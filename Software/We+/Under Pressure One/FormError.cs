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
    public partial class FormError : Form
    {
        private const int CP_DISABLE_CLOSE_BUTTON = 0x200;
        int nError = 0;
        
        bool IsOpen;
        
        public FormError()
        {
            IsOpen = false;
            InitializeComponent();
            Load += FormError_Load;
        }

        private void FormError_Load(object sender, EventArgs e)
        {
            IsOpen = true;
        }

        public bool AreErrors()
        {
            if (nError > 0)
            {
                return true;
            }
            else
            {
                return false;
            }            
        }


        public bool Is_Open()
        {
            return IsOpen;
        }


        public void AddError(string msgError)
        {            
            nError++;
            //IsOpen = true;
            ListViewItem item = new ListViewItem(nError.ToString());
            item.SubItems.Add(msgError);
            listViewError.Items.Insert(0, item);
        }
        
        public void ResetError()
        {
            listViewError.Items.Clear();
            nError = 0;
            IsOpen = false;
            Hide();
        }
        
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = cp.ClassStyle | CP_DISABLE_CLOSE_BUTTON;
                return cp;
            }
        }

        private void FormError_FormClosing(object sender, FormClosingEventArgs e)
        {            
            listViewError.Items.Clear();
            nError = 0;
        }
    }
}
