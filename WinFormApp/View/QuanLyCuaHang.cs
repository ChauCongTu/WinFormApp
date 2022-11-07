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
using WinFormApp.Model;

namespace WinFormApp
{
    public partial class QuanLyCuaHang : Form
    {
        NhanVien nhanVien = new NhanVien();
        public QuanLyCuaHang()
        {
            InitializeComponent();
        }
        public QuanLyCuaHang(NhanVien nhanVien)
        {
            InitializeComponent();
            this.nhanVien = nhanVien;
        }
        void switchSelect(RJButton btn)
        {
            //Default Button
            btnChiNhanh.BackColor = Color.Transparent;
            btnChiNhanh.ForeColor = Color.White;
            btnChiNhanh.BorderRadius = 0;

            btnHome.BackColor = Color.Transparent;
            btnHome.ForeColor = Color.White;
            btnHome.BorderRadius = 0;

            btnKhachHang.BackColor = Color.Transparent;
            btnKhachHang.ForeColor = Color.White;
            btnKhachHang.BorderRadius = 0;

            btnKhoPhuTung.BackColor = Color.Transparent;
            btnKhoPhuTung.ForeColor = Color.White;
            btnKhoPhuTung.BorderRadius = 0;

            btnNhanVien.BackColor = Color.Transparent;
            btnNhanVien.ForeColor = Color.White;
            btnNhanVien.BorderRadius = 0;

            btnKhoXe.BackColor = Color.Transparent;
            btnKhoXe.ForeColor = Color.White;
            btnKhoXe.BorderRadius = 0;

            btnNhapHang.BackColor = Color.Transparent;
            btnNhapHang.ForeColor = Color.White;
            btnNhapHang.BorderRadius = 0;

            btnXuatHang.BackColor = Color.Transparent;
            btnXuatHang.ForeColor = Color.White;
            btnXuatHang.BorderRadius = 0;

            btnThongKe.BackColor = Color.Transparent;
            btnThongKe.ForeColor = Color.White;
            btnThongKe.BorderRadius = 0;

            rjButton1.BackColor = Color.Transparent;
            rjButton1.ForeColor = Color.White;
            rjButton1.BorderRadius = 0;
            //Selected Button
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
            btn.BorderRadius = 15;
        }
        private void rjButton10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
            this.Close();
        }

        private void btnChiNhanh_Click(object sender, EventArgs e)
        {
            switchSelect(btnChiNhanh);
            gpMain.Controls.Clear();
            gpMain.Controls.Add(new ucQuanLyChiNhanh());
        }

        private void btnXuatHang_Click(object sender, EventArgs e)
        {
            switchSelect(btnXuatHang);
            gpMain.Controls.Clear();
            gpMain.Controls.Add(new ucQuanLyXuatHang(nhanVien));
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            switchSelect(btnHome);
            gpMain.Controls.Clear();
            gpMain.Controls.Add(new ucTrangChu());
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            switchSelect(btnNhanVien);
            gpMain.Controls.Clear();
            gpMain.Controls.Add(new ucNhanVien());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            switchSelect(btnKhachHang);
            gpMain.Controls.Clear();
            gpMain.Controls.Add(new ucQuanLyKhachHang());
        }

        private void btnKhoXe_Click(object sender, EventArgs e)
        {
            switchSelect(btnKhoXe);
            gpMain.Controls.Clear();
            gpMain.Controls.Add(new ucKhoXe());
        }

        private void btnKhoPhuTung_Click(object sender, EventArgs e)
        {
            switchSelect(btnKhoPhuTung);
            gpMain.Controls.Clear();
            gpMain.Controls.Add(new ucKhoPhuTung());
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            switchSelect(btnNhapHang);
            gpMain.Controls.Clear();
            gpMain.Controls.Add(new ucQuanLyNhapHang(nhanVien));
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            switchSelect(btnThongKe);
            gpMain.Controls.Clear();
            gpMain.Controls.Add(new ucQuanLyThongKe());
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            switchSelect(rjButton1);
            gpMain.Controls.Clear();
            gpMain.Controls.Add(new ucQuanLyNCC());
        }

        private void QuanLyCuaHang_Load(object sender, EventArgs e)
        {
            gpMain.Controls.Clear();
            gpMain.Controls.Add(new ucTrangChu());
            lbUserName.Text = nhanVien.tenNhanVien;
            if(nhanVien.capbac == 1)
            {
                lbCapBac.Text = "(Nhân Viên)";
            }
            if(nhanVien.capbac == 2)
            {
                lbCapBac.Text = "(Quản Lý)";
            }
            if(nhanVien.capbac == 3)
            {
                lbCapBac.Text = "(Admin)";
            }
        }

        private void rjCircularPictureBox1_Click(object sender, EventArgs e)
        {
            ucTrangCaNhan profile = new ucTrangCaNhan(nhanVien);
            gpMain.Controls.Clear();
            gpMain.Controls.Add(profile);
        }
    }
}
