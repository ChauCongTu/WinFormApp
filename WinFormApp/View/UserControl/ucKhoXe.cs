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
    public partial class ucKhoXe : UserControl
    {
        Functions function = new Functions();
        SanPhamXe _sanPhamXe = new SanPhamXe();
        int saveType;
        string _maChiNhanh;
        public ucKhoXe()
        {
            InitializeComponent();
        }
        void table_load()
        {
            dgvKhoXe.Rows.Clear();
            int i = 1;
            DAO_SanPhamXe dAO_SanPhamXe = new DAO_SanPhamXe();
            List<SanPhamXe> xe = dAO_SanPhamXe.GetList(_maChiNhanh);
            foreach(SanPhamXe sanPham in xe)
            {
                string loaiXe = dAO_SanPhamXe.GetLoaiXe(sanPham.maSanPham);
                dgvKhoXe.Rows.Add(i, sanPham.maSanPham, sanPham.tenSanPham,loaiXe , sanPham.donGia, sanPham.soKhungXe);
                i++;
            }
        }
        private void ucKhoXe_Load(object sender, EventArgs e)
        {
            DAO_ChiNhanh dAO_ChiNhanh = new DAO_ChiNhanh();
            cbChiNhanh.DataSource = dAO_ChiNhanh.getAll();
            cbChiNhanh.ValueMember = "maChiNhanh";
            cbChiNhanh.DisplayMember = "tenChiNhanh";
            txtMaXe.Enabled = false;
            txtTenXe.Enabled = false;
            cbLoaiXe.Enabled = false;
            txtDonGia.Enabled = false;
            txtSoKhung.Enabled = false;
            function.turnOffButton(btnXemChiTiet);
            function.turnOffButton(btnUpdate, pbUpdate);
            function.turnOffButton(btnDelete, pbDelete);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ChiTietXe chiTietXe = new ChiTietXe(_sanPhamXe, 1, cbChiNhanh.SelectedValue.ToString());
            chiTietXe.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ChiTietXe chiTietXe = new ChiTietXe(_sanPhamXe, 2, cbChiNhanh.SelectedValue.ToString());
            chiTietXe.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = RJMessageBox.Show("Bạn có chắc muốn xóa sản phẩm này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DAO_SanPhamXe dAO_SanPhamXe = new DAO_SanPhamXe();
                dAO_SanPhamXe.Delete(txtMaXe.Text);
                table_load();
            }
            else
            {

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            txtMaXe.Enabled = false;
            txtTenXe.Enabled = false;
            cbLoaiXe.Enabled = false;
            txtDonGia.Enabled = false;
            txtSoKhung.Enabled = false;
            function.turnOffButton(btnXemChiTiet);
            function.turnOffButton(btnUpdate, pbUpdate);
            function.turnOnButton(btnNew, pbAdd);
            function.turnOffButton(btnDelete, pbDelete);
            txtMaXe.Text = "";
            txtTenXe.Text = "";
            txtDonGia.Text = "";
            txtSoKhung.Text = "";
        }

        private void dgvKhoXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            function.turnOffButton(btnNew, pbAdd);
            function.turnOnButton(btnUpdate, pbUpdate);
            function.turnOnButton(btnDelete, pbDelete);
            function.turnOnButton(btnXemChiTiet);
            //
            DataGridViewRow row = dgvKhoXe.Rows[e.RowIndex];
            DAO_SanPhamXe dAO_SanPhamXe = new DAO_SanPhamXe();
            _sanPhamXe = dAO_SanPhamXe.GetByID(row.Cells[1].Value.ToString());
            txtMaXe.Text = _sanPhamXe.maSanPham;
            txtTenXe.Text = _sanPhamXe.tenSanPham;
            cbLoaiXe.Text = dAO_SanPhamXe.GetLoaiXe(_sanPhamXe.maSanPham);
            txtDonGia.Text = _sanPhamXe.donGia.ToString();
            txtSoKhung.Text = _sanPhamXe.soKhungXe;
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            int thaotac = 3;
            ChiTietXe chiTietXe = new ChiTietXe(_sanPhamXe, thaotac, cbChiNhanh.SelectedValue.ToString());
            chiTietXe.ShowDialog();
        }

        private void cbNhanVien_SelectedValueChanged(object sender, EventArgs e)
        {
            _maChiNhanh = cbChiNhanh.SelectedValue.ToString();
            table_load();
        }
    }
}
