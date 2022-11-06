using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormApp.Model
{
    public class dsHoaDon
    {
        public string maSanPham { get; set; }
        public string tenSanPham { set; get; }
        public int soLuong { get; set; }
        public decimal donGia { get; set; }
        public decimal thanhTien { get; set; }
        public dsHoaDon()
        {

        }
        public dsHoaDon(string maSanPham, string tenSanPham, int soLuong, decimal donGia, decimal thanhTien)
        {
            this.maSanPham = maSanPham;
            this.tenSanPham = tenSanPham;
            this.soLuong = soLuong;
            this.donGia = donGia;
            this.thanhTien = thanhTien;
        }
    }
}
