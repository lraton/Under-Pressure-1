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
    public partial class FormEmergency : Form
    {
        TskEmergency tskEmergency;
        GetStatus getStatus;
        TskHwComunication tskHwComunication;
        TskReset tskReset;

        public FormEmergency()
        {            
            tskEmergency = new TskEmergency();
            tskEmergency.EmergencyUpdatedEvent += TskEmergency_EmergencyUpdatedEvent;
            tskEmergency.CloseFormEmergency += TskEmergency_CloseFormEmergency;
            InitializeComponent();
        }

        private void TskEmergency_CloseFormEmergency(object sender, EventArgs e)
        {
            if (!InvokeRequired)
            {                
                Close();
            }
            else
            {
                BeginInvoke(new EventHandler(TskEmergency_CloseFormEmergency), sender, e);
            }
        }


        public void InitData(ref GetStatus _getStatus, ref TskHwComunication _tskHw, ref TskReset _tskReset)
        {
            getStatus = _getStatus;
            tskHwComunication = _tskHw;
            tskReset = _tskReset;
        }



        //Message to user
        private void TskEmergency_EmergencyUpdatedEvent(object sender, string e)
        {
            if (!InvokeRequired)
            {
                LblMessage.Text = e;
            }
            else
            {
                BeginInvoke(new EventHandler<string>(TskEmergency_EmergencyUpdatedEvent), sender, e);
            }
        }


        private void tmrEmergency_Tick(object sender, EventArgs e)
        {
            
            if (ledEmergency.BackColor == Color.Maroon)
            {
                ledEmergency.BackColor = Color.Red;
                LblMessage.BackColor = Color.Red;
                LblError.BackColor = Color.Red;
            }
            else
            {
                ledEmergency.BackColor = Color.Maroon;
                LblError.BackColor = Color.Maroon;
                LblMessage.BackColor = Color.Maroon;
            }
        }

        private void FormEmergency_Load(object sender, EventArgs e)
        {
            tskHwComunication.SetColorRed();
            getStatus.EmergencyIsOpen = true;
            LblMessage.Text = "";
            tskEmergency.InitData(ref getStatus, ref tskHwComunication, ref tskReset);
            tskEmergency.SwitchOn();
        }

        

        private void FormEmergency_FormClosing(object sender, FormClosingEventArgs e)
        {
            getStatus.EmergencyIsOpen = false;
            tskHwComunication.SetColorWhite();
        }
    }
}
