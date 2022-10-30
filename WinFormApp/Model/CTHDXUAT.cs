using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormApp.Model
{
    public class CTHDXUAT
    {
        public int sl{ get; set; }
        public float thanhtien { get; set; }
        public SanPham SP { get; set; }
        public CTHDXUAT()
        {

        }
        public CTHDXUAT(int SL, SanPham SP)
        {
            this.sl = SL;
            this.SP = SP;
            this.thanhtien = SL * SP.donGia;
        }
    }
}
