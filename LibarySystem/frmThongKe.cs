using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web.UI;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LibarySystem
{
    public partial class frmThongKe : Form
    {
        public int checkUser { get; set; }
        public frmThongKe()
        {
            InitializeComponent();
        }

        
        qlyMuonDataContext qlM = new qlyMuonDataContext();

       
        private void frmThongKe_Load(object sender, EventArgs e)
        {
            
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            try
            {
                listMuon lsM = new listMuon();
                qlyMuonDataContext qlyM = new qlyMuonDataContext();
                listBook lsB = new listBook();
                quanliSachDataContext qlyB = new quanliSachDataContext();
                listMember lsMB = new listMember();
                qlyThanhVienDataContext qlyTV = new qlyThanhVienDataContext();


                // Bước 1: Truy xuất dữ liệu từ cơ sở dữ liệu
                var listMuons = qlM.listMuons.ToList(); // ToList() để tải dữ liệu vào bộ nhớ
                var listBooks = qlyB.listBooks.ToList(); // Tương tự với danh sách sách

                // Bước 2: Thống kê số lần mượn theo sách
                var bookStatistics = listMuons
                    .Where(m => !string.IsNullOrEmpty(m.ID_Book)) // Loại bỏ bản ghi null
                    .GroupBy(m => m.ID_Book) // gom nhom theo ID_Book
                    .Select(g => new// tao doi tuong moi chua ma sach, so lan muon
                    {
                        BookID = g.Key,
                        BorrowCount = g.Count() // Đếm số lần mượn
                    })
                    .ToList(); // Chuyển thành danh sách trong bộ nhớ

                // Bước 3: Kết nối dữ liệu từ bảng `listBooks` để lấy tên sách
                var detailedStatistics = bookStatistics
                    .Join(listBooks, // Kết nối bảng thống kê với danh sách sách
                          m => m.BookID,
                          b => b.ID,
                          (m, b) => new
                          {
                              BookName = b.Name,     // Lấy tên sách
                              BorrowCount = m.BorrowCount // Số lần mượn
                          })
                    .ToList(); // Chuyển thành danh sách trong bộ nhớ



                // Hiển thị thống kê trong biểu đồ
                chart1Books.Series.Clear();
                var series = chart1Books.Series.Add("SỐ LẦN MƯỢN ");
                series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

                foreach (var item in detailedStatistics)// them du lieu vao bieu do
                {
                    series.Points.AddXY(item.BookName, item.BorrowCount); // them 2 diem du lieu vao chuoi ten sach
                }


                // Tùy chỉnh biểu đồ
                chart1Books.ChartAreas[0].AxisX.Title = "TÊN SÁCH ";
                chart1Books.ChartAreas[0].AxisY.Title = "SỐ LẦN MƯỢN";
                chart1Books.ChartAreas[0].AxisX.LabelStyle.Angle = -45;// goc nghien
                chart1Books.Legends[0].Enabled = false;

                // Tăng kích thước và in đậm chữ trên trục X

                chart1Books.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 10, FontStyle.Bold);


                // Tùy chỉnh kích thước và in đậm cho tiêu đề trục X
                chart1Books.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 12, FontStyle.Bold);

                // Tùy chỉnh kích thước và in đậm cho tiêu đề trục Y
                chart1Books.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 12, FontStyle.Bold);


                //=========================================================================================================================



                // Lấy danh sách thành viên và danh sách mượn từ cơ sở dữ liệu
                var listMembers = qlyTV.listMembers.ToList();
                var listMuon = qlyM.listMuons.ToList(); // Giả sử listMuons có chứa thông tin về ID_Person (ID thành viên)

                // Thống kê số lần mượn theo thành viên
                var memberStatistics = listMuon
                    .Where(m => !string.IsNullOrEmpty(m.ID_Person)) // Loại bỏ các bản ghi không có ID_Person
                    .GroupBy(m => m.ID_Person)
                    .Select(g => new
                    {
                        MemberID = g.Key,        // ID của thành viên
                        BorrowCount = g.Count()  // Số lần mượn sách
                    })
                    .ToList(); // Chuyển thành danh sách trong bộ nhớ

                // Kết nối với bảng thành viên để lấy thông tin tên
                var detailedMemberStatistics = memberStatistics
                    .Join(listMembers, // Kết nối bảng thống kê với danh sách thành viên
                          m => m.MemberID,
                          mem => mem.ID,
                          (m, mem) => new
                          {
                              MemberName = mem.FirstName.Trim() + " " + mem.LastName, // Tên thành viên (họ và tên)
                              BorrowCount = m.BorrowCount                     // Số lần mượn
                          })
                    .OrderByDescending(x => x.BorrowCount) // Sắp xếp giảm dần theo số lần mượn
                    .ToList(); // Chuyển thành danh sách trong bộ nhớ
                               // Xóa Series cũ nếu có
                chart2Books.Series.Clear();

                // Tạo Series mới cho thành viên tích cực
                var memberSeries = chart2Books.Series.Add("THÀNH VIÊN TÍCH CỰC");
                memberSeries.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column; // Dạng cột

                // Thêm dữ liệu vào Series
                foreach (var item in detailedMemberStatistics)
                {
                    memberSeries.Points.AddXY(item.MemberName, item.BorrowCount); // Thêm tên thành viên và số lần mượn
                }

                // Tùy chỉnh biểu đồ
                chart2Books.ChartAreas[0].AxisX.Title = "TÊN THÀNH VIÊN";
                chart2Books.ChartAreas[0].AxisY.Title = "SỐ LẦN MƯỢN";
                chart2Books.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // Xoay nhãn trục X để dễ đọc
                chart2Books.Legends[0].Enabled = false;// tat hien thi chu thich

                // Tăng kích thước và in đậm chữ trên trục X

                chart2Books.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 10, FontStyle.Bold);


                // Tùy chỉnh kích thước và in đậm cho tiêu đề trục X
                chart2Books.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 12, FontStyle.Bold);

                // Tùy chỉnh kích thước và in đậm cho tiêu đề trục Y
                chart2Books.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 12, FontStyle.Bold);



            }
            catch (Exception ex)
            {

                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
            




        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLibaryManagement frmLibaryManagement = new frmLibaryManagement();
            frmLibaryManagement.check = checkUser;
            frmLibaryManagement.Show();
            this.Hide();
        }
    }
}
