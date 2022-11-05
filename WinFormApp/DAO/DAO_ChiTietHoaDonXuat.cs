using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormApp.Model;

namespace WinFormApp.DAO
{
    public class DAO_ChiTietHoaDonXuat : DatabaseConnection
    {
        SqlConnection _conn;
        private SqlCommand command;
        private SqlDataReader reader;
        public DAO_ChiTietHoaDonXuat()
        {
            _conn = new SqlConnection(_strConn);
        }
        public List<CTHDXUAT> GetList(string _soHoaDon)
        {
            List<CTHDXUAT> list = new List<CTHDXUAT>();
            _conn.Open();
            command = new SqlCommand($"SELECT SOLUONG, SANPHAM.MASP FROM CTHDXUAT, SANPHAM WHERE CTHDXUAT.MASP = SANPHAM.MASP AND SOHDXUAT = '{_soHoaDon}'", _conn);
            reader = command.ExecuteReader();
            DAO_SanPham _sanPham = new DAO_SanPham();
            while (reader.Read())
            {
                int soLuong = reader.GetInt32(0);
                SanPham sp = _sanPham.GetByID(reader.GetString(1));
                CTHDXUAT cthd = new CTHDXUAT(soLuong, sp);
                list.Add(cthd);
            }
            _conn.Close();
            return list;
        }
        public void Add(CTHDXUAT CTHD, string _soHoaDon)
        {
            _conn.Open();
            command = new SqlCommand($"INSERT INTO CTHDXUAT (SOHDXUAT, SOLUONG, MASP) VALUES('{_soHoaDon}', {CTHD.sl}, '{CTHD.SP.maSanPham}'", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }
        public void Update(CTHDXUAT CTHD, string _soHoaDon)
        {
            _conn.Open();
            command = new SqlCommand($"UPDATE CTHDXUAT SET SOLUONG = {CTHD.sl} WHERE SOHDXUAT = '{_soHoaDon}' AND MASP = '{CTHD.SP.maSanPham}'", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }
        public void Delete(string _soHoaDon, string _maSanPham)
        {
            _conn.Open();
            command = new SqlCommand($"DELETE FROM CTHDXUAT WHERE SOHDXUAT = '{_soHoaDon}' AND MASP = '{_maSanPham}'", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }
    }
}
