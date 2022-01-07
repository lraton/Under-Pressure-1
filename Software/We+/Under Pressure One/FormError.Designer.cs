namespace InterfacciaUtente
{
    partial class FormError
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormError));
            this.lblError = new System.Windows.Forms.Label();
            this.listViewError = new System.Windows.Forms.ListView();
            this.number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.msgError = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblError
            // 
            this.lblError.BackColor = System.Drawing.Color.DarkRed;
            this.lblError.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.White;
            this.lblError.Location = new System.Drawing.Point(0, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(536, 37);
            this.lblError.TabIndex = 1;
            this.lblError.Text = "Close door and press RESET";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listViewError
            // 
            this.listViewError.BackColor = System.Drawing.Color.DarkRed;
            this.listViewError.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.number,
            this.msgError});
            this.listViewError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.listViewError.ForeColor = System.Drawing.SystemColors.Window;
            this.listViewError.Location = new System.Drawing.Point(0, 37);
            this.listViewError.Name = "listViewError";
            this.listViewError.Size = new System.Drawing.Size(536, 428);
            this.listViewError.TabIndex = 2;
            this.listViewError.UseCompatibleStateImageBehavior = false;
            this.listViewError.View = System.Windows.Forms.View.Details;
            // 
            // number
            // 
            this.number.Text = "N.";
            this.number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.number.Width = 56;
            // 
            // msgError
            // 
            this.msgError.Text = "Error";
            this.msgError.Width = 472;
            // 
            // FormError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 465);
            this.Controls.Add(this.listViewError);
            this.Controls.Add(this.lblError);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormError";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormError_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.ListView listViewError;
        private System.Windows.Forms.ColumnHeader msgError;
        private System.Windows.Forms.ColumnHeader number;
    }
}