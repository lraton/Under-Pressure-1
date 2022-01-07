using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacciaUtente
{
    public partial class FormAutomatic : Form
    {
        FormError formError;
        FormEmergency formEmergency;
        TskAutomatic tskAutomatic;

        GetStatus getStatus;
        TskHwComunication tskHwComunication;
        TskReset tskReset;

        public FormAutomatic()
        {
            tskAutomatic = new TskAutomatic();
            InitializeComponent();
        }
        //Init
        private void InitTskData()
        {         
            tskReset.InitData(ref getStatus, ref tskHwComunication);
            //tskHwComunication.InitData(ref getStatus);
            //tskAutomatic.InitData(ref getStatus, ref tskHwComunication);
            

            tskHwComunication.AlarmEvent += AlarmEvent;
            //tskAutomatic.AlarmEvent += TskAutomatic_AlarmEvent;
            tskHwComunication.ResetAlarm += ResetAlarm;

            //tskReset.AlarmEvent += TskReset_AlarmEvent;

            tskReset.SendMessageUser += TskReset_SendMessageUser;


            tskHwComunication.ResponseEvent += TskHwComunication_ResponseEvent;
        }

        private void TskReset_SendMessageUser(object sender, string e)
        {
            if (!InvokeRequired)
            {
                lblMsgUser.Text = e;
            }
            else
            {
                BeginInvoke(new EventHandler<string>(TskReset_SendMessageUser), sender, e);
            }
        }

      

        public void InitData(ref TskHwComunication _tskHwComunication, ref GetStatus _getStatus, ref TskReset _tskReset)
        {
            tskReset = _tskReset;
            tskAutomatic.SendMessageUser += TskAutomatic_SendMessageUser;
            tskHwComunication = _tskHwComunication;
            getStatus = _getStatus;
            tskAutomatic.AlarmEvent += TskAutomatic_AlarmEvent;
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

        //Task automatic message user
        private void TskAutomatic_SendMessageUser(object sender, string e)
        {
            if (!InvokeRequired)
            {
                lblMsgUser.Text=e;
            }
            else
            {
                BeginInvoke(new EventHandler<string>(TskAutomatic_SendMessageUser), sender, e);
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
            tskHwComunication.SwitchOff();
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

        //Invoke led diagnostic
        public void diagnosticRefresh()
        {
            if (getStatus.StateReset)
            {
                if (!tskReset.Started)
                {
                    tskReset.SwitchOn();
                    tskAutomatic.SwitchOff();
                }

            }

            if (getStatus.StateEmergency)
            {
                formEmergency = new FormEmergency();
                formEmergency.InitData(ref getStatus, ref tskHwComunication, ref tskReset);
                formEmergency.ShowDialog();
                tskAutomatic.SwitchOff();
            }

            if (getStatus.StateDoor)
            {
                ledDoor.BackColor = Color.Green;
            }
            else
            {
                ledDoor.BackColor = Color.Red;
            }

            if (getStatus.StateInjector)
            {
                ledInj.BackColor = Color.Green;
            }
            else
            {
                ledInj.BackColor = Color.Red;
            }
            if (getStatus.StatePistonUp)
            {
                ledCylinderUp.BackColor = Color.Green;
            }
            else
            {
                ledCylinderUp.BackColor = Color.Red;
            }
            if (getStatus.StatePistonDown)
            {
                ledCylinderDown.BackColor = Color.Green;
            }
            else
            {
                ledCylinderDown.BackColor = Color.Red;
            }

            if (getStatus.StateAir)
            {
                ledAir.BackColor = Color.Green;
            }
            else
            {
                ledAir.BackColor = Color.Red;
            }

            btnHome.Enabled = !tskAutomatic.Testing();
            flux.Text = getStatus.Flux.ToString();
            voltage.Text = getStatus.Volt.ToString();

            //charts
            chartFlux.Series[0].Points.AddY(getStatus.Flux);
            chartVoltage.Series[0].Points.AddY(getStatus.Volt);


        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        //Button fo going in the home
        private void btnHome_Click(object sender, EventArgs e)
        {
            tskAutomatic.SwitchOff();
            Hide();
        }

        

        //temporary Error button click
        private void Error_Click(object sender, EventArgs e)
        {
            formError = new FormError();
            formError.Show();
        }


        //temporary emergency button click
        private void btnEmergency_Click(object sender, EventArgs e)
        {
            formEmergency = new FormEmergency();
            formEmergency.ShowDialog();
        }


        private void FormAutomatic_Load(object sender, EventArgs e)
        {
            InitTskData();

            tskAutomatic.InitData(ref getStatus, ref tskHwComunication);
            tskAutomatic.SwitchOn();
        }

    }
}
