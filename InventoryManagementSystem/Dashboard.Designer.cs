namespace InventoryManagementSystem
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblStore = new System.Windows.Forms.Label();
            this.dgvDashTyre = new System.Windows.Forms.DataGridView();
            this.dgvDashAcc = new System.Windows.Forms.DataGridView();
            this.dgvSideDash = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDashTyre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDashAcc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSideDash)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStore
            // 
            this.lblStore.AutoSize = true;
            this.lblStore.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStore.Location = new System.Drawing.Point(203, 0);
            this.lblStore.Name = "lblStore";
            this.lblStore.Size = new System.Drawing.Size(54, 19);
            this.lblStore.TabIndex = 4;
            this.lblStore.Text = "label1";
            // 
            // dgvDashTyre
            // 
            this.dgvDashTyre.AllowUserToAddRows = false;
            this.dgvDashTyre.AllowUserToDeleteRows = false;
            this.dgvDashTyre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDashTyre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDashTyre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDashTyre.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDashTyre.Location = new System.Drawing.Point(203, 28);
            this.dgvDashTyre.Name = "dgvDashTyre";
            this.dgvDashTyre.RowHeadersVisible = false;
            this.dgvDashTyre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDashTyre.Size = new System.Drawing.Size(294, 419);
            this.dgvDashTyre.TabIndex = 1;
            // 
            // dgvDashAcc
            // 
            this.dgvDashAcc.AllowUserToAddRows = false;
            this.dgvDashAcc.AllowUserToDeleteRows = false;
            this.dgvDashAcc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDashAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDashAcc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDashAcc.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDashAcc.Location = new System.Drawing.Point(503, 28);
            this.dgvDashAcc.Name = "dgvDashAcc";
            this.dgvDashAcc.RowHeadersVisible = false;
            this.dgvDashAcc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDashAcc.Size = new System.Drawing.Size(294, 419);
            this.dgvDashAcc.TabIndex = 3;
            // 
            // dgvSideDash
            // 
            this.dgvSideDash.AllowUserToAddRows = false;
            this.dgvSideDash.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSideDash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSideDash.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvSideDash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSideDash.Location = new System.Drawing.Point(3, 3);
            this.dgvSideDash.Name = "dgvSideDash";
            this.dgvSideDash.RowHeadersVisible = false;
            this.tableLayoutPanel1.SetRowSpan(this.dgvSideDash, 2);
            this.dgvSideDash.Size = new System.Drawing.Size(194, 444);
            this.dgvSideDash.TabIndex = 0;
            this.dgvSideDash.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSideDash_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column2.HeaderText = "Store";
            this.Column2.Name = "Column2";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgvSideDash, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvDashAcc, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvDashTyre, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblStore, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 14;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDashTyre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDashAcc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSideDash)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblStore;
        private System.Windows.Forms.DataGridView dgvDashTyre;
        private System.Windows.Forms.DataGridView dgvDashAcc;
        private System.Windows.Forms.DataGridView dgvSideDash;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}