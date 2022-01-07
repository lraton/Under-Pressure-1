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
        TskStop tskStop;

        public event EventHandler<string> SendMessageUser;
        public event EventHandler<string> AlarmEvent;
        public event EventHandler StopAll;

        Timer tmr;
        bool Started;
        bool TskOn;
        bool is_open;
        public string MessageOperator = "Open Door";
        public bool ConfirmConnected;
        string WaitState = "eBegin";
        public bool StopCharts;

        private Stopwatch TimeOut;

        private int WaitMax = 3000;
      
        public TskAutomatic()
        {
            StopCharts = false;
            tmr = new Timer();
            tmr.Interval = 250;
            tmr.Enabled = false;
            tmr.Elapsed += Tmr_Elapsed;

            TimeOut = new Stopwatch();
            is_open = false;
            Started = false;
            ConfirmConnected = false;
        }



        public void InitData(ref GetStatus _getStatus, ref TskHwComunication _tskHwComunication, ref TskStop _tskStop)
        {
            getStatus = _getStatus;
            tskHwComunication = _tskHwComunication;
            tskStop = _tskStop;
        }



        //Timer Elapsed
        private void Tmr_Elapsed(object sender, ElapsedEventArgs e)
        {
            tmr.Enabled = false;

            if (Started)
            {
                if (!getStatus.StateDoor)
                {
                    SwitchOff();
                    tskStop.SwitchOn();
                    Stop_Charts();
                    //StopAll.Invoke(this, e);
                    AlarmEvent.Invoke(this, "THE DOOR IS OPEN");
                    
                    return;
                }

                if (!getStatus.StateInjector)
                {
                    SwitchOff();
                    Stop_Charts();
                    AlarmEvent.Invoke(this, "THERE ISN'T THE INJECTOR");                    
                    return;
                }
            }



            Console.Write(WaitState);
            //Switch message user for automatic
            switch (WaitState)
            {
                case "eBegin":
                    Start_Charts();
                    if (getStatus.StatePistonDown || getStatus.StateAir || getStatus.Volt >= 1 || getStatus.firstStart)
                    {
                        SendMessageUser.Invoke(this, "Press Reset");
                    }
                    else
                    {
                        ChangeWaitState("presStart");
                        SendMessageUser.Invoke(this, "Press start to begin");
                    }
                    break;

                case "presStart":
                    if (getStatus.StateStart)
                    {
                        ChangeWaitState("Open Door");
                        SendMessageUser.Invoke(this, WaitState);
                    }
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
                        SendMessageUser.Invoke(this, "Start Test");
                    }
                    break;


                //Start Test
                case "StartTest":
                    Started = true;
                    if (!getStatus.StatePistonDown && getStatus.StatePistonUp && getStatus.led)
                    {
                        tskHwComunication.ClosePiston();
                        ChangeWaitState("ClosePiston");
                        SendMessageUser.Invoke(this, "Wait to piston down");
                    }
                    TimeOut.Restart();
                    break;


                case "ClosePiston":
                    if (getStatus.StatePistonDown && !getStatus.StatePistonUp)
                    {
                        if (!getStatus.StateAir)
                        {
                            tskHwComunication.OpenAir();
                        }
                        ChangeWaitState("OpenAir");
                        SendMessageUser.Invoke(this, "Wait to air open");
                        TimeOut.Restart();
                    }
                    else
                    {
                        if (TimeOut.ElapsedMilliseconds > WaitMax)
                        {
                            AlarmEvent.Invoke(this, "Piston is blocked");
                            SwitchOff();
                        }
                    }
                    break;



                case "OpenAir":
                    if (getStatus.StateAir)
                    {
                        if (getStatus.Volt <= 1)
                        {
                            tskHwComunication.StartVoltageRamp();
                        }
                        ChangeWaitState("wfRampStarted");
                        SendMessageUser.Invoke(this, "Wait to ramp start");
                        TimeOut.Restart();
                    }
                    else
                    {
                        if (TimeOut.ElapsedMilliseconds > WaitMax)
                        {
                            AlarmEvent.Invoke(this, "Solenoid is blocked");
                            SwitchOff();
                        }
                    }
                    break;



                case "wfRampStarted":

                    if (getStatus.Volt >= 1)
                    {
                        ChangeWaitState("Set Color");
                        SendMessageUser.Invoke(this, "Wait to ramp finish");
                        TimeOut.Restart();
                    }
                    else
                    {
                        if (TimeOut.ElapsedMilliseconds > WaitMax)
                        {
                            AlarmEvent.Invoke(this, "No passage of voltage");
                            SwitchOff();
                        }
                    }
                    break;



                case "Set Color":
                    if (getStatus.Volt >= 11.9)
                    {
                        if (getStatus.Flow >= getStatus.minValueFlow)
                        {
                            tskHwComunication.SetColorGreen();
                            getStatus.successTest = 1;
                        }
                        else
                        {
                            tskHwComunication.SetColorRed();
                            getStatus.successTest = -1;
                        }
                        getStatus.led = false;
                        ChangeWaitState("wfRampFinished");

                    }
                    break;


                case "wfRampFinished":
                    if (getStatus.led)
                    {
                        tskHwComunication.StopVoltageRamp();
                        ChangeWaitState("wfVoltageZero");
                        TimeOut.Restart();
                        SendMessageUser.Invoke(this, "Wait to stop ramp");
                    }

                    break;



                case "wfVoltageZero":
                    if (getStatus.Volt <= 0.5)
                    {
                        Stop_Charts();
                        tskHwComunication.CloseAir();
                        ChangeWaitState("wfAirClosed");
                        SendMessageUser.Invoke(this, "Wait to close air");
                        TimeOut.Restart();
                    }
                    else
                    {
                        if (TimeOut.ElapsedMilliseconds > WaitMax)
                        {
                            AlarmEvent.Invoke(this, "Voltage not close");
                            SwitchOff();
                        }
                    }
                    break;

                case "wfAirClosed":
                    if (!getStatus.StateAir)
                    {
                        tskHwComunication.OpenPiston();
                        ChangeWaitState("wfOpenPiston");
                        SendMessageUser.Invoke(this, "Wait to piston go up");
                        TimeOut.Restart();
                    }
                    else
                    {
                        if (TimeOut.ElapsedMilliseconds > WaitMax)
                        {
                            AlarmEvent.Invoke(this, "Solenoid valve not closed");
                            SwitchOff();
                        }
                    }
                    break;

                //Test finished
                case "wfOpenPiston":
                    if (getStatus.StatePistonUp && !getStatus.StatePistonDown)
                    {
                        //Send message to Operator
                        Started = false;
                        SendMessageUser.Invoke(this, "Press start for new test or open door and remove the injector");
                        ChangeWaitState("CheckOperatorChoise");
                        TimeOut.Restart();
                    }
                    else
                    {
                        if (TimeOut.ElapsedMilliseconds > WaitMax)
                        {
                            AlarmEvent.Invoke(this, "Piston is blocked");
                            SwitchOff();
                        }
                    }
                    break;



                case "CheckOperatorChoise":
                    if (getStatus.StateStart)
                    {
                        Start_Charts();
                        ChangeWaitState("StartTest");
                        tskHwComunication.SetColorWhite();
                        getStatus.MaxFlow = 0;
                        getStatus.successTest = 0;
                        getStatus.led = false;
                        getStatus.MaxFlow = 0;
                        getStatus.openVolt = 0;
                        //Jump over close door control before move cylinder down
                    }
                    else
                    {
                        //Check door is open
                        if (!getStatus.StateDoor)
                        {
                            getStatus.MaxFlow = 0;
                            Start_Charts();
                            tskHwComunication.SetColorWhite();
                            getStatus.successTest = 0;
                            getStatus.led = false;
                            getStatus.MaxFlow = 0;
                            getStatus.openVolt = 0;
                            ChangeWaitState("Remove volt plug");
                            SendMessageUser.Invoke(this, "Unplug the volt cable and press start");
                            //quà vado sul passo che chiedo togliere la corrente e premere start
                           
                        }
                    }
                    break;

                case "Remove volt plug":
                    if (getStatus.StateStart)
                    {
                        ChangeWaitState("Remove Injector");
                        SendMessageUser.Invoke(this, "Remove the injector");
                    }
                    break;

                case "Remove Injector":
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
            //tskHwComunication.SetColorWhite();
            WaitState = "eBegin";
            tmr.Interval = getStatus.autoVelocity;
            is_open = true;
            TskOn = true;
            tmr.Enabled = true;
        }



        //STOP TSK AUTOMATIC 
        public void SwitchOff()
        {
            WaitState = "DoNothing";
            tmr.Enabled = false;
            TskOn = false;
            is_open = false;
            Started = false;
        }


        private void ChangeWaitState(string newWaitState)
        {
            WaitState = newWaitState;
        }


        public bool Testing()
        {
            return Started;
        }

        public bool isOpen()
        {
            return is_open;
        }

        public void Stop_Charts()
        {
            StopCharts = true;            
        }

        public void Start_Charts()
        {
            StopCharts = false;
        }



        public bool Tsk_On()
        {
            return TskOn;
        }


    }
}
