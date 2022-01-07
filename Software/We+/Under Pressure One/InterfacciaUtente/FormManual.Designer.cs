namespace InterfacciaUtente
{
    partial class FormManual
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManual));
            this.chartVoltage = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartFlux = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnHome = new System.Windows.Forms.Button();
            this.tlpDiagnostic = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.VoltSelector = new System.Windows.Forms.NumericUpDown();
            this.btnConfigVolt = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAirOpen = new System.Windows.Forms.Button();
            this.btnAirClose = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.ledInj = new System.Windows.Forms.Label();
            this.flux = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblV = new System.Windows.Forms.Label();
            this.ledAir = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ledDoor = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPistonUp = new System.Windows.Forms.Button();
            this.btnPistonDown = new System.Windows.Forms.Button();
            this.tlbForm = new System.Windows.Forms.TableLayoutPanel();
            this.tlpChartDiagnostic = new System.Windows.Forms.TableLayoutPanel();
            this.tlpUpper = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ledCylinderDown = new System.Windows.Forms.Label();
            this.ledCylinderUp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartVoltage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFlux)).BeginInit();
            this.tlpDiagnostic.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VoltSelector)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tlbForm.SuspendLayout();
            this.tlpChartDiagnostic.SuspendLayout();
            this.tlpUpper.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartVoltage
            // 
            chartArea1.Name = "ChartArea1";
            this.chartVoltage.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartVoltage.Legends.Add(legend1);
            this.chartVoltage.Location = new System.Drawing.Point(459, 3);
            this.chartVoltage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chartVoltage.Name = "chartVoltage";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Black;
            series1.Legend = "Legend1";
            series1.Name = "Voltage";
            this.chartVoltage.Series.Add(series1);
            this.chartVoltage.Size = new System.Drawing.Size(453, 450);
            this.chartVoltage.TabIndex = 18;
            this.chartVoltage.Text = "chart2";
            // 
            // chartFlux
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFlux.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartFlux.Legends.Add(legend2);
            this.chartFlux.Location = new System.Drawing.Point(2, 3);
            this.chartFlux.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chartFlux.Name = "chartFlux";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Black;
            series2.Legend = "Legend1";
            series2.Name = "Flux";
            this.chartFlux.Series.Add(series2);
            this.chartFlux.Size = new System.Drawing.Size(453, 450);
            this.chartFlux.TabIndex = 17;
            this.chartFlux.Text = "chart1";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(174)))), ((int)(((byte)(209)))));
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(2, 3);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(107, 33);
            this.btnHome.TabIndex = 19;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // tlpDiagnostic
            // 
            this.tlpDiagnostic.ColumnCount = 2;
            this.tlpDiagnostic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDiagnostic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDiagnostic.Controls.Add(this.tableLayoutPanel3, 1, 5);
            this.tlpDiagnostic.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tlpDiagnostic.Controls.Add(this.flux, 0, 5);
            this.tlpDiagnostic.Controls.Add(this.label9, 0, 4);
            this.tlpDiagnostic.Controls.Add(this.lblV, 1, 4);
            this.tlpDiagnostic.Controls.Add(this.ledAir, 1, 3);
            this.tlpDiagnostic.Controls.Add(this.label7, 0, 0);
            this.tlpDiagnostic.Controls.Add(this.ledDoor, 1, 0);
            this.tlpDiagnostic.Controls.Add(this.label10, 0, 1);
            this.tlpDiagnostic.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tlpDiagnostic.Controls.Add(this.ledInj, 1, 1);
            this.tlpDiagnostic.Controls.Add(this.tableLayoutPanel1, 1, 2);
            this.tlpDiagnostic.Dock = System.Windows.Forms.DockStyle.Right;
            this.tlpDiagnostic.Location = new System.Drawing.Point(1006, 3);
            this.tlpDiagnostic.Name = "tlpDiagnostic";
            this.tlpDiagnostic.RowCount = 6;
            this.tlpDiagnostic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpDiagnostic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpDiagnostic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpDiagnostic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpDiagnostic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpDiagnostic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpDiagnostic.Size = new System.Drawing.Size(425, 843);
            this.tlpDiagnostic.TabIndex = 47;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.VoltSelector, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnConfigVolt, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(215, 703);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.42029F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.57971F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(207, 137);
            this.tableLayoutPanel3.TabIndex = 48;
            // 
            // VoltSelector
            // 
            this.VoltSelector.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.VoltSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F);
            this.VoltSelector.Location = new System.Drawing.Point(53, 3);
            this.VoltSelector.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.VoltSelector.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.VoltSelector.Name = "VoltSelector";
            this.VoltSelector.Size = new System.Drawing.Size(101, 46);
            this.VoltSelector.TabIndex = 15;
            // 
            // btnConfigVolt
            // 
            this.btnConfigVolt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConfigVolt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigVolt.Location = new System.Drawing.Point(29, 84);
            this.btnConfigVolt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnConfigVolt.Name = "btnConfigVolt";
            this.btnConfigVolt.Size = new System.Drawing.Size(148, 32);
            this.btnConfigVolt.TabIndex = 16;
            this.btnConfigVolt.Text = "Set";
            this.btnConfigVolt.UseVisualStyleBackColor = true;
            this.btnConfigVolt.Click += new System.EventHandler(this.btnConfigVolt_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnAirOpen, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAirClose, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 423);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(206, 134);
            this.tableLayoutPanel2.TabIndex = 48;
            // 
            // btnAirOpen
            // 
            this.btnAirOpen.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAirOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAirOpen.Location = new System.Drawing.Point(29, 32);
            this.btnAirOpen.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAirOpen.Name = "btnAirOpen";
            this.btnAirOpen.Size = new System.Drawing.Size(148, 32);
            this.btnAirOpen.TabIndex = 12;
            this.btnAirOpen.Text = "Air Open";
            this.btnAirOpen.UseVisualStyleBackColor = true;
            this.btnAirOpen.Click += new System.EventHandler(this.btnAirOpen_Click);
            // 
            // btnAirClose
            // 
            this.btnAirClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAirClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAirClose.Location = new System.Drawing.Point(29, 70);
            this.btnAirClose.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAirClose.Name = "btnAirClose";
            this.btnAirClose.Size = new System.Drawing.Size(148, 32);
            this.btnAirClose.TabIndex = 14;
            this.btnAirClose.Text = "Air Close";
            this.btnAirClose.UseVisualStyleBackColor = true;
            this.btnAirClose.Click += new System.EventHandler(this.btnAirClose_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 187);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 46);
            this.label10.TabIndex = 43;
            this.label10.Text = "Injector";
            // 
            // ledInj
            // 
            this.ledInj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ledInj.BackColor = System.Drawing.Color.Red;
            this.ledInj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.ledInj.Location = new System.Drawing.Point(230, 192);
            this.ledInj.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ledInj.Name = "ledInj";
            this.ledInj.Size = new System.Drawing.Size(177, 36);
            this.ledInj.TabIndex = 46;
            // 
            // flux
            // 
            this.flux.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flux.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flux.Location = new System.Drawing.Point(66, 700);
            this.flux.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.flux.Name = "flux";
            this.flux.Size = new System.Drawing.Size(80, 50);
            this.flux.TabIndex = 38;
            this.flux.Text = "0";
            this.flux.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(58, 654);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 46);
            this.label9.TabIndex = 37;
            this.label9.Text = "Flux";
            // 
            // lblV
            // 
            this.lblV.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblV.AutoSize = true;
            this.lblV.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblV.Location = new System.Drawing.Point(240, 654);
            this.lblV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblV.Name = "lblV";
            this.lblV.Size = new System.Drawing.Size(156, 46);
            this.lblV.TabIndex = 6;
            this.lblV.Text = "Voltage";
            // 
            // ledAir
            // 
            this.ledAir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ledAir.BackColor = System.Drawing.Color.Red;
            this.ledAir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.ledAir.Location = new System.Drawing.Point(230, 455);
            this.ledAir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ledAir.Name = "ledAir";
            this.ledAir.Size = new System.Drawing.Size(177, 70);
            this.ledAir.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 47);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 46);
            this.label7.TabIndex = 44;
            this.label7.Text = "Door";
            // 
            // ledDoor
            // 
            this.ledDoor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ledDoor.BackColor = System.Drawing.Color.Red;
            this.ledDoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.ledDoor.Location = new System.Drawing.Point(230, 52);
            this.ledDoor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ledDoor.Name = "ledDoor";
            this.ledDoor.Size = new System.Drawing.Size(177, 36);
            this.ledDoor.TabIndex = 45;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btnPistonDown, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnPistonUp, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 283);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(206, 134);
            this.tableLayoutPanel4.TabIndex = 49;
            // 
            // btnPistonUp
            // 
            this.btnPistonUp.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPistonUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPistonUp.Location = new System.Drawing.Point(29, 32);
            this.btnPistonUp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPistonUp.Name = "btnPistonUp";
            this.btnPistonUp.Size = new System.Drawing.Size(148, 32);
            this.btnPistonUp.TabIndex = 16;
            this.btnPistonUp.Text = "Upper piston";
            this.btnPistonUp.UseVisualStyleBackColor = true;
            this.btnPistonUp.Click += new System.EventHandler(this.btnPistonUp_Click);
            // 
            // btnPistonDown
            // 
            this.btnPistonDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPistonDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPistonDown.Location = new System.Drawing.Point(29, 70);
            this.btnPistonDown.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPistonDown.Name = "btnPistonDown";
            this.btnPistonDown.Size = new System.Drawing.Size(148, 32);
            this.btnPistonDown.TabIndex = 15;
            this.btnPistonDown.Text = "Lower piston";
            this.btnPistonDown.UseVisualStyleBackColor = true;
            this.btnPistonDown.Click += new System.EventHandler(this.btnPistonDown_Click);
            // 
            // tlbForm
            // 
            this.tlbForm.ColumnCount = 1;
            this.tlbForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlbForm.Controls.Add(this.tlpChartDiagnostic, 0, 1);
            this.tlbForm.Controls.Add(this.tlpUpper, 0, 0);
            this.tlbForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlbForm.Location = new System.Drawing.Point(0, 0);
            this.tlbForm.Name = "tlbForm";
            this.tlbForm.RowCount = 2;
            this.tlbForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlbForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.tlbForm.Size = new System.Drawing.Size(1440, 900);
            this.tlbForm.TabIndex = 48;
            // 
            // tlpChartDiagnostic
            // 
            this.tlpChartDiagnostic.ColumnCount = 3;
            this.tlpChartDiagnostic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.87F));
            this.tlpChartDiagnostic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.87F));
            this.tlpChartDiagnostic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.26F));
            this.tlpChartDiagnostic.Controls.Add(this.chartFlux, 0, 0);
            this.tlpChartDiagnostic.Controls.Add(this.chartVoltage, 1, 0);
            this.tlpChartDiagnostic.Controls.Add(this.tlpDiagnostic, 2, 0);
            this.tlpChartDiagnostic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpChartDiagnostic.Location = new System.Drawing.Point(3, 48);
            this.tlpChartDiagnostic.Name = "tlpChartDiagnostic";
            this.tlpChartDiagnostic.RowCount = 1;
            this.tlpChartDiagnostic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpChartDiagnostic.Size = new System.Drawing.Size(1434, 849);
            this.tlpChartDiagnostic.TabIndex = 49;
            // 
            // tlpUpper
            // 
            this.tlpUpper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(174)))), ((int)(((byte)(209)))));
            this.tlpUpper.ColumnCount = 2;
            this.tlpUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpUpper.Controls.Add(this.btnHome, 0, 0);
            this.tlpUpper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpUpper.Location = new System.Drawing.Point(3, 3);
            this.tlpUpper.Name = "tlpUpper";
            this.tlpUpper.RowCount = 1;
            this.tlpUpper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpUpper.Size = new System.Drawing.Size(1434, 39);
            this.tlpUpper.TabIndex = 50;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ledCylinderDown, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ledCylinderUp, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(215, 283);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(207, 134);
            this.tableLayoutPanel1.TabIndex = 50;
            // 
            // ledCylinderDown
            // 
            this.ledCylinderDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ledCylinderDown.BackColor = System.Drawing.Color.Red;
            this.ledCylinderDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.ledCylinderDown.Location = new System.Drawing.Point(15, 67);
            this.ledCylinderDown.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ledCylinderDown.Name = "ledCylinderDown";
            this.ledCylinderDown.Size = new System.Drawing.Size(177, 36);
            this.ledCylinderDown.TabIndex = 47;
            // 
            // ledCylinderUp
            // 
            this.ledCylinderUp.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ledCylinderUp.BackColor = System.Drawing.Color.Red;
            this.ledCylinderUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.ledCylinderUp.Location = new System.Drawing.Point(15, 31);
            this.ledCylinderUp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ledCylinderUp.Name = "ledCylinderUp";
            this.ledCylinderUp.Size = new System.Drawing.Size(177, 36);
            this.ledCylinderUp.TabIndex = 48;
            // 
            // FormManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1440, 900);
            this.Controls.Add(this.tlbForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormManual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "FormManual";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.chartVoltage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFlux)).EndInit();
            this.tlpDiagnostic.ResumeLayout(false);
            this.tlpDiagnostic.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VoltSelector)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tlbForm.ResumeLayout(false);
            this.tlpChartDiagnostic.ResumeLayout(false);
            this.tlpUpper.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVoltage;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFlux;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.TableLayoutPanel tlpDiagnostic;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.NumericUpDown VoltSelector;
        private System.Windows.Forms.Button btnConfigVolt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAirOpen;
        private System.Windows.Forms.Button btnAirClose;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label ledInj;
        private System.Windows.Forms.Label flux;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblV;
        private System.Windows.Forms.Label ledAir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ledDoor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnPistonUp;
        private System.Windows.Forms.Button btnPistonDown;
        private System.Windows.Forms.TableLayoutPanel tlbForm;
        private System.Windows.Forms.TableLayoutPanel tlpChartDiagnostic;
        private System.Windows.Forms.TableLayoutPanel tlpUpper;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label ledCylinderDown;
        private System.Windows.Forms.Label ledCylinderUp;
    }
}