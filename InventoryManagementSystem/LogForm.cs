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
    public partial class LogForm : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U753JSI;Initial Catalog=INV;Integrated Security=True");
        //SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        SqlDataAdapter da;
        BindingSource bs = new BindingSource();
        DataTable dt = new DataTable();

        public LogForm()
        {
            InitializeComponent();
            LoadLog();

            dateStart.Value = DateTime.Today.AddDays(-30);
            dateEnd.Value = DateTime.Today;
            //cBoxItem.Items.Insert(0, "-select-");
            //cBoxItem.SelectedIndex = 0;

            using (var connection = new SqlConnection(@"Data Source=DESKTOP-U753JSI;Initial Catalog=INV;Integrated Security=True"))
            {
                connection.Open();
                using(var command = new SqlCommand("SELECT * FROM [dbo].[Item]", connection))
                {
                    da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();

                    
                    da.Fill(dt);
                    cBoxItem.ValueMember = "Id";
                    cBoxItem.DisplayMember = "Item";
                    cBoxItem.DataSource = dt;

                    DataRow dr = dt.NewRow();
                    dr[1] = "All items";
                   
                    dt.Rows.InsertAt(dr, 0);
                    

                    cBoxItem.SelectedIndex = 0;
                   

                }

                using (var command = new SqlCommand("SELECT * FROM [dbo].[Tyre_brand]", connection))
                {
                    da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cBoxBrand.ValueMember = "Brand_id";
                    cBoxBrand.DisplayMember = "Brand";
                    cBoxBrand.DataSource = dt;

                    DataRow dr = dt.NewRow();
                    dr[1] = "All tyre brands";

                    dt.Rows.InsertAt(dr, 0);


                    cBoxBrand.SelectedIndex = 0;

                }

                using (var command = new SqlCommand("SELECT * FROM [INV].[dbo].[tblStore]", connection))
                {
                    da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cBoxParty.ValueMember = "Store_ID";
                    cBoxParty.DisplayMember = "Name";
                    cBoxParty.DataSource = dt;

                    //cBoxParty.Text = "";
                    cBoxParty.SelectedIndex = -1;


                }
            }

        }

        public void LoadLog()
        {
            //int i = 0;
           // dgvLog.Rows.Clear();


            using (var connection = new SqlConnection(@"Data Source=DESKTOP-U753JSI;Initial Catalog=INV;Integrated Security=True"))
            {
                connection.Open();

               
                using (var command = new SqlCommand("EXEC [dbo].[SP_LOG_DISPLAY]  ", connection))
                {
                    dr = command.ExecuteReader();
                    dt.Load(dr);
                    bs.DataSource = dt.DefaultView;
                    dgvLog.DataSource = bs;
                   
                    dr.Close(); 
                } 
            }
            //con.Close();
        }

        private void dgvLog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvLog_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateStart_ValueChanged(object sender, EventArgs e)
        {
            
            updateDGV();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            dateStart.Value = DateTime.Today.AddDays(-30);
            dateEnd.Value = DateTime.Today;
            cBoxItem.SelectedIndex = 0;
            cBoxBrand.SelectedIndex = 0;
            cBoxParty.Text = "";
            cBoxSize.SelectedIndex = 0;
            cBoxPattern.SelectedIndex = 0;

            txtCode.Clear();
            txtSN.Clear();
            txtDoc.Clear();
            txtVeh.Clear();

        }

        private void updateDGV()
        {
            //BindingSource bs = new BindingSource();
            //bs.DataSource = dgvLog.DataSource;

            string filter = string.Empty;

            filter = string.Format("Date >= '{0}' AND Date <= '{1}'", dateStart.Value.ToString("dd-MM-yyyy"), dateEnd.Value.ToString("dd-MM-yyyy"));

            if (txtCode.Text != string.Empty)
            {
                if (filter != string.Empty)
                    filter += " and ";
                filter += string.Format("[Tyre code] LIKE '{0}%'", txtCode.Text)  ; 
            }

            if (txtSN.Text != string.Empty)
            {
                if (filter != string.Empty)
                    filter += " and ";
                filter += string.Format("[Tyre S/N] LIKE '{0}%'", txtSN.Text);
            }

            if (txtDoc.Text != string.Empty)
            {
                if (filter != string.Empty)
                    filter += " and ";
                filter += string.Format("Document LIKE '{0}%'", txtDoc.Text);
            }

            if (txtVeh.Text != string.Empty)
            {
                if (filter != string.Empty)
                    filter += " and ";
                filter += string.Format("Vehicle LIKE '{0}%'", txtVeh.Text);
            }
            
            if (cBoxItem.SelectedIndex != 0)
            {
                if (filter != string.Empty)
                    filter += " and ";
                filter += string.Format("Item LIKE '{0}%'", cBoxItem.GetItemText(cBoxItem.SelectedItem));
            }

            if (cBoxItem.SelectedIndex != 0 && cBoxSize.SelectedIndex != 0)
            {
                if (filter != string.Empty)
                    filter += " AND ";
                filter += string.Format("Size LIKE '{0}%' ", cBoxSize.GetItemText(cBoxSize.SelectedItem));
            }
            
            if (cBoxBrand.SelectedIndex != 0)
            {
                if (filter != string.Empty)
                    filter += " and ";
                filter += string.Format("Brand LIKE '{0}%'", cBoxBrand.GetItemText(cBoxBrand.SelectedItem));
            }
            
            if (cBoxBrand.SelectedIndex != 0 && cBoxPattern.SelectedIndex != 0)
            {
                if (filter != string.Empty)
                    filter += " AND ";
                filter += string.Format("Pattern LIKE '{0}%' ", cBoxPattern.GetItemText(cBoxPattern.SelectedItem));
            }

            if (cBoxTran.SelectedIndex != 0)
            {
                if (filter != string.Empty)
                    filter += " AND ";
                filter += string.Format("Transfer LIKE '{0}%' ", cBoxTran.GetItemText(cBoxTran.SelectedItem));
            }

            if (cBoxParty.Text != string.Empty)
            {
                if (filter != string.Empty)
                    filter += " AND ";
                filter += string.Format("Party LIKE '{0}%' ", cBoxParty.Text);
            }
            /*
            if(dateStart != null)
            {
                if (filter != string.Empty)
                    filter += " and ";
                filter += string.Format("Date >= '{0}'", dateStart.Value.ToString("dd-MM-yyyy") );
            } 
            
            if (dateEnd.Value != DateTime.Now)
            {
                if (filter != string.Empty)
                    filter += " and ";
                filter += string.Format("Date <= '{0}'", dateEnd.Value.ToString("dd-MM-yyyy"));
            }
            */


            if (filter != string.Empty)
                this.Text = filter;
            else
                this.Text = "All records"; 

            bs.Filter = filter;
            //dgvLog.DataSource = bs;
            
        }

        private void cBoxItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(@"Data Source=DESKTOP-U753JSI;Initial Catalog=INV;Integrated Security=True"))
            {
                connection.Open();

                using (var command = new SqlCommand("SELECT * FROM [dbo].[Size] WHERE Item_ID = @Item_ID", connection))
                {
                    command.Parameters.AddWithValue("@Item_ID", cBoxItem.SelectedValue.ToString());
                    da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cBoxSize.ValueMember = "Size_ID";
                    cBoxSize.DisplayMember = "Size";
                    cBoxSize.DataSource = dt;

                    DataRow dr = dt.NewRow();
                    dr[2] = "All sizes";

                    dt.Rows.InsertAt(dr, 0);


                    cBoxSize.SelectedIndex = 0;



                }
            }

            updateDGV();
        }

        private void cBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(@"Data Source=DESKTOP-U753JSI;Initial Catalog=INV;Integrated Security=True"))
            {
                connection.Open();

                using (var command = new SqlCommand("SELECT * FROM [dbo].[Thread_pattern] WHERE Brand_id = @Brand_id", connection))
                {
                    //cm2 = new SqlCommand("SELECT * FROM [dbo].[Thread_pattern] WHERE Brand_id = @Brand_id", con);
                    command.Parameters.AddWithValue("@Brand_id", cBoxBrand.SelectedValue.ToString());
                    //con.Open();
                    da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cBoxPattern.ValueMember = "Thread_ID";
                    cBoxPattern.DisplayMember = "Pattern";
                    cBoxPattern.DataSource = dt;

                    DataRow dr = dt.NewRow();
                    dr[2] = "All thread pattern";

                    dt.Rows.InsertAt(dr, 0);


                    cBoxPattern.SelectedIndex = 0;
                }
            }

            updateDGV();
        }

        private void cBoxPattern_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateDGV();
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            updateDGV();
        }

        private void txtSN_TextChanged(object sender, EventArgs e)
        {
            updateDGV();
        }

        private void txtDoc_TextChanged(object sender, EventArgs e)
        {
            updateDGV();
        }

        private void txtVeh_TextChanged(object sender, EventArgs e)
        {
            updateDGV();
        }

        private void dateStart_CloseUp(object sender, EventArgs e)
        {
           // dateStart_ValueChanged(sender, e);
        }

        private void dateEnd_ValueChanged(object sender, EventArgs e)
        {
            updateDGV(); 
        }

        private void cBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateDGV();
        }

        private void cBoxTran_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateDGV();
        }

        private void cBoxParty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z')
                e.KeyChar -= (char)32;

            updateDGV();
        }

        private void cBoxParty_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateDGV();
        }

        private void cBoxParty_TextChanged(object sender, EventArgs e)
        {
            updateDGV();
        }
    }
}
