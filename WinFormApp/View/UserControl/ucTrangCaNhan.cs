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
    public partial class ucTrangCaNhan : UserControl
    {
        Functions functions = new Functions();
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
            if(nhanVien.anhDaiDien == "0")
            {
                pbAnhDaiDien.Image = Properties.Resources.avatar;
            }
            else
            {
                pbAnhDaiDien.Image = functions.ConvertByteToImg(nhanVien.anhDaiDien);
            }
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
            if(nhanVien.gioiTinh == 1)
            {
                cbGioiTinh.Text = "Nam";
            }
            else if(nhanVien.gioiTinh == 2)
            {
                cbGioiTinh.Text = "Nữ";
            }
            else
            {
                cbGioiTinh.Text = "Khác";
            }
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            DoiMatKhau doiMatKhau = new DoiMatKhau(nhanVien);
            doiMatKhau.Show();
        }

        private void pbDelete_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string BinaryImg;
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                BinaryImg = Convert.ToBase64String(functions.ConvertImgToByte(openFile.FileName));
                DAO_NhanVien dAO_NhanVien = new DAO_NhanVien();
                var result = RJMessageBox.Show("Bạn có chắc muốn thay đổi ảnh đại diện?",
                "Xác nhận thay đổi",
                MessageBoxButtons.YesNo);
                RJMessageBox.Show("Thay đổi ảnh đại diên thành công\n\nLưu ý: vui lòng đăng nhập lại để hoàn thành thay đổi!", "Thành công");
                dAO_NhanVien.SetUpAvatar(nhanVien.maNhanVien, BinaryImg);
            }
        }

        private void pbAnhDaiDien_Click(object sender, EventArgs e)
        {
            FullSizeAvatar fullSizeAvatar = new FullSizeAvatar(nhanVien);
            fullSizeAvatar.ShowDialog();
        }
    }
}
