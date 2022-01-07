using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacciaUtente
{
    public partial class FormMain : Form
    {
        FormAutomatic formAutomatic = null;
        FormManual formManual;
        FormError formError;
        FormEmergency formEmergency;
        FormTestPlan formTestPlan;

        TskReset tskReset;
        GetStatus getStatus;
        TskHwComunication tskHwComunication;
        TskAutomatic tskAutomatic;
        TskStop tskStop;

        public FormMain()
        {
            InitTskData();
            tskHwComunication.SwitchOn();
            InitializeComponent();

        }

        //initialize data
        private void InitTskData()
        {
            //Istance class
            formEmergency = new FormEmergency();
            formError = new FormError();

            getStatus = new GetStatus();

            tskHwComunication = new TskHwComunication();
            tskStop = new TskStop();           
            tskReset = new TskReset();
            tskAutomatic = new TskAutomatic();

            tskAutomatic.StopAll += TskAutomatic_StopAll;

            //Referiment data
            tskHwComunication.InitData(ref getStatus);
            tskReset.InitData(ref getStatus, ref tskHwComunication);
            tskStop.InitData(ref getStatus, ref tskHwComunication);
            
            //Event
            tskHwComunication.HwInformationUpdatedEvent += HwInformationUpdatedEvent;
            tskHwComunication.AlarmEvent += AlarmEvent;
            tskHwComunication.ResponseEvent += TskHwComunication_ResponseEvent;

            tskReset.AlarmEvent += TskReset_AlarmEvent;
            tskReset.SendMessageUser += TskReset_SendMessageUser;
            tskReset.ResetAlarm += TskReset_ResetAlarm;

            tskStop.CloseAll += CloseAll;
        }
        


        //End program
        private void CloseAll(object sender, EventArgs e)
        {
            if (!InvokeRequired)
            {
                Close();
            }
            else
            {
                BeginInvoke(new EventHandler(CloseAll), sender, e);
            }
        }

        //Stop task automatic
        private void TskAutomatic_StopAll(object sender, EventArgs e)
        {
            if (!InvokeRequired)
            {
                tskStop.SwitchOn();
            }
            else
            {
                BeginInvoke(new EventHandler(TskAutomatic_StopAll), sender, e);
            }
        }

        //Print Message user
        public void WriteInLabelMessageUser(string message)
        {
            LblMsgUser.Text = message;
        }

        //Message user for the task reset
        private void TskReset_SendMessageUser(object sender, string e)
        {
            if (!InvokeRequired)
            {
                SelectFormToWrite(e);
            }
            else
            {
                BeginInvoke(new EventHandler<string>(TskReset_SendMessageUser), sender, e);
            }
        }


        //scrive a una delle 3 form nella label per messaggio utente
        public void SelectFormToWrite(string message)
        {
            

            if(formAutomatic == null && formManual == null)
            {
                WriteInLabelMessageUser(message);
            }
            else
            {
                if (formAutomatic != null)
                {
                    formAutomatic.WriteInLabelMessageUser(message);
                }
                if (formManual != null)
                {
                    formManual.WriteInLabelMessageUser(message);
                }
            }
                        
        }

        //Reset led and led
        private void TskReset_ResetAlarm(object sender, EventArgs e)
        {
            if (!InvokeRequired)
            {
                tskHwComunication.SetColorWhite();

                if (formError == null)
                    return;

                formError.ResetError();
            }
            else
            {
                BeginInvoke(new EventHandler(TskReset_ResetAlarm), sender, e);
            }
        }

        //stampo quello che ricevo dalla seriale
        private void TskHwComunication_ResponseEvent(object sender, string e)
        {
            if (!InvokeRequired)
            {
                if (e != "") { }
                Console.WriteLine(e);
            }
            else
            {
                BeginInvoke(new EventHandler<string>(TskHwComunication_ResponseEvent), sender, e);
            }
        }

        //Allarm task automatic
        private void TskAutomatic_AlarmEvent(object sender, string e)
        {
            if (!InvokeRequired)
            {
                ALARM(e);
            }
            else
            {
                BeginInvoke(new EventHandler<string>(AlarmEvent), sender, e);
            }
        }

        //Alarm task reset
        private void TskReset_AlarmEvent(object sender, string e)
        {
            if (!InvokeRequired)
            {
                ALARM(e);
            }
            else
            {
                BeginInvoke(new EventHandler<string>(AlarmEvent), sender, e);
            }
        }

        //Alarm task communication
        private void AlarmEvent(object sender, string e)
        {
            if (!InvokeRequired)
            {
                ALARM(e);
            }
            else
            {
                BeginInvoke(new EventHandler<string>(AlarmEvent), sender, e);
            }
        }


        private void ALARM(string e)
        {
            tskHwComunication.SetColorRed();
            formError.AddError(e);
            if (!formError.Is_Open())
            {
                formError.Show();
            }
        }



        //Enable btnautmatic/manual
        private void HwInformationUpdatedEvent(object sender, GetStatus e)
        {          

            if (!InvokeRequired)
            {
                //Reset Error
                if (getStatus.StateReset && formError.Is_Open())
                {
                    formError.ResetError();
                }

                if (getStatus.AutomaticSelector)
                {
                    btnAutomatic.Enabled = true;
                    btnManual.Enabled = false;
                }
                else
                {
                    btnAutomatic.Enabled = false;
                    btnManual.Enabled = true;
                }


                if (formAutomatic != null)
                {
                    formAutomatic.diagnosticRefresh();
                }
                if (formManual != null)
                {
                    formManual.diagnosticRefresh();
                }


            }
            else
            {
                BeginInvoke(new EventHandler<GetStatus>(HwInformationUpdatedEvent), sender, e);
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        //Update the clock
        private void tmrClock_Tick_1(object sender, EventArgs e)
        {
            clock.Text = DateTime.Now.ToString("HH:mm:ss");

            //if EMERGENCY is pressed
            if ((getStatus.StateEmergency) && (!getStatus.EmergencyIsOpen))
            {

                formEmergency.InitData(ref getStatus, ref tskHwComunication, ref tskReset);
                formEmergency.ShowDialog();
            }


            if (LblMsgUser.Text == "End Reset")
            {
                LblMsgUser.Text = "Set Automatic/Manual";
            }

        }

        //Set the automatic mode
        private void btnAutomatic_Click(object sender, EventArgs e)
        {
            formAutomatic = new FormAutomatic();
            formAutomatic.InitData(ref tskHwComunication, ref getStatus, ref tskReset, ref formError, ref tskStop);
            formAutomatic.diagnosticRefresh();
            formAutomatic.Show();
        }

        //Set manual mode
        private void btnManual_Click(object sender, EventArgs e)
        {
            formManual = new FormManual();
            formManual.InitData(ref tskHwComunication, ref getStatus, ref tskReset);
            formManual.diagnosticRefresh();
            formManual.Show();
        }

        //Exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            btnExit.Enabled = false;

            tskStop.SwitchOn();//Start task stop
            tskStop.EndProgram();//End program
        }

        //Execute only first start
        private void FormMain_Load(object sender, EventArgs e)
        {
            getStatus.firstStart = true;
            tskHwComunication.SetColorWhite();
        }

        //Show Test Plan
        private void btnTestPlan_Click(object sender, EventArgs e)
        {
            formTestPlan = new FormTestPlan();
            formTestPlan.InitData(ref tskHwComunication, ref getStatus);
            formTestPlan.Show();

        }
    }
}
