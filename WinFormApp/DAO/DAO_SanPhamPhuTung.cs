using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormApp.Model;

namespace WinFormApp.DAO
{
    public class DAO_SanPhamPhuTung : DatabaseConnection
    {
        SqlConnection _conn;
        private SqlCommand command;
        private SqlDataReader reader;
        public DAO_SanPhamPhuTung()
        {
            _conn = new SqlConnection(_strConn);
        }
        public List<SanPhamPhuTung> GetAll()
        {
            List<SanPhamPhuTung> list = new List<SanPhamPhuTung>();
            _conn.Open();
            command = new SqlCommand($"SELECT PHUTUNG.MASP, MAPT, TENSP, SOLUONG, DONGIA, DVT, MOTA FROM PHUTUNG, SANPHAM WHERE PHUTUNG.MASP = SANPHAM.MASP", _conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string maSanPham = reader.GetString(0);
                string maPhuTung = reader.GetString(1);
                string tenSanPham = reader.GetString(2);
                int soLuong = reader.GetInt32(3);
                decimal donGia = reader.GetDecimal(2);
                string donViTinh = reader.GetString(5);
                string mota = reader.GetString(6);
                SanPhamPhuTung sanPhamPhuTung = new SanPhamPhuTung(maSanPham, tenSanPham, donGia, donViTinh, maPhuTung, mota, soLuong);
                list.Add(sanPhamPhuTung);
            }
            _conn.Close();
            return list;
        }
        public List<SanPhamPhuTung> GetList(string _maChiNhanh)
        {
            List<SanPhamPhuTung> list = new List<SanPhamPhuTung>();
            _conn.Open();
            command = new SqlCommand($"SELECT PHUTUNG.MASP, MAPT, TENSP, SOLUONG, DONGIA, DVT, MOTA FROM PHUTUNG, SANPHAM WHERE PHUTUNG.MASP = SANPHAM.MASP AND MACN = '{_maChiNhanh}'", _conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string maSanPham = reader.GetString(0);
                string maPhuTung = reader.GetString(1);
                string tenSanPham = reader.GetString(2);
                int soLuong = reader.GetInt32(3);
                decimal donGia = reader.GetDecimal(2);
                string donViTinh = reader.GetString(5);
                string mota = reader.GetString(6);
                SanPhamPhuTung sanPhamPhuTung = new SanPhamPhuTung(maSanPham, tenSanPham, donGia, donViTinh, maPhuTung, mota, soLuong);
                list.Add(sanPhamPhuTung);
            }
            _conn.Close();
            return list;
        }
        public SanPhamPhuTung GetLast()
        {
            SanPhamPhuTung sanPhamPhuTung = new SanPhamPhuTung();
            _conn.Open();
            command = new SqlCommand($"SELECT TOP(1) PHUTUNG.MASP, MAPT, TENSP, SOLUONG, DONGIA, DVT, MOTA FROM PHUTUNG, SANPHAM WHERE PHUTUNG.MASP = SANPHAM.MASP ORDER BY MAPT DESC", _conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string maSanPham = reader.GetString(0);
                string maPhuTung = reader.GetString(1);
                string tenSanPham = reader.GetString(2);
                int soLuong = reader.GetInt32(3);
                decimal donGia = reader.GetDecimal(2);
                string donViTinh = reader.GetString(5);
                string mota = reader.GetString(6);
                sanPhamPhuTung = new SanPhamPhuTung(maSanPham, tenSanPham, donGia, donViTinh, maPhuTung, mota, soLuong);
            }
            _conn.Close();
            return sanPhamPhuTung;
        }
        public SanPhamPhuTung GetByID(string _maSanPham)
        {
            SanPhamPhuTung sanPhamPhuTung = new SanPhamPhuTung();
            _conn.Open();
            command = new SqlCommand($"SELECT PHUTUNG.MASP, MAPT, TENSP, SOLUONG, DONGIA, DVT, MOTA FROM PHUTUNG, SANPHAM WHERE PHUTUNG.MASP = SANPHAM.MASP AND PHUTUNG.MASP = '{_maSanPham}'", _conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string maSanPham = reader.GetString(0);
                string maPhuTung = reader.GetString(1);
                string tenSanPham = reader.GetString(2);
                int soLuong = reader.GetInt32(3);
                decimal donGia = reader.GetDecimal(2);
                string donViTinh = reader.GetString(5);
                string mota = reader.GetString(6);
                sanPhamPhuTung = new SanPhamPhuTung(maSanPham, tenSanPham, donGia, donViTinh, maPhuTung, mota, soLuong);
            }
            _conn.Close();
            return sanPhamPhuTung;
        }
        public void Add(SanPhamPhuTung _phuTung, string _maChiNhanh)
        {
            _conn.Open();
            command = new SqlCommand($"INSERT INTO SANPHAM VALUES ('{_phuTung.maSanPham}', N'{_phuTung.tenSanPham}', {_phuTung.donGia}, '{_maChiNhanh}', N'{_phuTung.donViTinh}')", _conn);
            command.ExecuteNonQuery();
            command = new SqlCommand($"INSERT INTO PHUTUNG VALUES ('{_phuTung.maPhuTung}', N'{_phuTung.moTa}', '{_phuTung.maSanPham}', {_phuTung.soLuong})", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }
        public void Update(SanPhamPhuTung _phuTung)
        {
            _conn.Open();
            command = new SqlCommand($"UPDATE SANPHAM SET TENSP =  N'{_phuTung.tenSanPham}', DONGIA = {_phuTung.donGia}, DVT = N'{_phuTung.donViTinh}' WHERE MASP = '{_phuTung.maSanPham}'", _conn);
            command.ExecuteNonQuery();
            command = new SqlCommand($"UPDATE PHUTUNG SET MOTA = N'{_phuTung.moTa}', SOLUONG = {_phuTung.soLuong} WHERE MASP = '{_phuTung.maSanPham}'", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }
        public void Delete(string _maSanPham) {
            _conn.Open();
            command = new SqlCommand($"DELETE FROM PHUTUNG WHERE MASP = '{_maSanPham}'", _conn);
            command.ExecuteNonQuery();
            command = new SqlCommand($"DELETE FROM SANPHAM WHERE MASP = '{_maSanPham}'", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }
    }
}
