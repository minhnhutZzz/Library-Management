using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace LibarySystem
{
    public partial class frmBookReviews : Form
    {
        listMember lsTV= new listMember();
        qlyThanhVienDataContext qlyTV = new qlyThanhVienDataContext();
        listBook lsB= new listBook();
        quanliSachDataContext qlyB= new quanliSachDataContext();
        public int check { get; set; }
        public string userId { get; set; }
        public string BookID { get; set; }  
        public frmBookReviews()
        {
            InitializeComponent();
        }

        private void btnConfim_Click(object sender, EventArgs e)
        {
           
            lsB=qlyB.listBooks.Where(l=>l.ID==BookID).Single();
            
            int numberOfStars;
            if (!int.TryParse(txtNumberofStars.Text, out numberOfStars) || numberOfStars < 1 || numberOfStars > 5)
            {
                MessageBox.Show("Số sao phải nằm trong khoảng từ 1 đến 5.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string comment = txtComment.Text;

            // Loại bỏ ký tự không hợp lệ trong tên file (cho tên sách)
            string sanitizedBookName = Regex.Replace(lsB.Name, @"[<>:""/\\|?*]", "_");

            // Tạo đường dẫn file theo tên sách
            string directory = @"C:\BookReviews"; // Thư mục lưu file
            Directory.CreateDirectory(directory); // Tạo thư mục nếu chưa tồn tại
            string filePath = Path.Combine(directory, $"{sanitizedBookName}.txt");

            // Tạo nội dung để lưu vào file
            lsTV = qlyTV.listMembers.Where(l => l.ID == userId).Single();
            string data = $"Tên người đánh giá: {lsTV.FirstName.Trim()} {lsTV.LastName.Trim()}\n" +
                          $"Số sao: {numberOfStars}\n" +
                          $"Nhận xét: {comment}\n" +
                          $"-------------------------\n";

            try
            {
                // Lưu vào file (append mode)
                File.AppendAllText(filePath, data);

                // Thông báo lưu thành công
                MessageBox.Show($"Đánh giá đã được lưu vào file: {filePath}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmLibaryManagementMember frmLibaryManagementMember = new frmLibaryManagementMember();
                frmLibaryManagementMember.UserId = userId;
                frmLibaryManagementMember.check = check;
                frmLibaryManagementMember.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                // Thông báo lỗi nếu không thể lưu file
                MessageBox.Show($"Không thể lưu file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmBookReviews_Load(object sender, EventArgs e)
        {

        }
    }
}
