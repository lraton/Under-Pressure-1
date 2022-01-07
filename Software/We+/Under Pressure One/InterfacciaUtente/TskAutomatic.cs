using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace InterfacciaUtente
{
    public class TskAutomatic
    {
        FormEmergency formEmergency;

        TskHwComunication tskHwComunication;
        GetStatus getStatus;

        public event EventHandler<string> SendMessageUser;
        public event EventHandler<string> AlarmEvent;

        Timer tmr;
        public bool Started;
        public string MessageOperator = "Open Door";
        public bool ConfirmConnected;
        string WaitState = "eBegin";


        private Stopwatch TimeOut;


        /* 
            1)Inserisci iniettore           VERIFICARE
            2)Collegare l'alimentazione
            3)Chiudere portella              VERIFICARE
            4)Premere i 2 pulsanti start


            5)Apri valvola aria      
         */




        public TskAutomatic()
        {
            tmr = new Timer();
            tmr.Interval = 400;
            tmr.Enabled = false;
            tmr.Elapsed += Tmr_Elapsed;

            TimeOut = new Stopwatch();

            Started = false;
            ConfirmConnected = false;
        }



        public void InitData( ref GetStatus _getStatus, ref TskHwComunication _tskHwComunication)
        {
            getStatus = _getStatus;
            tskHwComunication = _tskHwComunication;
        }



        //TICK DEL TIMER
        private void Tmr_Elapsed(object sender, ElapsedEventArgs e)
        {
            tmr.Enabled = false;

            


            if(Started)
            {
                if(!getStatus.StateDoor)
                {
                    SwitchOff();
                    AlarmEvent.Invoke(this, "EMERGENCY, THE DOOR IS OPEN");                    
                    return;
                }

                if (!getStatus.StateInjector)
                {
                    SwitchOff();
                    AlarmEvent.Invoke(this, "EMERGENCY, THERE ISN'T THE INJECTOR");
                    return;
                }
            } 




            //Switch message user for automatic
            switch (WaitState)
            {
                case "eBegin":
                    ChangeWaitState("Open Door");
                    SendMessageUser.Invoke(this, WaitState);
                    break;
                    
                case "Open Door":
                    if (!getStatus.StateDoor)
                    {
                        ChangeWaitState("Insert Injector");
                        SendMessageUser.Invoke(this, WaitState);
                    }
                    break;

                case "Insert Injector":
                    if (getStatus.StateInjector)
                    {
                        ChangeWaitState("wfConfirmVoltConnect");
                        SendMessageUser.Invoke(this, "Connect the voltage and press start");
                    }
                    break;

                case "wfConfirmVoltConnect":
                    if (getStatus.StateStart)
                    {
                        ChangeWaitState("Close Door");
                        SendMessageUser.Invoke(this, WaitState);
                    }
                    break;

                case "Close Door":
                    if (getStatus.StateDoor)
                    {
                        ChangeWaitState("Press start for begin test");
                        SendMessageUser.Invoke(this, WaitState);
                    }
                    break;

                case "Press start for begin test":
                    if (getStatus.StateStart)
                    {
                        ChangeWaitState("StartTest");
                        SendMessageUser.Invoke(this, "Execution");
                    }
                    break;


               //START TEST
                case "StartTest":
                    Started = true;

                    tskHwComunication.ClosePiston();
                    ChangeWaitState("ClosePiston");
                    SendMessageUser.Invoke(this, "Execution");
                    break;


                case "ClosePiston":
                    if (getStatus.StatePistonUp)
                    {
                        tskHwComunication.OpenAir();
                        ChangeWaitState("OpenAir");
                    }
                    break;


                        
                case "OpenAir":
                    if (getStatus.StateAir)
                    {

                        tskHwComunication.StartVoltageRamp();
                        ChangeWaitState("wfRampStarted");
                    }
                    break;



                case "wfRampStarted":
                    if (getStatus.Volt >= 1)
                    {
                        ChangeWaitState("wfRampFinished");
                    }
                    break;



                case "wfRampFinished":
                    if (getStatus.Volt >= 11.9)
                    {
                        tskHwComunication.SetVoltage(0);
                        ChangeWaitState("wfVoltageZero");
                        Started = false;
                    }
                    break;



                case "wfVoltageZero":
                    if (getStatus.Volt <=0.5)
                    {
                        tskHwComunication.CloseAir();
                        ChangeWaitState("wfAirClosed");
                    }
                    break;

                case "wfAirClosed":
                    if (!getStatus.StateAir)
                    {
                        tskHwComunication.OpenPiston();
                        ChangeWaitState("wfOpenPiston");
                    }
                    break;
                    
                    

                case "wfOpenPiston":
                    if (!getStatus.StatePistonUp)
                    {
                        ChangeWaitState("wfCylResetted");
                    }
                    break;




                case "wfCylResetted":
                    if (!getStatus.StatePistonUp)
                    {
                        //mando messaggio operatore
                        SendMessageUser.Invoke(this, "Press start for new test or open door and remove the injector");
                        ChangeWaitState("CheckOperatorChoise");
                    }
                    break;



                case "CheckOperatorChoise":                    
                    if (getStatus.StateStart)
                    {
                        ChangeWaitState("StartTest");
                        //qua salto sul passo dove controllo che la porta sia chiusa prima di muovere il cilindro basso
                    }
                    else
                    { 
                        //if la portella è aperta
                        if(!getStatus.StateDoor)
                        {
                            ChangeWaitState("Remove Injector");
                            //quà vado sul passo che chiedo di inserire l'iniettore e collegare il cablaggio elettrico.
                        }
                    }
                    break;



                case "Remove Injector":
                    SendMessageUser.Invoke(this, "Remove Injector");
                    if (!getStatus.StateInjector)
                    {
                        ChangeWaitState("End Test");
                    }
                    break;


                case "End Test":
                    SendMessageUser.Invoke(this, "End Test");
                    ChangeWaitState("eBegin");
                    break;



                case "DoNothing":
                    break;
            }
            
            tmr.Enabled = true;
        }


                
        //START TSK AUTOMATIC
        public void SwitchOn()
        {
            ChangeWaitState("eBegin");
            tmr.Enabled = true;            
        }


        //STOP TSK AUTOMATIC 
        public void SwitchOff()
        {
            tmr.Enabled = false;
            Started = false;
            ChangeWaitState("DoNothing");
        }


        private void ChangeWaitState(string newWaitState)
        {
            WaitState = newWaitState;
        }
        
        public bool Testing()
        {
            return Started;
        }


    }
}
