using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Media;
using WMPLib;
namespace LibarySystem
{
    

    public partial class frmLogin : Form
    {
        public bool check;
        list_QuanMuc lsQM= new list_QuanMuc();
        qlyQuanMucDataContext qlyQM = new qlyQuanMucDataContext();

        list_TaiKhoan lsTK = new list_TaiKhoan();
        qlyTaiKhoanDataContext qlyTk= new qlyTaiKhoanDataContext();

        frmMenuLib frmMenu = new frmMenuLib();

        

       
        public frmLogin()
        {
            InitializeComponent();

            this.Shown += frmLogin_Shown;
        }
        private void frmLogin_Shown(object sender, EventArgs e)
        {
            try
            {
                string musicPath = @"D:\WindyHill.mp3";
                WindowsMediaPlayer wmp = new WindowsMediaPlayer();
                wmp.URL = musicPath;
                wmp.controls.play();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
            
        }

        private void btnLoginLib_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPass.Text))
                {
                    MessageBox.Show("Vui lòng nhập tài khoản, mật khẩu!", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var taiKhoan = qlyQM.list_QuanMucs.FirstOrDefault(s => s.UserName == txtUserName.Text && s.Password == txtPass.Text);

                    if (taiKhoan != null)
                    {

                        frmMenu.check = 1;
                        frmMenu.userID = taiKhoan.ID;
                        MessageBox.Show("Bạn đã đăng nhập thành công ", "Thông tin dịch vụ ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmMenu.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa có tài khoản, vui lòng đăng ký tài khoản", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }

            
            


        }

        private void btnNewAcc_Click(object sender, EventArgs e)
        {
            frmNewAccount frmCreate=new frmNewAccount();
            frmCreate.Show();

        }

        
      
        private void btnLoginMem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPass.Text))
                {
                    MessageBox.Show("Vui lòng nhập tài khoản, mật khẩu!", "Thông tin dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    var taiKhoan = qlyTk.list_TaiKhoans.FirstOrDefault(s => s.UserName == txtUserName.Text && s.Password == txtPass.Text);

                    if (taiKhoan != null)
                    {
                        SpeechSynthesizer chaoMember = new SpeechSynthesizer();

                        chaoMember.SelectVoiceByHints(VoiceGender.Female);
                        chaoMember.Volume = 100;
                        chaoMember.Rate = -1;
                        chaoMember.Speak("Welcome to the library, have a good day! ");
                        frmMenu.check = 2;
                        frmMenu.userID = taiKhoan.ID;
                        MessageBox.Show("Bạn đã đăng nhập thành công ", "Thông tin dịch vụ ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmMenu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa có tài khoản, vui lòng đăng ký tài khoản", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }    
                    
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
