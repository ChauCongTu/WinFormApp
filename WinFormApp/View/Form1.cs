using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp
{
    public partial class Form1 : Form
    {
        int _showPass = 0;
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
            txtPassword.PasswordChar = true;
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyCuaHang qlch = new QuanLyCuaHang();
            qlch.ShowDialog();
            this.Close();
        }
    }
}
