namespace UserFilterTester
{
    partial class ImageFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageFilter));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cbEnableGray = new System.Windows.Forms.CheckBox();
            this.numMatrixGain = new System.Windows.Forms.NumericUpDown();
            this.numMatrixOffset = new System.Windows.Forms.NumericUpDown();
            this.numMatrix33 = new System.Windows.Forms.NumericUpDown();
            this.numMatrix32 = new System.Windows.Forms.NumericUpDown();
            this.numMatrix31 = new System.Windows.Forms.NumericUpDown();
            this.numMatrix23 = new System.Windows.Forms.NumericUpDown();
            this.numMatrix22 = new System.Windows.Forms.NumericUpDown();
            this.numMatrix21 = new System.Windows.Forms.NumericUpDown();
            this.numMatrix13 = new System.Windows.Forms.NumericUpDown();
            this.numMatrix12 = new System.Windows.Forms.NumericUpDown();
            this.numMatrix11 = new System.Windows.Forms.NumericUpDown();
            this.saveImage = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbFilter33 = new System.Windows.Forms.Label();
            this.lbFilter11 = new System.Windows.Forms.Label();
            this.lbOffsetandPlus = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbFilter32 = new System.Windows.Forms.Label();
            this.lbGainAndMultiplier = new System.Windows.Forms.Label();
            this.lbFilter31 = new System.Windows.Forms.Label();
            this.lbFilter12 = new System.Windows.Forms.Label();
            this.lbFilter23 = new System.Windows.Forms.Label();
            this.lbFilter13 = new System.Windows.Forms.Label();
            this.lbFilter22 = new System.Windows.Forms.Label();
            this.lbFilter21 = new System.Windows.Forms.Label();
            this.applyFilter = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.convolutionFilter = new System.Windows.Forms.ComboBox();
            this.loadImage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMatrixGain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMatrixOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMatrix33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMatrix32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMatrix31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMatrix23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMatrix22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMatrix21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMatrix13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMatrix12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMatrix11)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AllowDrop = true;
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.cbEnableGray);
            this.splitContainer1.Panel1.Controls.Add(this.numMatrixGain);
            this.splitContainer1.Panel1.Controls.Add(this.numMatrixOffset);
            this.splitContainer1.Panel1.Controls.Add(this.numMatrix33);
            this.splitContainer1.Panel1.Controls.Add(this.numMatrix32);
            this.splitContainer1.Panel1.Controls.Add(this.numMatrix31);
            this.splitContainer1.Panel1.Controls.Add(this.numMatrix23);
            this.splitContainer1.Panel1.Controls.Add(this.numMatrix22);
            this.splitContainer1.Panel1.Controls.Add(this.numMatrix21);
            this.splitContainer1.Panel1.Controls.Add(this.numMatrix13);
            this.splitContainer1.Panel1.Controls.Add(this.numMatrix12);
            this.splitContainer1.Panel1.Controls.Add(this.numMatrix11);
            this.splitContainer1.Panel1.Controls.Add(this.saveImage);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.applyFilter);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.convolutionFilter);
            this.splitContainer1.Panel1.Controls.Add(this.loadImage);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AllowDrop = true;
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1189, 679);
            this.splitContainer1.SplitterDistance = 312;
            this.splitContainer1.TabIndex = 2;
            // 
            // cbEnableGray
            // 
            this.cbEnableGray.AutoSize = true;
            this.cbEnableGray.Location = new System.Drawing.Point(12, 534);
            this.cbEnableGray.Name = "cbEnableGray";
            this.cbEnableGray.Size = new System.Drawing.Size(115, 17);
            this.cbEnableGray.TabIndex = 52;
            this.cbEnableGray.Text = "Enable grayscaling";
            this.cbEnableGray.UseVisualStyleBackColor = true;
            // 
            // numMatrixGain
            // 
            this.numMatrixGain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numMatrixGain.Location = new System.Drawing.Point(53, 320);
            this.numMatrixGain.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numMatrixGain.Name = "numMatrixGain";
            this.numMatrixGain.Size = new System.Drawing.Size(253, 20);
            this.numMatrixGain.TabIndex = 51;
            this.numMatrixGain.ValueChanged += new System.EventHandler(this.matrix_Changed);
            // 
            // numMatrixOffset
            // 
            this.numMatrixOffset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numMatrixOffset.Location = new System.Drawing.Point(53, 295);
            this.numMatrixOffset.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numMatrixOffset.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            -2147483648});
            this.numMatrixOffset.Name = "numMatrixOffset";
            this.numMatrixOffset.Size = new System.Drawing.Size(253, 20);
            this.numMatrixOffset.TabIndex = 50;
            this.numMatrixOffset.ValueChanged += new System.EventHandler(this.matrix_Changed);
            // 
            // numMatrix33
            // 
            this.numMatrix33.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numMatrix33.Location = new System.Drawing.Point(53, 269);
            this.numMatrix33.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numMatrix33.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            -2147483648});
            this.numMatrix33.Name = "numMatrix33";
            this.numMatrix33.Size = new System.Drawing.Size(253, 20);
            this.numMatrix33.TabIndex = 49;
            this.numMatrix33.ValueChanged += new System.EventHandler(this.matrix_Changed);
            // 
            // numMatrix32
            // 
            this.numMatrix32.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numMatrix32.Location = new System.Drawing.Point(53, 243);
            this.numMatrix32.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numMatrix32.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            -2147483648});
            this.numMatrix32.Name = "numMatrix32";
            this.numMatrix32.Size = new System.Drawing.Size(253, 20);
            this.numMatrix32.TabIndex = 48;
            this.numMatrix32.ValueChanged += new System.EventHandler(this.matrix_Changed);
            // 
            // numMatrix31
            // 
            this.numMatrix31.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numMatrix31.Location = new System.Drawing.Point(53, 216);
            this.numMatrix31.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numMatrix31.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            -2147483648});
            this.numMatrix31.Name = "numMatrix31";
            this.numMatrix31.Size = new System.Drawing.Size(253, 20);
            this.numMatrix31.TabIndex = 47;
            this.numMatrix31.ValueChanged += new System.EventHandler(this.matrix_Changed);
            // 
            // numMatrix23
            // 
            this.numMatrix23.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numMatrix23.Location = new System.Drawing.Point(53, 190);
            this.numMatrix23.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numMatrix23.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            -2147483648});
            this.numMatrix23.Name = "numMatrix23";
            this.numMatrix23.Size = new System.Drawing.Size(253, 20);
            this.numMatrix23.TabIndex = 46;
            this.numMatrix23.ValueChanged += new System.EventHandler(this.matrix_Changed);
            // 
            // numMatrix22
            // 
            this.numMatrix22.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numMatrix22.Location = new System.Drawing.Point(53, 165);
            this.numMatrix22.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numMatrix22.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            -2147483648});
            this.numMatrix22.Name = "numMatrix22";
            this.numMatrix22.Size = new System.Drawing.Size(253, 20);
            this.numMatrix22.TabIndex = 45;
            this.numMatrix22.ValueChanged += new System.EventHandler(this.matrix_Changed);
            // 
            // numMatrix21
            // 
            this.numMatrix21.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numMatrix21.Location = new System.Drawing.Point(53, 139);
            this.numMatrix21.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numMatrix21.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            -2147483648});
            this.numMatrix21.Name = "numMatrix21";
            this.numMatrix21.Size = new System.Drawing.Size(253, 20);
            this.numMatrix21.TabIndex = 44;
            this.numMatrix21.ValueChanged += new System.EventHandler(this.matrix_Changed);
            // 
            // numMatrix13
            // 
            this.numMatrix13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numMatrix13.Location = new System.Drawing.Point(53, 113);
            this.numMatrix13.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numMatrix13.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            -2147483648});
            this.numMatrix13.Name = "numMatrix13";
            this.numMatrix13.Size = new System.Drawing.Size(253, 20);
            this.numMatrix13.TabIndex = 43;
            this.numMatrix13.ValueChanged += new System.EventHandler(this.matrix_Changed);
            // 
            // numMatrix12
            // 
            this.numMatrix12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numMatrix12.Location = new System.Drawing.Point(53, 87);
            this.numMatrix12.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numMatrix12.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            -2147483648});
            this.numMatrix12.Name = "numMatrix12";
            this.numMatrix12.Size = new System.Drawing.Size(253, 20);
            this.numMatrix12.TabIndex = 42;
            this.numMatrix12.ValueChanged += new System.EventHandler(this.matrix_Changed);
            // 
            // numMatrix11
            // 
            this.numMatrix11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numMatrix11.Location = new System.Drawing.Point(54, 61);
            this.numMatrix11.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numMatrix11.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            -2147483648});
            this.numMatrix11.Name = "numMatrix11";
            this.numMatrix11.Size = new System.Drawing.Size(253, 20);
            this.numMatrix11.TabIndex = 41;
            this.numMatrix11.ValueChanged += new System.EventHandler(this.matrix_Changed);
            // 
            // saveImage
            // 
            this.saveImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveImage.Location = new System.Drawing.Point(6, 586);
            this.saveImage.Name = "saveImage";
            this.saveImage.Size = new System.Drawing.Size(301, 23);
            this.saveImage.TabIndex = 40;
            this.saveImage.Text = "Save Image";
            this.saveImage.UseVisualStyleBackColor = true;
            this.saveImage.Click += new System.EventHandler(this.saveImage_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbFilter33);
            this.groupBox1.Controls.Add(this.lbFilter11);
            this.groupBox1.Controls.Add(this.lbOffsetandPlus);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lbFilter32);
            this.groupBox1.Controls.Add(this.lbGainAndMultiplier);
            this.groupBox1.Controls.Add(this.lbFilter31);
            this.groupBox1.Controls.Add(this.lbFilter12);
            this.groupBox1.Controls.Add(this.lbFilter23);
            this.groupBox1.Controls.Add(this.lbFilter13);
            this.groupBox1.Controls.Add(this.lbFilter22);
            this.groupBox1.Controls.Add(this.lbFilter21);
            this.groupBox1.Location = new System.Drawing.Point(6, 346);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 182);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resulting Convolution Matrix";
            // 
            // lbFilter33
            // 
            this.lbFilter33.AutoSize = true;
            this.lbFilter33.Location = new System.Drawing.Point(192, 117);
            this.lbFilter33.Name = "lbFilter33";
            this.lbFilter33.Size = new System.Drawing.Size(25, 13);
            this.lbFilter33.TabIndex = 37;
            this.lbFilter33.Text = "F33";
            // 
            // lbFilter11
            // 
            this.lbFilter11.AutoSize = true;
            this.lbFilter11.Location = new System.Drawing.Point(106, 43);
            this.lbFilter11.Name = "lbFilter11";
            this.lbFilter11.Size = new System.Drawing.Size(25, 13);
            this.lbFilter11.TabIndex = 28;
            this.lbFilter11.Text = "F11";
            // 
            // lbOffsetandPlus
            // 
            this.lbOffsetandPlus.AutoSize = true;
            this.lbOffsetandPlus.Location = new System.Drawing.Point(223, 81);
            this.lbOffsetandPlus.Name = "lbOffsetandPlus";
            this.lbOffsetandPlus.Size = new System.Drawing.Size(50, 13);
            this.lbOffsetandPlus.TabIndex = 36;
            this.lbOffsetandPlus.Text = "+   Offset";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Result  =";
            // 
            // lbFilter32
            // 
            this.lbFilter32.AutoSize = true;
            this.lbFilter32.Location = new System.Drawing.Point(148, 117);
            this.lbFilter32.Name = "lbFilter32";
            this.lbFilter32.Size = new System.Drawing.Size(25, 13);
            this.lbFilter32.TabIndex = 35;
            this.lbFilter32.Text = "F32";
            // 
            // lbGainAndMultiplier
            // 
            this.lbGainAndMultiplier.AutoSize = true;
            this.lbGainAndMultiplier.Location = new System.Drawing.Point(61, 81);
            this.lbGainAndMultiplier.Name = "lbGainAndMultiplier";
            this.lbGainAndMultiplier.Size = new System.Drawing.Size(39, 13);
            this.lbGainAndMultiplier.TabIndex = 27;
            this.lbGainAndMultiplier.Tag = "";
            this.lbGainAndMultiplier.Text = "Gain X";
            // 
            // lbFilter31
            // 
            this.lbFilter31.AutoSize = true;
            this.lbFilter31.Location = new System.Drawing.Point(106, 117);
            this.lbFilter31.Name = "lbFilter31";
            this.lbFilter31.Size = new System.Drawing.Size(25, 13);
            this.lbFilter31.TabIndex = 34;
            this.lbFilter31.Text = "F31";
            // 
            // lbFilter12
            // 
            this.lbFilter12.AutoSize = true;
            this.lbFilter12.Location = new System.Drawing.Point(148, 43);
            this.lbFilter12.Name = "lbFilter12";
            this.lbFilter12.Size = new System.Drawing.Size(25, 13);
            this.lbFilter12.TabIndex = 29;
            this.lbFilter12.Text = "F12";
            // 
            // lbFilter23
            // 
            this.lbFilter23.AutoSize = true;
            this.lbFilter23.Location = new System.Drawing.Point(192, 81);
            this.lbFilter23.Name = "lbFilter23";
            this.lbFilter23.Size = new System.Drawing.Size(25, 13);
            this.lbFilter23.TabIndex = 33;
            this.lbFilter23.Text = "F23";
            // 
            // lbFilter13
            // 
            this.lbFilter13.AutoSize = true;
            this.lbFilter13.Location = new System.Drawing.Point(192, 43);
            this.lbFilter13.Name = "lbFilter13";
            this.lbFilter13.Size = new System.Drawing.Size(25, 13);
            this.lbFilter13.TabIndex = 30;
            this.lbFilter13.Text = "F13";
            // 
            // lbFilter22
            // 
            this.lbFilter22.AutoSize = true;
            this.lbFilter22.Location = new System.Drawing.Point(148, 81);
            this.lbFilter22.Name = "lbFilter22";
            this.lbFilter22.Size = new System.Drawing.Size(25, 13);
            this.lbFilter22.TabIndex = 32;
            this.lbFilter22.Text = "F22";
            // 
            // lbFilter21
            // 
            this.lbFilter21.AutoSize = true;
            this.lbFilter21.Location = new System.Drawing.Point(106, 81);
            this.lbFilter21.Name = "lbFilter21";
            this.lbFilter21.Size = new System.Drawing.Size(25, 13);
            this.lbFilter21.TabIndex = 31;
            this.lbFilter21.Text = "F21";
            // 
            // applyFilter
            // 
            this.applyFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.applyFilter.Location = new System.Drawing.Point(6, 557);
            this.applyFilter.Name = "applyFilter";
            this.applyFilter.Size = new System.Drawing.Size(301, 23);
            this.applyFilter.TabIndex = 25;
            this.applyFilter.Text = "Apply Filter";
            this.applyFilter.UseVisualStyleBackColor = true;
            this.applyFilter.Click += new System.EventHandler(this.applyFilter_Click);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 323);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Gain";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 297);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Offset";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Filter 33";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Filter 32";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Filter 31";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Filter 23";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Filter 22";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Filter 21";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Filter 13";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filter 12";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filter 11";
            // 
            // convolutionFilter
            // 
            this.convolutionFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.convolutionFilter.FormattingEnabled = true;
            this.convolutionFilter.Location = new System.Drawing.Point(4, 33);
            this.convolutionFilter.MaxDropDownItems = 10;
            this.convolutionFilter.Name = "convolutionFilter";
            this.convolutionFilter.Size = new System.Drawing.Size(303, 21);
            this.convolutionFilter.TabIndex = 1;
            this.convolutionFilter.SelectedIndexChanged += new System.EventHandler(this.convolutionFilter_SelectedIndexChanged);
            // 
            // loadImage
            // 
            this.loadImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadImage.Location = new System.Drawing.Point(3, 3);
            this.loadImage.Name = "loadImage";
            this.loadImage.Size = new System.Drawing.Size(304, 23);
            this.loadImage.TabIndex = 0;
            this.loadImage.Text = "Load Image";
            this.loadImage.UseVisualStyleBackColor = true;
            this.loadImage.Click += new System.EventHandler(this.loadImage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(844, 672);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ImageFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 679);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImageFilter";
            this.Text = "Image Filter";
            this.Load += new System.EventHandler(this.ImageFilter_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numMatrixGain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMatrixOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMatrix33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMatrix32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMatrix31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMatrix23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMatrix22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMatrix21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMatrix13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMatrix12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMatrix11)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox convolutionFilter;
        private System.Windows.Forms.Button loadImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button applyFilter;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbFilter33;
        private System.Windows.Forms.Label lbFilter11;
        private System.Windows.Forms.Label lbOffsetandPlus;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbFilter32;
        private System.Windows.Forms.Label lbGainAndMultiplier;
        private System.Windows.Forms.Label lbFilter31;
        private System.Windows.Forms.Label lbFilter12;
        private System.Windows.Forms.Label lbFilter23;
        private System.Windows.Forms.Label lbFilter13;
        private System.Windows.Forms.Label lbFilter22;
        private System.Windows.Forms.Label lbFilter21;
        private System.Windows.Forms.Button saveImage;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.NumericUpDown numMatrixGain;
        private System.Windows.Forms.NumericUpDown numMatrixOffset;
        private System.Windows.Forms.NumericUpDown numMatrix33;
        private System.Windows.Forms.NumericUpDown numMatrix32;
        private System.Windows.Forms.NumericUpDown numMatrix31;
        private System.Windows.Forms.NumericUpDown numMatrix23;
        private System.Windows.Forms.NumericUpDown numMatrix22;
        private System.Windows.Forms.NumericUpDown numMatrix21;
        private System.Windows.Forms.NumericUpDown numMatrix13;
        private System.Windows.Forms.NumericUpDown numMatrix12;
        private System.Windows.Forms.NumericUpDown numMatrix11;
        private System.Windows.Forms.CheckBox cbEnableGray;
    }
}

