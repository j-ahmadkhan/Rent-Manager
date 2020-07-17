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
    public partial class Form6 : Form
    {
        public Form6()
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

        private void Form6_Load(object sender, EventArgs e)
        {
            DataRecordBind("select CustomerName,Phone,Address, Type, FromDate, ToDate, RentDate,Cust_Place.Rent,Advance,PreviousAmount, Status from Cust_Place_Rent");
            ComboItemsShow("Place", prname);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void CName_TextChanged(object sender, EventArgs e)
        {
            DataRecordBind("select CustomerName,Phone,Address, Type, FromDate, ToDate, RentDate,Cust_Place.Rent,Advance,PreviousAmount, Status from Cust_Place_Rent where CustomerName like'" + CName.Text + "%'");
        }

        private void prname_SelectedValueChanged(object sender, EventArgs e)
        {
            if(active.Checked == false)
            DataRecordBind("select CustomerName,Phone,Address, Type, FromDate, ToDate, RentDate,Cust_Place.Rent,Advance,PreviousAmount, Status from Cust_Place_Rent where Address ='" + prname.SelectedItem.ToString() + "'");
            else
                DataRecordBind("select CustomerName,Phone,Address, Type, FromDate, ToDate, RentDate,Cust_Place.Rent,Advance,PreviousAmount, Status from Cust_Place_Rent where Address ='" + prname.SelectedItem.ToString() + "' and Status = 1");
        }

        private void active_CheckedChanged(object sender, EventArgs e)
        {
            if (prname.SelectedItem != null)
            {
                if (active.Checked == false)
                    DataRecordBind("select CustomerName,Phone,Address, Type, FromDate, ToDate, RentDate,Cust_Place.Rent,Advance,PreviousAmount, Status from Cust_Place_Rent where Address ='" + prname.SelectedItem.ToString() + "'");
                else
                    DataRecordBind("select CustomerName,Phone,Address, Type, FromDate, ToDate, RentDate,Cust_Place.Rent,Advance,PreviousAmount, Status from Cust_Place_Rent where Address ='" + prname.SelectedItem.ToString() + "' and Status = 1");
            }
            else
            {
                if (active.Checked == false)
                    DataRecordBind("select CustomerName,Phone,Address, Type, FromDate, ToDate, RentDate,Cust_Place.Rent,Advance,PreviousAmount, Status from Cust_Place_Rent");
                else
                    DataRecordBind("select CustomerName,Phone,Address, Type, FromDate, ToDate, RentDate,Cust_Place.Rent,Advance,PreviousAmount, Status from Cust_Place_Rent where Status = 1");
            
            }
        }
    }
}
