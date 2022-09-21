using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace InventoryManagementSystem
{
    public partial class Transfer : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U753JSI;Initial Catalog=INV;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public Transfer()
        {
            InitializeComponent();
            LoadStores();
            //LoadStorage();

        }

        public void LoadStores()
        {
            //int i = 0;
            dgvTransferSide.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tblStore", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
               // i++;
                dgvTransferSide.Rows.Add(dr[0], dr[2].ToString()+" "+dr[1].ToString());
            }
            dr.Close();
            con.Close();
        }

     

        private void dgvTransferSide_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void txtStore_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnReceiving_Click(object sender, EventArgs e)
        {
            new ReceivingModule().ShowDialog();


        }

       // List<string> selected_items = new List<string>();


        private void btnTransfer_Click(object sender, EventArgs e)
        {
            List<CommonValue> CV = new List<CommonValue>();
            foreach(DataGridViewRow item in dgvStorage.Rows)
            {
                if ((bool)item.Cells[8].Value == true)
                {
                    CV.Add(new CommonValue
                    {
                        Item = item.Cells[0].Value.ToString(),
                        Size = item.Cells[1].Value.ToString(),
                        Pattern = item.Cells[2].Value.ToString(),
                        Branding_code = item.Cells[3].Value.ToString(),
                        Serial_number = item.Cells[4].Value.ToString(),
                        //Qty = item.Cells[5].Value.ToString(),
                        Log_ID = item.Cells[6].Value.ToString(),
                        Item_ID = item.Cells[7].Value.ToString(),
                        Store_ID = item.Cells[9].Value.ToString()
                        
                        
                    }); 
                  

                }
                  
            }
           

            TransferModule transferModule = new TransferModule();
            transferModule.Values = CV;
            transferModule.ShowDialog();
            
        }

        private void dgvStorage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void dgvTransferSide_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            try
            {
                if (e.RowIndex == -1) return;
                txtStore.Text = dgvTransferSide.Rows[e.RowIndex].Cells[1].Value.ToString();
                //label2.Text = dgvTransferSide.Rows[e.RowIndex].Cells[0].Value.ToString();
                int selected_store_id = int.Parse(dgvTransferSide.Rows[e.RowIndex].Cells[0].Value.ToString());
                // LoadStorage();

                dgvStorage.Rows.Clear();
                cm = new SqlCommand("SELECT A.Store_ID, Item, Size, Pattern,  Branding_code, Serial_number, Quantity, In_stock, Log_ID, A.Item_ID  FROM [INV].[dbo].[tblStorage] A  " +
                    "LEFT JOIN [INV].[dbo].[Item] B  ON A.Item_ID = B.Id  " +
                    "LEFT JOIN [INV].[dbo].[Size] C  ON A.Size_ID = C.Size_ID  " +
                    "LEFT JOIN [INV].[dbo].[Thread_pattern] D  ON A.Thread_pattern_ID = D.Thread_id  " +
                    "LEFT JOIN [INV].[dbo].[Tyre_brand] E  ON A.Tyre_brand_ID = E.Brand_id WHERE In_stock = 1 AND Store_ID = @Store_ID", con);
                cm.Parameters.AddWithValue("@Store_ID", selected_store_id);
                con.Open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    dgvStorage.Rows.Add(dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[8].ToString(), dr[9].ToString(), false, selected_store_id);
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
            
        }

        //List<string> selected_items = new List<string>();


        private void dgvStorage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            label2.Text = dgvStorage.Rows[e.RowIndex].Cells[6].Value.ToString();
           

            if ((bool)dgvStorage.SelectedRows[0].Cells[8].Value == false)
            {
                dgvStorage.SelectedRows[0].Cells[8].Value = true;
            } 
            else
            {
                dgvStorage.SelectedRows[0].Cells[8].Value = false;
            }
            
        }

        private void dgvStorage_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
           
        }

        private void dgvStorage_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            
        }

        
    }
}
