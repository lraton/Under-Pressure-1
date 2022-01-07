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

        string _STX = "\u0002";
        string _ETX = "\u0003";
        string _ACK = "\u0006";
        string _NAK = "\u0015";

        private string[] msgSplitted;

        private string WaitState = "";
        public string OtherMessage = "";
        private string msgToSend;


        public bool ManualMsgOk = true;

        public TskHwComunication()
        {

            msgToSend = "G";

            isDataRecived = false;

            tmrtsk = new Timer();
            tmrtsk.Enabled = false;
            tmrtsk.Interval = 15;
            tmrtsk.Elapsed += Tmrtsk_Elapsed;

            serial = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One);

        }

        //Init getstatus
        public void InitData(ref GetStatus _getStatus)
        {
            getStatus = _getStatus;
        }

        // Switch On this TAsk
        public void SwitchOn()
        {
            msgToSend = "G";
            OtherMessage = "";
            WaitState = "eBegin";

            serial.DataReceived += Serial_DataReceived;

            tmrtsk.Enabled = true;
        }

        // Switch Off this task
        public void SwitchOff()
        {
            OtherMessage = "";
            WaitState = "DoNothing";
            serial.DataReceived -= Serial_DataReceived;
            tmrtsk.Enabled = false;
        }

        //Status COM
        public bool IsComOpen()
        {
            return serial.IsOpen;
        }
        //Status this Task
        public bool IsTaskRunning()
        {
            return tmrtsk.Enabled;
        }

        // Open Com Port
        public void OpenComPort()
        {
            try
            {
                if (!serial.IsOpen)
                    serial.Open();
            }
            catch (Exception)
            {
                AlarmEvent.Invoke(this, "Connect to COM");
            }
        }

        // Close Com Port
        public void CloseComPort()
        {
            if (serial.IsOpen)
                serial.Close();
        }

        //Timer Task send message
        public void Tmrtsk_Elapsed(object sender, ElapsedEventArgs e)
        {
            tmrtsk.Enabled = false;

            switch (WaitState)
            {
                case "eBegin":
                    //Open COM
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


                    if (!serial.IsOpen)
                        return;

                    //Message to send
                    try
                    {
                        if (msgToSend == "G")
                        {
                            serial.Write(_STX + msgToSend + "\u0000" + "\u0000" + _ETX);
                            Console.WriteLine(_STX + msgToSend + "\u0000" + "\u0000" + _ETX);
                        }
                        else
                        {
                            serial.Write(_STX + msgToSend + _ETX);
                            Console.WriteLine(_STX + msgToSend + _ETX);
                        }
                    }
                    catch (Exception)
                    {   //If COm closed
                        OpenComPort();
                        break;
                    }

                    WaitState = "WaitForResponse";
                    break;


                case "WaitForResponse":
                    if (isDataRecived)//Wait to recived message
                    {
                        //Check if the message is correct
                        if (CheckMessageRecived(StrDataRecived))
                        {
                            if (msgToSend != "G")
                            {
                                OtherMessage = "";
                                ManualMsgOk = true;
                            }
                            else
                            {
                                HwInformationUpdatedEvent.Invoke(this, getStatus);
                            }
                            WaitState = "eBegin";
                        }
                        else
                        {
                            //Allarm User, the message is not correct
                            AlarmEvent(this, "Error message");
                            WaitState = "eBegin";
                            OtherMessage = "";
                        }
                    }
                    break;


                case "DoNothing":
                    break;
            }

            tmrtsk.Enabled = true;
        }

        //Message Recived
        private void Serial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            tmrtsk.Enabled = false;
            //Read Message
            StrDataRecived += serial.ReadExisting();

            if (CheckResponseCompleted(StrDataRecived))
            {   
                //If message is correct, print message in the console
                ResponseEvent.Invoke(this, "Response: " + StrDataRecived);
                isDataRecived = true;
            }
            tmrtsk.Enabled = true;
        }

        //Check into message STX and ETX
        private bool CheckResponseCompleted(string msgRecived)
        {
            //Search into message STX and ETX
            string msg = msgRecived;
            
            int x = msg.IndexOf(_STX);
            if (x < 0)
                return false; //If is not present STX
            
            int y = msg.IndexOf(_ETX);
            if (y < 0)
                return false;//If is not present ETX

            return true;
        }

        //Check Message Recived
        private bool CheckMessageRecived(string msgRecived)
        {

            //Search into message STX and ETX
            string msg = msgRecived;
            
            int x = msg.IndexOf(_STX);
            if (x < 0)
                return false;//If is not present STX

            int y = msg.IndexOf(_ETX);
            if (y < 0)
                return false;//If is not present ETX

            msg = msg.Remove(0, x + 1); //Remove STX

            msg = msg.Substring(0, y - 1);//Remove ETX


            msgSplitted = msg.Split('|');//Split message


            if (msgSplitted.Count() >= 2)
            {
                if (msgSplitted[1] == _ACK) //Check correct messsage 
                {
                   
                    if (msgToSend.Length != 0)
                    {
                        //Error if the answer is different that question 
                        if (msgSplitted[0] != msgToSend[0].ToString()) 
                        {
                            AlarmEvent.Invoke(this, "Wrong message");
                            return false;
                        }
                    }
                    else
                        return false;

                    //Unpack the message
                    switch (msgSplitted[0])
                    {
                        case "G":
                            try
                            {
                                ReadGetStatus();
                            }
                            catch (Exception)
                            {
                                //Error in the message
                                AlarmEvent.Invoke(this, "Error message");
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


                        case "L":
                            getStatus.led = true;
                            break;


                        default:
                            //Inusual message recived
                            AlarmEvent.Invoke(this, "Undefined message");
                            break;

                    }
                    isDataRecived = true;//Confirm reception message
                    return true;
                }
                else
                {
                    //Check is a problem with messsage 
                    if (msgSplitted[1] == _NAK)
                    {
                        AlarmEvent(this, "Received NAK");
                    }
                    return false;
                }
            }
            else
                return false;
        }



        //Read message "Get Status", saved paramater
        private void ReadGetStatus()
        {
            if (msgSplitted[2] == "1")
                getStatus.StateDoor = true;//Door close
            else
                getStatus.StateDoor = false;//Door open

            if (msgSplitted[3] == "1")
                getStatus.StateInjector = false;//Injector not present
            else
                getStatus.StateInjector = true;//Injector present

            if (msgSplitted[4] == "1")
                getStatus.StateStart = true;//Button start pressed
            else
                getStatus.StateStart = false;//Button start not pressed

            if (msgSplitted[5] == "1")
                getStatus.StateReset = true;//Button reset pressed
            else
                getStatus.StateReset = false;//Button reset not pressed

            if (msgSplitted[6] == "1")
                getStatus.StateEmergency = false;//Button Emergency not pressed
            else
                getStatus.StateEmergency = true;//Button Emergency pressed

            if (msgSplitted[7] == "1")
                getStatus.AutomaticSelector = false;//Selector in Manual
            else
                getStatus.AutomaticSelector = true;//Selector in Automatic

            //Calculate Flow l/m
                getStatus.Flow = (Convert.ToDouble(msgSplitted[8]) - 37) / 194;
                string app= getStatus.Flow.ToString();
                 if (app.Length > 4)
                 {
                 app = app.Substring(0, 4);
                 getStatus.Flow = Convert.ToDouble(app);
                 }

            if(getStatus.MaxFlow > 0)
            {
                //Set volt open
                if (getStatus.openVolt == 0)
                {
                    getStatus.openVolt = getStatus.Volt;
                }
            }
                        
            getStatus.Volt = Convert.ToInt32(msgSplitted[9]);//Value volt

            if (msgSplitted[10] == "1")
                getStatus.StateAir = true;//Air Open
            else
                getStatus.StateAir = false;//Air Close


            if (msgSplitted[11] == "1")
                getStatus.StatePistonUp = true;//Piston Up
            else
                getStatus.StatePistonUp = false;//Piston not Up


            if (msgSplitted[12] == "1")
                getStatus.StatePistonDown = true;//Piston Down
            else
                getStatus.StatePistonDown = false;//Piston not Down

        }


        //Set Led Color White
        public void SetColorWhite()
        {
            string msg = "L|W";
            SendOtherMessage(msg);
            getStatus.led = false;
        }

        //Set Led Color Green
        public void SetColorGreen()
        {
            string msg = "L|G";
            SendOtherMessage(msg);
            getStatus.led = false;
        }

        //Set Led Color Red
        public void SetColorRed()
        {
            string msg = "L|B";
            SendOtherMessage(msg);
            getStatus.led = false;
        }

        //Set Voltage
        public void SetVoltage(int voltage)
        {
            string msg = "V|";

            if (voltage < 10)
            {
                msg += voltage;
            }
            else
            {
                string app = "";
                switch (voltage)
                {
                    case 10:
                        app = "W";
                        break;

                    case 11:
                        app = "X";
                        break;

                    case 12:
                        app = "Y";
                        break;

                    default:
                        AlarmEvent.Invoke(this, "Error voltage to high");
                        return;
                }
                msg += app;
            }
            SendOtherMessage(msg);
        }

        //Send Message Close Air
        public void CloseAir()
        {
            string msg = "A|0";
            SendOtherMessage(msg);
        }

        //Send Message Open Air
        public void OpenAir()
        {
            string msg = "A|1";
            SendOtherMessage(msg);
        }

        //Send Message Start Ramp
        public void StartVoltageRamp()
        {
            string msg = "T|1";
            SendOtherMessage(msg);
        }

        //Send Message Stop Ramp
        public void StopVoltageRamp()
        {
            string msg = "T|0";
            SendOtherMessage(msg);
        }

        //Send Message Lower Piston
        public void ClosePiston()
        {
            string msg = "P|1";
            SendOtherMessage(msg);
        }

        //Send Message Upper Piston
        public void OpenPiston()
        {
            string msg = "P|0";
            SendOtherMessage(msg);
        }

        //Send Message Other Get Status
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
