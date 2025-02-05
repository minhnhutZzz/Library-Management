namespace LibarySystem
{
    partial class frmBookReviews
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookReviews));
            this.lblNumberofStars = new System.Windows.Forms.Label();
            this.lblComment = new System.Windows.Forms.Label();
            this.txtNumberofStars = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.btnConfim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumberofStars
            // 
            this.lblNumberofStars.AutoSize = true;
            this.lblNumberofStars.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberofStars.Location = new System.Drawing.Point(729, 138);
            this.lblNumberofStars.Name = "lblNumberofStars";
            this.lblNumberofStars.Size = new System.Drawing.Size(202, 29);
            this.lblNumberofStars.TabIndex = 2;
            this.lblNumberofStars.Text = "Number of Stars";
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComment.Location = new System.Drawing.Point(729, 203);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(124, 29);
            this.lblComment.TabIndex = 3;
            this.lblComment.Text = "Comment";
            // 
            // txtNumberofStars
            // 
            this.txtNumberofStars.Location = new System.Drawing.Point(956, 137);
            this.txtNumberofStars.Multiline = true;
            this.txtNumberofStars.Name = "txtNumberofStars";
            this.txtNumberofStars.Size = new System.Drawing.Size(150, 30);
            this.txtNumberofStars.TabIndex = 6;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(729, 257);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(425, 217);
            this.txtComment.TabIndex = 7;
            // 
            // btnConfim
            // 
            this.btnConfim.BackColor = System.Drawing.Color.Blue;
            this.btnConfim.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfim.ForeColor = System.Drawing.Color.White;
            this.btnConfim.Location = new System.Drawing.Point(860, 510);
            this.btnConfim.Name = "btnConfim";
            this.btnConfim.Size = new System.Drawing.Size(139, 58);
            this.btnConfim.TabIndex = 8;
            this.btnConfim.Text = "Confim";
            this.btnConfim.UseVisualStyleBackColor = false;
            this.btnConfim.Click += new System.EventHandler(this.btnConfim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(737, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 36);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mời bạn đánh giá về sách";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 653);
            this.panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(711, 650);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmBookReviews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 653);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfim);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.txtNumberofStars);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.lblNumberofStars);
            this.Name = "frmBookReviews";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBookReviews";
            this.Load += new System.EventHandler(this.frmBookReviews_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNumberofStars;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.TextBox txtNumberofStars;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Button btnConfim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}