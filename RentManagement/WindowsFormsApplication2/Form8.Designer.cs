namespace WindowsFormsApplication2
{
    partial class Form8
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
            this.label7 = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pname = new System.Windows.Forms.ComboBox();
            this.FrmDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.Unpaid = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Renter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Active = new System.Windows.Forms.CheckBox();
            this.rooms = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Area = new System.Windows.Forms.TextBox();
            this.rent = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.PropertyNameList = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Customer = new System.Windows.Forms.GroupBox();
            this.CNIC = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.CPhone = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cname = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CustomerNameslist = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.RentFinal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ToDate = new System.Windows.Forms.DateTimePicker();
            this.PayDate = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.Advanced = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.Customer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PayDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(278, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Area";
            // 
            // Type
            // 
            this.Type.Enabled = false;
            this.Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type.Location = new System.Drawing.Point(148, 68);
            this.Type.MaxLength = 100;
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(100, 26);
            this.Type.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Type";
            // 
            // pname
            // 
            this.pname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pname.FormattingEnabled = true;
            this.pname.Location = new System.Drawing.Point(148, 29);
            this.pname.Name = "pname";
            this.pname.Size = new System.Drawing.Size(633, 26);
            this.pname.TabIndex = 1;
            this.pname.SelectedValueChanged += new System.EventHandler(this.pname_SelectedValueChanged);
            this.pname.TextChanged += new System.EventHandler(this.pname_TextChanged);
            this.pname.Click += new System.EventHandler(this.pname_Click);
            // 
            // FrmDate
            // 
            this.FrmDate.CustomFormat = "dd-MM-yyyy";
            this.FrmDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrmDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FrmDate.Location = new System.Drawing.Point(166, 416);
            this.FrmDate.Name = "FrmDate";
            this.FrmDate.Size = new System.Drawing.Size(235, 22);
            this.FrmDate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(163, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Rented From Date";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.Unpaid);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.Renter);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Active);
            this.groupBox1.Controls.Add(this.rooms);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Area);
            this.groupBox1.Controls.Add(this.rent);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.pname);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Type);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.PropertyNameList);
            this.groupBox1.Location = new System.Drawing.Point(19, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(787, 210);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Property";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(335, 213);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(235, 22);
            this.dateTimePicker1.TabIndex = 60;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(216, -20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 16);
            this.label13.TabIndex = 61;
            this.label13.Text = "Unpaid Amount";
            // 
            // Unpaid
            // 
            this.Unpaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unpaid.Location = new System.Drawing.Point(146, 178);
            this.Unpaid.MaxLength = 100;
            this.Unpaid.Name = "Unpaid";
            this.Unpaid.Size = new System.Drawing.Size(106, 26);
            this.Unpaid.TabIndex = 59;
            this.Unpaid.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 183);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 16);
            this.label12.TabIndex = 58;
            this.label12.Text = "Unpaid Amount";
            // 
            // Renter
            // 
            this.Renter.Enabled = false;
            this.Renter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Renter.Location = new System.Drawing.Point(146, 146);
            this.Renter.MaxLength = 1000;
            this.Renter.Name = "Renter";
            this.Renter.Size = new System.Drawing.Size(632, 26);
            this.Renter.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 16);
            this.label4.TabIndex = 55;
            this.label4.Text = "Currently Rented by";
            // 
            // Active
            // 
            this.Active.AutoSize = true;
            this.Active.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Active.Location = new System.Drawing.Point(695, 108);
            this.Active.Name = "Active";
            this.Active.Size = new System.Drawing.Size(77, 24);
            this.Active.TabIndex = 54;
            this.Active.Text = "Active";
            this.Active.UseVisualStyleBackColor = true;
            // 
            // rooms
            // 
            this.rooms.Enabled = false;
            this.rooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rooms.Location = new System.Drawing.Point(365, 103);
            this.rooms.MaxLength = 100;
            this.rooms.Name = "rooms";
            this.rooms.Size = new System.Drawing.Size(106, 26);
            this.rooms.TabIndex = 53;
            this.rooms.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(278, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 52;
            this.label2.Text = "Rooms";
            // 
            // Area
            // 
            this.Area.Enabled = false;
            this.Area.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Area.Location = new System.Drawing.Point(365, 66);
            this.Area.MaxLength = 100;
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(106, 26);
            this.Area.TabIndex = 47;
            this.Area.Text = "0";
            // 
            // rent
            // 
            this.rent.Enabled = false;
            this.rent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rent.Location = new System.Drawing.Point(148, 106);
            this.rent.MaxLength = 100;
            this.rent.Name = "rent";
            this.rent.Size = new System.Drawing.Size(100, 26);
            this.rent.TabIndex = 46;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(11, 113);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 16);
            this.label14.TabIndex = 45;
            this.label14.Text = "Rent";
            // 
            // PropertyNameList
            // 
            this.PropertyNameList.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.PropertyNameList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PropertyNameList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PropertyNameList.FormattingEnabled = true;
            this.PropertyNameList.ItemHeight = 16;
            this.PropertyNameList.Location = new System.Drawing.Point(148, 57);
            this.PropertyNameList.Name = "PropertyNameList";
            this.PropertyNameList.Size = new System.Drawing.Size(632, 82);
            this.PropertyNameList.TabIndex = 51;
            this.PropertyNameList.Visible = false;
            this.PropertyNameList.SelectedValueChanged += new System.EventHandler(this.PropertyNameList_SelectedValueChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(160, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 34);
            this.button1.TabIndex = 57;
            this.button1.Text = "Update Previous Rent Status";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Customer
            // 
            this.Customer.Controls.Add(this.CNIC);
            this.Customer.Controls.Add(this.label17);
            this.Customer.Controls.Add(this.CPhone);
            this.Customer.Controls.Add(this.label9);
            this.Customer.Controls.Add(this.cname);
            this.Customer.Controls.Add(this.label8);
            this.Customer.Controls.Add(this.CustomerNameslist);
            this.Customer.Location = new System.Drawing.Point(24, 12);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(782, 123);
            this.Customer.TabIndex = 36;
            this.Customer.TabStop = false;
            this.Customer.Text = "Renter";
            // 
            // CNIC
            // 
            this.CNIC.AutoSize = true;
            this.CNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNIC.Location = new System.Drawing.Point(82, 90);
            this.CNIC.Name = "CNIC";
            this.CNIC.Size = new System.Drawing.Size(125, 18);
            this.CNIC.TabIndex = 51;
            this.CNIC.Text = "0000000000000";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(8, 63);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 18);
            this.label17.TabIndex = 48;
            this.label17.Text = "Phone";
            // 
            // CPhone
            // 
            this.CPhone.AutoSize = true;
            this.CPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPhone.Location = new System.Drawing.Point(82, 63);
            this.CPhone.Name = "CPhone";
            this.CPhone.Size = new System.Drawing.Size(56, 18);
            this.CPhone.TabIndex = 45;
            this.CPhone.Text = "Phone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 18);
            this.label9.TabIndex = 39;
            this.label9.Text = "NIC #";
            // 
            // cname
            // 
            this.cname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cname.FormattingEnabled = true;
            this.cname.Location = new System.Drawing.Point(85, 16);
            this.cname.Name = "cname";
            this.cname.Size = new System.Drawing.Size(688, 26);
            this.cname.TabIndex = 0;
            this.cname.SelectedValueChanged += new System.EventHandler(this.cname_SelectedValueChanged);
            this.cname.TextChanged += new System.EventHandler(this.cname_TextChanged);
            this.cname.Click += new System.EventHandler(this.cname_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 18);
            this.label8.TabIndex = 38;
            this.label8.Text = "Name";
            // 
            // CustomerNameslist
            // 
            this.CustomerNameslist.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.CustomerNameslist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CustomerNameslist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameslist.FormattingEnabled = true;
            this.CustomerNameslist.ItemHeight = 16;
            this.CustomerNameslist.Location = new System.Drawing.Point(85, 42);
            this.CustomerNameslist.Name = "CustomerNameslist";
            this.CustomerNameslist.Size = new System.Drawing.Size(688, 82);
            this.CustomerNameslist.TabIndex = 50;
            this.CustomerNameslist.Visible = false;
            this.CustomerNameslist.SelectedValueChanged += new System.EventHandler(this.CustomerNameslist_SelectedValueChanged);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(410, 450);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(252, 34);
            this.button4.TabIndex = 7;
            this.button4.Text = "Assign Property to New Renter";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // RentFinal
            // 
            this.RentFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentFinal.Location = new System.Drawing.Point(166, 358);
            this.RentFinal.MaxLength = 100;
            this.RentFinal.Name = "RentFinal";
            this.RentFinal.Size = new System.Drawing.Size(106, 26);
            this.RentFinal.TabIndex = 4;
            this.RentFinal.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 48;
            this.label5.Text = "Rent Finalised:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(304, 364);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 16);
            this.label10.TabIndex = 50;
            this.label10.Text = "Rent Payable By:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(413, 397);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 16);
            this.label11.TabIndex = 52;
            this.label11.Text = "Rented  To Date";
            // 
            // ToDate
            // 
            this.ToDate.CustomFormat = "dd-MM-yyyy";
            this.ToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ToDate.Location = new System.Drawing.Point(416, 416);
            this.ToDate.Name = "ToDate";
            this.ToDate.Size = new System.Drawing.Size(235, 22);
            this.ToDate.TabIndex = 3;
            // 
            // PayDate
            // 
            this.PayDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayDate.Location = new System.Drawing.Point(421, 361);
            this.PayDate.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.PayDate.Name = "PayDate";
            this.PayDate.Size = new System.Drawing.Size(40, 22);
            this.PayDate.TabIndex = 5;
            this.PayDate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(467, 363);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 16);
            this.label16.TabIndex = 55;
            this.label16.Text = "of each Month";
            // 
            // Advanced
            // 
            this.Advanced.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Advanced.Location = new System.Drawing.Point(691, 357);
            this.Advanced.MaxLength = 100;
            this.Advanced.Name = "Advanced";
            this.Advanced.Size = new System.Drawing.Size(106, 26);
            this.Advanced.TabIndex = 6;
            this.Advanced.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(615, 363);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 16);
            this.label18.TabIndex = 56;
            this.label18.Text = "Advance:";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(691, 450);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 34);
            this.button3.TabIndex = 8;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.Location = new System.Drawing.Point(4, 497);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(808, 181);
            this.dataGridView1.TabIndex = 76;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(819, 685);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Advanced);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PayDate);
            this.Controls.Add(this.ToDate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.RentFinal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FrmDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Customer);
            this.Name = "Form8";
            this.Text = "Rent Property";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Customer.ResumeLayout(false);
            this.Customer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PayDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox Type;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox pname;
        private System.Windows.Forms.DateTimePicker FrmDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Customer;
        private System.Windows.Forms.ComboBox cname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.TextBox rent;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Area;
        private System.Windows.Forms.ListBox CustomerNameslist;
        private System.Windows.Forms.ListBox PropertyNameList;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label CPhone;
        private System.Windows.Forms.TextBox RentFinal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker ToDate;
        private System.Windows.Forms.NumericUpDown PayDate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Advanced;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox rooms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label CNIC;
        private System.Windows.Forms.CheckBox Active;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox Renter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Unpaid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label13;
    }
}