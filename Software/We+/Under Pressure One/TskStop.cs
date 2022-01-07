using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace InterfacciaUtente
{
    public class TskStop
    {
        GetStatus getStatus;
        TskHwComunication tskHwComunication;
        public event EventHandler CloseAll;

        bool Finish;
        bool Start;
        bool End_Program;

        Timer tmr;
        string WaitState = "";
        public TskStop()
        {
            End_Program = false;
            Finish = true;
            Start = false;
            tmr = new Timer();
            tmr.Enabled = false;
            tmr.Interval = 20;
            tmr.Elapsed += Tmr_Elapsed;
        }

        private void Tmr_Elapsed(object sender, ElapsedEventArgs e)
        {
            tmr.Enabled = false;

            switch (WaitState)
            {
                case "eBegin":
                    
                    if (getStatus.StateAir)
                    {
                        if (getStatus.led)
                        {
                            tskHwComunication.CloseAir();
                            WaitState = "wfCloseAir";
                        }
                    }
                    else
                    {
                        WaitState = "CloseVoltage";
                    }
                    break;

                case "wfCloseAir":
                    if (!getStatus.StateAir)
                    {
                        WaitState = "CloseVoltage";
                    }
                    break;

                case "CloseVoltage":
                    if (getStatus.Volt >= 1)
                    {
                        tskHwComunication.SetVoltage(0);
                        WaitState = "wfCloseVoltage";
                    }
                    else
                    {
                        WaitState = "End";
                    }
                    break;

                case "wfCloseVoltage":
                    if (getStatus.Volt <= 1)
                    {
                        if (End_Program)
                        {
                            WaitState = "Set Color White";
                        }
                        else
                        {
                            WaitState = "End";
                        }
                    }
                    break;


                case "Set Color White":
                    tskHwComunication.SetColorWhite();
                    WaitState = "End";
                    break;


                case "End": 
                    if(getStatus.led)
                    {
                        SwitchOff();
                        WaitState = "doNothing";
                        return;
                    }
                    break;


                case "doNothing":
                    break;
            }

            


            tmr.Enabled = true;
        }

        public void InitData(ref GetStatus _getStatus, ref TskHwComunication _tskHw)
        {
            getStatus = _getStatus;
            tskHwComunication = _tskHw;
        }

        public void SwitchOn()
        {
            Finish = false;
            Start = true;
            tmr.Enabled = true;
            WaitState = "eBegin";
        }

        public void SwitchOff()
        {
            Finish = true;
            Start = false;
            tmr.Enabled = false;
            WaitState = "doNothing";

            if(End_Program)
            {
                CloseAll.Invoke(this, null);
            }

        }
        public void EndProgram()
        {
            End_Program = true;
        }

    }
}
