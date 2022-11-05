using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormApp.Model;

namespace WinFormApp.DAO
{
    public class DAO_NhaCungCap : DatabaseConnection
    {
        SqlConnection _conn;
        private SqlCommand command;
        private SqlDataReader reader;
        public DAO_NhaCungCap()
        {
            _conn = new SqlConnection(_strConn);
        }
        public List<NhaCungCap> GetAll()
        {
            List<NhaCungCap> list = new List<NhaCungCap>();
            _conn.Open();
            command = new SqlCommand($"SELECT * FROM NHACUNGCAP", _conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string maNhaCungCap = reader.GetString(0);
                string tenNhaCungCap = reader.GetString(1);
                string diaChi = reader.GetString(2);
                string soDienThoai = "0" + Convert.ToString(reader.GetInt32(3));
                string email = reader.GetString(4);
                NhaCungCap nhaCungCap = new NhaCungCap(maNhaCungCap, tenNhaCungCap, diaChi, soDienThoai, email);
                list.Add(nhaCungCap);
            }
            _conn.Close();
            return list;
        }
        public NhaCungCap GetLast()
        {
            NhaCungCap nhaCungCap = new NhaCungCap();
            _conn.Open();
            command = new SqlCommand($"SELECT TOP(1)* FROM NHACUNGCAP ORDER BY MANCC DESC", _conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string maNhaCungCap = reader.GetString(0);
                string tenNhaCungCap = reader.GetString(1);
                string diaChi = reader.GetString(2);
                string soDienThoai = "0" + Convert.ToString(reader.GetInt32(3));
                string email = reader.GetString(4);
                nhaCungCap = new NhaCungCap(maNhaCungCap, tenNhaCungCap, diaChi, soDienThoai, email);
            }
            _conn.Close();
            return nhaCungCap;
        }
        public NhaCungCap GetByID(string _maNhaCungCap)
        {
            NhaCungCap nhaCungCap = new NhaCungCap();
            _conn.Open();
            command = new SqlCommand($"SELECT * FROM NHACUNGCAP WHERE MANCC = '{_maNhaCungCap}'", _conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string maNhaCungCap = reader.GetString(0);
                string tenNhaCungCap = reader.GetString(1);
                string diaChi = reader.GetString(2);
                string soDienThoai = "0" + Convert.ToString(reader.GetInt32(3));
                string email = reader.GetString(4);
                nhaCungCap = new NhaCungCap(maNhaCungCap, tenNhaCungCap, diaChi, soDienThoai, email);
            }
            _conn.Close();
            return nhaCungCap;
        }
        public void Add(NhaCungCap nhaCungCap)
        {
            _conn.Open();
            command = new SqlCommand($"INSERT INTO NHACUNGCAP VALUES ('{nhaCungCap.maNhaCungCap}', N'{nhaCungCap.tenNhaCungCap}', N'{nhaCungCap.diaChi}', {nhaCungCap.soDienThoai}, '{nhaCungCap.email}')", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }
        public void Update(NhaCungCap nhaCungCap)
        {
            _conn.Open();
            command = new SqlCommand($"UPDATE NHACUNGCAP SET TENNCC = N'{nhaCungCap.tenNhaCungCap}', DIACHI = N'{nhaCungCap.diaChi}', SDT = {nhaCungCap.soDienThoai}, EMAIL = '{nhaCungCap.email}' WHERE MANCC = '{nhaCungCap.maNhaCungCap}'", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }
        public void Delete(string _maNhaCungCap)
        {
            _conn.Open();
            command = new SqlCommand($"DELETE FROM NHACUNGCAP WHERE MAKH = '{_maNhaCungCap}'", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }
    }
}
