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
    public partial class ucKhoPhuTung : UserControl
    {
        public ucKhoPhuTung()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
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
        private void btn_them_Click(object sender, EventArgs e)
        {
            txtMaphutung.Enabled = true;
            txtTenphutung.Enabled = true;
            txtMota.Enabled = true;
            txtMaphutung.Enabled = true;
            turnOnButton(btnSave, pbsave);
            turnOffButton(btn_sua, pbedit);
            turnOffButton(btn_xoa, pbdelete);
            if (txtMaphutung.Text.Length == 0 || txtTenphutung.Text.Length == 0 || txtMota.Text.Length == 0 || txtSoluong.Text.Length == 0)
            {
                RJMessageBox.Show("Vui lòng điền đầy đủ các thông tin phụ tùng!",
                    "Có lỗi xảy ra",
                    MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Error);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            txtMaphutung.Enabled = true;
            txtTenphutung.Enabled = true;
            txtMota.Enabled = true;
            txtMaphutung.Enabled = true;
            turnOnButton(btnSave, pbsave);
            turnOffButton(btn_them, pbadd);
            turnOffButton(btn_xoa, pbdelete);
            if (txtMaphutung.Text.Length == 0 || txtTenphutung.Text.Length == 0 || txtMota.Text.Length == 0 || txtSoluong.Text.Length == 0)
            {
                RJMessageBox.Show("Vui lòng điền đầy đủ các thông tin phụ tùng!",
                    "Có lỗi xảy ra",
                    MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Error);
            }
        }

        private void ucKhoPhuTung_Load(object sender, EventArgs e)
        {

        }
    }
}
