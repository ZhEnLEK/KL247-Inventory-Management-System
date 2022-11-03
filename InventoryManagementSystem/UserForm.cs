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
    public partial class UserForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U753JSI;Initial Catalog=INV;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public UserForm()
        {
            InitializeComponent();
            LoadUser();
        }
           

        public void LoadUser()
        {
            int i = 0;
            dgvUser.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tblUser", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvUser.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[4].ToString() == "True" ? "Admin" : "", null, null, dr[3]);
            }
            dr.Close();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserModuleForm userModule = new UserModuleForm();
            userModule.btnSave.Enabled = true;
            userModule.btnUpdate.Enabled = false; 
            userModule.ShowDialog();
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvUser.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                UserModuleForm userModuleForm = new UserModuleForm();
                userModuleForm.txtUserName.Text = dgvUser.Rows[e.RowIndex].Cells[0].Value.ToString();
                userModuleForm.txtFullName.Text = dgvUser.Rows[e.RowIndex].Cells[1].Value.ToString();
                userModuleForm.txtPass.Text = dgvUser.Rows[e.RowIndex].Cells[2].Value.ToString();
               // userModuleForm.txtRepass.Text = dgvUser.Rows[e.RowIndex].Cells[1].Value.ToString();
                userModuleForm.comboBox1.SelectedIndex =  dgvUser.Rows[e.RowIndex].Cells[3].Value.ToString() == "Admin" ? 0:1;
                //userModuleForm.comboBox1.SelectedItem = dgvUser.Rows[e.RowIndex].Cells[3].Value.ToString();

                userModuleForm.userid = int.Parse(dgvUser.Rows[e.RowIndex].Cells[6].Value.ToString());

                userModuleForm.btnSave.Enabled = false;
                userModuleForm.btnUpdate.Enabled = true;
                userModuleForm.btnClear.Enabled = true;

                userModuleForm.ShowDialog();

            }

            else if (colName == "Delete")
            {
                if(MessageBox.Show("Delete this user?", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM [INV].[dbo].[tblUser] WHERE User_ID = " + dgvUser.Rows[e.RowIndex].Cells[6].Value, con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("User deleted!");

                }
            }
        }
    }
}
