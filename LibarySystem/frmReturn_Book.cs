using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibarySystem
{
    public partial class frmReturn_Book : Form
    {

        listMuon lsM= new listMuon();
        qlyMuonDataContext qlM= new qlyMuonDataContext();
        list_TaiKhoan lsTK = new list_TaiKhoan();
        qlyTaiKhoanDataContext qlyTK= new qlyTaiKhoanDataContext();
        listBook lsB = new listBook();
        quanliSachDataContext qlyB = new quanliSachDataContext();
        
        public string BookID { get; set; }
        public string userID { get; set; }
        public int check { get; set; }
        public frmReturn_Book()
        {
            InitializeComponent();
        }

        private void btnConfim_Click(object sender, EventArgs e)
        {
            try
            {

                if (int.Parse(txtMemberID.Text) == int.Parse(userID))
                {
                    var lsm = qlM.listMuons
             .Where(s => s.ID_Person == txtMemberID.Text && s.ID_Book == txtBookID.Text && s.NgayMuon != null)
             .SingleOrDefault();// tra ve pt duy nhat
                    if (lsm != null)
                    {
                        lsm.ID_Person = txtMemberID.Text;
                        lsm.ID_Book = txtBookID.Text;
                        qlM.listMuons.DeleteOnSubmit(lsm);
                        qlM.SubmitChanges();
                        MessageBox.Show("Cảm ơn bạn đã mượn sách tại thư viện\nNếu muốn đọc cuốn sách nào hãy tới mượn tiếp nhé!.", "Thông tin dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmReturn_Book_Load(sender, e);
                        frmBookReviews frmBookReviews = new frmBookReviews();
                        frmBookReviews.check= check;
                        frmBookReviews.userId=userID;
                        frmBookReviews.BookID=txtBookID.Text;
                        frmBookReviews.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu phù hợp.", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                
                }
                else
                {
                    MessageBox.Show("ID không khớp với tài khoản của bạn", "Thông tin dịch vụ ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
            
            
        }

        private void frmReturn_Book_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmLibaryManagementMember frmLibaryManagementMember = new frmLibaryManagementMember();
            frmLibaryManagementMember.UserId = userID;
            frmLibaryManagementMember.check = 2;
            frmLibaryManagementMember.Show();
            this.Hide();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {


        }

        private void bunifuRange1_RangeChanged(object sender, EventArgs e)
        {

        }
    }
}
