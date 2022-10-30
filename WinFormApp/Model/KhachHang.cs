using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormApp.Model
{
    public class KhachHang
    {
        public string maKhachHang { get; set; }
        public string tenKhachHang { get; set; }
        public string diaChi { get; set; }
        public string soDienThoai { get; set; }
        int chungMinhNhanDan { get; set; }

        public KhachHang()
        {

        }
        public KhachHang(string maKhachHang, string tenKhachHang, string diaChi, string soDienThoai, int chungMinhNhanDan)
        {
            this.maKhachHang = maKhachHang;
            this.tenKhachHang = tenKhachHang;
            this.diaChi = diaChi;
            this.soDienThoai = soDienThoai;
            this.chungMinhNhanDan = chungMinhNhanDan;
        }
    }
}
