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

namespace WinFormApp.View
{
    public partial class ChiTietXe : Form
    {
        SanPhamXe sanPhamXe = new SanPhamXe();
        DAO_SanPhamXe dAO_SanPhamXe = new DAO_SanPhamXe();
        Functions functions = new Functions();
        string machinhanh;
        int thaoTac;
        public ChiTietXe()
        {
            InitializeComponent();
        }
        public ChiTietXe(SanPhamXe sanPhamXe, int thaotac, string machinhanh)
        {
            InitializeComponent();
            this.sanPhamXe = sanPhamXe;
            this.thaoTac = thaotac;
            this.machinhanh = machinhanh;
        }
        void DisableChiTiet()
        {
            txtMaSP.Enabled = false;
            txtCongSuatMax.Enabled = false;
            txtDonGia.Enabled = false;
            txtDungTichBX.Enabled = false;
            txtDungTichNhot.Enabled = false;
            txtDungTichXL.Enabled = false;
            txtHanhTrinhPittong.Enabled = false;
            txtHTKhoiDong.Enabled = false;
            txtKhoiLuong.Enabled = false;
            txtLoaiDC.Enabled = false;
            txtLoaiTruyenDong.Enabled = false;
            txtSoKhung.Enabled = false;
            txtTenXe.Enabled = false;
            txtTySoNen.Enabled = false;
            cbLoaiXe.Enabled = false;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ChiTietXe_Load(object sender, EventArgs e)
        {
            if(thaoTac == 1)
            {
                txtMaXe.Text = functions.CreateID(dAO_SanPhamXe.GetXeLast().maXe);
                txtMaSP.Text = functions.CreateID(dAO_SanPhamXe.GetSPLast().maSanPham);
                txtMaSP.Enabled = false;
            }
            else if(thaoTac == 2)
            {
                txtMaXe.Text = sanPhamXe.maXe;
                txtMaSP.Text = sanPhamXe.maSanPham;
                txtTenXe.Text = sanPhamXe.tenSanPham;
                txtDonGia.Text = sanPhamXe.donGia.ToString();
                txtSoKhung.Text = sanPhamXe.soKhungXe;
                cbLoaiXe.Text = dAO_SanPhamXe.GetLoaiXe(sanPhamXe.maSanPham);
                txtKhoiLuong.Text = sanPhamXe.khoiLuong.ToString();
                txtCongSuatMax.Text = sanPhamXe.congSuatToiDa.ToString();
                txtDungTichBX.Text = sanPhamXe.dungTichBinhXang.ToString();
                txtDungTichNhot.Text = sanPhamXe.dungTichNhot;
                txtDungTichXL.Text = sanPhamXe.dungTichXiLanh.ToString();
                txtHanhTrinhPittong.Text = sanPhamXe.hanhTrinhPittong;
                txtHTKhoiDong.Text = sanPhamXe.heThongKhoiDong;
                txtLoaiDC.Text = sanPhamXe.loaiDongCo;
                txtLoaiTruyenDong.Text = sanPhamXe.loaiTruyenDong;
                txtTySoNen.Text = sanPhamXe.tySoNen;
                txtMaSP.Enabled = false;
            }
            else
            {
                txtMaXe.Text = sanPhamXe.maXe;
                txtMaSP.Text = sanPhamXe.maSanPham;
                txtTenXe.Text = sanPhamXe.tenSanPham;
                txtDonGia.Text = sanPhamXe.donGia.ToString();
                txtSoKhung.Text = sanPhamXe.soKhungXe;
                cbLoaiXe.Text = dAO_SanPhamXe.GetLoaiXe(sanPhamXe.maSanPham);
                txtKhoiLuong.Text = sanPhamXe.khoiLuong.ToString();
                txtCongSuatMax.Text = sanPhamXe.congSuatToiDa.ToString();
                txtDungTichBX.Text = sanPhamXe.dungTichBinhXang.ToString();
                txtDungTichNhot.Text = sanPhamXe.dungTichNhot;
                txtDungTichXL.Text = sanPhamXe.dungTichXiLanh.ToString();
                txtHanhTrinhPittong.Text = sanPhamXe.hanhTrinhPittong;
                txtHTKhoiDong.Text = sanPhamXe.heThongKhoiDong;
                txtLoaiDC.Text = sanPhamXe.loaiDongCo;
                txtLoaiTruyenDong.Text = sanPhamXe.loaiTruyenDong;
                txtTySoNen.Text = sanPhamXe.tySoNen;
                DisableChiTiet();
                functions.turnOffButton(btnSave, pbSave);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(thaoTac == 1)
            {
                if(txtCongSuatMax.TextLength == 0 || txtDonGia.TextLength == 0 || txtDungTichBX.TextLength == 0 || txtDungTichNhot.TextLength == 0 || txtDungTichXL.TextLength == 0 || txtHanhTrinhPittong.TextLength == 0 || txtHTKhoiDong.TextLength == 0 || txtKhoiLuong.TextLength == 0 || txtLoaiDC.TextLength == 0 || txtLoaiTruyenDong.TextLength == 0 || txtSoKhung.TextLength == 0 || txtTenXe.TextLength == 0 || txtTySoNen.TextLength == 0)
                {
                    RJMessageBox.Show("Bạn phải điền đầy đủ thông tin!", "Có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(dAO_SanPhamXe.CheckSoKhung(txtSoKhung.Text) == false)
                {
                    RJMessageBox.Show("Số khung xe đã tồn tại!", "Có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    RJMessageBox.Show("Thêm thành công sản phẩm xe: "+txtMaXe.Text, "Thành công", MessageBoxButtons.OK);
                    sanPhamXe.maXe = txtMaXe.Text;
                    sanPhamXe.maSanPham = txtMaSP.Text;
                    sanPhamXe.tenSanPham = txtTenXe.Text;
                    sanPhamXe.donGia = Convert.ToDecimal(txtDonGia.Text);
                    sanPhamXe.soKhungXe = txtSoKhung.Text;
                    sanPhamXe.khoiLuong = Convert.ToInt64(txtKhoiLuong.Text);
                    sanPhamXe.congSuatToiDa = txtCongSuatMax.Text;
                    sanPhamXe.dungTichBinhXang = Convert.ToInt64(txtDungTichBX.Text);
                    sanPhamXe.dungTichNhot = txtDungTichNhot.Text;
                    sanPhamXe.dungTichXiLanh = Convert.ToInt64(txtDungTichXL.Text);
                    sanPhamXe.hanhTrinhPittong = txtHanhTrinhPittong.Text;
                    sanPhamXe.heThongKhoiDong = txtHTKhoiDong.Text;
                    sanPhamXe.loaiDongCo = txtLoaiDC.Text;
                    sanPhamXe.loaiTruyenDong = txtLoaiTruyenDong.Text;
                    sanPhamXe.tySoNen = txtTySoNen.Text;
                    sanPhamXe.donViTinh = "CHIẾC";
                    string maloai = "";
                    if (cbLoaiXe.SelectedItem.ToString() == "Xe số")
                    {
                        maloai = "PKL002";
                    }
                    else if (cbLoaiXe.SelectedItem.ToString() == "Xe côn tay")
                    {
                        maloai = "PKL001";
                    }
                    else
                    {
                        maloai = "PKL003";
                    }
                    dAO_SanPhamXe.Add(sanPhamXe, maloai, machinhanh);
                    DisableChiTiet();
                }
            }
            else if(thaoTac == 2)
            {
                if (txtCongSuatMax.TextLength == 0 || txtDonGia.TextLength == 0 || txtDungTichBX.TextLength == 0 || txtDungTichNhot.TextLength == 0 || txtDungTichXL.TextLength == 0 || txtHanhTrinhPittong.TextLength == 0 || txtHTKhoiDong.TextLength == 0 || txtKhoiLuong.TextLength == 0 || txtLoaiDC.TextLength == 0 || txtLoaiTruyenDong.TextLength == 0 || txtSoKhung.TextLength == 0 || txtTenXe.TextLength == 0 || txtTySoNen.TextLength == 0)
                {
                    RJMessageBox.Show("Bạn phải điền đầy đủ thông tin!", "Có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    RJMessageBox.Show("Thay đổi thành công sản phẩm xe: " + txtMaXe.Text, "Thành công", MessageBoxButtons.OK);
                    sanPhamXe.maXe = txtMaXe.Text;
                    sanPhamXe.maSanPham = txtMaSP.Text;
                    sanPhamXe.tenSanPham = txtTenXe.Text;
                    sanPhamXe.donGia = Convert.ToDecimal(txtDonGia.Text);
                    sanPhamXe.soKhungXe = txtSoKhung.Text;
                    sanPhamXe.khoiLuong = Convert.ToInt64(txtKhoiLuong.Text);
                    sanPhamXe.congSuatToiDa = txtCongSuatMax.Text;
                    sanPhamXe.dungTichBinhXang = Convert.ToInt64(txtDungTichBX.Text);
                    sanPhamXe.dungTichNhot = txtDungTichNhot.Text;
                    sanPhamXe.dungTichXiLanh = Convert.ToInt64(txtDungTichXL.Text);
                    sanPhamXe.hanhTrinhPittong = txtHanhTrinhPittong.Text;
                    sanPhamXe.heThongKhoiDong = txtHTKhoiDong.Text;
                    sanPhamXe.loaiDongCo = txtLoaiDC.Text;
                    sanPhamXe.loaiTruyenDong = txtLoaiTruyenDong.Text;
                    sanPhamXe.tySoNen = txtTySoNen.Text;
                    sanPhamXe.donViTinh = "CHIẾC";
                    string maloai = "";
                    if (cbLoaiXe.SelectedItem.ToString() == "Xe số")
                    {
                        maloai = "PKL002";
                    }
                    else if (cbLoaiXe.SelectedItem.ToString() == "Xe côn tay")
                    {
                        maloai = "PKL001";
                    }
                    else
                    {
                        maloai = "PKL003";
                    }
                    dAO_SanPhamXe.Update(sanPhamXe, maloai);
                    DisableChiTiet();
                }
            }
        }

        private void cbLoaiXe_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
