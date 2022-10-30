using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormApp.Model
{
    public class NhaCungCap
    {
        public string maNhaCungCap { get; set; }
        public string tenNhaCungCap { get; set; }
        public string diaChi { get; set; }
        public string soDienThoai { get; set; }
        public string email { get; set; }
        public NhaCungCap()
        {

        }
        public NhaCungCap(string maNhaCungCap, string tenNhaCungCap, string diaChi, string soDienThoai, string email)
        {
            this.maNhaCungCap = maNhaCungCap;
            this.tenNhaCungCap = tenNhaCungCap;
            this.diaChi = diaChi;
            this.soDienThoai = soDienThoai;
            this.email = email;
        }
    }
}
