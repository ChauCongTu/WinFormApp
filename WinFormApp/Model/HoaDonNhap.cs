using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormApp.Model
{
    public class HoaDonNhap
    {
        public string SOHD { get; set; }
        public DateTime ngayLapHoaDon = new DateTime();
        public NhanVien nhanVien = new NhanVien();
        public NhaCungCap nhaCungCap = new NhaCungCap();
        public List<CTHDNHAP> chiTietHoaDon = new List<CTHDNHAP>();
        public decimal tongHoaDon { get; set; }
        public HoaDonNhap()
        {

        }
        public HoaDonNhap(string sOHD, DateTime ngayLapHoaDon, NhanVien nhanVien, NhaCungCap nhaCungCap)
        {
            SOHD = sOHD;
            this.ngayLapHoaDon = ngayLapHoaDon;
            this.nhanVien = nhanVien;
            this.nhaCungCap = nhaCungCap;
        }
        public HoaDonNhap(string sOHD, DateTime ngayLapHoaDon, NhanVien nhanVien, NhaCungCap nhaCungCap, List<CTHDNHAP> chiTietHoaDon)
        {
            List<decimal> thanhtien = new List<decimal>();
            foreach(CTHDNHAP ct in chiTietHoaDon)
            {
                thanhtien.Add(ct.thanhTien);
            }
            SOHD = sOHD;
            this.ngayLapHoaDon = ngayLapHoaDon;
            this.nhanVien = nhanVien;
            this.nhaCungCap = nhaCungCap;
            this.chiTietHoaDon = chiTietHoaDon;
            this.tongHoaDon = sum(thanhtien);
        }

        public static decimal sum(List<decimal> thanhTien)
        {
            decimal tongtien = 0;
            foreach (decimal i in thanhTien)
            {
                tongtien = tongtien + i;
            }
            return tongtien;
        }

    }
}
