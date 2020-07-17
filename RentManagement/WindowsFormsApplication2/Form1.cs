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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //for 2007 Provider=Microsoft.Jet.OLEDB.4.0
        public string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "/POS.accdb";
        public string OldTax = "";
        OleDbDataAdapter da;
        private BindingSource bindingSource = null;
        private OleDbCommandBuilder oleCommandBuilder = null;
        DataTable dataTable = new DataTable();

        OleDbDataAdapter da1;
        private BindingSource bindingSource1 = null;
        private OleDbCommandBuilder oleCommandBuilder1 = null;
        DataTable dataTable1 = new DataTable();

        OleDbDataAdapter da2;
        private BindingSource bindingSource2 = null;
        private OleDbCommandBuilder oleCommandBuilder2 = null;
        DataTable dataTable2 = new DataTable();


        bool IsDecimal(string txt)
        {
            try
            {
                double d;
                return (double.TryParse(txt, out d));
            }
            catch
            { return false; }
        }

        public static void Backup()
        {
            string dt = Application.StartupPath + "/Backup/POS.accdb_" + DateTime.Now.GetHashCode();
            File.Copy(Application.StartupPath + "/POS.accdb", dt, true);
            
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            int el = 0;
            int g = 0;
            int w = 0;
            if (Elect.Checked)
                el = 1;
            if (Gas.Checked)
                g = 1;
            if (Water.Checked)
                w = 1;
            if (Rent.Text != "" && txtAddress.Text != "")
            {
                string strSQL = "INSERT INTO Place(Address, Type, Rent, Area, Rooms, store, drawing, dining, kitchen, lawn, porch, floors, electricity, gas, water) VALUES ('" + txtAddress.Text + "','" + PType.SelectedItem.ToString() + "','" + Rent.Text + "','" + Area.Text + "','" + rooms.Text + "','" + store.Text + "','" + drawing.Text + "','" + Dining.Text + "','" + kitchen.Text + "','" + Lawn.Text + "','" + Porch.Text + "','" + Floors.Text + "','" + el + "','" + g + "','" + w + "')";

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    OleDbCommand command = new OleDbCommand(strSQL, connection);

                    try
                    {
                        connection.Open();
                        command.ExecuteReader();
                        connection.Close();
                        txtAddress.Clear();
                        Rent.Text = "0";
                        rooms.Text = "1";
                        Elect.Checked = false;
                        Gas.Checked = false;
                        Water.Checked = false;
                        
                        MessageBox.Show("Property Added to List");
                        DataBind("SELECT ID,Address,Rent,Type,Rooms,Area FROM Place");
      
                       

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else {
                MessageBox.Show("Property Details Missing. Please Add the details", "Failure!");
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
           // DataSet1TableAdapters.SaleInvoiceTableAdapter SA = new DataSet1TableAdapters.SaleInvoiceTableAdapter();
           // SA.Connection.ConnectionString = connectionString;


            DataBind("SELECT ID,Address,Rent,Type,Rooms,Area FROM Place");
      
            string strSQL1 = "Select * from CompanyInfo";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            { 
                try
                {
                    connection.Open();

                    OleDbCommand command = new OleDbCommand(strSQL1, connection);
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                        {
                            Company.Text = reader[1].ToString();
                            Address.Text = reader[2].ToString();
                            Phone.Text = reader[3].ToString();
                            NTN.Text = reader[4].ToString();
                            STN.Text = reader[5].ToString();
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

        private void DataBind(string strSQL)
        {
            RunningStockGrid.DataSource = null;

            dataTable.Clear();

            //string strSQL = "SELECT * FROM Place";

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
                RunningStockGrid.DataSource = bindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public void UpdateStock()
        {
            try
            {
                Backup();
                RunningStockGrid.EndEdit(); //very important step
                da.Update(dataTable);
                MessageBox.Show("Property Record Updated");
                DataBind("SELECT ID,Address,Rent,Type,Rooms,Area FROM Place");
      
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Update Property Record?", "Warning", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                UpdateStock();
            }


        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void RunningStockGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RunningStockGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           // MessageBox.Show(sender.ToString()+" " +RunningStockGrid[e.ColumnIndex, e.RowIndex].Value.ToString());
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
           
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

      
        private void button16_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
        }

       

        private void Company_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Update Company Info?", "Warning", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                string strSQL = "UPDATE CompanyInfo SET CompanyName ='" + Company.Text + "', Address ='" + Address.Text + "', Phone ='" + Phone.Text + "', NTN ='" + NTN.Text + "', STN ='" + STN.Text + "' where id = 1";
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    OleDbCommand command = new OleDbCommand(strSQL, connection);
                    try
                    {
                        connection.Open();
                        command.ExecuteReader();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
        }

      

        private void checkBox3_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                button19.Enabled = true;
            else
                button19.Enabled = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Clean All Data, Are you Sure?", "Warning", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                dr = MessageBox.Show("Do you want to take a data Backup?", "Precaution", MessageBoxButtons.YesNo);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                {
                    Backup();
                    MessageBox.Show("Backup Done, Now Cleaning up Data");
                }

                //string strSQL1 = "DELETE from CompanyInfo";
                string strSQL2 = "DELETE from Place";
                string strSQL3 = "DELETE from Customer";
                string strSQL4 = "DELETE from Cust_Place";
                string strSQL5 = "DELETE from Invoice";
          

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    //OleDbCommand command = new OleDbCommand(strSQL1, connection);
                    try
                    {
                        connection.Open();
                        //command.ExecuteReader();
                        //command = new OleDbCommand(strSQL1, connection);
                        //command.ExecuteReader();
                        OleDbCommand command = new OleDbCommand(strSQL2, connection);
                        command.ExecuteReader();
                        command = new OleDbCommand(strSQL3, connection);
                        command.ExecuteReader();
                        command = new OleDbCommand(strSQL4, connection);
                        command.ExecuteReader();
                        command = new OleDbCommand(strSQL5, connection);
                        command.ExecuteReader();

                        MessageBox.Show("All Data is Formatted except CompanyInfo","Done");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    connection.Close();

                }
            }
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            DataBind("Select * from Place where Address like '" + txtAddress.Text + "%'");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
        }

       
       
    }
}
