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

namespace WinFormApp
{
    public partial class QuanLyCuaHang : Form
    {
        public QuanLyCuaHang()
        {
            InitializeComponent();
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
        }

        private void btnXuatHang_Click(object sender, EventArgs e)
        {
            switchSelect(btnXuatHang);
            gpMain.Controls.Clear();
            gpMain.Controls.Add(new ucQuanLyXuatHang());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            switchSelect(btnHome);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            switchSelect(btnNhanVien);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            switchSelect(btnKhachHang);
        }

        private void btnKhoXe_Click(object sender, EventArgs e)
        {
            switchSelect(btnKhoXe);
        }

        private void btnKhoPhuTung_Click(object sender, EventArgs e)
        {
            switchSelect(btnKhoPhuTung);
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            switchSelect(btnNhapHang);
            gpMain.Controls.Clear();
            gpMain.Controls.Add(new ucQuanLyNhapHang());
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
        }
    }
}
