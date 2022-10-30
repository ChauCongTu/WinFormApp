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
    public partial class ChiTietHoaDonNhap : Form
    {
        HoaDonNhap hd = new HoaDonNhap();
        public ChiTietHoaDonNhap()
        {
            InitializeComponent();
        }
        public ChiTietHoaDonNhap (HoaDonNhap hd)
        {
            InitializeComponent();
            this.hd = hd;
        }

        private void ChiTietHoaDonNhap_Load(object sender, EventArgs e)
        {
            txtSoHoaDon.Text = hd.SOHD;
            dtpNgayHD.Value = hd.ngayLapHoaDon;
            cbNhaCungCap.Text = hd.nhaCungCap.tenNhaCungCap.ToString();
            cbNhanVien.Text = hd.nhanVien.tenNhanVien.ToString();
            txtSoHoaDon.Enabled = false;
            txtSl.Enabled = false;
            dtpNgayHD.Enabled = false;
            cbNhaCungCap.Enabled = false;
            cbNhanVien.Enabled = false;
            cbSanPham.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
