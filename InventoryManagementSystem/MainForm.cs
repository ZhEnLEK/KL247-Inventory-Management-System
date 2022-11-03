using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.BringToFront();
            childForm.Show();
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm; 
            childForm.BringToFront();
            childForm.Show();
        }

        private void tabLog_Click(object sender, EventArgs e)
        {

        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            openChildForm(new UserForm());
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            openChildForm(new UserForm());
            //Application.Run(new UserForm());
            //UserForm User = new UserForm();
            //User.ShowDialog();
                     

        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            openChildForm(new LogForm());
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            openChildForm(new StoreForm());
        }

        private void btnTran_Click(object sender, EventArgs e)
        {
            openChildForm(new Transfer());
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            openChildForm(new ItemForm());
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            openChildForm(new Dashboard());
        }
    }
}
