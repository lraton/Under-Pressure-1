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
        TskHwComunication TskHwComunication;
        GetStatus getStatus;
        FormAutomatic formAutomatic;
        FormMain formMain;
        FormManual formManual;

        public event EventHandler<string> SendMessageUser;
        public event EventHandler<string> AlarmEvent;

        public string PhaseReset;
        string MsgUser;
        public bool Started;
        string WaitState = "";

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
            TskHwComunication = _tskHw;
        }


        //COSTRUTTORE
        public TskReset()
        {
            
            tmr = new Timer();
            tmr.Interval = 300;
            tmr.Enabled = false;
            tmr.Elapsed += Tmr_Elapsed;
            PhaseReset = "";
            Started = false;
            TimeOut = new Stopwatch();
        }



        public void SwitchOn()
        {
            tmr.Enabled = true;
            Started = true;
            WaitState = "eBegin";
        }


        public void SwitchOff()
        {
            tmr.Enabled = false;
            Started = false;
        }



        //TICK DEL TIMER
        private void Tmr_Elapsed(object sender, ElapsedEventArgs e)
        {
            tmr.Enabled = false;


            switch (WaitState)
            {
                case "eBegin":
                    MsgUser = "Resetting";
                    SendMessageUser.Invoke(this, MsgUser);
                    TskHwComunication.SetVoltage(0);
                    ChangeWaitState("wfZeroVoltage");
                    TimeOut.Restart();
                    break;


                case "wfZeroVoltage":
                    if (getStatus.Volt <= 1)
                    {
                        TskHwComunication.CloseAir();
                        ChangeWaitState("wfAirOff");
                        TimeOut.Restart();
                    }
                    else
                        if (TimeOut.ElapsedMilliseconds > 5000)
                    {
                        SwitchOff();
                        AlarmEvent.Invoke(this, "EMERGENCY FOR VOLTAGE NOT CLOSED");
                    }
                    break;

                case "wfAirOff":
                    if (!getStatus.StateAir)
                    {
                        ChangeWaitState("wfUpPiston");
                        TskHwComunication.OpenPiston();
                        TimeOut.Restart();
                    }
                    else
                    {
                        if (TimeOut.ElapsedMilliseconds > 5000)
                        {
                            SwitchOff();
                            AlarmEvent.Invoke(this, "EMERGENCY FOR AIR NOT CLOSED");
                        }
                    }
                    break;

                case "wfUpPiston":
                    if (!getStatus.StatePistonUp)
                    {
                        if (getStatus.StateInjector)
                        {
                            MsgUser = "Open door";
                            SendMessageUser.Invoke(this, MsgUser);
                            ChangeWaitState("wfDoorOpen");
                            TimeOut.Restart();
                        }
                        else
                        {
                            MsgUser = "Reset finished";
                            SendMessageUser.Invoke(this, MsgUser);

                            if (formAutomatic != null)
                            {
                                formAutomatic.Close();
                            }
                            else
                            {
                                if (formManual != null)
                                {
                                    formManual.Close();
                                }
                            }

                            ChangeWaitState("DoNothing");
                            SwitchOff();
                        }
                    }
                    else
                    {
                        if (TimeOut.ElapsedMilliseconds > 5000)
                        {
                            SwitchOff();
                            AlarmEvent.Invoke(this, "EMERGENCY FOR PISTON NOT UP");
                        }
                    }
                    break;


                case "wfDoorOpen":
                    if (!getStatus.StateDoor)
                    {
                        MsgUser = "Remove the injector";
                        SendMessageUser.Invoke(this, MsgUser);
                        ChangeWaitState("wfRemoveInj");
                    }
                    break;

                case "wfRemoveInj":
                    if (!getStatus.StateInjector) {
                        MsgUser = "Close door";
                        SendMessageUser.Invoke(this, MsgUser);
                        ChangeWaitState("wfDoorClose");
                    }
                    break;

                case "wfDoorClose":
                    if (getStatus.StateDoor)
                    {
                        MsgUser = "Reset finished";
                        SendMessageUser.Invoke(this, MsgUser);

                        ChangeWaitState("DoNothing");
                    }
                    break;

                case "DoNothing":
                    break;
            }


            tmr.Enabled = true;
        }



        private void ChangeWaitState(string newWaitState)
        {
            WaitState = newWaitState;
        }

    }
}
