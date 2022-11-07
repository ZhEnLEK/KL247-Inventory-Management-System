using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using Microsoft.Office.Interop;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Net;
using System.Configuration;


namespace InventoryManagementSystem
{
    public partial class ReceivingModule : Form
    {
        string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U753JSI;Initial Catalog=INV;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlCommand cm1 = new SqlCommand();
        SqlCommand cm2 = new SqlCommand();
        SqlCommand cm3 = new SqlCommand();
           
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataAdapter da1 = new SqlDataAdapter();
        SqlDataAdapter da2 = new SqlDataAdapter();


        // public static string storeid = "";
        private int Store_ID;
        

        public ReceivingModule(int storeid)
        {
            InitializeComponent();


            using (var connection = new SqlConnection(connStr))
            {
                connection.Open();

                //cm = new SqlCommand("SELECT * FROM [dbo].[Item]", con);
                //con.Open();
                using (var command = new SqlCommand("SELECT * FROM [dbo].[KLConnect 247INVENTORY$Item]", connection))
                {
                    da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cBoxItem.ValueMember = "Id";
                    cBoxItem.DisplayMember = "Item";
                    cBoxItem.DataSource = dt; 
                }


                //cm1 = new SqlCommand("SELECT * FROM [INV].[dbo].[tblStore] WHERE Store_ID = @Store_ID", con);

                using (var command = new SqlCommand("SELECT * FROM [dbo].[KLConnect 247INVENTORY$Store] WHERE Store_ID = @Store_ID", connection))
                {
                    command.Parameters.AddWithValue("@Store_ID", storeid);
                    command.ExecuteNonQuery();
                    da1 = new SqlDataAdapter(command);
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);

                    lblStoreName.Text = dt1.Rows[0][2].ToString() +" "+ dt1.Rows[0][1].ToString();

                }

                //lblStore2.Text = dt1.Rows[0][1].ToString();

                Store_ID = storeid;

                //lblStore.Text = storeid.ToString();

               // cm2 = new SqlCommand("SELECT * FROM [dbo].[Tyre_brand]", con);
                //con.Open();

                using (var command = new SqlCommand("SELECT * FROM [dbo].[KLConnect 247INVENTORY$Tyre_brand]", connection))
                {
                    da2 = new SqlDataAdapter(command);
                    DataTable dt2 = new DataTable();
                    da2.Fill(dt2);
                    cBoxBrand.ValueMember = "Brand_id";
                    cBoxBrand.DisplayMember = "Brand";
                    cBoxBrand.DataSource = dt2;  
                }
            }
            
        }
          
      

        
        private void ReceivingModule_Load(object sender, EventArgs e)
        {
          
        }
            

     

        private void dgvReceiving_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvReceiving_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void cBoxItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cBoxItem.SelectedIndex = -1;
           // if(cBoxItem.SelectedValue.ToString() != null)
            
              //  cm = new SqlCommand("SELECT * FROM [dbo].[Size] WHERE Item_ID = @Item_ID", con);
               // cm.Parameters.AddWithValue("@Item_ID", cBoxItem.SelectedValue.ToString());
            //con.Open();
            using (var connection = new SqlConnection(connStr))
            {
                connection.Open();

                using (var command = new SqlCommand("SELECT * FROM [dbo].[KLConnect 247INVENTORY$Size] WHERE Item_ID = @Item_ID", connection))
                {
                    command.Parameters.AddWithValue("@Item_ID", cBoxItem.SelectedValue.ToString());
                    da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cBoxSize.ValueMember = "Size_ID";
                    cBoxSize.DisplayMember = "Size";
                    cBoxSize.DataSource = dt;

                   // label11.Text = cBoxItem.SelectedValue.ToString();
                   // label12.Text = cBoxItem.GetItemText(cBoxItem.SelectedItem);  
                }
            }

            
            
            if(cBoxItem.SelectedValue.ToString() == "1" || cBoxItem.SelectedValue.ToString() == "2" || cBoxItem.SelectedValue.ToString() == "3")
            {
                cBoxBrand.Enabled = true;
                cBoxPattern.Enabled = true;
                txtBrandingCode.Enabled = true;
                txtSerial.Enabled = true; 
            }

