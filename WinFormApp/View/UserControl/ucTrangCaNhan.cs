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
            functions.turnOffButton(btnSave, pbSave);
            functions.turnOnButton(btnUpdate, pbUpdate);
            functions.turnOnButton(btnChangePass, pbChangePass);
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
            string bakAvatar = nhanVien.anhDaiDien;
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                nhanVien.anhDaiDien = Convert.ToBase64String(functions.ConvertImgToByte(openFile.FileName));
                DAO_NhanVien dAO_NhanVien = new DAO_NhanVien();
                var result = RJMessageBox.Show("Bạn có chắc muốn thay đổi ảnh đại diện?",
                "Xác nhận thay đổi",
                MessageBoxButtons.YesNo);
                int exception = 0;
                try
                {
                    dAO_NhanVien.SetUpAvatar(nhanVien.maNhanVien, nhanVien.anhDaiDien);
                    ucTrangCaNhan_Load(sender, e);
                }
                catch (Exception ex)
                {
                    exception++;
                    dAO_NhanVien.SetUpAvatar(nhanVien.maNhanVien, bakAvatar);
                    RJMessageBox.Show("Không thể thay đổi ảnh đại diện, vui lòng thử lại!", "Có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if(exception == 0)
                        RJMessageBox.Show("Thay đổi ảnh đại diện thành công", "Thành công");
                }
            }
        }

        private void pbAnhDaiDien_Click(object sender, EventArgs e)
        {
            FullSizeAvatar fullSizeAvatar = new FullSizeAvatar(nhanVien);
            fullSizeAvatar.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ucTrangCaNhan_Load(sender, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Enable all text box
            txtTenNhanVien.Enabled = true;
            txtSoDienThoai.Enabled = true;
            txtChungMinhNhanDan.Enabled = true;
            txtDiaChi.Enabled = true;
            cbGioiTinh.Enabled = true;
            dtpNgaySinh.Enabled = true;
            functions.turnOnButton(btnSave, pbSave);
            functions.turnOffButton(btnUpdate, pbUpdate);
            functions.turnOffButton(btnChangePass, pbChangePass);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtTenNhanVien.TextLength == 0 || txtSoDienThoai.TextLength == 0 || txtChungMinhNhanDan.TextLength == 0 || txtDiaChi.TextLength == 0)
            {
                RJMessageBox.Show("Thông tin người dùng không được để trống!", "Có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int gender;
                if (cbGioiTinh.Text == "Nam")
                {
                    gender = 1;
                }
                else if (cbGioiTinh.Text == "Nữ")
                {
                    gender = 2;
                }
                else
                {
                    gender = 3;
                }
                nhanVien.tenNhanVien = txtTenNhanVien.Text;
                nhanVien.ngaySinh = dtpNgaySinh.Value;
                nhanVien.soDienThoai = txtSoDienThoai.Text;
                nhanVien.diaChi = txtDiaChi.Text;
                nhanVien.chungMinhNhanDan = Convert.ToInt32(txtChungMinhNhanDan.Text);
                nhanVien.gioiTinh = gender;
                DAO_NhanVien dAO_NhanVien = new DAO_NhanVien();
                DAO_ChiNhanh dAO_ChiNhanh = new DAO_ChiNhanh();
                dAO_NhanVien.Update(nhanVien, dAO_ChiNhanh.GetByUsrID(nhanVien.maNhanVien).maChiNhanh.ToString());
                RJMessageBox.Show("Thay đổi thông tin thành công!", "Thành công");
                ucTrangCaNhan_Load(sender, e);
            }
        }
    }
}
