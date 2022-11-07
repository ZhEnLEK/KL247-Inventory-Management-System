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
using System.Security.AccessControl;
using System.Configuration;

namespace InventoryManagementSystem
{
    public partial class ItemForm : Form
    {
        string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        
        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U753JSI;Initial Catalog=INV;Integrated Security=True");
        //SqlCommand cm = new SqlCommand();
        //SqlCommand cm1 = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataReader dr;

        private int selected_itemid;
        private int selected_brandid;
        public int updated_size_item_id = 0;
        public ItemForm()
        {
            InitializeComponent();
            LoadItem();
            LoadSize(1);
            LoadBrand();
            LoadPattern(1);
        }

        public void LoadItem()
        {
            dgvItem.Rows.Clear();

           // cm = new SqlCommand("SELECT * FROM Item", con);
           // con.Open();
            using (var connection = new SqlConnection(connStr))
            {
                connection.Open();
                using (var command = new SqlCommand("SELECT * FROM [dbo].[KLConnect 247INVENTORY$Item]", connection))
                {
                    dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        dgvItem.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
                    }
                    dr.Close(); 
                } 
            }
            //con.Close();
        }

        public void LoadSize(int cbox_selected_value)
        {
            //cm = new SqlCommand("SELECT * FROM [dbo].[KLConnect 247INVENTORY$Item]", con);
            //con.Open();
            using (var connection = new SqlConnection(connStr))
            {
                connection.Open();

                using (var command = new SqlCommand("SELECT * FROM [dbo].[KLConnect 247INVENTORY$Item]", connection))
                {
                    da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cBoxItem.ValueMember = "Id";
                    cBoxItem.DisplayMember = "Item";
                    cBoxItem.DataSource = dt;

                    cBoxItem.SelectedValue = cbox_selected_value;  
                }
            }

            //con.Close();

        }

        public void LoadBrand()
        {
            dgvBrand.Rows.Clear();
            using (var connection = new SqlConnection(connStr))
            {
                connection.Open();
                using (var command = new SqlCommand("SELECT * FROM [dbo].[KLConnect 247INVENTORY$Tyre_brand]", connection))
                {
                    dr = command.ExecuteReader();
                    while(dr.Read())
                    {
                        dgvBrand.Rows.Add(dr[0].ToString(), dr[1].ToString());
                    }
                    dr.Close();
                }

            }
        }

        public void LoadPattern(int cbox_selected_value)
        {
            using(var connection = new SqlConnection(connStr))
            {
                connection.Open();
                using(var command = new SqlCommand("SELECT * FROM [dbo].[KLConnect 247INVENTORY$Tyre_brand]", connection))
                {
                    da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cBoxPattern.ValueMember = "Brand_id";
                    cBoxPattern.DisplayMember = "Brand";
                    cBoxPattern.DataSource = dt;

                    cBoxPattern.SelectedValue = cbox_selected_value;
                }
            }
        }

        private void ItemForm_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvItem.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                ItemModuleForm itemModuleForm = new ItemModuleForm(this);
                itemModuleForm.txtItemName.Text = dgvItem.Rows[e.RowIndex].Cells[1].Value.ToString();
                itemModuleForm.txtDesc.Text = dgvItem.Rows[e.RowIndex].Cells[2].Value.ToString();

                itemModuleForm.itemid = int.Parse(dgvItem.Rows[e.RowIndex].Cells[0].Value.ToString());

                itemModuleForm.btnSave.Enabled = false;
                itemModuleForm.btnUpdate.Enabled = true;
                itemModuleForm.btnClear.Enabled = true;

