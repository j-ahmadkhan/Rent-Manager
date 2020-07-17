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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        public string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "/POS.accdb";

        public string Company = "";
        public string Address = "";
        public string Phone = "";
        public string NTN = "";
        public string STN = "";

        string PlaceId = "";
        string CustId = "";
        string CustPlaceId = "";
        string PreviousRenterCNIC = "";

        OleDbDataAdapter da;
        private BindingSource bindingSource = null;
        private OleDbCommandBuilder oleCommandBuilder = null;
        DataTable dataTable = new DataTable();
        public string SaleTax = "";
        double PrevUnpaidAmount = 0;

      
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


        double GetDecimal(string txt)
        {
            try
            {
                double d;
                double.TryParse(txt, out d);
                return d;
            }
            catch
            {
                //MessageBox.Show("Value " + txt + " is invalid" );
                return 0; 
            }
            
        }

        void ComboItemsShow(string tablename, ComboBox cb)
        {
            string strSQL = "";
            strSQL = "Select * from " + tablename;
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
                                cb.Items.Add(reader[1].ToString()); 
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

       

        private void Form3_Load(object sender, EventArgs e)
        {
            ComboItemsShow("Customer", cname);
            ComboItemsShow("Place", pname);
        }

        private void cname_Click(object sender, EventArgs e)
        {
            cname.Items.Clear();
            //if (cname.Text == "")
            {
                ComboItemsShow("Customer", cname);
            }
            /*else
            {

                cname.Items.Clear();
                string strSQL = "Select CustomerName from Customer where CustomerName like '" + cname.Text + "%'";

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
                                cname.Items.Add(reader[0].ToString());
                            }

                        }
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }*/
        }

        private void pname_Click(object sender, EventArgs e)
        {
            pname.Items.Clear();
            //if (pname.Text == "")
            {
                ComboItemsShow("Place", pname);
            }
            //else
            //{

            //    pname.Items.Clear();
            //    string strSQL = "Select Address from Place where Address like '" + pname.Text + "%'";

            //    using (OleDbConnection connection = new OleDbConnection(connectionString))
            //    {
            //        OleDbCommand command = new OleDbCommand(strSQL, connection);
            //        try
            //        {
            //            connection.Open();
            //            using (OleDbDataReader reader = command.ExecuteReader())
            //            {

            //                while (reader.Read())
            //                {
            //                    pname.Items.Add(reader[0].ToString());
            //                }

            //            }
            //            connection.Close();
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show(ex.Message);
            //        }
            //    }

            //}
        }

       
        private void cname_SelectedValueChanged(object sender, EventArgs e)
        {
            //string strSQL = "Select id,CNIC,PrevAmount,Address from Customer where CustomerName='" + cname.SelectedItem.ToString() + "'";
            if (CustomerNameslist.Visible == true)
                return;
            string strSQL = "Select id,CNIC,Phone from Customer where CustomerName='" + cname.SelectedItem.ToString() + "'";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand command = new OleDbCommand(strSQL, connection);
                try
                {
                    //cnic.Items.Clear();
                    Refresh();
                    connection.Open();
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CustId = reader[0].ToString();
                            CNIC.Text = reader[1].ToString();
                            CPhone.Text = reader[2].ToString();   
                        }
                        connection.Close();

                        DataRecordBind("select CustomerName,Phone,Address,Address, Type, FromDate, ToDate, RentDate,Cust_Place.Rent,Advance,PreviousAmount, Status from Cust_Place_Rent where CNIC='" + CNIC.Text + "' and Status=1");  
                      
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        void GetAlreadyRentedPropertyInfo(string pid)
        {
            //string CustPlaceId = "0";
            string strSQL = "Select Cust_Place.id,CustomerName,FromDate,ToDate,Cust_Place.Rent,Advance,PreviousAmount,CNIC  from Cust_Place_Rent where PlaceId=" + pid + " and Status=1";
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
                            CustPlaceId = reader[0].ToString();
                            Renter.Text = reader[1].ToString();
                            FrmDate.Text = reader[2].ToString();
                            ToDate.Text = reader[3].ToString();
                            RentFinal.Text = reader[4].ToString();
                            Advanced.Text = reader[5].ToString();
                            Unpaid.Text = reader[6].ToString();
                            PreviousRenterCNIC = reader[7].ToString();
                        }
                        if (!reader.HasRows)
                        {
                            Renter.Text = "";
                            Active.Checked = false;
                        }
                        else
                            Active.Checked = true;
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void pname_SelectedValueChanged(object sender, EventArgs e)
        {
            if (PropertyNameList.Visible == true)
                return;
            string id = "0";
            string strSQL = "select ID,Type,Rent,Area,Rooms from Place where Address='"+pname.SelectedItem.ToString()+"'";
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
                            id = reader[0].ToString();
                            Type.Text = reader[1].ToString();
                            rent.Text = reader[2].ToString();
                            Area.Text = reader[3].ToString();
                            rooms.Text = reader[4].ToString();
                            PlaceId = id;
                        }
                        if (id != "0")
                            GetAlreadyRentedPropertyInfo(id);
                         
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        void Refresh()
        {
            rent.Text = "0";
            CNIC.Text = "00";
            Type.Clear();
            rooms.Clear();
            rent.Text = "0";
            RentFinal.Text = "0";
            Advanced.Text = "0";
            Active.Checked = false;
            Renter.Clear();
            Unpaid.Text = "0";
            //RentFinal.Clear();
            dataGridView1.DataSource = null;
            dataTable.Clear();
            CustId = "";
            PlaceId = "";
            PreviousRenterCNIC = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Refresh();
        }

       
        private void Paid_Click(object sender, EventArgs e)
        {
            //Paid.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OleDbCommand command = null;
            //OleDbTransaction tr = null;
            if (CustId != "" && PlaceId != "")
            {
                if (RentFinal.Text != "0" && RentFinal.Text != "")
                {
                    string customer = cname.SelectedItem.ToString();
                    if (customer == Renter.Text && Active.Checked && CNIC.Text == PreviousRenterCNIC)
                    {
                        MessageBox.Show("Property already Rented by " + customer + "\nPlease Update instead of Adding New!", "Error!", MessageBoxButtons.OK);
                        button1.Focus();
                        return;
                    }
                    else if (Active.Checked)
                    {
                        DialogResult dr = MessageBox.Show("Property already Rented by " + Renter.Text + "\nAssign to New Renter?", "Warning!", MessageBoxButtons.YesNo);
                        if (dr == System.Windows.Forms.DialogResult.No)
                            return;
                        else
                        {
                            using (OleDbConnection connection = new OleDbConnection(connectionString))
                            {
                                connection.Open();
                                try
                                {
                                    string strSQL7 = "Update Cust_Place SET Status ='0'" + " where id=" + CustPlaceId + "";
                                    command = new OleDbCommand(strSQL7, connection);
                                    command.ExecuteReader();
                                }
                                catch (Exception ex)
                                { MessageBox.Show(ex.ToString()); return; }
                                connection.Close();

                            }
                        }
                    }

                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    {
                        connection.Open();
                        try
                        {
                            string strSQL1 = "INSERT INTO Cust_Place(CustomerId,PlaceId,FromDate,ToDate,RentDate,Rent,PreviousAmount,Status,Advance) VALUES('" + CustId + "','" + PlaceId + "','" + FrmDate.Value.ToShortDateString() + "','" + ToDate.Value.ToShortDateString() + "','" + PayDate.Value.ToString() + "','" + RentFinal.Text + "','" + Unpaid.Text + "','" + "1" + "','" + Advanced.Text + "')";
                            //string strSQL1 = "INSERT INTO Cust_Place(CustomerId,PlaceId,FromDate,ToDate,RentDate,Rent,PreviousAmount,Status,Advance) VALUES(" + CustId + "," + PlaceId + ",'" + FrmDate.Value.ToShortDateString() + "','" + ToDate.Value.ToShortDateString() + "','" + PayDate.Value.ToString() + "','" + RentFinal.Text + "','" + Unpaid.Text + "','" + "1" + "','" + Advanced.Text + "')";
                            command = new OleDbCommand(strSQL1, connection);
                            command.ExecuteReader();
                        }
                        catch (Exception ex)
                        { MessageBox.Show(ex.ToString()); return; }
                        connection.Close();

                    }
                     
                    MessageBox.Show("Property Assigned to " + cname.SelectedItem.ToString(), "Done");
                    CustPlaceId = "";
                    PlaceId = "";
                    CustId = "";
                    Refresh();
                    DataRecordBind("select CustomerName,Phone,Address,Address, Type, FromDate, ToDate, RentDate,Cust_Place.Rent,Advance,PreviousAmount, Status from Cust_Place_Rent where CNIC='" + CNIC.Text + "' and Status=1"); 
                }
                else
                {
                    MessageBox.Show("Final Rent is Required for Renting The Property", "Error!", MessageBoxButtons.OK);
                    RentFinal.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please Select Renter and Property!", "Error!", MessageBoxButtons.OK);
            }
          
        }


       

        void AddToCell(Microsoft.Office.Interop.Word.Table table, int rowindex, int colindex,float fontsize, int bold, string text)
        {
            table.Cell(rowindex, colindex).Range.Text = text;
            table.Cell(rowindex, colindex).Range.Font.Bold = bold;
            table.Cell(rowindex, colindex).Range.Font.Name = "verdana";
            table.Cell(rowindex, colindex).Range.Font.Size = fontsize;
            table.Cell(rowindex, colindex).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
        }
        void PrintFormatReceipt()
        {
          /*  try
            {
                //Create an instance for word app  
                Microsoft.Office.Interop.Word.Application winword = new Microsoft.Office.Interop.Word.Application();

                //Set animation status for word application  


                //Set status for word application is to be visible or not.  
                winword.Visible = false;

                //Create a missing variable for missing value  
                object missing = System.Reflection.Missing.Value;

                //Create a new document  
                Microsoft.Office.Interop.Word.Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);

                document.Sections.PageSetup.TopMargin = 30.0f;
                document.Sections.PageSetup.RightMargin = 30.0f;
                document.Sections.PageSetup.LeftMargin = 30.0f;
                //document.SpellingChecked = true;
                //document.DisableFeatures = true;
                document.ShowSpellingErrors = false;
                document.ShowGrammaticalErrors = false;
                //document.Sections[0].PageSetup.Orientation = PageOrientation.Landscape;

                //adding text to document  
                document.Content.SetRange(0, 0);
               
                //Add paragraph with Heading 1 style  
                Microsoft.Office.Interop.Word.Paragraph para1 = document.Content.Paragraphs.Add(ref missing);
                //object styleHeading1 = "Heading 1";
                //para1.Range.set_Style(ref styleHeading1);
                para1.Range.Font.Size = 14F;
                para1.Range.Font.Name = "Arial Black";
                para1.Range.Font.Color = Microsoft.Office.Interop.Word.WdColor.wdColorBlueGray;
                para1.Range.Text = Company;
                para1.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                para1.Range.InsertParagraphAfter();

                Microsoft.Office.Interop.Word.Table firstTable1 = document.Tables.Add(para1.Range, 6, 4, ref missing, ref missing);
                firstTable1.Borders.Enable = 0;
                firstTable1.Rows.HeightRule = Microsoft.Office.Interop.Word.WdRowHeightRule.wdRowHeightExactly;
                //firstTable1.Rows.SetHeight(0.1f,Microsoft.Office.Interop.Word.WdRowHeightRule.wdRowHeightAuto);

                firstTable1.Columns[1].Width = 65f;
                firstTable1.Columns[2].Width = 270f;
                firstTable1.Columns[3].Width = 55f;
                firstTable1.Columns[4].Width = 150f;

                //foreach (Microsoft.Office.Interop.Word.Column col in firstTable1.Columns)
              
               
                AddToCell(firstTable1, 1, 1, 9F, 1, "Address:");
                AddToCell(firstTable1, 1, 2, 9F, 0, Address);
                AddToCell(firstTable1, 1, 3, 9F, 1, "NTN:");
                AddToCell(firstTable1, 1, 4, 9F, 0, NTN);
                AddToCell(firstTable1, 2, 1, 9F, 1, "Mobile:");
                AddToCell(firstTable1, 2, 2, 9F, 0, Phone);
                AddToCell(firstTable1, 2, 3, 9F, 1, "STN:");
                AddToCell(firstTable1, 2, 4, 9F, 0, STN);
                AddToCell(firstTable1, 3, 1, 7F, 0, " ");
                AddToCell(firstTable1, 4, 1, 9F, 1, "Customer:");
                AddToCell(firstTable1, 4, 2, 9F, 0, cname.SelectedItem.ToString());
                AddToCell(firstTable1, 4, 3, 9F, 1, "Date:");
                AddToCell(firstTable1, 4, 4, 9F, 0, FrmDate.Value.ToShortDateString());
                AddToCell(firstTable1, 5, 1, 9F, 1, "Address:");
                AddToCell(firstTable1, 5, 2, 9F, 0, CAddress.Text);
                AddToCell(firstTable1, 5, 3, 9F, 1, "CNIC:");
                if (printcnic.Checked)
                {
                    if (cnic.SelectedItem == null)
                    {
                        cnic.SelectedIndex = 0;
                    }
                    AddToCell(firstTable1, 5, 4, 10F, 0, cnic.SelectedItem.ToString());
                }
                AddToCell(firstTable1, 6, 1, 9F, 1, "Status:");
                AddToCell(firstTable1, 6, 2, 9F, 0, Status.Text);
                AddToCell(firstTable1, 6, 3, 9F, 1, "Invoice:");
                AddToCell(firstTable1, 6, 4, 9F, 0, Invoice.Text);
                //para1.Range.InsertBreak(ref missing);

                Microsoft.Office.Interop.Word.Paragraph para2 = document.Content.Paragraphs.Add(ref missing);
                para2.Range.Text = " ";
                para2.Range.InsertParagraphAfter();

               Microsoft.Office.Interop.Word.Table firstTable = document.Tables.Add(para2.Range, listView1.Items.Count+2, 9, ref missing, ref missing);
               firstTable.Borders.Enable = 0;
               firstTable.Columns[1].Width = 25f;
               firstTable.Columns[2].Width = 118f;
               firstTable.Columns[3].Width = 65f;
               firstTable.Columns[4].Width = 55f;
               firstTable.Columns[5].Width = 55f;
               firstTable.Columns[6].Width = 55f;
               firstTable.Columns[7].Width = 55f;
               firstTable.Columns[8].Width = 65f;
               firstTable.Columns[9].Width = 58f;

               
               firstTable.Rows[1].Cells.Shading.BackgroundPatternColor = Microsoft.Office.Interop.Word.WdColor.wdColorGray25;
               firstTable.Rows[1].Cells.VerticalAlignment = Microsoft.Office.Interop.Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
               firstTable.Rows.HeightRule = Microsoft.Office.Interop.Word.WdRowHeightRule.wdRowHeightAuto;
               firstTable.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;

               AddToCell(firstTable, 1, 1, 9f, 1, "Sr.");
               AddToCell(firstTable, 1, 2, 9f, 1, "Product");
               AddToCell(firstTable, 1, 3, 9f, 1, "Pack");
               AddToCell(firstTable, 1, 4, 9f, 1, "R.Pr");
               AddToCell(firstTable, 1, 5, 9f, 1, "Qty.");
               AddToCell(firstTable, 1, 6, 9f, 1, "T.Pr");
               AddToCell(firstTable, 1, 7, 9f, 1, "T.V(I.S)");
               AddToCell(firstTable, 1, 8, 9f, 1, "S.T@" + SaleTax.ToString()+"%");
               AddToCell(firstTable, 1, 9, 9f, 1, "S.Tax");
               
               int count = 1;
               int rowindx = 2;
               foreach (ListViewItem item in listView1.Items)
               {
                   //for (int j = 1; j <= 9; j++)
                   //foreach (Microsoft.Office.Interop.Word.Cell cell in firstTable.Rows[count+1].Cells)
                   {
                      AddToCell(firstTable, rowindx, 1, 8.5f, 0, count.ToString());
                      AddToCell(firstTable, rowindx, 2, 8.5f, 0, item.SubItems[0].Text);
                      AddToCell(firstTable, rowindx, 3, 8.5f, 0, item.SubItems[1].Text);
                      AddToCell(firstTable, rowindx, 4, 8.5f, 0, item.SubItems[2].Text);
                      AddToCell(firstTable, rowindx, 5, 8.5f, 0, item.SubItems[3].Text);
                      AddToCell(firstTable, rowindx, 6, 8.5f, 0, item.SubItems[4].Text);
                      AddToCell(firstTable, rowindx, 7, 8.5f, 0, item.SubItems[5].Text);
                      AddToCell(firstTable, rowindx, 8, 8.5f, 0, item.SubItems[6].Text);
                      AddToCell(firstTable, rowindx, 9, 8.5f, 0, item.SubItems[7].Text);
                      count += 1;
                      rowindx += 1;
                   }
               }

               firstTable.Rows[rowindx].Cells[5].Borders.Enable = 1;
               firstTable.Rows[rowindx].Cells[7].Borders.Enable = 1;
               firstTable.Rows[rowindx].Cells[9].Borders.Enable = 1;
               //firstTable.Rows[rowindx].Borders.JoinBorders = false;
               //firstTable.Rows[rowindx].Cells[5].Range.Font.Italic = 1;
               //firstTable.Rows[rowindx].Cells[7].Range.Font.Italic = 1;
               //firstTable.Rows[rowindx].Cells[9].Range.Font.Italic = 1;
               //firstTable.Rows[rowindx].Cells[5].Shading.BackgroundPatternColor = Microsoft.Office.Interop.Word.WdColor.wdColorGray25;
               //firstTable.Rows[rowindx].Cells[7].Shading.BackgroundPatternColor = Microsoft.Office.Interop.Word.WdColor.wdColorGray25;
               //firstTable.Rows[rowindx].Cells[9].Shading.BackgroundPatternColor = Microsoft.Office.Interop.Word.WdColor.wdColorGray25;
               rowindx += 1;
               AddToCell(firstTable, rowindx, 4, 9f, 1, "Total:");
               AddToCell(firstTable, rowindx, 5, 8.5f, 1, Qty.Text);
               AddToCell(firstTable, rowindx, 7, 8.5f, 1, GrandTotal.Text);
               AddToCell(firstTable, rowindx, 9, 8.5f, 1, GrandTax.Text);

               Microsoft.Office.Interop.Word.Paragraph para3 = document.Content.Paragraphs.Add(ref missing);
               para3.Range.Text = " ";
               para3.Range.InsertParagraphAfter();

               Microsoft.Office.Interop.Word.Table firstTable2 = document.Tables.Add(para2.Range, 4, 3, ref missing, ref missing);
               firstTable2.Borders.Enable = 0;
               firstTable2.Rows[1].Cells.VerticalAlignment = Microsoft.Office.Interop.Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
               firstTable2.Rows.HeightRule = Microsoft.Office.Interop.Word.WdRowHeightRule.wdRowHeightAuto;
               firstTable2.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
               firstTable2.Columns[1].Width = 310f;
               firstTable2.Columns[2].Width = 125f;
               firstTable2.Columns[3].Width = 140;

               AddToCell(firstTable2, 1, 2, 10f, 1, "Sales Tax Inc.");
               AddToCell(firstTable2, 1, 3, 10f, 0, GrandTax.Text);
               AddToCell(firstTable2, 2, 2, 10f, 1, "Payable Amount.");
               AddToCell(firstTable2, 2, 3, 10f, 0, GrandTotal.Text);
               if (unpaid.Text == "")
                   unpaid.Text = "0";
               AddToCell(firstTable2, 3, 2, 10f, 1, "Prev. Bill.");
               AddToCell(firstTable2, 3, 3, 10f, 0, unpaid.Text);
               AddToCell(firstTable2, 4, 1, 10f, 1, "\tCustomer Sig.");
               AddToCell(firstTable2, 4, 2, 10f, 1, "Net Payable.");
               double NetPayable = GetDecimal(GrandTotal.Text) + GetDecimal(unpaid.Text);
               AddToCell(firstTable2, 4, 3, 10f, 0, NetPayable.ToString());

               Microsoft.Office.Interop.Word.Paragraph para4 = document.Content.Paragraphs.Add(ref missing);
               para4.Range.Text = " ";
               para4.Range.InsertParagraphAfter();

               Microsoft.Office.Interop.Word.Table firstTable3 = document.Tables.Add(para2.Range, 3, 2, ref missing, ref missing);
               firstTable2.Borders.Enable = 0;
               firstTable3.Rows[1].Cells.VerticalAlignment = Microsoft.Office.Interop.Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
               firstTable3.Rows.HeightRule = Microsoft.Office.Interop.Word.WdRowHeightRule.wdRowHeightExactly;
               firstTable3.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
               //firstTable3.Range.Font.Size = 10.5f;
               firstTable3.Range.Font.Color = Microsoft.Office.Interop.Word.WdColor.wdColorBlueGray;
               firstTable3.Columns[1].Width = 40f;
               firstTable3.Columns[2].Width = 550f;
               AddToCell(firstTable3, 1, 1, 8.5f, 1, "Note:");
               AddToCell(firstTable3, 2, 2, 8.5f, 0, "No Expiry Claim will be Compensated.");
               AddToCell(firstTable3, 3, 2, 8.5f, 0, "Distribution is not responsible for any personal matter between Sales Staff and Customer.");
                
              
                //Save the document  
               string dir = Application.StartupPath + "/" + FrmDate.Value.ToLongDateString();
               string dt = dir + "/" + Invoice.Text + ".doc";
            
               DirectoryInfo di = new DirectoryInfo(dir);
               if (!di.Exists)
                   di.Create();
                object filename = dt;
                document.SaveAs(ref filename);
                document.Close(ref missing, ref missing, ref missing);
                document = null;
                winword.Quit(ref missing, ref missing, ref missing);
                winword = null;
                object readOnly = true;
                object isVisible = true;
                //object missing1 = System.Reflection.Missing.Value;
                Microsoft.Office.Interop.Word.Application wrd = new Microsoft.Office.Interop.Word.Application { Visible = true };
                Microsoft.Office.Interop.Word.Document doc = wrd.Documents.Open(filename, ReadOnly: readOnly, Visible: isVisible);
                //MessageBox.Show("Document created successfully !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  */
        }

        private void cname_TextChanged(object sender, EventArgs e)
        {
            if (cname.Text != "" && cname.SelectedItem == null)
            {
                string strSQL = "Select ID,CustomerName,Phone from Customer where CustomerName like '"+ cname.Text +"%'";
                CustomerNameslist.Items.Clear();
                CustomerNameslist.BringToFront();
                //Customer.SendToBack();
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    OleDbCommand command = new OleDbCommand(strSQL, connection);
                    try
                    {
                        connection.Open();
                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            
                            while(reader.Read())
                            {
                               
                                CustomerNameslist.Items.Add( reader[0].ToString() +"-"+ reader[1].ToString() + " | " + reader[2].ToString());
                            }
                            if (reader.HasRows)
                            {
                                CustomerNameslist.Visible = true;
                            }
                            else
                                CustomerNameslist.Visible = false;
                           
                        }
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                
            
            }
            else
                CustomerNameslist.Visible = false;

        }

        private void CustomerNameslist_SelectedValueChanged(object sender, EventArgs e)
        {

            string[] ids = CustomerNameslist.SelectedItem.ToString().Split('-');
            string strSQL = "Select CNIC, CustomerName, Phone from Customer where ID=" + ids[0];
            CustId = ids[0];
           
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand command = new OleDbCommand(strSQL, connection);
                try
                {
                    //cnic.Items.Clear();
                    Refresh();
                    connection.Open();
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        cname.Items.Clear();
                        while (reader.Read())
                        {
                            CNIC.Text = reader[0].ToString();
                            cname.Items.Add(reader[1].ToString());
                            CPhone.Text = reader[2].ToString(); 
                        }
                        cname.SelectedIndex = 0;

                        DataRecordBind("select CustomerName,Phone,Address,Address, Type, FromDate, ToDate, RentDate,Cust_Place.Rent,Advance,PreviousAmount, Status from Cust_Place_Rent where CNIC='" + CNIC.Text + "' and Status=1");  
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                connection.Close();
                CustomerNameslist.Visible = false;
            }
        }

        private void pname_TextChanged(object sender, EventArgs e)
        {
            if (pname.Text != "" && pname.SelectedItem == null)
            {
                string strSQL = "Select ID,Address from Place where Address like '" + pname.Text + "%'";
                PropertyNameList.Items.Clear();
                PropertyNameList.BringToFront();
                //Customer.SendToBack();
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
                                PropertyNameList.Items.Add(reader[0].ToString() + "-" + reader[1].ToString());
                            }
                            if (reader.HasRows)
                            {
                                PropertyNameList.Visible = true;
                            }
                            else
                                PropertyNameList.Visible = false;

                        }
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                       // MessageBox.Show(ex.Message);
                    }
                }


            }
            else
                CustomerNameslist.Visible = false;
        }

        private void PropertyNameList_SelectedValueChanged(object sender, EventArgs e)
        {
            string[] ids = PropertyNameList.SelectedItem.ToString().Split('-');
            string strSQL = "select Address,Type,Rent,Area,Rooms from Place where Id=" + ids[0];
            PlaceId = ids[0];
        
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand command = new OleDbCommand(strSQL, connection);
                try
                {
                    connection.Open();
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        pname.Items.Clear();
                        while (reader.Read())
                        {
                            pname.Items.Add(reader[0].ToString());
                            Type.Text = reader[1].ToString();
                            rent.Text = reader[2].ToString();
                            Area.Text = reader[3].ToString();
                            rooms.Text = reader[4].ToString();
                        }
                        pname.SelectedIndex = 0;
                            GetAlreadyRentedPropertyInfo(ids[0]);

                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                connection.Close();
                PropertyNameList.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pname.SelectedItem != null && cname.SelectedItem != null && CustPlaceId != "")
            {
                DialogResult dr = MessageBox.Show("Are You Sure to Upadte Rent Info?", "Warning!", MessageBoxButtons.YesNo);
                if (dr == System.Windows.Forms.DialogResult.No)
                    return;
                string act = "0";
                if (Active.Checked)
                    act = "1";
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    try
                    {
                        string strSQL7 = "Update Cust_Place SET FromDate='" + FrmDate.Value.ToShortDateString() + "',ToDate='" + ToDate.Value.ToShortDateString() + "',RentDate='" + PayDate.Value.ToString() + "',Rent='" + RentFinal.Text + "',PreviousAmount='" + Unpaid.Text + "',Advance='" + Advanced.Text + "',Status='" + act + "' where id=" + CustPlaceId + "";
                        OleDbCommand command = new OleDbCommand(strSQL7, connection);
                        command.ExecuteReader();
                    }
                    catch (Exception ex)
                    { MessageBox.Show(ex.ToString()); return; }
                    connection.Close();
                }
            }
            else
                MessageBox.Show("Please Select Renter and Property!", "Error!", MessageBoxButtons.OK);
            CustPlaceId = "";
            PlaceId = "";
            CustId = "";
            Refresh();
            DataRecordBind("select CustomerName,Phone,Address,Address, Type, FromDate, ToDate, RentDate,Cust_Place.Rent,Advance,PreviousAmount, Status from Cust_Place_Rent where CNIC='" + CNIC.Text + "' and Status=1"); 
        }

       

       
    }
}
