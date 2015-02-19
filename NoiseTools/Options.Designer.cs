namespace NoiseTools
{
    partial class Options
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
            this.groupColor = new System.Windows.Forms.GroupBox();
            this.numericFactorRed = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxReverseRed = new System.Windows.Forms.CheckBox();
            this.checkBoxRedCosine = new System.Windows.Forms.CheckBox();
            this.trackBarRedMax = new System.Windows.Forms.TrackBar();
            this.trackBarRedMin = new System.Windows.Forms.TrackBar();
            this.groupGreen = new System.Windows.Forms.GroupBox();
            this.numericFactorGreen = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBoxReverseGreen = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.checkBoxGreenCosine = new System.Windows.Forms.CheckBox();
            this.trackBarGreenMax = new System.Windows.Forms.TrackBar();
            this.trackBarGreenMin = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericFactorBlue = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBoxReverseBlue = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.checkBoxBlueCosine = new System.Windows.Forms.CheckBox();
            this.trackBarBlueMax = new System.Windows.Forms.TrackBar();
            this.trackBarBlueMin = new System.Windows.Forms.TrackBar();
            this.groupNoise = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numericNoiseSeed = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericColorSeed = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericStep = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericOffset = new System.Windows.Forms.NumericUpDown();
            this.numericGain = new System.Windows.Forms.NumericUpDown();
            this.numericLacunarity = new System.Windows.Forms.NumericUpDown();
            this.numericOctaves = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.numericHeight = new System.Windows.Forms.NumericUpDown();
            this.numericWidth = new System.Windows.Forms.NumericUpDown();
            this.groupColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFactorRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRedMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRedMin)).BeginInit();
            this.groupGreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFactorGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreenMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreenMin)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFactorBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlueMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlueMin)).BeginInit();
            this.groupNoise.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNoiseSeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericColorSeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLacunarity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericOctaves)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // groupColor
            // 
            this.groupColor.Controls.Add(this.numericFactorRed);
            this.groupColor.Controls.Add(this.label9);
            this.groupColor.Controls.Add(this.label8);
            this.groupColor.Controls.Add(this.checkBoxReverseRed);
            this.groupColor.Controls.Add(this.checkBoxRedCosine);
            this.groupColor.Controls.Add(this.trackBarRedMax);
            this.groupColor.Controls.Add(this.trackBarRedMin);
            this.groupColor.Location = new System.Drawing.Point(12, 12);
            this.groupColor.Name = "groupColor";
            this.groupColor.Size = new System.Drawing.Size(106, 275);
            this.groupColor.TabIndex = 0;
            this.groupColor.TabStop = false;
            this.groupColor.Text = "Red";
            // 
            // numericFactorRed
            // 
            this.numericFactorRed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericFactorRed.DecimalPlaces = 3;
            this.numericFactorRed.Location = new System.Drawing.Point(6, 201);
            this.numericFactorRed.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericFactorRed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericFactorRed.Name = "numericFactorRed";
            this.numericFactorRed.Size = new System.Drawing.Size(94, 20);
            this.numericFactorRed.TabIndex = 14;
            this.numericFactorRed.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericFactorRed.ValueChanged += new System.EventHandler(this.numericFactorRed_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(65, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Max";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Min";
            // 
            // checkBoxReverseRed
            // 
            this.checkBoxReverseRed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxReverseRed.AutoSize = true;
            this.checkBoxReverseRed.Location = new System.Drawing.Point(6, 252);
            this.checkBoxReverseRed.Name = "checkBoxReverseRed";
            this.checkBoxReverseRed.Size = new System.Drawing.Size(93, 17);
            this.checkBoxReverseRed.TabIndex = 4;
            this.checkBoxReverseRed.Text = "Reverse Color";
            this.checkBoxReverseRed.UseVisualStyleBackColor = true;
            this.checkBoxReverseRed.CheckedChanged += new System.EventHandler(this.checkBoxReverseRed_CheckedChanged);
            // 
            // checkBoxRedCosine
            // 
            this.checkBoxRedCosine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxRedCosine.AutoSize = true;
            this.checkBoxRedCosine.Location = new System.Drawing.Point(6, 229);
            this.checkBoxRedCosine.Name = "checkBoxRedCosine";
            this.checkBoxRedCosine.Size = new System.Drawing.Size(58, 17);
            this.checkBoxRedCosine.TabIndex = 3;
            this.checkBoxRedCosine.Text = "Cosine";
            this.checkBoxRedCosine.UseVisualStyleBackColor = true;
            this.checkBoxRedCosine.CheckedChanged += new System.EventHandler(this.checkBoxRedCosine_CheckedChanged);
            // 
            // trackBarRedMax
            // 
            this.trackBarRedMax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.trackBarRedMax.Location = new System.Drawing.Point(57, 33);
            this.trackBarRedMax.Maximum = 255;
            this.trackBarRedMax.Name = "trackBarRedMax";
            this.trackBarRedMax.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarRedMax.Size = new System.Drawing.Size(45, 162);
            this.trackBarRedMax.TabIndex = 2;
            this.trackBarRedMax.TickFrequency = 16;
            this.trackBarRedMax.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarRedMax.Scroll += new System.EventHandler(this.trackBarRedMax_Scroll);
            this.trackBarRedMax.ValueChanged += new System.EventHandler(this.trackBarRedMax_Scroll);
            // 
            // trackBarRedMin
            // 
            this.trackBarRedMin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.trackBarRedMin.Location = new System.Drawing.Point(6, 33);
            this.trackBarRedMin.Maximum = 255;
            this.trackBarRedMin.Name = "trackBarRedMin";
            this.trackBarRedMin.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarRedMin.Size = new System.Drawing.Size(45, 162);
            this.trackBarRedMin.TabIndex = 0;
            this.trackBarRedMin.TickFrequency = 16;
            this.trackBarRedMin.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarRedMin.Scroll += new System.EventHandler(this.trackBarRedMin_Scroll);
            this.trackBarRedMin.ValueChanged += new System.EventHandler(this.trackBarRedMin_Scroll);
            // 
            // groupGreen
            // 
            this.groupGreen.Controls.Add(this.numericFactorGreen);
            this.groupGreen.Controls.Add(this.label10);
            this.groupGreen.Controls.Add(this.checkBoxReverseGreen);
            this.groupGreen.Controls.Add(this.label11);
            this.groupGreen.Controls.Add(this.checkBoxGreenCosine);
            this.groupGreen.Controls.Add(this.trackBarGreenMax);
            this.groupGreen.Controls.Add(this.trackBarGreenMin);
            this.groupGreen.Location = new System.Drawing.Point(124, 12);
            this.groupGreen.Name = "groupGreen";
            this.groupGreen.Size = new System.Drawing.Size(106, 275);
            this.groupGreen.TabIndex = 4;
            this.groupGreen.TabStop = false;
            this.groupGreen.Text = "Green";
            // 
            // numericFactorGreen
            // 
            this.numericFactorGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericFactorGreen.DecimalPlaces = 3;
            this.numericFactorGreen.Location = new System.Drawing.Point(6, 201);
            this.numericFactorGreen.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericFactorGreen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericFactorGreen.Name = "numericFactorGreen";
            this.numericFactorGreen.Size = new System.Drawing.Size(94, 20);
            this.numericFactorGreen.TabIndex = 16;
            this.numericFactorGreen.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericFactorGreen.ValueChanged += new System.EventHandler(this.numericFactorGreen_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(63, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Max";
            // 
            // checkBoxReverseGreen
            // 
            this.checkBoxReverseGreen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxReverseGreen.AutoSize = true;
            this.checkBoxReverseGreen.Location = new System.Drawing.Point(6, 252);
            this.checkBoxReverseGreen.Name = "checkBoxReverseGreen";
            this.checkBoxReverseGreen.Size = new System.Drawing.Size(93, 17);
            this.checkBoxReverseGreen.TabIndex = 5;
            this.checkBoxReverseGreen.Text = "Reverse Color";
            this.checkBoxReverseGreen.UseVisualStyleBackColor = true;
            this.checkBoxReverseGreen.CheckedChanged += new System.EventHandler(this.checkBoxReverseGreen_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Min";
            // 
            // checkBoxGreenCosine
            // 
            this.checkBoxGreenCosine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxGreenCosine.AutoSize = true;
            this.checkBoxGreenCosine.Location = new System.Drawing.Point(6, 230);
            this.checkBoxGreenCosine.Name = "checkBoxGreenCosine";
            this.checkBoxGreenCosine.Size = new System.Drawing.Size(58, 17);
            this.checkBoxGreenCosine.TabIndex = 3;
            this.checkBoxGreenCosine.Text = "Cosine";
            this.checkBoxGreenCosine.UseVisualStyleBackColor = true;
            this.checkBoxGreenCosine.CheckedChanged += new System.EventHandler(this.checkBoxGreenCosine_CheckedChanged);
            // 
            // trackBarGreenMax
            // 
            this.trackBarGreenMax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.trackBarGreenMax.Location = new System.Drawing.Point(57, 33);
            this.trackBarGreenMax.Maximum = 255;
            this.trackBarGreenMax.Name = "trackBarGreenMax";
            this.trackBarGreenMax.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarGreenMax.Size = new System.Drawing.Size(45, 162);
            this.trackBarGreenMax.TabIndex = 2;
            this.trackBarGreenMax.TickFrequency = 16;
            this.trackBarGreenMax.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarGreenMax.Scroll += new System.EventHandler(this.trackBarGreenMax_Scroll);
            this.trackBarGreenMax.ValueChanged += new System.EventHandler(this.trackBarGreenMax_Scroll);
            // 
            // trackBarGreenMin
            // 
            this.trackBarGreenMin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.trackBarGreenMin.Location = new System.Drawing.Point(6, 33);
            this.trackBarGreenMin.Maximum = 255;
            this.trackBarGreenMin.Name = "trackBarGreenMin";
            this.trackBarGreenMin.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarGreenMin.Size = new System.Drawing.Size(45, 162);
            this.trackBarGreenMin.TabIndex = 0;
            this.trackBarGreenMin.TickFrequency = 16;
            this.trackBarGreenMin.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarGreenMin.Scroll += new System.EventHandler(this.trackBarGreenMin_Scroll);
            this.trackBarGreenMin.ValueChanged += new System.EventHandler(this.trackBarGreenMin_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericFactorBlue);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.checkBoxReverseBlue);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.checkBoxBlueCosine);
            this.groupBox2.Controls.Add(this.trackBarBlueMax);
            this.groupBox2.Controls.Add(this.trackBarBlueMin);
            this.groupBox2.Location = new System.Drawing.Point(236, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(106, 275);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Blue";
            // 
            // numericFactorBlue
            // 
            this.numericFactorBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericFactorBlue.DecimalPlaces = 3;
            this.numericFactorBlue.Location = new System.Drawing.Point(6, 201);
            this.numericFactorBlue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericFactorBlue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericFactorBlue.Name = "numericFactorBlue";
            this.numericFactorBlue.Size = new System.Drawing.Size(94, 20);
            this.numericFactorBlue.TabIndex = 18;
            this.numericFactorBlue.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericFactorBlue.ValueChanged += new System.EventHandler(this.numericFactorBlue_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(66, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Max";
            // 
            // checkBoxReverseBlue
            // 
            this.checkBoxReverseBlue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxReverseBlue.AutoSize = true;
            this.checkBoxReverseBlue.Location = new System.Drawing.Point(6, 252);
            this.checkBoxReverseBlue.Name = "checkBoxReverseBlue";
            this.checkBoxReverseBlue.Size = new System.Drawing.Size(93, 17);
            this.checkBoxReverseBlue.TabIndex = 6;
            this.checkBoxReverseBlue.Text = "Reverse Color";
            this.checkBoxReverseBlue.UseVisualStyleBackColor = true;
            this.checkBoxReverseBlue.CheckedChanged += new System.EventHandler(this.checkBoxReverseBlue_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Min";
            // 
            // checkBoxBlueCosine
            // 
            this.checkBoxBlueCosine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxBlueCosine.AutoSize = true;
            this.checkBoxBlueCosine.Location = new System.Drawing.Point(6, 230);
            this.checkBoxBlueCosine.Name = "checkBoxBlueCosine";
            this.checkBoxBlueCosine.Size = new System.Drawing.Size(58, 17);
            this.checkBoxBlueCosine.TabIndex = 3;
            this.checkBoxBlueCosine.Text = "Cosine";
            this.checkBoxBlueCosine.UseVisualStyleBackColor = true;
            this.checkBoxBlueCosine.CheckedChanged += new System.EventHandler(this.checkBoxBlueCosine_CheckedChanged);
            // 
            // trackBarBlueMax
            // 
            this.trackBarBlueMax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.trackBarBlueMax.Location = new System.Drawing.Point(57, 33);
            this.trackBarBlueMax.Maximum = 255;
            this.trackBarBlueMax.Name = "trackBarBlueMax";
            this.trackBarBlueMax.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarBlueMax.Size = new System.Drawing.Size(45, 162);
            this.trackBarBlueMax.TabIndex = 2;
            this.trackBarBlueMax.TickFrequency = 16;
            this.trackBarBlueMax.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarBlueMax.Scroll += new System.EventHandler(this.trackBarBlueMax_Scroll);
            this.trackBarBlueMax.ValueChanged += new System.EventHandler(this.trackBarBlueMax_Scroll);
            // 
            // trackBarBlueMin
            // 
            this.trackBarBlueMin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.trackBarBlueMin.Location = new System.Drawing.Point(6, 33);
            this.trackBarBlueMin.Maximum = 255;
            this.trackBarBlueMin.Name = "trackBarBlueMin";
            this.trackBarBlueMin.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarBlueMin.Size = new System.Drawing.Size(45, 162);
            this.trackBarBlueMin.TabIndex = 0;
            this.trackBarBlueMin.TickFrequency = 16;
            this.trackBarBlueMin.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarBlueMin.Scroll += new System.EventHandler(this.trackBarBlueMin_Scroll);
            this.trackBarBlueMin.ValueChanged += new System.EventHandler(this.trackBarBlueMin_Scroll);
            // 
            // groupNoise
            // 
            this.groupNoise.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupNoise.Controls.Add(this.label7);
            this.groupNoise.Controls.Add(this.numericNoiseSeed);
            this.groupNoise.Controls.Add(this.label6);
            this.groupNoise.Controls.Add(this.numericColorSeed);
            this.groupNoise.Controls.Add(this.label5);
            this.groupNoise.Controls.Add(this.label4);
            this.groupNoise.Controls.Add(this.label3);
            this.groupNoise.Controls.Add(this.label2);
            this.groupNoise.Controls.Add(this.numericStep);
            this.groupNoise.Controls.Add(this.label1);
            this.groupNoise.Controls.Add(this.numericOffset);
            this.groupNoise.Controls.Add(this.numericGain);
            this.groupNoise.Controls.Add(this.numericLacunarity);
            this.groupNoise.Controls.Add(this.numericOctaves);
            this.groupNoise.Location = new System.Drawing.Point(12, 293);
            this.groupNoise.Name = "groupNoise";
            this.groupNoise.Size = new System.Drawing.Size(330, 202);
            this.groupNoise.TabIndex = 5;
            this.groupNoise.TabStop = false;
            this.groupNoise.Text = "Perlin Noise";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Noise Seed";
            // 
            // numericNoiseSeed
            // 
            this.numericNoiseSeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericNoiseSeed.Location = new System.Drawing.Point(204, 175);
            this.numericNoiseSeed.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericNoiseSeed.Name = "numericNoiseSeed";
            this.numericNoiseSeed.Size = new System.Drawing.Size(120, 20);
            this.numericNoiseSeed.TabIndex = 12;
            this.numericNoiseSeed.ValueChanged += new System.EventHandler(this.numericNoiseSeed_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Color Seed";
            // 
            // numericColorSeed
            // 
            this.numericColorSeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericColorSeed.Location = new System.Drawing.Point(204, 149);
            this.numericColorSeed.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericColorSeed.Name = "numericColorSeed";
            this.numericColorSeed.Size = new System.Drawing.Size(120, 20);
            this.numericColorSeed.TabIndex = 10;
            this.numericColorSeed.ValueChanged += new System.EventHandler(this.numericColorSeed_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Noise Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Offset";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Gain";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lacunarity";
            // 
            // numericStep
            // 
            this.numericStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericStep.DecimalPlaces = 4;
            this.numericStep.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.numericStep.Location = new System.Drawing.Point(204, 123);
            this.numericStep.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericStep.Name = "numericStep";
            this.numericStep.Size = new System.Drawing.Size(120, 20);
            this.numericStep.TabIndex = 5;
            this.numericStep.ValueChanged += new System.EventHandler(this.numericStep_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Octaves";
            // 
            // numericOffset
            // 
            this.numericOffset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericOffset.DecimalPlaces = 3;
            this.numericOffset.Location = new System.Drawing.Point(204, 97);
            this.numericOffset.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericOffset.Name = "numericOffset";
            this.numericOffset.Size = new System.Drawing.Size(120, 20);
            this.numericOffset.TabIndex = 3;
            this.numericOffset.ValueChanged += new System.EventHandler(this.numericOffset_ValueChanged);
            // 
            // numericGain
            // 
            this.numericGain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericGain.DecimalPlaces = 3;
            this.numericGain.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericGain.Location = new System.Drawing.Point(204, 71);
            this.numericGain.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericGain.Name = "numericGain";
            this.numericGain.Size = new System.Drawing.Size(120, 20);
            this.numericGain.TabIndex = 2;
            this.numericGain.ValueChanged += new System.EventHandler(this.numericGain_ValueChanged);
            // 
            // numericLacunarity
            // 
            this.numericLacunarity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericLacunarity.DecimalPlaces = 3;
            this.numericLacunarity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericLacunarity.Location = new System.Drawing.Point(204, 45);
            this.numericLacunarity.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericLacunarity.Name = "numericLacunarity";
            this.numericLacunarity.Size = new System.Drawing.Size(120, 20);
            this.numericLacunarity.TabIndex = 1;
            this.numericLacunarity.ValueChanged += new System.EventHandler(this.numericLacunarity_ValueChanged);
            // 
            // numericOctaves
            // 
            this.numericOctaves.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericOctaves.Location = new System.Drawing.Point(204, 19);
            this.numericOctaves.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericOctaves.Name = "numericOctaves";
            this.numericOctaves.Size = new System.Drawing.Size(120, 20);
            this.numericOctaves.TabIndex = 0;
            this.numericOctaves.ValueChanged += new System.EventHandler(this.numericOctaves_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.numericHeight);
            this.groupBox1.Controls.Add(this.numericWidth);
            this.groupBox1.Location = new System.Drawing.Point(12, 500);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 47);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(135, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 20);
            this.label14.TabIndex = 2;
            this.label14.Text = "X";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericHeight
            // 
            this.numericHeight.Location = new System.Drawing.Point(203, 19);
            this.numericHeight.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericHeight.Name = "numericHeight";
            this.numericHeight.Size = new System.Drawing.Size(120, 20);
            this.numericHeight.TabIndex = 1;
            this.numericHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericHeight.ValueChanged += new System.EventHandler(this.numericHeight_ValueChanged);
            // 
            // numericWidth
            // 
            this.numericWidth.Location = new System.Drawing.Point(9, 19);
            this.numericWidth.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericWidth.Name = "numericWidth";
            this.numericWidth.Size = new System.Drawing.Size(120, 20);
            this.numericWidth.TabIndex = 0;
            this.numericWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericWidth.ValueChanged += new System.EventHandler(this.numericWidth_ValueChanged);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupNoise);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupGreen);
            this.Controls.Add(this.groupColor);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(371, 600);
            this.MinimumSize = new System.Drawing.Size(371, 600);
            this.Name = "Options";
            this.Text = "Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Options_FormClosing);
            this.groupColor.ResumeLayout(false);
            this.groupColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFactorRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRedMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRedMin)).EndInit();
            this.groupGreen.ResumeLayout(false);
            this.groupGreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFactorGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreenMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreenMin)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFactorBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlueMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlueMin)).EndInit();
            this.groupNoise.ResumeLayout(false);
            this.groupNoise.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNoiseSeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericColorSeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLacunarity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericOctaves)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericWidth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupColor;
        private System.Windows.Forms.TrackBar trackBarRedMin;
        private System.Windows.Forms.TrackBar trackBarRedMax;
        private System.Windows.Forms.CheckBox checkBoxRedCosine;
        private System.Windows.Forms.GroupBox groupGreen;
        private System.Windows.Forms.CheckBox checkBoxGreenCosine;
        private System.Windows.Forms.TrackBar trackBarGreenMax;
        private System.Windows.Forms.TrackBar trackBarGreenMin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxBlueCosine;
        private System.Windows.Forms.TrackBar trackBarBlueMax;
        private System.Windows.Forms.TrackBar trackBarBlueMin;
        private System.Windows.Forms.GroupBox groupNoise;
        private System.Windows.Forms.NumericUpDown numericLacunarity;
        private System.Windows.Forms.NumericUpDown numericOctaves;
        private System.Windows.Forms.NumericUpDown numericOffset;
        private System.Windows.Forms.NumericUpDown numericGain;
        private System.Windows.Forms.NumericUpDown numericStep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericNoiseSeed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericColorSeed;
        private System.Windows.Forms.CheckBox checkBoxReverseRed;
        private System.Windows.Forms.CheckBox checkBoxReverseGreen;
        private System.Windows.Forms.CheckBox checkBoxReverseBlue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericFactorRed;
        private System.Windows.Forms.NumericUpDown numericFactorGreen;
        private System.Windows.Forms.NumericUpDown numericFactorBlue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numericHeight;
        private System.Windows.Forms.NumericUpDown numericWidth;
    }
}