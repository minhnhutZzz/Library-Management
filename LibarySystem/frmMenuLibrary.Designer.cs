namespace LibarySystem
{
    partial class frmMenuLib
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuLib));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.lbMenuLibrarians = new System.Windows.Forms.ToolStripMenuItem();
            this.lbMenuMembers = new System.Windows.Forms.ToolStripMenuItem();
            this.lbMenuLogout = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(816, 416);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbMenuLibrarians,
            this.lbMenuMembers,
            this.lbMenuLogout});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(495, 46);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // lbMenuLibrarians
            // 
            this.lbMenuLibrarians.Image = ((System.Drawing.Image)(resources.GetObject("lbMenuLibrarians.Image")));
            this.lbMenuLibrarians.Name = "lbMenuLibrarians";
            this.lbMenuLibrarians.Size = new System.Drawing.Size(179, 42);
            this.lbMenuLibrarians.Text = "Librarians";
            this.lbMenuLibrarians.Click += new System.EventHandler(this.lbMenuLibrarians_Click);
            // 
            // lbMenuMembers
            // 
            this.lbMenuMembers.Image = ((System.Drawing.Image)(resources.GetObject("lbMenuMembers.Image")));
            this.lbMenuMembers.Name = "lbMenuMembers";
            this.lbMenuMembers.Size = new System.Drawing.Size(174, 42);
            this.lbMenuMembers.Text = "Members";
            this.lbMenuMembers.Click += new System.EventHandler(this.lbMenuMembers_Click);
            // 
            // lbMenuLogout
            // 
            this.lbMenuLogout.Name = "lbMenuLogout";
            this.lbMenuLogout.Size = new System.Drawing.Size(132, 42);
            this.lbMenuLogout.Text = "Log out";
            this.lbMenuLogout.Click += new System.EventHandler(this.lbMenuLogout_Click);
            // 
            // frmMenuLib
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 456);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmMenuLib";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MenuLibrary";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenuLib_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem lbMenuLibrarians;
        private System.Windows.Forms.ToolStripMenuItem lbMenuMembers;
        private System.Windows.Forms.ToolStripMenuItem lbMenuLogout;
    }
}