using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace InterfacciaUtente
{
   public class TskHwComunication
    {
        public event EventHandler<GetStatus> HwInformationUpdatedEvent;

        public event EventHandler<string> AlarmEvent;
        public event EventHandler ResetAlarm;
        public event EventHandler<string> ResponseEvent;
        GetStatus getStatus;        

        private SerialPort serial;
        private string StrDataRecived;
        private Timer tmrtsk;
        bool isDataRecived;

        string msg = "\u0002|G|\u0006|0|0|0|0|0|1|10|10|0|0|0\u0003";
        string _STX = "\u0002";
        string _ETX = "\u0003";
        string _ACK = "\u0006";

        private string[] msgSplitted;

        private string WaitState = "";
        private string OtherMessage = "";
        private string msgToSend;


        public bool ManualMsgOk = true;



        public TskHwComunication()
        {

            msgToSend = "G";

            isDataRecived = false;
            tmrtsk = new Timer();
            tmrtsk.Interval =100;
            tmrtsk.Enabled = false;
            tmrtsk.Elapsed += Tmrtsk_Elapsed;
            serial = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One);
            
        }


        public void InitData(ref GetStatus _getStatus)
        {
            getStatus = _getStatus;
        }

        /// <summary>
        /// Switch On della task
        /// </summary>
        public void SwitchOn()
        {
            msgToSend = "G";
            OtherMessage = "";
            WaitState = "eBegin";

            serial.DataReceived += Serial_DataReceived;

            tmrtsk.Enabled = true;
        }

        /// <summary>
        /// Switch Off della task
        /// </summary>
        public void SwitchOff()
        {
            OtherMessage = "";
            WaitState = "DoNothing";

            serial.DataReceived -= Serial_DataReceived;


            tmrtsk.Enabled = false;
        }

        public bool IsComOpen()
        {
            return serial.IsOpen;
        }
        public bool IsTaskRunning()
        {
            return tmrtsk.Enabled;
        }

        /// <summary>
        /// Open Com Port
        /// </summary>
        public void OpenComPort()
        {
            if (!serial.IsOpen)
            {
                try
                {
                    serial.Open();
                }
                catch (Exception)
                {

                    AlarmEvent.Invoke(this, "Collegati alla COM scemo");
                }
               
            }
        }
        /// <summary>
        /// Close Com Port
        /// </summary>
        public void CloseComPort()
        {
            if (serial.IsOpen)
                serial.Close();
        }






        //Timer Task send
        public void Tmrtsk_Elapsed(object sender, ElapsedEventArgs e)
        {
            tmrtsk.Enabled = false;

            switch (WaitState)
            {
                case "eBegin":
                    //apro seriale               
                    OpenComPort();
                    WaitState = "SayToElectronic";                        
                    
                    break;


                case "SayToElectronic":
                    StrDataRecived = "";
                    isDataRecived = false;
                    ResponseEvent.Invoke(this, "");

                    if (OtherMessage != "")
                        msgToSend = OtherMessage;
                    else
                        msgToSend = "G";


                    if (msgToSend == "G")
                    {
                        serial.Write(_STX + msgToSend + "\u0000" + "\u0000"+ _ETX );
                        Console.WriteLine(_STX + msgToSend + "\u0000" + "\u0000" + _ETX);
                    }
                    else
                    {
                        serial.Write(_STX + msgToSend + _ETX);
                        Console.WriteLine(_STX + msgToSend + _ETX);
                    }


                    WaitState = "WaitForResponse";
                    break;



                case "WaitForResponse":
                    if (isDataRecived)//aspetto che ci sia stata una risposta
                    {

                        //ora controllo che la risposta ricevuta sia coerente
                        if (CheckMessageRecived(StrDataRecived))
                        {
                            if (msgToSend != "G")
                            {
                                OtherMessage = "";
                                ManualMsgOk = true;
                            }
                            else
                                HwInformationUpdatedEvent.Invoke(this, getStatus);

                            WaitState = "eBegin";
                        }
                        else
                        {
                            //Allarme Utente Con Evento
                            SwitchOff();
                            AlarmEvent(this, "Received NAk");
                            tmrtsk.Enabled = false;

                        }
                    }
                    break;



                case "DoNothing":
                    break;
            }


            tmrtsk.Enabled = true;

        }

        //task recive
        private void Serial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            tmrtsk.Enabled = false;

                StrDataRecived += serial.ReadExisting();
                //Console.WriteLine("Responce: " + StrDataRecived);

                if (CheckResponseCompleted(StrDataRecived))
                {
                    ResponseEvent.Invoke(this, "Response: " + StrDataRecived);
                    isDataRecived = true;
                }


            tmrtsk.Enabled = true;
        }

        private bool CheckResponseCompleted(string msgRecived)
        {
            //Controllo STX ed ETX
            string msg = msgRecived;


            int x = msg.IndexOf(_STX);

            if (x < 0)
                return false;


            int y = msg.IndexOf(_ETX);
            if (y < 0)
                return false;

            return true;

        }


        //CHECK MESSAGE RECIVED
        private bool CheckMessageRecived(string msgRecived)
        {

            //Controllo STX ed ETX
            string msg = msgRecived;


            int x = msg.IndexOf(_STX);

            if (x < 0)
                return false;


            int y = msg.IndexOf(_ETX);
            if (y < 0)
                return false;


            msg = msg.Remove(0, x + 1); //Questo rimuove STX

            msg = msg.Substring(0, y - 1);    //Rimuove ETX


            msgSplitted = msg.Split('|');


            if (msgSplitted.Count() >= 2)
            {
                //questa è la risposta al Get Status
                if (msgSplitted[1] == _ACK)
                {
                    //MESSAGGIO DI ERRORE SE ELETTRONICI RISPONDONO DIVERSO DALLA DOMANDA
                    if (msgToSend.Length != 0)
                    {
                        if (msgSplitted[0] != msgToSend[0].ToString())
                        {
                            SwitchOff();
                            AlarmEvent.Invoke(this, "Dammi la risposta giusta");
                            return false;
                        }
                    }
                    else
                        return false;

                    //ALTRIMENTI SPACCHETTAMENTO DEL MESSAGGIO
                    switch (msgSplitted[0])
                    {
                        case "G":
                            try
                            {
                                ReadGetStatus();
                            }
                            catch (Exception)
                            {
                                //Scatena allarme
                                SwitchOff();
                                AlarmEvent.Invoke(this, "Gli elettronici hanno scritto male il Get Status");
                            }
                            break;


                        case "V":

                            break;

                        case "A":

                            break;

                        case "T":

                            break;

                        case "P":

                            break;


                        default:
                            //SCATENARE EVENTO ALLARME
                            SwitchOff();
                            AlarmEvent.Invoke(this, "Dammi la risposta giusta");
                            break;

                    }

                    isDataRecived = true;
                    return true;

                }
                else
                    return false;
            }
            else
                return false;
        }



        //READ GET STATUS
        private void ReadGetStatus()
        {
            if (msgSplitted[2] == "1")
                getStatus.StateDoor = true;
            else
                getStatus.StateDoor = false;

            if (msgSplitted[3] == "1")
                getStatus.StateInjector = true;
            else
                getStatus.StateInjector = false;

            if (msgSplitted[4] == "1")
                getStatus.StateStart = true;
            else
                getStatus.StateStart = false;

            if (msgSplitted[5] == "1")
                getStatus.StateReset = true;
            else
                getStatus.StateReset = false;

            if (msgSplitted[6] == "1")
                getStatus.StateEmergency = true;
            else
                getStatus.StateEmergency = false;

            if (msgSplitted[7] == "1")
                getStatus.AutomaticSelector = true;
            else
                getStatus.AutomaticSelector = false;

            getStatus.Flux = Convert.ToDouble(msgSplitted[8]) /10;
            getStatus.Volt =Convert.ToInt32(msgSplitted[9]);
            
            if (msgSplitted[10] == "1")
                getStatus.StateAir = true;
            else
                getStatus.StateAir = false;


            if (msgSplitted[11] == "1")
                getStatus.StatePistonUp = true;
            else
                getStatus.StatePistonUp = false;


            if (msgSplitted[12] == "1")
                getStatus.StatePistonDown = true;
            else
                getStatus.StatePistonDown = false;

        }



        //Set Voltage
        public void SetVoltage(int voltage)
        {
            string msg = "V|" + voltage;
            SendOtherMessage(msg);
        }


        //Close Air
        public void CloseAir()
        {
            string msg = "A|0";
            SendOtherMessage(msg);
        }



        //Open Air
        public void OpenAir()
        {
            string msg = "A|1";
            SendOtherMessage(msg);
        }


        //START RAMPA
        public void StartVoltageRamp()
        {
            string msg = "T|1";
            SendOtherMessage(msg);
        }

        //STOP RAMPA
        public void StopVoltageRamp()
        {
            string msg = "T|0";
            SendOtherMessage(msg);
        }

        //LOWER PISTON
        public void ClosePiston()
        {
            string msg = "P|1";
            SendOtherMessage(msg);
        }

        //UPPER PISTON
        public void OpenPiston()
        {
            string msg = "P|0";
            SendOtherMessage(msg);
        }



        public bool SendOtherMessage(string msg)
        {
            if (OtherMessage == "")
            {
                if (msg == null)
                {
                    msg = "";
                    ManualMsgOk = true;
                }
                else
                {
                    ManualMsgOk = false;
                }
                OtherMessage = msg;
                return true;
            }
            else
                return false;
        }

        public bool IsOff()
        {
            return !tmrtsk.Enabled;
        }

        public bool GetSerialStatus()
        {
            return serial.IsOpen;
        }

    }
}
