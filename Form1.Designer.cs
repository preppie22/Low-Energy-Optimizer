namespace Low_Energy_Optimizer
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.serversPerRack = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cpuSpeedLabel = new System.Windows.Forms.Label();
            this.cpuSpeedSelector = new System.Windows.Forms.TrackBar();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.psuLabel = new System.Windows.Forms.Label();
            this.psuSelector = new System.Windows.Forms.TrackBar();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.nodeIdlePower = new System.Windows.Forms.NumericUpDown();
            this.nodePeakPower = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.runButton = new System.Windows.Forms.Button();
            this.elapsedTimeLabel = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.simSpeedLabel = new System.Windows.Forms.Label();
            this.simSpeedSelector = new System.Windows.Forms.TrackBar();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.processBoundRadio = new System.Windows.Forms.RadioButton();
            this.infiniteRadio = new System.Windows.Forms.RadioButton();
            this.resetButton = new System.Windows.Forms.Button();
            this.startServer = new System.Windows.Forms.Button();
            this.processView = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.powerDrawLabel = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.rackPowerLabel = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.hvacPowerLabel = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.totalPowerLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.ambTempLabel = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.rackTempLabel = new System.Windows.Forms.Label();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.outdoorTempLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.hvacRuntimeLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processQueueGenerator = new System.ComponentModel.BackgroundWorker();
            this.runner = new System.ComponentModel.BackgroundWorker();
            this.temperatureControl = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serversPerRack)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpuSpeedSelector)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.psuSelector)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nodeIdlePower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodePeakPower)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.simSpeedSelector)).BeginInit();
            this.groupBox14.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processView)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.processView, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.71323F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.28676F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1200, 618);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 458);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(693, 157);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "System Variables";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox9, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox5, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox7, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(687, 138);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.tableLayoutPanel5);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox9.Location = new System.Drawing.Point(346, 72);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(338, 63);
            this.groupBox9.TabIndex = 3;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Rack Configuration";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.93052F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.06949F));
            this.tableLayoutPanel5.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.serversPerRack, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(332, 44);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(13, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = " Servers per Rack";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // serversPerRack
            // 
            this.serversPerRack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serversPerRack.Location = new System.Drawing.Point(112, 3);
            this.serversPerRack.Maximum = new decimal(new int[] {
            42,
            0,
            0,
            0});
            this.serversPerRack.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.serversPerRack.Name = "serversPerRack";
            this.serversPerRack.Size = new System.Drawing.Size(217, 20);
            this.serversPerRack.TabIndex = 1;
            this.serversPerRack.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.serversPerRack.ValueChanged += new System.EventHandler(this.computePower);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cpuSpeedLabel);
            this.groupBox3.Controls.Add(this.cpuSpeedSelector);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(337, 63);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CPU Frequency";
            // 
            // cpuSpeedLabel
            // 
            this.cpuSpeedLabel.AutoSize = true;
            this.cpuSpeedLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cpuSpeedLabel.Location = new System.Drawing.Point(3, 47);
            this.cpuSpeedLabel.Name = "cpuSpeedLabel";
            this.cpuSpeedLabel.Size = new System.Drawing.Size(35, 13);
            this.cpuSpeedLabel.TabIndex = 1;
            this.cpuSpeedLabel.Text = "label2";
            // 
            // cpuSpeedSelector
            // 
            this.cpuSpeedSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpuSpeedSelector.LargeChange = 10;
            this.cpuSpeedSelector.Location = new System.Drawing.Point(3, 16);
            this.cpuSpeedSelector.Maximum = 100;
            this.cpuSpeedSelector.Minimum = 10;
            this.cpuSpeedSelector.Name = "cpuSpeedSelector";
            this.cpuSpeedSelector.Size = new System.Drawing.Size(331, 44);
            this.cpuSpeedSelector.SmallChange = 10;
            this.cpuSpeedSelector.TabIndex = 0;
            this.cpuSpeedSelector.TickFrequency = 10;
            this.cpuSpeedSelector.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.cpuSpeedSelector.Value = 10;
            this.cpuSpeedSelector.ValueChanged += new System.EventHandler(this.cpuSpeedSelector_ValueChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.psuLabel);
            this.groupBox5.Controls.Add(this.psuSelector);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(346, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(338, 63);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Power Supply Efficiency";
            // 
            // psuLabel
            // 
            this.psuLabel.AutoSize = true;
            this.psuLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.psuLabel.Location = new System.Drawing.Point(3, 47);
            this.psuLabel.Name = "psuLabel";
            this.psuLabel.Size = new System.Drawing.Size(35, 13);
            this.psuLabel.TabIndex = 1;
            this.psuLabel.Text = "label1";
            // 
            // psuSelector
            // 
            this.psuSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.psuSelector.LargeChange = 10;
            this.psuSelector.Location = new System.Drawing.Point(3, 16);
            this.psuSelector.Maximum = 100;
            this.psuSelector.Minimum = 50;
            this.psuSelector.Name = "psuSelector";
            this.psuSelector.Size = new System.Drawing.Size(332, 44);
            this.psuSelector.SmallChange = 10;
            this.psuSelector.TabIndex = 0;
            this.psuSelector.TickFrequency = 10;
            this.psuSelector.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.psuSelector.Value = 50;
            this.psuSelector.ValueChanged += new System.EventHandler(this.psuSelector_ValueChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.tableLayoutPanel4);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(3, 72);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(337, 63);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Node Power Rating";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.93052F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.06949F));
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.nodeIdlePower, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.nodePeakPower, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(331, 44);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(26, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = " Idle Power (W)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nodeIdlePower
            // 
            this.nodeIdlePower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nodeIdlePower.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nodeIdlePower.Location = new System.Drawing.Point(112, 3);
            this.nodeIdlePower.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nodeIdlePower.Name = "nodeIdlePower";
            this.nodeIdlePower.Size = new System.Drawing.Size(216, 20);
            this.nodeIdlePower.TabIndex = 1;
            this.nodeIdlePower.ValueChanged += new System.EventHandler(this.computePower);
            // 
            // nodePeakPower
            // 
            this.nodePeakPower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nodePeakPower.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nodePeakPower.Location = new System.Drawing.Point(112, 25);
            this.nodePeakPower.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nodePeakPower.Name = "nodePeakPower";
            this.nodePeakPower.Size = new System.Drawing.Size(216, 20);
            this.nodePeakPower.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(21, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Peak Power (W)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(702, 458);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(495, 157);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Simulation Controls";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.runButton, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.elapsedTimeLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.groupBox4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox14, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.resetButton, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.startServer, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(489, 138);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // runButton
            // 
            this.runButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.runButton.Location = new System.Drawing.Point(3, 72);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(287, 35);
            this.runButton.TabIndex = 0;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // elapsedTimeLabel
            // 
            this.elapsedTimeLabel.AutoSize = true;
            this.elapsedTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elapsedTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elapsedTimeLabel.Location = new System.Drawing.Point(3, 110);
            this.elapsedTimeLabel.Name = "elapsedTimeLabel";
            this.elapsedTimeLabel.Size = new System.Drawing.Size(287, 28);
            this.elapsedTimeLabel.TabIndex = 4;
            this.elapsedTimeLabel.Text = "label2";
            this.elapsedTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.simSpeedLabel);
            this.groupBox4.Controls.Add(this.simSpeedSelector);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(287, 63);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Simulation Speed";
            // 
            // simSpeedLabel
            // 
            this.simSpeedLabel.AutoSize = true;
            this.simSpeedLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.simSpeedLabel.Location = new System.Drawing.Point(3, 47);
            this.simSpeedLabel.Name = "simSpeedLabel";
            this.simSpeedLabel.Size = new System.Drawing.Size(29, 13);
            this.simSpeedLabel.TabIndex = 3;
            this.simSpeedLabel.Text = "NaN";
            this.simSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // simSpeedSelector
            // 
            this.simSpeedSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simSpeedSelector.LargeChange = 50;
            this.simSpeedSelector.Location = new System.Drawing.Point(3, 16);
            this.simSpeedSelector.Maximum = 800;
            this.simSpeedSelector.Minimum = 100;
            this.simSpeedSelector.Name = "simSpeedSelector";
            this.simSpeedSelector.Size = new System.Drawing.Size(281, 44);
            this.simSpeedSelector.SmallChange = 50;
            this.simSpeedSelector.TabIndex = 2;
            this.simSpeedSelector.TickFrequency = 50;
            this.simSpeedSelector.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.simSpeedSelector.Value = 200;
            this.simSpeedSelector.ValueChanged += new System.EventHandler(this.simSpeedSelector_ValueChanged);
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.flowLayoutPanel4);
            this.groupBox14.Location = new System.Drawing.Point(296, 3);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(190, 63);
            this.groupBox14.TabIndex = 7;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Duration";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.processBoundRadio);
            this.flowLayoutPanel4.Controls.Add(this.infiniteRadio);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(184, 44);
            this.flowLayoutPanel4.TabIndex = 0;
            // 
            // processBoundRadio
            // 
            this.processBoundRadio.AutoSize = true;
            this.processBoundRadio.Location = new System.Drawing.Point(3, 3);
            this.processBoundRadio.Name = "processBoundRadio";
            this.processBoundRadio.Size = new System.Drawing.Size(121, 17);
            this.processBoundRadio.TabIndex = 0;
            this.processBoundRadio.TabStop = true;
            this.processBoundRadio.Text = "Processes Complete";
            this.processBoundRadio.UseVisualStyleBackColor = true;
            this.processBoundRadio.CheckedChanged += new System.EventHandler(this.processBoundRadio_CheckedChanged);
            // 
            // infiniteRadio
            // 
            this.infiniteRadio.AutoSize = true;
            this.infiniteRadio.Location = new System.Drawing.Point(3, 26);
            this.infiniteRadio.Name = "infiniteRadio";
            this.infiniteRadio.Size = new System.Drawing.Size(61, 17);
            this.infiniteRadio.TabIndex = 1;
            this.infiniteRadio.TabStop = true;
            this.infiniteRadio.Text = "Forever";
            this.infiniteRadio.UseVisualStyleBackColor = true;
            this.infiniteRadio.CheckedChanged += new System.EventHandler(this.processBoundRadio_CheckedChanged);
            // 
            // resetButton
            // 
            this.resetButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resetButton.Location = new System.Drawing.Point(296, 113);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(190, 22);
            this.resetButton.TabIndex = 9;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // startServer
            // 
            this.startServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startServer.Location = new System.Drawing.Point(296, 72);
            this.startServer.Name = "startServer";
            this.startServer.Size = new System.Drawing.Size(190, 35);
            this.startServer.TabIndex = 10;
            this.startServer.Text = "Start Server";
            this.startServer.UseVisualStyleBackColor = true;
            this.startServer.Click += new System.EventHandler(this.startServer_Click);
            // 
            // processView
            // 
            this.processView.AllowUserToAddRows = false;
            this.processView.AllowUserToDeleteRows = false;
            this.processView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.processView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processView.Location = new System.Drawing.Point(702, 3);
            this.processView.Name = "processView";
            this.processView.ReadOnly = true;
            this.processView.Size = new System.Drawing.Size(495, 449);
            this.processView.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(693, 449);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.groupBox6);
            this.flowLayoutPanel2.Controls.Add(this.groupBox10);
            this.flowLayoutPanel2.Controls.Add(this.groupBox12);
            this.flowLayoutPanel2.Controls.Add(this.groupBox8);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(677, 69);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // groupBox6
            // 
            this.groupBox6.AutoSize = true;
            this.groupBox6.Controls.Add(this.powerDrawLabel);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox6.Location = new System.Drawing.Point(3, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(124, 61);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Node Power";
            // 
            // powerDrawLabel
            // 
            this.powerDrawLabel.AutoSize = true;
            this.powerDrawLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.powerDrawLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerDrawLabel.Location = new System.Drawing.Point(3, 16);
            this.powerDrawLabel.Name = "powerDrawLabel";
            this.powerDrawLabel.Size = new System.Drawing.Size(118, 42);
            this.powerDrawLabel.TabIndex = 0;
            this.powerDrawLabel.Text = "label1";
            this.powerDrawLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox10
            // 
            this.groupBox10.AutoSize = true;
            this.groupBox10.Controls.Add(this.rackPowerLabel);
            this.groupBox10.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox10.Location = new System.Drawing.Point(133, 3);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(124, 61);
            this.groupBox10.TabIndex = 3;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Rack Power";
            // 
            // rackPowerLabel
            // 
            this.rackPowerLabel.AutoSize = true;
            this.rackPowerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rackPowerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rackPowerLabel.Location = new System.Drawing.Point(3, 16);
            this.rackPowerLabel.Name = "rackPowerLabel";
            this.rackPowerLabel.Size = new System.Drawing.Size(118, 42);
            this.rackPowerLabel.TabIndex = 0;
            this.rackPowerLabel.Text = "label1";
            this.rackPowerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox12
            // 
            this.groupBox12.AutoSize = true;
            this.groupBox12.Controls.Add(this.hvacPowerLabel);
            this.groupBox12.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox12.Location = new System.Drawing.Point(263, 3);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(124, 61);
            this.groupBox12.TabIndex = 5;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "HVAC Power";
            // 
            // hvacPowerLabel
            // 
            this.hvacPowerLabel.AutoSize = true;
            this.hvacPowerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hvacPowerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hvacPowerLabel.Location = new System.Drawing.Point(3, 16);
            this.hvacPowerLabel.Name = "hvacPowerLabel";
            this.hvacPowerLabel.Size = new System.Drawing.Size(118, 42);
            this.hvacPowerLabel.TabIndex = 0;
            this.hvacPowerLabel.Text = "label1";
            this.hvacPowerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox8
            // 
            this.groupBox8.AutoSize = true;
            this.groupBox8.Controls.Add(this.totalPowerLabel);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox8.Location = new System.Drawing.Point(393, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(124, 61);
            this.groupBox8.TabIndex = 6;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Total Power";
            // 
            // totalPowerLabel
            // 
            this.totalPowerLabel.AutoSize = true;
            this.totalPowerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalPowerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPowerLabel.Location = new System.Drawing.Point(3, 16);
            this.totalPowerLabel.Name = "totalPowerLabel";
            this.totalPowerLabel.Size = new System.Drawing.Size(118, 42);
            this.totalPowerLabel.TabIndex = 0;
            this.totalPowerLabel.Text = "label1";
            this.totalPowerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.groupBox11);
            this.flowLayoutPanel3.Controls.Add(this.groupBox13);
            this.flowLayoutPanel3.Controls.Add(this.groupBox16);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 78);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(677, 72);
            this.flowLayoutPanel3.TabIndex = 5;
            // 
            // groupBox11
            // 
            this.groupBox11.AutoSize = true;
            this.groupBox11.Controls.Add(this.ambTempLabel);
            this.groupBox11.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox11.Location = new System.Drawing.Point(3, 3);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(145, 61);
            this.groupBox11.TabIndex = 2;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Ambient Temperature";
            // 
            // ambTempLabel
            // 
            this.ambTempLabel.AutoSize = true;
            this.ambTempLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ambTempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ambTempLabel.Location = new System.Drawing.Point(3, 16);
            this.ambTempLabel.Name = "ambTempLabel";
            this.ambTempLabel.Size = new System.Drawing.Size(139, 42);
            this.ambTempLabel.TabIndex = 0;
            this.ambTempLabel.Text = "label11";
            this.ambTempLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox13
            // 
            this.groupBox13.AutoSize = true;
            this.groupBox13.Controls.Add(this.rackTempLabel);
            this.groupBox13.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox13.Location = new System.Drawing.Point(154, 3);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(145, 61);
            this.groupBox13.TabIndex = 3;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Rack Temperature";
            // 
            // rackTempLabel
            // 
            this.rackTempLabel.AutoSize = true;
            this.rackTempLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rackTempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rackTempLabel.Location = new System.Drawing.Point(3, 16);
            this.rackTempLabel.Name = "rackTempLabel";
            this.rackTempLabel.Size = new System.Drawing.Size(139, 42);
            this.rackTempLabel.TabIndex = 0;
            this.rackTempLabel.Text = "label11";
            this.rackTempLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox16
            // 
            this.groupBox16.AutoSize = true;
            this.groupBox16.Controls.Add(this.outdoorTempLabel);
            this.groupBox16.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox16.Location = new System.Drawing.Point(305, 3);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(145, 61);
            this.groupBox16.TabIndex = 4;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Outdoor Temperature";
            // 
            // outdoorTempLabel
            // 
            this.outdoorTempLabel.AutoSize = true;
            this.outdoorTempLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outdoorTempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outdoorTempLabel.Location = new System.Drawing.Point(3, 16);
            this.outdoorTempLabel.Name = "outdoorTempLabel";
            this.outdoorTempLabel.Size = new System.Drawing.Size(139, 42);
            this.outdoorTempLabel.TabIndex = 0;
            this.outdoorTempLabel.Text = "label11";
            this.outdoorTempLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.groupBox15);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 156);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(677, 68);
            this.flowLayoutPanel5.TabIndex = 6;
            // 
            // groupBox15
            // 
            this.groupBox15.AutoSize = true;
            this.groupBox15.Controls.Add(this.hvacRuntimeLabel);
            this.groupBox15.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox15.Location = new System.Drawing.Point(3, 3);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(124, 61);
            this.groupBox15.TabIndex = 7;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "HVAC Run Time";
            // 
            // hvacRuntimeLabel
            // 
            this.hvacRuntimeLabel.AutoSize = true;
            this.hvacRuntimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hvacRuntimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hvacRuntimeLabel.Location = new System.Drawing.Point(3, 16);
            this.hvacRuntimeLabel.Name = "hvacRuntimeLabel";
            this.hvacRuntimeLabel.Size = new System.Drawing.Size(118, 42);
            this.hvacRuntimeLabel.TabIndex = 0;
            this.hvacRuntimeLabel.Text = "label1";
            this.hvacRuntimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusProgress,
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 642);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1200, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusProgress
            // 
            this.statusProgress.Name = "statusProgress";
            this.statusProgress.Size = new System.Drawing.Size(100, 16);
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(26, 17);
            this.statusLabel.Text = "Idle";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadCSVToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadCSVToolStripMenuItem
            // 
            this.loadCSVToolStripMenuItem.Name = "loadCSVToolStripMenuItem";
            this.loadCSVToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.loadCSVToolStripMenuItem.Text = "Load CSV...";
            this.loadCSVToolStripMenuItem.Click += new System.EventHandler(this.loadCSVToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // processQueueGenerator
            // 
            this.processQueueGenerator.DoWork += new System.ComponentModel.DoWorkEventHandler(this.processQueueGenerator_DoWork);
            this.processQueueGenerator.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.processQueueGenerator_ProgressChanged);
            this.processQueueGenerator.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.processQueueGenerator_RunWorkerCompleted);
            // 
            // runner
            // 
            this.runner.WorkerReportsProgress = true;
            this.runner.WorkerSupportsCancellation = true;
            this.runner.DoWork += new System.ComponentModel.DoWorkEventHandler(this.runner_DoWork);
            this.runner.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.runner_ProgressChanged);
            this.runner.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.runner_RunWorkerCompleted);
            // 
            // temperatureControl
            // 
            this.temperatureControl.WorkerReportsProgress = true;
            this.temperatureControl.DoWork += new System.ComponentModel.DoWorkEventHandler(this.temperatureControl_DoWork);
            this.temperatureControl.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.temperatureControl_ProgressChanged);
            this.temperatureControl.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.temperatureControl_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 664);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serversPerRack)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpuSpeedSelector)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.psuSelector)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nodeIdlePower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodePeakPower)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.simSpeedSelector)).EndInit();
            this.groupBox14.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processView)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripProgressBar statusProgress;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.ComponentModel.BackgroundWorker processQueueGenerator;
        private System.Windows.Forms.DataGridView processView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button runButton;
        private System.ComponentModel.BackgroundWorker runner;
        private System.Windows.Forms.TrackBar simSpeedSelector;
        private System.Windows.Forms.Label simSpeedLabel;
        private System.Windows.Forms.Label elapsedTimeLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label cpuSpeedLabel;
        private System.Windows.Forms.TrackBar cpuSpeedSelector;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label psuLabel;
        private System.Windows.Forms.TrackBar psuSelector;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nodeIdlePower;
        private System.Windows.Forms.NumericUpDown nodePeakPower;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown serversPerRack;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label powerDrawLabel;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label rackPowerLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Label hvacPowerLabel;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label totalPowerLabel;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label ambTempLabel;
        private System.ComponentModel.BackgroundWorker temperatureControl;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Label rackTempLabel;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.RadioButton processBoundRadio;
        private System.Windows.Forms.RadioButton infiniteRadio;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button startServer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.Label hvacRuntimeLabel;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.Label outdoorTempLabel;
    }
}

