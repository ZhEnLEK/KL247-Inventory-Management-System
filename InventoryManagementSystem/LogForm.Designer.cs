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
            this.panelRight = new System.Windows.Forms.Panel();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.cBoxSize = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVeh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxParty = new System.Windows.Forms.ComboBox();
            this.lblParty = new System.Windows.Forms.Label();
            this.lblTransfer = new System.Windows.Forms.Label();
            this.txtSN = new System.Windows.Forms.TextBox();
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
            this.panelLogMain = new System.Windows.Forms.Panel();
            this.dgvLog = new System.Windows.Forms.DataGridView();
            this.cBoxTran = new System.Windows.Forms.ComboBox();
            this.panelRight.SuspendLayout();
            this.panelLogMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.cBoxTran);
            this.panelRight.Controls.Add(this.btnClearFilter);
            this.panelRight.Controls.Add(this.cBoxSize);
            this.panelRight.Controls.Add(this.label3);
            this.panelRight.Controls.Add(this.txtVeh);
            this.panelRight.Controls.Add(this.label2);
            this.panelRight.Controls.Add(this.txtDoc);
            this.panelRight.Controls.Add(this.label1);
            this.panelRight.Controls.Add(this.cBoxParty);
            this.panelRight.Controls.Add(this.lblParty);
            this.panelRight.Controls.Add(this.lblTransfer);
            this.panelRight.Controls.Add(this.txtSN);
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
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(780, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(180, 573);
            this.panelRight.TabIndex = 4;
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFilter.Location = new System.Drawing.Point(15, 12);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(128, 33);
            this.btnClearFilter.TabIndex = 28;
            this.btnClearFilter.Text = "CLEAR FILTER";
            this.btnClearFilter.UseVisualStyleBackColor = true;
            this.btnClearFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // cBoxSize
            // 
            this.cBoxSize.AutoCompleteCustomSource.AddRange(new string[] {
            "295/80R22.5",
            "11R22.5",
            "12R22.5"});
            this.cBoxSize.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cBoxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxSize.FormattingEnabled = true;
            this.cBoxSize.Items.AddRange(new object[] {
            "295/80R22.5",
            "11R22.5",
            "12R22.5"});
            this.cBoxSize.Location = new System.Drawing.Point(15, 197);
            this.cBoxSize.Name = "cBoxSize";
            this.cBoxSize.Size = new System.Drawing.Size(120, 21);
            this.cBoxSize.TabIndex = 27;
            this.cBoxSize.SelectedIndexChanged += new System.EventHandler(this.cBoxSize_SelectedIndexChanged);
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
            this.txtVeh.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVeh.Location = new System.Drawing.Point(15, 538);
            this.txtVeh.Name = "txtVeh";
            this.txtVeh.Size = new System.Drawing.Size(100, 20);
            this.txtVeh.TabIndex = 25;
            this.txtVeh.TextChanged += new System.EventHandler(this.txtVeh_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 519);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "VEHICLE";
            // 
            // txtDoc
            // 
            this.txtDoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDoc.Location = new System.Drawing.Point(15, 496);
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.Size = new System.Drawing.Size(100, 20);
            this.txtDoc.TabIndex = 23;
            this.txtDoc.TextChanged += new System.EventHandler(this.txtDoc_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 477);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "DOCUMENT";
            // 
            // cBoxParty
            // 
            this.cBoxParty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cBoxParty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxParty.FormattingEnabled = true;
            this.cBoxParty.Location = new System.Drawing.Point(15, 453);
            this.cBoxParty.Name = "cBoxParty";
            this.cBoxParty.Size = new System.Drawing.Size(120, 21);
            this.cBoxParty.TabIndex = 21;
            this.cBoxParty.SelectedIndexChanged += new System.EventHandler(this.cBoxParty_SelectedIndexChanged);
            this.cBoxParty.TextChanged += new System.EventHandler(this.cBoxParty_TextChanged);
            this.cBoxParty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cBoxParty_KeyPress);
            // 
            // lblParty
            // 
            this.lblParty.AutoSize = true;
            this.lblParty.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParty.Location = new System.Drawing.Point(12, 434);
            this.lblParty.Name = "lblParty";
            this.lblParty.Size = new System.Drawing.Size(42, 16);
            this.lblParty.TabIndex = 20;
            this.lblParty.Text = "PARTY";
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
            // txtSN
            // 
            this.txtSN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSN.Location = new System.Drawing.Point(15, 368);
            this.txtSN.Name = "txtSN";
            this.txtSN.Size = new System.Drawing.Size(100, 20);
            this.txtSN.TabIndex = 17;
            this.txtSN.TextChanged += new System.EventHandler(this.txtSN_TextChanged);
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
            this.cBoxPattern.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cBoxPattern.SelectedIndexChanged += new System.EventHandler(this.cBoxPattern_SelectedIndexChanged);
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
            this.cBoxBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cBoxBrand.SelectedIndexChanged += new System.EventHandler(this.cBoxBrand_SelectedIndexChanged);
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
            this.txtCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCode.Location = new System.Drawing.Point(15, 240);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 11;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(12, 221);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(131, 16);
            this.lblCode.TabIndex = 10;
            this.lblCode.Text = "TYRE BRANDING CODE";
            // 
            // dateEnd
            // 
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEnd.Location = new System.Drawing.Point(53, 99);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(100, 20);
            this.dateEnd.TabIndex = 9;
            this.dateEnd.Value = new System.DateTime(2022, 10, 26, 0, 0, 0, 0);
            this.dateEnd.ValueChanged += new System.EventHandler(this.dateEnd_ValueChanged);
            // 
            // dateStart
            // 
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateStart.Location = new System.Drawing.Point(53, 65);
            this.dateStart.Name = "dateStart";
            this.dateStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateStart.Size = new System.Drawing.Size(100, 20);
            this.dateStart.TabIndex = 8;
            this.dateStart.Value = new System.DateTime(2022, 10, 26, 0, 0, 0, 0);
            this.dateStart.CloseUp += new System.EventHandler(this.dateStart_CloseUp);
            this.dateStart.ValueChanged += new System.EventHandler(this.dateStart_ValueChanged);
            // 
            // cBoxItem
            // 
            this.cBoxItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cBoxItem.SelectedIndexChanged += new System.EventHandler(this.cBoxItem_SelectedIndexChanged);
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
            this.dgvLog.AllowUserToDeleteRows = false;
            this.dgvLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLog.Location = new System.Drawing.Point(0, 0);
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.RowHeadersVisible = false;
            this.dgvLog.Size = new System.Drawing.Size(780, 573);
            this.dgvLog.TabIndex = 4;
            this.dgvLog.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLog_CellContentClick_1);
            // 
            // cBoxTran
            // 
            this.cBoxTran.AutoCompleteCustomSource.AddRange(new string[] {
            "pattern",
            "pat",
            "pat"});
            this.cBoxTran.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxTran.FormattingEnabled = true;
            this.cBoxTran.Items.AddRange(new object[] {
            "All transfer",
            "IN",
            "OUT"});
            this.cBoxTran.Location = new System.Drawing.Point(15, 410);
            this.cBoxTran.Name = "cBoxTran";
            this.cBoxTran.Size = new System.Drawing.Size(120, 21);
            this.cBoxTran.TabIndex = 29;
            this.cBoxTran.SelectedIndexChanged += new System.EventHandler(this.cBoxTran_SelectedIndexChanged);
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
        private System.Windows.Forms.Label lblTransfer;
        private System.Windows.Forms.TextBox txtSN;
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
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.ComboBox cBoxTran;
    }
}