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
    public partial class LogForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U753JSI;Initial Catalog=INV;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public LogForm()
        {
            InitializeComponent();
            LoadLog();
        }

        public void LoadLog()
        {
            int i = 0;
            dgvLog.Rows.Clear();
            cm = new SqlCommand("SELECT Date_log , Item, Size, Branding_code, Tyre_brand,Tyre_pattern,Tyre_serial_number, Transaction_type,Party, Quantity, Document, Vehicle FROM tblIventoryLog  ", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvLog.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString(), dr[10].ToString(), dr[11].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void dgvLog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvLog_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
