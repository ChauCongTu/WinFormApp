using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WinFormApp.CustomControl;
using WinFormApp.Model;

namespace WinFormApp.DAO
{
    public class DAO_HinhAnhXe:DatabaseConnection
    {
        SqlConnection _conn;
        private SqlCommand command;
        private SqlDataReader reader;
        public DAO_HinhAnhXe()
        {
            _conn = new SqlConnection(_strConn);
        }
        public List<HinhAnhXe> GetAll()
        {
            List<HinhAnhXe> list = new List<HinhAnhXe>();
            _conn.Open();
            command = new SqlCommand($"SELECT * FROM XE_HINHANH", _conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string maSanPham = reader.GetString(0);
                int maHinhAnh = reader.GetInt32(1);
                string image = reader.GetString(2);
                HinhAnhXe hinhAnhXe = new HinhAnhXe(maSanPham, maHinhAnh, image);
                list.Add(hinhAnhXe);
            }
            _conn.Close();
            return list;
        }
        public List<HinhAnhXe> GetList(string _maSanPham)
        {
            List<HinhAnhXe> list = new List<HinhAnhXe>();
            _conn.Open();
            command = new SqlCommand($"SELECT * FROM XE_HINHANH WHERE Product_ID = '{_maSanPham}'", _conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string maSanPham = reader.GetString(0);
                int maHinhAnh = reader.GetInt32(1);
                string image = reader.GetString(2);
                HinhAnhXe hinhAnhXe = new HinhAnhXe(maSanPham, maHinhAnh, image);
                list.Add(hinhAnhXe);
            }
            _conn.Close();
            return list;
        }
        public HinhAnhXe GetByID(string _maSanPham, string _maHinhAnh)
        {
            HinhAnhXe hinhAnhXe = new HinhAnhXe();
            _conn.Open();
            command = new SqlCommand($"SELECT * FROM XE_HINHANH WHERE Product_ID = '{_maSanPham}' AND Image_ID = '{_maHinhAnh}'", _conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string maSanPham = reader.GetString(0);
                int maHinhAnh = reader.GetInt32(1);
                string image = reader.GetString(2);
                hinhAnhXe = new HinhAnhXe(_maSanPham, maHinhAnh, image);
            }
            _conn.Open();
            return hinhAnhXe;
        }
        public void Add(HinhAnhXe hinhAnhXe)
        {
            _conn.Open();
            command = new SqlCommand($"INSERT INTO XE_HINHANH VALUES ('{hinhAnhXe.maSanPham}', {hinhAnhXe.maHinhAnh}, '{hinhAnhXe.hinhAnh}')", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }
        public void Update(HinhAnhXe hinhAnhXe)
        {
            _conn.Open();
            command = new SqlCommand($"UPDATE XE_HINHANH SET Image_binary = '{hinhAnhXe.hinhAnh}' WHERE Product_ID = '{hinhAnhXe.maSanPham}' AND Image_ID = {hinhAnhXe.maHinhAnh}", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }
        public void Delete(string _maSanPham, int _maHinhAnh)
        {
            _conn.Open();
            command = new SqlCommand($"DELETE FROM XE_HINHANH WHERE Product_ID = '{_maSanPham}' AND Image_ID = {_maHinhAnh}", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }
    }
}
