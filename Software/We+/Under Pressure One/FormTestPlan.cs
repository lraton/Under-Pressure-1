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
    public partial class FormTestPlan : Form
    {
        TskHwComunication tskHwComunication;
        GetStatus getStatus;

        string velocity;
        public FormTestPlan()
        {
            InitializeComponent();
        }

        //Clock for time
        private void tmrClock_Tick(object sender, EventArgs e)
        {
            clock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        public void InitData(ref TskHwComunication _tskHwComunication, ref GetStatus _getStatus)
        {
            tskHwComunication = _tskHwComunication;
            getStatus = _getStatus;
        }


        //Button for go in the home
        private void btnHome_Click(object sender, EventArgs e)
        {
            Hide();
        }

        //slow button
        private void btnSlow_Click(object sender, EventArgs e)
        {
            ledFast.BackColor = Color.Red;
            ledNormal.BackColor = Color.Red;
            ledSlow.BackColor = Color.Green;
            velocity = "slow";
        }

        //normal button
        private void btnNormal_Click(object sender, EventArgs e)
        {
            ledFast.BackColor = Color.Red;
            ledNormal.BackColor = Color.Green;
            ledSlow.BackColor = Color.Red;
            velocity = "normal";
        }

        //Fast button
        private void btnFast_Click(object sender, EventArgs e)
        {
            ledFast.BackColor = Color.Green;
            ledNormal.BackColor = Color.Red;
            ledSlow.BackColor = Color.Red;
            velocity = "fast";
        }

        //Confirm button
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            switch (velocity)
            {
                case "slow":
                    getStatus.autoVelocity = 400;
                    break;
                case "normal":
                    getStatus.autoVelocity = 250;
                    break;
                case "fast":
                    getStatus.autoVelocity = 100;
                    break;
            }

            getStatus.minValueFlow = Convert.ToDouble(flowSelector.Value);
        }


        //form load
        private void FormTestPlan_Load(object sender, EventArgs e)
        {
            flowSelector.Value = Convert.ToDecimal(getStatus.minValueFlow);
            if (getStatus.autoVelocity == 400)
            {
                ledFast.BackColor = Color.Red;
                ledNormal.BackColor = Color.Red;
                ledSlow.BackColor = Color.Green;
            }
            if (getStatus.autoVelocity == 250)
            {
                ledFast.BackColor = Color.Red;
                ledNormal.BackColor = Color.Green;
                ledSlow.BackColor = Color.Red;
            }
            if (getStatus.autoVelocity == 100)
            {
                ledFast.BackColor = Color.Green;
                ledNormal.BackColor = Color.Red;
                ledSlow.BackColor = Color.Red;
            }
        }

        private void btnPreset_Click(object sender, EventArgs e)
        {
            ledFast.BackColor = Color.Red;
            ledNormal.BackColor = Color.Green;
            ledSlow.BackColor = Color.Red;
            getStatus.autoVelocity = 250;

            getStatus.maxRamp = 12;
            getStatus.minValueFlow = 1;
            flowSelector.Value = Convert.ToDecimal(getStatus.minValueFlow);
        }
    }
}
