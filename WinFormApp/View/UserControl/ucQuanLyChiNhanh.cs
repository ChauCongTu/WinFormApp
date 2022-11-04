using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormApp.View;

namespace WinFormApp.CustomControl
{
    public partial class ucQuanLyChiNhanh : UserControl
    {
        Functions func = new Functions();
        public ucQuanLyChiNhanh()
        {
            InitializeComponent();
        }

        private void ucQuanLyChiNhanh_Load(object sender, EventArgs e)
        {
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
            tbInputMacn.Enabled = true;
            tbInputTenCN.Enabled = true;
            tbInputSDT.Enabled = true;

            tbInputDiachi.Enabled = true;
            func.turnOffButton(btnNewCN, pbAdd);
            func.turnOnButton(btnSaveCN, pbSave);

        }

        private void btnSaveCN_Click(object sender, EventArgs e)
        {
            if (tbInputMacn.Text == "" || tbInputTenCN.Text == "" || tbInputDiachi.Text == "" || tbInputSDT.Text == "")
            {
                RJMessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Có lỗi xảy ra", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {

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
        }
    }
}
