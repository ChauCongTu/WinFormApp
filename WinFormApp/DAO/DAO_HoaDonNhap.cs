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
    public class DAO_HoaDonNhap : DatabaseConnection
    {
        SqlConnection _conn;
        private SqlCommand command;
        private SqlDataReader reader;
        public DAO_HoaDonNhap()
        {
            _conn = new SqlConnection(_strConn);
        }
        public List<HoaDonNhap> GetAll()
        {
            List<HoaDonNhap> list = new List<HoaDonNhap>();
            _conn.Open();
            command = new SqlCommand($"SELECT * FROM HOADONNHAP", _conn);
            reader = command.ExecuteReader();
            DAO_NhaCungCap dAO_NhaCungCap = new DAO_NhaCungCap();
            DAO_NhanVien dAO_NhanVien = new DAO_NhanVien();
            DAO_ChiTietHoaDonNhap dAO_ChiTietHoaDonNhap = new DAO_ChiTietHoaDonNhap();
            while (reader.Read())
            {
                string soHoaDon = reader.GetString(0);
                DateTime ngayLapHoaDon = reader.GetDateTime(3);
                NhanVien nhanVien = dAO_NhanVien.GetByID(reader.GetString(1));
                NhaCungCap nhaCungCap = dAO_NhaCungCap.GetByID(reader.GetString(2));
                List<CTHDNHAP> chiTiet = dAO_ChiTietHoaDonNhap.GetList(reader.GetString(0));
                HoaDonNhap hoaDon = new HoaDonNhap(soHoaDon, ngayLapHoaDon, nhanVien, nhaCungCap, chiTiet);
                list.Add(hoaDon);
            }
            _conn.Close();
            return list;
        }
        public List<HoaDonNhap> GetByDate(DateTime _from, DateTime _to)
        {
            List<HoaDonNhap> list = new List<HoaDonNhap>();
            _conn.Open();
            command = new SqlCommand($"SELECT * FROM HOADONNHAP WHERE NGHD <= '{_to}' AND NGHD >='{_from}'", _conn);
            reader = command.ExecuteReader();
            DAO_NhaCungCap dAO_NhaCungCap = new DAO_NhaCungCap();
            DAO_NhanVien dAO_NhanVien = new DAO_NhanVien();
            DAO_ChiTietHoaDonNhap dAO_ChiTietHoaDonNhap = new DAO_ChiTietHoaDonNhap();
            while (reader.Read())
            {
                string soHoaDon = reader.GetString(0);
                DateTime ngayLapHoaDon = reader.GetDateTime(3);
                NhanVien nhanVien = dAO_NhanVien.GetByID(reader.GetString(1));
                NhaCungCap nhaCungCap = dAO_NhaCungCap.GetByID(reader.GetString(2));
                List<CTHDNHAP> chiTiet = dAO_ChiTietHoaDonNhap.GetList(reader.GetString(0));
                HoaDonNhap hoaDon = new HoaDonNhap(soHoaDon, ngayLapHoaDon, nhanVien, nhaCungCap, chiTiet);
                list.Add(hoaDon);
            }
            _conn.Close();
            return list;
        }
        public HoaDonNhap GetLast()
        {
            HoaDonNhap hoaDonNhap = new HoaDonNhap();
            command = new SqlCommand($"SELECT TOP(1).* FROM HOADONNHAP ORDER BY DESC", _conn);
            reader = command.ExecuteReader();
            DAO_NhaCungCap dAO_NhaCungCap = new DAO_NhaCungCap();
            DAO_NhanVien dAO_NhanVien = new DAO_NhanVien();
            DAO_ChiTietHoaDonNhap dAO_ChiTietHoaDonNhap = new DAO_ChiTietHoaDonNhap();
            while (reader.Read())
            {
                string soHoaDon = reader.GetString(0);
                DateTime ngayLapHoaDon = reader.GetDateTime(3);
                NhanVien nhanVien = dAO_NhanVien.GetByID(reader.GetString(1));
                NhaCungCap nhaCungCap = dAO_NhaCungCap.GetByID(reader.GetString(2));
                List<CTHDNHAP> chiTiet = dAO_ChiTietHoaDonNhap.GetList(reader.GetString(0));
                hoaDonNhap = new HoaDonNhap(soHoaDon, ngayLapHoaDon, nhanVien, nhaCungCap, chiTiet);
            }
            _conn.Close();
            return hoaDonNhap;
        }
        public HoaDonNhap GetByID(string _soHoaDon)
        {
            HoaDonNhap hoaDonNhap = new HoaDonNhap();
            command = new SqlCommand($"SELECT * FROM HOADONNHAP WHERE SOHDNHAP = '{_soHoaDon}'", _conn);
            reader = command.ExecuteReader();
            DAO_NhaCungCap dAO_NhaCungCap = new DAO_NhaCungCap();
            DAO_NhanVien dAO_NhanVien = new DAO_NhanVien();
            DAO_ChiTietHoaDonNhap dAO_ChiTietHoaDonNhap = new DAO_ChiTietHoaDonNhap();
            while (reader.Read())
            {
                string soHoaDon = reader.GetString(0);
                DateTime ngayLapHoaDon = reader.GetDateTime(3);
                NhanVien nhanVien = dAO_NhanVien.GetByID(reader.GetString(1));
                NhaCungCap nhaCungCap = dAO_NhaCungCap.GetByID(reader.GetString(2));
                List<CTHDNHAP> chiTiet = dAO_ChiTietHoaDonNhap.GetList(reader.GetString(0));
                hoaDonNhap = new HoaDonNhap(soHoaDon, ngayLapHoaDon, nhanVien, nhaCungCap, chiTiet);
            }
            _conn.Close();
            return hoaDonNhap;
        }
        public void Add(HoaDonNhap hoaDonNhap)
        {
            _conn.Open();
            command = new SqlCommand($"INSERT INTO HOADONNHAP VALUES ('{hoaDonNhap.SOHD}', '{hoaDonNhap.nhanVien.maNhanVien}', '{hoaDonNhap.nhaCungCap.maNhaCungCap}', '{hoaDonNhap.ngayLapHoaDon}')", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }
        public void Update(HoaDonNhap hoaDonNhap)
        {
            _conn.Open();
            command = new SqlCommand($"UPDATE HOADONNHAP SET MANV = '{hoaDonNhap.nhanVien.maNhanVien}', MAKH = '{hoaDonNhap.nhaCungCap.maNhaCungCap}', NGHD = '{hoaDonNhap.ngayLapHoaDon}' WHERE SOHDXUAT = '{hoaDonNhap.SOHD}'", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }
        public void Delete(string _soHoaDon)
        {
            _conn.Open();
            command = new SqlCommand($"DELETE FROM CTHDNHAP WHERE SOHDNHAP = '{_soHoaDon}'", _conn);
            command.ExecuteNonQuery();
            command = new SqlCommand($"DELETE FROM HOADONNHAP WHERE SOHDNHAP = '{_soHoaDon}'", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }
    }
}
