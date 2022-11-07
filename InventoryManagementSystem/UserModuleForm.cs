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
using System.Security.Cryptography.X509Certificates;
using System.Configuration;

namespace InventoryManagementSystem
{
    public partial class UserModuleForm : Form
    {
        string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U753JSI;Initial Catalog=INV;Integrated Security=True");
        SqlCommand cm = new SqlCommand();

        public int userid;
        public UserModuleForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

       
        private void UserModuleForm_Load(object sender, EventArgs e)
        {

        }
       
        

        public void Clear()
        {
            txtUserName.Clear();
            txtFullName.Clear();
            txtPass.Clear();
            txtRepass.Clear();
            //txtPhone.Clear();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

       

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPass.Text != txtRepass.Text)
                {
                    MessageBox.Show("Password did not match!");
                    return;
                }
                if (MessageBox.Show("Are you sure you want to save this user?", "Saving record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (var connection = new SqlConnection(connStr))
                    {
                        connection.Open();
                        using (var command = new SqlCommand("INSERT INTO [dbo].[KLConnect 247INVENTORY$User](username, fullname, password, Is_Admin) VALUES(@username, @fullname, @password, @Is_Admin) ", connection))
                        {
                            //cm = new SqlCommand("INSERT INTO tblUser(username, fullname, password, Is_Admin) VALUES(@username, @fullname, @password, @Is_Admin) ", con);
                            command.Parameters.AddWithValue("@username", txtUserName.Text);
                            command.Parameters.AddWithValue("@fullname", txtFullName.Text);
                            command.Parameters.AddWithValue("@password", txtPass.Text);
                            command.Parameters.AddWithValue("@Is_Admin", comboBox1.SelectedIndex == 0 ? 1 : 0);
                            //con.Open();
                            command.ExecuteNonQuery();
                            // con.Close();
                            MessageBox.Show("User have been successfully saved.");
                            Clear();
                            this.Dispose(); 
                        } 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {            

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                

                if (txtPass.Text != txtRepass.Text)
                {
                    MessageBox.Show("Password did not match!");
                    return;
                }
                if (MessageBox.Show("Update this user?", "Updating record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (var connection = new SqlConnection(connStr))
                    {
                        connection.Open();
                        using (var command = new SqlCommand("UPDATE [dbo].[KLConnect 247INVENTORY$User] SET username = @username, fullname = @fullname, password = @password, Is_Admin = @Is_Admin WHERE User_ID = @User_ID ", connection))
                        {
                            //cm = new SqlCommand("UPDATE tblUser SET username = @username, fullname = @fullname, password = @password, Is_Admin = @Is_Admin WHERE User_ID = @User_ID ", con);
                            command.Parameters.AddWithValue("@username", txtUserName.Text);
                            command.Parameters.AddWithValue("@fullname", txtFullName.Text);
                            command.Parameters.AddWithValue("@password", txtPass.Text);
                            command.Parameters.AddWithValue("@Is_Admin", comboBox1.SelectedIndex == 0 ? 1 : 0);
                            command.Parameters.AddWithValue("@User_ID", userid);
                            //con.Open();
                            command.ExecuteNonQuery();
                            //con.Close();
                            MessageBox.Show("User updated");
                            Clear();
                            this.Dispose();  
                        }
                    }
                    //new UserForm().Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
