using System.Windows.Forms;

namespace TransPak
{
    partial class LumberCalculator
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
            this.lumberDimensionsDropBox = new System.Windows.Forms.ComboBox();
            this.lumberDimensionsLabel = new System.Windows.Forms.Label();
            this.countDropBox = new System.Windows.Forms.ComboBox();
            this.countLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.comboBox6ft = new System.Windows.Forms.ComboBox();
            this.comboBox16ft = new System.Windows.Forms.ComboBox();
            this.comboBox14ft = new System.Windows.Forms.ComboBox();
            this.comboBox12ft = new System.Windows.Forms.ComboBox();
            this.comboBox10ft = new System.Windows.Forms.ComboBox();
            this.comboBox8ft = new System.Windows.Forms.ComboBox();
            this.comboBox20ft = new System.Windows.Forms.ComboBox();
            this.comboBox18ft = new System.Windows.Forms.ComboBox();
            this.calculateLumberButton = new System.Windows.Forms.Button();
            this.plywoodDimensionsDropBox = new System.Windows.Forms.ComboBox();
            this.plywoodDimensionsLabel = new System.Windows.Forms.Label();
            this.unitsLabel = new System.Windows.Forms.Label();
            this.unitsDropBox = new System.Windows.Forms.ComboBox();
            this.calculatePlywoodButton = new System.Windows.Forms.Button();
            this.plywoodResultTextBox = new System.Windows.Forms.TextBox();
            this.lumberResultTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox20ft = new System.Windows.Forms.CheckBox();
            this.checkBox18ft = new System.Windows.Forms.CheckBox();
            this.checkBox16ft = new System.Windows.Forms.CheckBox();
            this.checkBox14ft = new System.Windows.Forms.CheckBox();
            this.checkBox12ft = new System.Windows.Forms.CheckBox();
            this.checkBox10ft = new System.Windows.Forms.CheckBox();
            this.checkBox8ft = new System.Windows.Forms.CheckBox();
            this.checkBox6ft = new System.Windows.Forms.CheckBox();
            this.lumberUnitsLabel = new System.Windows.Forms.Label();
            this.pricePerSheetLabel = new System.Windows.Forms.Label();
            this.pricePerSheetComboBox = new System.Windows.Forms.ComboBox();
            this.resultPricePerThousandPlywood = new System.Windows.Forms.TextBox();
            this.calculatePricePerThousandSheetButton = new System.Windows.Forms.Button();
            this.costPerPiecelabel = new System.Windows.Forms.Label();
            this.lumberCostDimensionsComboBox = new System.Windows.Forms.ComboBox();
            this.costPerPieceDimensionLabel = new System.Windows.Forms.Label();
            this.lengthCostLabel = new System.Windows.Forms.Label();
            this.lumberLengthCostComboBox = new System.Windows.Forms.ComboBox();
            this.pricePerPieceComboBox = new System.Windows.Forms.ComboBox();
            this.resultPricePerThousandLumber = new System.Windows.Forms.TextBox();
            this.calculateCostPerThousandPieceButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.notesLabel = new System.Windows.Forms.Label();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descripionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.partNumberResultTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.plywoodSizeSearchComboBox = new System.Windows.Forms.ComboBox();
            this.PlywoodSizeSearchLabel = new System.Windows.Forms.Label();
            this.transpakFacilitiesSearch = new System.Windows.Forms.ComboBox();
            this.locationsLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.altNotesTextBox = new System.Windows.Forms.TextBox();
            this.altNotesLabel = new System.Windows.Forms.Label();
            this.altPartNumberTextBox = new System.Windows.Forms.TextBox();
            this.altDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.altDescriptionLabel = new System.Windows.Forms.Label();
            this.altPartNumberLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lumberDimensionsDropBox
            // 
            this.lumberDimensionsDropBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lumberDimensionsDropBox.FormattingEnabled = true;
            this.lumberDimensionsDropBox.Items.AddRange(new object[] {
            "1x4",
            "1x6",
            "2x4",
            "2x6",
            "2x8",
            "2x10",
            "2x12",
            "3x6",
            "4x4",
            "4x6"});
            this.lumberDimensionsDropBox.Location = new System.Drawing.Point(86, 29);
            this.lumberDimensionsDropBox.Name = "lumberDimensionsDropBox";
            this.lumberDimensionsDropBox.Size = new System.Drawing.Size(85, 26);
            this.lumberDimensionsDropBox.TabIndex = 3;
            this.lumberDimensionsDropBox.SelectedIndexChanged += new System.EventHandler(this.lumberDimensionsDropBox_SelectedIndexChanged);
            // 
            // lumberDimensionsLabel
            // 
            this.lumberDimensionsLabel.AutoSize = true;
            this.lumberDimensionsLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lumberDimensionsLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lumberDimensionsLabel.Location = new System.Drawing.Point(51, 8);
            this.lumberDimensionsLabel.Name = "lumberDimensionsLabel";
            this.lumberDimensionsLabel.Size = new System.Drawing.Size(179, 18);
            this.lumberDimensionsLabel.TabIndex = 2;
            this.lumberDimensionsLabel.Text = "Lumber Dimensions";
            // 
            // countDropBox
            // 
            this.countDropBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countDropBox.FormattingEnabled = true;
            this.countDropBox.Location = new System.Drawing.Point(100, 84);
            this.countDropBox.Name = "countDropBox";
            this.countDropBox.Size = new System.Drawing.Size(57, 26);
            this.countDropBox.TabIndex = 4;
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.countLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countLabel.Location = new System.Drawing.Point(97, 63);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(60, 18);
            this.countLabel.TabIndex = 5;
            this.countLabel.Text = "Count";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.BackColor = System.Drawing.Color.Transparent;
            this.lengthLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthLabel.Location = new System.Drawing.Point(0, 10);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(74, 18);
            this.lengthLabel.TabIndex = 7;
            this.lengthLabel.Text = "Length ";
            // 
            // comboBox6ft
            // 
            this.comboBox6ft.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox6ft.FormattingEnabled = true;
            this.comboBox6ft.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comboBox6ft.Location = new System.Drawing.Point(86, 31);
            this.comboBox6ft.Name = "comboBox6ft";
            this.comboBox6ft.Size = new System.Drawing.Size(50, 26);
            this.comboBox6ft.TabIndex = 8;
            this.comboBox6ft.Text = "0";
            this.comboBox6ft.Visible = false;
            this.comboBox6ft.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox6ft_OnKeyPress);
            // 
            // comboBox16ft
            // 
            this.comboBox16ft.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox16ft.FormattingEnabled = true;
            this.comboBox16ft.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comboBox16ft.Location = new System.Drawing.Point(86, 191);
            this.comboBox16ft.Name = "comboBox16ft";
            this.comboBox16ft.Size = new System.Drawing.Size(50, 26);
            this.comboBox16ft.TabIndex = 9;
            this.comboBox16ft.Text = "0";
            this.comboBox16ft.Visible = false;
            this.comboBox16ft.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox16ft_OnKeyPress);
            // 
            // comboBox14ft
            // 
            this.comboBox14ft.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox14ft.FormattingEnabled = true;
            this.comboBox14ft.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comboBox14ft.Location = new System.Drawing.Point(86, 159);
            this.comboBox14ft.Name = "comboBox14ft";
            this.comboBox14ft.Size = new System.Drawing.Size(50, 26);
            this.comboBox14ft.TabIndex = 10;
            this.comboBox14ft.Text = "0";
            this.comboBox14ft.Visible = false;
            this.comboBox14ft.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox14ft_OnKeyPress);
            // 
            // comboBox12ft
            // 
            this.comboBox12ft.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox12ft.FormattingEnabled = true;
            this.comboBox12ft.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comboBox12ft.Location = new System.Drawing.Point(86, 127);
            this.comboBox12ft.Name = "comboBox12ft";
            this.comboBox12ft.Size = new System.Drawing.Size(50, 26);
            this.comboBox12ft.TabIndex = 11;
            this.comboBox12ft.Text = "0";
            this.comboBox12ft.Visible = false;
            this.comboBox12ft.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox12ft_OnKeyPress);
            // 
            // comboBox10ft
            // 
            this.comboBox10ft.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox10ft.FormattingEnabled = true;
            this.comboBox10ft.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comboBox10ft.Location = new System.Drawing.Point(86, 95);
            this.comboBox10ft.Name = "comboBox10ft";
            this.comboBox10ft.Size = new System.Drawing.Size(50, 26);
            this.comboBox10ft.TabIndex = 12;
            this.comboBox10ft.Text = "0";
            this.comboBox10ft.Visible = false;
            this.comboBox10ft.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox10ft_OnKeyPress);
            // 
            // comboBox8ft
            // 
            this.comboBox8ft.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox8ft.FormattingEnabled = true;
            this.comboBox8ft.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comboBox8ft.Location = new System.Drawing.Point(86, 63);
            this.comboBox8ft.Name = "comboBox8ft";
            this.comboBox8ft.Size = new System.Drawing.Size(50, 26);
            this.comboBox8ft.TabIndex = 13;
            this.comboBox8ft.Text = "0";
            this.comboBox8ft.Visible = false;
            this.comboBox8ft.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox8ft_OnKeyPress);
            // 
            // comboBox20ft
            // 
            this.comboBox20ft.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox20ft.FormattingEnabled = true;
            this.comboBox20ft.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comboBox20ft.Location = new System.Drawing.Point(85, 255);
            this.comboBox20ft.Name = "comboBox20ft";
            this.comboBox20ft.Size = new System.Drawing.Size(50, 26);
            this.comboBox20ft.TabIndex = 15;
            this.comboBox20ft.Text = "0";
            this.comboBox20ft.Visible = false;
            this.comboBox20ft.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox20ft_OnKeyPress);
            // 
            // comboBox18ft
            // 
            this.comboBox18ft.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox18ft.FormattingEnabled = true;
            this.comboBox18ft.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comboBox18ft.Location = new System.Drawing.Point(85, 223);
            this.comboBox18ft.Name = "comboBox18ft";
            this.comboBox18ft.Size = new System.Drawing.Size(50, 26);
            this.comboBox18ft.TabIndex = 16;
            this.comboBox18ft.Text = "0";
            this.comboBox18ft.Visible = false;
            this.comboBox18ft.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox18ft_OnKeyPress);
            // 
            // calculateLumberButton
            // 
            this.calculateLumberButton.BackColor = System.Drawing.SystemColors.Control;
            this.calculateLumberButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateLumberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.calculateLumberButton.Location = new System.Drawing.Point(3, 425);
            this.calculateLumberButton.Name = "calculateLumberButton";
            this.calculateLumberButton.Size = new System.Drawing.Size(103, 27);
            this.calculateLumberButton.TabIndex = 24;
            this.calculateLumberButton.Text = "Calculate";
            this.calculateLumberButton.UseVisualStyleBackColor = false;
            this.calculateLumberButton.Click += new System.EventHandler(this.calculateLumberButton_Click);
            // 
            // plywoodDimensionsDropBox
            // 
            this.plywoodDimensionsDropBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plywoodDimensionsDropBox.FormattingEnabled = true;
            this.plywoodDimensionsDropBox.Items.AddRange(new object[] {
            "1/4",
            "1/2",
            "3/4",
            "3/8",
            "1 1/8"});
            this.plywoodDimensionsDropBox.Location = new System.Drawing.Point(90, 32);
            this.plywoodDimensionsDropBox.Name = "plywoodDimensionsDropBox";
            this.plywoodDimensionsDropBox.Size = new System.Drawing.Size(85, 26);
            this.plywoodDimensionsDropBox.TabIndex = 27;
            this.plywoodDimensionsDropBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.plywoodDimensionsDropBox_OnKeyPress);
            // 
            // plywoodDimensionsLabel
            // 
            this.plywoodDimensionsLabel.AutoSize = true;
            this.plywoodDimensionsLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.plywoodDimensionsLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plywoodDimensionsLabel.Location = new System.Drawing.Point(68, 6);
            this.plywoodDimensionsLabel.Name = "plywoodDimensionsLabel";
            this.plywoodDimensionsLabel.Size = new System.Drawing.Size(124, 18);
            this.plywoodDimensionsLabel.TabIndex = 26;
            this.plywoodDimensionsLabel.Text = "Plywood Size";
            // 
            // unitsLabel
            // 
            this.unitsLabel.AutoSize = true;
            this.unitsLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.unitsLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitsLabel.Location = new System.Drawing.Point(109, 68);
            this.unitsLabel.Name = "unitsLabel";
            this.unitsLabel.Size = new System.Drawing.Size(52, 18);
            this.unitsLabel.TabIndex = 29;
            this.unitsLabel.Text = "Units";
            // 
            // unitsDropBox
            // 
            this.unitsDropBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitsDropBox.FormattingEnabled = true;
            this.unitsDropBox.Items.AddRange(new object[] {
            15});
            this.unitsDropBox.Location = new System.Drawing.Point(112, 96);
            this.unitsDropBox.Name = "unitsDropBox";
            this.unitsDropBox.Size = new System.Drawing.Size(49, 26);
            this.unitsDropBox.TabIndex = 28;
            this.unitsDropBox.Text = "15";
            this.unitsDropBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.unitsDropBox_OnKeyPress);
            // 
            // calculatePlywoodButton
            // 
            this.calculatePlywoodButton.BackColor = System.Drawing.SystemColors.Control;
            this.calculatePlywoodButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatePlywoodButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.calculatePlywoodButton.Location = new System.Drawing.Point(3, 132);
            this.calculatePlywoodButton.Name = "calculatePlywoodButton";
            this.calculatePlywoodButton.Size = new System.Drawing.Size(103, 29);
            this.calculatePlywoodButton.TabIndex = 30;
            this.calculatePlywoodButton.Text = "Calculate";
            this.calculatePlywoodButton.UseVisualStyleBackColor = false;
            this.calculatePlywoodButton.Click += new System.EventHandler(this.calculatePlywoodButton_Click);
            // 
            // plywoodResultTextBox
            // 
            this.plywoodResultTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plywoodResultTextBox.Location = new System.Drawing.Point(112, 134);
            this.plywoodResultTextBox.Name = "plywoodResultTextBox";
            this.plywoodResultTextBox.Size = new System.Drawing.Size(100, 27);
            this.plywoodResultTextBox.TabIndex = 32;
            this.plywoodResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lumberResultTextBox
            // 
            this.lumberResultTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lumberResultTextBox.Location = new System.Drawing.Point(112, 425);
            this.lumberResultTextBox.Name = "lumberResultTextBox";
            this.lumberResultTextBox.Size = new System.Drawing.Size(100, 27);
            this.lumberResultTextBox.TabIndex = 33;
            this.lumberResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.checkBox20ft);
            this.panel1.Controls.Add(this.checkBox18ft);
            this.panel1.Controls.Add(this.checkBox16ft);
            this.panel1.Controls.Add(this.checkBox14ft);
            this.panel1.Controls.Add(this.checkBox12ft);
            this.panel1.Controls.Add(this.checkBox10ft);
            this.panel1.Controls.Add(this.checkBox8ft);
            this.panel1.Controls.Add(this.checkBox6ft);
            this.panel1.Controls.Add(this.lumberUnitsLabel);
            this.panel1.Controls.Add(this.comboBox6ft);
            this.panel1.Controls.Add(this.comboBox20ft);
            this.panel1.Controls.Add(this.comboBox18ft);
            this.panel1.Controls.Add(this.comboBox16ft);
            this.panel1.Controls.Add(this.comboBox8ft);
            this.panel1.Controls.Add(this.comboBox14ft);
            this.panel1.Controls.Add(this.comboBox12ft);
            this.panel1.Controls.Add(this.lengthLabel);
            this.panel1.Controls.Add(this.comboBox10ft);
            this.panel1.Location = new System.Drawing.Point(64, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 286);
            this.panel1.TabIndex = 34;
            // 
            // checkBox20ft
            // 
            this.checkBox20ft.AutoSize = true;
            this.checkBox20ft.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox20ft.Location = new System.Drawing.Point(3, 259);
            this.checkBox20ft.Name = "checkBox20ft";
            this.checkBox20ft.Size = new System.Drawing.Size(47, 22);
            this.checkBox20ft.TabIndex = 43;
            this.checkBox20ft.Text = "20";
            this.checkBox20ft.UseVisualStyleBackColor = true;
            this.checkBox20ft.Click += new System.EventHandler(this.checkBox20ft_Click);
            // 
            // checkBox18ft
            // 
            this.checkBox18ft.AutoSize = true;
            this.checkBox18ft.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox18ft.Location = new System.Drawing.Point(3, 227);
            this.checkBox18ft.Name = "checkBox18ft";
            this.checkBox18ft.Size = new System.Drawing.Size(47, 22);
            this.checkBox18ft.TabIndex = 42;
            this.checkBox18ft.Text = "18";
            this.checkBox18ft.UseVisualStyleBackColor = true;
            this.checkBox18ft.Click += new System.EventHandler(this.checkBox18ft_Click);
            // 
            // checkBox16ft
            // 
            this.checkBox16ft.AutoSize = true;
            this.checkBox16ft.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox16ft.Location = new System.Drawing.Point(3, 195);
            this.checkBox16ft.Name = "checkBox16ft";
            this.checkBox16ft.Size = new System.Drawing.Size(47, 22);
            this.checkBox16ft.TabIndex = 41;
            this.checkBox16ft.Text = "16";
            this.checkBox16ft.UseVisualStyleBackColor = true;
            this.checkBox16ft.Click += new System.EventHandler(this.checkBox16ft_Click);
            // 
            // checkBox14ft
            // 
            this.checkBox14ft.AutoSize = true;
            this.checkBox14ft.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox14ft.Location = new System.Drawing.Point(3, 163);
            this.checkBox14ft.Name = "checkBox14ft";
            this.checkBox14ft.Size = new System.Drawing.Size(47, 22);
            this.checkBox14ft.TabIndex = 40;
            this.checkBox14ft.Text = "14";
            this.checkBox14ft.UseVisualStyleBackColor = true;
            this.checkBox14ft.Click += new System.EventHandler(this.checkBox14ft_Click);
            // 
            // checkBox12ft
            // 
            this.checkBox12ft.AutoSize = true;
            this.checkBox12ft.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox12ft.Location = new System.Drawing.Point(3, 131);
            this.checkBox12ft.Name = "checkBox12ft";
            this.checkBox12ft.Size = new System.Drawing.Size(47, 22);
            this.checkBox12ft.TabIndex = 39;
            this.checkBox12ft.Text = "12";
            this.checkBox12ft.UseVisualStyleBackColor = true;
            this.checkBox12ft.Click += new System.EventHandler(this.checkBox12ft_Click);
            // 
            // checkBox10ft
            // 
            this.checkBox10ft.AutoSize = true;
            this.checkBox10ft.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox10ft.Location = new System.Drawing.Point(3, 99);
            this.checkBox10ft.Name = "checkBox10ft";
            this.checkBox10ft.Size = new System.Drawing.Size(47, 22);
            this.checkBox10ft.TabIndex = 38;
            this.checkBox10ft.Text = "10";
            this.checkBox10ft.UseVisualStyleBackColor = true;
            this.checkBox10ft.Click += new System.EventHandler(this.checkBox10ft_Click);
            // 
            // checkBox8ft
            // 
            this.checkBox8ft.AutoSize = true;
            this.checkBox8ft.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox8ft.Location = new System.Drawing.Point(3, 67);
            this.checkBox8ft.Name = "checkBox8ft";
            this.checkBox8ft.Size = new System.Drawing.Size(37, 22);
            this.checkBox8ft.TabIndex = 37;
            this.checkBox8ft.Text = "8";
            this.checkBox8ft.UseVisualStyleBackColor = true;
            this.checkBox8ft.Click += new System.EventHandler(this.checkBox8ft_Click);
            // 
            // checkBox6ft
            // 
            this.checkBox6ft.AutoSize = true;
            this.checkBox6ft.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6ft.Location = new System.Drawing.Point(3, 35);
            this.checkBox6ft.Name = "checkBox6ft";
            this.checkBox6ft.Size = new System.Drawing.Size(37, 22);
            this.checkBox6ft.TabIndex = 36;
            this.checkBox6ft.Text = "6";
            this.checkBox6ft.UseVisualStyleBackColor = true;
            this.checkBox6ft.Click += new System.EventHandler(this.checkBox6ft_Click);
            // 
            // lumberUnitsLabel
            // 
            this.lumberUnitsLabel.AutoSize = true;
            this.lumberUnitsLabel.BackColor = System.Drawing.Color.Transparent;
            this.lumberUnitsLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lumberUnitsLabel.Location = new System.Drawing.Point(84, 10);
            this.lumberUnitsLabel.Name = "lumberUnitsLabel";
            this.lumberUnitsLabel.Size = new System.Drawing.Size(52, 18);
            this.lumberUnitsLabel.TabIndex = 35;
            this.lumberUnitsLabel.Text = "Units";
            // 
            // pricePerSheetLabel
            // 
            this.pricePerSheetLabel.AutoSize = true;
            this.pricePerSheetLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pricePerSheetLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricePerSheetLabel.Location = new System.Drawing.Point(70, 6);
            this.pricePerSheetLabel.Name = "pricePerSheetLabel";
            this.pricePerSheetLabel.Size = new System.Drawing.Size(139, 18);
            this.pricePerSheetLabel.TabIndex = 37;
            this.pricePerSheetLabel.Text = "Cost Per Sheet";
            // 
            // pricePerSheetComboBox
            // 
            this.pricePerSheetComboBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricePerSheetComboBox.FormattingEnabled = true;
            this.pricePerSheetComboBox.Location = new System.Drawing.Point(91, 29);
            this.pricePerSheetComboBox.Name = "pricePerSheetComboBox";
            this.pricePerSheetComboBox.Size = new System.Drawing.Size(85, 26);
            this.pricePerSheetComboBox.TabIndex = 38;
            // 
            // resultPricePerThousandPlywood
            // 
            this.resultPricePerThousandPlywood.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultPricePerThousandPlywood.Location = new System.Drawing.Point(109, 66);
            this.resultPricePerThousandPlywood.Name = "resultPricePerThousandPlywood";
            this.resultPricePerThousandPlywood.Size = new System.Drawing.Size(100, 27);
            this.resultPricePerThousandPlywood.TabIndex = 40;
            this.resultPricePerThousandPlywood.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calculatePricePerThousandSheetButton
            // 
            this.calculatePricePerThousandSheetButton.BackColor = System.Drawing.SystemColors.Control;
            this.calculatePricePerThousandSheetButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatePricePerThousandSheetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.calculatePricePerThousandSheetButton.Location = new System.Drawing.Point(3, 66);
            this.calculatePricePerThousandSheetButton.Name = "calculatePricePerThousandSheetButton";
            this.calculatePricePerThousandSheetButton.Size = new System.Drawing.Size(103, 29);
            this.calculatePricePerThousandSheetButton.TabIndex = 39;
            this.calculatePricePerThousandSheetButton.Text = "Calculate";
            this.calculatePricePerThousandSheetButton.UseVisualStyleBackColor = false;
            this.calculatePricePerThousandSheetButton.Click += new System.EventHandler(this.calculatePricePerThousandSheetButton_Click);
            // 
            // costPerPiecelabel
            // 
            this.costPerPiecelabel.AutoSize = true;
            this.costPerPiecelabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.costPerPiecelabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costPerPiecelabel.Location = new System.Drawing.Point(17, 4);
            this.costPerPiecelabel.Name = "costPerPiecelabel";
            this.costPerPiecelabel.Size = new System.Drawing.Size(135, 18);
            this.costPerPiecelabel.TabIndex = 42;
            this.costPerPiecelabel.Text = "Cost Per Piece";
            // 
            // lumberCostDimensionsComboBox
            // 
            this.lumberCostDimensionsComboBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lumberCostDimensionsComboBox.FormattingEnabled = true;
            this.lumberCostDimensionsComboBox.Items.AddRange(new object[] {
            "1x4",
            "1x6",
            "2x4",
            "2x6",
            "2x8",
            "2x10",
            "2x12",
            "3x6",
            "4x4",
            "4x6"});
            this.lumberCostDimensionsComboBox.Location = new System.Drawing.Point(95, 81);
            this.lumberCostDimensionsComboBox.Name = "lumberCostDimensionsComboBox";
            this.lumberCostDimensionsComboBox.Size = new System.Drawing.Size(85, 26);
            this.lumberCostDimensionsComboBox.TabIndex = 43;
            // 
            // costPerPieceDimensionLabel
            // 
            this.costPerPieceDimensionLabel.AutoSize = true;
            this.costPerPieceDimensionLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.costPerPieceDimensionLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costPerPieceDimensionLabel.Location = new System.Drawing.Point(46, 60);
            this.costPerPieceDimensionLabel.Name = "costPerPieceDimensionLabel";
            this.costPerPieceDimensionLabel.Size = new System.Drawing.Size(179, 18);
            this.costPerPieceDimensionLabel.TabIndex = 44;
            this.costPerPieceDimensionLabel.Text = "Lumber Dimensions";
            // 
            // lengthCostLabel
            // 
            this.lengthCostLabel.AutoSize = true;
            this.lengthCostLabel.BackColor = System.Drawing.Color.Transparent;
            this.lengthCostLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthCostLabel.Location = new System.Drawing.Point(179, 4);
            this.lengthCostLabel.Name = "lengthCostLabel";
            this.lengthCostLabel.Size = new System.Drawing.Size(69, 18);
            this.lengthCostLabel.TabIndex = 46;
            this.lengthCostLabel.Text = "Length";
            // 
            // lumberLengthCostComboBox
            // 
            this.lumberLengthCostComboBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lumberLengthCostComboBox.FormattingEnabled = true;
            this.lumberLengthCostComboBox.Items.AddRange(new object[] {
            "6",
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20"});
            this.lumberLengthCostComboBox.Location = new System.Drawing.Point(182, 25);
            this.lumberLengthCostComboBox.Name = "lumberLengthCostComboBox";
            this.lumberLengthCostComboBox.Size = new System.Drawing.Size(61, 26);
            this.lumberLengthCostComboBox.TabIndex = 45;
            // 
            // pricePerPieceComboBox
            // 
            this.pricePerPieceComboBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricePerPieceComboBox.FormattingEnabled = true;
            this.pricePerPieceComboBox.Location = new System.Drawing.Point(33, 25);
            this.pricePerPieceComboBox.Name = "pricePerPieceComboBox";
            this.pricePerPieceComboBox.Size = new System.Drawing.Size(85, 26);
            this.pricePerPieceComboBox.TabIndex = 47;
            // 
            // resultPricePerThousandLumber
            // 
            this.resultPricePerThousandLumber.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultPricePerThousandLumber.Location = new System.Drawing.Point(112, 128);
            this.resultPricePerThousandLumber.Name = "resultPricePerThousandLumber";
            this.resultPricePerThousandLumber.Size = new System.Drawing.Size(100, 27);
            this.resultPricePerThousandLumber.TabIndex = 49;
            this.resultPricePerThousandLumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calculateCostPerThousandPieceButton
            // 
            this.calculateCostPerThousandPieceButton.BackColor = System.Drawing.SystemColors.Control;
            this.calculateCostPerThousandPieceButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateCostPerThousandPieceButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.calculateCostPerThousandPieceButton.Location = new System.Drawing.Point(3, 128);
            this.calculateCostPerThousandPieceButton.Name = "calculateCostPerThousandPieceButton";
            this.calculateCostPerThousandPieceButton.Size = new System.Drawing.Size(103, 29);
            this.calculateCostPerThousandPieceButton.TabIndex = 48;
            this.calculateCostPerThousandPieceButton.Text = "Calculate";
            this.calculateCostPerThousandPieceButton.UseVisualStyleBackColor = false;
            this.calculateCostPerThousandPieceButton.Click += new System.EventHandler(this.calculateCostPerThousandPieceButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(218, 134);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(41, 27);
            this.textBox1.TabIndex = 50;
            this.textBox1.Text = "sqft";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(218, 426);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(41, 27);
            this.textBox2.TabIndex = 51;
            this.textBox2.Text = "bdft";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(218, 128);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(33, 27);
            this.textBox3.TabIndex = 52;
            this.textBox3.Text = "/m";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(215, 66);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(33, 27);
            this.textBox4.TabIndex = 53;
            this.textBox4.Text = "/m";
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.notesLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesLabel.Location = new System.Drawing.Point(3, 160);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(59, 18);
            this.notesLabel.TabIndex = 77;
            this.notesLabel.Text = "Notes";
            // 
            // notesTextBox
            // 
            this.notesTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesTextBox.Location = new System.Drawing.Point(115, 157);
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(458, 27);
            this.notesTextBox.TabIndex = 76;
            this.notesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.descriptionLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(3, 127);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(106, 18);
            this.descriptionLabel.TabIndex = 75;
            this.descriptionLabel.Text = "Description";
            // 
            // descripionTextBox
            // 
            this.descripionTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripionTextBox.Location = new System.Drawing.Point(115, 124);
            this.descripionTextBox.Name = "descripionTextBox";
            this.descripionTextBox.Size = new System.Drawing.Size(458, 27);
            this.descripionTextBox.TabIndex = 74;
            this.descripionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 73;
            this.label1.Text = "Part #";
            // 
            // partNumberResultTextBox
            // 
            this.partNumberResultTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partNumberResultTextBox.Location = new System.Drawing.Point(115, 91);
            this.partNumberResultTextBox.Name = "partNumberResultTextBox";
            this.partNumberResultTextBox.Size = new System.Drawing.Size(141, 27);
            this.partNumberResultTextBox.TabIndex = 72;
            this.partNumberResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.SystemColors.Control;
            this.searchButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.searchButton.Location = new System.Drawing.Point(377, 26);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(103, 29);
            this.searchButton.TabIndex = 71;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // plywoodSizeSearchComboBox
            // 
            this.plywoodSizeSearchComboBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plywoodSizeSearchComboBox.FormattingEnabled = true;
            this.plywoodSizeSearchComboBox.Items.AddRange(new object[] {
            "1/4",
            "1/2",
            "3/4",
            "3/8",
            "1 1/8",
            "1 x 2",
            "1 x 3",
            "1 x 4",
            "1 x 6",
            "1 x 8",
            "1 x 10",
            "1 x 12",
            "2 x 4",
            "2 x 6",
            "2 x 8",
            "2 x 10",
            "2 x 12",
            "3 x 4",
            "4 x 4",
            "4 x 6",
            "4 x 8",
            "4 x 10",
            "4 x 12"});
            this.plywoodSizeSearchComboBox.Location = new System.Drawing.Point(41, 28);
            this.plywoodSizeSearchComboBox.Name = "plywoodSizeSearchComboBox";
            this.plywoodSizeSearchComboBox.Size = new System.Drawing.Size(85, 26);
            this.plywoodSizeSearchComboBox.TabIndex = 70;
            // 
            // PlywoodSizeSearchLabel
            // 
            this.PlywoodSizeSearchLabel.AutoSize = true;
            this.PlywoodSizeSearchLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PlywoodSizeSearchLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlywoodSizeSearchLabel.Location = new System.Drawing.Point(16, 6);
            this.PlywoodSizeSearchLabel.Name = "PlywoodSizeSearchLabel";
            this.PlywoodSizeSearchLabel.Size = new System.Drawing.Size(145, 18);
            this.PlywoodSizeSearchLabel.TabIndex = 69;
            this.PlywoodSizeSearchLabel.Text = "Size/Dimension";
            // 
            // transpakFacilitiesSearch
            // 
            this.transpakFacilitiesSearch.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transpakFacilitiesSearch.FormattingEnabled = true;
            this.transpakFacilitiesSearch.Items.AddRange(new object[] {
            "Austin, TX",
            "San Jose, CA",
            "Tualatin, OR",
            "Memphis, TN",
            "Houston, TX",
            "Houston-Sheldon, TX",
            "Laredo, TX",
            "Robertsdale, AL",
            "Korea",
            "Guadalajara",
            "Los Angeles, CA",
            "San Diego, CA"});
            this.transpakFacilitiesSearch.Location = new System.Drawing.Point(177, 28);
            this.transpakFacilitiesSearch.Name = "transpakFacilitiesSearch";
            this.transpakFacilitiesSearch.Size = new System.Drawing.Size(176, 26);
            this.transpakFacilitiesSearch.TabIndex = 68;
            // 
            // locationsLabel
            // 
            this.locationsLabel.AutoSize = true;
            this.locationsLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.locationsLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationsLabel.Location = new System.Drawing.Point(215, 6);
            this.locationsLabel.Name = "locationsLabel";
            this.locationsLabel.Size = new System.Drawing.Size(91, 18);
            this.locationsLabel.TabIndex = 67;
            this.locationsLabel.Text = "Locations";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TransPak.Properties.Resources.Untitled;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(873, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 82);
            this.pictureBox1.TabIndex = 78;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lumberDimensionsLabel);
            this.panel2.Controls.Add(this.countLabel);
            this.panel2.Controls.Add(this.countDropBox);
            this.panel2.Controls.Add(this.lumberDimensionsDropBox);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.lumberResultTextBox);
            this.panel2.Controls.Add(this.calculateLumberButton);
            this.panel2.Location = new System.Drawing.Point(3, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(263, 455);
            this.panel2.TabIndex = 79;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.plywoodDimensionsLabel);
            this.panel3.Controls.Add(this.plywoodDimensionsDropBox);
            this.panel3.Controls.Add(this.unitsLabel);
            this.panel3.Controls.Add(this.unitsDropBox);
            this.panel3.Controls.Add(this.calculatePlywoodButton);
            this.panel3.Controls.Add(this.plywoodResultTextBox);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Location = new System.Drawing.Point(562, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(266, 163);
            this.panel3.TabIndex = 80;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.altNotesTextBox);
            this.panel4.Controls.Add(this.altNotesLabel);
            this.panel4.Controls.Add(this.altPartNumberTextBox);
            this.panel4.Controls.Add(this.altDescriptionTextBox);
            this.panel4.Controls.Add(this.altDescriptionLabel);
            this.panel4.Controls.Add(this.altPartNumberLabel);
            this.panel4.Controls.Add(this.PlywoodSizeSearchLabel);
            this.panel4.Controls.Add(this.plywoodSizeSearchComboBox);
            this.panel4.Controls.Add(this.locationsLabel);
            this.panel4.Controls.Add(this.transpakFacilitiesSearch);
            this.panel4.Controls.Add(this.notesTextBox);
            this.panel4.Controls.Add(this.notesLabel);
            this.panel4.Controls.Add(this.searchButton);
            this.panel4.Controls.Add(this.partNumberResultTextBox);
            this.panel4.Controls.Add(this.descripionTextBox);
            this.panel4.Controls.Add(this.descriptionLabel);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(529, 253);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(581, 314);
            this.panel4.TabIndex = 81;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.costPerPiecelabel);
            this.panel5.Controls.Add(this.pricePerPieceComboBox);
            this.panel5.Controls.Add(this.lengthCostLabel);
            this.panel5.Controls.Add(this.lumberLengthCostComboBox);
            this.panel5.Controls.Add(this.costPerPieceDimensionLabel);
            this.panel5.Controls.Add(this.lumberCostDimensionsComboBox);
            this.panel5.Controls.Add(this.textBox3);
            this.panel5.Controls.Add(this.calculateCostPerThousandPieceButton);
            this.panel5.Controls.Add(this.resultPricePerThousandLumber);
            this.panel5.Location = new System.Drawing.Point(281, 9);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(266, 160);
            this.panel5.TabIndex = 82;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.pricePerSheetLabel);
            this.panel6.Controls.Add(this.pricePerSheetComboBox);
            this.panel6.Controls.Add(this.calculatePricePerThousandSheetButton);
            this.panel6.Controls.Add(this.resultPricePerThousandPlywood);
            this.panel6.Controls.Add(this.textBox4);
            this.panel6.Location = new System.Drawing.Point(844, 9);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(266, 108);
            this.panel6.TabIndex = 51;
            // 
            // altNotesTextBox
            // 
            this.altNotesTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altNotesTextBox.Location = new System.Drawing.Point(115, 265);
            this.altNotesTextBox.Name = "altNotesTextBox";
            this.altNotesTextBox.Size = new System.Drawing.Size(458, 27);
            this.altNotesTextBox.TabIndex = 82;
            this.altNotesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // altNotesLabel
            // 
            this.altNotesLabel.AutoSize = true;
            this.altNotesLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.altNotesLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altNotesLabel.Location = new System.Drawing.Point(3, 268);
            this.altNotesLabel.Name = "altNotesLabel";
            this.altNotesLabel.Size = new System.Drawing.Size(59, 18);
            this.altNotesLabel.TabIndex = 83;
            this.altNotesLabel.Text = "Notes";
            // 
            // altPartNumberTextBox
            // 
            this.altPartNumberTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altPartNumberTextBox.Location = new System.Drawing.Point(115, 199);
            this.altPartNumberTextBox.Name = "altPartNumberTextBox";
            this.altPartNumberTextBox.Size = new System.Drawing.Size(141, 27);
            this.altPartNumberTextBox.TabIndex = 78;
            this.altPartNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // altDescriptionTextBox
            // 
            this.altDescriptionTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altDescriptionTextBox.Location = new System.Drawing.Point(115, 232);
            this.altDescriptionTextBox.Name = "altDescriptionTextBox";
            this.altDescriptionTextBox.Size = new System.Drawing.Size(458, 27);
            this.altDescriptionTextBox.TabIndex = 80;
            this.altDescriptionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // altDescriptionLabel
            // 
            this.altDescriptionLabel.AutoSize = true;
            this.altDescriptionLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.altDescriptionLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altDescriptionLabel.Location = new System.Drawing.Point(3, 235);
            this.altDescriptionLabel.Name = "altDescriptionLabel";
            this.altDescriptionLabel.Size = new System.Drawing.Size(106, 18);
            this.altDescriptionLabel.TabIndex = 81;
            this.altDescriptionLabel.Text = "Description";
            // 
            // altPartNumberLabel
            // 
            this.altPartNumberLabel.AutoSize = true;
            this.altPartNumberLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.altPartNumberLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altPartNumberLabel.Location = new System.Drawing.Point(3, 202);
            this.altPartNumberLabel.Name = "altPartNumberLabel";
            this.altPartNumberLabel.Size = new System.Drawing.Size(92, 18);
            this.altPartNumberLabel.TabIndex = 79;
            this.altPartNumberLabel.Text = "Alt Part #";
            // 
            // LumberCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1126, 600);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LumberCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transpak Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox lumberDimensionsDropBox;
        private System.Windows.Forms.Label lumberDimensionsLabel;
        private System.Windows.Forms.ComboBox countDropBox;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.ComboBox comboBox6ft;
        private System.Windows.Forms.ComboBox comboBox16ft;
        private System.Windows.Forms.ComboBox comboBox14ft;
        private System.Windows.Forms.ComboBox comboBox12ft;
        private System.Windows.Forms.ComboBox comboBox10ft;
        private System.Windows.Forms.ComboBox comboBox8ft;
        private System.Windows.Forms.ComboBox comboBox20ft;
        private System.Windows.Forms.ComboBox comboBox18ft;
        private System.Windows.Forms.Button calculateLumberButton;
        private System.Windows.Forms.ComboBox plywoodDimensionsDropBox;
        private System.Windows.Forms.Label plywoodDimensionsLabel;
        private System.Windows.Forms.Label unitsLabel;
        private System.Windows.Forms.ComboBox unitsDropBox;
        private System.Windows.Forms.Button calculatePlywoodButton;
        private System.Windows.Forms.TextBox plywoodResultTextBox;
        private System.Windows.Forms.TextBox lumberResultTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lumberUnitsLabel;
        private System.Windows.Forms.CheckBox checkBox6ft;
        private System.Windows.Forms.CheckBox checkBox20ft;
        private System.Windows.Forms.CheckBox checkBox18ft;
        private System.Windows.Forms.CheckBox checkBox16ft;
        private System.Windows.Forms.CheckBox checkBox14ft;
        private System.Windows.Forms.CheckBox checkBox12ft;
        private System.Windows.Forms.CheckBox checkBox10ft;
        private System.Windows.Forms.CheckBox checkBox8ft;
        private Label pricePerSheetLabel;
        private ComboBox pricePerSheetComboBox;
        private TextBox resultPricePerThousandPlywood;
        private Button calculatePricePerThousandSheetButton;
        private Label costPerPiecelabel;
        private ComboBox lumberCostDimensionsComboBox;
        private Label costPerPieceDimensionLabel;
        private Label lengthCostLabel;
        private ComboBox lumberLengthCostComboBox;
        private ComboBox pricePerPieceComboBox;
        private TextBox resultPricePerThousandLumber;
        private Button calculateCostPerThousandPieceButton;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label notesLabel;
        private TextBox notesTextBox;
        private Label descriptionLabel;
        private TextBox descripionTextBox;
        private Label label1;
        private TextBox partNumberResultTextBox;
        private Button searchButton;
        private ComboBox plywoodSizeSearchComboBox;
        private Label PlywoodSizeSearchLabel;
        private ComboBox transpakFacilitiesSearch;
        private Label locationsLabel;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private TextBox altNotesTextBox;
        private Label altNotesLabel;
        private TextBox altPartNumberTextBox;
        private TextBox altDescriptionTextBox;
        private Label altDescriptionLabel;
        private Label altPartNumberLabel;
    }
}

