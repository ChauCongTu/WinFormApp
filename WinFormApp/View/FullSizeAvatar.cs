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

namespace WinFormApp.View
{
    public partial class FullSizeAvatar : Form
    {
        Functions functions = new Functions();
        NhanVien NhanVien = new NhanVien();
        public FullSizeAvatar(NhanVien nhanVien)
        {
            InitializeComponent();
            this.NhanVien = nhanVien;
            if (nhanVien.anhDaiDien == "0")
            {
                pbAnhDaiDien.Image = Properties.Resources.avatar;
            }
            else
            {
                pbAnhDaiDien.Image = functions.ConvertByteToImg(nhanVien.anhDaiDien);
            }
            this.Text = "Ảnh đại diện " +nhanVien.tenNhanVien;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void FullSizeAvatar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
