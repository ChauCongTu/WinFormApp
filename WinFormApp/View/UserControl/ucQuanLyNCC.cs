using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class ucQuanLyNCC : UserControl
    {
        Functions func = new Functions();
        int savetype;
        NhaCungCap Nhacungcap = new NhaCungCap();
        public ucQuanLyNCC()
        {
            InitializeComponent();
        }
        void table_load()
        {
            dgvNCC.Rows.Clear();
            int i = 1;
            DAO_NhaCungCap dAO_NhaCungCap = new DAO_NhaCungCap();
            List<NhaCungCap> nhaCungCaps = dAO_NhaCungCap.GetAll();
            foreach (NhaCungCap nhaCungCap in nhaCungCaps)
            {
                dgvNCC.Rows.Add(i, nhaCungCap.maNhaCungCap, nhaCungCap.tenNhaCungCap, nhaCungCap.email, nhaCungCap.diaChi, nhaCungCap.soDienThoai);
                i++;
            }
        }
        private void ucQuanLyNCC_Load(object sender, EventArgs e)
        {
            table_load();
            tbInputMaNcc.Enabled = false;
            tbInputTenNcc.Enabled = false;
            tbInputSdtNcc.Enabled = false;
            tbInputDiachiNcc.Enabled = false;
            tbInputEmail.Enabled = false;

            func.turnOffButton(btnUpdateCN, pbUpdate);
            func.turnOffButton(btnSaveCN, pbSave);
            func.turnOffButton(btnDeleteCN, pbDelete);
        }

        private void btnNewCN_Click(object sender, EventArgs e)
        {
            savetype = 1;
            table_load();
            DAO_NhaCungCap NCC = new DAO_NhaCungCap();
            tbInputMaNcc.Text = func.CreateID(NCC.GetLast().maNhaCungCap);
            savetype = 1;
            tbInputMaNcc.Enabled = false;
            tbInputSdtNcc.Enabled = true;
            tbInputTenNcc.Enabled = true;
            tbInputDiachiNcc.Enabled = true;
            tbInputEmail.Enabled = true;
            func.turnOffButton(btnNewCN, pbAdd);
            func.turnOnButton(btnSaveCN, pbSave);
            func.turnOffButton(btnUpdateCN, pbUpdate);
            func.turnOffButton(btnDeleteCN, pbDelete);
        }

        private void btnSaveCN_Click(object sender, EventArgs e)
        {

            if (savetype == 1)
            {
                if (tbInputMaNcc.Text == "" || tbInputTenNcc.Text == "" || tbInputDiachiNcc.Text == "" || tbInputSdtNcc.Text == "" || tbInputEmail.Text == "")
                {
                    RJMessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Có lỗi xảy ra", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                else
                {
                    RJMessageBox.Show("Thêm chi nhánh thành công!", "Thành công", MessageBoxButtons.OK);
                    DAO_NhaCungCap dAO_NhaCungCap = new DAO_NhaCungCap();
                    Nhacungcap.maNhaCungCap = tbInputMaNcc.Text;
                    Nhacungcap.tenNhaCungCap = tbInputTenNcc.Text;
                    Nhacungcap.email = tbInputEmail.Text;
                    Nhacungcap.soDienThoai = tbInputSdtNcc.Text;
                    Nhacungcap.diaChi = tbInputDiachiNcc.Text;
                    dAO_NhaCungCap.Add(Nhacungcap);
                    table_load();
                    func.turnOnButton(btnNewCN, pbAdd);
                }
            }
            if (savetype == 2)
            {
                RJMessageBox.Show("Thay đổi thông tin chi nhánh thành công!", "Thành công", MessageBoxButtons.OK);
                DAO_NhaCungCap dAO_NhaCungCap = new DAO_NhaCungCap();
                Nhacungcap.maNhaCungCap = tbInputMaNcc.Text;
                Nhacungcap.tenNhaCungCap = tbInputTenNcc.Text;
                Nhacungcap.email = tbInputEmail.Text;
                Nhacungcap.soDienThoai = tbInputSdtNcc.Text;
                Nhacungcap.diaChi = tbInputDiachiNcc.Text;
                dAO_NhaCungCap.Update(Nhacungcap);
                table_load();
            }
        }

        private void btnUpdateCN_Click(object sender, EventArgs e)
        {
            savetype = 2;
            tbInputMaNcc.Enabled = false;
            tbInputTenNcc.Enabled = true;
            tbInputEmail.Enabled = true;
            tbInputSdtNcc.Enabled = true;
            tbInputDiachiNcc.Enabled = true;
        }

        private void btnDeleteCN_Click(object sender, EventArgs e)
        {
            var res = RJMessageBox.Show("Bạn có chắc muốn xóa chi nhánh này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                DAO_NhaCungCap dAO_NhaCungCap = new DAO_NhaCungCap();
                dAO_NhaCungCap.Delete(tbInputMaNcc.Text);
                table_load();
            }
            else
            {
                table_load();
            }
            tbInputMaNcc.Text = "";
            tbInputTenNcc.Text = "";
            tbInputEmail.Text = "";
            tbInputDiachiNcc.Text = "";
            tbInputSdtNcc.Text = "";
        }

        private void btnExitCN_Click(object sender, EventArgs e)
        {
            tbInputMaNcc.Enabled = false;
            tbInputTenNcc.Enabled = false;
            tbInputEmail.Enabled = false;
            tbInputSdtNcc.Enabled = false;
            tbInputDiachiNcc.Enabled = false;
            func.turnOnButton(btnNewCN, pbAdd);
            func.turnOffButton(btnSaveCN, pbSave);
            func.turnOffButton(btnUpdateCN, pbUpdate);
            func.turnOffButton(btnDeleteCN, pbDelete);
            DAO_NhaCungCap NCC = new DAO_NhaCungCap();
            tbInputMaNcc.Text = func.CreateID(NCC.GetLast().maNhaCungCap);
            tbInputTenNcc.Text = "";
            tbInputEmail.Text = "";
            tbInputDiachiNcc.Text = "";
            tbInputSdtNcc.Text = "";
        }

        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            func.turnOnButton(btnUpdateCN, pbUpdate);
            func.turnOnButton(btnDeleteCN, pbDelete);
            func.turnOffButton(btnNewCN, pbAdd);
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvNCC.Rows[e.RowIndex];
                DAO_NhaCungCap dAO_NhaCungCap = new DAO_NhaCungCap();
                Nhacungcap = dAO_NhaCungCap.GetByID(row.Cells[1].Value.ToString());
                tbInputMaNcc.Text = Nhacungcap.maNhaCungCap;
                tbInputTenNcc.Text = Nhacungcap.tenNhaCungCap;
                tbInputEmail.Text = Nhacungcap.email;
                tbInputSdtNcc.Text = Nhacungcap.soDienThoai;
                tbInputDiachiNcc.Text = Nhacungcap.diaChi;
                func.turnOnButton(btnSaveCN, pbSave);

            }
        }
    }
}
