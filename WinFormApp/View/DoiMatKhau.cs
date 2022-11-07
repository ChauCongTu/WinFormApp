using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormApp.CustomControl;
using WinFormApp.DAO;
using WinFormApp.Model;

namespace WinFormApp.View
{
    public partial class DoiMatKhau : Form
    {
        int _pass1 = 0;
        int _pass2 = 0;
        int _pass3 = 0;
        NhanVien nhanVien = new NhanVien();
        Functions Functions = new Functions();
        public DoiMatKhau()
        {
            InitializeComponent();
        }
        public DoiMatKhau(NhanVien nhanVien)
        {
            InitializeComponent();
            this.nhanVien = nhanVien;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(_pass1 == 0)
            {
                txtOldPwd.PasswordChar = '*';
                _pass1 = 1;
            }
            else if(_pass1 == 1)
            {
                txtOldPwd.PasswordChar = (char)0;
                _pass1 = 0;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (_pass2 == 0)
            {
                txtNewPwd.PasswordChar = '*';
                _pass2 = 1;
            }
            else if (_pass2 == 1)
            {
                txtNewPwd.PasswordChar = (char)0;
                _pass2 = 0;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (_pass3 == 0)
            {
                txtNewPwdCfm.PasswordChar = '*';
                _pass3 = 1;
            }
            else if (_pass3 == 1)
            {
                txtNewPwdCfm.PasswordChar = (char)0;
                _pass3 = 0;
            }
        }

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
            lbErr.Text = "";
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            lbErr.Text = "";
            if(txtOldPwd.Text.Length == 0 || txtNewPwd.Text.Length == 0 || txtNewPwdCfm.Text.Length == 0)
            {
                lbErr.Text = "*Không được để trống thông tin!";
            }
            else if(Functions.GetMD5(txtOldPwd.Text) != nhanVien.matKhau)
            {
                lbErr.Text = "*Mật khẩu cũ không chính xác!";
            }
            else
            {
                if(txtNewPwd.Text.Length < 6 || txtNewPwdCfm.Text.Length < 6)
                {
                    lbErr.Text = "*Mật khẩu mới không được ít hơn 6 kí tự!";
                }
                else if(txtNewPwd.Text != txtNewPwdCfm.Text)
                {
                    lbErr.Text = "*Mật khẩu mới và mật khẩu xác nhận không trùng khớp!";
                }
                else if(Functions.GetMD5(txtNewPwd.Text) == nhanVien.matKhau)
                {
                    lbErr.Text = "*Mật khẩu mới không được trùng với mật khẩu cũ!";
                }
                else
                {
                    lbErr.Text = "";
                    RJMessageBox.Show("Đổi mật khẩu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    nhanVien.matKhau = Functions.GetMD5(txtNewPwd.Text);
                    DAO_NhanVien dAO_NhanVien = new DAO_NhanVien();
                    DAO_ChiNhanh dAO_ChiNhanh = new DAO_ChiNhanh();
                    dAO_NhanVien.Update(nhanVien, dAO_ChiNhanh.GetByUsrID(nhanVien.maNhanVien).maChiNhanh);
                    this.Hide();
                    this.Close();
                }
            }
        }
    }
}
