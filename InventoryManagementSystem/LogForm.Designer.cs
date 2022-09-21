namespace InventoryManagementSystem
{
    partial class LogForm
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
            this.panelRight = new System.Windows.Forms.Panel();
            this.cBoxSize = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVeh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxParty = new System.Windows.Forms.ComboBox();
            this.lblParty = new System.Windows.Forms.Label();
            this.lBoxTrans = new System.Windows.Forms.ListBox();
            this.lblTransfer = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblSerial = new System.Windows.Forms.Label();
            this.cBoxPattern = new System.Windows.Forms.ComboBox();
            this.lblPattern = new System.Windows.Forms.Label();
            this.cBoxBrand = new System.Windows.Forms.ComboBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.cBoxItem = new System.Windows.Forms.ComboBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.panelLogMain = new System.Windows.Forms.Panel();
            this.dgvLog = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelRight.SuspendLayout();
            this.panelLogMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.cBoxSize);
            this.panelRight.Controls.Add(this.label3);
            this.panelRight.Controls.Add(this.txtVeh);
            this.panelRight.Controls.Add(this.label2);
            this.panelRight.Controls.Add(this.txtDoc);
            this.panelRight.Controls.Add(this.label1);
            this.panelRight.Controls.Add(this.cBoxParty);
            this.panelRight.Controls.Add(this.lblParty);
            this.panelRight.Controls.Add(this.lBoxTrans);
            this.panelRight.Controls.Add(this.lblTransfer);
            this.panelRight.Controls.Add(this.textBox1);
            this.panelRight.Controls.Add(this.lblSerial);
            this.panelRight.Controls.Add(this.cBoxPattern);
            this.panelRight.Controls.Add(this.lblPattern);
            this.panelRight.Controls.Add(this.cBoxBrand);
            this.panelRight.Controls.Add(this.lblBrand);
            this.panelRight.Controls.Add(this.txtCode);
            this.panelRight.Controls.Add(this.lblCode);
            this.panelRight.Controls.Add(this.dateEnd);
            this.panelRight.Controls.Add(this.dateStart);
            this.panelRight.Controls.Add(this.cBoxItem);
            this.panelRight.Controls.Add(this.lblItem);
            this.panelRight.Controls.Add(this.lblEnd);
            this.panelRight.Controls.Add(this.lblStart);
            this.panelRight.Controls.Add(this.lblDate);
            this.panelRight.Controls.Add(this.lblSearch);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(780, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(180, 573);
            this.panelRight.TabIndex = 4;
            // 
            // cBoxSize
            // 
            this.cBoxSize.AutoCompleteCustomSource.AddRange(new string[] {
            "295/80R22.5",
            "11R22.5",
            "12R22.5"});
            this.cBoxSize.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cBoxSize.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cBoxSize.FormattingEnabled = true;
            this.cBoxSize.Items.AddRange(new object[] {
            "295/80R22.5",
            "11R22.5",
            "12R22.5"});
            this.cBoxSize.Location = new System.Drawing.Point(15, 197);
            this.cBoxSize.Name = "cBoxSize";
            this.cBoxSize.Size = new System.Drawing.Size(120, 21);
            this.cBoxSize.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "SIZE";
            // 
            // txtVeh
            // 
            this.txtVeh.Location = new System.Drawing.Point(15, 532);
            this.txtVeh.Name = "txtVeh";
            this.txtVeh.Size = new System.Drawing.Size(100, 20);
            this.txtVeh.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 513);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "VEHICLE";
            // 
            // txtDoc
            // 
            this.txtDoc.Location = new System.Drawing.Point(15, 490);
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.Size = new System.Drawing.Size(100, 20);
            this.txtDoc.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 471);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "DOCUMENT";
            // 
            // cBoxParty
            // 
            this.cBoxParty.AutoCompleteCustomSource.AddRange(new string[] {
            "c2r",
            "c2pk",
            "s2s",
            "egb",
            "c4sj"});
            this.cBoxParty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cBoxParty.FormattingEnabled = true;
            this.cBoxParty.Items.AddRange(new object[] {
            "cr",
            "ck",
            "eg",
            "s2"});
            this.cBoxParty.Location = new System.Drawing.Point(15, 447);
            this.cBoxParty.Name = "cBoxParty";
            this.cBoxParty.Size = new System.Drawing.Size(120, 21);
            this.cBoxParty.TabIndex = 21;
            // 
            // lblParty
            // 
            this.lblParty.AutoSize = true;
            this.lblParty.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParty.Location = new System.Drawing.Point(12, 428);
            this.lblParty.Name = "lblParty";
            this.lblParty.Size = new System.Drawing.Size(42, 16);
            this.lblParty.TabIndex = 20;
            this.lblParty.Text = "PARTY";
            // 
            // lBoxTrans
            // 
            this.lBoxTrans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lBoxTrans.FormattingEnabled = true;
            this.lBoxTrans.Items.AddRange(new object[] {
            "OUT",
            "IN"});
            this.lBoxTrans.Location = new System.Drawing.Point(15, 410);
            this.lBoxTrans.Name = "lBoxTrans";
            this.lBoxTrans.Size = new System.Drawing.Size(120, 15);
            this.lBoxTrans.TabIndex = 19;
            // 
            // lblTransfer
            // 
            this.lblTransfer.AutoSize = true;
            this.lblTransfer.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransfer.Location = new System.Drawing.Point(12, 391);
            this.lblTransfer.Name = "lblTransfer";
            this.lblTransfer.Size = new System.Drawing.Size(66, 16);
            this.lblTransfer.TabIndex = 18;
            this.lblTransfer.Text = "TRANSFER";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 368);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 17;
            // 
            // lblSerial
            // 
            this.lblSerial.AutoSize = true;
            this.lblSerial.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerial.Location = new System.Drawing.Point(12, 349);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(99, 16);
            this.lblSerial.TabIndex = 16;
            this.lblSerial.Text = "SERIAL NUMBER";
            // 
            // cBoxPattern
            // 
            this.cBoxPattern.AutoCompleteCustomSource.AddRange(new string[] {
            "pattern",
            "pat",
            "pat"});
            this.cBoxPattern.FormattingEnabled = true;
            this.cBoxPattern.Items.AddRange(new object[] {
            "test",
            "test",
            "test",
            "test"});
            this.cBoxPattern.Location = new System.Drawing.Point(15, 325);
            this.cBoxPattern.Name = "cBoxPattern";
            this.cBoxPattern.Size = new System.Drawing.Size(120, 21);
            this.cBoxPattern.TabIndex = 15;
            // 
            // lblPattern
            // 
            this.lblPattern.AutoSize = true;
            this.lblPattern.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPattern.Location = new System.Drawing.Point(12, 306);
            this.lblPattern.Name = "lblPattern";
            this.lblPattern.Size = new System.Drawing.Size(56, 16);
            this.lblPattern.TabIndex = 14;
            this.lblPattern.Text = "PATTERN";
            // 
            // cBoxBrand
            // 
            this.cBoxBrand.AutoCompleteCustomSource.AddRange(new string[] {
            "tyre",
            "tyre",
            "tyre"});
            this.cBoxBrand.FormattingEnabled = true;
            this.cBoxBrand.Items.AddRange(new object[] {
            "test",
            "test",
            "test",
            "test"});
            this.cBoxBrand.Location = new System.Drawing.Point(15, 282);
            this.cBoxBrand.Name = "cBoxBrand";
            this.cBoxBrand.Size = new System.Drawing.Size(120, 21);
            this.cBoxBrand.TabIndex = 13;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.Location = new System.Drawing.Point(12, 263);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(46, 16);
            this.lblBrand.TabIndex = 12;
            this.lblBrand.Text = "BRAND";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(15, 240);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 11;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(12, 221);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(38, 16);
            this.lblCode.TabIndex = 10;
            this.lblCode.Text = "CODE";
            // 
            // dateEnd
            // 
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEnd.Location = new System.Drawing.Point(53, 99);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(100, 20);
            this.dateEnd.TabIndex = 9;
            this.dateEnd.Value = new System.DateTime(2022, 8, 17, 15, 30, 12, 0);
            // 
            // dateStart
            // 
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateStart.Location = new System.Drawing.Point(53, 65);
            this.dateStart.Name = "dateStart";
            this.dateStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateStart.Size = new System.Drawing.Size(100, 20);
            this.dateStart.TabIndex = 8;
            this.dateStart.Value = new System.DateTime(2022, 8, 18, 0, 0, 0, 0);
            // 
            // cBoxItem
            // 
            this.cBoxItem.FormattingEnabled = true;
            this.cBoxItem.Items.AddRange(new object[] {
            "test",
            "test",
            "test",
            "test"});
            this.cBoxItem.Location = new System.Drawing.Point(15, 154);
            this.cBoxItem.Name = "cBoxItem";
            this.cBoxItem.Size = new System.Drawing.Size(120, 21);
            this.cBoxItem.TabIndex = 7;
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.Location = new System.Drawing.Point(12, 135);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(33, 16);
            this.lblItem.TabIndex = 6;
            this.lblItem.Text = "ITEM";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.Location = new System.Drawing.Point(12, 101);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(30, 16);
            this.lblEnd.TabIndex = 3;
            this.lblEnd.Text = "End";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(12, 67);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(35, 16);
            this.lblStart.TabIndex = 2;
            this.lblStart.Text = "Start";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(12, 48);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(35, 16);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "DATE";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(12, 15);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(53, 16);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "SEARCH";
            this.lblSearch.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelLogMain
            // 
            this.panelLogMain.Controls.Add(this.dgvLog);
            this.panelLogMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogMain.Location = new System.Drawing.Point(0, 0);
            this.panelLogMain.Name = "panelLogMain";
            this.panelLogMain.Size = new System.Drawing.Size(780, 573);
            this.panelLogMain.TabIndex = 5;
            // 
            // dgvLog
            // 
            this.dgvLog.AllowUserToAddRows = false;
            this.dgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column10,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column11,
            this.Column12});
            this.dgvLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLog.Location = new System.Drawing.Point(0, 0);
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.Size = new System.Drawing.Size(780, 573);
            this.dgvLog.TabIndex = 4;
            this.dgvLog.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLog_CellContentClick_1);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "Date";
            this.Column1.Name = "Column1";
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 36;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Item";
            this.Column2.Name = "Column2";
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 33;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column10.HeaderText = "Size";
            this.Column10.Name = "Column10";
            this.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column10.Width = 33;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Code";
            this.Column3.Name = "Column3";
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 38;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Brand";
            this.Column4.Name = "Column4";
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 41;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "Pattern";
            this.Column5.Name = "Column5";
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Width = 47;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "Serial no.";
            this.Column6.Name = "Column6";
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column6.Width = 57;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "Transfer";
            this.Column7.Name = "Column7";
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column7.Width = 52;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.HeaderText = "Party";
            this.Column8.Name = "Column8";
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column9.HeaderText = "Quantity";
            this.Column9.Name = "Column9";
            this.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column9.Width = 52;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column11.HeaderText = "Document";
            this.Column11.Name = "Column11";
            this.Column11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column11.Width = 62;
            // 
            // Column12
            // 
            this.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column12.HeaderText = "Vehicle";
            this.Column12.Name = "Column12";
            this.Column12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column12.Width = 48;
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 573);
            this.Controls.Add(this.panelLogMain);
            this.Controls.Add(this.panelRight);
            this.Name = "LogForm";
            this.Text = "LogForm";
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.panelLogMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ListBox lBoxTrans;
        private System.Windows.Forms.Label lblTransfer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.ComboBox cBoxPattern;
        private System.Windows.Forms.Label lblPattern;
        private System.Windows.Forms.ComboBox cBoxBrand;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.ComboBox cBoxItem;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cBoxParty;
        private System.Windows.Forms.Label lblParty;
        private System.Windows.Forms.Panel panelLogMain;
        private System.Windows.Forms.DataGridView dgvLog;
        private System.Windows.Forms.TextBox txtVeh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
    }
}