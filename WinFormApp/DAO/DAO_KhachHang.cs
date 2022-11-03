using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormApp.Model;

namespace WinFormApp.DAO
{
    public class DAO_KhachHang : DatabaseConnection
    {
        SqlConnection _conn;
        private SqlCommand command;
        private SqlDataReader reader;
        public DAO_KhachHang()
        {
            _conn = new SqlConnection(_strConn);
        }
        public List<KhachHang> GetAll()
        {
            List<KhachHang> list = new List<KhachHang>();
            _conn.Open();
            command = new SqlCommand($"SELECT * FROM KHACHHANG", _conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string maKhachHang = reader.GetString(0);
                string tenKhachHang = reader.GetString(1);
                string diaChi = reader.GetString(2);
                string soDienThoai = reader.GetString(3);
                int chungMinhNhanDan = reader.GetInt32(4);
                KhachHang khachHang = new KhachHang(maKhachHang, tenKhachHang, diaChi, soDienThoai, chungMinhNhanDan);
                list.Add(khachHang);
            }
            _conn.Close();
            return list;
        }
        public KhachHang GetByID(string _maKhachHang)
        {
            KhachHang khachHang = new KhachHang();
            _conn.Open();
            command = new SqlCommand($"SELECT * FROM KHACHHANG WHERE MAKH = '{_maKhachHang}'", _conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string maKhachHang = reader.GetString(0);
                string tenKhachHang = reader.GetString(1);
                string diaChi = reader.GetString(2);
                string soDienThoai = reader.GetString(3);
                int chungMinhNhanDan = reader.GetInt32(4);
                khachHang = new KhachHang(maKhachHang, tenKhachHang, diaChi, soDienThoai, chungMinhNhanDan);
            }
            _conn.Close();
            return khachHang;
        }
        public List<KhachHang> GetByName(string _tenKhachHang)
        {
            List<KhachHang> list = new List<KhachHang>();
            _conn.Open();
            command = new SqlCommand($"SELECT * FROM KHACHHANG WHERE TENKH LIKE '%{_tenKhachHang}%'", _conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string maKhachHang = reader.GetString(0);
                string tenKhachHang = reader.GetString(1);
                string diaChi = reader.GetString(2);
                string soDienThoai = reader.GetString(3);
                int chungMinhNhanDan = reader.GetInt32(4);
                KhachHang khachHang = new KhachHang(maKhachHang, tenKhachHang, diaChi, soDienThoai, chungMinhNhanDan);
                list.Add(khachHang);
            }
            _conn.Close();
            return list;
        }
        public void Add(KhachHang khachHang)
        {
            _conn.Open();
            command = new SqlCommand($"INSERT INTO KHACHHANG VALUES ('{khachHang.maKhachHang}', N'{khachHang.tenKhachHang}', N'{khachHang.diaChi}', '{khachHang.soDienThoai}', {khachHang.chungMinhNhanDan})", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }
        public void Update(KhachHang khachHang)
        {
            _conn.Open();
            command = new SqlCommand($"UPDATE KHACHHANG SET TENKH = N'{khachHang.tenKhachHang}', DIACHI = N'{khachHang.diaChi}', SDT = '{khachHang.soDienThoai}', CMND = {khachHang.chungMinhNhanDan} WHERE MAKH = '{khachHang.maKhachHang}'", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }
        public void Delete(string _maKhachHang)
        {
            _conn.Open();
            command = new SqlCommand($"DELETE FROM KHACHHANG WHERE MAKH = '{_maKhachHang}'", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }
    }
}
