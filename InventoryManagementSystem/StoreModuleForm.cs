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
    public partial class StoreModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U753JSI;Initial Catalog=INV;Integrated Security=True");
        SqlCommand cm = new SqlCommand();

        public void Clear()
        {
            txtCode.Clear();
           // txtDes.Clear();
            txtName.Clear();
            //txtType.Clear();
            txtRemark.Clear();
            
            
        }

        public StoreModuleForm()
        {
            InitializeComponent();
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
                    cm = new SqlCommand("INSERT INTO tblStore(Code, Designation, Name, Type, Remark, Location) VALUES(@Code, @Designation, @Name, @Type, @Remark, @Location); " , con);
                    cm.Parameters.AddWithValue("@Code", txtCode.Text);
                    cm.Parameters.AddWithValue("@Designation", cBoxDes.Text);
                    cm.Parameters.AddWithValue("@Name", txtName.Text);
                    cm.Parameters.AddWithValue("@Type", cBoxType.Text);
                    cm.Parameters.AddWithValue("@Remark", txtRemark.Text);
                    cm.Parameters.AddWithValue("@Location", cBoxLocation.Text);
                    //cm = new SqlCommand("CREATE TABLE fakename (Item varchar(50), Size varchar(50), Pattern varchar(50), Tyre_branding_code varchar(50), Tyre_serial_no varchar(50), In_stock bit, Quantity smallint )", con);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("User have been successfully saved.");
                    Clear();
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
    }
}
