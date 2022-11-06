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
using WinFormApp.View.Report;

namespace WinFormApp.View
{
    public partial class ChiTietHoaDonXuat : Form
    {
        HoaDonXuat hd = new HoaDonXuat();
        ChiNhanh chiNhanh = new ChiNhanh();
        NhanVien nhanVien = new NhanVien();
        public ChiTietHoaDonXuat()
        {
            InitializeComponent();
        }
        public ChiTietHoaDonXuat(HoaDonXuat hd, ChiNhanh chiNhanh, NhanVien nhanVien)
        {
            InitializeComponent();
            this.hd = hd;
            this.chiNhanh = chiNhanh;
            this.nhanVien = nhanVien;
        }
        void table_load()
        {
            dgvChiTietHoaDon.Rows.Clear();
            int i = 1;
            decimal tongTien = 0;
            DAO_ChiTietHoaDonXuat dAO_ChiTietHoaDonXuat = new DAO_ChiTietHoaDonXuat();
            List<CTHDXUAT> cTHDXUATs = dAO_ChiTietHoaDonXuat.GetList(hd.SOHD);
            foreach (CTHDXUAT chitiet in cTHDXUATs)
            {
                dgvChiTietHoaDon.Rows.Add(i, chitiet.SP.maSanPham, chitiet.SP.tenSanPham, chitiet.sl, chitiet.SP.donGia, chitiet.thanhtien, "Xóa");
                tongTien = tongTien + chitiet.thanhtien;
                i++;
            }
            txtTongTien.Text = tongTien.ToString();
        }
        private void ChiTietHoaDonXuat_Load(object sender, EventArgs e)
        {
            table_load();
            txtSoHoaDon.Text = hd.SOHD;
            dtpNgayHD.Value = hd.ngayLapHoaDon;
            cbChiNhanh.Text = chiNhanh.tenChiNhanh;
            cbKhachHang.Text = hd.khachHang.tenKhachHang;
            cbNhanVien.Text = hd.nhanVien.tenNhanVien.ToString();
            txtSoHoaDon.Enabled = false;
            txtSl.Enabled = false;
            dtpNgayHD.Enabled = false;
            cbChiNhanh.Enabled = false;
            cbKhachHang.Enabled = false;
            cbNhanVien.Enabled = false;
            DAO_SanPhamXe dAO_SanPhamXe = new DAO_SanPhamXe();
            cbSanPham.DataSource = dAO_SanPhamXe.GetList(chiNhanh.maChiNhanh);
            cbSanPham.ValueMember = "maSanPham";
            cbSanPham.DisplayMember = "tenSanPham";
            if (nhanVien.capbac == 1)
            {
                if (nhanVien.maNhanVien != hd.nhanVien.maNhanVien)
                {
                    Functions functions = new Functions();
                    functions.turnOffButton(btnAdd, pictureBox6);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void cbSanPham_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cbLoaiSP_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbLoaiSP.SelectedItem.ToString() == "Xe")
            {
                DAO_SanPhamXe dAO_SanPhamXe = new DAO_SanPhamXe();
                cbSanPham.DataSource = dAO_SanPhamXe.GetList(chiNhanh.maChiNhanh);
                cbSanPham.ValueMember = "maSanPham";
                cbSanPham.DisplayMember = "tenSanPham";
                txtSl.Enabled = false;
                txtSl.Text = "1";
            }
            else
            {
                DAO_SanPhamPhuTung dAO_SanPhamPhuTung = new DAO_SanPhamPhuTung();
                cbSanPham.DataSource = dAO_SanPhamPhuTung.GetList(chiNhanh.maChiNhanh);
                cbSanPham.ValueMember = "maSanPham";
                cbSanPham.DisplayMember = "tenSanPham";
                txtSl.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DAO_SanPham dAO_SanPham = new DAO_SanPham();
            SanPham sanPham = dAO_SanPham.GetByID(cbSanPham.SelectedValue.ToString());
            CTHDXUAT cTHDXUAT = new CTHDXUAT(Convert.ToInt32(txtSl.Text), sanPham);
            DAO_ChiTietHoaDonXuat dAO_ChiTietHoaDonXuat = new DAO_ChiTietHoaDonXuat();
            dAO_ChiTietHoaDonXuat.Add(cTHDXUAT, hd.SOHD);
            table_load();
        }

        private void dgvChiTietHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvChiTietHoaDon.Columns["_xoa"].Index)
            {
                if (nhanVien.capbac == 1)
                {
                    if (nhanVien.maNhanVien != hd.nhanVien.maNhanVien)
                    {
                        var result = RJMessageBox.Show("Bạn không có quyền xóa sản phẩm từ hóa đơn không phải của bạn",
                            "Không đủ thẩm quyền",
                            MessageBoxButtons.OK);
                    }
                }
                else
                {
                    var result = RJMessageBox.Show("Bạn có chắc muốn xóa sản phẩm này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        DataGridViewRow row = dgvChiTietHoaDon.Rows[e.RowIndex];
                        DAO_ChiTietHoaDonXuat dAO_ChiTietHoaDonXuat = new DAO_ChiTietHoaDonXuat();
                        dAO_ChiTietHoaDonXuat.Delete(hd.SOHD, row.Cells[1].Value.ToString());
                        table_load();
                    }
                    else
                    {

                    }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            rpHoaDonXuat rpHoaDonXuat = new rpHoaDonXuat(hd);
            rpHoaDonXuat.ShowDialog();
        }
    }
}
