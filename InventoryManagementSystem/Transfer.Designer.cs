namespace InventoryManagementSystem
{
    partial class Transfer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTransfer = new System.Windows.Forms.Panel();
            this.dgvTransferSide = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvStorage = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStore = new System.Windows.Forms.TextBox();
            this.btnReceiving = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTransfer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferSide)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorage)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTransfer
            // 
            this.panelTransfer.Controls.Add(this.dgvTransferSide);
            this.panelTransfer.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTransfer.Location = new System.Drawing.Point(0, 0);
            this.panelTransfer.Name = "panelTransfer";
            this.panelTransfer.Size = new System.Drawing.Size(200, 450);
            this.panelTransfer.TabIndex = 4;
            // 
            // dgvTransferSide
            // 
            this.dgvTransferSide.AllowUserToAddRows = false;
            this.dgvTransferSide.AllowUserToDeleteRows = false;
            this.dgvTransferSide.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTransferSide.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column7});
            this.dgvTransferSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTransferSide.Location = new System.Drawing.Point(0, 0);
            this.dgvTransferSide.MinimumSize = new System.Drawing.Size(0, 30);
            this.dgvTransferSide.MultiSelect = false;
            this.dgvTransferSide.Name = "dgvTransferSide";
            this.dgvTransferSide.ReadOnly = true;
            this.dgvTransferSide.RowHeadersVisible = false;
            this.dgvTransferSide.RowHeadersWidth = 25;
            this.dgvTransferSide.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransferSide.Size = new System.Drawing.Size(200, 450);
            this.dgvTransferSide.TabIndex = 0;
            this.dgvTransferSide.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransferSide_CellClick);
            this.dgvTransferSide.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransferSide_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvStorage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(200, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 390);
            this.panel1.TabIndex = 5;
            // 
            // dgvStorage
            // 
            this.dgvStorage.AllowUserToAddRows = false;
            this.dgvStorage.AllowUserToDeleteRows = false;
            this.dgvStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStorage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column8,
            this.Column11,
            this.Column10,
            this.Column12});
            this.dgvStorage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStorage.Location = new System.Drawing.Point(0, 0);
            this.dgvStorage.Name = "dgvStorage";
            this.dgvStorage.RowHeadersWidth = 20;
            this.dgvStorage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStorage.Size = new System.Drawing.Size(639, 390);
            this.dgvStorage.TabIndex = 0;
            this.dgvStorage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStorage_CellClick);
            this.dgvStorage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStorage_CellContentClick);
            this.dgvStorage.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvStorage_RowPostPaint);
            this.dgvStorage.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvStorage_RowsRemoved);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Item";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 52;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Size";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 52;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Pattern";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 66;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Branding code";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 101;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "Serial number";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 96;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = "1";
            this.Column6.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column6.HeaderText = "Qty";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.ToolTipText = "Edit quantity where necessary";
            // 
            // Column8
            // 
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.Column8.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column8.HeaderText = "Log ID";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column11
            // 
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.Column11.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column11.HeaderText = "Item_ID";
            this.Column11.Name = "Column11";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Select";
            this.Column10.Name = "Column10";
            // 
            // Column12
            // 
            this.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            this.Column12.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column12.HeaderText = "Store_ID";
            this.Column12.Name = "Column12";
            this.Column12.Width = 74;
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(701, 17);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(80, 25);
            this.btnTransfer.TabIndex = 6;
            this.btnTransfer.Text = "TRANSFER";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearch.Location = new System.Drawing.Point(605, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(80, 20);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(557, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtStore
            // 
            this.txtStore.BackColor = System.Drawing.SystemColors.Control;
            this.txtStore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStore.Cursor = System.Windows.Forms.Cursors.No;
            this.txtStore.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStore.Location = new System.Drawing.Point(326, 17);
            this.txtStore.Name = "txtStore";
            this.txtStore.Size = new System.Drawing.Size(206, 25);
            this.txtStore.TabIndex = 9;
            this.txtStore.TextChanged += new System.EventHandler(this.txtStore_TextChanged);
            // 
            // btnReceiving
            // 
            this.btnReceiving.Location = new System.Drawing.Point(206, 17);
            this.btnReceiving.Name = "btnReceiving";
            this.btnReceiving.Size = new System.Drawing.Size(80, 25);
            this.btnReceiving.TabIndex = 10;
            this.btnReceiving.Text = "RECEIVING";
            this.btnReceiving.UseVisualStyleBackColor = true;
            this.btnReceiving.Click += new System.EventHandler(this.btnReceiving_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(602, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(792, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "label3";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "ID";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 21;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column7.HeaderText = "Store";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column7.ToolTipText = "Select store for goods transfer";
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReceiving);
            this.Controls.Add(this.txtStore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTransfer);
            this.Name = "Transfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer";
            this.panelTransfer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferSide)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelTransfer;
        private System.Windows.Forms.DataGridView dgvTransferSide;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvStorage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStore;
        private System.Windows.Forms.Button btnReceiving;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}