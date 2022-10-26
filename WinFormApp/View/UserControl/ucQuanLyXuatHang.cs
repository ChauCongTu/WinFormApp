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
    public partial class ucQuanLyXuatHang : UserControl
    {
        CTHDXUAT cthd = new CTHDXUAT();
        public ucQuanLyXuatHang()
        {
            InitializeComponent();
        }
        public ucQuanLyXuatHang(CTHDXUAT ct)
        {
            InitializeComponent();
            cthd.SP = ct.SP;
            cthd.sl = ct.sl;
            cthd.thanhtien = ct.thanhtien;
        }
        private void ucQuanLyXuatHang_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
