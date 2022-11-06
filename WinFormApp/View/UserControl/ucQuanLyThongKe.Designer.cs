namespace WinFormApp.CustomControl
{
    partial class ucQuanLyThongKe
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnThisMonth = new System.Windows.Forms.Button();
            this.btnLast30Days = new System.Windows.Forms.Button();
            this.btnLast7Days = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.btnCustomDate = new System.Windows.Forms.Button();
            this.btnOkCustomDate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNumberOfOrders = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTotalRevenue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbTotalProfit = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbNumberOfCustomers = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbNumberOfSuppliers = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNumberOfProducts = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvUnderStocks = new System.Windows.Forms.DataGridView();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnderStocks)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.panel4.Controls.Add(this.btnOkCustomDate);
            this.panel4.Controls.Add(this.btnCustomDate);
            this.panel4.Controls.Add(this.btnToday);
            this.panel4.Controls.Add(this.btnLast7Days);
            this.panel4.Controls.Add(this.btnLast30Days);
            this.panel4.Controls.Add(this.btnThisMonth);
            this.panel4.Controls.Add(this.dtpEndDate);
            this.panel4.Controls.Add(this.dtpStartDate);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1210, 41);
            this.panel4.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(10, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Thống kê";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "MMM dd,yyyy";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(117, 9);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(119, 20);
            this.dtpStartDate.TabIndex = 1;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "MMM dd,yyyy";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(265, 9);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(114, 20);
            this.dtpEndDate.TabIndex = 2;
            // 
            // btnThisMonth
            // 
            this.btnThisMonth.Location = new System.Drawing.Point(1077, 6);
            this.btnThisMonth.Name = "btnThisMonth";
            this.btnThisMonth.Size = new System.Drawing.Size(120, 30);
            this.btnThisMonth.TabIndex = 3;
            this.btnThisMonth.Text = "This Month";
            this.btnThisMonth.UseVisualStyleBackColor = true;
            // 
            // btnLast30Days
            // 
            this.btnLast30Days.Location = new System.Drawing.Point(951, 6);
            this.btnLast30Days.Name = "btnLast30Days";
            this.btnLast30Days.Size = new System.Drawing.Size(120, 30);
            this.btnLast30Days.TabIndex = 4;
            this.btnLast30Days.Text = "Last 30 Days";
            this.btnLast30Days.UseVisualStyleBackColor = true;
            // 
            // btnLast7Days
            // 
            this.btnLast7Days.Location = new System.Drawing.Point(825, 6);
            this.btnLast7Days.Name = "btnLast7Days";
            this.btnLast7Days.Size = new System.Drawing.Size(120, 30);
            this.btnLast7Days.TabIndex = 5;
            this.btnLast7Days.Text = "Last 7 Days";
            this.btnLast7Days.UseVisualStyleBackColor = true;
            // 
            // btnToday
            // 
            this.btnToday.Location = new System.Drawing.Point(699, 6);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(120, 30);
            this.btnToday.TabIndex = 6;
            this.btnToday.Text = "Today";
            this.btnToday.UseVisualStyleBackColor = true;
            // 
            // btnCustomDate
            // 
            this.btnCustomDate.Location = new System.Drawing.Point(573, 6);
            this.btnCustomDate.Name = "btnCustomDate";
            this.btnCustomDate.Size = new System.Drawing.Size(120, 30);
            this.btnCustomDate.TabIndex = 7;
            this.btnCustomDate.Text = "Custom";
            this.btnCustomDate.UseVisualStyleBackColor = true;
            // 
            // btnOkCustomDate
            // 
            this.btnOkCustomDate.Location = new System.Drawing.Point(543, 6);
            this.btnOkCustomDate.Name = "btnOkCustomDate";
            this.btnOkCustomDate.Size = new System.Drawing.Size(30, 30);
            this.btnOkCustomDate.TabIndex = 53;
            this.btnOkCustomDate.Text = "ok";
            this.btnOkCustomDate.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbNumberOfOrders);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 67);
            this.panel1.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of orders";
            // 
            // lbNumberOfOrders
            // 
            this.lbNumberOfOrders.AutoSize = true;
            this.lbNumberOfOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumberOfOrders.Location = new System.Drawing.Point(17, 13);
            this.lbNumberOfOrders.Name = "lbNumberOfOrders";
            this.lbNumberOfOrders.Size = new System.Drawing.Size(67, 25);
            this.lbNumberOfOrders.TabIndex = 1;
            this.lbNumberOfOrders.Text = "10000";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lbTotalRevenue);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(209, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(412, 67);
            this.panel2.TabIndex = 54;
            // 
            // lbTotalRevenue
            // 
            this.lbTotalRevenue.AutoSize = true;
            this.lbTotalRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalRevenue.Location = new System.Drawing.Point(17, 13);
            this.lbTotalRevenue.Name = "lbTotalRevenue";
            this.lbTotalRevenue.Size = new System.Drawing.Size(78, 25);
            this.lbTotalRevenue.TabIndex = 1;
            this.lbTotalRevenue.Text = "100000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Revenue";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lbTotalProfit);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(627, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(583, 67);
            this.panel3.TabIndex = 55;
            // 
            // lbTotalProfit
            // 
            this.lbTotalProfit.AutoSize = true;
            this.lbTotalProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalProfit.Location = new System.Drawing.Point(17, 13);
            this.lbTotalProfit.Name = "lbTotalProfit";
            this.lbTotalProfit.Size = new System.Drawing.Size(78, 25);
            this.lbTotalProfit.TabIndex = 1;
            this.lbTotalProfit.Text = "100000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Profit";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(4, 119);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(736, 300);
            this.chart1.TabIndex = 56;
            this.chart1.Text = "chartGrossRevenue";
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title1.Name = "Title1";
            title1.Text = "Gross Revenue";
            this.chart1.Titles.Add(title1);
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(746, 119);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            series2.IsValueShownAsLabel = true;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(464, 517);
            this.chart2.TabIndex = 57;
            this.chart2.Text = "chartTop5Products";
            title2.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title2.Name = "Title1";
            title2.Text = "Top 5 Products";
            this.chart2.Titles.Add(title2);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.lbNumberOfProducts);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.lbNumberOfSuppliers);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.lbNumberOfCustomers);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(4, 425);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 224);
            this.panel5.TabIndex = 58;
            // 
            // lbNumberOfCustomers
            // 
            this.lbNumberOfCustomers.AutoSize = true;
            this.lbNumberOfCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumberOfCustomers.Location = new System.Drawing.Point(16, 59);
            this.lbNumberOfCustomers.Name = "lbNumberOfCustomers";
            this.lbNumberOfCustomers.Size = new System.Drawing.Size(67, 25);
            this.lbNumberOfCustomers.TabIndex = 1;
            this.lbNumberOfCustomers.Text = "10000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Number of customers";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Total Counter";
            // 
            // lbNumberOfSuppliers
            // 
            this.lbNumberOfSuppliers.AutoSize = true;
            this.lbNumberOfSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumberOfSuppliers.Location = new System.Drawing.Point(16, 113);
            this.lbNumberOfSuppliers.Name = "lbNumberOfSuppliers";
            this.lbNumberOfSuppliers.Size = new System.Drawing.Size(67, 25);
            this.lbNumberOfSuppliers.TabIndex = 4;
            this.lbNumberOfSuppliers.Text = "10000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Number of Suppliers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of Products";
            // 
            // lbNumberOfProducts
            // 
            this.lbNumberOfProducts.AutoSize = true;
            this.lbNumberOfProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumberOfProducts.Location = new System.Drawing.Point(14, 173);
            this.lbNumberOfProducts.Name = "lbNumberOfProducts";
            this.lbNumberOfProducts.Size = new System.Drawing.Size(67, 25);
            this.lbNumberOfProducts.TabIndex = 4;
            this.lbNumberOfProducts.Text = "10000";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.dgvUnderStocks);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Location = new System.Drawing.Point(210, 425);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(530, 224);
            this.panel6.TabIndex = 59;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(193, 25);
            this.label13.TabIndex = 2;
            this.label13.Text = "Products Understock";
            // 
            // dgvUnderStocks
            // 
            this.dgvUnderStocks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUnderStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnderStocks.Location = new System.Drawing.Point(8, 28);
            this.dgvUnderStocks.Name = "dgvUnderStocks";
            this.dgvUnderStocks.Size = new System.Drawing.Size(504, 183);
            this.dgvUnderStocks.TabIndex = 3;
            // 
            // ucQuanLyThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ucQuanLyThongKe";
            this.Size = new System.Drawing.Size(1210, 652);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnderStocks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Button btnOkCustomDate;
        private System.Windows.Forms.Button btnCustomDate;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button btnLast7Days;
        private System.Windows.Forms.Button btnLast30Days;
        private System.Windows.Forms.Button btnThisMonth;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbNumberOfOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTotalRevenue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbTotalProfit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbNumberOfProducts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbNumberOfSuppliers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbNumberOfCustomers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgvUnderStocks;
        private System.Windows.Forms.Label label13;
    }
}
