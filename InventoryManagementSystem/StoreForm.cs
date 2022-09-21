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
    public partial class StoreForm : Form
    {
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
            int i = 0;
            dgvStore.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tblStore", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvStore.Rows.Add(dr[6].ToString(),dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void dgvStore_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            StoreModuleForm storeModule = new StoreModuleForm();
            storeModule.btnSave.Enabled = true;
            storeModule.btnUpdate.Enabled = false;
            //storeModule.btnClear.Enabled = true;
            storeModule.ShowDialog();

        }
    }
}
