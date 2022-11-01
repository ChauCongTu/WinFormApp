using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormApp.Model
{
    public class CTHDNHAP
    {
        public int soLuong { get; set; }
        public SanPham sanPham { get; set; }
        public decimal thanhTien { get; set; }

        public CTHDNHAP()
        {

        }
        public CTHDNHAP(int soLuong, SanPham sanPham)
        {
            this.soLuong = soLuong;
            this.sanPham = sanPham;
            this.thanhTien = Convert.ToDecimal(soLuong) * sanPham.donGia;
        }
    }
}
