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

namespace WinFormApp.CustomControl
{
    public partial class ucQuanLyThongKe : UserControl
    {
        private Dashboard repository;
        public ucQuanLyThongKe()
        {
            InitializeComponent();
            dtpStartDate.Value = DateTime.Today.AddDays(-365);
            dtpEndDate.Value = DateTime.Now;
            btnLast7Days.Select();

            this.repository = new Dashboard();
            LoadData();
        }

        private void LoadData()
        {
            var refreshData = this.repository.LoadData(dtpStartDate.Value, dtpEndDate.Value);
            if(refreshData)
            {
                lbNumberOfOrders.Text = this.repository.NumOrders.ToString();
                lbTotalRevenue.Text = "$" + this.repository.TotalRevenue.ToString();
                lbTotalProfit.Text = "$" + this.repository.TotalProfit.ToString();

                lbNumberOfCustomers.Text = this.repository.NumCustomers.ToString();
                lbNumberOfSuppliers.Text = this.repository.NumSuppliers.ToString();
                lbNumberOfProducts.Text = this.repository.NumProducts.ToString();

                chartGrossRevenue.DataSource = this.repository.GrossRevenueList;
                chartGrossRevenue.Series[0].XValueMember = "Date";
                chartGrossRevenue.Series[0].YValueMembers = "TotalAmount";
                chartGrossRevenue.DataBind();

                chartTop5Products.DataSource = this.repository.TopProductsList;
                chartTop5Products.Series[0].XValueMember = "Key";
                chartTop5Products.Series[0].YValueMembers = "Value";
                chartTop5Products.DataBind();

                dgvUnderStocks.DataSource = this.repository.UnderStockList;
                dgvUnderStocks.Columns[0].HeaderText = "Sản phẩm";
                dgvUnderStocks.Columns[1].HeaderText = "Tồn kho";

                Console.WriteLine("Loaded view");
            }
            else
            {
                Console.WriteLine("View not loaded");
            }
        }

        private void cbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
