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
    public partial class Dashboard : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U753JSI;Initial Catalog=INV;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public Dashboard()
        {
            InitializeComponent();
            LoadStores();
            
        }

        public void LoadStores()
        {
            dgvSideDash.Rows.Clear();
            lblStore.Text = "DASHBOARD";

            using (var connection = new SqlConnection(@"Data Source=DESKTOP-U753JSI;Initial Catalog=INV;Integrated Security=True"))
            {
                connection.Open();

                using (var command = new SqlCommand("SELECT * FROM tblStore", connection))
                {
                    dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        dgvSideDash.Rows.Add(dr[0], dr[2].ToString() + " " + dr[1].ToString() + " " + dr[3].ToString());
                    }
                    dr.Close();
                }
            }
        }

        private void dgvSideDash_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            int selected_store_id = int.Parse(dgvSideDash.Rows[e.RowIndex].Cells[0].Value.ToString());

            lblStore.Text = dgvSideDash.Rows[e.RowIndex].Cells[1].Value.ToString();
            //dgvDashboard.Rows.Clear();
            using (var connection = new SqlConnection(@"Data Source=DESKTOP-U753JSI;Initial Catalog=INV;Integrated Security=True"))
            {
                connection.Open();
                using(var command = new SqlCommand("EXEC [dbo].[SP_DASHBOARD] @Store_ID = @Store_ID", connection))
                {
                    command.Parameters.AddWithValue("@Store_ID", selected_store_id);

                    dr = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    BindingSource bs = new BindingSource();
                    dt.Load(dr);
                    bs.DataSource = dt.DefaultView;
                    dgvDashboard.DataSource = bs;

                    dr.Close();
                }

            }



        }

        private void lblStore_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
