using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormApp.Model;

namespace WinFormApp.View.Report
{
    public partial class rpHoaDonXuat : Form
    {
        HoaDonXuat hoaDonXuat = new HoaDonXuat();
        public rpHoaDonXuat()
        {
            InitializeComponent();
        }
        public rpHoaDonXuat(HoaDonXuat hoaDonXuat)
        {
            InitializeComponent();
            this.hoaDonXuat = hoaDonXuat;
        }
        private void rpHoaDonXuat_Load(object sender, EventArgs e)
        {
            ReportParameter[] param = new ReportParameter[6];
            param[0] = new ReportParameter("NgayLapHoaDon", hoaDonXuat.ngayLapHoaDon.ToString("dd/MM/yyyy"));
            param[1] = new ReportParameter("SoHoaDon", hoaDonXuat.SOHD);
            param[2] = new ReportParameter("NhanVien", hoaDonXuat.nhanVien.tenNhanVien);
            param[3] = new ReportParameter("KhachHang", hoaDonXuat.khachHang.tenKhachHang);
            param[4] = new ReportParameter("SoDienThoai", hoaDonXuat.khachHang.soDienThoai);
            param[5] = new ReportParameter("DiaChi", hoaDonXuat.khachHang.diaChi);
            this.reportViewer1.LocalReport.ReportPath = "HoaDonXuat.rdlc";
            this.reportViewer1.LocalReport.SetParameters(param);
            List<dsHoaDon> dsHoaDonXuat = new List<dsHoaDon>();
            foreach (CTHDXUAT chiTietHoaDon in hoaDonXuat.chiTietHoaDon)
            {
                dsHoaDon dsHoaDon = new dsHoaDon(chiTietHoaDon.SP.maSanPham, chiTietHoaDon.SP.tenSanPham, chiTietHoaDon.sl, chiTietHoaDon.SP.donGia, chiTietHoaDon.thanhtien);
                dsHoaDonXuat.Add(dsHoaDon);
            }
            var reportDataSource = new ReportDataSource("DataSet1", dsHoaDonXuat);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            //tên hiển thị
            this.reportViewer1.LocalReport.DisplayName = "Hóa đơn bán hàng";
            this.reportViewer1.RefreshReport();
        }
    }
}
