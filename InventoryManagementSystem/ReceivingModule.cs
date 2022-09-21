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

namespace InventoryManagementSystem
{
    public partial class ReceivingModule : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U753JSI;Initial Catalog=INV;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlCommand cm2 = new SqlCommand();
        SqlCommand cm3 = new SqlCommand();
           
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataAdapter da2 = new SqlDataAdapter();

        

        public ReceivingModule()
        {
            InitializeComponent();

            cm = new SqlCommand("SELECT * FROM [dbo].[Item]", con);
            con.Open();
            da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cBoxItem.ValueMember = "Id";
            cBoxItem.DisplayMember = "Item";
            cBoxItem.DataSource = dt;
            

            cm2 = new SqlCommand("SELECT * FROM [dbo].[Tyre_brand]", con);
            //con.Open();
            da2 = new SqlDataAdapter(cm2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            cBoxBrand.ValueMember = "Brand_id";
            cBoxBrand.DisplayMember = "Brand";
            cBoxBrand.DataSource = dt2;



            con.Close();




        }

            

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Excel Files Only | *.xlsx; *.xls";
                dialog.Title = "Browse";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    textBox1.Text = dialog.FileName;
                }
            }

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

                dgvReceiving.ColumnCount = xlrange.Columns.Count;

                for (int xlrow = 2; xlrow <= xlrange.Rows.Count; xlrow++)
                {
                    dgvReceiving.Rows.Add(xlrange.Cells[xlrow, 1].Text, xlrange.Cells[xlrow, 2].Text, xlrange.Cells[xlrow, 3].Text, xlrange.Cells[xlrow, 4].Text, xlrange.Cells[xlrow, 5].Text, xlrange.Cells[xlrow, 6].Text, xlrange.Cells[xlrow, 7].Text, xlrange.Cells[xlrow, 8].Text, xlrange.Cells[xlrow, 9].Text);
                }
                xlworkbook.Close();
                xlapp.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_DragDrop(object sender, DragEventArgs e)
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

                dgvReceiving.ColumnCount = xlrange.Columns.Count; 

                for (int xlrow = 2; xlrow <= xlrange.Rows.Count; xlrow++)
                {
                    dgvReceiving.Rows.Add(xlrange.Cells[xlrow, 1].Text, xlrange.Cells[xlrow, 2].Text, xlrange.Cells[xlrow, 3].Text, xlrange.Cells[xlrow, 4].Text, xlrange.Cells[xlrow, 5].Text, xlrange.Cells[xlrow, 6].Text, xlrange.Cells[xlrow, 7].Text, xlrange.Cells[xlrow, 8].Text, xlrange.Cells[xlrow, 9].Text);
                }
                xlworkbook.Close();
                xlapp.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;

                       
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {

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
            {
                cm = new SqlCommand("SELECT * FROM [dbo].[Size] WHERE Item_ID = @Item_ID", con);
                cm.Parameters.AddWithValue("@Item_ID", cBoxItem.SelectedValue.ToString());
                //con.Open();
                da = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cBoxSize.ValueMember = "Size_ID";
                cBoxSize.DisplayMember = "Size";
                cBoxSize.DataSource = dt;
                //cBoxBrand.Enabled = false;
                //cBoxPattern.Enabled = false;
                // cBoxSize.Enabled = true;
                //con.Close();
                label11.Text = cBoxItem.SelectedValue.ToString();
                label12.Text = cBoxItem.GetItemText(cBoxItem.SelectedItem);

                //cBoxBrand.SelectedIndex = -1;
                //cBoxBrand.SelectedItem = null;
               

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
            {
                cm2 = new SqlCommand("SELECT * FROM [dbo].[Thread_pattern] WHERE Brand_id = @Brand_id", con);
                cm2.Parameters.AddWithValue("@Brand_id", cBoxBrand.SelectedValue.ToString());
                //con.Open();
                da2 = new SqlDataAdapter(cm2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                cBoxPattern.ValueMember = "Thread_ID";
                cBoxPattern.DisplayMember = "Pattern"; 
                cBoxPattern.DataSource = dt2;
                //cBoxBrand.Enabled = false;
                //cBoxPattern.Enabled = false;
                //cBoxSize.Enabled = true;
                con.Close();
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (cBoxItem.SelectedValue.ToString() == "1" || cBoxItem.SelectedValue.ToString() == "2" || cBoxItem.SelectedValue.ToString() == "3")
                dgvReceiving.Rows.Add(txtBrandingCode.Text, dateReceiving.Text, cBoxItem.GetItemText(cBoxItem.SelectedItem), cBoxSize.GetItemText(cBoxSize.SelectedItem), qtyBox.Text, cBoxBrand.GetItemText(cBoxBrand.SelectedItem), cBoxPattern.GetItemText(cBoxPattern.SelectedItem), txtSerial.Text, txtDoc.Text);
            else
                dgvReceiving.Rows.Add("", dateReceiving.Text, cBoxItem.GetItemText(cBoxItem.SelectedItem), cBoxSize.GetItemText(cBoxSize.SelectedItem), qtyBox.Text, "", "", "", txtDoc.Text);

        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            try
            //for (int i = 1; i <= dgvReceiving.RowCount; i++)
            {
                for (int i = 0; i < dgvReceiving.RowCount - 1; i++)
                //int i = 0;
                {
                    cm3 = new SqlCommand("INSERT INTO [INV].[dbo].[tblStorage](Date_in, Date_modified, Branding_code, Item_ID, Size_ID, Tyre_brand_ID, Thread_pattern_ID, Serial_number, Document, Store_ID, Quantity, In_stock) VALUES(@Date_in, @Date_modified, @Branding_code, @Item_ID, @Size_ID, @Tyre_brand_ID, @Thread_pattern_ID, @Serial_number, @Document, @Store_ID, @Quantity, @In_stock) ", con);
                    cm3.Parameters.AddWithValue("@Date_in", DateTime.Now);
                    cm3.Parameters.AddWithValue("@Date_modified", DateTime.Now);
                    cm3.Parameters.AddWithValue("@Branding_code", dgvReceiving.Rows[i].Cells[0].Value.ToString());
                   // cm3.Parameters.AddWithValue("@Date_log", DateTime.Parse(dgvReceiving.Rows[i].Cells[1].Value.ToString())); 
                    cm3.Parameters.AddWithValue("@Item_ID", cBoxItem.SelectedValue.ToString());
                   // cm3.Parameters.AddWithValue("@Transaction_type", "IN");
                    cm3.Parameters.AddWithValue("@Store_ID", 1);
                    //cm3.Parameters.AddWithValue("@Party", "KL247 HQ");
                    cm3.Parameters.AddWithValue("@Quantity", dgvReceiving.Rows[i].Cells[4].Value);
                    cm3.Parameters.AddWithValue("@Size_ID", cBoxSize.SelectedValue.ToString());
                    cm3.Parameters.AddWithValue("@Tyre_brand_ID", cBoxBrand.SelectedValue.ToString());
                    cm3.Parameters.AddWithValue("@Thread_pattern_ID", cBoxPattern.SelectedValue.ToString());
                    cm3.Parameters.AddWithValue("@Serial_number", dgvReceiving.Rows[i].Cells[7].Value.ToString());
                    cm3.Parameters.AddWithValue("@Document", dgvReceiving.Rows[i].Cells[8].Value.ToString());
                    cm3.Parameters.AddWithValue("@In_stock", 1);






                    con.Open();
                    cm3.ExecuteNonQuery();
                    con.Close();
                    //MessageBox.Show("Items have been received");
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
    }
}
