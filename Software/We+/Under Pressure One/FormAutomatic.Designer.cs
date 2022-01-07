namespace InterfacciaUtente
{
    partial class FormAutomatic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAutomatic));
            this.btnHome = new System.Windows.Forms.Button();
            this.tlpForm = new System.Windows.Forms.TableLayoutPanel();
            this.tblChartDiagnostic = new System.Windows.Forms.TableLayoutPanel();
            this.tblChart = new System.Windows.Forms.TableLayoutPanel();
            this.tlpResult = new System.Windows.Forms.TableLayoutPanel();
            this.lblMaximumFlux = new System.Windows.Forms.Label();
            this.lblOV = new System.Windows.Forms.Label();
            this.lblMF = new System.Windows.Forms.Label();
            this.lblOpeningVoltage = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.chartFlux = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartVoltage = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tblDiagnostic = new System.Windows.Forms.TableLayoutPanel();
            this.flux = new System.Windows.Forms.Label();
            this.voltage = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ledAir = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ledDoor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ledInj = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ledCylinderDown = new System.Windows.Forms.Label();
            this.ledCylinderUp = new System.Windows.Forms.Label();
            this.tblUpper = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.clock = new System.Windows.Forms.Label();
            this.LblMsgUser = new System.Windows.Forms.Label();
            this.tlpForm.SuspendLayout();
            this.tblChartDiagnostic.SuspendLayout();
            this.tblChart.SuspendLayout();
            this.tlpResult.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFlux)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVoltage)).BeginInit();
            this.tblDiagnostic.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tblUpper.SuspendLayout();
            this.SuspendLayout();
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
            this.btnHome.Size = new System.Drawing.Size(150, 78);
            this.btnHome.TabIndex = 14;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // tlpForm
            // 
            this.tlpForm.ColumnCount = 1;
            this.tlpForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpForm.Controls.Add(this.tblChartDiagnostic, 0, 1);
            this.tlpForm.Controls.Add(this.tblUpper, 0, 0);
            this.tlpForm.Controls.Add(this.LblMsgUser, 0, 2);
            this.tlpForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpForm.Location = new System.Drawing.Point(0, 0);
            this.tlpForm.Margin = new System.Windows.Forms.Padding(0);
            this.tlpForm.Name = "tlpForm";
            this.tlpForm.RowCount = 3;
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpForm.Size = new System.Drawing.Size(1440, 900);
            this.tlpForm.TabIndex = 25;
            // 
            // tblChartDiagnostic
            // 
            this.tblChartDiagnostic.ColumnCount = 2;
            this.tblChartDiagnostic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.43375F));
            this.tblChartDiagnostic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.56625F));
            this.tblChartDiagnostic.Controls.Add(this.tblChart, 0, 0);
            this.tblChartDiagnostic.Controls.Add(this.tblDiagnostic, 1, 0);
            this.tblChartDiagnostic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblChartDiagnostic.Location = new System.Drawing.Point(3, 93);
            this.tblChartDiagnostic.Name = "tblChartDiagnostic";
            this.tblChartDiagnostic.RowCount = 1;
            this.tblChartDiagnostic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblChartDiagnostic.Size = new System.Drawing.Size(1434, 669);
            this.tblChartDiagnostic.TabIndex = 32;
            // 
            // tblChart
            // 
            this.tblChart.ColumnCount = 1;
            this.tblChart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblChart.Controls.Add(this.tlpResult, 0, 0);
            this.tblChart.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tblChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblChart.Location = new System.Drawing.Point(3, 3);
            this.tblChart.Name = "tblChart";
            this.tblChart.RowCount = 2;
            this.tblChart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.33898F));
            this.tblChart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.66102F));
            this.tblChart.Size = new System.Drawing.Size(960, 663);
            this.tblChart.TabIndex = 26;
            // 
            // tlpResult
            // 
            this.tlpResult.ColumnCount = 4;
            this.tlpResult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpResult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpResult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpResult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpResult.Controls.Add(this.lblMaximumFlux, 0, 0);
            this.tlpResult.Controls.Add(this.lblOV, 3, 0);
            this.tlpResult.Controls.Add(this.lblMF, 1, 0);
            this.tlpResult.Controls.Add(this.lblOpeningVoltage, 2, 0);
            this.tlpResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpResult.Location = new System.Drawing.Point(3, 3);
            this.tlpResult.Name = "tlpResult";
            this.tlpResult.RowCount = 1;
            this.tlpResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpResult.Size = new System.Drawing.Size(954, 128);
            this.tlpResult.TabIndex = 26;
            // 
            // lblMaximumFlux
            // 
            this.lblMaximumFlux.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMaximumFlux.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaximumFlux.Location = new System.Drawing.Point(111, 19);
            this.lblMaximumFlux.Name = "lblMaximumFlux";
            this.lblMaximumFlux.Size = new System.Drawing.Size(172, 90);
            this.lblMaximumFlux.TabIndex = 21;
            this.lblMaximumFlux.Text = "Maximum flow";
            this.lblMaximumFlux.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOV
            // 
            this.lblOV.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOV.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblOV.Location = new System.Drawing.Point(765, 39);
            this.lblOV.Name = "lblOV";
            this.lblOV.Size = new System.Drawing.Size(176, 50);
            this.lblOV.TabIndex = 23;
            this.lblOV.Text = "0";
            this.lblOV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMF
            // 
            this.lblMF.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMF.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblMF.Location = new System.Drawing.Point(289, 39);
            this.lblMF.Name = "lblMF";
            this.lblMF.Size = new System.Drawing.Size(175, 50);
            this.lblMF.TabIndex = 22;
            this.lblMF.Text = "0";
            this.lblMF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOpeningVoltage
            // 
            this.lblOpeningVoltage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblOpeningVoltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpeningVoltage.Location = new System.Drawing.Point(598, 19);
            this.lblOpeningVoltage.Name = "lblOpeningVoltage";
            this.lblOpeningVoltage.Size = new System.Drawing.Size(161, 90);
            this.lblOpeningVoltage.TabIndex = 20;
            this.lblOpeningVoltage.Text = "Opening voltage";
            this.lblOpeningVoltage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.chartFlux, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.chartVoltage, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 137);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(954, 523);
            this.tableLayoutPanel5.TabIndex = 25;
            // 
            // chartFlux
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFlux.ChartAreas.Add(chartArea1);
            this.chartFlux.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chartFlux.Legends.Add(legend1);
            this.chartFlux.Location = new System.Drawing.Point(2, 3);
            this.chartFlux.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chartFlux.Name = "chartFlux";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Black;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            series1.Legend = "Legend1";
            series1.MarkerSize = 3;
            series1.Name = "Flow";
            this.chartFlux.Series.Add(series1);
            this.chartFlux.Size = new System.Drawing.Size(473, 448);
            this.chartFlux.TabIndex = 12;
            this.chartFlux.Text = "chart1";
            // 
            // chartVoltage
            // 
            chartArea2.Name = "ChartArea1";
            this.chartVoltage.ChartAreas.Add(chartArea2);
            this.chartVoltage.Dock = System.Windows.Forms.DockStyle.Top;
            legend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chartVoltage.Legends.Add(legend2);
            this.chartVoltage.Location = new System.Drawing.Point(479, 3);
            this.chartVoltage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chartVoltage.Name = "chartVoltage";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Black;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            series2.LabelForeColor = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "Voltage";
            this.chartVoltage.Series.Add(series2);
            this.chartVoltage.Size = new System.Drawing.Size(473, 448);
            this.chartVoltage.TabIndex = 13;
            this.chartVoltage.Text = "chart2";
            // 
            // tblDiagnostic
            // 
            this.tblDiagnostic.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tblDiagnostic.ColumnCount = 2;
            this.tblDiagnostic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDiagnostic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDiagnostic.Controls.Add(this.flux, 0, 5);
            this.tblDiagnostic.Controls.Add(this.voltage, 1, 5);
            this.tblDiagnostic.Controls.Add(this.label6, 1, 4);
            this.tblDiagnostic.Controls.Add(this.label11, 0, 3);
            this.tblDiagnostic.Controls.Add(this.ledAir, 1, 3);
            this.tblDiagnostic.Controls.Add(this.label9, 0, 4);
            this.tblDiagnostic.Controls.Add(this.label7, 0, 0);
            this.tblDiagnostic.Controls.Add(this.ledDoor, 1, 0);
            this.tblDiagnostic.Controls.Add(this.label2, 0, 2);
            this.tblDiagnostic.Controls.Add(this.label4, 0, 1);
            this.tblDiagnostic.Controls.Add(this.ledInj, 1, 1);
            this.tblDiagnostic.Controls.Add(this.tableLayoutPanel1, 1, 2);
            this.tblDiagnostic.Location = new System.Drawing.Point(1002, 9);
            this.tblDiagnostic.Name = "tblDiagnostic";
            this.tblDiagnostic.RowCount = 6;
            this.tblDiagnostic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblDiagnostic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblDiagnostic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblDiagnostic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblDiagnostic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.745128F));
            this.tblDiagnostic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.68816F));
            this.tblDiagnostic.Size = new System.Drawing.Size(429, 650);
            this.tblDiagnostic.TabIndex = 31;
            // 
            // flux
            // 
            this.flux.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flux.BackColor = System.Drawing.Color.Transparent;
            this.flux.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.flux.Location = new System.Drawing.Point(25, 495);
            this.flux.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.flux.Name = "flux";
            this.flux.Size = new System.Drawing.Size(164, 50);
            this.flux.TabIndex = 28;
            this.flux.Text = "0";
            this.flux.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // voltage
            // 
            this.voltage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.voltage.BackColor = System.Drawing.Color.Transparent;
            this.voltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.voltage.Location = new System.Drawing.Point(281, 495);
            this.voltage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.voltage.Name = "voltage";
            this.voltage.Size = new System.Drawing.Size(80, 50);
            this.voltage.TabIndex = 20;
            this.voltage.Text = "0";
            this.voltage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label6.Location = new System.Drawing.Point(243, 449);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 46);
            this.label6.TabIndex = 19;
            this.label6.Text = "Voltage";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label11.Location = new System.Drawing.Point(72, 355);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 46);
            this.label11.TabIndex = 23;
            this.label11.Text = "Air";
            // 
            // ledAir
            // 
            this.ledAir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ledAir.BackColor = System.Drawing.Color.Red;
            this.ledAir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.ledAir.Location = new System.Drawing.Point(233, 360);
            this.ledAir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ledAir.Name = "ledAir";
            this.ledAir.Size = new System.Drawing.Size(177, 36);
            this.ledAir.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label9.Location = new System.Drawing.Point(54, 449);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 46);
            this.label9.TabIndex = 27;
            this.label9.Text = "Flow";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label7.Location = new System.Drawing.Point(53, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 46);
            this.label7.TabIndex = 25;
            this.label7.Text = "Door";
            // 
            // ledDoor
            // 
            this.ledDoor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ledDoor.BackColor = System.Drawing.Color.Red;
            this.ledDoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.ledDoor.Location = new System.Drawing.Point(233, 36);
            this.ledDoor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ledDoor.Name = "ledDoor";
            this.ledDoor.Size = new System.Drawing.Size(177, 36);
            this.ledDoor.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label2.Location = new System.Drawing.Point(41, 247);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 46);
            this.label2.TabIndex = 25;
            this.label2.Text = "Piston";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label4.Location = new System.Drawing.Point(31, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 46);
            this.label4.TabIndex = 0;
            this.label4.Text = "Injector";
            // 
            // ledInj
            // 
            this.ledInj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ledInj.BackColor = System.Drawing.Color.Red;
            this.ledInj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.ledInj.Location = new System.Drawing.Point(233, 144);
            this.ledInj.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ledInj.Name = "ledInj";
            this.ledInj.Size = new System.Drawing.Size(177, 36);
            this.ledInj.TabIndex = 30;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ledCylinderDown, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ledCylinderUp, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(217, 219);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 31;
            // 
            // ledCylinderDown
            // 
            this.ledCylinderDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ledCylinderDown.BackColor = System.Drawing.Color.Red;
            this.ledCylinderDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.ledCylinderDown.Location = new System.Drawing.Point(11, 50);
            this.ledCylinderDown.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ledCylinderDown.Name = "ledCylinderDown";
            this.ledCylinderDown.Size = new System.Drawing.Size(177, 36);
            this.ledCylinderDown.TabIndex = 33;
            this.ledCylinderDown.Text = "Down";
            this.ledCylinderDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledCylinderUp
            // 
            this.ledCylinderUp.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ledCylinderUp.BackColor = System.Drawing.Color.Red;
            this.ledCylinderUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.ledCylinderUp.Location = new System.Drawing.Point(11, 14);
            this.ledCylinderUp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ledCylinderUp.Name = "ledCylinderUp";
            this.ledCylinderUp.Size = new System.Drawing.Size(177, 36);
            this.ledCylinderUp.TabIndex = 32;
            this.ledCylinderUp.Text = "Up";
            this.ledCylinderUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblUpper
            // 
            this.tblUpper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(174)))), ((int)(((byte)(209)))));
            this.tblUpper.ColumnCount = 3;
            this.tblUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblUpper.Controls.Add(this.btnHome, 0, 0);
            this.tblUpper.Controls.Add(this.label1, 1, 0);
            this.tblUpper.Controls.Add(this.clock, 2, 0);
            this.tblUpper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblUpper.Location = new System.Drawing.Point(3, 3);
            this.tblUpper.Name = "tblUpper";
            this.tblUpper.RowCount = 1;
            this.tblUpper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblUpper.Size = new System.Drawing.Size(1434, 84);
            this.tblUpper.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(481, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 84);
            this.label1.TabIndex = 15;
            this.label1.Text = "AUTOMATIC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clock
            // 
            this.clock.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.clock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(174)))), ((int)(((byte)(209)))));
            this.clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.clock.ForeColor = System.Drawing.Color.White;
            this.clock.Location = new System.Drawing.Point(1315, 29);
            this.clock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(117, 26);
            this.clock.TabIndex = 16;
            this.clock.Text = "HH:mm:ss";
            // 
            // LblMsgUser
            // 
            this.LblMsgUser.AutoSize = true;
            this.LblMsgUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblMsgUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblMsgUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMsgUser.Location = new System.Drawing.Point(3, 765);
            this.LblMsgUser.Name = "LblMsgUser";
            this.LblMsgUser.Size = new System.Drawing.Size(1434, 135);
            this.LblMsgUser.TabIndex = 33;
            this.LblMsgUser.Text = "Message user";
            this.LblMsgUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAutomatic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1440, 900);
            this.Controls.Add(this.tlpForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormAutomatic";
            this.Text = "FormAutomatic";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormAutomatic_Load);
            this.tlpForm.ResumeLayout(false);
            this.tlpForm.PerformLayout();
            this.tblChartDiagnostic.ResumeLayout(false);
            this.tblChart.ResumeLayout(false);
            this.tlpResult.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFlux)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVoltage)).EndInit();
            this.tblDiagnostic.ResumeLayout(false);
            this.tblDiagnostic.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tblUpper.ResumeLayout(false);
            this.tblUpper.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.TableLayoutPanel tlpForm;
        private System.Windows.Forms.TableLayoutPanel tblUpper;
        private System.Windows.Forms.TableLayoutPanel tblChartDiagnostic;
        private System.Windows.Forms.TableLayoutPanel tblChart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFlux;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVoltage;
        private System.Windows.Forms.TableLayoutPanel tblDiagnostic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ledInj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label ledAir;
        private System.Windows.Forms.Label ledDoor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMaximumFlux;
        private System.Windows.Forms.Label lblOV;
        private System.Windows.Forms.Label lblOpeningVoltage;
        private System.Windows.Forms.Label lblMF;
        private System.Windows.Forms.TableLayoutPanel tlpResult;
        private System.Windows.Forms.Label LblMsgUser;
        private System.Windows.Forms.Label flux;
        private System.Windows.Forms.Label voltage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label ledCylinderDown;
        private System.Windows.Forms.Label ledCylinderUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label clock;
    }
}