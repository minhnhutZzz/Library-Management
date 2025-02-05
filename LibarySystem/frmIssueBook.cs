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
    public partial class frmIssueBook : Form
    {
        listMuon lsM= new listMuon();
        qlyMuonDataContext qlyM= new qlyMuonDataContext();
        listMember lsTV= new listMember();
        qlyThanhVienDataContext qlyTV= new qlyThanhVienDataContext();


        private DateTimePicker dateTimeMuon;
        public int check { get; set; }
        public string userId {  get; set; }
        public frmIssueBook()
        {
            InitializeComponent();
        }

        private void txtMemberID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfim_Click(object sender, EventArgs e)
        {
            bool flag = false;
            try
            {
                if (int.Parse(txtMemberID.Text) == int.Parse(userId))
                {
                    var lsM1 = qlyM.listMuons.Where(l => l.ID_Person == userId).ToList();
                    
                    foreach (var item in lsM1)
                    {
                        if (int.Parse(item.ID_Book.Trim()) == int.Parse(txtBookID.Text))
                        {
                            flag = true;
                            break;
                        }
                            
                    }
                    if (!flag)
                    {
                        listMuon lsM = new listMuon();
                        lsM.ID_Person = txtMemberID.Text;
                        lsM.ID_Book = txtBookID.Text;
                        dateTimeMuon = new DateTimePicker
                        {
                            Format = DateTimePickerFormat.Custom,// dinh dang tuy chinh cho hien thi ngay
                            CustomFormat = "dd/MM/yyyy",
                            Location = new System.Drawing.Point(10, 10),
                            Width = 200
                        };
                        lsM.NgayMuon = dateTimeMuon.Value;
                        lsM.NgayTra = dateTimeMuon.Value.AddDays(90);


                        qlyM.listMuons.InsertOnSubmit(lsM);
                        qlyM.SubmitChanges();
                        frmIssueBook_Load(sender, e);
                        txtBookID.Clear();
                        txtMemberID.Clear();
                        MessageBox.Show("Bạn đã mượn sách thành công ", "Thông tin dịch vụ ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Bạn đã mượn sách này rồi, vui lòng mượn sách khác! ", "Thông tin dịch vụ ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                else
                {
                    MessageBox.Show("ID không khớp với tài khoản của bạn","Thông tin dịch vụ ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }

            

           

        }

        private void frmIssueBook_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmLibaryManagementMember frmLibaryManagementMember = new frmLibaryManagementMember();
            frmLibaryManagementMember.check = check;
            frmLibaryManagementMember.UserId = userId;
            frmLibaryManagementMember.Show();
            this.Hide();
        }

        private void dTNgaymuonsach_ValueChanged(object sender, EventArgs e)
        {
            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
