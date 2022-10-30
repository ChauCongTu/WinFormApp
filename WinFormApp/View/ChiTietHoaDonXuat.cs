using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormApp.Model;

namespace WinFormApp.View
{
    public partial class ChiTietHoaDonXuat : Form
    {
        HoaDonXuat hd = new HoaDonXuat();
        public ChiTietHoaDonXuat()
        {
            InitializeComponent();
        }
        public ChiTietHoaDonXuat(HoaDonXuat hd)
        {
            InitializeComponent();
            this.hd = hd;
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void ChiTietHoaDonXuat_Load(object sender, EventArgs e)
        {
            txtSoHoaDon.Text = hd.SOHD;
            dtpNgayHD.Value = hd.ngayLapHoaDon;
            cbKhachHang.Text = hd.khachHang.tenKhachHang.ToString();
            cbNhanVien.Text = hd.nhanVien.tenNhanVien.ToString();
            txtSoHoaDon.Enabled = false;
            txtSl.Enabled = false;
            dtpNgayHD.Enabled = false;
            cbKhachHang.Enabled = false;
            cbNhanVien.Enabled = false; 
            cbSanPham.Enabled = false;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
