using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using WinFormApp.Model;

namespace WinFormApp.DAO
{
    public class DAO_NhanVien : DatabaseConnection
    {
        SqlConnection _conn;
        private SqlCommand command;
        private SqlDataReader reader;
        public DAO_NhanVien()
        {
            _conn = new SqlConnection(_strConn);
        }
        public List<NhanVien> GetAll()
        {
            List<NhanVien> list = new List<NhanVien>();
            _conn.Open();
            command = new SqlCommand($"SELECT * FROM NHANVIEN", _conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string maNhanVien = reader.GetString(0);
                string tenNhanVien = reader.GetString(1);
                string tenDangNhap = reader.GetString(2);
                string matKhau = reader.GetString(3);
                DateTime ngaySinh = reader.GetDateTime(4);
                int chungMinhNhanDan = reader.GetInt32(5);
                string diaChi = reader.GetString(6);
                int capbac = reader.GetInt32(7);
                string soDienThoai = reader.GetString(8);
                NhanVien nhan = new NhanVien(maNhanVien, tenNhanVien, tenDangNhap, matKhau, ngaySinh, chungMinhNhanDan, diaChi, capbac, soDienThoai);
                list.Add(nhan);
            }
            _conn.Close();
            return list;
        }
        public List<NhanVien> GetList(string _maChiNhanh)
        {
            List<NhanVien> list = new List<NhanVien>();
            _conn.Open();
            command = new SqlCommand($"SELECT * FROM NHANVIEN WHERE MACN = '{_maChiNhanh}'", _conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string maNhanVien = reader.GetString(0);
                string tenNhanVien = reader.GetString(1);
                string tenDangNhap = reader.GetString(2);
                string matKhau = reader.GetString(3);
                DateTime ngaySinh = reader.GetDateTime(4);
                int chungMinhNhanDan = reader.GetInt32(5);
                string diaChi = reader.GetString(6);
                int capbac = reader.GetInt32(7);
                string soDienThoai = reader.GetString(8);
                NhanVien nhan = new NhanVien(maNhanVien, tenNhanVien, tenDangNhap, matKhau, ngaySinh, chungMinhNhanDan, diaChi, capbac, soDienThoai);
                list.Add(nhan);
            }
            _conn.Close();
            return list;
            
        }
        public NhanVien GetByID(string _maNhanVien)
        {
            NhanVien nhanVien = new NhanVien();
            _conn.Open();
            command = new SqlCommand($"SELECT * FROM NHANVIEN WHERE MANV = {_maNhanVien}", _conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string maNhanVien = reader.GetString(0);
                string tenNhanVien = reader.GetString(1);
                string tenDangNhap = reader.GetString(2);
                string matKhau = reader.GetString(3);
                DateTime ngaySinh = reader.GetDateTime(4);
                int chungMinhNhanDan = reader.GetInt32(5);
                string diaChi = reader.GetString(6);
                int capbac = reader.GetInt32(7);
                string soDienThoai = reader.GetString(8);
                nhanVien = new NhanVien(maNhanVien, tenNhanVien, tenDangNhap, matKhau, ngaySinh, chungMinhNhanDan, diaChi, capbac, soDienThoai);
            }
            return nhanVien;
        }
        public void Add(NhanVien _nhanVien, string _maChiNhanh)
        {
            _conn.Open();
            command = new SqlCommand($@"INSERT INTO NHANVIEN 
                                        VALUES(MANV = '{_nhanVien.maNhanVien}', 
                                               HOTEN = N'{_nhanVien.tenNhanVien}',
                                               TENDANGNHAP = N'{_nhanVien.tenDangNhap}',
                                               MATKHAU = '{GetMD5(_nhanVien.matKhau)}',
                                               NGSINH = '{_nhanVien.ngaySinh}',
                                               SOCMND = '{_nhanVien.chungMinhNhanDan}',
                                               DIACHI = N'{_nhanVien.diaChi}',
                                               QUYEN = {_nhanVien.capbac},
                                               SDT = '{_nhanVien.soDienThoai}',
                                               MACN = '{_maChiNhanh}'
                                               )", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }
        public void Update(NhanVien _nhanVien, string _maChiNhanh)
        {
            _conn.Open();
            command = new SqlCommand($@"UPDATE NHANVIEN 
                                        SET HOTEN = N'{_nhanVien.tenNhanVien}',
                                            TENDANGNHAP = N'{_nhanVien.tenDangNhap}',
                                            MATKHAU = '{GetMD5(_nhanVien.matKhau)}',
                                            NGSINH = '{_nhanVien.ngaySinh}',
                                            SOCMND = '{_nhanVien.chungMinhNhanDan}',
                                            DIACHI = N'{_nhanVien.diaChi}',
                                            QUYEN = {_nhanVien.capbac},
                                            SDT = '{_nhanVien.soDienThoai}',
                                            MACN = '{_maChiNhanh}'
                                        WHERE MANV = '{_nhanVien.maNhanVien}'", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }
        public void Delete(string _maNhanVien)
        {
            _conn.Open();
            command = new SqlCommand($"DELETE FROM NHANVIEN WHERE MANV = '{_maNhanVien}'", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }
        public static string GetMD5(string plainText)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            // Compute hash from the bytes of text
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(plainText));
            // Get hash result after compute it
            byte[] result = md5.Hash;
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                strBuilder.Append(result[i].ToString("X2"));
            }

            return strBuilder.ToString();
        }
    }
}
