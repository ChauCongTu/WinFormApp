using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormApp.Model;

namespace WinFormApp.View.Report
{
    public partial class rpHoaDonNhap : Form
    {
        HoaDonNhap hoaDonNhap = new HoaDonNhap();
        public rpHoaDonNhap()
        {
            InitializeComponent();
        }
        public rpHoaDonNhap(HoaDonNhap hoaDonNhap)
        {
            InitializeComponent();
            this.hoaDonNhap = hoaDonNhap;
        }
        private void rpHoaDonNhap_Load(object sender, EventArgs e)
        {
            ReportParameter[] param = new ReportParameter[6];
            param[0] = new ReportParameter("NgayLapHoaDon", hoaDonNhap.ngayLapHoaDon.ToString("dd/MM/yyyy"));
            param[1] = new ReportParameter("SoHoaDon", hoaDonNhap.SOHD);
            param[2] = new ReportParameter("NhanVien", hoaDonNhap.nhanVien.tenNhanVien);
            param[3] = new ReportParameter("NhaCungCap", hoaDonNhap.nhaCungCap.tenNhaCungCap);
            param[4] = new ReportParameter("SoDienThoai", hoaDonNhap.nhaCungCap.soDienThoai);
            param[5] = new ReportParameter("DiaChi", hoaDonNhap.nhaCungCap.diaChi);
            this.reportViewer1.LocalReport.ReportPath = "HoaDonNhap.rdlc";
            this.reportViewer1.LocalReport.SetParameters(param);
            List<dsHoaDon> dsHoaDonNhap = new List<dsHoaDon>();
            foreach(CTHDNHAP chiTietHoaDon in hoaDonNhap.chiTietHoaDon)
            {
                dsHoaDon dsHoaDon = new dsHoaDon(chiTietHoaDon.sanPham.maSanPham, chiTietHoaDon.sanPham.tenSanPham, chiTietHoaDon.soLuong, chiTietHoaDon.sanPham.donGia, chiTietHoaDon.thanhTien);
                dsHoaDonNhap.Add(dsHoaDon);
            }
            var reportDataSource = new ReportDataSource("DataSet1", dsHoaDonNhap);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            //tên hiển thị
            this.reportViewer1.LocalReport.DisplayName = "Hóa đơn nhập hàng";
            this.reportViewer1.RefreshReport();
        }
    }
    
}
