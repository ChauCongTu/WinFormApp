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
    public partial class ucNhanVien : UserControl
    {
        Functions function = new Functions();
        ChiNhanh ChiNhanh = new ChiNhanh();
        NhanVien nhanVien = new NhanVien();
        NhanVien nhan_Vien = new NhanVien();
        int saveType;
        public ucNhanVien()
        {
            InitializeComponent();
        }
        public ucNhanVien(NhanVien nhanVien)
        {
            InitializeComponent();
            this.nhanVien = nhanVien;
        }
        void Table_load()       // function load du lieu dgv
        {
            dgvNhanVien.Rows.Clear();
            int i = 1;
            DAO_NhanVien dAO_NhanVien = new DAO_NhanVien();
            List<NhanVien> nhanVien = dAO_NhanVien.GetAll();
            foreach (NhanVien nhanViens in nhanVien)
            {
                string chucvu;
                if (nhanViens.capbac == 1)
                {
                    chucvu = "Nhân Viên";
                }
                else if (nhanViens.capbac == 2)
                {
                    chucvu = "Quản Lý";
                }
                else
                {
                    chucvu = "Admin";
                }

                dgvNhanVien.Rows.Add(i, nhanViens.maNhanVien, nhanViens.tenNhanVien, nhanViens.ngaySinh.ToString("dd/MM/yyyy"), nhanViens.soDienThoai, chucvu, nhanViens.diaChi);
                i++;

            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)  // Chức năng thêm nhân viên
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
        }

        private void ucNhanVien_Load(object sender, EventArgs e)
        {
            txtManhanvien.Enabled = false;
            txtTen.Enabled = false;
            txtSodienthoai.Enabled = false;
            txtDiachi.Enabled = false;
            cbChucvu.Enabled = false;
            cbGioitinh.Enabled = false;
            function.turnOffButton(btnSave, pbsave);
            function.turnOffButton(btn_sua, pbedit);
            function.turnOffButton(btn_xoa, pbdelete);
            DAO_ChiNhanh dAO_ChiNhanh = new DAO_ChiNhanh();
            Table_load();
            cbChiNhanh.DataSource = dAO_ChiNhanh.getAll();
            cbChiNhanh.ValueMember = "maChiNhanh";
            cbChiNhanh.DisplayMember = "tenChiNhanh";
        }

        void check() //fct check rong 
        {
            if (txtManhanvien.Text.Length == 0 || txtTen.Text.Length == 0 || txtDiachi.Text.Length == 0 || txtSodienthoai.Text.Length == 0 || cbGioitinh.Text.Length == 0 || cbChucvu.Text.Length == 0)
            {
                RJMessageBox.Show("Vui lòng điền đầy đủ các thông tin nhân viên!",
                    "Có lỗi xảy ra",
                    MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Error);
            }
        }

        private void btn_them_Click(object sender, EventArgs e) //Them nhan vien
        {
            saveType = 1;
            dtpNgaysinh.Enabled = true;
            cbGioitinh.Enabled = true;
            cbChucvu.Enabled = true;
            txtTen.Enabled = true;
            txtSodienthoai.Enabled = true;
            txtDiachi.Enabled = true;
            function.turnOffButton(btn_them, pbadd);
            function.turnOnButton(btnSave, pbsave);
            function.turnOffButton(btn_sua, pbedit);
            function.turnOffButton(btn_xoa, pbdelete);
            //Xử lý sự kiện 
            DAO_ChiNhanh dAO_ChiNhanh = new DAO_ChiNhanh();
            DAO_NhanVien dAO_NhanVien = new DAO_NhanVien();
            txtManhanvien.Text = function.CreateID(dAO_NhanVien.GetLast().maNhanVien);
            cbChiNhanh.Text = dAO_ChiNhanh.GetByUsrID(nhanVien.maNhanVien).tenChiNhanh;

        }

        private void pbedit_Click(object sender, EventArgs e)
        {

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            txtManhanvien.Enabled = true;
            txtTen.Enabled = true;
            dtpNgaysinh.Enabled = true;
            cbGioitinh.Enabled = true;
            txtDiachi.Enabled = true;
            txtSodienthoai.Enabled = true;
            cbChucvu.Enabled = true;
            function.turnOnButton(btnSave, pbsave);
            function.turnOffButton(btn_them, pbadd);
            function.turnOffButton(btn_xoa, pbdelete);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveType == 1)
            {
                if (txtManhanvien.Text.Length == 0 || txtTen.Text.Length == 0 || txtDiachi.Text.Length == 0 || txtSodienthoai.Text.Length == 0 || cbGioitinh.Text.Length == 0 || cbChucvu.Text.Length == 0 || cbChiNhanh.Text.Length == 0)
                {
                    RJMessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    RJMessageBox.Show("Thêm nhân viên thành công!", "Thành công", MessageBoxButtons.OK);
                    DAO_ChiNhanh dAO_ChiNhanh = new DAO_ChiNhanh();
                    DAO_NhanVien dAO_NhanVien = new DAO_NhanVien();
                    nhanVien.tenNhanVien = txtTen.Text;
                    nhanVien.maNhanVien = function.CreateID(dAO_NhanVien.GetLast().maNhanVien);
                    nhanVien.ngaySinh = dtpNgaysinh.Value;
                    dAO_NhanVien.Add(nhanVien, cbChiNhanh.SelectedValue.ToString());
                    Table_load();
                }
            }
            else
            {
                RJMessageBox.Show("Cập nhật nhân viên thành công!", "Thành công", MessageBoxButtons.OK);
                DAO_ChiNhanh dAO_ChiNhanh = new DAO_ChiNhanh();
                DAO_NhanVien dAO_NhanVien = new DAO_NhanVien();
                nhanVien.tenNhanVien = txtTen.Text;
                nhanVien.maNhanVien = function.CreateID(dAO_NhanVien.GetLast().maNhanVien);
                nhanVien.ngaySinh = dtpNgaysinh.Value;
                dAO_NhanVien.Update(nhanVien, cbChiNhanh.SelectedValue.ToString());
                Table_load();
            }

        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            function.turnOffButton(btn_them, pbadd);
            function.turnOffButton(btnSave, pbsave);
            function.turnOnButton(btn_xoa, pbdelete);

            //
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
                DAO_NhanVien dAO_NhanVien = new DAO_NhanVien();
                DAO_ChiNhanh dAO_ChiNhanh = new DAO_ChiNhanh();
                NhanVien nhanVien = dAO_NhanVien.GetByID(row.Cells[1].Value.ToString());
                txtTen.Text = nhanVien.tenNhanVien;
                txtManhanvien.Text = nhanVien.maNhanVien;
                cbChiNhanh.Text = dAO_ChiNhanh.GetByUsrID(nhanVien.maNhanVien).tenChiNhanh;
                cbChiNhanh.ValueMember = "maChiNhanh"; //giá trị
                dtpNgaysinh.Value = nhanVien.ngaySinh;
                txtSodienthoai.Text = nhanVien.soDienThoai;
                txtDiachi.Text = nhanVien.diaChi;
                dtpNgaysinh.Value = nhanVien.ngaySinh;
                cbChucvu.Text = nhanVien.capbac.ToString();
                if (nhanVien.capbac == 1)
                {
                    cbChucvu.Text = "Nhân Viên";
                }
                else if (nhanVien.capbac == 2)
                {
                    cbChucvu.Text = "Quản Lý";
                }
                else
                {
                    cbChucvu.Text = "Admin";
                }
                cbGioitinh.Text = nhanVien.gioiTinh.ToString();
                if (nhanVien.gioiTinh == 1)
                {
                    cbGioitinh.Text = "Nam";
                }
                else if (nhanVien.gioiTinh == 2)
                {
                    cbGioitinh.Text = "Nữ";
                }
                else
                {
                    cbGioitinh.Text = "Khác";
                }
                if (nhanVien.capbac == 1)
                {
                    function.turnOffButton(btnSave, pbsave);
                    function.turnOffButton(btn_sua, pbedit);
                    function.turnOffButton(btn_xoa, pbdelete);

                }
            }
        }

        private void cbChiNhanh_SelectedValueChanged(object sender, EventArgs e)
        {
            dgvNhanVien.Rows.Clear();
            int i = 1;
            DAO_NhanVien dAO_NhanVien = new DAO_NhanVien();
            List<NhanVien> nhanVien = dAO_NhanVien.GetList(cbChiNhanh.SelectedValue.ToString());
            foreach (NhanVien nhanViens in nhanVien)
            {
                dgvNhanVien.Rows.Add(i, nhanViens.maNhanVien, nhanViens.tenNhanVien, nhanViens.ngaySinh.ToString("dd/MM/yyyy"), nhanViens.soDienThoai, nhanViens.capbac, nhanViens.diaChi);
                i++;
            }

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            var result = RJMessageBox.Show("Bạn có chắc muốn xóa nhân viên này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DAO_NhanVien dAO_NhanVien = new DAO_NhanVien();
                dAO_NhanVien.Delete(txtManhanvien.Text);
                Table_load();
            }
            else
            {

            }
        }

        private void cbChiNhanh_SelectedValueChanged_1(object sender, EventArgs e)
        {
            dgvNhanVien.Rows.Clear();
            int i = 1;
            DAO_NhanVien dAO_NhanVien = new DAO_NhanVien();
            List<NhanVien> nhanVien = dAO_NhanVien.GetList(cbChiNhanh.SelectedValue.ToString());
            foreach (NhanVien nhanViens in nhanVien)
            {
                string chucvu;
                if (nhanViens.capbac == 1)
                {
                    chucvu = "Nhân Viên";
                }
                else if (nhanViens.capbac == 2)
                {
                    chucvu = "Quản Lý";
                }
                else
                {
                    chucvu = "Admin";
                }

                dgvNhanVien.Rows.Add(i, nhanViens.maNhanVien, nhanViens.tenNhanVien, nhanViens.ngaySinh.ToString("dd/MM/yyyy"), nhanViens.soDienThoai, chucvu, nhanViens.diaChi);
                i++;

            }
        }
    }
}
