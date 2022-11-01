using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormApp.Model
{
    public class SanPhamPhuTung:SanPham
    {
        public string maPhuTung { get; set; }
        public string moTa { get; set; }
        public int soLuong { get; set; }
        public SanPhamPhuTung()
        {

        }
        public SanPhamPhuTung(string masp, string tensp, decimal dongia, string dvt, string maPhuTung, string moTa, int soLuong) : base( masp,  tensp,  dongia,  dvt)
        {
            this.maPhuTung = maPhuTung;
            this.moTa = moTa;
            this.soLuong = soLuong;
        }
    }
}
