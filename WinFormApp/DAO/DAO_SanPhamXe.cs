using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using WinFormApp.Model;

namespace WinFormApp.DAO
{
    public class DAO_SanPhamXe : DatabaseConnection
    {
        SqlConnection _conn;
        private SqlCommand command;
        private SqlDataReader reader;
        public DAO_SanPhamXe()
        {
            _conn = new SqlConnection(_strConn);
        }
        public List<SanPhamXe> GetAll()
        {
            List<SanPhamXe> list = new List<SanPhamXe>();
            _conn.Open();
            command = new SqlCommand($"EXEC sp_getAllVehicle", _conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string masp = reader.GetString(0);
                string tensp = reader.GetString(1);
                decimal donGia = reader.GetDecimal(2);
                string dvt = reader.GetString(3);
                string maXe = reader.GetString(4);
                string soKhungXe = reader.GetString(5);
                float khoiLuong = reader.GetFloat(6);
                float dungTichBinhXang = reader.GetFloat(7);
                float dungTichXiLanh = reader.GetFloat(8);
                string loaiDongCo = reader.GetString(9);
                string hanhTrinhPittong = reader.GetString(10);
                string tySoNen = reader.GetString(11);
                string congSuatToiDa = reader.GetString(12);
                string dungTichNhot = reader.GetString(13);
                string loaiTruyenDong = reader.GetString(14);
                string heThongKhoiDong = reader.GetString(15);
                SanPhamXe sanPham = new SanPhamXe(masp, tensp, donGia, dvt, maXe, soKhungXe, khoiLuong, dungTichBinhXang, dungTichXiLanh, loaiDongCo, hanhTrinhPittong, tySoNen, congSuatToiDa, dungTichNhot, loaiTruyenDong, heThongKhoiDong);
                list.Add(sanPham);
            }
            _conn.Close();
            return list;
        }
        public List<SanPhamXe> GetList(string _maChiNhanh)
        {
            List<SanPhamXe> list = new List<SanPhamXe>();
            _conn.Open();
            command = new SqlCommand($"SELECT SANPHAM.MASP, TENSP, DONGIA, DVT, MAXE, SOKHUNG, KHOILUONG, DUNGTICHBX, DUNGTICHXL, LOAIDC, PITTONG, TYSONEN, CONGSUATMAX, DUNGTICHNHOT, TRUYENDONG, HTKHOIDONG  FROM XE, SANPHAM WHERE XE.MASP = SANPHAM.MASP AND MACN = '{_maChiNhanh}' AND DABAN != 1", _conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string masp = reader.GetString(0);
                string tensp = reader.GetString(1);
                decimal donGia = reader.GetDecimal(2);
                string dvt = reader.GetString(3);
                string maXe = reader.GetString(4);
                string soKhungXe = reader.GetString(5);
                float khoiLuong = reader.GetFloat(6);
                float dungTichBinhXang = reader.GetFloat(7);
                float dungTichXiLanh = reader.GetFloat(8);
                string loaiDongCo = reader.GetString(9);
                string hanhTrinhPittong = reader.GetString(10);
                string tySoNen = reader.GetString(11);
                string congSuatToiDa = reader.GetString(12);
                string dungTichNhot = reader.GetString(13);
                string loaiTruyenDong = reader.GetString(14);
                string heThongKhoiDong = reader.GetString(15);
                SanPhamXe sanPham = new SanPhamXe(masp, tensp, donGia, dvt, maXe, soKhungXe, khoiLuong, dungTichBinhXang, dungTichXiLanh, loaiDongCo, hanhTrinhPittong, tySoNen, congSuatToiDa, dungTichNhot, loaiTruyenDong, heThongKhoiDong);
                list.Add(sanPham);
            }
            _conn.Close();
            return list;
        }
        public List<SanPhamXe> GetListByName(string _tenXe)
        {
            List<SanPhamXe> list = new List<SanPhamXe>();
            _conn.Open();
            command = new SqlCommand($"SELECT SANPHAM.MASP, TENSP, DONGIA, DVT, MAXE, SOKHUNG, KHOILUONG, DUNGTICHBX, DUNGTICHXL, LOAIDC, PITTONG, TYSONEN, CONGSUATMAX, DUNGTICHNHOT, TRUYENDONG, HTKHOIDONG  FROM XE, SANPHAM WHERE XE.MASP = SANPHAM.MASP AND DABAN != 1 AND TENSP LIKE '%{_tenXe}%'", _conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string masp = reader.GetString(0);
                string tensp = reader.GetString(1);
                decimal donGia = reader.GetDecimal(2);
                string dvt = reader.GetString(3);
                string maXe = reader.GetString(4);
                string soKhungXe = reader.GetString(5);
                float khoiLuong = reader.GetFloat(6);
                float dungTichBinhXang = reader.GetFloat(7);
                float dungTichXiLanh = reader.GetFloat(8);
                string loaiDongCo = reader.GetString(9);
                string hanhTrinhPittong = reader.GetString(10);
                string tySoNen = reader.GetString(11);
                string congSuatToiDa = reader.GetString(12);
                string dungTichNhot = reader.GetString(13);
                string loaiTruyenDong = reader.GetString(14);
                string heThongKhoiDong = reader.GetString(15);
                SanPhamXe sanPham = new SanPhamXe(masp, tensp, donGia, dvt, maXe, soKhungXe, khoiLuong, dungTichBinhXang, dungTichXiLanh, loaiDongCo, hanhTrinhPittong, tySoNen, congSuatToiDa, dungTichNhot, loaiTruyenDong, heThongKhoiDong);
                list.Add(sanPham);
            }
            _conn.Close();
            return list;
        }
        public SanPhamXe GetByID(string _maSanPham)
        {
            SanPhamXe sanPham = new SanPhamXe();
            _conn.Open();
            command = new SqlCommand($"SELECT SANPHAM.MASP, TENSP, DONGIA, DVT, MAXE, SOKHUNG, KHOILUONG, DUNGTICHBX, DUNGTICHXL, LOAIDC, PITTONG, TYSONEN, CONGSUATMAX, DUNGTICHNHOT, TRUYENDONG, HTKHOIDONG  FROM XE, SANPHAM WHERE XE.MASP = SANPHAM.MASP AND DABAN != 1 AND XE.MASP = '{_maSanPham}'", _conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string masp = reader.GetString(0);
                string tensp = reader.GetString(1);
                decimal donGia = reader.GetDecimal(2);
                string dvt = reader.GetString(3);
                string maXe = reader.GetString(4);
                string soKhungXe = reader.GetString(5);
                float khoiLuong = reader.GetFloat(6);
                float dungTichBinhXang = reader.GetFloat(7);
                float dungTichXiLanh = reader.GetFloat(8);
                string loaiDongCo = reader.GetString(9);
                string hanhTrinhPittong = reader.GetString(10);
                string tySoNen = reader.GetString(11);
                string congSuatToiDa = reader.GetString(12);
                string dungTichNhot = reader.GetString(13);
                string loaiTruyenDong = reader.GetString(14);
                string heThongKhoiDong = reader.GetString(15);
                sanPham = new SanPhamXe(masp, tensp, donGia, dvt, maXe, soKhungXe, khoiLuong, dungTichBinhXang, dungTichXiLanh, loaiDongCo, hanhTrinhPittong, tySoNen, congSuatToiDa, dungTichNhot, loaiTruyenDong, heThongKhoiDong);
            }
            _conn.Close();
            return sanPham;
        }
        public SanPhamXe GetSPLast()
        {
            SanPhamXe sanPham = new SanPhamXe();
            _conn.Open();
            command = new SqlCommand($"SELECT TOP(1) SANPHAM.MASP, TENSP, DONGIA, DVT, MAXE, SOKHUNG, KHOILUONG, DUNGTICHBX, DUNGTICHXL, LOAIDC, PITTONG, TYSONEN, CONGSUATMAX, DUNGTICHNHOT, TRUYENDONG, HTKHOIDONG  FROM XE, SANPHAM WHERE XE.MASP = SANPHAM.MASP ORDER BY XE.MASP DESC", _conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string masp = reader.GetString(0);
                string tensp = reader.GetString(1);
                decimal donGia = reader.GetDecimal(2);
                string dvt = reader.GetString(3);
                string maXe = reader.GetString(4);
                string soKhungXe = reader.GetString(5);
                float khoiLuong = reader.GetFloat(6);
                float dungTichBinhXang = reader.GetFloat(7);
                float dungTichXiLanh = reader.GetFloat(8);
                string loaiDongCo = reader.GetString(9);
                string hanhTrinhPittong = reader.GetString(10);
                string tySoNen = reader.GetString(11);
                string congSuatToiDa = reader.GetString(12);
                string dungTichNhot = reader.GetString(13);
                string loaiTruyenDong = reader.GetString(14);
                string heThongKhoiDong = reader.GetString(15);
                sanPham = new SanPhamXe(masp, tensp, donGia, dvt, maXe, soKhungXe, khoiLuong, dungTichBinhXang, dungTichXiLanh, loaiDongCo, hanhTrinhPittong, tySoNen, congSuatToiDa, dungTichNhot, loaiTruyenDong, heThongKhoiDong);
            }
            _conn.Close();
            return sanPham;
        }
        public SanPhamXe GetXeLast()
        {
            SanPhamXe sanPham = new SanPhamXe();
            _conn.Open();
            command = new SqlCommand($"SELECT TOP(1) SANPHAM.MASP, TENSP, DONGIA, DVT, MAXE, SOKHUNG, KHOILUONG, DUNGTICHBX, DUNGTICHXL, LOAIDC, PITTONG, TYSONEN, CONGSUATMAX, DUNGTICHNHOT, TRUYENDONG, HTKHOIDONG  FROM XE, SANPHAM WHERE XE.MASP = SANPHAM.MASP ORDER BY MAXE DESC", _conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string masp = reader.GetString(0);
                string tensp = reader.GetString(1);
                decimal donGia = reader.GetDecimal(2);
                string dvt = reader.GetString(3);
                string maXe = reader.GetString(4);
                string soKhungXe = reader.GetString(5);
                float khoiLuong = reader.GetFloat(6);
                float dungTichBinhXang = reader.GetFloat(7);
                float dungTichXiLanh = reader.GetFloat(8);
                string loaiDongCo = reader.GetString(9);
                string hanhTrinhPittong = reader.GetString(10);
                string tySoNen = reader.GetString(11);
                string congSuatToiDa = reader.GetString(12);
                string dungTichNhot = reader.GetString(13);
                string loaiTruyenDong = reader.GetString(14);
                string heThongKhoiDong = reader.GetString(15);
                sanPham = new SanPhamXe(masp, tensp, donGia, dvt, maXe, soKhungXe, khoiLuong, dungTichBinhXang, dungTichXiLanh, loaiDongCo, hanhTrinhPittong, tySoNen, congSuatToiDa, dungTichNhot, loaiTruyenDong, heThongKhoiDong);
            }
            _conn.Close();
            return sanPham;
        }
        public string GetLoaiXe(string masp)
        {
            string loaiXe = "Mã sản phẩm không xác định!";
            _conn.Open();
            command = new SqlCommand($"SELECT TENLOAI FROM LOAIXE, XE WHERE LOAIXE.MALOAI = XE.MALOAI AND MASP = '{masp}'", _conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                loaiXe = reader.GetString(0);
            }
            _conn.Close();
            return loaiXe;
        }
        public Boolean CheckSoKhung(string _soKhung)
        {
            List<string> soKhung = new List<string>();
            _conn.Open();
            command = new SqlCommand($"SELECT SOKHUNG FROM XE", _conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                soKhung.Add(reader.GetString(0));
            }
            _conn.Close();
            if (soKhung.Contains(_soKhung) == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Add(SanPhamXe _xe, string _maLoaiXe, string _maChiNhanh)
        {
            _conn.Open();
            command = new SqlCommand($@"INSERT INTO SANPHAM VALUES('{_xe.maSanPham}', N'{_xe.tenSanPham}', {_xe.donGia}, '{_maChiNhanh}', N'{_xe.donViTinh}');", _conn);
            command.ExecuteNonQuery();
            command = new SqlCommand($"INSERT INTO XE VALUES('{_xe.maXe}', '{_xe.soKhungXe}', {_xe.khoiLuong}, {_xe.dungTichBinhXang}, N'{_xe.loaiDongCo}', {_xe.dungTichXiLanh}, N'{_xe.hanhTrinhPittong}', '{_xe.tySoNen}', N'{_xe.congSuatToiDa}', N'{_xe.dungTichNhot}', N'{_xe.loaiTruyenDong}', N'{_xe.heThongKhoiDong}', '{_xe.maSanPham}', '{_maLoaiXe}', 0);", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }
        public void Update(SanPhamXe _xe, string _maLoaiXe)
        {
            _conn.Open();
            command = new SqlCommand($"UPDATE SANPHAM SET TENSP =  N'{_xe.tenSanPham}', DONGIA = {_xe.donGia}, DVT = N'{_xe.donViTinh}' WHERE MASP = '{_xe.maSanPham}'", _conn);
            command.ExecuteNonQuery();
            command = new SqlCommand($@"UPDATE XE
                                        SET SOKHUNG = '{_xe.soKhungXe}',
                                            KHOILUONG = {_xe.khoiLuong},
                                            DUNGTICHBX = {_xe.dungTichBinhXang},
                                            LOAIDC = N'{_xe.loaiDongCo}',
                                            DUNGTICHXL = {_xe.dungTichXiLanh},
                                            PITTONG = N'{_xe.hanhTrinhPittong}',
                                            TYSONEN = N'{_xe.tySoNen}',
                                            CONGSUATMAX = N'{_xe.congSuatToiDa}',
                                            DUNGTICHNHOT = N'{_xe.dungTichNhot}',
                                            TRUYENDONG = N'{_xe.loaiDongCo}',
                                            HTKHOIDONG = N'{_xe.heThongKhoiDong}',
                                            MALOAI = '{_maLoaiXe}'
                                        WHERE MAXE = '{_xe.maXe}'", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }
        public void Delete(string _maSanPham)
        {
            _conn.Open();
            command = new SqlCommand($"DELETE FROM XE WHERE MASP = '{_maSanPham}'", _conn);
            command.ExecuteNonQuery();
            command = new SqlCommand($"DELETE FROM SANPHAM WHERE MASP = '{_maSanPham}'", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }
    }
}
