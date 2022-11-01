using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormApp.Model
{
    public class HoaDonXuat
    {
        public string SOHD { get; set; }
        public DateTime ngayLapHoaDon = new DateTime();
        public NhanVien nhanVien = new NhanVien();
        public KhachHang khachHang = new KhachHang();
        public List<CTHDXUAT> chiTietHoaDon = new List<CTHDXUAT>();
        public decimal tongHoaDon { get; set; }
        public HoaDonXuat()
        {

        }
        public HoaDonXuat(string sOHD, DateTime ngayLapHoaDon, NhanVien nhanVien, KhachHang khachHang)
        {
            SOHD = sOHD;
            this.ngayLapHoaDon = ngayLapHoaDon;
            this.nhanVien = nhanVien;
            this.khachHang = khachHang;
        }
        public HoaDonXuat(string sOHD, DateTime ngayLapHoaDon, NhanVien nhanVien, KhachHang khachHang, List<CTHDXUAT> chiTietHoaDon)
        {
            List<decimal> thanhTien = new List<decimal>();
            foreach(CTHDXUAT ct in chiTietHoaDon)
            {
                thanhTien.Add(ct.thanhtien);
            }
            SOHD = sOHD;
            this.ngayLapHoaDon = ngayLapHoaDon;
            this.nhanVien = nhanVien;
            this.khachHang = khachHang;
            this.chiTietHoaDon = chiTietHoaDon;
            this.tongHoaDon = sum(thanhTien);
        }
        public static decimal sum(List<decimal> thanhTien)
        {
            decimal tongtien = 0;
            foreach(decimal i in thanhTien)
            {
                tongtien = tongtien + i;
            }
            return tongtien;
        }
    }
}