                itemModuleForm.ShowDialog();

            }
            if (colName == "Delete")
            {
                if (MessageBox.Show("Delete this item?", "Delete item", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    // con.Open();
                    using (var connection = new SqlConnection(connStr))
                    {
                        connection.Open();
                        using(var command = new SqlCommand("DELETE FROM [dbo].[KLConnect 247INVENTORY$Item] WHERE Id = @Id", connection))
                        {
                            command.Parameters.AddWithValue("@Id", dgvItem.Rows[e.RowIndex].Cells[0].Value);
                            command.ExecuteNonQuery();
                        }
                                
                       // cm = new SqlCommand("DELETE FROM [dbo].[KLConnect 247INVENTORY$Item] WHERE Id = @Id " + dgvItem.Rows[e.RowIndex].Cells[0].Value, con);
                        //cm.ExecuteNonQuery(); 
                    }
                    //con.Close();
                    MessageBox.Show("Item deleted!");
                    //dgvItem.Refresh();
                    LoadItem();
                }
            }
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            ItemModuleForm itemModuleForm = new ItemModuleForm(this);
            itemModuleForm.btnSave.Enabled = true;
            itemModuleForm.btnUpdate.Enabled = false;
            itemModuleForm.btnClear.Enabled = true;

            itemModuleForm.ShowDialog();
        }

        private void cBoxItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new SqlConnection(connStr))
                {
                    connection.Open();

                    using (var command = new SqlCommand("SELECT * FROM [dbo].[KLConnect 247INVENTORY$Size] WHERE Item_ID = @Item_ID", connection))
                    {
                        //cm1 = new SqlCommand("SELECT * FROM [dbo].[KLConnect 247INVENTORY$Size] WHERE Item_ID = @Item_ID", con);
                        command.Parameters.AddWithValue("@Item_ID", cBoxItem.SelectedValue.ToString()); //reload the dgvSize with the said item after a size has been added
                        selected_itemid = int.Parse(cBoxItem.SelectedValue.ToString());
                        //con.Open();
                        dgvSize.Rows.Clear();
                        //if (con.State == ConnectionState.Closed)
                        //{ con.Open(); }
                        dr = command.ExecuteReader();
                        while (dr.Read())
                        {
                            dgvSize.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
                        }
                        dr.Close();  
                    }
                }
                //con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSize_Click(object sender, EventArgs e)  //adding size
        {
            SizeModuleForm sizeModuleForm = new SizeModuleForm(selected_itemid, this);
            sizeModuleForm.btnSave.Enabled = true;
            sizeModuleForm.btnUpdate.Enabled = false;
            sizeModuleForm.btnClear.Enabled = true;

            sizeModuleForm.ShowDialog();
                        
        }

        private void dgvSize_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvSize.Columns[e.ColumnIndex].Name;

            if(colName == "Edit_Size")  //edit size
            {
                SizeModuleForm sizeModuleForm = new SizeModuleForm( selected_itemid, this);
                sizeModuleForm.txtSize.Text = dgvSize.Rows[e.RowIndex].Cells[2].Value.ToString();

                sizeModuleForm.Size_ID = int.Parse(dgvSize.Rows[e.RowIndex].Cells[0].Value.ToString());


                sizeModuleForm.btnSave.Enabled = false;
                sizeModuleForm.btnUpdate.Enabled = true;
                sizeModuleForm.btnClear.Enabled= true;

                sizeModuleForm.ShowDialog();

            }

            if (colName == "Delete_Size")
            {
                if (MessageBox.Show("Delete this size?", "Delete size", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (var connection = new SqlConnection(connStr))
                    {
                        connection.Open();
                        using (var command = new SqlCommand("DELETE FROM [dbo].[KLConnect 247INVENTORY$Size] WHERE Size_ID = @Size_ID", connection))
                        {
                            command.Parameters.AddWithValue("@Size_ID", dgvSize.Rows[e.RowIndex].Cells[0].Value);
                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Size deleted!");
                    LoadSize(int.Parse( dgvSize.Rows[e.RowIndex].Cells[1].Value.ToString()));
                    //updated_size_item_id = int.Parse(cBoxItem.SelectedValue.ToString());
                    //LoadSize();  
                }
            }
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            BrandModuleForm brandModuleForm = new BrandModuleForm(this);

            brandModuleForm.btnSave.Enabled = true;
            brandModuleForm.btnUpdate.Enabled = false ;
            brandModuleForm.btnClear.Enabled = true;

            brandModuleForm.ShowDialog();
        }

        private void dgvBrand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvBrand.Columns[e.ColumnIndex].Name;

            if (colName == "Brand_Edit")
            {
                BrandModuleForm brandModuleForm = new BrandModuleForm(this);
                brandModuleForm.txtBrand.Text = dgvBrand.Rows[e.RowIndex].Cells[1].Value.ToString();

                brandModuleForm.brandid = int.Parse(dgvBrand.Rows[e.RowIndex].Cells[0].Value.ToString());

                brandModuleForm.btnSave.Enabled = false;
                brandModuleForm.btnUpdate.Enabled = true;
                brandModuleForm.btnClear.Enabled = true;

                brandModuleForm.ShowDialog();
            }

            if(colName == "Brand_Delete")
            {
                if (MessageBox.Show("Delete this tyre brand?", "Delete brand", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (var connection = new SqlConnection(connStr))
                    {
                        connection.Open();
                        using (var command = new SqlCommand("DELETE FROM [dbo].[KLConnect 247INVENTORY$Tyre_brand] WHERE Brand_id = @Brand_id", connection))
                        {
                            command.Parameters.AddWithValue("@Brand_id", dgvBrand.Rows[e.RowIndex].Cells[0].Value);
                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Brand deleted!");
                    LoadBrand();
                    //updated_size_item_id = int.Parse(cBoxItem.SelectedValue.ToString());
                    //LoadSize();  
                }
            }
        }

        private void cBoxPattern_SelectedIndexChanged(object sender, EventArgs e)
        {
            using(var connection = new SqlConnection(connStr))
            {
                connection.Open();
                using(var command = new SqlCommand("SELECT * FROM [dbo].[KLConnect 247INVENTORY$Thread_pattern] WHERE Brand_id = @Brand_id" , connection))
                {
                    command.Parameters.AddWithValue("@Brand_id", cBoxPattern.SelectedValue.ToString());

                    selected_brandid = int.Parse(cBoxPattern.SelectedValue.ToString());

                    dgvPattern.Rows.Clear();

                    dr = command.ExecuteReader();

                    while(dr.Read())
                    {
                        dgvPattern.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString()); 
                    }

                    dr.Close();
                }
            }
        }

        private void btnPattern_Click(object sender, EventArgs e)
        {
            PatternModuleForm patternModuleForm = new PatternModuleForm(selected_brandid, this);

            patternModuleForm.btnSave.Enabled = true;
            patternModuleForm.btnUpdate.Enabled = false;
            patternModuleForm.btnClear.Enabled = true;

            patternModuleForm.ShowDialog();
        }

        private void dgvPattern_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvPattern.Columns[e.ColumnIndex].Name;

            if (colName == "Edit_Pattern")  //edit size
            {
                PatternModuleForm patternModuleForm = new PatternModuleForm(selected_brandid, this);
                patternModuleForm.txtPattern.Text = dgvPattern.Rows[e.RowIndex].Cells[2].Value.ToString();

                patternModuleForm.Thread_ID = int.Parse(dgvPattern.Rows[e.RowIndex].Cells[0].Value.ToString());

                patternModuleForm.btnSave.Enabled = false;
                patternModuleForm.btnUpdate.Enabled = true;
                patternModuleForm.btnClear.Enabled = true;

                patternModuleForm.ShowDialog();
                    

            }

            if (colName == "Delete_Pattern")
            {
                if (MessageBox.Show("Delete this thread pattern?", "Delete thread pattern", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (var connection = new SqlConnection(connStr))
                    {
                        connection.Open();
                        using (var command = new SqlCommand("DELETE FROM [dbo].[KLConnect 247INVENTORY$Thread_pattern] WHERE Thread_id = @Thread_id", connection))
                        {
                            command.Parameters.AddWithValue("@Thread_id", dgvPattern.Rows[e.RowIndex].Cells[0].Value);
                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Thread pattern deleted!");
                    LoadPattern(int.Parse(dgvPattern.Rows[e.RowIndex].Cells[1].Value.ToString()));
                }
            }
        }
    }
}
