using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormApp.Model
{
    public class CTHDXUAT
    {
        public int sl = 0;
        public float thanhtien;
        public SanPham SP;
        public CTHDXUAT()
        {

        }
        public CTHDXUAT(int SL, SanPham SP)
        {
            this.sl = SL;
            this.thanhtien = SL * SP.donGia;
            this.SP = SP;
        }
    }
}
