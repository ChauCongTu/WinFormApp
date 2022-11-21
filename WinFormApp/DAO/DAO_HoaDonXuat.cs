using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using WinFormApp.Model;
using WinFormApp.View;

namespace WinFormApp.DAO
{
    public class DAO_HoaDonXuat : DatabaseConnection
    {
        SqlConnection _conn;
        private SqlCommand command;
        private SqlDataReader reader;
        public DAO_HoaDonXuat()
        {
            _conn = new SqlConnection(_strConn);
        }
        public List<HoaDonXuat> GetAll()
        {
            List<HoaDonXuat> list = new List<HoaDonXuat>();
            _conn.Open();
            command = new SqlCommand($"SELECT * FROM HOADONXUAT", _conn);
            reader = command.ExecuteReader();
            DAO_KhachHang dAO_KhachHang = new DAO_KhachHang();
            DAO_NhanVien dAO_NhanVien = new DAO_NhanVien();
            DAO_ChiTietHoaDonXuat dAO_ChiTietHoaDonXuat = new DAO_ChiTietHoaDonXuat();
            while (reader.Read())
            {
                string soHoaDon = reader.GetString(0);
                DateTime ngayLapHoaDon = reader.GetDateTime(3);
                NhanVien nhanVien = dAO_NhanVien.GetByID(reader.GetString(1));
                KhachHang khachHang = dAO_KhachHang.GetByID(reader.GetString(2));
                List<CTHDXUAT> chiTiet = dAO_ChiTietHoaDonXuat.GetList(reader.GetString(0));
                HoaDonXuat hoaDonXuat = new HoaDonXuat(soHoaDon, ngayLapHoaDon, nhanVien, khachHang, chiTiet);
                list.Add(hoaDonXuat);
            }
            _conn.Close();
            return list;
        }
        public List<HoaDonXuat> GetByDate(DateTime _from, DateTime _to)
        {
            List<HoaDonXuat> list = new List<HoaDonXuat>();
            _conn.Open();
            command = new SqlCommand($"SELECT * FROM HOADONXUAT WHERE NGHD <= '{_to}' AND NGHD >='{_from}'", _conn);
            reader = command.ExecuteReader();
            DAO_KhachHang dAO_KhachHang = new DAO_KhachHang();
            DAO_NhanVien dAO_NhanVien = new DAO_NhanVien();
            DAO_ChiTietHoaDonXuat dAO_ChiTietHoaDonXuat = new DAO_ChiTietHoaDonXuat();
            while (reader.Read())
            {
                string soHoaDon = reader.GetString(0);
                DateTime ngayLapHoaDon = reader.GetDateTime(3);
                NhanVien nhanVien = dAO_NhanVien.GetByID(reader.GetString(1));
                KhachHang khachHang = dAO_KhachHang.GetByID(reader.GetString(2));
                List<CTHDXUAT> chiTiet = dAO_ChiTietHoaDonXuat.GetList(reader.GetString(0));
                HoaDonXuat hoaDonXuat = new HoaDonXuat(soHoaDon, ngayLapHoaDon, nhanVien, khachHang, chiTiet);
                list.Add(hoaDonXuat);
            }
            _conn.Close();
            return list;
        }
        public HoaDonXuat GetLastIDToday()
        {
            _conn.Open();
            HoaDonXuat hoaDonXuat = new HoaDonXuat();
            command = new SqlCommand($"SELECT TOP(1)* FROM HOADONXUAT WHERE NGHD = '{DateTime.Now}'ORDER BY SOHDXUAT DESC", _conn);
            reader = command.ExecuteReader();
            DAO_KhachHang dAO_KhachHang = new DAO_KhachHang();
            DAO_NhanVien dAO_NhanVien = new DAO_NhanVien();
            DAO_ChiTietHoaDonXuat dAO_ChiTietHoaDonXuat = new DAO_ChiTietHoaDonXuat();
            while (reader.Read())
            {
                string soHoaDon = reader.GetString(0);
                DateTime ngayLapHoaDon = reader.GetDateTime(3);
                NhanVien nhanVien = dAO_NhanVien.GetByID(reader.GetString(1));
                KhachHang khachHang = dAO_KhachHang.GetByID(reader.GetString(2));
                List<CTHDXUAT> chiTiet = dAO_ChiTietHoaDonXuat.GetList(reader.GetString(0));
                hoaDonXuat = new HoaDonXuat(soHoaDon, ngayLapHoaDon, nhanVien, khachHang, chiTiet);
            }
            _conn.Close();
            return hoaDonXuat;
        }
        public HoaDonXuat GetByID(string _soHoaDon)
        {
            _conn.Open();
            HoaDonXuat hoaDonXuat = new HoaDonXuat();
            command = new SqlCommand($"SELECT * FROM HOADONXUAT WHERE SOHDXUAT = '{_soHoaDon}'", _conn);
            reader = command.ExecuteReader();

            DAO_KhachHang dAO_KhachHang = new DAO_KhachHang();
            DAO_NhanVien dAO_NhanVien = new DAO_NhanVien();
            DAO_ChiTietHoaDonXuat dAO_ChiTietHoaDonXuat = new DAO_ChiTietHoaDonXuat();
            while (reader.Read())
            {
                string soHoaDon = reader.GetString(0);
                DateTime ngayLapHoaDon = reader.GetDateTime(3);
                NhanVien nhanVien = dAO_NhanVien.GetByID(reader.GetString(1));
                KhachHang khachHang = dAO_KhachHang.GetByID(reader.GetString(2));
                List<CTHDXUAT> chiTiet = dAO_ChiTietHoaDonXuat.GetList(reader.GetString(0));
                hoaDonXuat = new HoaDonXuat(soHoaDon, ngayLapHoaDon, nhanVien, khachHang, chiTiet);
            }
            _conn.Close();
            return hoaDonXuat;
        }
        public void Add(HoaDonXuat hoaDonXuat)
        {
            _conn.Open();
            command = new SqlCommand($"INSERT INTO HOADONXUAT VALUES ('{hoaDonXuat.SOHD}', '{hoaDonXuat.nhanVien.maNhanVien}', '{hoaDonXuat.khachHang.maKhachHang}', '{hoaDonXuat.ngayLapHoaDon}')", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }
        public void Update(HoaDonXuat hoaDonXuat)
        {
            _conn.Open();
            command = new SqlCommand($"UPDATE HOADONXUAT SET MANV = '{hoaDonXuat.nhanVien.maNhanVien}', MAKH = '{hoaDonXuat.khachHang.maKhachHang}', NGHD = '{hoaDonXuat.ngayLapHoaDon}' WHERE SOHDXUAT = '{hoaDonXuat.SOHD}'", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }
        public void Delete(string _soHoaDon)
        {
            _conn.Open();
            command = new SqlCommand($"DELETE FROM CTHDXUAT WHERE SOHDXUAT = '{_soHoaDon}'", _conn);
            command.ExecuteNonQuery();
            command = new SqlCommand($"DELETE FROM HOADONXUAT WHERE SOHDXUAT = '{_soHoaDon}'", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }
    }
}
