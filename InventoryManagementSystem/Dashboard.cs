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
            dgvDashboardSide.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tblStore", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dgvDashboardSide.Rows.Add(dr[2].ToString() + " " + dr[1].ToString());
            }
            dr.Close();
            con.Close();
        }



        private void dgvDashboardSide_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
