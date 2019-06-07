using System;

namespace ProvaLoccioni
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.lblRes = new System.Windows.Forms.Label();
            this.btnPortOnOff = new System.Windows.Forms.Button();
            this.ledOnOFF = new System.Windows.Forms.Label();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.lblClock = new System.Windows.Forms.Label();
            this.ledTskOnOff = new System.Windows.Forms.Label();
            this.btnTaskOnOFF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tmr
            // 
            this.tmr.Enabled = true;
            this.tmr.Interval = 300;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // lblRes
            // 
            this.lblRes.Location = new System.Drawing.Point(601, 53);
            this.lblRes.Name = "lblRes";
            this.lblRes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRes.Size = new System.Drawing.Size(187, 82);
            this.lblRes.TabIndex = 5;
            this.lblRes.Text = "Label1";
            this.lblRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPortOnOff
            // 
            this.btnPortOnOff.Location = new System.Drawing.Point(119, 72);
            this.btnPortOnOff.Name = "btnPortOnOff";
            this.btnPortOnOff.Size = new System.Drawing.Size(202, 63);
            this.btnPortOnOff.TabIndex = 6;
            this.btnPortOnOff.Text = "Port  On/off";
            this.btnPortOnOff.UseVisualStyleBackColor = true;
            this.btnPortOnOff.Click += new System.EventHandler(this.startStop_Click);
            // 
            // ledOnOFF
            // 
            this.ledOnOFF.BackColor = System.Drawing.Color.Red;
            this.ledOnOFF.Location = new System.Drawing.Point(119, 30);
            this.ledOnOFF.Name = "ledOnOFF";
            this.ledOnOFF.Size = new System.Drawing.Size(202, 23);
            this.ledOnOFF.TabIndex = 7;
            this.ledOnOFF.Text = "On/OFf";
            this.ledOnOFF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ledOnOFF.UseMnemonic = false;
            // 
            // clock
            // 
            this.clock.Enabled = true;
            this.clock.Interval = 1;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // lblClock
            // 
            this.lblClock.Location = new System.Drawing.Point(598, 30);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(100, 23);
            this.lblClock.TabIndex = 8;
            this.lblClock.Text = "hour";
            this.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledTskOnOff
            // 
            this.ledTskOnOff.BackColor = System.Drawing.Color.Red;
            this.ledTskOnOff.Location = new System.Drawing.Point(119, 199);
            this.ledTskOnOff.Name = "ledTskOnOff";
            this.ledTskOnOff.Size = new System.Drawing.Size(202, 23);
            this.ledTskOnOff.TabIndex = 10;
            this.ledTskOnOff.Text = "On/OFf";
            this.ledTskOnOff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ledTskOnOff.UseMnemonic = false;
            // 
            // btnTaskOnOFF
            // 
            this.btnTaskOnOFF.Location = new System.Drawing.Point(119, 241);
            this.btnTaskOnOFF.Name = "btnTaskOnOFF";
            this.btnTaskOnOFF.Size = new System.Drawing.Size(202, 63);
            this.btnTaskOnOFF.TabIndex = 9;
            this.btnTaskOnOFF.Text = "Task On/off";
            this.btnTaskOnOFF.UseVisualStyleBackColor = true;
            this.btnTaskOnOFF.Click += new System.EventHandler(this.btnTaskOnOFF_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ledTskOnOff);
            this.Controls.Add(this.btnTaskOnOFF);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.ledOnOFF);
            this.Controls.Add(this.btnPortOnOff);
            this.Controls.Add(this.lblRes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        private void btnObjPres_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Button btnPortOnOff;
        private System.Windows.Forms.Label ledOnOFF;
        private System.Windows.Forms.Timer clock;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Label ledTskOnOff;
        private System.Windows.Forms.Button btnTaskOnOFF;
    }
}

