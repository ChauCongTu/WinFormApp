using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using WinFormApp.Model;

namespace WinFormApp.CustomControl
{
    public partial class ucNhanVien : UserControl
    {
        public ucNhanVien()
        {
            InitializeComponent();
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
        void turnOffButton(Button btn, PictureBox picture)
        {
            btn.Enabled = false;
            btn.BackColor = Color.FromArgb(238, 238, 238);
            picture.BackColor = Color.FromArgb(238, 238, 238);
        }
        void turnOffButton(Button btn)
        {
            btn.Enabled = false;
            btn.BackColor = Color.FromArgb(238, 238, 238);
        }
        void turnOnButton(Button btn, PictureBox picture)
        {
            btn.Enabled = true;
            btn.BackColor = Color.FromArgb(23, 162, 139);
            picture.BackColor = Color.FromArgb(23, 162, 139);
        }
        void turnOnButton(Button btn)
        {
            btn.Enabled = true;
            btn.BackColor = Color.FromArgb(23, 162, 139);
        }
        private void button1_Click(object sender, EventArgs e)  // Chức năng thêm nhân viên
        {
            txtManhanvien.Enabled = true;
            txtTen.Enabled = true;
            dtbNgaysinh.Enabled = true;
            rdNam.Enabled = true;
            rdNu.Enabled = true;
            txtDiachi.Enabled = true;
            txtSodienthoai.Enabled = true;
            cbChucvu.Enabled = true;
            turnOnButton(btnSave, pbsave);
            turnOffButton(btn_sua, pbedit);
            turnOffButton(btn_xoa, pbdelete);
            if (txtManhanvien.Text.Length == 0 || txtTen.Text.Length == 0|| txtDiachi.Text.Length == 0 || txtSodienthoai.Text.Length == 0|| rdNam.Text.Length == 0 || rdNu.Text.Length == 0 || cbChucvu.Text.Length == 0)
            {
                RJMessageBox.Show("Vui lòng điền đầy đủ các thông tin nhân viên!",
                    "Có lỗi xảy ra",
                    MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Error);
            }
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
            //panel1.Controls.Add(new QuanLyCuaHang());        Thêm chức năng thoát về trang chủ
        }

        private void text_ten_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            txtManhanvien.Enabled = true;
            txtTen.Enabled = true;
            dtbNgaysinh.Enabled = true;
            rdNam.Enabled = true;
            rdNu.Enabled = true;
            txtDiachi.Enabled = true;
            txtSodienthoai.Enabled = true;
            cbChucvu.Enabled = true;
            turnOnButton(btnSave, pbsave);
            turnOffButton(btn_them, pbadd);
            turnOffButton(btn_xoa, pbdelete);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
