namespace WindowsFormsApplication2
{
    partial class Form5
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
            this.Address = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ReturnDate = new System.Windows.Forms.DateTimePicker();
            this.Paid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Addresss = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ren = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rentss = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.CustomerName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Rent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cnic = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cnicc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Unpaid = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.NetPayable = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(147, 380);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(138, 18);
            this.Address.TabIndex = 59;
            this.Address.Text = "Property Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(959, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 61;
            this.label4.Text = "Current Date";
            // 
            // ReturnDate
            // 
            this.ReturnDate.CustomFormat = "dd-MM-yyyy";
            this.ReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ReturnDate.Location = new System.Drawing.Point(1047, 12);
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.Size = new System.Drawing.Size(121, 22);
            this.ReturnDate.TabIndex = 60;
            this.ReturnDate.ValueChanged += new System.EventHandler(this.ReturnDate_ValueChanged);
            // 
            // Paid
            // 
            this.Paid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paid.Location = new System.Drawing.Point(975, 452);
            this.Paid.MaxLength = 7;
            this.Paid.Name = "Paid";
            this.Paid.Size = new System.Drawing.Size(98, 26);
            this.Paid.TabIndex = 4;
            this.Paid.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(903, 458);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 65;
            this.label6.Text = "Paid";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(902, 393);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 64;
            this.label7.Text = "Rent:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(975, 483);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 36);
            this.button1.TabIndex = 67;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1079, 391);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 87);
            this.button3.TabIndex = 69;
            this.button3.Text = "Collect Rent";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Addresss
            // 
            this.Addresss.Text = "Address";
            this.Addresss.Width = 350;
            // 
            // Ren
            // 
            this.Ren.Text = "Renter";
            this.Ren.Width = 350;
            // 
            // Rentss
            // 
            this.Rentss.Text = "Rent";
            this.Rentss.Width = 100;
            // 
            // Rd
            // 
            this.Rd.Text = "Due Date";
            this.Rd.Width = 150;
            // 
            // PA
            // 
            this.PA.Text = "Arrears";
            this.PA.Width = 200;
            // 
            // pid
            // 
            this.pid.Width = 0;
            // 
            // CustomerId
            // 
            this.CustomerId.Width = 0;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Addresss,
            this.Ren,
            this.Rentss,
            this.Rd,
            this.PA,
            this.pid,
            this.CustomerId,
            this.cnicc});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(24, 40);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1155, 320);
            this.listView1.TabIndex = 56;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSize = true;
            this.CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerName.Location = new System.Drawing.Point(147, 414);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(99, 16);
            this.CustomerName.TabIndex = 54;
            this.CustomerName.Text = "Renter Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 70;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 472);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 71;
            this.label2.Text = "Previous Arrears";
            // 
            // Rent
            // 
            this.Rent.Enabled = false;
            this.Rent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rent.Location = new System.Drawing.Point(975, 391);
            this.Rent.MaxLength = 7;
            this.Rent.Name = "Rent";
            this.Rent.Size = new System.Drawing.Size(98, 26);
            this.Rent.TabIndex = 73;
            this.Rent.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 74;
            this.label3.Text = "CNIC#";
            // 
            // cnic
            // 
            this.cnic.AutoSize = true;
            this.cnic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnic.Location = new System.Drawing.Point(147, 447);
            this.cnic.Name = "cnic";
            this.cnic.Size = new System.Drawing.Size(16, 16);
            this.cnic.TabIndex = 75;
            this.cnic.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 16);
            this.label5.TabIndex = 76;
            this.label5.Text = "Click Over the Property to Collect Rent";
            // 
            // cnicc
            // 
            this.cnicc.Width = 0;
            // 
            // Unpaid
            // 
            this.Unpaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unpaid.Location = new System.Drawing.Point(146, 471);
            this.Unpaid.Name = "Unpaid";
            this.Unpaid.Size = new System.Drawing.Size(100, 22);
            this.Unpaid.TabIndex = 77;
            this.Unpaid.Text = "0";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(27, 499);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 31);
            this.button2.TabIndex = 78;
            this.button2.Text = "Update Arrears";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NetPayable
            // 
            this.NetPayable.AutoSize = true;
            this.NetPayable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetPayable.Location = new System.Drawing.Point(975, 427);
            this.NetPayable.Name = "NetPayable";
            this.NetPayable.Size = new System.Drawing.Size(16, 16);
            this.NetPayable.TabIndex = 80;
            this.NetPayable.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(902, 428);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 16);
            this.label9.TabIndex = 79;
            this.label9.Text = "Net Total:";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1191, 542);
            this.Controls.Add(this.NetPayable);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Unpaid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cnic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Rent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Paid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ReturnDate);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.CustomerName);
            this.Name = "Form5";
            this.Text = "Collect Rent";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker ReturnDate;
        private System.Windows.Forms.TextBox Paid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColumnHeader Addresss;
        private System.Windows.Forms.ColumnHeader Ren;
        private System.Windows.Forms.ColumnHeader Rentss;
        private System.Windows.Forms.ColumnHeader Rd;
        private System.Windows.Forms.ColumnHeader PA;
        private System.Windows.Forms.ColumnHeader pid;
        private System.Windows.Forms.ColumnHeader CustomerId;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label CustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Rent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label cnic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader cnicc;
        private System.Windows.Forms.TextBox Unpaid;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label NetPayable;
        private System.Windows.Forms.Label label9;
    }
}