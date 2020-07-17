using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "/POS.accdb";
        public string OldTax = "";
        OleDbDataAdapter da;
        private BindingSource bindingSource = null;
        private OleDbCommandBuilder oleCommandBuilder = null;
        DataTable dataTable = new DataTable();

        private void DataRecordBind(string strSQL)
        {
            dataGridView1.DataSource = null;
            dataTable.Clear();

            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = strSQL;
            try
            {
                da = new OleDbDataAdapter(strSQL, connection);
                oleCommandBuilder = new OleDbCommandBuilder(da);
                da.Fill(dataTable);
                bindingSource = new BindingSource { DataSource = dataTable };
                dataGridView1.DataSource = bindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        void ComboItemsShow(string tablename, ComboBox cb)
        {
            string strSQL = "";
            strSQL = "Select Address from " + tablename;
            cb.Items.Clear();
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand command = new OleDbCommand(strSQL, connection);
                try
                {
                    connection.Open();
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {  
                                cb.Items.Add(reader[0].ToString()); 
                        }
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        
        private void Form4_Load(object sender, EventArgs e)
        {
            DataRecordBind("select Id,CustomerName as Renter,Address,AmountPaid,RemainingAmount,Arrears,InvDate from Invoice");
            ComboItemsShow("Place", prname);
        }

        private void Invoice_Click(object sender, EventArgs e)
        {

        }

        private void SaleDate_ValueChanged(object sender, EventArgs e)
        {
            string Mnth = SaleDate.Value.Month.ToString();
            string Year = SaleDate.Value.Year.ToString();
            if (!checkBox1.Checked && !checkBox2.Checked)
                DataRecordBind("select Id,CustomerName as Renter,Address,AmountPaid,RemainingAmount,Arrears,InvDate from Invoice where BillMonth=" + Mnth + " and BillYear=" + Year);
            else if(prname.SelectedItem != null && checkBox1.Checked)
                DataRecordBind("select Id,CustomerName as Renter,Address,AmountPaid,RemainingAmount,Arrears,InvDate from Invoice where Address='" + prname.SelectedItem.ToString() + "' and BillMonth=" + Mnth + " and BillYear=" + Year); 
            else if(CName.Text != "" && checkBox2.Checked)
                DataRecordBind("select Id,CustomerName as Renter,Address,AmountPaid,RemainingAmount,Arrears,InvDate from Invoice where CustomerName like '" + CName.Text + "%' and BillMonth=" + Mnth + " and BillYear=" + Year);
            else if(CName.Text != "" && checkBox2.Checked && prname.SelectedItem != null && checkBox1.Checked)
                DataRecordBind("select Id,CustomerName as Renter,Address,AmountPaid,RemainingAmount,Arrears,InvDate from Invoice where CustomerName like '" + CName.Text + "%' and Address='" + prname.SelectedItem.ToString() + "' and BillMonth=" + Mnth + " and BillYear=" + Year);
        }
        private void prname_SelectedValueChanged(object sender, EventArgs e)
        {

            DataRecordBind("select Id,CustomerName as Renter,Address,AmountPaid,RemainingAmount,Arrears,InvDate from Invoice where Address='" + prname.SelectedItem.ToString() + "'"); 
        }

        private void CName_TextChanged(object sender, EventArgs e)
        {
            DataRecordBind("select Id,CustomerName as Renter,Address,AmountPaid,RemainingAmount,Arrears,InvDate from Invoice where CustomerName like '" + CName.Text + "%'");
        }

      
        private void button18_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        public void UpdateRent()
        {
            try
            {
               
                dataGridView1.EndEdit(); //very important step
                da.Update(dataTable);
                MessageBox.Show("Rent Record Updated");
                DataRecordBind("select Id,CustomerName as Renter,Address,AmountPaid,RemainingAmount,InvDate from Invoice");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Update Rent Record?", "Warning", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                UpdateRent();
            }
        }
    }
}
