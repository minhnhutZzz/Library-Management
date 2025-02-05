namespace LibarySystem
{
    partial class frmIssueBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIssueBook));
            this.lblMemberID = new System.Windows.Forms.Label();
            this.lblBookID = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.btnConfim = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dTNgaymuonsach = new System.Windows.Forms.DateTimePicker();
            this.lblNgaymuonsach = new System.Windows.Forms.Label();
           
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblIssueBook = new System.Windows.Forms.Label();
            
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberID.Location = new System.Drawing.Point(57, 114);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(111, 22);
            this.lblMemberID.TabIndex = 0;
            this.lblMemberID.Text = "Member ID:";
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookID.Location = new System.Drawing.Point(57, 174);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(92, 22);
            this.lblBookID.TabIndex = 1;
            this.lblBookID.Text = "Book ID: ";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(209, 115);
            this.txtMemberID.Multiline = true;
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(116, 30);
            this.txtMemberID.TabIndex = 2;
            this.txtMemberID.TextChanged += new System.EventHandler(this.txtMemberID_TextChanged);
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(209, 175);
            this.txtBookID.Multiline = true;
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(116, 30);
            this.txtBookID.TabIndex = 3;
            // 
            // btnConfim
            // 
            this.btnConfim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfim.Location = new System.Drawing.Point(61, 365);
            this.btnConfim.Name = "btnConfim";
            this.btnConfim.Size = new System.Drawing.Size(112, 44);
            this.btnConfim.TabIndex = 4;
            this.btnConfim.Text = "Confim";
            this.btnConfim.UseVisualStyleBackColor = true;
            this.btnConfim.Click += new System.EventHandler(this.btnConfim_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(213, 365);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 44);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dTNgaymuonsach
            // 
            this.dTNgaymuonsach.Location = new System.Drawing.Point(61, 275);
            this.dTNgaymuonsach.Name = "dTNgaymuonsach";
            this.dTNgaymuonsach.Size = new System.Drawing.Size(231, 22);
            this.dTNgaymuonsach.TabIndex = 6;
            this.dTNgaymuonsach.ValueChanged += new System.EventHandler(this.dTNgaymuonsach_ValueChanged);
            // 
            // lblNgaymuonsach
            // 
            this.lblNgaymuonsach.AutoSize = true;
            this.lblNgaymuonsach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaymuonsach.Location = new System.Drawing.Point(57, 231);
            this.lblNgaymuonsach.Name = "lblNgaymuonsach";
            this.lblNgaymuonsach.Size = new System.Drawing.Size(164, 22);
            this.lblNgaymuonsach.TabIndex = 7;
            this.lblNgaymuonsach.Text = "Ngày mượn sách:";
            // 
            // qlyMuonDataSet1
          
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(428, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 541);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(471, 541);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblIssueBook
            // 
            this.lblIssueBook.AutoSize = true;
            this.lblIssueBook.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueBook.Location = new System.Drawing.Point(98, 20);
            this.lblIssueBook.Name = "lblIssueBook";
            this.lblIssueBook.Size = new System.Drawing.Size(205, 41);
            this.lblIssueBook.TabIndex = 9;
            this.lblIssueBook.Text = "Issue Book";
            // 
            // frmIssueBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(861, 541);
            this.Controls.Add(this.lblIssueBook);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNgaymuonsach);
            this.Controls.Add(this.dTNgaymuonsach);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConfim);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.lblBookID);
            this.Controls.Add(this.lblMemberID);
            this.Name = "frmIssueBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "14_IssueBook";
            this.Load += new System.EventHandler(this.frmIssueBook_Load);
           
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Button btnConfim;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DateTimePicker dTNgaymuonsach;
        private System.Windows.Forms.Label lblNgaymuonsach;
       
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblIssueBook;
    }
}