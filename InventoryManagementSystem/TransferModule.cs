﻿using System;
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
    public partial class TransferModule : Form
    {
        string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U753JSI;Initial Catalog=INV;Integrated Security=True");
        //SqlCommand cm = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        private readonly Transfer transfer;
        private int selected_store_id;

        public TransferModule(Transfer TF, int store_id)
        {
            InitializeComponent();
            transfer = TF;
            selected_store_id = store_id;
                
                     
           //cBoxReceiver.SelectedItem = null;

            using(var connection = new SqlConnection(connStr))
            {
                connection.Open();
                using (var command = new SqlCommand("SELECT [Store_ID],[Code] ,[Designation] ,[Name],[Type] ,[Remark] ,[Location] FROM [dbo].[KLConnect 247INVENTORY$Store]", connection))
                {
                    da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dt.Columns.Add("comboname", typeof(string), "Code + ' '+ Name");//create new column with combined names
                    cBoxReceiver.DataSource = dt;
                    cBoxReceiver.ValueMember = "Store_Id";
                    cBoxReceiver.DisplayMember = "comboname";
                    cBoxReceiver.SelectedIndex = -1;
                }
            }
            
                      
            
        }

        public List<CommonValue> Values { get; set; } 

        public void AddToGrid(List<CommonValue> val)
        {
            if (val != null)
            {
                foreach (CommonValue item in val)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item.Item;
                    dataGridView1.Rows[n].Cells[1].Value = item.Size;
                    dataGridView1.Rows[n].Cells[2].Value = item.Pattern;
                    dataGridView1.Rows[n].Cells[3].Value = item.Branding_code;
                    dataGridView1.Rows[n].Cells[4].Value = item.Serial_number;
                    //dataGridView1.Rows[n].Cells[5].Value = item.Qty;
                    dataGridView1.Rows[n].Cells[6].Value = item.Log_ID;
                    dataGridView1.Rows[n].Cells[7].Value = item.Item_ID;
                    dataGridView1.Rows[n].Cells[8].Value = item.Store_ID;
                    dataGridView1.Rows[n].Cells[9].Value = item.Size_ID;
                } 
            }
        }

        public void UpdateDatabase()
        {
           
               
                foreach(DataGridViewRow item in dataGridView1.Rows)
                {

                using (var connection = new SqlConnection(connStr))
                {
                    connection.Open();
                    if (item.Cells[7].Value.ToString() == "1" || item.Cells[7].Value.ToString() == "2" ) // when tyres are selected
                    {
                        if (rbInternal.Checked) //for internal transfer of tyres
                        {
                            //cm = new SqlCommand("EXEC [dbo].[SP_STORAGE_TYRE_INTERNAL_TRANSFER] @Log_ID = @Log_ID, @Document = @Document, @Store_ID = @Store_ID;", con);
                            using (var command = new SqlCommand("EXEC [dbo].[KLCONNECT 247INVENTORY$SP_STORAGE_TYRE_INTERNAL_TRANSFER] @Log_ID = @Log_ID, @Document = @Document, @Store_ID = @Store_ID, @Date_log = @Date_log;", connection))
                            {
                                command.Parameters.AddWithValue("@Store_ID", cBoxReceiver.SelectedValue);
                                command.Parameters.AddWithValue("@Document", txtDoc.Text);
                                command.Parameters.AddWithValue("@Log_ID", item.Cells[6].Value);
                                command.Parameters.AddWithValue("@Date_log", dateTransfer.Value.Date);
                                command.ExecuteNonQuery();
                            }
                        }

                        if (rbExternal.Checked) //for external transfer of tyres
                        {
                           // cm = new SqlCommand("EXEC [dbo].[SP_STORAGE_TYRE_EXTERNAL_TRANSFER] @Client = @Client, @Vehicle = @Vehicle, @Document = @Document, @Log_ID = @Log_ID  ", con);
                            using (var command = new SqlCommand("EXEC [dbo].[KLCONNECT 247INVENTORY$SP_STORAGE_TYRE_EXTERNAL_TRANSFER] @Client = @Client, @Vehicle = @Vehicle, @Document = @Document, @Log_ID = @Log_ID, @Date_log = @Date_log;  ", connection))
                            {
                                command.Parameters.AddWithValue("@Client", txtExternal.Text);
                                command.Parameters.AddWithValue("@Vehicle", txtVehicle.Text);
                                command.Parameters.AddWithValue("@Document", txtDoc.Text);
                                command.Parameters.AddWithValue("@Log_ID", item.Cells[6].Value);
                                command.Parameters.AddWithValue("@Date_log", dateTransfer.Value.Date);
                                command.ExecuteNonQuery ();
                            }
                        }
                    }
                    else //accessories selected
                    {
                        if (rbInternal.Checked)  //internal transfer of accessories
                        {
                           // cm = new SqlCommand("EXEC [dbo].[SP_STORAGE_ACC_INTERNAL_TRANSFER] @Store_ID = @Store_ID, @Item_ID = @Item_ID, @Size_ID = @Size_ID, @Document = @Document, @Quantity = @Quantity, @Log_ID = @Log_ID; ", con);
                            using (var command = new SqlCommand("EXEC [dbo].[KLCONNECT 247INVENTORY$SP_STORAGE_ACC_INTERNAL_TRANSFER] @Store_ID = @Store_ID, @Item_ID = @Item_ID, @Size_ID = @Size_ID, @Document = @Document, @Quantity = @Quantity, @Log_ID = @Log_ID, @Date_log = @Date_log; ", connection))
                            {
                                command.Parameters.AddWithValue("@Store_ID", cBoxReceiver.SelectedValue);
                                command.Parameters.AddWithValue("@Item_ID", item.Cells[7].Value);
                                command.Parameters.AddWithValue("@Size_ID", item.Cells[9].Value);
                                command.Parameters.AddWithValue("@Quantity", item.Cells[5].Value == null ? 1 : item.Cells[5].Value); // by default dgv cell value is null, hence usiing conditional operator 
                                command.Parameters.AddWithValue("@Log_ID", item.Cells[6].Value);
                                command.Parameters.AddWithValue("@Document", txtDoc.Text);
                                command.Parameters.AddWithValue("@Date_log", dateTransfer.Value.Date);

                                command.ExecuteNonQuery();
                            }
                        }

                        if (rbExternal.Checked) //external transfer of accessories
                        {
                           // cm = new SqlCommand("EXEC [dbo].[SP_STORAGE_ACC_EXTERNAL_TRANSFER] @Quantity= @Quantity, @Client = @Client, @Vehicle = @Vehicle, @Document = @Document, @Log_ID = @Log_ID ", con);
                            using (var command = new SqlCommand("EXEC [dbo].[KLCONNECT 247INVENTORY$SP_STORAGE_ACC_EXTERNAL_TRANSFER] @Quantity= @Quantity, @Client = @Client, @Vehicle = @Vehicle, @Document = @Document, @Log_ID = @Log_ID, @Date_log = @Date_log ;", connection))
                            {
                                command.Parameters.AddWithValue("@Quantity", item.Cells[5].Value == null ? 1 : item.Cells[5].Value);
                                command.Parameters.AddWithValue("@Client", txtExternal.Text);
                                command.Parameters.AddWithValue("@Vehicle", txtVehicle.Text);
                                command.Parameters.AddWithValue("@Document", txtDoc.Text);
                                command.Parameters.AddWithValue("@Log_ID", item.Cells[6].Value);
                                command.Parameters.AddWithValue("@Date_log", dateTransfer.Value.Date);

                                command.ExecuteNonQuery();
                            }
                        }
                    } 
                }

                   


                }
            
        }

        private void storeFormBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void TransferModule_Load(object sender, EventArgs e)
        {
            AddToGrid(Values);
            

        }

        private void cBoxReceiver_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*  if (cBoxReceiver.SelectedValue.ToString() == null)
                  label6.Text = "none selected";
              else
                  label6.Text = cBoxReceiver.SelectedValue.ToString();
            */

            //label6.Text = cBoxReceiver.Text;
        }

        public void Clear()
        {
            cBoxReceiver.Text = string.Empty;   
            cBoxReceiver.SelectedIndex = -1;

            txtVehicle.Clear();
            txtDoc.Clear();
            txtExternal.Clear();
            //dataGridView1.Rows.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void txtVehicle_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtDoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateDatabase();
                MessageBox.Show("Items have been transferred");
                dataGridView1.Rows.Clear();
                this.Dispose();
                transfer.LoadStorage(selected_store_id);

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbInternal_CheckedChanged(object sender, EventArgs e)
        {
            cBoxReceiver.Enabled = true;
            txtExternal.Enabled = false;
            txtExternal.Clear();
            txtVehicle.Enabled = false;
            txtVehicle.Clear();
            label7.Hide();
        }

        private void rbExternal_CheckedChanged(object sender, EventArgs e)
        {
            cBoxReceiver.Enabled = false;
            cBoxReceiver.Text = "";
            txtExternal.Enabled = true;
            txtVehicle.Enabled = true;
            label7.Show();
        }

        private void cBoxReceiver_KeyPress(object sender, KeyPressEventArgs e)
        {
          //  e.KeyChar = (char)Keys.None;
        }

        private void txtDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            e.Handled = (e.KeyChar == (char)Keys.Space);


        }

        private void txtVehicle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }
    }
}
