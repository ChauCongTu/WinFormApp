using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormApp.Model
{
    public class LoaiXe
    {
        public string maLoaiXe { get; set; }
        public string tenLoaiXe { get; set; }
        public List<SanPhamXe> danhSachXe = new List<SanPhamXe>();
        
        public LoaiXe()
        {

        }
        public LoaiXe(string maLoaiXe, string tenLoaiXe, List<SanPhamXe> danhSachXe)
        {
            this.maLoaiXe = maLoaiXe;
            this.tenLoaiXe = tenLoaiXe;
            this.danhSachXe = danhSachXe;
        }
    }
}
