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
using WinFormApp.DAO;
using WinFormApp.Model;
using WinFormApp.View;

namespace WinFormApp.CustomControl
{
    public partial class ucHinhAnhXe : UserControl
    {
        int maHinhAnh = 0;
        HinhAnhXe hinhAnhXe = new HinhAnhXe();
        SanPhamXe sanPhamXe = new SanPhamXe();
        Functions functions = new Functions();
        string machinhanh;
        int thaoTac;
        public ucHinhAnhXe()
        {
            InitializeComponent();
        }
        public ucHinhAnhXe(SanPhamXe sanPhamXe, int thaotac, string machinhanh)
        {
            InitializeComponent();
            this.sanPhamXe = sanPhamXe;
            this.thaoTac = thaotac;
            this.machinhanh = machinhanh;
        }
        void Load_Image()
        {
            DAO_HinhAnhXe dAO_HinhAnhXe = new DAO_HinhAnhXe();
            List<HinhAnhXe> listHinhAnh = dAO_HinhAnhXe.GetList(sanPhamXe.maSanPham);
            if (listHinhAnh.Count > 0 && listHinhAnh.Count < 2)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                lbError.Visible = false;
                pbHinhAnh.Image = functions.ConvertByteToImg(listHinhAnh[maHinhAnh].hinhAnh);
            }
            else if (listHinhAnh.Count >= 2)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                lbError.Visible = false;
                pbHinhAnh.Image = functions.ConvertByteToImg(listHinhAnh[maHinhAnh].hinhAnh);
            }
            else
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pbHinhAnh.Image = null;
            }
        }
        private void ucHinhAnhXe_Load(object sender, EventArgs e)
        {
            Load_Image();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DAO_HinhAnhXe dAO_HinhAnhXe = new DAO_HinhAnhXe();
            List<HinhAnhXe> listHinhAnh = dAO_HinhAnhXe.GetList(sanPhamXe.maSanPham);
            string BinaryImg;
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                BinaryImg = Convert.ToBase64String(functions.ConvertImgToByte(openFile.FileName));
                RJMessageBox.Show("Thêm ảnh sản phẩm thành công!", "Thành công");
                hinhAnhXe = new HinhAnhXe(sanPhamXe.maSanPham, listHinhAnh.Count + 1, BinaryImg);
                dAO_HinhAnhXe.Add(hinhAnhXe);
            }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            Load_Image();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DAO_HinhAnhXe dAO_HinhAnhXe = new DAO_HinhAnhXe();
            List<HinhAnhXe> listHinhAnh = dAO_HinhAnhXe.GetList(sanPhamXe.maSanPham);
            if (maHinhAnh < listHinhAnh.Count - 1)
            {
                maHinhAnh++;
                Load_Image();
            }
            else
            {
                maHinhAnh = 0;
                Load_Image();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DAO_HinhAnhXe dAO_HinhAnhXe = new DAO_HinhAnhXe();
            List<HinhAnhXe> listHinhAnh = dAO_HinhAnhXe.GetList(sanPhamXe.maSanPham);
            if (maHinhAnh > 0)
            {
                maHinhAnh--;
                Load_Image();
            }
            else
            {
                maHinhAnh = listHinhAnh.Count - 1;
                Load_Image();
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            var result = RJMessageBox.Show("Bạn có chắc muốn xóa hình ảnh này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DAO_HinhAnhXe dAO_HinhAnhXe = new DAO_HinhAnhXe();
                dAO_HinhAnhXe.Delete(sanPhamXe.maSanPham, maHinhAnh + 1);
                maHinhAnh--;
            }
            else
            {

            }
        }

        private void ucHinhAnhXe_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right)
            {
                pictureBox2_Click(sender, e);
            }
            else if(e.KeyCode == Keys.Left)
            {
                pictureBox3_Click(sender, e);
            }
        }
    }
}
