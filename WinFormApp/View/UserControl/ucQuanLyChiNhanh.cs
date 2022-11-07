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
    public partial class ucQuanLyChiNhanh : UserControl
    {
        Functions func = new Functions();
        int savetype;
        ChiNhanh Chinhanh = new ChiNhanh();
        public ucQuanLyChiNhanh()
        {
            InitializeComponent();
        }

        void table_load()
        {
            dgvChiNhanh.Rows.Clear();
            int i = 1;
            DAO_ChiNhanh dAO_ChiNhanh = new DAO_ChiNhanh();
            List<ChiNhanh> chiNhanhs = dAO_ChiNhanh.getAll();
            foreach (ChiNhanh chiNhanh in chiNhanhs)
            {
                dgvChiNhanh.Rows.Add(i, chiNhanh.maChiNhanh, chiNhanh.tenChiNhanh, chiNhanh.diaChi, chiNhanh.soDienThoai);
                i++;
            }
        }

        private void ucQuanLyChiNhanh_Load(object sender, EventArgs e)
        {
            table_load();
            tbInputMacn.Enabled = false;
            tbInputTenCN.Enabled = false;
            tbInputSDT.Enabled = false;
            tbInputDiachi.Enabled = false;
            func.turnOffButton(btnUpdateCN, pbUpdate);
            func.turnOffButton(btnSaveCN, pbSave);
            func.turnOffButton(btnDeleteCN, pbDelete);
        }

        private void btnNewCN_Click(object sender, EventArgs e)
        {
            table_load();
            DAO_ChiNhanh CN = new DAO_ChiNhanh();
            tbInputMacn.Text = func.CreateID(CN.GetLast().maChiNhanh);
            savetype = 1;
            tbInputMacn.Enabled = false;
            tbInputTenCN.Enabled = true;
            tbInputSDT.Enabled = true;

            tbInputDiachi.Enabled = true;
            func.turnOffButton(btnNewCN, pbAdd);
            func.turnOnButton(btnSaveCN, pbSave);
            func.turnOffButton(btnUpdateCN, pbUpdate);
            func.turnOffButton(btnDeleteCN, pbDelete);

        }

        private void btnSaveCN_Click(object sender, EventArgs e)
        {
            if (savetype == 1)
            {

                if (tbInputMacn.Text == "" || tbInputTenCN.Text == "" || tbInputDiachi.Text == "" || tbInputSDT.Text == "")
                {
                    RJMessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Có lỗi xảy ra", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                else
                {
                    RJMessageBox.Show("Thêm chi nhánh thành công!", "Thành công", MessageBoxButtons.OK);
                    DAO_ChiNhanh dAO_ChiNhanh = new DAO_ChiNhanh();
                    Chinhanh.maChiNhanh = tbInputMacn.Text;
                    Chinhanh.tenChiNhanh = tbInputTenCN.Text;
                    Chinhanh.diaChi = tbInputDiachi.Text;
                    Chinhanh.soDienThoai = tbInputSDT.Text;
                    dAO_ChiNhanh.Add(Chinhanh);
                    table_load();
                    func.turnOnButton(btnNewCN, pbAdd);
                }
            }
            if (savetype == 2)
            {
                RJMessageBox.Show("Sửa thông tin thành công!", "Thành công", MessageBoxButtons.OK);
                DAO_ChiNhanh dAO_ChiNhanh = new DAO_ChiNhanh();
                Chinhanh.maChiNhanh = tbInputMacn.Text;
                Chinhanh.tenChiNhanh = tbInputTenCN.Text;
                Chinhanh.diaChi = tbInputDiachi.Text;
                Chinhanh.soDienThoai = tbInputSDT.Text;
                dAO_ChiNhanh.Update(Chinhanh);
                table_load();
            }

        }

        private void tbInputSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && Char.IsDigit(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 127)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void dgvChiNhanh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvChiNhanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            func.turnOnButton(btnUpdateCN, pbUpdate);
            func.turnOnButton(btnDeleteCN, pbDelete);
            func.turnOffButton(btnNewCN, pbAdd);
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvChiNhanh.Rows[e.RowIndex];
                DAO_ChiNhanh dAO_ChiNhanh = new DAO_ChiNhanh();
                Chinhanh = dAO_ChiNhanh.GetByID(row.Cells[1].Value.ToString());
                tbInputMacn.Text = Chinhanh.maChiNhanh;
                tbInputTenCN.Text = Chinhanh.tenChiNhanh;
                tbInputDiachi.Text = Chinhanh.diaChi;
                tbInputSDT.Text = Chinhanh.soDienThoai;
                func.turnOnButton(btnSaveCN, pbSave);

            }
        }

        private void btnUpdateCN_Click(object sender, EventArgs e)
        {
            savetype = 2;
            tbInputMacn.Enabled = false;
            tbInputTenCN.Enabled = true;
            tbInputSDT.Enabled = true;
            tbInputDiachi.Enabled = true;

        }

        private void btnDeleteCN_Click(object sender, EventArgs e)
        {
            var res = RJMessageBox.Show("Bạn có chắc muốn xóa chi nhánh này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                DAO_ChiNhanh dAO_ChiNhanh = new DAO_ChiNhanh();
                dAO_ChiNhanh.Delete(tbInputMacn.Text);
                table_load();
            }
            else
            {
                table_load();
            }
            tbInputMacn.Text = "";
            tbInputTenCN.Text = "";
            tbInputDiachi.Text = "";
            tbInputSDT.Text = "";
        }

        private void dgvChiNhanh_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExitCN_Click(object sender, EventArgs e)
        {
            tbInputMacn.Enabled = false;
            tbInputTenCN.Enabled = false;
            tbInputSDT.Enabled = false;
            tbInputDiachi.Enabled = false;
            func.turnOnButton(btnNewCN, pbAdd);
            func.turnOffButton(btnSaveCN, pbSave);
            func.turnOffButton(btnUpdateCN, pbUpdate);
            func.turnOffButton(btnDeleteCN, pbDelete);
            DAO_ChiNhanh CN = new DAO_ChiNhanh();
            tbInputMacn.Text = func.CreateID(CN.GetLast().maChiNhanh);
            tbInputTenCN.Text = "";
            tbInputDiachi.Text = "";
            tbInputSDT.Text = "";
        }
    }
}
