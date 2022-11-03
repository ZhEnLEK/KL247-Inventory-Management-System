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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InventoryManagementSystem
{
    public partial class ItemModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U753JSI;Initial Catalog=INV;Integrated Security=True");
        SqlCommand cm = new SqlCommand();

        public int itemid;
        private readonly ItemForm itemForm;
        public ItemModuleForm(ItemForm IF)
        {
            InitializeComponent();

            itemForm = IF;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            
        }

        public void Clear()
        {
            txtItemName.Clear();
            txtDesc.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Add item?", "Adding item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO Item (Item, Description) VALUES (@Item, @Description)", con);
                    cm.Parameters.AddWithValue("@Item", txtItemName.Text);
                    cm.Parameters.AddWithValue("@Description", txtDesc.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Item saved.");
                    Clear();

                    itemForm.LoadItem();
                    //this.Close();
                    
                    
                    

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Update this item?", "Updating Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE Item SET Item = @Item, Description = @Description WHERE Id = @Item_ID ", con);
                    cm.Parameters.AddWithValue("@Item", txtItemName.Text);
                    cm.Parameters.AddWithValue("@Description", txtDesc.Text);
                    cm.Parameters.AddWithValue("@Item_ID", itemid);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Item updated");
                    Clear();
                    //this.Dispose();

                    itemForm.LoadItem();
                    this.Close();

                   

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
