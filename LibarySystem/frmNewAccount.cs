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
    public partial class frmNewAccount : Form
    {
        list_TaiKhoan lsTK = new list_TaiKhoan();
        qlyTaiKhoanDataContext qlTK = new qlyTaiKhoanDataContext();
        listMember lsTV= new listMember();
        qlyThanhVienDataContext qlTV = new qlyThanhVienDataContext();
        public frmNewAccount()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                list_TaiKhoan lsTK = new list_TaiKhoan();
                lsTK.UserName = txtCreateNewUserName.Text;



                if (txtCreateNewPassword.Text == txtConfirmPassword.Text)
                {
                    bool kiemTra_ID = qlTK.list_TaiKhoans.Any(x => x.ID == txtID.Text);
                    bool kiemTra_username = qlTK.list_TaiKhoans.Any(x => x.UserName == txtCreateNewUserName.Text);

                    if (kiemTra_ID == false && kiemTra_username==false)
                    {
                        lsTK.ID = txtID.Text;
                        lsTK.UserName=txtCreateNewUserName.Text;
                        lsTK.Password = txtCreateNewPassword.Text;
                        qlTK.list_TaiKhoans.InsertOnSubmit(lsTK);
                        qlTK.SubmitChanges();
                        frmNewAccount_Load(sender, e);
                        txtCreateNewPassword.Clear();
                        txtCreateNewUserName.Clear();
                        txtConfirmPassword.Clear();
                        listMember lsTV = new listMember();
                        lsTV.ID = txtID.Text;
                        lsTV.FirstName = txtFirstName.Text;
                        lsTV.LastName = txtLastName.Text;
                        Date BirthDateTemp = new Date(int.Parse(txtDay.Text), int.Parse(txtMonth.Text), int.Parse(txtYear.Text));
                        lsTV.BirthDate = BirthDateTemp.ToDateString();
                        lsTV.ContactNumber = txtContactNumber.Text;
                        lsTV.Address = txtAddress.Text;
                        qlTV.listMembers.InsertOnSubmit(lsTV);
                        qlTV.SubmitChanges();
                        frmNewAccount_Load(sender, e);
                        txtID.Clear();
                        txtFirstName.Clear();
                        txtLastName.Clear();
                        txtDay.Clear();
                        txtMonth.Clear();
                        txtYear.Clear();
                        txtContactNumber.Clear();
                        txtAddress.Clear();
                        MessageBox.Show("Đã đăng ký thành công tài khoản. Vui lòng đăng nhập.", "Thông tin dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        frmLogin frmLogin = new frmLogin();
                        frmLogin.Show();
                        this.Hide();
                    }
                    else if (kiemTra_ID==true)
                    {
                        MessageBox.Show("Tài khoản đã tồn tại, vui lòng nhập lại ID ", "Thông tin dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (kiemTra_username==true) 
                    {
                        MessageBox.Show("Tài khoản đã tồn tại, vui lòng nhập lại UserName ", "Thông tin dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                }
                else 
                {
                    MessageBox.Show("Mật khẩu không khớp, vui lòng nhập lại ", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtConfirmPassword.Clear();
                    txtCreateNewPassword.Clear();
                    txtCreateNewPassword.Focus();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Vui lòng nhập đúng định dạng/thông tin! {ex.Message}");
            }
            

           




        }

        private void frmNewAccount_Load(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
