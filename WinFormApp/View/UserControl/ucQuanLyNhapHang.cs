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
        NhanVien nhanVien = new NhanVien();
        HoaDonNhap hd = new HoaDonNhap();
        int saveType;
        public ucQuanLyNhapHang(NhanVien nhanVien)
        {
            InitializeComponent();
            this.nhanVien = nhanVien;
        }
        public ucQuanLyNhapHang(HoaDonNhap hd, NhanVien nhanVien)
        {
            InitializeComponent();
            this.hd = hd;
            this.nhanVien = nhanVien;
        }
        void table_load()
        {
            dgvHoaDonXuat.Rows.Clear();
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
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            saveType = 1;
            dtpNgayHD.Enabled = true;
            cbNhaCungCap.Enabled = true;
            function.turnOnButton(btnChiTietHD);
            function.turnOffButton(btnNew, pbAdd);
            function.turnOnButton(btnSave, pbSave);
            function.turnOffButton(btnUpdate, pbUpdate);
            function.turnOffButton(btnDelete, pbDelete);
            //Xử lý sự kiện 
            DAO_HoaDonNhap daoHoaDonNhap = new DAO_HoaDonNhap();
            DAO_NhanVien dAO_NhanVien = new DAO_NhanVien();
            DAO_NhaCungCap dAO_NhaCungCap = new DAO_NhaCungCap();
            txtSoHD.Text = function.CreateID(daoHoaDonNhap.GetLast().SOHD);
            DAO_ChiNhanh dAO_ChiNhanh = new DAO_ChiNhanh();
            cbChiNhanh.Text = dAO_ChiNhanh.GetByUsrID(nhanVien.maNhanVien).tenChiNhanh;
            cbChiNhanh.ValueMember = "maChiNhanh"; //giá trị
            cbChiNhanh.DisplayMember = "tenChiNhanh"; //hiển thị
            cbNhanVien.Text = nhanVien.tenNhanVien;
            cbNhanVien.ValueMember = "maNhanVien";
            cbNhanVien.DisplayMember = "tenNhanVien";
            cbNhaCungCap.DataSource = dAO_NhaCungCap.GetAll();
            cbNhaCungCap.ValueMember = "maNhaCungCap";
            cbNhaCungCap.DisplayMember = "tenNhaCungCap";
        }

        private void btnChiTietHD_Click(object sender, EventArgs e)
        {
            if(saveType == 1)
            {
                DAO_ChiNhanh dAO_ChiNhanh = new DAO_ChiNhanh();
                DAO_HoaDonNhap dAO_HoaDon = new DAO_HoaDonNhap();
                DAO_NhanVien dAO_NhanVien = new DAO_NhanVien();
                DAO_NhaCungCap dAO_NhaCungCap = new DAO_NhaCungCap();
                hd.SOHD = txtSoHD.Text;
                hd.nhanVien = nhanVien;
                hd.ngayLapHoaDon = dtpNgayHD.Value;
                hd.nhaCungCap = dAO_NhaCungCap.GetByID(cbNhaCungCap.SelectedValue.ToString());
                ChiNhanh = dAO_ChiNhanh.GetByUsrID(nhanVien.maNhanVien);
                ChiTietHoaDonNhap chiTietHoaDon = new ChiTietHoaDonNhap(hd, ChiNhanh, nhanVien);
                chiTietHoaDon.ShowDialog();
            }
            else
            {
                DAO_HoaDonNhap hoaDonNhap = new DAO_HoaDonNhap();
                DAO_ChiNhanh dAO_ChiNhanh = new DAO_ChiNhanh();
                HoaDonNhap hoaDon = hoaDonNhap.GetByID(txtSoHD.Text);
                ChiNhanh chiNhanh = dAO_ChiNhanh.GetByUsrID(hoaDon.nhanVien.maNhanVien);
                ChiTietHoaDonNhap chiTietHoaDon = new ChiTietHoaDonNhap(hoaDon, chiNhanh, nhanVien);
                chiTietHoaDon.ShowDialog();
            }
        }

        private void dgvHoaDonXuat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvHoaDonXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            function.turnOffButton(btnSave, pbSave);
            function.turnOnButton(btnUpdate, pbUpdate);
            function.turnOnButton(btnDelete, pbDelete);
            function.turnOnButton(btnChiTietHD);
            //
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvHoaDonXuat.Rows[e.RowIndex];
                DAO_HoaDonNhap dAO_HoaDonNhap = new DAO_HoaDonNhap();
                DAO_ChiNhanh dAO_ChiNhanh = new DAO_ChiNhanh();
                HoaDonNhap hoaDonNhap = dAO_HoaDonNhap.GetByID(row.Cells[1].Value.ToString());
                txtSoHD.Text = hoaDonNhap.SOHD;
                cbChiNhanh.Text = dAO_ChiNhanh.GetByUsrID(hoaDonNhap.nhanVien.maNhanVien).tenChiNhanh;
                cbChiNhanh.ValueMember = "maChiNhanh"; //giá trị
                cbNhanVien.Text = hoaDonNhap.nhanVien.tenNhanVien;
                cbNhanVien.ValueMember = "maNhanVien";
                cbNhaCungCap.Text = hoaDonNhap.nhaCungCap.tenNhaCungCap;
                cbNhaCungCap.ValueMember = "maNhaCungCap";
                dtpNgayHD.Value = hoaDonNhap.ngayLapHoaDon;
                if(nhanVien.capbac == 1)
                {
                    if (nhanVien.maNhanVien != hoaDonNhap.nhanVien.maNhanVien)
                    {
                        function.turnOffButton(btnUpdate, pbUpdate);
                        function.turnOffButton(btnDelete, pbDelete);
                    }
                }
            }
        }

        private void cbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            DAO_NhanVien dAO_NhanVien = new DAO_NhanVien();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(saveType == 1)
            {
                if (hd.chiTietHoaDon.Count != 0)
                {
                    RJMessageBox.Show("Vui lòng điền chi tiết hóa đơn!", "Có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    RJMessageBox.Show("Thêm hóa đơn thành công!", "Thành công", MessageBoxButtons.OK);
                    DAO_ChiNhanh dAO_ChiNhanh = new DAO_ChiNhanh();
                    DAO_HoaDonNhap dAO_HoaDon = new DAO_HoaDonNhap();
                    DAO_NhanVien dAO_NhanVien = new DAO_NhanVien();
                    DAO_NhaCungCap dAO_NhaCungCap = new DAO_NhaCungCap();
                    hd.SOHD = txtSoHD.Text;
                    hd.nhanVien = nhanVien;
                    hd.ngayLapHoaDon = dtpNgayHD.Value;
                    hd.nhaCungCap = dAO_NhaCungCap.GetByID(cbNhaCungCap.SelectedValue.ToString());
                    ChiNhanh = dAO_ChiNhanh.GetByUsrID(nhanVien.maNhanVien);
                    dAO_HoaDon.Add(hd);
                    table_load();
                }
            }
            else
            {
                RJMessageBox.Show("Cập nhật hóa đơn thành công!", "Thành công", MessageBoxButtons.OK);
                DAO_ChiNhanh dAO_ChiNhanh = new DAO_ChiNhanh();
                DAO_HoaDonNhap dAO_HoaDon = new DAO_HoaDonNhap();
                DAO_NhanVien dAO_NhanVien = new DAO_NhanVien();
                DAO_NhaCungCap dAO_NhaCungCap = new DAO_NhaCungCap();
                hd.SOHD = txtSoHD.Text;
                hd.nhanVien = nhanVien;
                hd.ngayLapHoaDon = dtpNgayHD.Value;
                hd.nhaCungCap = dAO_NhaCungCap.GetByID(cbNhaCungCap.SelectedValue.ToString());
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
            DAO_HoaDonNhap dAO_HoaDonNhap = new DAO_HoaDonNhap();

            List<HoaDonNhap> hoaDonNhap = dAO_HoaDonNhap.GetByDate(dtpFrom.Value.Date, dtpTo.Value.Date);
            foreach (HoaDonNhap hoaDon in hoaDonNhap)
            {
                dgvHoaDonXuat.Rows.Add(i, hoaDon.SOHD, hoaDon.nhaCungCap.tenNhaCungCap, hoaDon.ngayLapHoaDon.ToString(), hoaDon.nhanVien.tenNhanVien, hoaDon.tongHoaDon);
                i++;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            saveType = 2;
            dtpNgayHD.Enabled = true;
            cbNhaCungCap.Enabled = true;
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
            if(result == DialogResult.Yes)
            {
                DAO_HoaDonNhap dAO_HoaDonNhap = new DAO_HoaDonNhap();
                dAO_HoaDonNhap.Delete(txtSoHD.Text);
                table_load();
            }
            else
            {

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
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
            txtSoHD.Text = "";
            dtpNgayHD.Value = DateTime.Now;
            cbChiNhanh.Text = "";
            cbNhaCungCap.Text = "-- Chọn nhà cung cấp --";
            cbNhanVien.Text = nhanVien.tenNhanVien;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string _keyWord = txtTraCuuHoaDon.Texts;
            DAO_HoaDonNhap dAO_HoaDonNhap = new DAO_HoaDonNhap();
            HoaDonNhap hoaDonNhap = dAO_HoaDonNhap.GetByID(_keyWord);
            dgvHoaDonXuat.Rows.Clear();
            int i = 1;
            List<HoaDonNhap> hoaDonNhaps = new List<HoaDonNhap>();
            hoaDonNhaps.Add(hoaDonNhap);
            foreach (HoaDonNhap hoaDon in hoaDonNhaps)
            {
                dgvHoaDonXuat.Rows.Add(i, hoaDon.SOHD, hoaDon.nhaCungCap.tenNhaCungCap, hoaDon.ngayLapHoaDon.ToString(), hoaDon.nhanVien.tenNhanVien, hoaDon.tongHoaDon);
                i++;
            }
        }
    }
}
