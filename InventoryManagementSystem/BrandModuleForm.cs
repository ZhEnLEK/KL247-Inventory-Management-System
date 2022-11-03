using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class BrandModuleForm : Form
    {
        public int brandid;
        private readonly ItemForm itemForm;
        public BrandModuleForm(ItemForm IF)
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
            txtBrand.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Add tyre brand?", "Adding tyre brand", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using(var connection = new SqlConnection(@"Data Source=DESKTOP-U753JSI;Initial Catalog=INV;Integrated Security=True"))
                {
                    connection.Open();
                    using(var command = new SqlCommand("INSERT INTO Tyre_brand (Brand) VALUES (@Brand)", connection))
                    {
                        command.Parameters.AddWithValue("@Brand", txtBrand.Text);

                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Tyre brand added!");
                Clear();
                itemForm.LoadBrand();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Edit tyre brand?", "Editting tyre brand", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using(var connection = new SqlConnection(@"Data Source=DESKTOP-U753JSI;Initial Catalog=INV;Integrated Security=True"))
                {
                    connection.Open();
                    using(var command = new SqlCommand("UPDATE Tyre_brand SET Brand = @Brand WHERE Brand_id = @Brand_id", connection))
                    {
                        command.Parameters.AddWithValue("@Brand", txtBrand.Text);
                        command.Parameters.AddWithValue("Brand_id", brandid);

                        command.ExecuteNonQuery();

                    }
                }

                MessageBox.Show("Brand updated");
                Clear();
                itemForm.LoadBrand();
                this.Close();
            }

        }
    }
}
