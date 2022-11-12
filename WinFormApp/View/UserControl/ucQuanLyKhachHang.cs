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

namespace WinFormApp.CustomControl
{
    public partial class ucQuanLyKhachHang : UserControl
    {
        public ucQuanLyKhachHang()
        {
            InitializeComponent();
        }
        void table_load()
        {
            dgvKhachHang.Rows.Clear();
            int i = 1;
            DAO_KhachHang dAO_KhachHang = new DAO_KhachHang();

            List<KhachHang> khachHang = dAO_KhachHang.GetAll();
            foreach (KhachHang kh in khachHang)
            {
                dgvKhachHang.Rows.Add(i, kh.maKhachHang, kh.tenKhachHang, kh.soDienThoai, kh.diaChi, kh.chungMinhNhanDan);
                i++;
            }
        }
        private void ucQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            table_load();
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtSdtKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
