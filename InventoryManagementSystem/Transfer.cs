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
using System.Configuration;


namespace InventoryManagementSystem
{
    public partial class Transfer : Form
    {
        string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

       // SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U753JSI;Initial Catalog=INV;Integrated Security=True");
        //SqlCommand cm = new SqlCommand();
        SqlDataReader dr;

        private int selected_store_id;
        public Transfer()
        {
            InitializeComponent();
            btnReceiving.Enabled = false;
            btnTransfer.Enabled = false;
            LoadStores();
            //LoadStorage();

        }

        public void LoadStores()
        {
            dgvTransferSide.Rows.Clear();
            
            using (var connection = new SqlConnection(connStr))
            {
                connection.Open();

                using (var command = new SqlCommand("SELECT [Store_ID] ,[Code],[Designation] ,[Name] ,[Type] ,[Remark] ,[Location]  FROM [dbo].[KLConnect 247INVENTORY$Store] ", connection))
                {
                    dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        dgvTransferSide.Rows.Add(dr[0], dr[2].ToString() + " " + dr[1].ToString() + " " + dr[3].ToString());
                    }
                    dr.Close(); 
                } 
            }

        }

        public void LoadStorage(int selected_store)
        {
            dgvStorage.Rows.Clear();
            using (var connection = new SqlConnection(connStr))
            {
                connection.Open();
                using (var command = new SqlCommand("EXEC [dbo].[KLCONNECT 247INVENTORY$SP_STORAGE_DISPLAY] @Store_ID = @Store_ID", connection))
                {
                    command.Parameters.AddWithValue("@Store_ID", selected_store);
                    dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        dgvStorage.Rows.Add(dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[8].ToString(), dr[9].ToString(), false, selected_store_id, dr[10].ToString());
                    }
                    dr.Close();

                }
            }

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
                        Store_ID = item.Cells[9].Value.ToString(),
                        Size_ID = item.Cells[10].Value.ToString()
                        
                        
                    }); 
                  

                }
                  
            }
           

            TransferModule transferModule = new TransferModule(this, selected_store_id);
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

                btnReceiving.Enabled = true;

                //ReceivingModule receivingModule = new ReceivingModule();

                txtStore.Text = dgvTransferSide.Rows[e.RowIndex].Cells[1].Value.ToString();
                //label2.Text = dgvTransferSide.Rows[e.RowIndex].Cells[0].Value.ToString();
                selected_store_id = int.Parse(dgvTransferSide.Rows[e.RowIndex].Cells[0].Value.ToString());

                LoadStorage(selected_store_id);

                /*
                dgvStorage.Rows.Clear();
                using(var connection = new SqlConnection(connStr))
                {
                    connection.Open();
                    using(var command = new SqlCommand("EXEC [dbo].[KLCONNECT 247INVENTORY$SP_STORAGE_DISPLAY] @Store_ID = @Store_ID", connection))
                    {
                        command.Parameters.AddWithValue("@Store_ID", selected_store_id);
                        dr = command.ExecuteReader();
                        while (dr.Read())
                        {
                            dgvStorage.Rows.Add(dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[8].ToString(), dr[9].ToString(), false, selected_store_id, dr[10].ToString());
                        }
                        dr.Close();

                    }
                } */
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void btnReceiving_Click(object sender, EventArgs e)
        {

            ReceivingModule receivingModule = new ReceivingModule(selected_store_id, this);

            //ReceivingModule.storeid = selected_store_id;
            //receivingModule.storeid = int.Parse(selected_store_id.ToString());
            //receivingModule.lblStore.Text = selected_store_id.ToString();
            //receivingModule.lblStore.Text = store




            receivingModule.ShowDialog();

        }

        //List<string> selected_items = new List<string>();


        private void dgvStorage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            //label2.Text = dgvStorage.Rows[e.RowIndex].Cells[6].Value.ToString();
           

            if ((bool)dgvStorage.SelectedRows[0].Cells[8].Value == false)
            {
                dgvStorage.SelectedRows[0].Cells[8].Value = true;
            } 
            else
            {
                dgvStorage.SelectedRows[0].Cells[8].Value = false;
            }




            foreach (DataGridViewRow item in dgvStorage.Rows)
            {
                if ((bool)item.Cells[8].Value == true)
                {
                    btnTransfer.Enabled = true;
                    break;
                    

                }
                else
                { btnTransfer.Enabled = false; }
            }
                
        }

        private void dgvStorage_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
           
        }

        private void dgvStorage_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text;
            dgvStorage.ClearSelection();
            if (searchValue != string.Empty)
            {
                foreach (DataGridViewRow row in dgvStorage.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().ToUpper().Contains(searchValue))
                        {
                            int rowIndex = row.Index;
                            dgvStorage.Rows[rowIndex].Selected = true;
                            break;
                        }
                    }
                } 
            }

        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
           
        }
    }
}
