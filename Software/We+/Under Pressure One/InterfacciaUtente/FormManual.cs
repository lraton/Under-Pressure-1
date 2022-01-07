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


        public FormManual()
        {
            InitializeComponent();
        }

        public void InitData(ref TskHwComunication _tskHwComunication, ref GetStatus _getStatus, ref TskReset _tskReset)
        {
            tskReset = _tskReset;
            tskHwComunication = _tskHwComunication;
            getStatus = _getStatus;
        }


        //refresh diagnostic
        public void diagnosticRefresh()
        {
            if (getStatus.StateReset)
            {
                if (!tskReset.Started)
                {
                    tskReset.SwitchOn();
                }
            }



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
            flux.Text = getStatus.Flux.ToString();


            chartFlux.Series[0].Points.AddY(getStatus.Flux);
            chartVoltage.Series[0].Points.AddY(getStatus.Volt);
        }

        //Button for go in the home
        private void btnHome_Click(object sender, EventArgs e)
        {
            Hide();
        }

        //Disability button
        private void disabilityButtons()
        {
            btnAirClose.Enabled = false;
            btnAirOpen.Enabled = false;
            btnPistonDown.Enabled = false;
            btnPistonUp.Enabled = false;
            btnConfigVolt.Enabled = false;
        }
        //Ability Button
        private void abilityButtons()
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
    }
}
