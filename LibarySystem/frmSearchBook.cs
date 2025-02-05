using System;
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
    public partial class frmSearchBook : Form
    {
        public int check { get; set; }
        public string userID { get; set; }
        listBook lsb=new listBook();
        quanliSachDataContext qls=new quanliSachDataContext();
        public frmSearchBook()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmSearchBook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlySachDataSet1.listBooks' table. You can move, or remove it, as needed.
            this.listBooksTableAdapter.Fill(this.qlySachDataSet1.listBooks);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // Lọc danh sách dựa trên các tiêu chí nhập
                var list = (from s in qls.listBooks
                            where (string.IsNullOrEmpty(txtBookID.Text) || s.ID.Contains(txtBookID.Text))
       && (string.IsNullOrEmpty(txtAuthor.Text) || s.Author.Contains(txtAuthor.Text))
       && (string.IsNullOrEmpty(txtCategory.Text) || s.Category.Contains(txtCategory.Text))
       && (string.IsNullOrEmpty(txtBookName.Text) || s.Name.Contains(txtBookName.Text))
                            select s).ToList();

                // Hiển thị kết quả trong DataGridView

                if (list.Count == 0)
                    MessageBox.Show("Không tìm thấy sách phù hợp với tiêu chí trên.", "Thông tin dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    dGVSearchBook.DataSource = list;
                    txtBookID.DataBindings.Clear();
                    txtBookName.DataBindings.Clear();
                    txtAuthor.DataBindings.Clear();
                    txtCategory.DataBindings.Clear();
                    // them rang buoc du lieu moi cho TextBox de hien thi le TextBox
                    txtBookID.DataBindings.Add("Text", list, "ID");
                    txtBookName.DataBindings.Add("Text", list, "Name");
                    txtAuthor.DataBindings.Add("Text", list, "Author");
                    txtCategory.DataBindings.Add("Text", list, "Category");
                    txtBookID.Clear();
                    txtBookName.Clear();
                    txtAuthor.Clear();
                    txtCategory.Clear();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                frmLibaryManagementMember frmLibaryManagementMember = new frmLibaryManagementMember();
                frmLibaryManagement frmLibaryManagement = new frmLibaryManagement();
                if (check == 1)
                {
                    frmLibaryManagement.Show();
                    frmLibaryManagement.check = check;
                    frmLibaryManagement.User = userID;
                    this.Hide();
                }
                else if (check == 2)
                {
                    frmLibaryManagementMember.Show();
                    frmLibaryManagementMember.check = check;
                    frmLibaryManagementMember.UserId=userID;
                    this.Hide();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }

            
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
