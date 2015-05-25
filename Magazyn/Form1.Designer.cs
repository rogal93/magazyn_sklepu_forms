namespace Magazyn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listaDziałów = new System.Windows.Forms.CheckedListBox();
            this.WszystkieCheckBox = new System.Windows.Forms.CheckBox();
            this.grupaWyświetlania = new System.Windows.Forms.GroupBox();
            this.wyświetlButton = new System.Windows.Forms.Button();
            this.grupaDodawania = new System.Windows.Forms.GroupBox();
            this.dodajButton = new System.Windows.Forms.Button();
            this.labelPojemność = new System.Windows.Forms.Label();
            this.pojemnośćNumeric = new System.Windows.Forms.NumericUpDown();
            this.ilośćLabel = new System.Windows.Forms.Label();
            this.ilośćNumeric = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.DziałBox = new System.Windows.Forms.ComboBox();
            this.dataWażnościPicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cenaLabel = new System.Windows.Forms.Label();
            this.dataProdukcjiPicker = new System.Windows.Forms.DateTimePicker();
            this.cenaNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nazwaTextBox = new System.Windows.Forms.TextBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.poNazwieButton = new System.Windows.Forms.Button();
            this.nazwaWyszukajTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.przedziałNumeric2 = new System.Windows.Forms.NumericUpDown();
            this.przedziałNumeric1 = new System.Windows.Forms.NumericUpDown();
            this.poCenieButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.usuńButton = new System.Windows.Forms.Button();
            this.nazwaUsuńTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.kgLabel = new System.Windows.Forms.Label();
            this.grupaWyświetlania.SuspendLayout();
            this.grupaDodawania.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pojemnośćNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilośćNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cenaNumeric)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.przedziałNumeric2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przedziałNumeric1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaDziałów
            // 
            this.listaDziałów.CheckOnClick = true;
            this.listaDziałów.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.listaDziałów.FormattingEnabled = true;
            this.listaDziałów.Items.AddRange(new object[] {
            "Nabiał",
            "Mięso",
            "Słodycze",
            "Produkty zbożowe",
            "Napoje",
            "Owoce",
            "Warzywa",
            "Przyprawy"});
            this.listaDziałów.Location = new System.Drawing.Point(6, 19);
            this.listaDziałów.MultiColumn = true;
            this.listaDziałów.Name = "listaDziałów";
            this.listaDziałów.Size = new System.Drawing.Size(139, 124);
            this.listaDziałów.TabIndex = 1;
            // 
            // WszystkieCheckBox
            // 
            this.WszystkieCheckBox.AutoSize = true;
            this.WszystkieCheckBox.Location = new System.Drawing.Point(31, 149);
            this.WszystkieCheckBox.Name = "WszystkieCheckBox";
            this.WszystkieCheckBox.Size = new System.Drawing.Size(83, 17);
            this.WszystkieCheckBox.TabIndex = 2;
            this.WszystkieCheckBox.Text = "Wszystkie";
            this.WszystkieCheckBox.UseVisualStyleBackColor = true;
            this.WszystkieCheckBox.CheckedChanged += new System.EventHandler(this.WszystkieCheckBox_CheckedChanged);
            // 
            // grupaWyświetlania
            // 
            this.grupaWyświetlania.BackColor = System.Drawing.Color.Gainsboro;
            this.grupaWyświetlania.Controls.Add(this.wyświetlButton);
            this.grupaWyświetlania.Controls.Add(this.listaDziałów);
            this.grupaWyświetlania.Controls.Add(this.WszystkieCheckBox);
            this.grupaWyświetlania.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grupaWyświetlania.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.grupaWyświetlania.Location = new System.Drawing.Point(411, 424);
            this.grupaWyświetlania.Name = "grupaWyświetlania";
            this.grupaWyświetlania.Size = new System.Drawing.Size(151, 213);
            this.grupaWyświetlania.TabIndex = 3;
            this.grupaWyświetlania.TabStop = false;
            this.grupaWyświetlania.Text = "Wyświetlanie";
            // 
            // wyświetlButton
            // 
            this.wyświetlButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wyświetlButton.Location = new System.Drawing.Point(17, 172);
            this.wyświetlButton.Name = "wyświetlButton";
            this.wyświetlButton.Size = new System.Drawing.Size(109, 35);
            this.wyświetlButton.TabIndex = 4;
            this.wyświetlButton.Text = "Wyświetl";
            this.wyświetlButton.UseVisualStyleBackColor = true;
            this.wyświetlButton.Click += new System.EventHandler(this.wyświetlButton_Click);
            // 
            // grupaDodawania
            // 
            this.grupaDodawania.BackColor = System.Drawing.Color.Gainsboro;
            this.grupaDodawania.Controls.Add(this.kgLabel);
            this.grupaDodawania.Controls.Add(this.dodajButton);
            this.grupaDodawania.Controls.Add(this.labelPojemność);
            this.grupaDodawania.Controls.Add(this.pojemnośćNumeric);
            this.grupaDodawania.Controls.Add(this.ilośćLabel);
            this.grupaDodawania.Controls.Add(this.ilośćNumeric);
            this.grupaDodawania.Controls.Add(this.label5);
            this.grupaDodawania.Controls.Add(this.DziałBox);
            this.grupaDodawania.Controls.Add(this.dataWażnościPicker);
            this.grupaDodawania.Controls.Add(this.label4);
            this.grupaDodawania.Controls.Add(this.label3);
            this.grupaDodawania.Controls.Add(this.cenaLabel);
            this.grupaDodawania.Controls.Add(this.dataProdukcjiPicker);
            this.grupaDodawania.Controls.Add(this.cenaNumeric);
            this.grupaDodawania.Controls.Add(this.label1);
            this.grupaDodawania.Controls.Add(this.nazwaTextBox);
            this.grupaDodawania.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grupaDodawania.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.grupaDodawania.Location = new System.Drawing.Point(24, 79);
            this.grupaDodawania.Name = "grupaDodawania";
            this.grupaDodawania.Size = new System.Drawing.Size(229, 293);
            this.grupaDodawania.TabIndex = 4;
            this.grupaDodawania.TabStop = false;
            this.grupaDodawania.Text = "Dodawanie produktów";
            // 
            // dodajButton
            // 
            this.dodajButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodajButton.Location = new System.Drawing.Point(63, 249);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(109, 30);
            this.dodajButton.TabIndex = 5;
            this.dodajButton.Text = "Dodaj";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // labelPojemność
            // 
            this.labelPojemność.AutoSize = true;
            this.labelPojemność.Location = new System.Drawing.Point(16, 220);
            this.labelPojemność.Name = "labelPojemność";
            this.labelPojemność.Size = new System.Drawing.Size(72, 26);
            this.labelPojemność.TabIndex = 14;
            this.labelPojemność.Text = "Pojemność \r\n      [litr]";
            this.labelPojemność.Visible = false;
            // 
            // pojemnośćNumeric
            // 
            this.pojemnośćNumeric.DecimalPlaces = 2;
            this.pojemnośćNumeric.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.pojemnośćNumeric.Location = new System.Drawing.Point(84, 220);
            this.pojemnośćNumeric.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.pojemnośćNumeric.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.pojemnośćNumeric.Name = "pojemnośćNumeric";
            this.pojemnośćNumeric.Size = new System.Drawing.Size(56, 20);
            this.pojemnośćNumeric.TabIndex = 13;
            this.pojemnośćNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pojemnośćNumeric.Visible = false;
            // 
            // ilośćLabel
            // 
            this.ilośćLabel.AutoSize = true;
            this.ilośćLabel.Location = new System.Drawing.Point(49, 194);
            this.ilośćLabel.Name = "ilośćLabel";
            this.ilośćLabel.Size = new System.Drawing.Size(34, 13);
            this.ilośćLabel.TabIndex = 11;
            this.ilośćLabel.Text = "Ilość";
            // 
            // ilośćNumeric
            // 
            this.ilośćNumeric.Location = new System.Drawing.Point(84, 192);
            this.ilośćNumeric.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.ilośćNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ilośćNumeric.Name = "ilośćNumeric";
            this.ilośćNumeric.Size = new System.Drawing.Size(56, 20);
            this.ilośćNumeric.TabIndex = 10;
            this.ilośćNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Dział";
            // 
            // DziałBox
            // 
            this.DziałBox.FormattingEnabled = true;
            this.DziałBox.Items.AddRange(new object[] {
            "Nabiał",
            "Mięso",
            "Słodycze",
            "Produkty zbożowe",
            "Napoje",
            "Owoce",
            "Warzywa",
            "Przyprawy"});
            this.DziałBox.Location = new System.Drawing.Point(84, 54);
            this.DziałBox.Name = "DziałBox";
            this.DziałBox.Size = new System.Drawing.Size(121, 21);
            this.DziałBox.TabIndex = 8;
            this.DziałBox.SelectedIndexChanged += new System.EventHandler(this.DziałBox_SelectedIndexChanged);
            // 
            // dataWażnościPicker
            // 
            this.dataWażnościPicker.Location = new System.Drawing.Point(14, 166);
            this.dataWażnościPicker.Name = "dataWażnościPicker";
            this.dataWażnościPicker.Size = new System.Drawing.Size(200, 20);
            this.dataWażnościPicker.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data ważności";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data produkcji";
            // 
            // cenaLabel
            // 
            this.cenaLabel.AutoSize = true;
            this.cenaLabel.Location = new System.Drawing.Point(24, 83);
            this.cenaLabel.Name = "cenaLabel";
            this.cenaLabel.Size = new System.Drawing.Size(59, 13);
            this.cenaLabel.TabIndex = 4;
            this.cenaLabel.Text = "Cena [zł]";
            // 
            // dataProdukcjiPicker
            // 
            this.dataProdukcjiPicker.Location = new System.Drawing.Point(14, 123);
            this.dataProdukcjiPicker.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dataProdukcjiPicker.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dataProdukcjiPicker.Name = "dataProdukcjiPicker";
            this.dataProdukcjiPicker.Size = new System.Drawing.Size(200, 20);
            this.dataProdukcjiPicker.TabIndex = 3;
            this.dataProdukcjiPicker.ValueChanged += new System.EventHandler(this.dataProdukcjiPicker_ValueChanged);
            // 
            // cenaNumeric
            // 
            this.cenaNumeric.DecimalPlaces = 2;
            this.cenaNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.cenaNumeric.Location = new System.Drawing.Point(84, 81);
            this.cenaNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.cenaNumeric.Name = "cenaNumeric";
            this.cenaNumeric.Size = new System.Drawing.Size(66, 20);
            this.cenaNumeric.TabIndex = 2;
            this.cenaNumeric.Tag = "";
            this.cenaNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nazwa";
            // 
            // nazwaTextBox
            // 
            this.nazwaTextBox.Location = new System.Drawing.Point(84, 28);
            this.nazwaTextBox.Name = "nazwaTextBox";
            this.nazwaTextBox.Size = new System.Drawing.Size(100, 20);
            this.nazwaTextBox.TabIndex = 0;
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.White;
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox.Location = new System.Drawing.Point(340, 59);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(297, 333);
            this.textBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.poNazwieButton);
            this.groupBox1.Controls.Add(this.nazwaWyszukajTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(724, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 90);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wyszukiwanie po nazwie";
            // 
            // poNazwieButton
            // 
            this.poNazwieButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.poNazwieButton.Location = new System.Drawing.Point(26, 51);
            this.poNazwieButton.Name = "poNazwieButton";
            this.poNazwieButton.Size = new System.Drawing.Size(109, 30);
            this.poNazwieButton.TabIndex = 15;
            this.poNazwieButton.Text = "Wyszukaj";
            this.poNazwieButton.UseVisualStyleBackColor = true;
            this.poNazwieButton.Click += new System.EventHandler(this.poNazwieButton_Click);
            // 
            // nazwaWyszukajTextBox
            // 
            this.nazwaWyszukajTextBox.Location = new System.Drawing.Point(52, 23);
            this.nazwaWyszukajTextBox.Name = "nazwaWyszukajTextBox";
            this.nazwaWyszukajTextBox.Size = new System.Drawing.Size(100, 20);
            this.nazwaWyszukajTextBox.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nazwa";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.przedziałNumeric2);
            this.groupBox2.Controls.Add(this.przedziałNumeric1);
            this.groupBox2.Controls.Add(this.poCenieButton);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(724, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 95);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wyszukiwanie po cenie";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Przedział cenowy";
            // 
            // przedziałNumeric2
            // 
            this.przedziałNumeric2.DecimalPlaces = 2;
            this.przedziałNumeric2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.przedziałNumeric2.Location = new System.Drawing.Point(94, 32);
            this.przedziałNumeric2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.przedziałNumeric2.Name = "przedziałNumeric2";
            this.przedziałNumeric2.Size = new System.Drawing.Size(58, 20);
            this.przedziałNumeric2.TabIndex = 16;
            this.przedziałNumeric2.Tag = "";
            this.przedziałNumeric2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // przedziałNumeric1
            // 
            this.przedziałNumeric1.DecimalPlaces = 2;
            this.przedziałNumeric1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.przedziałNumeric1.Location = new System.Drawing.Point(9, 32);
            this.przedziałNumeric1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.przedziałNumeric1.Name = "przedziałNumeric1";
            this.przedziałNumeric1.Size = new System.Drawing.Size(58, 20);
            this.przedziałNumeric1.TabIndex = 15;
            this.przedziałNumeric1.Tag = "";
            this.przedziałNumeric1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // poCenieButton
            // 
            this.poCenieButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.poCenieButton.Location = new System.Drawing.Point(26, 59);
            this.poCenieButton.Name = "poCenieButton";
            this.poCenieButton.Size = new System.Drawing.Size(109, 30);
            this.poCenieButton.TabIndex = 15;
            this.poCenieButton.Text = "Wyszukaj";
            this.poCenieButton.UseVisualStyleBackColor = true;
            this.poCenieButton.Click += new System.EventHandler(this.poCenieButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox3.Controls.Add(this.usuńButton);
            this.groupBox3.Controls.Add(this.nazwaUsuńTextBox);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox3.Location = new System.Drawing.Point(724, 307);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(163, 85);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Usuwanie produktu";
            // 
            // usuńButton
            // 
            this.usuńButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usuńButton.Location = new System.Drawing.Point(26, 49);
            this.usuńButton.Name = "usuńButton";
            this.usuńButton.Size = new System.Drawing.Size(109, 30);
            this.usuńButton.TabIndex = 15;
            this.usuńButton.Text = "Usuń";
            this.usuńButton.UseVisualStyleBackColor = true;
            this.usuńButton.Click += new System.EventHandler(this.usuńButton_Click);
            // 
            // nazwaUsuńTextBox
            // 
            this.nazwaUsuńTextBox.Location = new System.Drawing.Point(52, 23);
            this.nazwaUsuńTextBox.Name = "nazwaUsuńTextBox";
            this.nazwaUsuńTextBox.Size = new System.Drawing.Size(100, 20);
            this.nazwaUsuńTextBox.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Nazwa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(407, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 24);
            this.label9.TabIndex = 17;
            this.label9.Text = "Okno wyświetleń";
            // 
            // kgLabel
            // 
            this.kgLabel.AutoSize = true;
            this.kgLabel.Location = new System.Drawing.Point(146, 194);
            this.kgLabel.Name = "kgLabel";
            this.kgLabel.Size = new System.Drawing.Size(21, 13);
            this.kgLabel.TabIndex = 15;
            this.kgLabel.Text = "kg";
            this.kgLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(973, 649);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grupaDodawania);
            this.Controls.Add(this.grupaWyświetlania);
            this.Controls.Add(this.textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Magazyn sklepu spożywczego";
            this.grupaWyświetlania.ResumeLayout(false);
            this.grupaWyświetlania.PerformLayout();
            this.grupaDodawania.ResumeLayout(false);
            this.grupaDodawania.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pojemnośćNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilośćNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cenaNumeric)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.przedziałNumeric2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przedziałNumeric1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox listaDziałów;
        private System.Windows.Forms.CheckBox WszystkieCheckBox;
        private System.Windows.Forms.GroupBox grupaWyświetlania;
        private System.Windows.Forms.Button wyświetlButton;
        private System.Windows.Forms.GroupBox grupaDodawania;
        private System.Windows.Forms.TextBox nazwaTextBox;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.NumericUpDown cenaNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ilośćLabel;
        private System.Windows.Forms.NumericUpDown ilośćNumeric;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox DziałBox;
        private System.Windows.Forms.DateTimePicker dataWażnościPicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label cenaLabel;
        private System.Windows.Forms.DateTimePicker dataProdukcjiPicker;
        private System.Windows.Forms.NumericUpDown pojemnośćNumeric;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.Label labelPojemność;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button poNazwieButton;
        private System.Windows.Forms.TextBox nazwaWyszukajTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown przedziałNumeric1;
        private System.Windows.Forms.Button poCenieButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown przedziałNumeric2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button usuńButton;
        private System.Windows.Forms.TextBox nazwaUsuńTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label kgLabel;
    }
}

