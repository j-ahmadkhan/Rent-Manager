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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        public string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "/POS.accdb";
        string cid = "";
        string prid = "";

        double GetDecimal(string txt)
        {
            try
            {
                double d;
                double.TryParse(txt, out d);
                return d;
            }
            catch
            { return 0; }

        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double net = 0;
            try
            {
                Address.Text = listView1.SelectedItems[0].SubItems[0].Text;
                CustomerName.Text = listView1.SelectedItems[0].SubItems[1].Text;
                Rent.Text = listView1.SelectedItems[0].SubItems[2].Text;
                Unpaid.Text = listView1.SelectedItems[0].SubItems[4].Text;
                double r = GetDecimal(Rent.Text);
                double u = GetDecimal(Unpaid.Text);
                net = r + u;
                NetPayable.Text = net.ToString();
                prid = listView1.SelectedItems[0].SubItems[5].Text;
                cid = listView1.SelectedItems[0].SubItems[6].Text;
                cnic.Text = listView1.SelectedItems[0].SubItems[7].Text;
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //listView1.Items.Clear();
            CustomerName.Text = "";
            cid = "";
            prid = "";
            Address.Text = "";
            Unpaid.Text = "";
            Rent.Clear();
            Paid.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0 && prid != "")
            {
                DialogResult dr = MessageBox.Show("Collect Rent?", "Warning", MessageBoxButtons.YesNo);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                {

                    double prevAmt = GetDecimal(Unpaid.Text);
                    double PaidAmt = GetDecimal(Paid.Text);
                    double RentAmt = GetDecimal(Rent.Text);
                    int pam = 0;
                    if (PaidAmt < RentAmt)
                    {
                        pam = (int)RentAmt - (int)PaidAmt;
                        prevAmt += pam;
                    }
                    else if (PaidAmt > RentAmt)
                    {
                        pam = (int)PaidAmt - (int)RentAmt;
                        prevAmt -= pam;
                    }

                    OleDbCommand command = null;
                    OleDbTransaction tr = null;
                    string strSQL1 = "INSERT INTO Invoice(CustomerId,PlaceId,CustomerName,Address,RemainingAmount,InvDate,AmountPaid,BillMonth,BillYear,Arrears) VALUES(" + cid + "," + prid + ",'" + CustomerName.Text + "','" + Address.Text + "'," + pam.ToString() + ",'" + ReturnDate.Value.ToShortDateString() + "'," + Paid.Text + "," + ReturnDate.Value.Month.ToString() + "," + ReturnDate.Value.Year.ToString()  +"," + prevAmt.ToString() + ")";

                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();
                            command = new OleDbCommand(strSQL1, connection);
                            command.ExecuteReader();
                            if (pam != 0)
                            {
                                string strSQL7 = "Update Cust_Place SET PreviousAmount='" + prevAmt.ToString() + "' where customerid=" + cid + " and PlaceId=" + prid +" and status=1";
                                command = new OleDbCommand(strSQL7, connection);
                                command.ExecuteReader();
                            }

                            MessageBox.Show("Rent COLLECTED for Property", "Done!");
                            Refresh();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            //tr.Rollback();
                            
                            return;
                        }
                        connection.Close();
                        listView1.Items.Clear();
                        GetListInfo();
                    }
                }
            }
            else
                MessageBox.Show("No Property selected to get Rent");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Refresh();
        }

        void FillList()
        { 
            string month = ReturnDate.Value.Month.ToString();
            string year = ReturnDate.Value.Year.ToString();
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    string plcid = listView1.Items[i].SubItems[5].Text;
                    string custid = listView1.Items[i].SubItems[6].Text;
                    string strSQL = "Select id from Invoice where PlaceId=" + plcid + " and CustomerId=" + custid + " and billMonth=" + month + " and billyear=" + year;

               
                        OleDbCommand command = new OleDbCommand(strSQL, connection);
                        try
                        {
                            
                            using (OleDbDataReader reader = command.ExecuteReader())
                            {
                                reader.Read();
                                if (!reader.HasRows)
                                { listView1.Items[i].BackColor = System.Drawing.Color.OrangeRed; }
                                else
                                { listView1.Items[i].BackColor = System.Drawing.Color.White; }

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                connection.Close();
             }
        }
        void Refresh()
        {
            //listView1.Items.Clear();
            CustomerName.Text = "Name";
            cnic.Text = "000";
            Address.Text = "Address";
            Unpaid.Text = "0";
            Rent.Text = "0";
            Paid.Text = "0";
            NetPayable.Text = "0";
        }

        void GetListInfo()
        {
            string strSQL = "Select Address,CustomerName,Cust_Place.Rent,RentDate,PreviousAmount,PlaceId,CustomerId,CNIC from Cust_Place_Rent where Status = 1";
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
                            string[] row = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString() };
                            ListViewItem lv = new ListViewItem(row);
                            listView1.Items.Add(lv);
                        }
                        FillList();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

            GetListInfo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                    OleDbCommand command = null;
                    OleDbTransaction tr = null;
                    DialogResult dr = MessageBox.Show("Update Renter Arrears?", "Warning", MessageBoxButtons.YesNo);
                    if (dr == System.Windows.Forms.DialogResult.Yes)
                    {
                        using (OleDbConnection connection = new OleDbConnection(connectionString))
                        {
                            try
                            {
                                connection.Open();
                       
                                if (Unpaid.Text != "")
                                {
                                    string strSQL7 = "Update Cust_Place SET PreviousAmount='" + Unpaid.Text + "' where customerid=" + cid + " and PlaceId=" + prid + " and status=1";
                                    command = new OleDbCommand(strSQL7, connection);
                                    command.ExecuteReader();
                                }

                                MessageBox.Show("Arrears Updated", "Done!");
                                Refresh();
                                listView1.Items.Clear();
                                GetListInfo();

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                                //tr.Rollback();

                                return;
                            }
                            connection.Close();
                        }
                    }
        }

        private void ReturnDate_ValueChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            GetListInfo();
        }
    }
}
