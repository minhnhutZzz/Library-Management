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
    public partial class frmMenuLib : Form
    {
        public int check { get; set; }
        public string userID { get; set; }

        
        public frmMenuLib()
        {
            InitializeComponent();
        }

        private void infomationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void frmMenuLib_Load(object sender, EventArgs e)
        {

        }

        private void lbMenuLibrarians_Click(object sender, EventArgs e)
        {

           
            if (check == 1)
            {
                frmLibaryManagement frmLibaryManagement = new frmLibaryManagement();
                frmLibaryManagement.check = check;

                frmLibaryManagement.User = userID;
                frmLibaryManagement.Show();
            }
            else
            {
                MessageBox.Show("Bạn không phải người quản lý thư viện!", "Thông tin dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbMenuMembers_Click(object sender, EventArgs e)
        {
            
            if (check == 2)
            {
                frmLibaryManagementMember frmLibaryManagementM = new frmLibaryManagementMember();
                frmLibaryManagementM.check = check;
                frmLibaryManagementM.UserId = userID;
                frmLibaryManagementM.Show();
            }
            else
            {
                MessageBox.Show("Bạn không phải thành viên thư viện!", "Thông tin dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void lbMenuLogout_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Close();
        }
    }
}
