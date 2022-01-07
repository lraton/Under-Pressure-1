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
        FormAutomatic formAutomatic;
        FormManual formManual;
        FormError formError;
        FormEmergency formEmergency;

        TskReset tskReset;
        GetStatus getStatus;
        TskHwComunication tskHwComunication;
        TskEmergency tskEmergency;


        public int c = 0;

        public FormMain()
        {
            InitTskData();
            tskHwComunication.SwitchOn();
            InitializeComponent();
        }

        //Init
        private void InitTskData()
        {
            tskHwComunication = new TskHwComunication();
            tskReset = new TskReset();
            getStatus = new GetStatus();
            // tskAutomatic = new TskAutomatic();

            tskReset.InitData(ref getStatus, ref tskHwComunication);
            tskHwComunication.InitData(ref getStatus);
            //  tskAutomatic.InitData(ref getStatus, ref tskHwComunication);


            tskHwComunication.HwInformationUpdatedEvent += HwInformationUpdatedEvent;
            tskHwComunication.AlarmEvent += AlarmEvent;
            //tskAutomatic.AlarmEvent += TskAutomatic_AlarmEvent;
            tskHwComunication.ResetAlarm += ResetAlarm;

            tskReset.AlarmEvent += TskReset_AlarmEvent;
            //tskReset.SendMessageUser += TskReset_SendMessageUser;
            //  tskAutomatic.SendMessageUser += TskAutomatic_SendMessageUser;

            tskHwComunication.ResponseEvent += TskHwComunication_ResponseEvent;
            
            
        }

        //stampo quello che ricevo dalla seriale
        private void TskHwComunication_ResponseEvent(object sender, string e)
        {
            if (!InvokeRequired)
            {
                if (e != "")
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

        //alarm task reset
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

        //Alarm task comunication
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
            //add error 
        }

        //Event reset alarm
        private void ResetAlarm(object sender, EventArgs e)
        {
            if (!InvokeRequired)
            {
                ResetAlarmMainForm();
            }
            else
            {
                BeginInvoke(new EventHandler(ResetAlarm), sender, e);
            }
        }

        public void ResetAlarmMainForm()
        {
            //LabelMessages.BackColor = Color.Gray;
            //LabelMessages.Text = "";
            //if (!btnTaskOnOFF.Enabled)
            //{
            //    AbilityButtons();
            //}
        }

        //Enable btnautmatic/manual
        private void HwInformationUpdatedEvent(object sender, GetStatus e)
        {
            if (!InvokeRequired)
            {
                if (getStatus.AutomaticSelector)
                {
                    btnAutomatic.Enabled = true ;
                    btnManual.Enabled = false;
                }
                else
                {
                    btnAutomatic.Enabled = false;
                    btnManual.Enabled = true;
                }
                

                if (formAutomatic!=null)
                {
                    formAutomatic.diagnosticRefresh();
                }
                else
                {
                    if (formManual != null)
                    {
                        formManual.diagnosticRefresh();
                    }
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
        }
        
        //Set the automatic mode
        private void btnAutomatic_Click(object sender, EventArgs e)
        {
            formAutomatic = new FormAutomatic();
            formAutomatic.InitData(ref tskHwComunication, ref getStatus, ref tskReset);
            formAutomatic.diagnosticRefresh();
            formAutomatic.Show();
            //this.Hide();
        }

        //Set manual mode
        private void btnManual_Click(object sender, EventArgs e)
        {
            formManual = new FormManual();
            formManual.InitData(ref tskHwComunication, ref getStatus, ref tskReset);
            formManual.diagnosticRefresh();
            formManual.Show();
          //  this.Hide();
        }

        //Exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