            else
            {
                cBoxBrand.Text = "";
                cBoxBrand.Enabled = false;
                //cBoxBrand.ResetText();
                //cBoxBrand.SelectedIndex = -1;
                //cBoxPattern.SelectedValue = 44;
                cBoxPattern.Text = "";
                cBoxPattern.Enabled = false;
                //cBoxPattern.SelectedIndex = -1;
                txtBrandingCode.Clear();
                txtBrandingCode.Enabled = false;
                txtSerial.Clear();
                txtSerial.Enabled = false;
            }
            

        }

        private void cBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(cBoxBrand.SelectedValue.ToString() != null)

            using (var connection = new SqlConnection(connStr))
            {
                connection.Open();

                using (var command = new SqlCommand("SELECT * FROM [dbo].[KLConnect 247INVENTORY$Thread_pattern] WHERE Brand_id = @Brand_id", connection))
                {
                    //cm2 = new SqlCommand("SELECT * FROM [dbo].[Thread_pattern] WHERE Brand_id = @Brand_id", con);
                    command.Parameters.AddWithValue("@Brand_id", cBoxBrand.SelectedValue.ToString());
                    //con.Open();
                    da2 = new SqlDataAdapter(command);
                    DataTable dt2 = new DataTable();
                    da2.Fill(dt2);
                    cBoxPattern.ValueMember = "Thread_ID";
                    cBoxPattern.DisplayMember = "Pattern";
                    cBoxPattern.DataSource = dt2;  
                }
            }
                
            
        }


        private void btnPreview_Click(object sender, EventArgs e)
        {
           // dgvReceiving.Rows.Clear();
            if (cBoxItem.SelectedValue.ToString() == "1" || cBoxItem.SelectedValue.ToString() == "3")
                dgvReceiving.Rows.Add( null, dateReceiving.Value.Date, txtBrandingCode.Text, txtSerial.Text, cBoxItem.GetItemText(cBoxItem.SelectedItem), cBoxBrand.GetItemText(cBoxBrand.SelectedItem), cBoxPattern.GetItemText(cBoxPattern.SelectedItem), cBoxSize.GetItemText(cBoxSize.SelectedItem), qtyBox.Text,   txtDoc.Text);
           // dgvReceiving.Rows.Add(xlrow - 1, xlrange.Cells[xlrow, 1].Text, xlrange.Cells[xlrow, 2].Text, xlrange.Cells[xlrow, 3].Text, xlrange.Cells[xlrow, 4].Text, xlrange.Cells[xlrow, 5].Text, xlrange.Cells[xlrow, 6].Text, xlrange.Cells[xlrow, 7].Text, null, xlrange.Cells[xlrow, 8].Text);

            else
                dgvReceiving.Rows.Add( null,dateReceiving.Value.Date, "", "", cBoxItem.GetItemText(cBoxItem.SelectedItem), "", "", cBoxSize.GetItemText(cBoxSize.SelectedItem), qtyBox.Text, txtDoc.Text);

        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            try
            //for (int i = 1; i <= dgvReceiving.RowCount; i++)
            {
               // if (cBoxItem.SelectedValue.ToString() == "1" || cBoxItem.SelectedValue.ToString() == "3")
                {
                    for (int i = 0; i < dgvReceiving.RowCount; i++)
                    //int i = 0;
                    {
                        using (var connection = new SqlConnection(connStr))
                        {
                            connection.Open();

                            using (var command = new SqlCommand("EXEC [dbo].[KLCONNECT 247INVENTORY$SP_STORAGE_INSERT_FROM_RECEIVING_MODULE] @Date_in = @Date_in, @Branding_code = @Branding_code, @Item = @Item, @Size = @Size, @Brand = @Brand, @Pattern = @Pattern, @Serial_number = @Serial_number, @Document = @Document, @Store_ID = @Store_ID, @Quantity = @Quantity, @In_stock = @In_stock;  ", connection))
                            {
                                //cm3 = new SqlCommand("EXEC [dbo].[SP_STORAGE_INSERT_FROM_RECEIVING_MODULE] @Date_in = @Date_in, @Branding_code = @Branding_code, @Item = @Item, @Size = @Size, @Brand = @Brand, @Pattern = @Pattern, @Serial_number = @Serial_number, @Document = @Document, @Store_ID = @Store_ID, @Quantity = @Quantity, @In_stock = @In_stock;  ", con);
                                command.Parameters.AddWithValue("@Date_in", DateTime.Parse(dgvReceiving.Rows[i].Cells[1].Value.ToString()));
                                command.Parameters.AddWithValue("@Branding_code", dgvReceiving.Rows[i].Cells[2].Value.ToString());
                                command.Parameters.AddWithValue("@Item", dgvReceiving.Rows[i].Cells[4].Value.ToString());
                                command.Parameters.AddWithValue("@Size", dgvReceiving.Rows[i].Cells[7].Value.ToString());
                                command.Parameters.AddWithValue("@Brand", dgvReceiving.Rows[i].Cells[5].Value.ToString());
                                command.Parameters.AddWithValue("@Pattern", dgvReceiving.Rows[i].Cells[6].Value.ToString());
                                command.Parameters.AddWithValue("@Serial_number", dgvReceiving.Rows[i].Cells[3].Value.ToString());
                                command.Parameters.AddWithValue("@Quantity", dgvReceiving.Rows[i].Cells[8].Value == null ? 1 : dgvReceiving.Rows[i].Cells[8].Value);
                                command.Parameters.AddWithValue("@Document", dgvReceiving.Rows[i].Cells[9].Value.ToString());
                                command.Parameters.AddWithValue("@In_stock", 1);
                                command.Parameters.AddWithValue("@Store_ID", Store_ID); 

                                command.ExecuteNonQuery();
                            } 
                        }

                        //con.Open();
                        //cm3.ExecuteNonQuery();
                        //con.Close();
                        //MessageBox.Show("Items have been received");
                    }
                }

               



                MessageBox.Show("Items have been received");

                dgvReceiving.Rows.Clear();
                dgvReceiving.Refresh();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvReceiving.Rows.Clear();
            dgvReceiving.Refresh();
        }

        private void btnPreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnReceive_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnClear_MouseHover(object sender, EventArgs e)
        {

        }

        private void lblStore_Click(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Excel Files Only | *.xlsx; *.xls";
                dialog.Title = "Browse";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = dialog.FileName;

                    dgvReceiving.Rows.Clear();
                    dgvReceiving.Refresh();

                    Microsoft.Office.Interop.Excel.Application xlapp;
                    Microsoft.Office.Interop.Excel.Workbook xlworkbook;
                    Microsoft.Office.Interop.Excel.Worksheet xlworksheet;
                    Microsoft.Office.Interop.Excel.Range xlrange;

                    xlapp = new Microsoft.Office.Interop.Excel.Application();
                    xlworkbook = xlapp.Workbooks.Open(textBox1.Text);
                    xlworksheet = xlworkbook.Worksheets["Sheet1"];
                    xlrange = xlworksheet.UsedRange;

                    dgvReceiving.ColumnCount = xlrange.Columns.Count + 2;

                    for (int xlrow = 2; xlrow <= xlrange.Rows.Count; xlrow++)
                    {
                        dgvReceiving.Rows.Add(xlrow - 1, xlrange.Cells[xlrow, 1].Text, xlrange.Cells[xlrow, 2].Text, xlrange.Cells[xlrow, 3].Text, xlrange.Cells[xlrow, 4].Text, xlrange.Cells[xlrow, 5].Text, xlrange.Cells[xlrow, 6].Text, xlrange.Cells[xlrow, 7].Text, null, xlrange.Cells[xlrow, 8].Text);
                    }
                    xlworkbook.Close();
                    xlapp.Quit();
                }
            }
              

        }

        private void btnUpload_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (files != null && files.Any())
                textBox1.Text = files.First();



            dgvReceiving.Rows.Clear();
            dgvReceiving.Refresh();

            Microsoft.Office.Interop.Excel.Application xlapp;
            Microsoft.Office.Interop.Excel.Workbook xlworkbook;
            Microsoft.Office.Interop.Excel.Worksheet xlworksheet;
            Microsoft.Office.Interop.Excel.Range xlrange;
            try
            {
                xlapp = new Microsoft.Office.Interop.Excel.Application();
                xlworkbook = xlapp.Workbooks.Open(textBox1.Text);
                xlworksheet = xlworkbook.Worksheets["Sheet1"];
                xlrange = xlworksheet.UsedRange;

                dgvReceiving.ColumnCount = xlrange.Columns.Count + 2;


                for (int xlrow = 2; xlrow <= xlrange.Rows.Count; xlrow++)
                {
                    dgvReceiving.Rows.Add(xlrow - 1, xlrange.Cells[xlrow, 1].Text, xlrange.Cells[xlrow, 2].Text, xlrange.Cells[xlrow, 3].Text, xlrange.Cells[xlrow, 4].Text, xlrange.Cells[xlrow, 5].Text, xlrange.Cells[xlrow, 6].Text, xlrange.Cells[xlrow, 7].Text, null, xlrange.Cells[xlrow, 8].Text);
                }
                xlworkbook.Close();
                xlapp.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpload_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void btnUpload_MouseHover(object sender, EventArgs e)
        {

        }
               

      
    }
}
