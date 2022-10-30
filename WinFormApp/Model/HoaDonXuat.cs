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
        public float tongHoaDon { get; set; }
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
            List<float> thanhTien = new List<float>();
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
        public static float sum(List<float> thanhTien)
        {
            float tongtien = 0;
            foreach(float i in thanhTien)
            {
                tongtien = tongtien + i;
            }
            return tongtien;
        }
    }
}
