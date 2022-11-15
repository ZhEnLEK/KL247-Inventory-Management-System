namespace InventoryManagementSystem
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnItem = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnStore = new System.Windows.Forms.Button();
            this.btnDash = new System.Windows.Forms.Button();
            this.btnTran = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnItem);
            this.panel1.Controls.Add(this.btnUser);
            this.panel1.Controls.Add(this.btnStore);
            this.panel1.Controls.Add(this.btnDash);
            this.panel1.Controls.Add(this.btnTran);
            this.panel1.Controls.Add(this.btnLog);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 40);
            this.panel1.TabIndex = 0;
            // 
            // btnItem
            // 
            this.btnItem.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnItem.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItem.Location = new System.Drawing.Point(380, 0);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(50, 40);
            this.btnItem.TabIndex = 7;
            this.btnItem.Text = "ITEM";
            this.btnItem.UseVisualStyleBackColor = true;
            this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // btnUser
            // 
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnUser.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.Location = new System.Drawing.Point(430, 0);
            this.btnUser.Name = "btnUser";
            this.btnUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUser.Size = new System.Drawing.Size(50, 40);
            this.btnUser.TabIndex = 5;
            this.btnUser.Text = "USER";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnStore
            // 
            this.btnStore.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnStore.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStore.Location = new System.Drawing.Point(480, 0);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(90, 40);
            this.btnStore.TabIndex = 6;
            this.btnStore.Text = "STORE";
            this.btnStore.UseVisualStyleBackColor = true;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // btnDash
            // 
            this.btnDash.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDash.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDash.Location = new System.Drawing.Point(570, 0);
            this.btnDash.Name = "btnDash";
            this.btnDash.Size = new System.Drawing.Size(90, 40);
            this.btnDash.TabIndex = 5;
            this.btnDash.Text = "DASHBOARD";
            this.btnDash.UseVisualStyleBackColor = true;
            this.btnDash.Click += new System.EventHandler(this.btnDash_Click);
            // 
            // btnTran
            // 
            this.btnTran.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTran.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTran.Location = new System.Drawing.Point(660, 0);
            this.btnTran.Name = "btnTran";
            this.btnTran.Size = new System.Drawing.Size(90, 40);
            this.btnTran.TabIndex = 4;
            this.btnTran.Text = "TRANSFER";
            this.btnTran.UseVisualStyleBackColor = true;
            this.btnTran.Click += new System.EventHandler(this.btnTran_Click);
            // 
            // btnLog
            // 
            this.btnLog.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLog.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.Location = new System.Drawing.Point(750, 0);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(50, 40);
            this.btnLog.TabIndex = 3;
            this.btnLog.Text = "LOG";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(20, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "KL247 INVENTORY\r\n";
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 40);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(800, 410);
            this.panelMain.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnDash;
        private System.Windows.Forms.Button btnTran;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.Button btnItem;
    }
}