using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormApp.Model;

namespace WinFormApp.DAO
{
    public class DAO_ChiTietHoaDonNhap : DatabaseConnection
    {
        SqlConnection _conn;
        private SqlCommand command;
        private SqlDataReader reader;
        public DAO_ChiTietHoaDonNhap()
        {
            _conn = new SqlConnection(_strConn);
        }
        public List<CTHDNHAP> GetList(string _soHoaDon)
        {
            List<CTHDNHAP> list = new List<CTHDNHAP>();
            _conn.Open();
            command = new SqlCommand($"SELECT SOLUONG, MASP FROM CTHDNHAP, SANPHAM WHERE CTHDNHAP.MASP = SANPHAM.MASP AND SOHDNHAP = {_soHoaDon}", _conn);
            reader = command.ExecuteReader();
            DAO_SanPham _sanPham = new DAO_SanPham();
            while (reader.Read())
            {
                int soLuong = reader.GetInt32(0);
                SanPham sp = _sanPham.GetByID(reader.GetString(1));
                CTHDNHAP cthd = new CTHDNHAP(soLuong, sp);
                list.Add(cthd);
            }
            _conn.Close();
            return list;
        }
        public void Add(CTHDNHAP CTHD, string _soHoaDon)
        {
            _conn.Open();
            command = new SqlCommand($"INSERT INTO CTHDNHAP (SOHDNHAP, SOLUONG, MASP) VALUES('{_soHoaDon}', {CTHD.soLuong}, '{CTHD.sanPham.maSanPham}'", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }
        public void Update(CTHDNHAP CTHD, string _soHoaDon)
        {
            _conn.Open();
            command = new SqlCommand($"UPDATE CTHDNHAP SET SOLUONG = {CTHD.soLuong} WHERE SOHDNHAP = '{_soHoaDon}' AND MASP = '{CTHD.sanPham.maSanPham}'", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }
        public void Delete(string _soHoaDon, string _maSanPham)
        {
            _conn.Open();
            command = new SqlCommand($"DELETE FROM CTHDNHAP WHERE SOHDNHAP = '{_soHoaDon}' AND MASP = '{_maSanPham}'", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }
    }
}
