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
    public partial class PatternModuleForm : Form
    {
        string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        private int Brand_ID;
        public int Thread_ID;
        private readonly ItemForm itemForm;
        SqlDataAdapter da = new SqlDataAdapter();
        public PatternModuleForm(int brandid, ItemForm IF)
        {
            InitializeComponent();
            Brand_ID = brandid;
            itemForm = IF;

            using(var connection = new SqlConnection(connStr))
            {
                connection.Open();
                using(var command = new SqlCommand("SELECT Brand FROM [dbo].[KLConnect 247INVENTORY$Tyre_brand] WHERE Brand_id = @Brand_id ", connection))
                {
                    command.Parameters.AddWithValue("@Brand_id", brandid);
                    da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    
                    lblBrand.Text = dt.Rows[0][0].ToString();
                }
            }
        }

        

        private void lblBrand_Click(object sender, EventArgs e)
        {

        }

        public void Clear()
        {
            txtPattern.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Add thread pattern?", "Adding thread pattern", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (var connection = new SqlConnection(connStr))
                {
                    connection.Open();
                    using (var command = new SqlCommand("INSERT INTO [dbo].[KLConnect 247INVENTORY$Thread_pattern] (Brand_id, Pattern) VALUES (@Brand_id, @Pattern)", connection))
                    {
                        command.Parameters.AddWithValue("@Brand_id", Brand_ID);
                        command.Parameters.AddWithValue("@Pattern",txtPattern.Text);

                        command.ExecuteNonQuery();
                    }

                }

            }
            MessageBox.Show("Thread pattern added!");
            Clear();
            itemForm.LoadPattern(Brand_ID);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Update this thread pattern?", "Updating thread pattern", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (var connection = new SqlConnection(connStr))
                {
                    connection.Open();
                    using (var command = new SqlCommand("UPDATE [dbo].[KLConnect 247INVENTORY$Thread_pattern] SET Pattern = @Pattern WHERE Thread_id = @Thread_id", connection))
                    {
                        command.Parameters.AddWithValue("@Pattern", txtPattern.Text);
                        command.Parameters.AddWithValue("@Thread_id", Thread_ID );

                        command.ExecuteNonQuery();
                    }

                }
                MessageBox.Show("Size updated");
                Clear();
                itemForm.LoadPattern(Brand_ID);
                this.Close();


            }
        }
    }
}
