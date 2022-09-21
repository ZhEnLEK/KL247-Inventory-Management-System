﻿namespace InventoryManagementSystem
{
    partial class TransferModule
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtDoc = new System.Windows.Forms.TextBox();
            this.txtVehicle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cBoxReceiver = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTransfer = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rbInternal = new System.Windows.Forms.RadioButton();
            this.rbExternal = new System.Windows.Forms.RadioButton();
            this.txtExternal = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 43);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transfer Module";
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(290, 425);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 36);
            this.btnClear.TabIndex = 32;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(209, 425);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 36);
            this.btnUpdate.TabIndex = 31;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(128, 425);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 36);
            this.btnSend.TabIndex = 30;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDoc
            // 
            this.txtDoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDoc.Location = new System.Drawing.Point(144, 205);
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.Size = new System.Drawing.Size(220, 20);
            this.txtDoc.TabIndex = 27;
            this.txtDoc.TextChanged += new System.EventHandler(this.txtDoc_TextChanged);
            // 
            // txtVehicle
            // 
            this.txtVehicle.AllowDrop = true;
            this.txtVehicle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVehicle.Location = new System.Drawing.Point(144, 175);
            this.txtVehicle.Name = "txtVehicle";
            this.txtVehicle.Size = new System.Drawing.Size(220, 20);
            this.txtVehicle.TabIndex = 26;
            this.txtVehicle.TextChanged += new System.EventHandler(this.txtVehicle_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(83, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 14);
            this.label5.TabIndex = 24;
            this.label5.Text = "Vehicle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(67, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 14);
            this.label4.TabIndex = 23;
            this.label4.Text = "Document";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(62, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 14);
            this.label2.TabIndex = 20;
            this.label2.Text = "Transfer to";
            // 
            // cBoxReceiver
            // 
            this.cBoxReceiver.AllowDrop = true;
            this.cBoxReceiver.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cBoxReceiver.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxReceiver.BackColor = System.Drawing.Color.White;
            this.cBoxReceiver.FormattingEnabled = true;
            this.cBoxReceiver.Location = new System.Drawing.Point(145, 117);
            this.cBoxReceiver.Name = "cBoxReceiver";
            this.cBoxReceiver.Size = new System.Drawing.Size(220, 21);
            this.cBoxReceiver.TabIndex = 33;
            this.cBoxReceiver.SelectedIndexChanged += new System.EventHandler(this.cBoxReceiver_SelectedIndexChanged);
            this.cBoxReceiver.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cBoxReceiver_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(99, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 14);
            this.label3.TabIndex = 34;
            this.label3.Text = "Date";
            // 
            // dateTransfer
            // 
            this.dateTransfer.AllowDrop = true;
            this.dateTransfer.CalendarFont = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTransfer.CausesValidation = false;
            this.dateTransfer.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTransfer.Location = new System.Drawing.Point(145, 65);
            this.dateTransfer.Name = "dateTransfer";
            this.dateTransfer.Size = new System.Drawing.Size(110, 20);
            this.dateTransfer.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(407, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "label6";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView1.Location = new System.Drawing.Point(38, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(577, 150);
            this.dataGridView1.TabIndex = 37;
            // 
            // rbInternal
            // 
            this.rbInternal.AutoSize = true;
            this.rbInternal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInternal.Location = new System.Drawing.Point(144, 89);
            this.rbInternal.Name = "rbInternal";
            this.rbInternal.Size = new System.Drawing.Size(81, 24);
            this.rbInternal.TabIndex = 38;
            this.rbInternal.Text = "Internal";
            this.rbInternal.UseVisualStyleBackColor = true;
            this.rbInternal.CheckedChanged += new System.EventHandler(this.rbInternal_CheckedChanged);
            // 
            // rbExternal
            // 
            this.rbExternal.AutoSize = true;
            this.rbExternal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbExternal.Location = new System.Drawing.Point(279, 89);
            this.rbExternal.Name = "rbExternal";
            this.rbExternal.Size = new System.Drawing.Size(85, 24);
            this.rbExternal.TabIndex = 39;
            this.rbExternal.Text = "External";
            this.rbExternal.UseVisualStyleBackColor = true;
            this.rbExternal.CheckedChanged += new System.EventHandler(this.rbExternal_CheckedChanged);
            // 
            // txtExternal
            // 
            this.txtExternal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtExternal.Location = new System.Drawing.Point(145, 147);
            this.txtExternal.Name = "txtExternal";
            this.txtExternal.Size = new System.Drawing.Size(220, 20);
            this.txtExternal.TabIndex = 40;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Item";
            this.Column1.Name = "Column1";
            this.Column1.Width = 52;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Size";
            this.Column2.Name = "Column2";
            this.Column2.Width = 52;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Pattern";
            this.Column3.Name = "Column3";
            this.Column3.Width = 66;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Branding_code";
            this.Column4.Name = "Column4";
            this.Column4.Width = 104;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "Serial_number";
            this.Column5.Name = "Column5";
            this.Column5.Width = 99;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = "1";
            this.Column6.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column6.HeaderText = "Qty";
            this.Column6.MaxInputLength = 2;
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column6.ToolTipText = "Edit quantity accordingly";
            this.Column6.Width = 29;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle8.Format = "N0";
            dataGridViewCellStyle8.NullValue = null;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column7.HeaderText = "Log_ID";
            this.Column7.Name = "Column7";
            this.Column7.Width = 67;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Item_ID";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            dataGridViewCellStyle9.Format = "N0";
            dataGridViewCellStyle9.NullValue = null;
            this.Column9.DefaultCellStyle = dataGridViewCellStyle9;
            this.Column9.HeaderText = "Store_ID";
            this.Column9.Name = "Column9";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(67, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 14);
            this.label7.TabIndex = 41;
            this.label7.Text = "Customer";
            // 
            // TransferModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 503);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtExternal);
            this.Controls.Add(this.rbExternal);
            this.Controls.Add(this.rbInternal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTransfer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cBoxReceiver);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtDoc);
            this.Controls.Add(this.txtVehicle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "TransferModule";
            this.Text = "TransferModule";
            this.Load += new System.EventHandler(this.TransferModule_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtDoc;
        private System.Windows.Forms.TextBox txtVehicle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBoxReceiver;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTransfer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rbInternal;
        private System.Windows.Forms.RadioButton rbExternal;
        private System.Windows.Forms.TextBox txtExternal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Label label7;
    }
}