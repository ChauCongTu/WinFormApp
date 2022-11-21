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
    public partial class ucQuanLyXuatHang : UserControl
    {
        Functions function = new Functions();
        ChiNhanh ChiNhanh = new ChiNhanh();
        NhanVien nhanVien = new NhanVien();
        HoaDonXuat hd = new HoaDonXuat();
        int saveType;
        public ucQuanLyXuatHang(NhanVien nhanVien)
        {
            InitializeComponent();
            this.nhanVien = nhanVien;
        }
        public ucQuanLyXuatHang(HoaDonXuat hd, NhanVien nhanVien)
        {
            InitializeComponent();
            this.hd = hd;
            this.nhanVien = nhanVien;
        }
        void table_load()
        {
            dgvHoaDonXuat.Rows.Clear();
            int i = 1;
            DAO_HoaDonXuat dAO_HoaDon = new DAO_HoaDonXuat();

            List<HoaDonXuat> hoaDonXuat = dAO_HoaDon.GetAll();
            foreach (HoaDonXuat hoaDon in hoaDonXuat)
            {
                dgvHoaDonXuat.Rows.Add(i, hoaDon.SOHD, hoaDon.khachHang.tenKhachHang, hoaDon.ngayLapHoaDon.ToString("dd/MM/yyyy"), hoaDon.nhanVien.tenNhanVien, hoaDon.tongHoaDon);
                i++;
            }
        }


        private void ucQuanLyXuatHang_Load(object sender, EventArgs e)
        {
            table_load();
            txtSoHD.Enabled = false;
            dtpNgayHD.Enabled = false;
            cbChiNhanh.Enabled = false;
            cbKhachHang.Enabled = false;
            cbNhanVien.Enabled = false;
            function.turnOnButton(btnNew, pbAdd);
            function.turnOffButton(btnSave, pbSave);
            function.turnOffButton(btnChiTietHD);
            function.turnOffButton(btnUpdate, pbUpdate);
            function.turnOffButton(btnDelete, pbDelete);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            saveType = 1;
            dtpNgayHD.Enabled = true;
            cbKhachHang.Enabled = true;
            function.turnOffButton(btnNew, pbAdd);
            function.turnOnButton(btnSave, pbSave);
            function.turnOffButton(btnUpdate, pbUpdate);
            function.turnOffButton(btnDelete, pbDelete);
            //Xử lý sự kiện 
            DAO_HoaDonXuat daoHoaDonXuat = new DAO_HoaDonXuat();
            DAO_NhanVien dAO_NhanVien = new DAO_NhanVien();
            DAO_KhachHang dAO_KhachHang = new DAO_KhachHang();
            txtSoHD.Text = function.GenerateID(1);
            DAO_ChiNhanh dAO_ChiNhanh = new DAO_ChiNhanh();
            cbChiNhanh.Text = dAO_ChiNhanh.GetByUsrID(nhanVien.maNhanVien).tenChiNhanh;
            cbChiNhanh.ValueMember = "maChiNhanh"; //giá trị
            cbChiNhanh.DisplayMember = "tenChiNhanh"; //hiển thị
            cbNhanVien.Text = nhanVien.tenNhanVien;
            cbNhanVien.ValueMember = "maNhanVien";
            cbNhanVien.DisplayMember = "tenNhanVien";
            cbKhachHang.DataSource = dAO_KhachHang.GetAll();
            cbKhachHang.ValueMember = "maKhachHang";
            cbKhachHang.DisplayMember = "tenKhachHang";
        }

        private void btnChiTietHD_Click(object sender, EventArgs e)
        {
            if (saveType == 1)
            {
                DAO_ChiNhanh dAO_ChiNhanh = new DAO_ChiNhanh();
                DAO_HoaDonXuat daoHoaDonXuat = new DAO_HoaDonXuat();
                DAO_NhanVien dAO_NhanVien = new DAO_NhanVien();
                DAO_KhachHang dAO_KhachHang = new DAO_KhachHang();
                hd.SOHD = txtSoHD.Text;
                hd.nhanVien = nhanVien;
                hd.ngayLapHoaDon = dtpNgayHD.Value;
                hd.khachHang = dAO_KhachHang.GetByID(cbKhachHang.SelectedValue.ToString());
                ChiNhanh = dAO_ChiNhanh.GetByUsrID(nhanVien.maNhanVien);
                ChiTietHoaDonXuat chiTietHoaDon = new ChiTietHoaDonXuat(hd, ChiNhanh, nhanVien);
                chiTietHoaDon.ShowDialog();
            }
            else
            {
                DAO_HoaDonXuat daoHoaDonXuat = new DAO_HoaDonXuat();
                DAO_ChiNhanh dAO_ChiNhanh = new DAO_ChiNhanh();
                HoaDonXuat hoaDon = daoHoaDonXuat.GetByID(txtSoHD.Text);
                ChiNhanh chiNhanh = dAO_ChiNhanh.GetByUsrID(hoaDon.nhanVien.maNhanVien);
                ChiTietHoaDonXuat chiTietHoaDon = new ChiTietHoaDonXuat(hoaDon, chiNhanh, nhanVien);
                chiTietHoaDon.ShowDialog();
            }
        }

        private void dgvHoaDonXuat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvHoaDonXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            function.turnOffButton(btnNew, pbAdd);
            function.turnOffButton(btnSave, pbSave);
            function.turnOnButton(btnUpdate, pbUpdate);
            function.turnOnButton(btnDelete, pbDelete);
            function.turnOnButton(btnChiTietHD);
            //
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvHoaDonXuat.Rows[e.RowIndex];
                DAO_HoaDonXuat dAO_HoaDonXuat = new DAO_HoaDonXuat();
                DAO_ChiNhanh dAO_ChiNhanh = new DAO_ChiNhanh();
                HoaDonXuat hoaDonXuat = dAO_HoaDonXuat.GetByID(row.Cells[1].Value.ToString());
                txtSoHD.Text = hoaDonXuat.SOHD;
                cbChiNhanh.Text = dAO_ChiNhanh.GetByUsrID(hoaDonXuat.nhanVien.maNhanVien).tenChiNhanh;
                cbChiNhanh.ValueMember = "maChiNhanh"; //giá trị
                cbNhanVien.Text = hoaDonXuat.nhanVien.tenNhanVien;
                cbNhanVien.ValueMember = "maNhanVien";
                cbKhachHang.Text = hoaDonXuat.khachHang.tenKhachHang;
                cbKhachHang.ValueMember = "maKhachHang";
                dtpNgayHD.Value = hoaDonXuat.ngayLapHoaDon;
                if(nhanVien.capbac < 3)
                {
                    if (nhanVien.maNhanVien != hoaDonXuat.nhanVien.maNhanVien)
                    {
                        function.turnOffButton(btnUpdate, pbUpdate);
                        function.turnOffButton(btnDelete, pbDelete);
                    }
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveType == 1)
            {
                if (hd.chiTietHoaDon.Count != 0)
                {
                    RJMessageBox.Show("Vui lòng điền chi tiết hóa đơn!", "Có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    RJMessageBox.Show("Thêm hóa đơn thành công!", "Thành công", MessageBoxButtons.OK);
                    DAO_ChiNhanh dAO_ChiNhanh = new DAO_ChiNhanh();
                    DAO_HoaDonXuat dAO_HoaDon = new DAO_HoaDonXuat();
                    DAO_NhanVien dAO_NhanVien = new DAO_NhanVien();
                    DAO_KhachHang khachHang = new DAO_KhachHang();
                    hd.SOHD = txtSoHD.Text;
                    hd.nhanVien = nhanVien;
                    hd.ngayLapHoaDon = dtpNgayHD.Value;
                    hd.khachHang = khachHang.GetByID(cbKhachHang.SelectedValue.ToString());
                    ChiNhanh = dAO_ChiNhanh.GetByUsrID(nhanVien.maNhanVien);
                    dAO_HoaDon.Add(hd);
                    table_load();
                }
            }
            else
            {
                RJMessageBox.Show("Cập nhật hóa đơn thành công!", "Thành công", MessageBoxButtons.OK);
                DAO_ChiNhanh dAO_ChiNhanh = new DAO_ChiNhanh();
                DAO_HoaDonXuat dAO_HoaDon = new DAO_HoaDonXuat();
                DAO_NhanVien dAO_NhanVien = new DAO_NhanVien();
                DAO_KhachHang khachHang = new DAO_KhachHang();
                hd.SOHD = txtSoHD.Text;
                hd.nhanVien = nhanVien;
                hd.ngayLapHoaDon = dtpNgayHD.Value;
                hd.khachHang = khachHang.GetByID(cbKhachHang.SelectedValue.ToString());
                ChiNhanh = dAO_ChiNhanh.GetByUsrID(nhanVien.maNhanVien);
                dAO_HoaDon.Update(hd);
                table_load();
            }
        }

        private void cbChiNhanh_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            dgvHoaDonXuat.Rows.Clear();
            int i = 1;
            DAO_HoaDonXuat dAO_HoaDon = new DAO_HoaDonXuat();

            List<HoaDonXuat> hoaDonXuat = dAO_HoaDon.GetByDate(dateTimePicker1.Value, dateTimePicker2.Value);
            foreach (HoaDonXuat hoaDon in hoaDonXuat)
            {
                dgvHoaDonXuat.Rows.Add(i, hoaDon.SOHD, hoaDon.khachHang.tenKhachHang, hoaDon.ngayLapHoaDon.ToString("dd/MM/yyyy"), hoaDon.nhanVien.tenNhanVien, hoaDon.tongHoaDon);
                i++;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            saveType = 2;
            dtpNgayHD.Enabled = true;
            cbKhachHang.Enabled = true;
            function.turnOffButton(btnUpdate, pbUpdate);
            function.turnOffButton(btnDelete, pbDelete);
            function.turnOnButton(btnSave, pbSave);
            function.turnOffButton(btnNew, pbAdd);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = RJMessageBox.Show("Bạn có chắc muốn xóa hóa đơn này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DAO_HoaDonXuat dAO_HoaDonXuat = new DAO_HoaDonXuat();
                dAO_HoaDonXuat.Delete(txtSoHD.Text);
                table_load();
            }
            else
            {

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ucQuanLyXuatHang_Load(sender, e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string _keyWord = txtTraCuuHoaDon.Texts;
            DAO_HoaDonXuat dAO_HoaDon = new DAO_HoaDonXuat();
            dgvHoaDonXuat.Rows.Clear();
            int i = 1;
            HoaDonXuat hoaDon = dAO_HoaDon.GetByID(_keyWord);
            dgvHoaDonXuat.Rows.Add(i, hoaDon.SOHD, hoaDon.khachHang.tenKhachHang, hoaDon.ngayLapHoaDon.ToString("dd/MM/yyyy"), hoaDon.nhanVien.tenNhanVien, hoaDon.tongHoaDon);
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            table_load();
        }
    }
}
