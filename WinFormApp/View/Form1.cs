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
using WinFormApp.View;
//Demo Pull
namespace WinFormApp
{
    public partial class Form1 : Form
    {

        int _showPass = 0;
        Functions _function = new Functions();
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void pbShowPwd_Click(object sender, EventArgs e)
        {
            if(_showPass == 0)
            {
                txtPassword.PasswordChar = false;
                _showPass = 1;
            }
            else
            {
                txtPassword.PasswordChar = true;
                _showPass = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
            txtErr1.Text = "";
            txtErr2.Text = "";
            txtPassword.PasswordChar = true;
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            txtErr1.Text = "";
            txtErr2.Text = "";
            string usn = txtUsername.Texts;
            string pwd = txtPassword.Texts;

            if (usn.Length == 0)
            {
                txtErr1.Text = "*Tên đăng nhập không được để trống";
            }
            if (pwd.Length < 6)
            {
                txtErr2.Text = "*Mật khẩu phải ít nhất 6 kí tự";
            }
            DAO_NhanVien dAO_NhanVien = new DAO_NhanVien();
            NhanVien nhanVien = dAO_NhanVien.GetByUsrName(usn);
            if (nhanVien.tenDangNhap != usn)
            {
                txtErr1.Text = "*Tên đăng nhập không tồn tại";
            }
            else
            {
                if(_function.GetMD5(pwd) != nhanVien.matKhau)
                {
                    txtErr2.Text = "*Mật khẩu không chính xác";
                }
                else
                {
                    this.Hide();
                    QuanLyCuaHang qlch = new QuanLyCuaHang(nhanVien);
                    qlch.ShowDialog();
                    this.Close();
                }
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                txtErr1.Text = "";
                txtErr2.Text = "";
                string usn = txtUsername.Texts;
                string pwd = txtPassword.Texts;

                if (usn.Length == 0)
                {
                    txtErr1.Text = "*Tên đăng nhập không được để trống";
                }
                if (pwd.Length < 6)
                {
                    txtErr2.Text = "*Mật khẩu phải ít nhất 6 kí tự";
                }
                DAO_NhanVien dAO_NhanVien = new DAO_NhanVien();
                NhanVien nhanVien = dAO_NhanVien.GetByUsrName(usn);
                if (nhanVien.tenDangNhap != usn)
                {
                    txtErr1.Text = "*Tên đăng nhập không tồn tại";
                }
                else
                {
                    if (_function.GetMD5(pwd) != nhanVien.matKhau)
                    {
                        txtErr2.Text = "*Mật khẩu không chính xác";
                    }
                    else
                    {
                        this.Hide();
                        QuanLyCuaHang qlch = new QuanLyCuaHang(nhanVien);
                        qlch.ShowDialog();
                        this.Close();
                    }
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                rjButton1_Click(sender, e);
            }
        }
        
    }
}
