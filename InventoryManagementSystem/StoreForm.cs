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
    public partial class StoreForm : Form
    {
        string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U753JSI;Initial Catalog=INV;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public StoreForm()
        {
            InitializeComponent();
            LoadStore();
        }

        public void LoadStore()
        {
            // int i = 0;
            using (var connection = new SqlConnection(connStr))
            {
                connection.Open();
                using (var command = new SqlCommand("SELECT * FROM [dbo].[KLConnect 247INVENTORY$Store]", connection))
                {
                    dgvStore.Rows.Clear();
                   // command = new SqlCommand("SELECT * FROM tblStore", con);
                    // con.Open();
                    dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        //  i++;
                        dgvStore.Rows.Add(dr[6].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), null, null, dr[0]);
                    }
                    dr.Close(); 
                } 
            }
            //con.Close();
        }

        private void dgvStore_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvStore.Columns[e.ColumnIndex].Name;
            if(colName == "Edit")
            {
                StoreModuleForm storeModuleForm = new StoreModuleForm(this);
                storeModuleForm.txtCode.Text = dgvStore.Rows[e.RowIndex].Cells[1].Value.ToString();
                storeModuleForm.cBoxDes.SelectedItem = dgvStore.Rows[e.RowIndex].Cells[2].Value.ToString();
                storeModuleForm.txtName.Text = dgvStore.Rows[e.RowIndex].Cells[3].Value.ToString();
                storeModuleForm.cBoxType.SelectedItem = dgvStore.Rows[e.RowIndex].Cells[4].Value.ToString();
                storeModuleForm.txtRemark.Text = dgvStore.Rows[e.RowIndex].Cells[5].Value.ToString();
                storeModuleForm.cBoxLocation.SelectedItem = dgvStore.Rows[e.RowIndex].Cells[0].Value.ToString();

                storeModuleForm.storeid = int.Parse(dgvStore.Rows[e.RowIndex].Cells[8].Value.ToString());

                storeModuleForm.btnSave.Enabled = false;
                storeModuleForm.btnUpdate.Enabled = true;
                storeModuleForm.btnClear.Enabled = true;

                storeModuleForm.ShowDialog();


            }

            else if (colName == "Delete")
            {
                if(MessageBox.Show("Delete this store?", "Delete Store", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // con.Open();
                    using (var connection = new SqlConnection(connStr))
                    {
                        connection.Open();
                        using (var command = new SqlCommand("DELETE FROM [dbo].[KLConnect 247INVENTORY$Store] WHERE Store_ID = @Store_ID", connection))
                        {
                            command.Parameters.AddWithValue( "@Store_ID", dgvStore.Rows[e.RowIndex].Cells[8].Value);
                            //cm = new SqlCommand("DELETE FROM [INV].[dbo].[tblStore] WHERE Store_ID = " + dgvStore.Rows[e.RowIndex].Cells[8].Value, con);
                            command.ExecuteNonQuery();
                            //con.Close();
                            MessageBox.Show("Store deleted!");
                            LoadStore();  
                        }
                    }
                }
            }

        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            StoreModuleForm storeModule = new StoreModuleForm(this);
            storeModule.btnSave.Enabled = true;
            storeModule.btnUpdate.Enabled = false;
            //storeModule.btnClear.Enabled = true;
            storeModule.ShowDialog();

        }
    }
}
