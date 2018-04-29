namespace BatchConverterProfiler
{
    partial class MainForm
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
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pbToolstrip = new System.Windows.Forms.ToolStripProgressBar();
            this.ofdInput = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cbSharpen = new System.Windows.Forms.CheckBox();
            this.cbEnhance = new System.Windows.Forms.CheckBox();
            this.tNoise = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.tbNoise = new System.Windows.Forms.TrackBar();
            this.tGamma = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.tbGamma = new System.Windows.Forms.TrackBar();
            this.bOrderDown = new System.Windows.Forms.Button();
            this.bOrderUp = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lOrder = new System.Windows.Forms.ListBox();
            this.cbTreshold = new System.Windows.Forms.CheckBox();
            this.tTreshold = new System.Windows.Forms.NumericUpDown();
            this.tbTreshold = new System.Windows.Forms.TrackBar();
            this.tContrast = new System.Windows.Forms.NumericUpDown();
            this.tBrightness = new System.Windows.Forms.NumericUpDown();
            this.bInputChoose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbContrast = new System.Windows.Forms.TrackBar();
            this.tbBrightness = new System.Windows.Forms.TrackBar();
            this.bSave = new System.Windows.Forms.Button();
            this.tableLayoutPreview = new System.Windows.Forms.TableLayoutPanel();
            this.gbAfter = new System.Windows.Forms.GroupBox();
            this.pAfter = new System.Windows.Forms.Panel();
            this.lAfter = new System.Windows.Forms.Label();
            this.pbAfter = new System.Windows.Forms.PictureBox();
            this.gbBefore = new System.Windows.Forms.GroupBox();
            this.pBefore = new System.Windows.Forms.Panel();
            this.lBefore = new System.Windows.Forms.Label();
            this.pbBefore = new System.Windows.Forms.PictureBox();
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            this.sfdProfile = new System.Windows.Forms.SaveFileDialog();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.bLoad = new System.Windows.Forms.Button();
            this.ofdProfile = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tNoise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNoise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tGamma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGamma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBrightness)).BeginInit();
            this.tableLayoutPreview.SuspendLayout();
            this.gbAfter.SuspendLayout();
            this.pAfter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAfter)).BeginInit();
            this.gbBefore.SuspendLayout();
            this.pBefore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBefore)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pbToolstrip});
            this.statusStrip1.Location = new System.Drawing.Point(0, 583);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(984, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "sStatus";
            // 
            // pbToolstrip
            // 
            this.pbToolstrip.Name = "pbToolstrip";
            this.pbToolstrip.Size = new System.Drawing.Size(100, 16);
            this.pbToolstrip.Visible = false;
            // 
            // ofdInput
            // 
            this.ofdInput.Title = "Choose your files";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.bLoad);
            this.splitContainer1.Panel1.Controls.Add(this.cbSharpen);
            this.splitContainer1.Panel1.Controls.Add(this.cbEnhance);
            this.splitContainer1.Panel1.Controls.Add(this.tNoise);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.tbNoise);
            this.splitContainer1.Panel1.Controls.Add(this.tGamma);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.tbGamma);
            this.splitContainer1.Panel1.Controls.Add(this.bOrderDown);
            this.splitContainer1.Panel1.Controls.Add(this.bOrderUp);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.lOrder);
            this.splitContainer1.Panel1.Controls.Add(this.cbTreshold);
            this.splitContainer1.Panel1.Controls.Add(this.tTreshold);
            this.splitContainer1.Panel1.Controls.Add(this.tbTreshold);
            this.splitContainer1.Panel1.Controls.Add(this.tContrast);
            this.splitContainer1.Panel1.Controls.Add(this.tBrightness);
            this.splitContainer1.Panel1.Controls.Add(this.bInputChoose);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.tbContrast);
            this.splitContainer1.Panel1.Controls.Add(this.tbBrightness);
            this.splitContainer1.Panel1.Controls.Add(this.bSave);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPreview);
            this.splitContainer1.Size = new System.Drawing.Size(984, 583);
            this.splitContainer1.SplitterDistance = 476;
            this.splitContainer1.TabIndex = 20;
            // 
            // cbSharpen
            // 
            this.cbSharpen.AutoSize = true;
            this.cbSharpen.Location = new System.Drawing.Point(45, 295);
            this.cbSharpen.Name = "cbSharpen";
            this.cbSharpen.Size = new System.Drawing.Size(66, 17);
            this.cbSharpen.TabIndex = 67;
            this.cbSharpen.Text = "Sharpen";
            this.cbSharpen.UseVisualStyleBackColor = true;
            this.cbSharpen.CheckedChanged += new System.EventHandler(this.cbSharpen_CheckedChanged);
            // 
            // cbEnhance
            // 
            this.cbEnhance.AutoSize = true;
            this.cbEnhance.Location = new System.Drawing.Point(45, 260);
            this.cbEnhance.Name = "cbEnhance";
            this.cbEnhance.Size = new System.Drawing.Size(69, 17);
            this.cbEnhance.TabIndex = 66;
            this.cbEnhance.Text = "Enhance";
            this.cbEnhance.UseVisualStyleBackColor = true;
            this.cbEnhance.CheckedChanged += new System.EventHandler(this.cbEnhance_CheckedChanged);
            // 
            // tNoise
            // 
            this.tNoise.Location = new System.Drawing.Point(221, 302);
            this.tNoise.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.tNoise.Name = "tNoise";
            this.tNoise.Size = new System.Drawing.Size(38, 20);
            this.tNoise.TabIndex = 65;
            this.tNoise.ValueChanged += new System.EventHandler(this.tNoise_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(193, 261);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 64;
            this.label10.Text = "Noise Filter Level";
            // 
            // tbNoise
            // 
            this.tbNoise.LargeChange = 1;
            this.tbNoise.Location = new System.Drawing.Point(156, 277);
            this.tbNoise.Maximum = 4;
            this.tbNoise.Name = "tbNoise";
            this.tbNoise.Size = new System.Drawing.Size(162, 45);
            this.tbNoise.TabIndex = 63;
            this.tbNoise.ValueChanged += new System.EventHandler(this.tbNoise_ValueChanged);
            // 
            // tGamma
            // 
            this.tGamma.DecimalPlaces = 2;
            this.tGamma.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.tGamma.Location = new System.Drawing.Point(382, 121);
            this.tGamma.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            65536});
            this.tGamma.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.tGamma.Name = "tGamma";
            this.tGamma.Size = new System.Drawing.Size(44, 20);
            this.tGamma.TabIndex = 60;
            this.tGamma.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tGamma.ValueChanged += new System.EventHandler(this.tGamma_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(362, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "Gamma Value";
            // 
            // tbGamma
            // 
            this.tbGamma.LargeChange = 1;
            this.tbGamma.Location = new System.Drawing.Point(313, 89);
            this.tbGamma.Maximum = 400;
            this.tbGamma.Minimum = 50;
            this.tbGamma.Name = "tbGamma";
            this.tbGamma.Size = new System.Drawing.Size(162, 45);
            this.tbGamma.TabIndex = 58;
            this.tbGamma.TickFrequency = 50;
            this.tbGamma.Value = 100;
            this.tbGamma.ValueChanged += new System.EventHandler(this.tbGamma_ValueChanged);
            // 
            // bOrderDown
            // 
            this.bOrderDown.Location = new System.Drawing.Point(168, 411);
            this.bOrderDown.Name = "bOrderDown";
            this.bOrderDown.Size = new System.Drawing.Size(20, 44);
            this.bOrderDown.TabIndex = 57;
            this.bOrderDown.Text = "v";
            this.bOrderDown.UseVisualStyleBackColor = true;
            this.bOrderDown.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bOrderDown_MouseClick);
            // 
            // bOrderUp
            // 
            this.bOrderUp.Location = new System.Drawing.Point(168, 359);
            this.bOrderUp.Name = "bOrderUp";
            this.bOrderUp.Size = new System.Drawing.Size(20, 44);
            this.bOrderUp.TabIndex = 56;
            this.bOrderUp.Text = "^";
            this.bOrderUp.UseVisualStyleBackColor = true;
            this.bOrderUp.Click += new System.EventHandler(this.bOrderUp_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 55;
            this.label6.Text = "Order of operations";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lOrder
            // 
            this.lOrder.FormattingEnabled = true;
            this.lOrder.Location = new System.Drawing.Point(12, 359);
            this.lOrder.Name = "lOrder";
            this.lOrder.Size = new System.Drawing.Size(150, 95);
            this.lOrder.TabIndex = 54;
            // 
            // cbTreshold
            // 
            this.cbTreshold.AutoSize = true;
            this.cbTreshold.Location = new System.Drawing.Point(45, 161);
            this.cbTreshold.Name = "cbTreshold";
            this.cbTreshold.Size = new System.Drawing.Size(84, 17);
            this.cbTreshold.TabIndex = 53;
            this.cbTreshold.Text = "Treshold [%]";
            this.cbTreshold.UseVisualStyleBackColor = true;
            this.cbTreshold.CheckedChanged += new System.EventHandler(this.cbTreshold_CheckedChanged);
            // 
            // tTreshold
            // 
            this.tTreshold.Location = new System.Drawing.Point(67, 212);
            this.tTreshold.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.tTreshold.Name = "tTreshold";
            this.tTreshold.Size = new System.Drawing.Size(41, 20);
            this.tTreshold.TabIndex = 52;
            this.tTreshold.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.tTreshold.ValueChanged += new System.EventHandler(this.tTreshold_ValueChanged);
            // 
            // tbTreshold
            // 
            this.tbTreshold.LargeChange = 1;
            this.tbTreshold.Location = new System.Drawing.Point(2, 180);
            this.tbTreshold.Maximum = 100;
            this.tbTreshold.Name = "tbTreshold";
            this.tbTreshold.Size = new System.Drawing.Size(162, 45);
            this.tbTreshold.TabIndex = 50;
            this.tbTreshold.TickFrequency = 50;
            this.tbTreshold.Value = 50;
            this.tbTreshold.ValueChanged += new System.EventHandler(this.tbTreshold_ValueChanged);
            // 
            // tContrast
            // 
            this.tContrast.Location = new System.Drawing.Point(221, 121);
            this.tContrast.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.tContrast.Name = "tContrast";
            this.tContrast.Size = new System.Drawing.Size(38, 20);
            this.tContrast.TabIndex = 49;
            this.tContrast.ValueChanged += new System.EventHandler(this.tContrast_ValueChanged);
            // 
            // tBrightness
            // 
            this.tBrightness.Location = new System.Drawing.Point(62, 121);
            this.tBrightness.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.tBrightness.Name = "tBrightness";
            this.tBrightness.Size = new System.Drawing.Size(41, 20);
            this.tBrightness.TabIndex = 48;
            this.tBrightness.ValueChanged += new System.EventHandler(this.tBrightness_ValueChanged);
            // 
            // bInputChoose
            // 
            this.bInputChoose.Location = new System.Drawing.Point(240, 23);
            this.bInputChoose.Name = "bInputChoose";
            this.bInputChoose.Size = new System.Drawing.Size(85, 23);
            this.bInputChoose.TabIndex = 46;
            this.bInputChoose.Text = "Choose...";
            this.bInputChoose.UseVisualStyleBackColor = true;
            this.bInputChoose.Click += new System.EventHandler(this.bInputChoose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Brightness [%]";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Contrast [%]";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(152, 25);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 42;
            this.label1.Text = "File for preview:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbContrast
            // 
            this.tbContrast.LargeChange = 1;
            this.tbContrast.Location = new System.Drawing.Point(156, 89);
            this.tbContrast.Maximum = 100;
            this.tbContrast.Minimum = -100;
            this.tbContrast.Name = "tbContrast";
            this.tbContrast.Size = new System.Drawing.Size(162, 45);
            this.tbContrast.TabIndex = 41;
            this.tbContrast.TickFrequency = 50;
            this.tbContrast.ValueChanged += new System.EventHandler(this.tbContrast_ValueChanged);
            // 
            // tbBrightness
            // 
            this.tbBrightness.LargeChange = 1;
            this.tbBrightness.Location = new System.Drawing.Point(2, 89);
            this.tbBrightness.Maximum = 100;
            this.tbBrightness.Minimum = -100;
            this.tbBrightness.Name = "tbBrightness";
            this.tbBrightness.Size = new System.Drawing.Size(162, 45);
            this.tbBrightness.TabIndex = 39;
            this.tbBrightness.TickFrequency = 50;
            this.tbBrightness.ValueChanged += new System.EventHandler(this.tbBrightness_ValueChanged);
            // 
            // bSave
            // 
            this.bSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bSave.Location = new System.Drawing.Point(366, 551);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(107, 26);
            this.bSave.TabIndex = 38;
            this.bSave.Text = "Save profile...";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // tableLayoutPreview
            // 
            this.tableLayoutPreview.ColumnCount = 1;
            this.tableLayoutPreview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPreview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPreview.Controls.Add(this.gbAfter, 0, 1);
            this.tableLayoutPreview.Controls.Add(this.gbBefore, 0, 0);
            this.tableLayoutPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPreview.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPreview.Name = "tableLayoutPreview";
            this.tableLayoutPreview.RowCount = 2;
            this.tableLayoutPreview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPreview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPreview.Size = new System.Drawing.Size(504, 583);
            this.tableLayoutPreview.TabIndex = 0;
            // 
            // gbAfter
            // 
            this.gbAfter.Controls.Add(this.pAfter);
            this.gbAfter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAfter.Location = new System.Drawing.Point(3, 294);
            this.gbAfter.Name = "gbAfter";
            this.gbAfter.Size = new System.Drawing.Size(498, 286);
            this.gbAfter.TabIndex = 1;
            this.gbAfter.TabStop = false;
            this.gbAfter.Text = "After";
            // 
            // pAfter
            // 
            this.pAfter.AutoScroll = true;
            this.pAfter.Controls.Add(this.lAfter);
            this.pAfter.Controls.Add(this.pbAfter);
            this.pAfter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pAfter.Location = new System.Drawing.Point(3, 16);
            this.pAfter.Name = "pAfter";
            this.pAfter.Size = new System.Drawing.Size(492, 267);
            this.pAfter.TabIndex = 0;
            // 
            // lAfter
            // 
            this.lAfter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lAfter.Location = new System.Drawing.Point(0, 0);
            this.lAfter.Name = "lAfter";
            this.lAfter.Size = new System.Drawing.Size(492, 267);
            this.lAfter.TabIndex = 4;
            this.lAfter.Text = "No file loaded";
            this.lAfter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbAfter
            // 
            this.pbAfter.Location = new System.Drawing.Point(0, -1);
            this.pbAfter.Name = "pbAfter";
            this.pbAfter.Size = new System.Drawing.Size(100, 100);
            this.pbAfter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbAfter.TabIndex = 3;
            this.pbAfter.TabStop = false;
            // 
            // gbBefore
            // 
            this.gbBefore.Controls.Add(this.pBefore);
            this.gbBefore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbBefore.Location = new System.Drawing.Point(3, 3);
            this.gbBefore.Name = "gbBefore";
            this.gbBefore.Size = new System.Drawing.Size(498, 285);
            this.gbBefore.TabIndex = 2;
            this.gbBefore.TabStop = false;
            this.gbBefore.Text = "Before";
            // 
            // pBefore
            // 
            this.pBefore.AutoScroll = true;
            this.pBefore.Controls.Add(this.lBefore);
            this.pBefore.Controls.Add(this.pbBefore);
            this.pBefore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBefore.Location = new System.Drawing.Point(3, 16);
            this.pBefore.Name = "pBefore";
            this.pBefore.Size = new System.Drawing.Size(492, 266);
            this.pBefore.TabIndex = 3;
            // 
            // lBefore
            // 
            this.lBefore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lBefore.Location = new System.Drawing.Point(0, 0);
            this.lBefore.Name = "lBefore";
            this.lBefore.Size = new System.Drawing.Size(492, 266);
            this.lBefore.TabIndex = 5;
            this.lBefore.Text = "No file loaded";
            this.lBefore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbBefore
            // 
            this.pbBefore.Location = new System.Drawing.Point(0, 0);
            this.pbBefore.Name = "pbBefore";
            this.pbBefore.Size = new System.Drawing.Size(100, 100);
            this.pbBefore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbBefore.TabIndex = 4;
            this.pbBefore.TabStop = false;
            // 
            // tmrRefresh
            // 
            this.tmrRefresh.Interval = 3000;
            this.tmrRefresh.Tick += new System.EventHandler(this.tmrRefresh_Tick);
            // 
            // sfdProfile
            // 
            this.sfdProfile.DefaultExt = "mgk";
            this.sfdProfile.Filter = "BatchCoverter profiles|*.mgk";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // bLoad
            // 
            this.bLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bLoad.Location = new System.Drawing.Point(3, 551);
            this.bLoad.Name = "bLoad";
            this.bLoad.Size = new System.Drawing.Size(107, 26);
            this.bLoad.TabIndex = 68;
            this.bLoad.Text = "Load profile...";
            this.bLoad.UseVisualStyleBackColor = true;
            this.bLoad.Click += new System.EventHandler(this.bLoad_Click);
            // 
            // ofdProfile
            // 
            this.ofdProfile.DefaultExt = "mgk";
            this.ofdProfile.Filter = "BatchCoverter profiles|*.mgk";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 605);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 555);
            this.Name = "MainForm";
            this.Text = "Batch Converter";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tNoise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNoise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tGamma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGamma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBrightness)).EndInit();
            this.tableLayoutPreview.ResumeLayout(false);
            this.gbAfter.ResumeLayout(false);
            this.pAfter.ResumeLayout(false);
            this.pAfter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAfter)).EndInit();
            this.gbBefore.ResumeLayout(false);
            this.pBefore.ResumeLayout(false);
            this.pBefore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBefore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.OpenFileDialog ofdInput;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox cbSharpen;
        private System.Windows.Forms.CheckBox cbEnhance;
        private System.Windows.Forms.NumericUpDown tNoise;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar tbNoise;
        private System.Windows.Forms.NumericUpDown tGamma;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar tbGamma;
        private System.Windows.Forms.Button bOrderDown;
        private System.Windows.Forms.Button bOrderUp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lOrder;
        private System.Windows.Forms.CheckBox cbTreshold;
        private System.Windows.Forms.NumericUpDown tTreshold;
        private System.Windows.Forms.TrackBar tbTreshold;
        private System.Windows.Forms.NumericUpDown tContrast;
        private System.Windows.Forms.NumericUpDown tBrightness;
        private System.Windows.Forms.Button bInputChoose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tbContrast;
        private System.Windows.Forms.TrackBar tbBrightness;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPreview;
        private System.Windows.Forms.GroupBox gbAfter;
        private System.Windows.Forms.GroupBox gbBefore;
        private System.Windows.Forms.Panel pBefore;
        private System.Windows.Forms.Label lBefore;
        private System.Windows.Forms.PictureBox pbBefore;
        private System.Windows.Forms.Panel pAfter;
        private System.Windows.Forms.Label lAfter;
        private System.Windows.Forms.PictureBox pbAfter;
        private System.Windows.Forms.Timer tmrRefresh;
        private System.Windows.Forms.SaveFileDialog sfdProfile;
        private System.Windows.Forms.ToolStripProgressBar pbToolstrip;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Button bLoad;
        private System.Windows.Forms.OpenFileDialog ofdProfile;
    }
}

