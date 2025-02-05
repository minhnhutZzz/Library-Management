using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace LibarySystem
{
    public partial class frmAddBook : Form
    {
        listBook lb= new listBook();
        quanliSachDataContext ql= new quanliSachDataContext();
        public int checkUser { get; set; }
        public frmAddBook()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtID.Text) || string.IsNullOrWhiteSpace(txtAuthor.Text) || string.IsNullOrWhiteSpace(txtCategory.Text))
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin về sách!", "Thông tin dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    listBook lb = new listBook();
                    lb.ID = txtID.Text;
                    lb.Name = txtName.Text;
                    lb.Author = txtAuthor.Text;
                    lb.Category = txtCategory.Text;
                    ql.listBooks.InsertOnSubmit(lb);
                    ql.SubmitChanges();
                    frmAddBook_Load(sender, e);
                    txtAuthor.Clear();
                    txtCategory.Clear();
                    txtID.Clear();
                    txtName.Clear();
                    MessageBox.Show("Đã thêm sách thành công!", "Thông tin dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    

                }

            }
            catch (SqlException exp)
            {

                if (exp.Number == 2627 || exp.Number == 2601)// neu co gang chen vao 1 gia tri khoa trung lap
                {
                    MessageBox.Show("ID sách đã tồn tại. Vui lòng nhập ID khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                    
            }
            catch (Exception ex)
            {
                // Xử lý các lỗi khác
                MessageBox.Show($"Đã xảy ra lỗi không xác định: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private void frmAddBook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlySachDataSet2.listBooks' table. You can move, or remove it, as needed.
            this.listBooksTableAdapter1.Fill(this.qlySachDataSet2.listBooks);
            // TODO: This line of code loads data into the 'qlySachDataSet.listBooks' table. You can move, or remove it, as needed.
            this.listBooksTableAdapter.Fill(this.qlySachDataSet.listBooks);// quan li ket noi voi co so du lieu
            var list = (from s in ql.listBooks select s).ToList();
            dGVAddBook.DataSource = list;


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                lb = ql.listBooks.Where(l => l.ID == txtID.Text).Single();
                if (!string.IsNullOrWhiteSpace(txtName.Text))
                    lb.Name = txtName.Text;
                if (!string.IsNullOrWhiteSpace(txtAuthor.Text))
                    lb.Author = txtAuthor.Text;
                if (!string.IsNullOrWhiteSpace(txtCategory.Text))
                    lb.Category = txtCategory.Text;
                ql.SubmitChanges();
                frmAddBook_Load(sender, e);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
           

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                lb = ql.listBooks.Where(l => l.ID == txtID.Text).Single();
                lb.ID = txtID.Text;
                lb.Name = txtName.Text;
                lb.Author = txtAuthor.Text;
                lb.Category = txtCategory.Text;
                ql.listBooks.DeleteOnSubmit(lb);
                ql.SubmitChanges();
                frmAddBook_Load(sender, e);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
           
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmLibaryManagement frmLibaryManagement = new frmLibaryManagement();
            frmLibaryManagement.check = checkUser;
            frmLibaryManagement.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

