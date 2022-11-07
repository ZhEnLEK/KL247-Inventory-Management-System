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
    public partial class SizeModuleForm : Form
    {
        string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U753JSI;Initial Catalog=INV;Integrated Security=True");
        //SqlCommand cm = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        private int Item_ID;
        private readonly ItemForm itemForm;
        public int Size_ID;
        public SizeModuleForm(int itemid, ItemForm IF)
        {
            InitializeComponent();
            using (var connection = new SqlConnection(connStr))
            {
                connection.Open();
                using (var command = new SqlCommand("SELECT Item FROM [dbo].[KLConnect 247INVENTORY$Item] WHERE Id = @Id", connection))
                {
                    //cm = new SqlCommand("SELECT Item FROM [dbo].[Item] WHERE Id = @Id", con);
                    command.Parameters.AddWithValue("@Id", itemid);
                    //con.Open();
                    da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    Item_ID = itemid;

                    lblItem.Text = dt.Rows[0][0].ToString();

                    itemForm = IF;  
                }
            }
           // cBoxItem.ValueMember = "Id";
            //cBoxItem.DisplayMember = "Item";
            //cBoxItem.DataSource = dt;


        }

        public void Clear()
        {
            txtSize.Clear();
        }

        private void cBoxItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Add item?", "Adding item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (var connection = new SqlConnection(connStr))
                {
                    connection.Open();
                    using (var command = new SqlCommand("INSERT INTO [dbo].[KLConnect 247INVENTORY$Size] (Item_ID, Size) VALUES (@Item_ID, @Size)", connection))
                    {
                        command.Parameters.AddWithValue("@Item_ID", Item_ID);
                        command.Parameters.AddWithValue("@Size", txtSize.Text);

                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Size added");
                Clear();
               // itemForm.updated_size_item_id = Item_ID;
                itemForm.LoadSize(Item_ID);
               // this.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Update this size?", "Updating Size", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (var connection = new SqlConnection(connStr))
                {
                    connection.Open();
                    using ( var command = new SqlCommand("UPDATE [dbo].[KLConnect 247INVENTORY$Size] SET Size = @Size WHERE Size_ID = @Size_ID", connection))
                    {
                        command.Parameters.AddWithValue("@Size", txtSize.Text);
                        command.Parameters.AddWithValue("@Size_ID", Size_ID);

                        command.ExecuteNonQuery();
                    }

                }
                MessageBox.Show("Size updated");
                Clear();
                itemForm.LoadSize(Item_ID);
                this.Close();


            }

        }

        private void txtSize_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
