using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace InterfacciaUtente
{
    public class TskReset
    {
        TskHwComunication tskHwComunication;
        GetStatus getStatus;

        public event EventHandler<string> SendMessageUser;

        public event EventHandler<string> AlarmEvent;
        public event EventHandler ResetAlarm;

        public bool IsNeverDone;

        public string PhaseReset;
        string MsgUser;
        public bool Started;
        bool finished;
        string WaitState = "";
        int waitMaxError = 1500;

        private Stopwatch TimeOut;
        Timer tmr;


        /*
            1) Close Voltage
            2) Close Air
            3) Request Open Door            
        */

        public void InitData(ref GetStatus _getStatus, ref TskHwComunication _tskHw)
        {
            getStatus = _getStatus;
            tskHwComunication = _tskHw;
        }


        //Costructor
        public TskReset()
        {
            IsNeverDone = false;
            tmr = new Timer();
            tmr.Interval = 200; 
            tmr.Enabled = false;
            tmr.Elapsed += Tmr_Elapsed;
            PhaseReset = "";
            Started = false;
            TimeOut = new Stopwatch();
            finished = true;
        }

        public bool Finish()
        {
            return finished;
        }

        //Switch on tsk
        public void SwitchOn()
        {
            IsNeverDone = true;
            WaitState = "eBegin";
            finished = false;
            Started = true;
            TimeOut.Start();
            tmr.Enabled = true;
        }

        //Switch off tsk
        public void SwitchOff()
        {
            tmr.Enabled = false;
            WaitState = "DoNothing";
            finished = true;
            Started = false;
            SendMessageUser.Invoke(this, "End Reset");
            if (getStatus.firstStart)
            {
                getStatus.firstStart = false;
            }
            TimeOut.Stop();
        }




        //Timer Elapsed
        private void Tmr_Elapsed(object sender, ElapsedEventArgs e)
        {
            tmr.Enabled = false;


            switch (WaitState)
            {
                case "eBegin":
                    ResetAlarm.Invoke(this, e);

                    MsgUser = "Resetting";
                    SendMessageUser.Invoke(this, MsgUser);
                    ChangeWaitState("Set Color");
                    break;

                case "Set Color":
                    if (getStatus.led)
                    {
                        tskHwComunication.StopVoltageRamp();
                        ChangeWaitState("wfStopRamp");
                        TimeOut.Restart();
                    }
                    break;


                case "wfStopRamp":
                    if (tskHwComunication.OtherMessage == "")
                    {
                        if (getStatus.Volt <= 1)
                        {
                            tskHwComunication.CloseAir();
                            ChangeWaitState("wfAirOff");
                            TimeOut.Restart();
                        }
                        else
                        {
                            if (TimeOut.ElapsedMilliseconds > waitMaxError)
                            {
                                SwitchOff();
                                AlarmEvent.Invoke(this, "EMERGENCY FOR VOLTAGE NOT CLOSE");
                                return;
                            }
                        }
                    }
                    else
                    {
                        if (TimeOut.ElapsedMilliseconds > waitMaxError)
                        {
                            SwitchOff();
                            AlarmEvent.Invoke(this, "EMERGENCY FOR VOLTAGE NOT CLOSED");
                            return;
                        }
                    }
                    break;

                case "wfAirOff":
                    if (tskHwComunication.OtherMessage == "")
                    {
                        if (!getStatus.StateAir)
                        {
                            ChangeWaitState("wfUpPiston");
                            tskHwComunication.OpenPiston();
                            TimeOut.Restart();
                        }
                        else
                        {
                            if (TimeOut.ElapsedMilliseconds > waitMaxError)
                            {
                                SwitchOff();
                                AlarmEvent.Invoke(this, "EMERGENCY FOR AIR NOT CLOSE");
                                return;
                            }
                        }
                    }
                    else
                    {

                        if (TimeOut.ElapsedMilliseconds > waitMaxError)
                        {
                            SwitchOff();
                            AlarmEvent.Invoke(this, "EMERGENCY FOR AIR NOT CLOSED");
                            return;
                        }
                    }
                    break;

                case "wfUpPiston":
                    if (tskHwComunication.OtherMessage == "")
                    {
                        if (getStatus.StatePistonUp)
                        {
                            SwitchOff();
                            return;
                        }
                        else
                        {
                            if (TimeOut.ElapsedMilliseconds > waitMaxError)
                            {
                                SwitchOff();
                                AlarmEvent.Invoke(this, "EMERGENCY FOR PISTON NOT UP");
                                return;
                            }
                        }
                    }
                    else
                    {
                        if (TimeOut.ElapsedMilliseconds > waitMaxError)
                        {
                            SwitchOff();
                            AlarmEvent.Invoke(this, "EMERGENCY FOR PISTON NOT UP");
                            return;
                        }
                    }
                    break;

               
                case "DoNothing":
                    SwitchOff();
                    return;
            }


            tmr.Enabled = true;
        }



        private void ChangeWaitState(string newWaitState)
        {
            WaitState = newWaitState;
        }

    }
}
