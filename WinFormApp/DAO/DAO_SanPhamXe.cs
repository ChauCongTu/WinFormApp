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
                float dongia = reader.GetFloat(2);
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
                SanPhamXe sanPham = new SanPhamXe(masp, tensp, dongia, dvt, maXe, soKhungXe, khoiLuong, dungTichBinhXang, dungTichXiLanh, loaiDongCo, hanhTrinhPittong, tySoNen, congSuatToiDa, dungTichNhot, loaiTruyenDong, heThongKhoiDong);
                list.Add(sanPham);
            }
            _conn.Close();
            return list;
        }
        public List<SanPhamXe> GetList(string _maChiNhanh)
        {
            List<SanPhamXe> list = new List<SanPhamXe>();
            _conn.Open();
            command = new SqlCommand($"EXEC sp_getListVehicle {_maChiNhanh}", _conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string masp = reader.GetString(0);
                string tensp = reader.GetString(1);
                float dongia = reader.GetFloat(2);
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
                SanPhamXe sanPham = new SanPhamXe(masp, tensp, dongia, dvt, maXe, soKhungXe, khoiLuong, dungTichBinhXang, dungTichXiLanh, loaiDongCo, hanhTrinhPittong, tySoNen, congSuatToiDa, dungTichNhot, loaiTruyenDong, heThongKhoiDong);
                list.Add(sanPham);
            }
            _conn.Close();
            return list;
        }
        public List<SanPhamXe> GetListByName(string _tenXe)
        {
            List<SanPhamXe> list = new List<SanPhamXe>();
            _conn.Open();
            command = new SqlCommand($"SELECT SANPHAM.MASP, TENSP, DONGIA, DVT, MAXE, SOKHUNG, KHOILUONG, DUNGTICHBX, DUNGTICHXL, LOAIDC, PITTONG, TYSONEN, CONGSUATMAX, DUNGTICHNHOT, TRUYENDONG, HTKHOIDONG  FROM XE, SANPHAM WHERE XE.MASP = SANPHAM.MASP AND MACN = @macn AND DABAN != 1 AND TENSP LIKE '%{_tenXe}%'", _conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string masp = reader.GetString(0);
                string tensp = reader.GetString(1);
                float dongia = reader.GetFloat(2);
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
                SanPhamXe sanPham = new SanPhamXe(masp, tensp, dongia, dvt, maXe, soKhungXe, khoiLuong, dungTichBinhXang, dungTichXiLanh, loaiDongCo, hanhTrinhPittong, tySoNen, congSuatToiDa, dungTichNhot, loaiTruyenDong, heThongKhoiDong);
                list.Add(sanPham);
            }
            _conn.Close();
            return list;
        }
        public SanPhamXe GetByID(string _maSanPham)
        {
            SanPhamXe sanPham = new SanPhamXe();
            _conn.Open();
            command = new SqlCommand($"EXEC sp_getVehicle {_maSanPham}", _conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string masp = reader.GetString(0);
                string tensp = reader.GetString(1);
                float dongia = reader.GetFloat(2);
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
                sanPham = new SanPhamXe(masp, tensp, dongia, dvt, maXe, soKhungXe, khoiLuong, dungTichBinhXang, dungTichXiLanh, loaiDongCo, hanhTrinhPittong, tySoNen, congSuatToiDa, dungTichNhot, loaiTruyenDong, heThongKhoiDong);
            }
            _conn.Close();
            return sanPham;
        }
        /*
         DECLARE @MASP nvarchar(20)
        DECLARE @TENSP nvarchar(50)
        DECLARE @DONGIA money
        DECLARE @MACN nvarchar(20)
        DECLARE @DVT nvarchar(10)
        DECLARE @MAXE nvarchar(20)
        DECLARE @SOKHUNG nvarchar(17)
        DECLARE @KHOILUONG float
        DECLARE @DUNGTICHBX float
        DECLARE @LOAIDC nvarchar(100)
        DECLARE @DUNGTICHXL float
        DECLARE @PITTONG nvarchar(100)
        DECLARE @TYSONEN char(20)
        DECLARE @CONGSUATMAX nvarchar(100)
        DECLARE @DUNGTICHNHOT nvarchar(100)
        DECLARE @TRUYENDONG nvarchar(100)
        DECLARE @HTKHOIDONG nvarchar(100)
        DECLARE @MALOAI nvarchar(20)
         */
        public void Add(SanPhamXe _xe, string _maLoaiXe, string _maChiNhanh)
        {
            _conn.Open();
            command = new SqlCommand($@"EXEC sp_themXe '{_xe.maSanPham}', 
                                                       N'{_xe.tenSanPham}', 
                                                         {_xe.donGia},
                                                        '{_maChiNhanh}',
                                                       N'{_xe.donViTinh}',
                                                        '{_xe.maXe}',
                                                        '{_xe.soKhungXe}',
                                                         {_xe.khoiLuong},
                                                         {_xe.dungTichBinhXang},
                                                       N'{_xe.loaiDongCo}',
                                                         {_xe.dungTichXiLanh},
                                                       N'{_xe.hanhTrinhPittong}',
                                                       N'{_xe.tySoNen}',
                                                       N'{_xe.congSuatToiDa}',
                                                       N'{_xe.dungTichNhot}',
                                                       N'{_xe.loaiTruyenDong}',
                                                       N'{_xe.heThongKhoiDong}',
                                                        '{_maLoaiXe}'", _conn);
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
                                            PITTONG = N'{_xe.hanhTrinhPittong}', ,
                                            TYSONEN = N'{_xe.tySoNen}', ,
                                            CONGSUATMAX = N'{_xe.congSuatToiDa}', ,
                                            DUNGTICHNHOT = N'{_xe.dungTichNhot}', ,
                                            TRUYENDONG = N'{_xe.loaiDongCo}', ,
                                            HTKHOIDONG = N'{_xe.heThongKhoiDong}', ,
                                            MALOAI = '{_maLoaiXe}', ,
                                        WHERE MAXE = '{_xe.maXe}'");
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
