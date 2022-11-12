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
    public partial class ucKhoPhuTung : UserControl
    {
        public ucKhoPhuTung()
        {
            InitializeComponent();
        }
        void table_load()
        {
            dgvPhuTung.Rows.Clear();
            int i = 1;
            DAO_SanPhamPhuTung dAO_PhuTung = new DAO_SanPhamPhuTung();

            List<SanPhamPhuTung> PhuTung = dAO_PhuTung.GetAll();
            foreach (SanPhamPhuTung pt in PhuTung)
            {
                dgvPhuTung.Rows.Add(i, pt.maPhuTung, pt.tenSanPham, pt.soLuong, pt.moTa);
                i++;
            }
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

        private void ucKhoPhuTung_Load(object sender, EventArgs e)
        {
            table_load();
            DAO_ChiNhanh dAO_ChiNhanh = new DAO_ChiNhanh();
            cbChiNhanh.DataSource = dAO_ChiNhanh.getAll();
            cbChiNhanh.ValueMember = "maChiNhanh";
            cbChiNhanh.DisplayMember = "tenChiNhanh";
        }

        private void cbChiNhanh_SelectedValueChanged(object sender, EventArgs e)
        {
            dgvPhuTung.Rows.Clear();
            int i = 1;
            DAO_SanPhamPhuTung dAO_PhuTung = new DAO_SanPhamPhuTung();

            List<SanPhamPhuTung> PhuTung = dAO_PhuTung.GetList(cbChiNhanh.SelectedValue.ToString());
            foreach (SanPhamPhuTung pt in PhuTung)
            {
                dgvPhuTung.Rows.Add(i, pt.maPhuTung, pt.tenSanPham, pt.soLuong, pt.moTa);
                i++;
            }
        }
    }
}
