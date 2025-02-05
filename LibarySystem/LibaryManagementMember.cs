using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibarySystem
{
    public partial class frmLibaryManagementMember : Form
    {
        
        listMember lM=new listMember();
        qlyThanhVienDataContext qlTV=new qlyThanhVienDataContext();


        list_TaiKhoan lsTK= new list_TaiKhoan();
        qlyTaiKhoanDataContext qlyTK= new qlyTaiKhoanDataContext();
        public string UserId { get; set; }
        public int check { get; set; }
       
        public frmLibaryManagementMember()
        {
            InitializeComponent();
           

        }
       

        private void btnSearchLbrMember_Click(object sender, EventArgs e)
        {
            frmSearchBook frmSearch = new frmSearchBook();
            frmSearch.check = check;
            frmSearch.userID = UserId;
            frmSearch.Show();
            this.Close();
        }
        private void btnReturnLbrMember_Click(object sender, EventArgs e)
        {
            frmReturn_Book frmR=new frmReturn_Book();
            frmR.userID =UserId;
            frmR.check = check;
            frmR.Show();
            this.Hide();
        }

        private void btnIssueLbrMember_Click(object sender, EventArgs e)
        {
            frmIssueBook frmIssue = new frmIssueBook();
            frmIssue.check = check;
            frmIssue.userId = UserId;
            frmIssue.Show();
            this.Hide();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLibaryManagementMember_Load(object sender, EventArgs e)
        {

        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                lM = qlTV.listMembers.Where(l => l.ID==UserId).Single();
                string message = $" ID: {lM.ID.Trim()} \n Tên: {lM.FirstName.Trim()} {lM.LastName.Trim()} \n Ngày sinh: {lM.BirthDate.Trim()} \n Địa chỉ: {lM.Address.Trim()}\n Số điện thoại: {lM.ContactNumber.Trim()}";
                MessageBox.Show(message, "Thông tin tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }

            

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Tạo form đăng nhập
            frmLogin frmLogin = new frmLogin();

            // Hiển thị form đăng nhập trước
            frmLogin.Show();

            // Đóng tất cả các form khác ngoại trừ frmLogin
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                var openForm = Application.OpenForms[i];
                if (openForm.Name != frmLogin.Name)
                {
                    openForm.Close();
                }
            }
        }
    }
}
