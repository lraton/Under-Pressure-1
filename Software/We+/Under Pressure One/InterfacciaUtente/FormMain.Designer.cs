namespace InterfacciaUtente
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAutomatic = new System.Windows.Forms.Button();
            this.btnTestPlan = new System.Windows.Forms.Button();
            this.btnManual = new System.Windows.Forms.Button();
            this.layoutPanelUP1 = new System.Windows.Forms.TableLayoutPanel();
            this.ayoutPanelLoccioniWe = new System.Windows.Forms.TableLayoutPanel();
            this.PictureWePlus = new System.Windows.Forms.PictureBox();
            this.PictureLoccioni = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.clock = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.layoutPanelUP1.SuspendLayout();
            this.ayoutPanelLoccioniWe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureWePlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLoccioni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrClock
            // 
            this.tmrClock.Enabled = true;
            this.tmrClock.Tick += new System.EventHandler(this.tmrClock_Tick_1);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.layoutPanelUP1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1440, 900);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(174)))), ((int)(((byte)(209)))));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnExit, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAutomatic, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnTestPlan, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnManual, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 768);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1434, 129);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(174)))), ((int)(((byte)(209)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1147, 23);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(213, 82);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAutomatic
            // 
            this.btnAutomatic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAutomatic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(174)))), ((int)(((byte)(209)))));
            this.btnAutomatic.Enabled = false;
            this.btnAutomatic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutomatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutomatic.ForeColor = System.Drawing.Color.White;
            this.btnAutomatic.Location = new System.Drawing.Point(72, 23);
            this.btnAutomatic.Name = "btnAutomatic";
            this.btnAutomatic.Size = new System.Drawing.Size(213, 82);
            this.btnAutomatic.TabIndex = 0;
            this.btnAutomatic.Text = "Automatic";
            this.btnAutomatic.UseVisualStyleBackColor = false;
            this.btnAutomatic.Click += new System.EventHandler(this.btnAutomatic_Click);
            // 
            // btnTestPlan
            // 
            this.btnTestPlan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTestPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(174)))), ((int)(((byte)(209)))));
            this.btnTestPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestPlan.ForeColor = System.Drawing.Color.White;
            this.btnTestPlan.Location = new System.Drawing.Point(430, 23);
            this.btnTestPlan.Name = "btnTestPlan";
            this.btnTestPlan.Size = new System.Drawing.Size(213, 82);
            this.btnTestPlan.TabIndex = 1;
            this.btnTestPlan.Text = "Test plan";
            this.btnTestPlan.UseVisualStyleBackColor = false;
            // 
            // btnManual
            // 
            this.btnManual.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnManual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(174)))), ((int)(((byte)(209)))));
            this.btnManual.Enabled = false;
            this.btnManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManual.ForeColor = System.Drawing.Color.White;
            this.btnManual.Location = new System.Drawing.Point(788, 23);
            this.btnManual.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(213, 82);
            this.btnManual.TabIndex = 2;
            this.btnManual.Text = "Manual";
            this.btnManual.UseVisualStyleBackColor = false;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // layoutPanelUP1
            // 
            this.layoutPanelUP1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.layoutPanelUP1.ColumnCount = 1;
            this.layoutPanelUP1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.layoutPanelUP1.Controls.Add(this.ayoutPanelLoccioniWe, 0, 0);
            this.layoutPanelUP1.Controls.Add(this.pictureBox2, 0, 1);
            this.layoutPanelUP1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPanelUP1.Location = new System.Drawing.Point(3, 48);
            this.layoutPanelUP1.Name = "layoutPanelUP1";
            this.layoutPanelUP1.RowCount = 2;
            this.layoutPanelUP1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPanelUP1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPanelUP1.Size = new System.Drawing.Size(1434, 714);
            this.layoutPanelUP1.TabIndex = 15;
            // 
            // ayoutPanelLoccioniWe
            // 
            this.ayoutPanelLoccioniWe.ColumnCount = 2;
            this.ayoutPanelLoccioniWe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ayoutPanelLoccioniWe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ayoutPanelLoccioniWe.Controls.Add(this.PictureWePlus, 1, 0);
            this.ayoutPanelLoccioniWe.Controls.Add(this.PictureLoccioni, 0, 0);
            this.ayoutPanelLoccioniWe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ayoutPanelLoccioniWe.Location = new System.Drawing.Point(3, 3);
            this.ayoutPanelLoccioniWe.Name = "ayoutPanelLoccioniWe";
            this.ayoutPanelLoccioniWe.RowCount = 1;
            this.ayoutPanelLoccioniWe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ayoutPanelLoccioniWe.Size = new System.Drawing.Size(1428, 351);
            this.ayoutPanelLoccioniWe.TabIndex = 15;
            // 
            // PictureWePlus
            // 
            this.PictureWePlus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureWePlus.Image = ((System.Drawing.Image)(resources.GetObject("PictureWePlus.Image")));
            this.PictureWePlus.InitialImage = ((System.Drawing.Image)(resources.GetObject("PictureWePlus.InitialImage")));
            this.PictureWePlus.Location = new System.Drawing.Point(716, 3);
            this.PictureWePlus.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PictureWePlus.Name = "PictureWePlus";
            this.PictureWePlus.Size = new System.Drawing.Size(710, 345);
            this.PictureWePlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureWePlus.TabIndex = 1;
            this.PictureWePlus.TabStop = false;
            // 
            // PictureLoccioni
            // 
            this.PictureLoccioni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureLoccioni.Image = ((System.Drawing.Image)(resources.GetObject("PictureLoccioni.Image")));
            this.PictureLoccioni.InitialImage = null;
            this.PictureLoccioni.Location = new System.Drawing.Point(80, 140);
            this.PictureLoccioni.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PictureLoccioni.Name = "PictureLoccioni";
            this.PictureLoccioni.Size = new System.Drawing.Size(554, 70);
            this.PictureLoccioni.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureLoccioni.TabIndex = 3;
            this.PictureLoccioni.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(2, 360);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1430, 351);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(174)))), ((int)(((byte)(209)))));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.clock, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1434, 39);
            this.tableLayoutPanel3.TabIndex = 17;
            // 
            // clock
            // 
            this.clock.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.clock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(174)))), ((int)(((byte)(209)))));
            this.clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.clock.ForeColor = System.Drawing.Color.White;
            this.clock.Location = new System.Drawing.Point(1315, 6);
            this.clock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(117, 26);
            this.clock.TabIndex = 14;
            this.clock.Text = "HH:mm:ss";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1440, 900);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormMain";
            this.Text = "Under Pressure 1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.layoutPanelUP1.ResumeLayout(false);
            this.ayoutPanelLoccioniWe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureWePlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLoccioni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmrClock;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAutomatic;
        private System.Windows.Forms.Button btnTestPlan;
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.TableLayoutPanel layoutPanelUP1;
        private System.Windows.Forms.TableLayoutPanel ayoutPanelLoccioniWe;
        private System.Windows.Forms.PictureBox PictureWePlus;
        private System.Windows.Forms.PictureBox PictureLoccioni;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label clock;
    }
}

