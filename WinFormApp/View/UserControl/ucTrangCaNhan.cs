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

namespace WinFormApp.CustomControl
{
    public partial class ucTrangCaNhan : UserControl
    {
        NhanVien nhanVien = new NhanVien();
        public ucTrangCaNhan()
        {
            InitializeComponent();
            DialogResult  dialog = RJMessageBox.Show("Truy cập không được phép!", "Có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
        public ucTrangCaNhan(NhanVien nhanVien)
        {
            InitializeComponent();
            this.nhanVien = nhanVien;
        }

        private void ucTrangCaNhan_Load(object sender, EventArgs e)
        {
            //Disable all text box
            txtMaNhanVien.Enabled = false;
            txtTenNhanVien.Enabled = false;
            txtSoDienThoai.Enabled = false;
            txtChungMinhNhanDan.Enabled = false;
            txtDiaChi.Enabled = false;
            cbChucVu.Enabled = false;
            cbGioiTinh.Enabled = false;
            dtpNgaySinh.Enabled = false;
            //Load employee data
            txtMaNhanVien.Text = nhanVien.maNhanVien;
            txtTenNhanVien.Text = nhanVien.tenNhanVien;
            txtSoDienThoai.Text = nhanVien.soDienThoai;
            if(nhanVien.capbac == 1)
            {
                cbChucVu.Text = "Nhân Viên";
            }
            else if(nhanVien.capbac == 2)
            {
                cbChucVu.Text = "Quản Lý";
            }
            else
            {
                cbChucVu.Text = "Admin";
            }
            txtChungMinhNhanDan.Text = nhanVien.chungMinhNhanDan.ToString();
            txtDiaChi.Text = nhanVien.diaChi;
            dtpNgaySinh.Value = nhanVien.ngaySinh;
        }
    }
}
