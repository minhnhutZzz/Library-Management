namespace LibarySystem
{
    partial class frmViewMember
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
            this.components = new System.ComponentModel.Container();
            this.lblMember = new System.Windows.Forms.Label();
            this.txtIDMember = new System.Windows.Forms.TextBox();
            this.btnView = new System.Windows.Forms.Button();
            this.dGV_viewMember = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listMembersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qlyThanhvienDataSet = new LibarySystem.qlyThanhvienDataSet();
            this.listMembersTableAdapter = new LibarySystem.qlyThanhvienDataSetTableAdapters.listMembersTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dGV_viewIssueBook = new System.Windows.Forms.DataGridView();
            this.qlyMuonDataSet1 = new LibarySystem.qlyMuonDataSet1();
            this.listMuonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listMuonTableAdapter = new LibarySystem.qlyMuonDataSet1TableAdapters.listMuonTableAdapter();
            this.iDPersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDBookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayMuonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayTraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_viewMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listMembersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlyThanhvienDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_viewIssueBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlyMuonDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listMuonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMember.ForeColor = System.Drawing.SystemColors.Window;
            this.lblMember.Location = new System.Drawing.Point(204, 33);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(169, 32);
            this.lblMember.TabIndex = 0;
            this.lblMember.Text = "ID Member:";
            // 
            // txtIDMember
            // 
            this.txtIDMember.Location = new System.Drawing.Point(392, 29);
            this.txtIDMember.Multiline = true;
            this.txtIDMember.Name = "txtIDMember";
            this.txtIDMember.Size = new System.Drawing.Size(226, 50);
            this.txtIDMember.TabIndex = 1;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(659, 29);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(90, 50);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // dGV_viewMember
            // 
            this.dGV_viewMember.AutoGenerateColumns = false;
            this.dGV_viewMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_viewMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn,
            this.contactNumberDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dGV_viewMember.DataSource = this.listMembersBindingSource;
            this.dGV_viewMember.Location = new System.Drawing.Point(0, 324);
            this.dGV_viewMember.Name = "dGV_viewMember";
            this.dGV_viewMember.RowHeadersWidth = 51;
            this.dGV_viewMember.RowTemplate.Height = 24;
            this.dGV_viewMember.Size = new System.Drawing.Size(905, 121);
            this.dGV_viewMember.TabIndex = 3;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            this.birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.HeaderText = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            this.birthDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactNumberDataGridViewTextBoxColumn
            // 
            this.contactNumberDataGridViewTextBoxColumn.DataPropertyName = "ContactNumber";
            this.contactNumberDataGridViewTextBoxColumn.HeaderText = "ContactNumber";
            this.contactNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactNumberDataGridViewTextBoxColumn.Name = "contactNumberDataGridViewTextBoxColumn";
            this.contactNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // listMembersBindingSource
            // 
            this.listMembersBindingSource.DataMember = "listMembers";
            this.listMembersBindingSource.DataSource = this.qlyThanhvienDataSet;
            // 
            // qlyThanhvienDataSet
            // 
            this.qlyThanhvienDataSet.DataSetName = "qlyThanhvienDataSet";
            this.qlyThanhvienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listMembersTableAdapter
            // 
            this.listMembersTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Thông tin thành viên: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-5, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Thông tin mượn sách:  ";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(814, 86);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(61, 28);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OliveDrab;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 143);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(902, 127);
            this.panel2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(337, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 41);
            this.label3.TabIndex = 0;
            this.label3.Text = "View Member";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel3.Controls.Add(this.lblMember);
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Controls.Add(this.txtIDMember);
            this.panel3.Controls.Add(this.btnView);
            this.panel3.Location = new System.Drawing.Point(-4, 140);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(909, 127);
            this.panel3.TabIndex = 9;
            // 
            // dGV_viewIssueBook
            // 
            this.dGV_viewIssueBook.AutoGenerateColumns = false;
            this.dGV_viewIssueBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_viewIssueBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPersonDataGridViewTextBoxColumn,
            this.iDBookDataGridViewTextBoxColumn,
            this.ngayMuonDataGridViewTextBoxColumn,
            this.ngayTraDataGridViewTextBoxColumn,
            this.sTTDataGridViewTextBoxColumn});
            this.dGV_viewIssueBook.DataSource = this.listMuonBindingSource;
            this.dGV_viewIssueBook.Location = new System.Drawing.Point(0, 502);
            this.dGV_viewIssueBook.Name = "dGV_viewIssueBook";
            this.dGV_viewIssueBook.RowHeadersWidth = 51;
            this.dGV_viewIssueBook.RowTemplate.Height = 24;
            this.dGV_viewIssueBook.Size = new System.Drawing.Size(716, 150);
            this.dGV_viewIssueBook.TabIndex = 10;
            // 
            // qlyMuonDataSet1
            // 
            this.qlyMuonDataSet1.DataSetName = "qlyMuonDataSet1";
            this.qlyMuonDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listMuonBindingSource
            // 
            this.listMuonBindingSource.DataMember = "listMuon";
            this.listMuonBindingSource.DataSource = this.qlyMuonDataSet1;
            // 
            // listMuonTableAdapter
            // 
            this.listMuonTableAdapter.ClearBeforeFill = true;
            // 
            // iDPersonDataGridViewTextBoxColumn
            // 
            this.iDPersonDataGridViewTextBoxColumn.DataPropertyName = "ID_Person";
            this.iDPersonDataGridViewTextBoxColumn.HeaderText = "ID_Person";
            this.iDPersonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDPersonDataGridViewTextBoxColumn.Name = "iDPersonDataGridViewTextBoxColumn";
            this.iDPersonDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDBookDataGridViewTextBoxColumn
            // 
            this.iDBookDataGridViewTextBoxColumn.DataPropertyName = "ID_Book";
            this.iDBookDataGridViewTextBoxColumn.HeaderText = "ID_Book";
            this.iDBookDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDBookDataGridViewTextBoxColumn.Name = "iDBookDataGridViewTextBoxColumn";
            this.iDBookDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayMuonDataGridViewTextBoxColumn
            // 
            this.ngayMuonDataGridViewTextBoxColumn.DataPropertyName = "NgayMuon";
            this.ngayMuonDataGridViewTextBoxColumn.HeaderText = "NgayMuon";
            this.ngayMuonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayMuonDataGridViewTextBoxColumn.Name = "ngayMuonDataGridViewTextBoxColumn";
            this.ngayMuonDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayTraDataGridViewTextBoxColumn
            // 
            this.ngayTraDataGridViewTextBoxColumn.DataPropertyName = "NgayTra";
            this.ngayTraDataGridViewTextBoxColumn.HeaderText = "NgayTra";
            this.ngayTraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayTraDataGridViewTextBoxColumn.Name = "ngayTraDataGridViewTextBoxColumn";
            this.ngayTraDataGridViewTextBoxColumn.Width = 125;
            // 
            // sTTDataGridViewTextBoxColumn
            // 
            this.sTTDataGridViewTextBoxColumn.DataPropertyName = "STT";
            this.sTTDataGridViewTextBoxColumn.HeaderText = "STT";
            this.sTTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTTDataGridViewTextBoxColumn.Name = "sTTDataGridViewTextBoxColumn";
            this.sTTDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTTDataGridViewTextBoxColumn.Width = 125;
            // 
            // frmViewMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 642);
            this.Controls.Add(this.dGV_viewIssueBook);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGV_viewMember);
            this.Controls.Add(this.panel3);
            this.Name = "frmViewMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmViewMember";
            this.Load += new System.EventHandler(this.frmViewMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_viewMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listMembersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlyThanhvienDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_viewIssueBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlyMuonDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listMuonBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMember;
        private System.Windows.Forms.TextBox txtIDMember;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DataGridView dGV_viewMember;
        private qlyThanhvienDataSet qlyThanhvienDataSet;
        private System.Windows.Forms.BindingSource listMembersBindingSource;
        private qlyThanhvienDataSetTableAdapters.listMembersTableAdapter listMembersTableAdapter;
      
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dGV_viewIssueBook;
        private qlyMuonDataSet1 qlyMuonDataSet1;
        private System.Windows.Forms.BindingSource listMuonBindingSource;
        private qlyMuonDataSet1TableAdapters.listMuonTableAdapter listMuonTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDBookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayMuonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayTraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTTDataGridViewTextBoxColumn;
    }
}