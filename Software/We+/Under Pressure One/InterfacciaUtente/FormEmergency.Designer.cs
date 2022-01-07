namespace InterfacciaUtente
{
    partial class FormEmergency
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmergency));
            this.LblMessage = new System.Windows.Forms.Label();
            this.ledEmergency = new System.Windows.Forms.Label();
            this.tmrEmergency = new System.Windows.Forms.Timer(this.components);
            this.LblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblMessage
            // 
            this.LblMessage.BackColor = System.Drawing.Color.Transparent;
            this.LblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 85F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMessage.Location = new System.Drawing.Point(12, 241);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(776, 123);
            this.LblMessage.TabIndex = 0;
            this.LblMessage.Text = "Unlock Button";
            this.LblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledEmergency
            // 
            this.ledEmergency.Location = new System.Drawing.Point(12, 9);
            this.ledEmergency.Name = "ledEmergency";
            this.ledEmergency.Size = new System.Drawing.Size(776, 432);
            this.ledEmergency.TabIndex = 1;
            // 
            // tmrEmergency
            // 
            this.tmrEmergency.Enabled = true;
            this.tmrEmergency.Interval = 250;
            this.tmrEmergency.Tick += new System.EventHandler(this.tmrEmergency_Tick);
            // 
            // LblError
            // 
            this.LblError.AutoSize = true;
            this.LblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblError.Location = new System.Drawing.Point(42, 43);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(746, 120);
            this.LblError.TabIndex = 2;
            this.LblError.Text = "EMERGENCY";
            this.LblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormEmergency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblError);
            this.Controls.Add(this.LblMessage);
            this.Controls.Add(this.ledEmergency);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEmergency";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emergency";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormEmergency_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMessage;
        private System.Windows.Forms.Label ledEmergency;
        private System.Windows.Forms.Timer tmrEmergency;
        private System.Windows.Forms.Label LblError;
    }
}