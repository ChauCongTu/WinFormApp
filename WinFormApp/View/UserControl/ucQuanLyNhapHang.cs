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
using WinFormApp.View;

namespace WinFormApp.CustomControl
{
    public partial class ucQuanLyNhapHang : UserControl
    {
        ChiNhanh ChiNhanh = new ChiNhanh();
        HoaDonNhap hd = new HoaDonNhap();
        public ucQuanLyNhapHang()
        {
            InitializeComponent();
        }
        public ucQuanLyNhapHang(HoaDonNhap hd)
        {
            InitializeComponent();
            this.hd = hd;
        }
        void turnOffButton(Button btn, PictureBox picture)
        {
            btn.Enabled = false;
            btn.BackColor = Color.FromArgb(238, 238, 238);
            picture.BackColor = Color.FromArgb(238, 238, 238);
        }
        void turnOffButton(Button btn)
        {
            btn.Enabled = false;
            btn.BackColor = Color.FromArgb(238, 238, 238);
        }
        void turnOnButton(Button btn, PictureBox picture)
        {
            btn.Enabled = true;
            btn.BackColor = Color.FromArgb(23, 162, 139);
            picture.BackColor = Color.FromArgb(23, 162, 139);
        }
        void turnOnButton(Button btn)
        {
            btn.Enabled = true;
            btn.BackColor = Color.FromArgb(23, 162, 139);
        }

        private void ucQuanLyNhapHang_Load(object sender, EventArgs e)
        {
            txtSoHD.Enabled = false;
            dtpNgayHD.Enabled = false;
            cbChiNhanh.Enabled = false;
            cbNhaCungCap.Enabled = false;
            cbNhanVien.Enabled = false;
            turnOffButton(btnSave, pbSave);
            turnOffButton(btnChiTietHD);
            turnOffButton(btnUpdate, pbUpdate);
            turnOffButton(btnDelete, pbDelete);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtSoHD.Enabled = true;
            dtpNgayHD.Enabled = true;
            cbNhaCungCap.Enabled = true;
            cbNhanVien.Enabled = true;
            cbChiNhanh.Enabled = true;
            turnOnButton(btnChiTietHD);
            turnOffButton(btnNew, pbAdd);
            turnOnButton(btnSave, pbSave);
        }

        private void btnChiTietHD_Click(object sender, EventArgs e)
        {
            if (txtSoHD.Text.Length == 0 || cbNhaCungCap.Text.Length == 0 || cbNhanVien.Text.Length == 0)
            {
                var result = RJMessageBox.Show("Vui lòng điền các thông tin cho hóa đơn!",
                    "Có lỗi xảy ra",
                    MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Error);
            }
            else
            {
                DateTime dateTime = new DateTime(2002, 10, 4);
                NhanVien nv = new NhanVien("NV12345", "Châu Quế Nhơn", "JoshCQN", "123456", dateTime, 61527384, "An Nhơn - Bình Định", 3, "0848611127");
                NhaCungCap nhaCungCap = new NhaCungCap("NCC001", "Honda Viễn Thuận Phát", "Bình Định", "081723884", "AAA@GMAIL.COM");
                HoaDonNhap hoaDonNhap = new HoaDonNhap(txtSoHD.Text, dtpNgayHD.Value, nv, nhaCungCap);
                ChiTietHoaDonNhap chiTietHoaDon = new ChiTietHoaDonNhap(hoaDonNhap);
                chiTietHoaDon.ShowDialog();
            }
        }
    }
}
