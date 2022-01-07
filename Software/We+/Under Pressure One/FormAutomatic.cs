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
        public event EventHandler<string> AlarmEvent;
        bool FormIsOpen;

        FormError formError;
        FormEmergency formEmergency;
        TskAutomatic tskAutomatic;

        GetStatus getStatus;
        TskHwComunication tskHwComunication;
        TskReset tskReset;
        TskEmergency tskEmergency;
        TskStop tskStop;

        Timer tmrClock;

        public FormAutomatic()
        {
            FormIsOpen = false;
            tskAutomatic = new TskAutomatic();
            InitializeComponent();
        }
        //Init
        private void InitTskData()
        {
            tmrClock = new Timer();
            tmrClock.Interval = 1000;
            tmrClock.Enabled = true;
            tmrClock.Tick += tmrClock_tick;

            tskReset.InitData(ref getStatus, ref tskHwComunication);
            tskAutomatic.SendMessageUser += TskAutomatic_SendMessageUser;
            tskAutomatic.AlarmEvent += TskAutomatic_AlarmEvent;


        }

        private void tmrClock_tick(object sender, EventArgs e)
        {
            clock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void TskAutomatic_AlarmEvent(object sender, string e)
        {
            if (!InvokeRequired)
            {
                tskHwComunication.SetColorRed();
                formError.AddError(e);

                if (!formError.Is_Open())
                    formError.Show();//Error Door
            }
            else
            {
                BeginInvoke(new EventHandler<string>(TskAutomatic_AlarmEvent), sender, e);
            }
        }



        private void TskAutomatic_SendMessageUser(object sender, string e)
        {
            if (!InvokeRequired)
            {
                LblMsgUser.Text = e;
            }
            else
            {
                BeginInvoke(new EventHandler<string>(TskAutomatic_SendMessageUser), sender, e);
            }
        }





        public void InitData(ref TskHwComunication _tskHwComunication, ref GetStatus _getStatus, ref TskReset _tskReset, ref FormError _formError, ref TskStop _tskStop)
        {
            tskReset = _tskReset;
            tskHwComunication = _tskHwComunication;
            getStatus = _getStatus;
            formError = _formError;
            tskStop = _tskStop;
            chartVoltage.ChartAreas[0].AxisY.Maximum = getStatus.maxRamp + 0.5;
            chartFlux.ChartAreas[0].AxisY.Maximum = getStatus.minValueFlow + 0.5;
        }




        //Invoke led diagnostic
        public void diagnosticRefresh()
        {
            if (getStatus == null)
                return;

            //se la form e' chiusa non fa la diagnostic refresh
            if (!FormIsOpen)
                return;



            if (tskReset.Finish() && !tskAutomatic.Tsk_On() && !getStatus.EmergencyIsOpen)
            {
                tskAutomatic.SwitchOn();
                btnHome.Enabled = true;
            }


            if (getStatus.StateEmergency)
            {
                tskAutomatic.SwitchOff();

                if (!tskReset.Finish())
                    tskReset.SwitchOff();
            }

            if (getStatus.StateReset)
            {
                if (getStatus.StateDoor)
                {
                    if ((LblMsgUser.Text == "Press Reset") || (formError.AreErrors()))
                    {
                        if (!tskReset.Started && !getStatus.EmergencyIsOpen && !tskAutomatic.Testing())
                        {
                            btnHome.Enabled = false;
                            tskAutomatic.SwitchOff();
                            tskReset.SwitchOn();
                        }
                    }
                }
                else
                {
                    tskHwComunication.SetColorRed();
                    formError.AddError("The door is open");
                    if (!formError.Is_Open())
                        formError.Show();//Error Door
                    
                }
            }

            if (LblMsgUser.Text == "End Reset")
            {
                LblMsgUser.Text = "Press start to begin";
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
            flux.Text = getStatus.Flow.ToString() + " l/m";
            voltage.Text = getStatus.Volt.ToString();
            lblOV.Text = getStatus.openVolt.ToString() + " V";
            if (getStatus.Flow >= getStatus.MaxFlow)
            {
                getStatus.MaxFlow = getStatus.Flow;
            }
            lblMF.Text = getStatus.MaxFlow.ToString() + " l/m";

            if (getStatus.successTest == 1)
            {
                tlpResult.BackColor = Color.Green;
            }
            else
            {
                if (getStatus.successTest == -1)
                {
                    tlpResult.BackColor = Color.Red;
                }
                else
                {
                    if (getStatus.successTest == 0)
                    {
                        tlpResult.BackColor = Color.White;
                    }
                }
            }

            if (chartFlux.Series[0].Points.Count >= 25)
            {
                chartFlux.Series[0].Points.RemoveAt(0);
            }

            if (chartVoltage.Series[0].Points.Count >= 25)
            {
                chartVoltage.Series[0].Points.RemoveAt(0);
            }

            //charts
            if (!tskAutomatic.StopCharts)
            {
                chartFlux.Series[0].Points.AddY(getStatus.Flow);
                chartVoltage.Series[0].Points.AddY(getStatus.Volt);
            }

            if (!getStatus.AutomaticSelector)
            {
                tskAutomatic.SwitchOff();
                LblMsgUser.Text = "Turn selector into automatic";
                tskStop.SwitchOn();
                  
            }

        }

        public void WriteInLabelMessageUser(string Message)
        {
            LblMsgUser.Text = Message;
        }


        //Button fo going in the home
        private void btnHome_Click(object sender, EventArgs e)
        {
            lblOV.Text = "0 V";
            lblMF.Text = "0 l/m";
            getStatus.MaxFlow = 0;
            getStatus.openVolt = 0;
            getStatus.successTest = 0;
            FormIsOpen = false;
            tskHwComunication.SetColorWhite();
            tskAutomatic.SwitchOff();
            Hide();
        }

        private void FormAutomatic_Load(object sender, EventArgs e)
        {
            InitTskData();
            FormIsOpen = true;
            tskAutomatic.InitData(ref getStatus, ref tskHwComunication, ref tskStop);
        }

    }
}
