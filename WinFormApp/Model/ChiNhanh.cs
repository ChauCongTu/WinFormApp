using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormApp.Model
{
    public class ChiNhanh
    {
        public string maChiNhanh { get; set; }
        public string tenChiNhanh { get; set; }
        public string diaChi { get; set; }
        public string soDienThoai { get; set; }
        public List<NhanVien> nhanVien { get; set; }
        public List<SanPham> sanPham { get; set; }

        public ChiNhanh()
        {

        }
        public ChiNhanh(string maChiNhanh, string tenChiNhanh, string diaChi, string soDienThoai, List<NhanVien> nhanVien, List<SanPham> sanPham)
        {
            this.maChiNhanh = maChiNhanh;
            this.tenChiNhanh = tenChiNhanh;
            this.diaChi = diaChi;
            this.soDienThoai = soDienThoai;
            this.nhanVien = nhanVien;
            this.sanPham = sanPham;
        }
    }
}
