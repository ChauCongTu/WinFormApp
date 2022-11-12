using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormApp.CustomControl;
using WinFormApp.DAO;
using WinFormApp.Model;

namespace WinFormApp.View
{
    public partial class ChiTietXe : Form
    {
        SanPhamXe sanPhamXe = new SanPhamXe();
        DAO_SanPhamXe dAO_SanPhamXe = new DAO_SanPhamXe();
        Functions functions = new Functions();
        string machinhanh;
        int thaoTac;
        public ChiTietXe()
        {
            InitializeComponent();
        }
        public ChiTietXe(SanPhamXe sanPhamXe, int thaotac, string machinhanh)
        {
            InitializeComponent();
            this.sanPhamXe = sanPhamXe;
            this.thaoTac = thaotac;
            this.machinhanh = machinhanh;
        }

        private void thôngSốKỹThuậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucChiTietXe ucChiTietXe = new ucChiTietXe(sanPhamXe, thaoTac, machinhanh);
            pnChiTiet.Controls.Clear();
            pnChiTiet.Controls.Add(ucChiTietXe);
        }

        private void hìnhẢnhSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucHinhAnhXe hinhAnhXe = new ucHinhAnhXe(sanPhamXe, thaoTac, machinhanh);
            pnChiTiet.Controls.Clear();
            pnChiTiet.Controls.Add(hinhAnhXe);
        }

        private void ChiTietXe_Load(object sender, EventArgs e)
        {
            this.Text = "Thông tin phương tiện: " + "[" + sanPhamXe.maXe + "] "+ sanPhamXe.tenSanPham;
            ucChiTietXe ucChiTietXe = new ucChiTietXe(sanPhamXe, thaoTac, machinhanh);
            pnChiTiet.Controls.Clear();
            pnChiTiet.Controls.Add(ucChiTietXe);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
