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
        public float tongHoaDon { get; set; }
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
            List<float> thanhtien = new List<float>();
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

        public static float sum(List<float> thanhTien)
        {
            float tongtien = 0;
            foreach (float i in thanhTien)
            {
                tongtien = tongtien + i;
            }
            return tongtien;
        }

    }
}
