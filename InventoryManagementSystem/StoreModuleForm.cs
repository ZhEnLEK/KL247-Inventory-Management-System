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
    public partial class StoreModuleForm : Form
    {
        string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U753JSI;Initial Catalog=INV;Integrated Security=True");
        //SqlCommand cm = new SqlCommand();

        public int storeid;
        private readonly StoreForm storeForm;

        public void Clear()
        {
            txtCode.Clear();
            txtName.Clear();
            txtRemark.Clear();
            cBoxDes.SelectedIndex = -1;
            cBoxLocation.SelectedIndex = -1;
            cBoxType.SelectedIndex = -1;

            
        }

        public StoreModuleForm(StoreForm SF)
        {
            InitializeComponent();

            storeForm = SF;
        }

        private void StoreModuleForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this store?", "Saving record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (var connection = new SqlConnection(connStr))
                    {
                        connection.Open();
                        using (var command = new SqlCommand("INSERT INTO [dbo].[KLConnect 247INVENTORY$Store](Code, Designation, Name, Type, Remark, Location) VALUES(@Code, @Designation, @Name, @Type, @Remark, @Location);", connection))
                        {
                            //cm = new SqlCommand("INSERT INTO tblStore(Code, Designation, Name, Type, Remark, Location) VALUES(@Code, @Designation, @Name, @Type, @Remark, @Location); ", con);
                            command.Parameters.AddWithValue("@Code", txtCode.Text);
                            command.Parameters.AddWithValue("@Designation", cBoxDes.Text);
                            command.Parameters.AddWithValue("@Name", txtName.Text);
                            command.Parameters.AddWithValue("@Type", cBoxType.Text);
                            command.Parameters.AddWithValue("@Remark", txtRemark.Text);
                            command.Parameters.AddWithValue("@Location", cBoxLocation.Text);
                            //cm = new SqlCommand("CREATE TABLE fakename (Item varchar(50), Size varchar(50), Pattern varchar(50), Tyre_branding_code varchar(50), Tyre_serial_no varchar(50), In_stock bit, Quantity smallint )", con);
                            //con.Open();
                            command.ExecuteNonQuery();
                            //con.Close();
                            MessageBox.Show("User have been successfully saved.");
                            Clear();
                            storeForm.LoadStore();
                        }
                    }
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                               
                if (MessageBox.Show("Update this store?", "Updating record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (var connection = new SqlConnection(connStr))
                    {
                        connection.Open();

                        using (var command = new SqlCommand("UPDATE [dbo].[KLConnect 247INVENTORY$Store] SET Code = @Code, Designation = @Designation, Name = @Name, Type = @Type, Remark = @Remark, Location = @Location WHERE Store_ID = @Store_ID ", connection))
                        {
                            //cm = new SqlCommand("UPDATE [INV].[dbo].[tblStore] SET Code = @Code, Designation = @Designation, Name = @Name, Type = @Type, Remark = @Remark, Location = @Location WHERE Store_ID = @Store_ID ", con);
                            command.Parameters.AddWithValue("@Code", txtCode.Text);
                            command.Parameters.AddWithValue("@Designation", cBoxDes.SelectedItem);
                            command.Parameters.AddWithValue("@Name", txtName.Text);
                            command.Parameters.AddWithValue("@Type", cBoxType.SelectedItem);
                            command.Parameters.AddWithValue("@Remark", txtRemark.Text);
                            command.Parameters.AddWithValue("@Location", cBoxLocation.SelectedItem);
                            command.Parameters.AddWithValue("Store_ID", storeid);

                            //con.Open();
                            command.ExecuteNonQuery();
                            //con.Close();
                            MessageBox.Show("Store updated");
                            Clear();
                            this.Dispose(); 
                            storeForm.LoadStore();
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
