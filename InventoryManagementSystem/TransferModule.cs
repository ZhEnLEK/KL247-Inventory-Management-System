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
    public partial class TransferModule : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U753JSI;Initial Catalog=INV;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        public TransferModule()
        {
            InitializeComponent();

            
            
            cm = new SqlCommand("SELECT * FROM [INV].[dbo].[tblStore]", con);
            con.Open();
            da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cBoxReceiver.DataSource = dt;
            cBoxReceiver.ValueMember = "Id";
            cBoxReceiver.DisplayMember = "Name";

            //cBoxReceiver.SelectedItem = null;
            
                      
            
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
                } 
            }
        }

        public void UpdateDatabase()
        {
           
                //int n = 0;
                //for(int i = 0; i < dataGridView1.RowCount - 1; i++)
                //foreach (CommonValue item in val)
                foreach(DataGridViewRow item in dataGridView1.Rows)
                {

                    //int n = dataGridView1.Rows.Add();
                    if (item.Cells[7].Value.ToString() == "1" || item.Cells[7].Value.ToString() == "2" || item.Cells[7].Value.ToString() == "3")
                    {
                        if (rbInternal.Checked) //for internal transfer of tyres
                        {
                            cm = new SqlCommand("UPDATE [INV].[dbo].[tblStorage] SET Store_ID = @Store_ID WHERE Log_ID = @Log_ID", con);
                            cm.Parameters.AddWithValue("@Store_ID", cBoxReceiver.SelectedValue);
                            cm.Parameters.AddWithValue("@Log_ID", item.Cells[6].Value); 
                        }

                        if(rbExternal.Checked) //for external transfer of tyres
                        {
                            cm = new SqlCommand("UPDATE [INV].[dbo].[tblStorage] SET Quantity = @Quantity, In_stock = @In_stock, Client = @Client, Vehicle = @Vehicle, Document = @Document WHERE Log_ID = @Log_ID ", con);
                            cm.Parameters.AddWithValue("@Quantity", 0);
                            cm.Parameters.AddWithValue("@In_stock", 0);
                            cm.Parameters.AddWithValue("@Client", txtExternal.Text);
                            cm.Parameters.AddWithValue("@Vehicle", txtVehicle.Text);
                            cm.Parameters.AddWithValue("@Document", txtDoc.Text);
                            cm.Parameters.AddWithValue("@Log_ID", item.Cells[6].Value);
                        }
                    }
                    else
                    {
                        if (rbInternal.Checked)  //internal transfer of accessories
                        {
                            cm = new SqlCommand("IF EXISTS (SELECT * FROM [INV].[dbo].[tblStorage] WHERE Store_ID =@Store_ID_Dest AND Item_ID =@Item_ID) " + // REMEMBER TO ADD SIZE ID!!!!
                                " BEGIN UPDATE [INV].[dbo].[tblStorage] SET Quantity +=@Quantity, Date_modified = GETDATE() WHERE Store_ID =@Store_ID_Dest AND Item_ID =@Item_ID;" +
                                "  UPDATE [INV].[dbo].[tblStorage] SET Quantity -=@Quantity, Date_modified = GETDATE() WHERE Log_ID = @Log_ID;  END  ELSE BEGIN " +
                                "  INSERT INTO [INV].[dbo].[tblStorage]([Store_ID], [Date_in], [Quantity], [In_stock], [Date_modified], [Item_ID], [Size_ID], [Document])" +
                                "  SELECT @Store_ID_Dest, GETDATE(), @Quantity, [In_stock], GETDATE(), [Item_ID], [Size_ID],[Document]" +
                                " FROM [INV].[dbo].[tblStorage] WHERE Log_ID = @Log_ID;" +
                                "  UPDATE [INV].[dbo].[tblStorage] SET Quantity -=@Quantity, Date_modified = GETDATE() WHERE Log_ID = @Log_ID;  END ", con);
                            cm.Parameters.AddWithValue("@Store_ID_Dest", cBoxReceiver.SelectedValue.ToString() );
                            //cm.Parameters.AddWithValue("@Store_ID_Source", item.Cells[8].Value);
                            cm.Parameters.AddWithValue("@Item_ID", item.Cells[7].Value);
                            cm.Parameters.AddWithValue("@Quantity", item.Cells[5].Value == null ? 1 : item.Cells[5].Value); // by default dgv cell value is null, hence usiing conditional operator 
                            cm.Parameters.AddWithValue("@Log_ID", item.Cells[6].Value);
                        }

                        if (rbExternal.Checked) //external transfer of accessories
                        {
                        cm = new SqlCommand("UPDATE [INV].[dbo].[tblStorage] SET Quantity -= @Quantity, Client = @Client, Vehicle = @Vehicle, Document = @Document WHERE Log_ID = @Log_ID ", con);
                        cm.Parameters.AddWithValue("@Quantity", item.Cells[5].Value == null ? 1 : item.Cells[5].Value);
                        cm.Parameters.AddWithValue("@Client", txtExternal.Text);
                        cm.Parameters.AddWithValue("@Vehicle", txtVehicle.Text);
                        cm.Parameters.AddWithValue("@Document", txtDoc.Text);
                        cm.Parameters.AddWithValue("@Log_ID", item.Cells[6].Value);
                        }
                    }

                   // con.Open();
                cm.ExecuteNonQuery();
                con.Close();


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

            label6.Text = cBoxReceiver.Text;
        }

        public void Clear()
        {
            cBoxReceiver.Items.Clear();
            txtVehicle.Clear();
            txtDoc.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           // Clear();
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
    }
}
