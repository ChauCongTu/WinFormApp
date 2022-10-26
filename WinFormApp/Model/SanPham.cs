using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormApp.Model
{
    public class SanPham
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public float donGia { get; set; }
        public string DVT { get; set; }
        public SanPham()
        {

        }
        public SanPham(string MaSP, string TenSP, float donGia, string DVT)
        {
            this.MaSP = MaSP;
            this.TenSP = TenSP;
            this.donGia = donGia;
            this.DVT = DVT;
        }
    }
}
