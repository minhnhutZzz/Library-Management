using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibarySystem
{
    public partial class frmViewMember : Form
    {
        listMember lsM=new listMember();
        qlyThanhVienDataContext qlTV=new qlyThanhVienDataContext();


        listMuon lsMuon = new listMuon();
        qlyMuonDataContext qlM = new qlyMuonDataContext();
        public int check { get; set; }
        public string userID {  get; set; }
        public frmViewMember()
        {
            InitializeComponent();
        }

        private void frmViewMember_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlyMuonDataSet1.listMuon' table. You can move, or remove it, as needed.
            this.listMuonTableAdapter.Fill(this.qlyMuonDataSet1.listMuon);


            // TODO: This line of code loads data into the 'qlyThanhvienDataSet.listMembers' table. You can move, or remove it, as needed.
            this.listMembersTableAdapter.Fill(this.qlyThanhvienDataSet.listMembers);

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                var list1 = (from s in qlTV.listMembers where s.ID.Contains(txtIDMember.Text) select s).ToList();
                var list2 = (from s in qlM.listMuons where s.ID_Person.Contains(txtIDMember.Text) select s).ToList();
                if (list1.Count != 0)
                {
                    dGV_viewMember.DataSource = list1;
                    dGV_viewIssueBook.DataSource = list2;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thành viên ", "Thông tin dịch vụ ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmLibaryManagement frmLibaryManagement = new frmLibaryManagement();
            frmLibaryManagement.check = check;
            frmLibaryManagement.User = userID;
            frmLibaryManagement.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
