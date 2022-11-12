using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WinFormApp.View;

namespace WinFormApp.Model
{
    public class HinhAnhXe
    {
        Functions Functions = new Functions();
        public string maSanPham { get; set; }
        public int maHinhAnh { get; set; }
        public string hinhAnh { get; set; }
        public HinhAnhXe()
        {

        }
        public HinhAnhXe(string maSanPham, int maHinhAnh, string hinhAnh)
        {
            this.maSanPham = maSanPham;
            this.maHinhAnh = maHinhAnh;
            this.hinhAnh = hinhAnh;
        }
    }
}
