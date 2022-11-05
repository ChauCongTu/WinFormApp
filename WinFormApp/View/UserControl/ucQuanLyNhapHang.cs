using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormApp.DAO;
using WinFormApp.Model;
using WinFormApp.View;

namespace WinFormApp.CustomControl
{
    public partial class ucQuanLyNhapHang : UserControl
    {
        Functions function = new Functions();
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
        void table_load()
        {
            int i = 1;
            DAO_HoaDonNhap dAO_HoaDonNhap = new DAO_HoaDonNhap();

            List<HoaDonNhap> hoaDonNhap = dAO_HoaDonNhap.GetAll();
            foreach(HoaDonNhap hoaDon in hoaDonNhap)
            {
                dgvHoaDonXuat.Rows.Add(i, hoaDon.SOHD, hoaDon.nhaCungCap.tenNhaCungCap, hoaDon.ngayLapHoaDon.ToString(), hoaDon.nhanVien.tenNhanVien, hoaDon.tongHoaDon);
                i++;
            }
        }
        

        private void ucQuanLyNhapHang_Load(object sender, EventArgs e)
        {
            table_load();
            txtSoHD.Enabled = false;
            dtpNgayHD.Enabled = false;
            cbChiNhanh.Enabled = false;
            cbNhaCungCap.Enabled = false;
            cbNhanVien.Enabled = false;
            function.turnOffButton(btnSave, pbSave);
            function.turnOffButton(btnChiTietHD);
            function.turnOffButton(btnUpdate, pbUpdate);
            function.turnOffButton(btnDelete, pbDelete);
            DAO_ChiNhanh dAO_ChiNhanh = new DAO_ChiNhanh();
            cbChiNhanh.DataSource = dAO_ChiNhanh.getAll();
            cbChiNhanh.ValueMember = "maChiNhanh"; //giá trị
            cbChiNhanh.DisplayMember = "tenChiNhanh"; //hiển thị
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtSoHD.Enabled = true;
            dtpNgayHD.Enabled = true;
            cbNhaCungCap.Enabled = true;
            cbChiNhanh.Enabled = true;
            function.turnOnButton(btnChiTietHD);
            function.turnOffButton(btnNew, pbAdd);
            function.turnOnButton(btnSave, pbSave);
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
                ChiTietHoaDonNhap chiTietHoaDon = new ChiTietHoaDonNhap(hoaDonNhap, ChiNhanh);
                chiTietHoaDon.ShowDialog();
            }
        }

        private void dgvHoaDonXuat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvHoaDonXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            function.turnOnButton(btnUpdate, pbUpdate);
            function.turnOnButton(btnDelete, pbDelete);
        }

        private void cbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            DAO_NhanVien dAO_NhanVien = new DAO_NhanVien();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }
    }
}
