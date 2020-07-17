namespace WindowsFormsApplication2
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Water = new System.Windows.Forms.CheckBox();
            this.Gas = new System.Windows.Forms.CheckBox();
            this.Elect = new System.Windows.Forms.CheckBox();
            this.Porch = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Floors = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Lawn = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Area = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Dining = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.drawing = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.kitchen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.store = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rooms = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.PType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Rent = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.button19 = new System.Windows.Forms.Button();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.STN = new System.Windows.Forms.TextBox();
            this.NTN = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.Company = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button11 = new System.Windows.Forms.Button();
            this.RunningStockGrid = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RunningStockGrid)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(980, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 53);
            this.button1.TabIndex = 13;
            this.button1.Text = "Add Property";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Address";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Water);
            this.groupBox1.Controls.Add(this.Gas);
            this.groupBox1.Controls.Add(this.Elect);
            this.groupBox1.Controls.Add(this.Porch);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.Floors);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.Lawn);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Area);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Dining);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.drawing);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.kitchen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.store);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rooms);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.PType);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.Rent);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(41, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1146, 204);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Property";
            // 
            // Water
            // 
            this.Water.AutoSize = true;
            this.Water.Location = new System.Drawing.Point(725, 164);
            this.Water.Name = "Water";
            this.Water.Size = new System.Drawing.Size(55, 17);
            this.Water.TabIndex = 37;
            this.Water.Text = "Water";
            this.Water.UseVisualStyleBackColor = true;
            // 
            // Gas
            // 
            this.Gas.AutoSize = true;
            this.Gas.Location = new System.Drawing.Point(593, 164);
            this.Gas.Name = "Gas";
            this.Gas.Size = new System.Drawing.Size(45, 17);
            this.Gas.TabIndex = 36;
            this.Gas.Text = "Gas";
            this.Gas.UseVisualStyleBackColor = true;
            // 
            // Elect
            // 
            this.Elect.AutoSize = true;
            this.Elect.Location = new System.Drawing.Point(468, 164);
            this.Elect.Name = "Elect";
            this.Elect.Size = new System.Drawing.Size(71, 17);
            this.Elect.TabIndex = 35;
            this.Elect.Text = "Electricity";
            this.Elect.UseVisualStyleBackColor = true;
            // 
            // Porch
            // 
            this.Porch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Porch.ForeColor = System.Drawing.Color.Black;
            this.Porch.Location = new System.Drawing.Point(725, 115);
            this.Porch.MaxLength = 2;
            this.Porch.Name = "Porch";
            this.Porch.Size = new System.Drawing.Size(53, 26);
            this.Porch.TabIndex = 12;
            this.Porch.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(664, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 16);
            this.label12.TabIndex = 33;
            this.label12.Text = "Porch";
            // 
            // Floors
            // 
            this.Floors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Floors.ForeColor = System.Drawing.Color.Black;
            this.Floors.Location = new System.Drawing.Point(593, 116);
            this.Floors.MaxLength = 2;
            this.Floors.Name = "Floors";
            this.Floors.Size = new System.Drawing.Size(53, 26);
            this.Floors.TabIndex = 11;
            this.Floors.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(532, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 16);
            this.label11.TabIndex = 31;
            this.label11.Text = "Floors";
            // 
            // Lawn
            // 
            this.Lawn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lawn.ForeColor = System.Drawing.Color.Black;
            this.Lawn.Location = new System.Drawing.Point(468, 117);
            this.Lawn.MaxLength = 2;
            this.Lawn.Name = "Lawn";
            this.Lawn.Size = new System.Drawing.Size(53, 26);
            this.Lawn.TabIndex = 10;
            this.Lawn.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(407, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 16);
            this.label9.TabIndex = 29;
            this.label9.Text = "Lawn";
            // 
            // Area
            // 
            this.Area.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Area.Location = new System.Drawing.Point(130, 145);
            this.Area.MaxLength = 100;
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(100, 26);
            this.Area.TabIndex = 4;
            this.Area.Text = "0x0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "Area";
            // 
            // Dining
            // 
            this.Dining.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dining.ForeColor = System.Drawing.Color.Black;
            this.Dining.Location = new System.Drawing.Point(984, 68);
            this.Dining.MaxLength = 2;
            this.Dining.Name = "Dining";
            this.Dining.Size = new System.Drawing.Size(53, 26);
            this.Dining.TabIndex = 9;
            this.Dining.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(923, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Dining";
            // 
            // drawing
            // 
            this.drawing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawing.ForeColor = System.Drawing.Color.Black;
            this.drawing.Location = new System.Drawing.Point(859, 67);
            this.drawing.MaxLength = 2;
            this.drawing.Name = "drawing";
            this.drawing.Size = new System.Drawing.Size(53, 26);
            this.drawing.TabIndex = 8;
            this.drawing.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(798, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Drawing";
            // 
            // kitchen
            // 
            this.kitchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitchen.ForeColor = System.Drawing.Color.Black;
            this.kitchen.Location = new System.Drawing.Point(725, 67);
            this.kitchen.MaxLength = 2;
            this.kitchen.Name = "kitchen";
            this.kitchen.Size = new System.Drawing.Size(53, 26);
            this.kitchen.TabIndex = 7;
            this.kitchen.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(664, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Kitchen";
            // 
            // store
            // 
            this.store.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.store.ForeColor = System.Drawing.Color.Black;
            this.store.Location = new System.Drawing.Point(593, 69);
            this.store.MaxLength = 2;
            this.store.Name = "store";
            this.store.Size = new System.Drawing.Size(53, 26);
            this.store.TabIndex = 6;
            this.store.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(532, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Store";
            // 
            // rooms
            // 
            this.rooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rooms.ForeColor = System.Drawing.Color.Black;
            this.rooms.Location = new System.Drawing.Point(468, 67);
            this.rooms.MaxLength = 2;
            this.rooms.Name = "rooms";
            this.rooms.Size = new System.Drawing.Size(53, 26);
            this.rooms.TabIndex = 5;
            this.rooms.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(407, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Rooms";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(130, 25);
            this.txtAddress.MaxLength = 1200;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(988, 26);
            this.txtAddress.TabIndex = 1;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // PType
            // 
            this.PType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PType.FormattingEnabled = true;
            this.PType.Items.AddRange(new object[] {
            "Chamber",
            "Residential",
            "Business",
            "Shop",
            "Office",
            "Plot"});
            this.PType.Location = new System.Drawing.Point(130, 67);
            this.PType.Name = "PType";
            this.PType.Size = new System.Drawing.Size(233, 26);
            this.PType.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Type";
            // 
            // Rent
            // 
            this.Rent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rent.Location = new System.Drawing.Point(130, 104);
            this.Rent.MaxLength = 100;
            this.Rent.Name = "Rent";
            this.Rent.Size = new System.Drawing.Size(100, 26);
            this.Rent.TabIndex = 3;
            this.Rent.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Rent";
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(248, 227);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(130, 31);
            this.button13.TabIndex = 20;
            this.button13.Text = "Collect Rent";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(107, 227);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(135, 31);
            this.button14.TabIndex = 21;
            this.button14.Text = "Renter Info";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(509, 227);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(119, 31);
            this.button15.TabIndex = 22;
            this.button15.Text = "Rent Record";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(634, 227);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(141, 31);
            this.button16.TabIndex = 23;
            this.button16.Text = "Rent Property";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(781, 227);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(134, 31);
            this.button17.TabIndex = 24;
            this.button17.Text = "Backup Database";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button19
            // 
            this.button19.Enabled = false;
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.Location = new System.Drawing.Point(921, 227);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(157, 31);
            this.button19.TabIndex = 25;
            this.button19.Text = "Clean All Database";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.checkBox3.Location = new System.Drawing.Point(923, 259);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(135, 19);
            this.checkBox3.TabIndex = 26;
            this.checkBox3.Text = "Enable Clean DB";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckStateChanged += new System.EventHandler(this.checkBox3_CheckStateChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button3);
            this.tabPage4.Controls.Add(this.STN);
            this.tabPage4.Controls.Add(this.NTN);
            this.tabPage4.Controls.Add(this.Address);
            this.tabPage4.Controls.Add(this.Phone);
            this.tabPage4.Controls.Add(this.Company);
            this.tabPage4.Controls.Add(this.label21);
            this.tabPage4.Controls.Add(this.label20);
            this.tabPage4.Controls.Add(this.label19);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1144, 490);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Dealer Info";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(143, 288);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 38);
            this.button3.TabIndex = 22;
            this.button3.Text = "Update Info";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // STN
            // 
            this.STN.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STN.Location = new System.Drawing.Point(143, 213);
            this.STN.MaxLength = 10000;
            this.STN.Name = "STN";
            this.STN.Size = new System.Drawing.Size(163, 25);
            this.STN.TabIndex = 21;
            // 
            // NTN
            // 
            this.NTN.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NTN.Location = new System.Drawing.Point(143, 169);
            this.NTN.MaxLength = 10000;
            this.NTN.Name = "NTN";
            this.NTN.Size = new System.Drawing.Size(163, 25);
            this.NTN.TabIndex = 20;
            // 
            // Address
            // 
            this.Address.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(143, 83);
            this.Address.MaxLength = 10000;
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(677, 25);
            this.Address.TabIndex = 18;
            this.Address.Text = "PINDI";
            // 
            // Phone
            // 
            this.Phone.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.Location = new System.Drawing.Point(143, 127);
            this.Phone.MaxLength = 10000;
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(163, 25);
            this.Phone.TabIndex = 19;
            // 
            // Company
            // 
            this.Company.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Company.Location = new System.Drawing.Point(143, 39);
            this.Company.MaxLength = 10000;
            this.Company.Name = "Company";
            this.Company.Size = new System.Drawing.Size(677, 25);
            this.Company.TabIndex = 17;
            this.Company.Text = "ROGER ENTERPRISES";
            this.Company.TextChanged += new System.EventHandler(this.Company_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(31, 219);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(36, 16);
            this.label21.TabIndex = 24;
            this.label21.Text = "STN";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(31, 175);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(37, 16);
            this.label20.TabIndex = 22;
            this.label20.Text = "NTN";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(31, 89);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 16);
            this.label19.TabIndex = 20;
            this.label19.Text = "Address";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(31, 133);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 16);
            this.label18.TabIndex = 18;
            this.label18.Text = "Phone";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(31, 45);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(106, 16);
            this.label17.TabIndex = 16;
            this.label17.Text = "Company Name";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button11);
            this.tabPage1.Controls.Add(this.RunningStockGrid);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1144, 490);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Current Properties";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(949, 446);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(189, 38);
            this.button11.TabIndex = 18;
            this.button11.Text = "Update Property Info";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // RunningStockGrid
            // 
            this.RunningStockGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RunningStockGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.RunningStockGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RunningStockGrid.Location = new System.Drawing.Point(6, 6);
            this.RunningStockGrid.Name = "RunningStockGrid";
            this.RunningStockGrid.Size = new System.Drawing.Size(1132, 434);
            this.RunningStockGrid.TabIndex = 0;
            this.RunningStockGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RunningStockGrid_CellClick);
            this.RunningStockGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.RunningStockGrid_CellEndEdit);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(41, 272);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1152, 516);
            this.tabControl1.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(384, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 31);
            this.button2.TabIndex = 27;
            this.button2.Text = "Rented Places";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1205, 798);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button13);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PROPERTY & DEALER INFO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RunningStockGrid)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox PType;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox Rent;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.CheckBox checkBox3;
        public System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox STN;
        private System.Windows.Forms.TextBox NTN;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.TextBox Company;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.DataGridView RunningStockGrid;
        private System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TextBox store;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox rooms;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox Porch;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox Floors;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox Lawn;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox Area;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox Dining;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox drawing;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox kitchen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox Water;
        private System.Windows.Forms.CheckBox Gas;
        private System.Windows.Forms.CheckBox Elect;
        private System.Windows.Forms.Button button2;
    }
}

