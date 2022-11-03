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
    public partial class SizeModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U753JSI;Initial Catalog=INV;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        private int Item_ID;
        private readonly ItemForm itemForm;
        public int Size_ID;
        public SizeModuleForm(int itemid, ItemForm IF)
        {
            InitializeComponent();
            cm = new SqlCommand("SELECT Item FROM [dbo].[Item] WHERE Id = @Id", con);
            cm.Parameters.AddWithValue("@Id", itemid);
            con.Open();
            da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);

            Item_ID = itemid;

            lblItem.Text = dt.Rows[0][0].ToString();

            itemForm = IF;
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
                using (var connection = new SqlConnection(@"Data Source=DESKTOP-U753JSI;Initial Catalog=INV;Integrated Security=True"))
                {
                    connection.Open();
                    using (var command = new SqlCommand("INSERT INTO [INV].[dbo].[Size] (Item_ID, Size) VALUES (@Item_ID, @Size)", connection))
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
                using (var connection = new SqlConnection(@"Data Source=DESKTOP-U753JSI;Initial Catalog=INV;Integrated Security=True"))
                {
                    connection.Open();
                    using ( var command = new SqlCommand("UPDATE Size SET Size = @Size WHERE Size_ID = @Size_ID", connection))
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
    }
}
