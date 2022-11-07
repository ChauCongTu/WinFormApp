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
    public class DAO_ChiNhanh : DatabaseConnection
    {
        SqlConnection _conn;
        private SqlCommand command;
        private SqlDataReader reader;
        public DAO_ChiNhanh()
        {
            _conn = new SqlConnection(_strConn);
        }
        public List<ChiNhanh> getAll()
        {
            List<ChiNhanh> list = new List<ChiNhanh>();
            _conn.Open();
            command = new SqlCommand($"SELECT * FROM CHINHANH", _conn);
            reader = command.ExecuteReader();
            DAO_NhanVien _NhanVien = new DAO_NhanVien();
            DAO_SanPham _SanPham = new DAO_SanPham();
            while (reader.Read())
            {
                string maChiNhanh = reader.GetString(0);
                string tenChiNhanh = reader.GetString(1);
                string diaChi = reader.GetString(2);
                string soDienThoai = reader.GetString(3);
                List<SanPham> sanPham = _SanPham.GetList(maChiNhanh);
                List<NhanVien> nhanVien = _NhanVien.GetList(maChiNhanh);
                ChiNhanh chiNhanh = new ChiNhanh(maChiNhanh, tenChiNhanh, diaChi, soDienThoai, nhanVien, sanPham);
                list.Add(chiNhanh);
            }
            return list;
        }
        public List<ChiNhanh> GetByName(string _tenChiNhanh)
        {
            List<ChiNhanh> list = new List<ChiNhanh>();
            _conn.Open();
            command = new SqlCommand($"SELECT * FROM CHINHANH WHERE TENCN LIKE '%{_tenChiNhanh}%'");
            reader = command.ExecuteReader();
            DAO_NhanVien _NhanVien = new DAO_NhanVien();
            DAO_SanPham _SanPham = new DAO_SanPham();
            while (reader.Read())
            {
                string maChiNhanh = reader.GetString(0);
                string tenChiNhanh = reader.GetString(1);
                string diaChi = reader.GetString(2);
                string soDienThoai = reader.GetString(3);
                List<SanPham> sanPham = _SanPham.GetList(maChiNhanh);
                List<NhanVien> nhanVien = _NhanVien.GetList(maChiNhanh);
                ChiNhanh chiNhanh = new ChiNhanh(maChiNhanh, tenChiNhanh, diaChi, soDienThoai, nhanVien, sanPham);
                list.Add(chiNhanh);
            }
            return list;
        }
        public ChiNhanh GetLast()
        {
            ChiNhanh chiNhanh = new ChiNhanh();
            _conn.Open();
            command = new SqlCommand($"SELECT TOP(1)* FROM CHINHANH ORDER BY MACN DESC", _conn);
            reader = command.ExecuteReader();
            DAO_NhanVien _NhanVien = new DAO_NhanVien();
            DAO_SanPham _SanPham = new DAO_SanPham();
            while (reader.Read())
            {
                string maChiNhanh = reader.GetString(0);
                string tenChiNhanh = reader.GetString(1);
                string diaChi = reader.GetString(2);
                string soDienThoai = reader.GetString(3);
                List<SanPham> sanPham = _SanPham.GetList(maChiNhanh);
                List<NhanVien> nhanVien = _NhanVien.GetList(maChiNhanh);
                chiNhanh = new ChiNhanh(maChiNhanh, tenChiNhanh, diaChi, soDienThoai, nhanVien, sanPham);
            }
            return chiNhanh;
        }
        public ChiNhanh GetByUsrID(string _maNhanVien)
        {
            ChiNhanh chiNhanh = new ChiNhanh();
            _conn.Open();
            command = new SqlCommand($"SELECT CHINHANH.* FROM CHINHANH, NHANVIEN WHERE CHINHANH.MACN = NHANVIEN.MACN AND MANV = '{_maNhanVien}'", _conn);
            reader = command.ExecuteReader();
            DAO_NhanVien _NhanVien = new DAO_NhanVien();
            DAO_SanPham _SanPham = new DAO_SanPham();
            while (reader.Read())
            {
                string maChiNhanh = reader.GetString(0);
                string tenChiNhanh = reader.GetString(1);
                string diaChi = reader.GetString(2);
                string soDienThoai = reader.GetString(3);
                List<SanPham> sanPham = _SanPham.GetList(maChiNhanh);
                List<NhanVien> nhanVien = _NhanVien.GetList(maChiNhanh);
                chiNhanh = new ChiNhanh(maChiNhanh, tenChiNhanh, diaChi, soDienThoai, nhanVien, sanPham);
            }
            _conn.Close();
            return chiNhanh;
        }
        public ChiNhanh GetByID(string _maChiNhanh)
        {
            ChiNhanh chiNhanh = new ChiNhanh();
            _conn.Open();
            command = new SqlCommand($"SELECT * FROM CHINHANH WHERE MACN = '{_maChiNhanh}'", _conn);
            reader = command.ExecuteReader();
            DAO_NhanVien _NhanVien = new DAO_NhanVien();
            DAO_SanPham _SanPham = new DAO_SanPham();
            while (reader.Read())
            {
                string maChiNhanh = reader.GetString(0);
                string tenChiNhanh = reader.GetString(1);
                string diaChi = reader.GetString(2);
                string soDienThoai = reader.GetString(3);
                List<SanPham> sanPham = _SanPham.GetList(maChiNhanh);
                List<NhanVien> nhanVien = _NhanVien.GetList(maChiNhanh);
                chiNhanh = new ChiNhanh(maChiNhanh, tenChiNhanh, diaChi, soDienThoai, nhanVien, sanPham);
            }
            return chiNhanh;
        }
        public void Add(ChiNhanh chiNhanh)
        {
            _conn.Open();
            command = new SqlCommand($"INSERT INTO CHINHANH VALUES('{chiNhanh.maChiNhanh}', N'{chiNhanh.tenChiNhanh}', N'{chiNhanh.diaChi}', '{chiNhanh.soDienThoai}')", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }
        public void Update(ChiNhanh chiNhanh)
        {
            _conn.Open();
            command = new SqlCommand($"UPDATE CHINHANH SET TENCN = N'{chiNhanh.tenChiNhanh}', DIACHI = N'{chiNhanh.diaChi}', SDT = '{chiNhanh.soDienThoai}' WHERE MACN = '{chiNhanh.maChiNhanh}'", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }
        public void Delete(string _maChiNhanh)
        {
            _conn.Open();
            command = new SqlCommand($"DELETE FROM CHINHANH WHERE MACN = '{_maChiNhanh}'", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }
    }
}
