using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormApp.Model;

namespace WinFormApp.DAO
{
    public class DAO_SanPham : DatabaseConnection
    {
        SqlConnection _conn;
        private SqlCommand command;
        private SqlDataReader reader;
        public DAO_SanPham()
        {
            _conn = new SqlConnection(_strConn);
        }
        public List<SanPham> GetAll()
        {
            List<SanPham> list = new List<SanPham>();
            _conn.Open();
            command = new SqlCommand($"SELECT * FROM SANPHAM", _conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string maSanPham = reader.GetString(0);
                string tenSanPham = reader.GetString(1);
                float donGia = reader.GetFloat(2);
                string donViTinh = reader.GetString(3);
            }
            return list;    
        }
        public List<SanPham> GetList(string _maChiNhanh)
        {
            List<SanPham> list = new List<SanPham>();
            _conn.Open();
            command = new SqlCommand($"SELECT * FROM SANPHAM WHERE MACN = {_maChiNhanh}", _conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string maSanPham = reader.GetString(0);
                string tenSanPham = reader.GetString(1);
                float donGia = reader.GetFloat(2);
                string donViTinh = reader.GetString(3);
            }
            return list;

        }
    }
}
