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
    public partial class FormManual : Form
    {
        GetStatus getStatus;
        TskHwComunication tskHwComunication;
        TskReset tskReset;

        Timer tmrClock;

        public FormManual()
        {
            tmrClock = new Timer();
            tmrClock.Interval = 1000;
            tmrClock.Enabled = true;
            tmrClock.Tick += TmrClock_Tick;
            InitializeComponent();

            //NB 01/07/2019    set max altezza
            chartVoltage.ChartAreas[0].AxisY.Maximum = 13;
            chartFlux.ChartAreas[0].AxisY.Maximum = 1.5;
        }

        private void TmrClock_Tick(object sender, EventArgs e)
        {
            clock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        public void InitData(ref TskHwComunication _tskHwComunication, ref GetStatus _getStatus, ref TskReset _tskReset)
        {
            tskReset = _tskReset;
            tskHwComunication = _tskHwComunication;
            getStatus = _getStatus;
        }
        
        


        public void WriteInLabelMessageUser(string message)
        {
            //LblMsgUser.Text = message;
        }


        //refresh diagnostic
        public void diagnosticRefresh()
        {
            //state reset
            if (getStatus.StateReset)
            {
                if (getStatus.StateDoor)
                {
                    if (!tskReset.Started)
                    {
                        tskReset.SwitchOn();
                        disabilityButtons();
                        btnHome.Enabled = false;
                    }
                }
            }

            if (tskReset.Finish())
            {
                abilityButtons();
                btnHome.Enabled = true;
                //led diagnostic
                if (getStatus.StateDoor)
                {
                    ledDoor.BackColor = Color.Green;
                    abilityButtons();
                }
                else
                {
                    ledDoor.BackColor = Color.Red;
                    disabilityButtons();
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
                flux.Text = getStatus.Flow.ToString()+" l/m";


                if (chartFlux.Series[0].Points.Count >= 25)
                {
                    chartFlux.Series[0].Points.RemoveAt(0);
                }

                if (chartVoltage.Series[0].Points.Count >= 25)
                {
                    chartVoltage.Series[0].Points.RemoveAt(0);
                }
                
                chartVoltage.Series[0].Points.AddY(getStatus.Volt);
                chartFlux.Series[0].Points.AddY(getStatus.Flow);

            }
        }

        //Button for go in the home
        private void btnHome_Click(object sender, EventArgs e)
        {
            getStatus.MaxFlow = 0;
            getStatus.openVolt = 0;
            Hide();
        }

        //Disability button
        public void disabilityButtons()
        {
            btnAirClose.Enabled = false;
            btnAirOpen.Enabled = false;
            btnPistonDown.Enabled = false;
            btnPistonUp.Enabled = false;
            btnConfigVolt.Enabled = false;
        }
        //Ability Button
        public void abilityButtons()
        {
            btnAirClose.Enabled = true;
            btnAirOpen.Enabled = true;
            btnPistonDown.Enabled = true;
            btnPistonUp.Enabled = true;
            btnConfigVolt.Enabled = true;
        }

        private void btnConfigVolt_Click(object sender, EventArgs e)
        {
            tskHwComunication.SetVoltage(Convert.ToInt32(VoltSelector.Value));
        }
        private void btnPistonDown_Click(object sender, EventArgs e)
        {
            tskHwComunication.ClosePiston();
        }

        private void btnPistonUp_Click(object sender, EventArgs e)
        {
            tskHwComunication.OpenPiston();
        }

        private void btnAirOpen_Click(object sender, EventArgs e)
        {
            tskHwComunication.OpenAir();
        }

        private void btnAirClose_Click(object sender, EventArgs e)
        {
            tskHwComunication.CloseAir();
        }
        
        private void FormManual_Load(object sender, EventArgs e)
        {
            VoltSelector.Maximum = getStatus.maxRamp;
        }
    }
}
