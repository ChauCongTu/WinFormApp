using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormApp.Model
{
    public class SanPham
    {
        public string maSanPham { get; set; }
        public string tenSanPham { get; set; }
        public decimal donGia { get; set; }
        public string donViTinh { get; set; }
        public SanPham()
        {

        }
        public SanPham(string masp, string tensp, decimal dongia, string dvt)
        {
            this.maSanPham = masp;
            this.tenSanPham = tensp;
            this.donGia = dongia;
            this.donViTinh = dvt;
        }
    }
}
