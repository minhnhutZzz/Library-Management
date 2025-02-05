namespace LibarySystem
{
    partial class frmLibaryManagementMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLibaryManagementMember));
            this.btnIssueLbrMember = new System.Windows.Forms.Button();
            this.btnReturnLbrMember = new System.Windows.Forms.Button();
            this.btnSearchLbrMember = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.taiKhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIssueLbrMember
            // 
            this.btnIssueLbrMember.BackColor = System.Drawing.SystemColors.Window;
            this.btnIssueLbrMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueLbrMember.Location = new System.Drawing.Point(47, 157);
            this.btnIssueLbrMember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIssueLbrMember.Name = "btnIssueLbrMember";
            this.btnIssueLbrMember.Size = new System.Drawing.Size(200, 50);
            this.btnIssueLbrMember.TabIndex = 8;
            this.btnIssueLbrMember.Text = "Issue Book";
            this.btnIssueLbrMember.UseVisualStyleBackColor = false;
            this.btnIssueLbrMember.Click += new System.EventHandler(this.btnIssueLbrMember_Click);
            // 
            // btnReturnLbrMember
            // 
            this.btnReturnLbrMember.BackColor = System.Drawing.SystemColors.Window;
            this.btnReturnLbrMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnLbrMember.Location = new System.Drawing.Point(47, 230);
            this.btnReturnLbrMember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturnLbrMember.Name = "btnReturnLbrMember";
            this.btnReturnLbrMember.Size = new System.Drawing.Size(200, 50);
            this.btnReturnLbrMember.TabIndex = 7;
            this.btnReturnLbrMember.Text = "Return Book";
            this.btnReturnLbrMember.UseVisualStyleBackColor = false;
            this.btnReturnLbrMember.Click += new System.EventHandler(this.btnReturnLbrMember_Click);
            // 
            // btnSearchLbrMember
            // 
            this.btnSearchLbrMember.BackColor = System.Drawing.SystemColors.Window;
            this.btnSearchLbrMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchLbrMember.Location = new System.Drawing.Point(47, 83);
            this.btnSearchLbrMember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchLbrMember.Name = "btnSearchLbrMember";
            this.btnSearchLbrMember.Size = new System.Drawing.Size(200, 50);
            this.btnSearchLbrMember.TabIndex = 6;
            this.btnSearchLbrMember.Text = "Search";
            this.btnSearchLbrMember.UseVisualStyleBackColor = false;
            this.btnSearchLbrMember.Click += new System.EventHandler(this.btnSearchLbrMember_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.Window;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.Red;
            this.btnReturn.Location = new System.Drawing.Point(47, 316);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(200, 50);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taiKhoanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(330, 36);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // taiKhoanToolStripMenuItem
            // 
            this.taiKhoanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.taiKhoanToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taiKhoanToolStripMenuItem.Name = "taiKhoanToolStripMenuItem";
            this.taiKhoanToolStripMenuItem.Size = new System.Drawing.Size(119, 32);
            this.taiKhoanToolStripMenuItem.Text = "Tài Khoản";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(285, 32);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            this.thôngTinTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.thôngTinTàiKhoảnToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(285, 32);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(437, 375);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(330, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 448);
            this.panel1.TabIndex = 12;
            // 
            // frmLibaryManagementMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(820, 448);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnIssueLbrMember);
            this.Controls.Add(this.btnReturnLbrMember);
            this.Controls.Add(this.btnSearchLbrMember);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "frmLibaryManagementMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "14_frmMember";
            this.Load += new System.EventHandler(this.frmLibaryManagementMember_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIssueLbrMember;
        private System.Windows.Forms.Button btnReturnLbrMember;
        private System.Windows.Forms.Button btnSearchLbrMember;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem taiKhoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}