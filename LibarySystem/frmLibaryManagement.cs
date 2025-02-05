using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using WMPLib;
using System.Windows.Forms.DataVisualization.Charting;

namespace LibarySystem
{
    public partial class frmLibaryManagement : Form
    {
       
        public int check { get; set; }
        public string User { get; set; }
        list_QuanMuc lsQM=new list_QuanMuc();
        qlyQuanMucDataContext qlyQM = new qlyQuanMucDataContext();
        public frmLibaryManagement()
        {
            InitializeComponent();
           

        }
       


        private void btnAdd_LbrM_Click(object sender, EventArgs e)
        {
            frmAddBook frmAdd = new frmAddBook();
            frmAdd.checkUser = check;
            frmAdd.Show();
            this.Hide();
        }

        private void btnIssueLbrM_Click(object sender, EventArgs e)
        {
            frmIssueBook frmIss = new frmIssueBook();
            frmIss.check = check;
            frmIss.userId= User;
            frmIss.Show();
            this.Hide();
        }

        private void btnReturnLbrM_Click(object sender, EventArgs e)
        {
            frmReturn_Book frmReturn = new frmReturn_Book();
            frmReturn.userID = User;
            frmReturn.check = check;
            frmReturn.Show();
            this.Hide();
        }

        private void btnSearchLbrM_Click(object sender, EventArgs e)
        {
            frmSearchBook frmSearch = new frmSearchBook();
            frmSearch.check = check;
            frmSearch.userID = User;
            frmSearch.Show();
            this.Close();
        }

        private void btnViewLbrM_Click(object sender, EventArgs e)
        {
            frmViewMember frmVM= new frmViewMember();
            frmVM.check = check;
            frmVM.userID = User;
            frmVM.Show();
            this.Hide();
        }
       

        private void btnGenerateLbrM_Click(object sender, EventArgs e)
        {
            try
            {
                listMember lsMB = new listMember();
                qlyThanhVienDataContext qlyTV = new qlyThanhVienDataContext();


                listBook lsB = new listBook();
                quanliSachDataContext qlyB = new quanliSachDataContext();


                listMuon lsM = new listMuon();
                qlyMuonDataContext qlyM = new qlyMuonDataContext();

                string filePart = @"C:\Users\Minh Nhut\Documents\lập trình hướng đối tượng\Do an cuoi ky OOP\DoAnCuoiKy\Report.txt";
                var DuLieuThanhVien = qlyTV.listMembers.ToList();
                var DuLieuSach = qlyB.listBooks.ToList();
                var DuLieuMuon = qlyM.listMuons.ToList();

                int tong_thanh_vien = qlyTV.listMembers.Count();
                int tong_sach = qlyB.listBooks.Count();
                int tong_luot_muon = qlyM.listMuons.Count();

                using (StreamWriter writer = new StreamWriter(filePart, false))
                {
                    writer.WriteLine($"Tổng thành viên thư viện là: {tong_thanh_vien} thành viên");
                    writer.WriteLine("Danh sách như sau:");
                    writer.WriteLine($"{"ID",-10} {"FirstName",-15} {"LastName",-15} {"BirthDate",-12} {"ContactNumber",-15} {"Address",-20}");
                    writer.WriteLine(new string('-', 80));

                    foreach (var TV in DuLieuThanhVien)
                    {
                        writer.WriteLine($"{TV.ID.Trim(),-10} {TV.FirstName.Trim(),-15} {TV.LastName.Trim(),-15} {TV.BirthDate.Trim(),-12} {TV.ContactNumber.Trim(),-15} {TV.Address.Trim(),-20}");
                    }
                    writer.WriteLine();

                    writer.WriteLine($"Tổng sách trong thư viện là: {tong_sach} sách");
                    writer.WriteLine("Danh sách như sau:");
                    writer.WriteLine($"{"ID",-10} {"Name",-20} \t\t{"Author",-20} \t\t{"Category",-15}");
                    writer.WriteLine(new string('-', 65));

                    foreach (var S in DuLieuSach)
                    {
                        writer.WriteLine($"{S.ID.Trim(),-10} {S.Name.Trim(),-20} \t\t{S.Author.Trim(),-20}\t\t {S.Category.Trim(),-15}");
                    }
                    writer.WriteLine();

                    writer.WriteLine($"Tổng số lượt mượn là: {tong_luot_muon} lượt");
                    writer.WriteLine("Danh sách như sau:");
                    writer.WriteLine($"{"Thành viên",-35} \t\t{"Sách",-25}");
                    writer.WriteLine(new string('-', 60));

                    foreach (var l in DuLieuMuon)
                    {
                        foreach (var S in DuLieuSach)
                        {
                            foreach (var TV in DuLieuThanhVien)
                            {
                                if (l.ID_Person == TV.ID && l.ID_Book == S.ID)
                                {
                                    writer.WriteLine($"{TV.FirstName.Trim()} {TV.LastName.Trim(),-30}\t {S.Name.Trim(),-25}");
                                }
                            }
                        }
                    }
                    writer.WriteLine();

                    MessageBox.Show("Đã lưu dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
            






        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLibaryManagement_Load(object sender, EventArgs e)
        {

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

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                lsQM = qlyQM.list_QuanMucs.Where(l => l.ID == User).Single();
                string message = $" ID: {lsQM.ID.Trim()} \n Tên: {lsQM.FirstName.Trim()} {lsQM.LastName.Trim()} \n Ngày sinh: {lsQM.BirthDate.Trim()} \n Địa chỉ: {lsQM.Address.Trim()}\n Số điện thoại: {lsQM.ContactNumber.Trim()}";
                MessageBox.Show(message, "Thông tin tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            frmThongKe frmThongKe = new frmThongKe();
            frmThongKe.checkUser = check;
            frmThongKe.Show();
            this.Hide();
        }

        private void btnXemdanhgia_Click(object sender, EventArgs e)
        {
            string folderPath = @"C:\BookReviews";

            // Kiểm tra xem thư mục có tồn tại không
            if (!System.IO.Directory.Exists(folderPath))
            {
                MessageBox.Show($"Thư mục '{folderPath}' không tồn tại!");
                return;
            }

            try
            {
                // Mở thư mục
                System.Diagnostics.Process.Start("explorer.exe", folderPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi mở thư mục: {ex.Message}");
            }

        }
    }
}
