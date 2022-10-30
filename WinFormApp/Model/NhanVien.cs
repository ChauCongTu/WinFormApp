using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormApp.Model
{
    public class NhanVien
    {
        public string maNhanVien { get; set; }
        public string tenNhanVien { set; get; }
        public string tenDangNhap { set; get; }
        public string matKhau { set; get; }
        public DateTime ngaySinh = new DateTime();
        public int chungMinhNhanDan { set; get; }
        public string diaChi { set; get; }
        public int capbac { set; get; }
        public string soDienThoai { set; get; }
        public NhanVien()
        {

        }
        public NhanVien(string maNhanVien, string tenNhanVien, string tenDangNhap, string matKhau, DateTime ngaySinh, int chungMinhNhanDan, string diaChi, int capbac, string soDienThoai)
        {
            this.maNhanVien = maNhanVien;
            this.tenNhanVien = tenNhanVien;
            this.tenDangNhap = tenDangNhap;
            this.matKhau = matKhau;
            this.ngaySinh = ngaySinh;
            this.chungMinhNhanDan = chungMinhNhanDan;
            this.diaChi = diaChi;
            this.capbac = capbac;
            this.soDienThoai = soDienThoai;
        }
    }
}
