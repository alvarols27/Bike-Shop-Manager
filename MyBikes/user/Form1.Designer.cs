namespace MyBikes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBoxBikeInfo = new GroupBox();
            labelFrameType = new Label();
            comboBoxFrameType = new ComboBox();
            labelWheelSize = new Label();
            textBoxWheelSize = new TextBox();
            labelColor = new Label();
            labelSpeed = new Label();
            textBoxSpeed = new TextBox();
            labelModel = new Label();
            textBoxModel = new TextBox();
            labelBikeType = new Label();
            labelSerialNumber = new Label();
            labelMade = new Label();
            comboBoxBikeType = new ComboBox();
            comboBoxColor = new ComboBox();
            textBoxSerialNumber = new TextBox();
            textBoxMade = new TextBox();
            groupMountainBike = new GroupBox();
            comboBoxSuspension = new ComboBox();
            labelSuspension = new Label();
            labelHeightFromGround = new Label();
            textBoxHeightFromGround = new TextBox();
            labelSeatHight = new Label();
            textBoxSeatHeight = new TextBox();
            groupBoxMadeDate = new GroupBox();
            labelMadeDate = new Label();
            labelMonth = new Label();
            labelDay = new Label();
            labelYear = new Label();
            textBoxMonth = new TextBox();
            textBoxDay = new TextBox();
            textBoxYear = new TextBox();
            groupBox1 = new GroupBox();
            buttonWriteToXmlFile = new Button();
            buttonReadFromXmlFile = new Button();
            listBoxBikes = new ListBox();
            buttonPrintMountainBike = new Button();
            buttonPrintRoadBike = new Button();
            buttonReset = new Button();
            buttonPrintBike = new Button();
            buttonAdd = new Button();
            buttonDelete = new Button();
            labelDelete = new Label();
            buttonUpdate = new Button();
            labelUpdate = new Label();
            labelSearch = new Label();
            buttonSearch = new Button();
            buttonExit = new Button();
            groupBox3 = new GroupBox();
            buttonPrintHybridBike = new Button();
            buttonPrintElectricBike = new Button();
            groupBoxRoadBike = new GroupBox();
            groupBoxElectricBike = new GroupBox();
            textBoxBatteryIndicator = new TextBox();
            labelBatteryIndicator = new Label();
            groupBoxHybridBike = new GroupBox();
            comboBoxHybridType = new ComboBox();
            labelHybridType = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            pictureBox4 = new PictureBox();
            label4 = new Label();
            pictureBox5 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            numericUpDownSpeed = new NumericUpDown();
            buttonTestSpeed = new Button();
            groupBox2 = new GroupBox();
            groupBoxBikeInfo.SuspendLayout();
            groupMountainBike.SuspendLayout();
            groupBoxMadeDate.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBoxRoadBike.SuspendLayout();
            groupBoxElectricBike.SuspendLayout();
            groupBoxHybridBike.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSpeed).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxBikeInfo
            // 
            groupBoxBikeInfo.Controls.Add(labelFrameType);
            groupBoxBikeInfo.Controls.Add(comboBoxFrameType);
            groupBoxBikeInfo.Controls.Add(labelWheelSize);
            groupBoxBikeInfo.Controls.Add(textBoxWheelSize);
            groupBoxBikeInfo.Controls.Add(labelColor);
            groupBoxBikeInfo.Controls.Add(labelSpeed);
            groupBoxBikeInfo.Controls.Add(textBoxSpeed);
            groupBoxBikeInfo.Controls.Add(labelModel);
            groupBoxBikeInfo.Controls.Add(textBoxModel);
            groupBoxBikeInfo.Controls.Add(labelBikeType);
            groupBoxBikeInfo.Controls.Add(labelSerialNumber);
            groupBoxBikeInfo.Controls.Add(labelMade);
            groupBoxBikeInfo.Controls.Add(comboBoxBikeType);
            groupBoxBikeInfo.Controls.Add(comboBoxColor);
            groupBoxBikeInfo.Controls.Add(textBoxSerialNumber);
            groupBoxBikeInfo.Controls.Add(textBoxMade);
            groupBoxBikeInfo.Location = new Point(770, 34);
            groupBoxBikeInfo.Name = "groupBoxBikeInfo";
            groupBoxBikeInfo.Size = new Size(498, 480);
            groupBoxBikeInfo.TabIndex = 54;
            groupBoxBikeInfo.TabStop = false;
            groupBoxBikeInfo.Text = "Bike Info";
            // 
            // labelFrameType
            // 
            labelFrameType.BackColor = Color.Transparent;
            labelFrameType.BorderStyle = BorderStyle.Fixed3D;
            labelFrameType.Cursor = Cursors.No;
            labelFrameType.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelFrameType.ForeColor = Color.Black;
            labelFrameType.Location = new Point(25, 356);
            labelFrameType.Name = "labelFrameType";
            labelFrameType.Size = new Size(212, 52);
            labelFrameType.TabIndex = 16;
            labelFrameType.Text = "Frame Type?";
            labelFrameType.TextAlign = ContentAlignment.TopCenter;
            // 
            // comboBoxFrameType
            // 
            comboBoxFrameType.FormattingEnabled = true;
            comboBoxFrameType.Location = new Point(258, 359);
            comboBoxFrameType.Name = "comboBoxFrameType";
            comboBoxFrameType.Size = new Size(212, 38);
            comboBoxFrameType.TabIndex = 15;
            // 
            // labelWheelSize
            // 
            labelWheelSize.BackColor = Color.Transparent;
            labelWheelSize.BorderStyle = BorderStyle.Fixed3D;
            labelWheelSize.Cursor = Cursors.No;
            labelWheelSize.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelWheelSize.ForeColor = Color.Black;
            labelWheelSize.Location = new Point(25, 308);
            labelWheelSize.Name = "labelWheelSize";
            labelWheelSize.Size = new Size(212, 52);
            labelWheelSize.TabIndex = 13;
            labelWheelSize.Text = "Wheel Size?";
            labelWheelSize.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxWheelSize
            // 
            textBoxWheelSize.Location = new Point(258, 311);
            textBoxWheelSize.Name = "textBoxWheelSize";
            textBoxWheelSize.Size = new Size(212, 35);
            textBoxWheelSize.TabIndex = 14;
            // 
            // labelColor
            // 
            labelColor.BackColor = Color.Transparent;
            labelColor.BorderStyle = BorderStyle.Fixed3D;
            labelColor.Cursor = Cursors.No;
            labelColor.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelColor.ForeColor = Color.Black;
            labelColor.Location = new Point(25, 408);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(212, 52);
            labelColor.TabIndex = 12;
            labelColor.Text = "Color?";
            labelColor.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelSpeed
            // 
            labelSpeed.BackColor = Color.Transparent;
            labelSpeed.BorderStyle = BorderStyle.Fixed3D;
            labelSpeed.Cursor = Cursors.No;
            labelSpeed.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelSpeed.ForeColor = Color.Black;
            labelSpeed.Location = new Point(25, 256);
            labelSpeed.Name = "labelSpeed";
            labelSpeed.Size = new Size(212, 52);
            labelSpeed.TabIndex = 10;
            labelSpeed.Text = "Speed?";
            labelSpeed.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxSpeed
            // 
            textBoxSpeed.Location = new Point(258, 259);
            textBoxSpeed.Name = "textBoxSpeed";
            textBoxSpeed.Size = new Size(212, 35);
            textBoxSpeed.TabIndex = 11;
            // 
            // labelModel
            // 
            labelModel.BackColor = Color.Transparent;
            labelModel.BorderStyle = BorderStyle.Fixed3D;
            labelModel.Cursor = Cursors.No;
            labelModel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelModel.ForeColor = Color.Black;
            labelModel.Location = new Point(25, 204);
            labelModel.Name = "labelModel";
            labelModel.Size = new Size(212, 52);
            labelModel.TabIndex = 8;
            labelModel.Text = "Model?";
            labelModel.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxModel
            // 
            textBoxModel.Location = new Point(260, 210);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(212, 35);
            textBoxModel.TabIndex = 9;
            // 
            // labelBikeType
            // 
            labelBikeType.BackColor = Color.Transparent;
            labelBikeType.BorderStyle = BorderStyle.Fixed3D;
            labelBikeType.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelBikeType.ForeColor = Color.Black;
            labelBikeType.Location = new Point(25, 48);
            labelBikeType.Name = "labelBikeType";
            labelBikeType.Size = new Size(212, 52);
            labelBikeType.TabIndex = 0;
            labelBikeType.Text = "Bike Type?";
            labelBikeType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSerialNumber
            // 
            labelSerialNumber.BackColor = Color.Transparent;
            labelSerialNumber.BorderStyle = BorderStyle.Fixed3D;
            labelSerialNumber.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelSerialNumber.ForeColor = Color.Black;
            labelSerialNumber.Location = new Point(25, 100);
            labelSerialNumber.Name = "labelSerialNumber";
            labelSerialNumber.Size = new Size(212, 52);
            labelSerialNumber.TabIndex = 1;
            labelSerialNumber.Text = "Serial Number?";
            labelSerialNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelMade
            // 
            labelMade.BackColor = Color.Transparent;
            labelMade.BorderStyle = BorderStyle.Fixed3D;
            labelMade.Cursor = Cursors.No;
            labelMade.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelMade.ForeColor = Color.Black;
            labelMade.Location = new Point(25, 152);
            labelMade.Name = "labelMade";
            labelMade.Size = new Size(212, 52);
            labelMade.TabIndex = 2;
            labelMade.Text = "Made?";
            labelMade.TextAlign = ContentAlignment.TopCenter;
            // 
            // comboBoxBikeType
            // 
            comboBoxBikeType.FormattingEnabled = true;
            comboBoxBikeType.Location = new Point(260, 58);
            comboBoxBikeType.Name = "comboBoxBikeType";
            comboBoxBikeType.Size = new Size(212, 38);
            comboBoxBikeType.TabIndex = 4;
            comboBoxBikeType.SelectedIndexChanged += comboBoxBikeType_SelectedIndexChanged;
            // 
            // comboBoxColor
            // 
            comboBoxColor.FormattingEnabled = true;
            comboBoxColor.Location = new Point(258, 411);
            comboBoxColor.Name = "comboBoxColor";
            comboBoxColor.Size = new Size(212, 38);
            comboBoxColor.TabIndex = 5;
            // 
            // textBoxSerialNumber
            // 
            textBoxSerialNumber.Location = new Point(260, 110);
            textBoxSerialNumber.Name = "textBoxSerialNumber";
            textBoxSerialNumber.Size = new Size(212, 35);
            textBoxSerialNumber.TabIndex = 6;
            // 
            // textBoxMade
            // 
            textBoxMade.Location = new Point(260, 158);
            textBoxMade.Name = "textBoxMade";
            textBoxMade.Size = new Size(212, 35);
            textBoxMade.TabIndex = 7;
            // 
            // groupMountainBike
            // 
            groupMountainBike.Controls.Add(comboBoxSuspension);
            groupMountainBike.Controls.Add(labelSuspension);
            groupMountainBike.Controls.Add(labelHeightFromGround);
            groupMountainBike.Controls.Add(textBoxHeightFromGround);
            groupMountainBike.Location = new Point(599, 651);
            groupMountainBike.Name = "groupMountainBike";
            groupMountainBike.Size = new Size(577, 155);
            groupMountainBike.TabIndex = 53;
            groupMountainBike.TabStop = false;
            groupMountainBike.Text = "Mountain Bike Features";
            // 
            // comboBoxSuspension
            // 
            comboBoxSuspension.FormattingEnabled = true;
            comboBoxSuspension.Location = new Point(353, 42);
            comboBoxSuspension.Name = "comboBoxSuspension";
            comboBoxSuspension.Size = new Size(195, 38);
            comboBoxSuspension.TabIndex = 13;
            // 
            // labelSuspension
            // 
            labelSuspension.BackColor = Color.Transparent;
            labelSuspension.BorderStyle = BorderStyle.Fixed3D;
            labelSuspension.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelSuspension.ForeColor = Color.Black;
            labelSuspension.Location = new Point(59, 42);
            labelSuspension.Name = "labelSuspension";
            labelSuspension.Size = new Size(196, 44);
            labelSuspension.TabIndex = 32;
            labelSuspension.Text = "Suspension?";
            labelSuspension.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelHeightFromGround
            // 
            labelHeightFromGround.BackColor = Color.Transparent;
            labelHeightFromGround.BorderStyle = BorderStyle.Fixed3D;
            labelHeightFromGround.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelHeightFromGround.ForeColor = Color.Black;
            labelHeightFromGround.Location = new Point(15, 86);
            labelHeightFromGround.Name = "labelHeightFromGround";
            labelHeightFromGround.Size = new Size(315, 44);
            labelHeightFromGround.TabIndex = 8;
            labelHeightFromGround.Text = "Height From Ground?";
            labelHeightFromGround.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxHeightFromGround
            // 
            textBoxHeightFromGround.Location = new Point(353, 92);
            textBoxHeightFromGround.Name = "textBoxHeightFromGround";
            textBoxHeightFromGround.Size = new Size(195, 35);
            textBoxHeightFromGround.TabIndex = 10;
            // 
            // labelSeatHight
            // 
            labelSeatHight.BackColor = Color.Transparent;
            labelSeatHight.BorderStyle = BorderStyle.Fixed3D;
            labelSeatHight.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelSeatHight.ForeColor = Color.Black;
            labelSeatHight.Location = new Point(15, 40);
            labelSeatHight.Name = "labelSeatHight";
            labelSeatHight.Size = new Size(249, 46);
            labelSeatHight.TabIndex = 9;
            labelSeatHight.Text = "Seat Height?";
            labelSeatHight.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxSeatHeight
            // 
            textBoxSeatHeight.Location = new Point(287, 47);
            textBoxSeatHeight.Name = "textBoxSeatHeight";
            textBoxSeatHeight.Size = new Size(195, 35);
            textBoxSeatHeight.TabIndex = 31;
            // 
            // groupBoxMadeDate
            // 
            groupBoxMadeDate.Controls.Add(labelMadeDate);
            groupBoxMadeDate.Controls.Add(labelMonth);
            groupBoxMadeDate.Controls.Add(labelDay);
            groupBoxMadeDate.Controls.Add(labelYear);
            groupBoxMadeDate.Controls.Add(textBoxMonth);
            groupBoxMadeDate.Controls.Add(textBoxDay);
            groupBoxMadeDate.Controls.Add(textBoxYear);
            groupBoxMadeDate.Location = new Point(1288, 156);
            groupBoxMadeDate.Name = "groupBoxMadeDate";
            groupBoxMadeDate.Size = new Size(323, 261);
            groupBoxMadeDate.TabIndex = 52;
            groupBoxMadeDate.TabStop = false;
            groupBoxMadeDate.Text = "Made Date";
            // 
            // labelMadeDate
            // 
            labelMadeDate.AutoSize = true;
            labelMadeDate.BackColor = Color.Transparent;
            labelMadeDate.BorderStyle = BorderStyle.Fixed3D;
            labelMadeDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            labelMadeDate.ForeColor = Color.Black;
            labelMadeDate.Location = new Point(55, 39);
            labelMadeDate.Margin = new Padding(5, 0, 5, 0);
            labelMadeDate.Name = "labelMadeDate";
            labelMadeDate.Size = new Size(177, 40);
            labelMadeDate.TabIndex = 13;
            labelMadeDate.Text = "Made Date?";
            // 
            // labelMonth
            // 
            labelMonth.AutoSize = true;
            labelMonth.BackColor = Color.Transparent;
            labelMonth.BorderStyle = BorderStyle.Fixed3D;
            labelMonth.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelMonth.ForeColor = Color.Black;
            labelMonth.Location = new Point(12, 160);
            labelMonth.Margin = new Padding(5, 0, 5, 0);
            labelMonth.Name = "labelMonth";
            labelMonth.Size = new Size(91, 32);
            labelMonth.TabIndex = 19;
            labelMonth.Text = "Month?";
            // 
            // labelDay
            // 
            labelDay.AutoSize = true;
            labelDay.BackColor = Color.Transparent;
            labelDay.BorderStyle = BorderStyle.Fixed3D;
            labelDay.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelDay.ForeColor = Color.Black;
            labelDay.Location = new Point(36, 118);
            labelDay.Margin = new Padding(5, 0, 5, 0);
            labelDay.Name = "labelDay";
            labelDay.Size = new Size(67, 32);
            labelDay.TabIndex = 20;
            labelDay.Text = "Day? ";
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.BackColor = Color.Transparent;
            labelYear.BorderStyle = BorderStyle.Fixed3D;
            labelYear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelYear.ForeColor = Color.Black;
            labelYear.Location = new Point(31, 203);
            labelYear.Margin = new Padding(5, 0, 5, 0);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(71, 32);
            labelYear.TabIndex = 21;
            labelYear.Text = "Year? ";
            // 
            // textBoxMonth
            // 
            textBoxMonth.Location = new Point(117, 160);
            textBoxMonth.Margin = new Padding(5, 6, 5, 6);
            textBoxMonth.Name = "textBoxMonth";
            textBoxMonth.Size = new Size(180, 35);
            textBoxMonth.TabIndex = 22;
            // 
            // textBoxDay
            // 
            textBoxDay.Location = new Point(117, 115);
            textBoxDay.Margin = new Padding(5, 6, 5, 6);
            textBoxDay.Name = "textBoxDay";
            textBoxDay.Size = new Size(180, 35);
            textBoxDay.TabIndex = 23;
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(117, 204);
            textBoxYear.Margin = new Padding(5, 6, 5, 6);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(180, 35);
            textBoxYear.TabIndex = 24;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonWriteToXmlFile);
            groupBox1.Controls.Add(buttonReadFromXmlFile);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.Location = new Point(21, 1221);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(478, 128);
            groupBox1.TabIndex = 61;
            groupBox1.TabStop = false;
            groupBox1.Text = "Serialize/Deserialize XMI File";
            // 
            // buttonWriteToXmlFile
            // 
            buttonWriteToXmlFile.BackColor = Color.DimGray;
            buttonWriteToXmlFile.FlatAppearance.BorderColor = Color.Black;
            buttonWriteToXmlFile.FlatAppearance.BorderSize = 0;
            buttonWriteToXmlFile.ForeColor = Color.Transparent;
            buttonWriteToXmlFile.Location = new Point(43, 37);
            buttonWriteToXmlFile.Margin = new Padding(5, 6, 5, 6);
            buttonWriteToXmlFile.Name = "buttonWriteToXmlFile";
            buttonWriteToXmlFile.Size = new Size(182, 71);
            buttonWriteToXmlFile.TabIndex = 39;
            buttonWriteToXmlFile.Text = "Write Xml File";
            buttonWriteToXmlFile.UseVisualStyleBackColor = false;
            buttonWriteToXmlFile.Click += buttonWriteToXmlFile_Click;
            // 
            // buttonReadFromXmlFile
            // 
            buttonReadFromXmlFile.BackColor = Color.DimGray;
            buttonReadFromXmlFile.FlatAppearance.BorderColor = Color.Black;
            buttonReadFromXmlFile.FlatAppearance.BorderSize = 0;
            buttonReadFromXmlFile.ForeColor = Color.Transparent;
            buttonReadFromXmlFile.Location = new Point(235, 37);
            buttonReadFromXmlFile.Margin = new Padding(5, 6, 5, 6);
            buttonReadFromXmlFile.Name = "buttonReadFromXmlFile";
            buttonReadFromXmlFile.Size = new Size(206, 71);
            buttonReadFromXmlFile.TabIndex = 40;
            buttonReadFromXmlFile.Text = "Read Xml File";
            buttonReadFromXmlFile.UseVisualStyleBackColor = false;
            buttonReadFromXmlFile.Click += buttonReadFromXmlFile_Click;
            // 
            // listBoxBikes
            // 
            listBoxBikes.BackColor = Color.White;
            listBoxBikes.Font = new Font("Segoe UI", 10F);
            listBoxBikes.ForeColor = Color.Black;
            listBoxBikes.FormattingEnabled = true;
            listBoxBikes.ItemHeight = 31;
            listBoxBikes.Location = new Point(19, 1022);
            listBoxBikes.Margin = new Padding(5, 6, 5, 6);
            listBoxBikes.Name = "listBoxBikes";
            listBoxBikes.Size = new Size(1927, 190);
            listBoxBikes.TabIndex = 60;
            listBoxBikes.SelectedIndexChanged += listBoxBikes_SelectedIndexChanged;
            // 
            // buttonPrintMountainBike
            // 
            buttonPrintMountainBike.BackColor = Color.DimGray;
            buttonPrintMountainBike.FlatAppearance.BorderColor = Color.Black;
            buttonPrintMountainBike.FlatAppearance.BorderSize = 0;
            buttonPrintMountainBike.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            buttonPrintMountainBike.ForeColor = Color.Transparent;
            buttonPrintMountainBike.Location = new Point(316, 50);
            buttonPrintMountainBike.Margin = new Padding(5, 6, 5, 6);
            buttonPrintMountainBike.Name = "buttonPrintMountainBike";
            buttonPrintMountainBike.Size = new Size(180, 70);
            buttonPrintMountainBike.TabIndex = 59;
            buttonPrintMountainBike.Text = "PRINT Mountain Bike";
            buttonPrintMountainBike.UseVisualStyleBackColor = false;
            buttonPrintMountainBike.Click += buttonPrintMountainBike_Click;
            // 
            // buttonPrintRoadBike
            // 
            buttonPrintRoadBike.BackColor = Color.DimGray;
            buttonPrintRoadBike.FlatAppearance.BorderColor = Color.Black;
            buttonPrintRoadBike.FlatAppearance.BorderSize = 0;
            buttonPrintRoadBike.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonPrintRoadBike.ForeColor = Color.Transparent;
            buttonPrintRoadBike.Location = new Point(154, 50);
            buttonPrintRoadBike.Margin = new Padding(5, 6, 5, 6);
            buttonPrintRoadBike.Name = "buttonPrintRoadBike";
            buttonPrintRoadBike.Size = new Size(152, 70);
            buttonPrintRoadBike.TabIndex = 58;
            buttonPrintRoadBike.Text = "PRINT Road Bike";
            buttonPrintRoadBike.UseVisualStyleBackColor = false;
            buttonPrintRoadBike.Click += buttonPrintRoadBike_Click;
            // 
            // buttonReset
            // 
            buttonReset.BackColor = Color.DimGray;
            buttonReset.FlatAppearance.BorderColor = Color.Black;
            buttonReset.FlatAppearance.BorderSize = 0;
            buttonReset.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonReset.ForeColor = Color.Transparent;
            buttonReset.Location = new Point(1828, 1221);
            buttonReset.Margin = new Padding(5, 6, 5, 6);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(118, 70);
            buttonReset.TabIndex = 57;
            buttonReset.Text = "RESET";
            buttonReset.UseVisualStyleBackColor = false;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonPrintBike
            // 
            buttonPrintBike.BackColor = Color.DimGray;
            buttonPrintBike.FlatAppearance.BorderColor = Color.Black;
            buttonPrintBike.FlatAppearance.BorderSize = 0;
            buttonPrintBike.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonPrintBike.ForeColor = Color.Transparent;
            buttonPrintBike.Location = new Point(41, 51);
            buttonPrintBike.Margin = new Padding(5, 6, 5, 6);
            buttonPrintBike.Name = "buttonPrintBike";
            buttonPrintBike.Size = new Size(103, 70);
            buttonPrintBike.TabIndex = 56;
            buttonPrintBike.Text = "PRINT Bike";
            buttonPrintBike.UseVisualStyleBackColor = false;
            buttonPrintBike.Click += buttonPrintBikes_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.DimGray;
            buttonAdd.FlatAppearance.BorderColor = Color.Black;
            buttonAdd.FlatAppearance.BorderSize = 0;
            buttonAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonAdd.ForeColor = Color.Transparent;
            buttonAdd.Location = new Point(17, 940);
            buttonAdd.Margin = new Padding(5, 6, 5, 6);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(118, 70);
            buttonAdd.TabIndex = 55;
            buttonAdd.Text = "ADD";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.DimGray;
            buttonDelete.FlatAppearance.BorderColor = Color.Black;
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonDelete.ForeColor = Color.Transparent;
            buttonDelete.Location = new Point(1967, 1218);
            buttonDelete.Margin = new Padding(5, 6, 5, 6);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(118, 66);
            buttonDelete.TabIndex = 67;
            buttonDelete.Text = "DELETE";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // labelDelete
            // 
            labelDelete.BackColor = Color.Transparent;
            labelDelete.BorderStyle = BorderStyle.Fixed3D;
            labelDelete.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            labelDelete.ForeColor = Color.Black;
            labelDelete.Location = new Point(1968, 1157);
            labelDelete.Margin = new Padding(5, 0, 5, 0);
            labelDelete.Name = "labelDelete";
            labelDelete.Size = new Size(532, 55);
            labelDelete.TabIndex = 66;
            labelDelete.Text = "Choose a bike to remove from the listBox";
            labelDelete.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.DimGray;
            buttonUpdate.FlatAppearance.BorderColor = Color.Black;
            buttonUpdate.FlatAppearance.BorderSize = 0;
            buttonUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonUpdate.ForeColor = Color.Transparent;
            buttonUpdate.Location = new Point(1967, 1050);
            buttonUpdate.Margin = new Padding(5, 6, 5, 6);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(118, 66);
            buttonUpdate.TabIndex = 65;
            buttonUpdate.Text = "UPDATE";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // labelUpdate
            // 
            labelUpdate.BackColor = Color.Transparent;
            labelUpdate.BorderStyle = BorderStyle.Fixed3D;
            labelUpdate.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            labelUpdate.ForeColor = Color.Black;
            labelUpdate.Location = new Point(1967, 1002);
            labelUpdate.Margin = new Padding(5, 0, 5, 0);
            labelUpdate.Name = "labelUpdate";
            labelUpdate.Size = new Size(530, 45);
            labelUpdate.TabIndex = 64;
            labelUpdate.Text = "Choose a bike to update from the listBox";
            labelUpdate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSearch
            // 
            labelSearch.BackColor = Color.Transparent;
            labelSearch.BorderStyle = BorderStyle.Fixed3D;
            labelSearch.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            labelSearch.ForeColor = Color.Black;
            labelSearch.Location = new Point(1968, 842);
            labelSearch.Margin = new Padding(5, 0, 5, 0);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(485, 55);
            labelSearch.TabIndex = 63;
            labelSearch.Text = "Search for a bike by the serial number";
            labelSearch.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.DimGray;
            buttonSearch.FlatAppearance.BorderColor = Color.Black;
            buttonSearch.FlatAppearance.BorderSize = 0;
            buttonSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonSearch.ForeColor = Color.Transparent;
            buttonSearch.Location = new Point(1967, 903);
            buttonSearch.Margin = new Padding(5, 6, 5, 6);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(118, 66);
            buttonSearch.TabIndex = 62;
            buttonSearch.Text = "SEARCH";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.DimGray;
            buttonExit.FlatAppearance.BorderColor = Color.Black;
            buttonExit.FlatAppearance.BorderSize = 0;
            buttonExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonExit.ForeColor = Color.Transparent;
            buttonExit.Location = new Point(2383, 1257);
            buttonExit.Margin = new Padding(5, 6, 5, 6);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(118, 102);
            buttonExit.TabIndex = 68;
            buttonExit.Text = "EXIT";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonPrintHybridBike);
            groupBox3.Controls.Add(buttonPrintElectricBike);
            groupBox3.Controls.Add(buttonPrintMountainBike);
            groupBox3.Controls.Add(buttonPrintBike);
            groupBox3.Controls.Add(buttonPrintRoadBike);
            groupBox3.Location = new Point(1073, 871);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(873, 142);
            groupBox3.TabIndex = 69;
            groupBox3.TabStop = false;
            groupBox3.Text = "Printing Bikes";
            // 
            // buttonPrintHybridBike
            // 
            buttonPrintHybridBike.BackColor = Color.DimGray;
            buttonPrintHybridBike.FlatAppearance.BorderColor = Color.Black;
            buttonPrintHybridBike.FlatAppearance.BorderSize = 0;
            buttonPrintHybridBike.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            buttonPrintHybridBike.ForeColor = Color.Transparent;
            buttonPrintHybridBike.Location = new Point(668, 51);
            buttonPrintHybridBike.Margin = new Padding(5, 6, 5, 6);
            buttonPrintHybridBike.Name = "buttonPrintHybridBike";
            buttonPrintHybridBike.Size = new Size(180, 70);
            buttonPrintHybridBike.TabIndex = 61;
            buttonPrintHybridBike.Text = "PRINT Hybrid Bike";
            buttonPrintHybridBike.UseVisualStyleBackColor = false;
            buttonPrintHybridBike.Click += buttonPrintHybridBike_Click;
            // 
            // buttonPrintElectricBike
            // 
            buttonPrintElectricBike.BackColor = Color.DimGray;
            buttonPrintElectricBike.FlatAppearance.BorderColor = Color.Black;
            buttonPrintElectricBike.FlatAppearance.BorderSize = 0;
            buttonPrintElectricBike.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonPrintElectricBike.ForeColor = Color.Transparent;
            buttonPrintElectricBike.Location = new Point(506, 51);
            buttonPrintElectricBike.Margin = new Padding(5, 6, 5, 6);
            buttonPrintElectricBike.Name = "buttonPrintElectricBike";
            buttonPrintElectricBike.Size = new Size(152, 70);
            buttonPrintElectricBike.TabIndex = 60;
            buttonPrintElectricBike.Text = "PRINT Electric Bike";
            buttonPrintElectricBike.UseVisualStyleBackColor = false;
            buttonPrintElectricBike.Click += buttonPrintElectricBike_Click;
            // 
            // groupBoxRoadBike
            // 
            groupBoxRoadBike.Controls.Add(textBoxSeatHeight);
            groupBoxRoadBike.Controls.Add(labelSeatHight);
            groupBoxRoadBike.Location = new Point(67, 677);
            groupBoxRoadBike.Name = "groupBoxRoadBike";
            groupBoxRoadBike.Size = new Size(507, 101);
            groupBoxRoadBike.TabIndex = 33;
            groupBoxRoadBike.TabStop = false;
            groupBoxRoadBike.Text = "Road Bike Feature";
            // 
            // groupBoxElectricBike
            // 
            groupBoxElectricBike.Controls.Add(textBoxBatteryIndicator);
            groupBoxElectricBike.Controls.Add(labelBatteryIndicator);
            groupBoxElectricBike.Location = new Point(1193, 677);
            groupBoxElectricBike.Name = "groupBoxElectricBike";
            groupBoxElectricBike.Size = new Size(507, 101);
            groupBoxElectricBike.TabIndex = 34;
            groupBoxElectricBike.TabStop = false;
            groupBoxElectricBike.Text = "Electric Bike Feature";
            // 
            // textBoxBatteryIndicator
            // 
            textBoxBatteryIndicator.Location = new Point(287, 47);
            textBoxBatteryIndicator.Name = "textBoxBatteryIndicator";
            textBoxBatteryIndicator.Size = new Size(195, 35);
            textBoxBatteryIndicator.TabIndex = 31;
            // 
            // labelBatteryIndicator
            // 
            labelBatteryIndicator.BackColor = Color.Transparent;
            labelBatteryIndicator.BorderStyle = BorderStyle.Fixed3D;
            labelBatteryIndicator.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelBatteryIndicator.ForeColor = Color.Black;
            labelBatteryIndicator.Location = new Point(15, 36);
            labelBatteryIndicator.Name = "labelBatteryIndicator";
            labelBatteryIndicator.Size = new Size(249, 46);
            labelBatteryIndicator.TabIndex = 9;
            labelBatteryIndicator.Text = "Battery Indicator?";
            labelBatteryIndicator.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBoxHybridBike
            // 
            groupBoxHybridBike.Controls.Add(comboBoxHybridType);
            groupBoxHybridBike.Controls.Add(labelHybridType);
            groupBoxHybridBike.Location = new Point(1741, 677);
            groupBoxHybridBike.Name = "groupBoxHybridBike";
            groupBoxHybridBike.Size = new Size(507, 101);
            groupBoxHybridBike.TabIndex = 35;
            groupBoxHybridBike.TabStop = false;
            groupBoxHybridBike.Text = "Hybrid Bike Feature";
            // 
            // comboBoxHybridType
            // 
            comboBoxHybridType.FormattingEnabled = true;
            comboBoxHybridType.Location = new Point(287, 43);
            comboBoxHybridType.Name = "comboBoxHybridType";
            comboBoxHybridType.Size = new Size(195, 38);
            comboBoxHybridType.TabIndex = 33;
            // 
            // labelHybridType
            // 
            labelHybridType.BackColor = Color.Transparent;
            labelHybridType.BorderStyle = BorderStyle.Fixed3D;
            labelHybridType.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelHybridType.ForeColor = Color.Black;
            labelHybridType.Location = new Point(15, 36);
            labelHybridType.Name = "labelHybridType";
            labelHybridType.Size = new Size(249, 46);
            labelHybridType.TabIndex = 9;
            labelHybridType.Text = "Type?";
            labelHybridType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1689, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 203);
            pictureBox1.TabIndex = 70;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(1689, -4);
            label1.Name = "label1";
            label1.Size = new Size(210, 37);
            label1.TabIndex = 71;
            label1.Text = "Try the electric one";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1939, 88);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(376, 306);
            pictureBox2.TabIndex = 72;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(2018, 407);
            label2.Name = "label2";
            label2.Size = new Size(247, 37);
            label2.TabIndex = 73;
            label2.Text = "Or prefer an hybrid?";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1633, 255);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(258, 259);
            pictureBox3.TabIndex = 74;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(1633, 517);
            label3.Name = "label3";
            label3.Size = new Size(256, 37);
            label3.TabIndex = 75;
            label3.Text = "We offer in many colors";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(462, 257);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(286, 259);
            pictureBox4.TabIndex = 76;
            pictureBox4.TabStop = false;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(40, 68);
            label4.Name = "label4";
            label4.Size = new Size(353, 37);
            label4.TabIndex = 77;
            label4.Text = "Try the new mountain bike";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(17, 127);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(401, 304);
            pictureBox5.TabIndex = 78;
            pictureBox5.TabStop = false;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(426, 517);
            label5.Name = "label5";
            label5.Size = new Size(353, 37);
            label5.TabIndex = 79;
            label5.Text = "Adjust the seat for your road bike";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(6, 103);
            label6.Name = "label6";
            label6.Size = new Size(261, 106);
            label6.TabIndex = 81;
            label6.Text = "Choose a bike from the listBox and input in the numbericBox a number to SPEED UP your bike's speed";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numericUpDownSpeed
            // 
            numericUpDownSpeed.Location = new Point(156, 53);
            numericUpDownSpeed.Name = "numericUpDownSpeed";
            numericUpDownSpeed.Size = new Size(89, 35);
            numericUpDownSpeed.TabIndex = 82;
            // 
            // buttonTestSpeed
            // 
            buttonTestSpeed.BackColor = Color.DimGray;
            buttonTestSpeed.FlatAppearance.BorderColor = Color.Black;
            buttonTestSpeed.FlatAppearance.BorderSize = 0;
            buttonTestSpeed.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            buttonTestSpeed.ForeColor = Color.Transparent;
            buttonTestSpeed.Location = new Point(33, 43);
            buttonTestSpeed.Margin = new Padding(5, 6, 5, 6);
            buttonTestSpeed.Name = "buttonTestSpeed";
            buttonTestSpeed.Size = new Size(112, 54);
            buttonTestSpeed.TabIndex = 83;
            buttonTestSpeed.Text = "SPEED UP";
            buttonTestSpeed.UseVisualStyleBackColor = false;
            buttonTestSpeed.Click += buttonTestSpeedUp_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonTestSpeed);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(numericUpDownSpeed);
            groupBox2.Location = new Point(1288, 442);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(306, 213);
            groupBox2.TabIndex = 84;
            groupBox2.TabStop = false;
            groupBox2.Text = "Speed Up";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2514, 1361);
            Controls.Add(groupBox2);
            Controls.Add(label5);
            Controls.Add(pictureBox5);
            Controls.Add(label4);
            Controls.Add(pictureBox4);
            Controls.Add(label3);
            Controls.Add(pictureBox3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(groupBoxHybridBike);
            Controls.Add(groupBoxElectricBike);
            Controls.Add(groupBoxRoadBike);
            Controls.Add(groupBox3);
            Controls.Add(buttonExit);
            Controls.Add(buttonDelete);
            Controls.Add(labelDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(labelUpdate);
            Controls.Add(labelSearch);
            Controls.Add(buttonSearch);
            Controls.Add(groupBox1);
            Controls.Add(listBoxBikes);
            Controls.Add(buttonReset);
            Controls.Add(buttonAdd);
            Controls.Add(groupBoxBikeInfo);
            Controls.Add(groupMountainBike);
            Controls.Add(groupBoxMadeDate);
            Name = "Form1";
            Text = "Alvaro Limaymanta Soria - 202311145";
            Load += Form1_Load;
            groupBoxBikeInfo.ResumeLayout(false);
            groupBoxBikeInfo.PerformLayout();
            groupMountainBike.ResumeLayout(false);
            groupMountainBike.PerformLayout();
            groupBoxMadeDate.ResumeLayout(false);
            groupBoxMadeDate.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBoxRoadBike.ResumeLayout(false);
            groupBoxRoadBike.PerformLayout();
            groupBoxElectricBike.ResumeLayout(false);
            groupBoxElectricBike.PerformLayout();
            groupBoxHybridBike.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSpeed).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxBikeInfo;
        private Label labelBikeType;
        private Label labelSerialNumber;
        private Label labelMade;
        private ComboBox comboBoxBikeType;
        private ComboBox comboBoxColor;
        private TextBox textBoxSerialNumber;
        private TextBox textBoxMade;
        private GroupBox groupMountainBike;
        private Label labelHeightFromGround;
        private Label labelSeatHight;
        private TextBox textBoxHeightFromGround;
        private TextBox textBoxSeatHeight;
        private GroupBox groupBoxMadeDate;
        private Label labelMadeDate;
        private Label labelMonth;
        private Label labelDay;
        private Label labelYear;
        private TextBox textBoxMonth;
        private TextBox textBoxDay;
        private TextBox textBoxYear;
        private GroupBox groupBox1;
        private Button buttonWriteToXmlFile;
        private Button buttonReadFromXmlFile;
        private ListBox listBoxBikes;
        private Button buttonPrintMountainBike;
        private Button buttonPrintRoadBike;
        private Button buttonReset;
        private Button buttonPrintBike;
        private Button buttonAdd;
        private Button buttonDelete;
        private Label labelDelete;
        private Button buttonUpdate;
        private Label labelUpdate;
        private Label labelSearch;
        private Button buttonSearch;
        private Button buttonExit;
        private Label labelModel;
        private TextBox textBoxModel;
        private Label labelSpeed;
        private TextBox textBoxSpeed;
        private Label labelColor;
        private ComboBox comboBoxSuspension;
        private Label labelSuspension;
        private Label labelWheelSize;
        private TextBox textBoxWheelSize;
        private Label labelFrameType;
        private ComboBox comboBoxFrameType;
        private GroupBox groupBox3;
        private GroupBox groupBoxRoadBike;
        private GroupBox groupBoxElectricBike;
        private TextBox textBoxBatteryIndicator;
        private Label labelBatteryIndicator;
        private GroupBox groupBoxHybridBike;
        private Label labelHybridType;
        private ComboBox comboBoxHybridType;
        private Button buttonPrintHybridBike;
        private Button buttonPrintElectricBike;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label2;
        private PictureBox pictureBox3;
        private Label label3;
        private PictureBox pictureBox4;
        private Label label4;
        private PictureBox pictureBox5;
        private Label label5;
        private Label label6;
        private NumericUpDown numericUpDownSpeed;
        private Button buttonTestSpeed;
        private GroupBox groupBox2;
    }
}
