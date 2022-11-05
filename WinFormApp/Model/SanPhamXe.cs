using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormApp.Model
{
    public class SanPhamXe : SanPham
    {
        public string maXe { get; set; }
        public string soKhungXe { get; set; }
        public float khoiLuong { get; set; }
        public float dungTichBinhXang { get; set; }
        public float dungTichXiLanh { get; set; }   
        public string loaiDongCo { get; set; }
        public string hanhTrinhPittong { get; set; }
        public string tySoNen { get; set; }
        public string congSuatToiDa { get; set; }
        public string dungTichNhot { get; set; }
        public string loaiTruyenDong { get; set; }
        public string heThongKhoiDong { get; set; }
        public SanPhamXe()
        {

        }
        public SanPhamXe(string masp, string tensp, decimal dongia, string dvt, string maXe, string soKhungXe, float khoiLuong, float dungTichBinhXang, float dungTichXiLanh, string loaiDongCo, string hanhTrinhPittong, string tySoNen, string congSuatToiDa, string dungTichNhot, string loaiTruyenDong, string heThongKhoiDong) : base( masp,  tensp,  dongia,  dvt)
        {
            this.maXe = maXe;
            this.soKhungXe = soKhungXe;
            this.khoiLuong = khoiLuong;
            this.dungTichBinhXang = dungTichBinhXang;
            this.dungTichXiLanh = dungTichXiLanh;
            this.loaiDongCo = loaiDongCo;
            this.hanhTrinhPittong = hanhTrinhPittong;
            this.tySoNen = tySoNen;
            this.congSuatToiDa = congSuatToiDa;
            this.dungTichNhot = dungTichNhot;
            this.loaiTruyenDong = loaiTruyenDong;
            this.heThongKhoiDong = heThongKhoiDong;
        }
    }
}
