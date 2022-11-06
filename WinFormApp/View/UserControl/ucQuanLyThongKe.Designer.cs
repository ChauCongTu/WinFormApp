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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title11 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title12 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCustomDate = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.btnLast7Days = new System.Windows.Forms.Button();
            this.btnLast30Days = new System.Windows.Forms.Button();
            this.btnThisMonth = new System.Windows.Forms.Button();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbNumberOfOrders = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTotalRevenue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbTotalProfit = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chartGrossRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTop5Products = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbNumberOfProducts = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNumberOfSuppliers = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbNumberOfCustomers = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvUnderStocks = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.btnLastMonth = new System.Windows.Forms.Button();
            this.btnLast90Days = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrossRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTop5Products)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnderStocks)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.panel4.Controls.Add(this.btnLast90Days);
            this.panel4.Controls.Add(this.btnLastMonth);
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
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(855, 41);
            this.panel4.TabIndex = 52;
            // 
            // btnCustomDate
            // 
            this.btnCustomDate.AutoSize = true;
            this.btnCustomDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomDate.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnCustomDate.Location = new System.Drawing.Point(463, 9);
            this.btnCustomDate.Name = "btnCustomDate";
            this.btnCustomDate.Size = new System.Drawing.Size(80, 25);
            this.btnCustomDate.TabIndex = 7;
            this.btnCustomDate.Text = "Tùy chỉnh";
            this.btnCustomDate.UseVisualStyleBackColor = true;
            // 
            // btnToday
            // 
            this.btnToday.AutoSize = true;
            this.btnToday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToday.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnToday.Location = new System.Drawing.Point(541, 9);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(61, 25);
            this.btnToday.TabIndex = 6;
            this.btnToday.Text = "Hôm nay";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // btnLast7Days
            // 
            this.btnLast7Days.AutoSize = true;
            this.btnLast7Days.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.btnLast7Days.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLast7Days.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuText;
            this.btnLast7Days.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast7Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast7Days.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnLast7Days.Location = new System.Drawing.Point(600, 9);
            this.btnLast7Days.Name = "btnLast7Days";
            this.btnLast7Days.Size = new System.Drawing.Size(80, 25);
            this.btnLast7Days.TabIndex = 5;
            this.btnLast7Days.Text = "7 ngày trước";
            this.btnLast7Days.UseVisualStyleBackColor = false;
            this.btnLast7Days.Click += new System.EventHandler(this.btnLast7Days_Click);
            // 
            // btnLast30Days
            // 
            this.btnLast30Days.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast30Days.Location = new System.Drawing.Point(958, 6);
            this.btnLast30Days.Name = "btnLast30Days";
            this.btnLast30Days.Size = new System.Drawing.Size(120, 30);
            this.btnLast30Days.TabIndex = 4;
            this.btnLast30Days.Text = "30 ngày trước";
            this.btnLast30Days.UseVisualStyleBackColor = true;
            // 
            // btnThisMonth
            // 
            this.btnThisMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThisMonth.Location = new System.Drawing.Point(1077, 6);
            this.btnThisMonth.Name = "btnThisMonth";
            this.btnThisMonth.Size = new System.Drawing.Size(120, 30);
            this.btnThisMonth.TabIndex = 3;
            this.btnThisMonth.Text = "Tháng này";
            this.btnThisMonth.UseVisualStyleBackColor = true;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "MMM dd,yyyy";
            this.dtpEndDate.Enabled = false;
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(253, 9);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(114, 20);
            this.dtpEndDate.TabIndex = 2;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "MMM dd,yyyy";
            this.dtpStartDate.Enabled = false;
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(117, 9);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(119, 20);
            this.dtpStartDate.TabIndex = 1;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số lượng đơn hàng";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lbTotalRevenue);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(209, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 67);
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
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tổng doanh thu";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lbTotalProfit);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(406, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(449, 67);
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
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tổng lợi nhuận";
            // 
            // chartGrossRevenue
            // 
            chartArea11.AxisX.LineColor = System.Drawing.Color.Transparent;
            chartArea11.AxisX.LineWidth = 0;
            chartArea11.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea11.AxisX.MajorGrid.LineWidth = 0;
            chartArea11.AxisY.LineColor = System.Drawing.Color.White;
            chartArea11.AxisY.LineWidth = 0;
            chartArea11.BackColor = System.Drawing.Color.White;
            chartArea11.Name = "ChartArea1";
            this.chartGrossRevenue.ChartAreas.Add(chartArea11);
            legend11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            legend11.BorderColor = System.Drawing.Color.White;
            legend11.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend11.ForeColor = System.Drawing.Color.White;
            legend11.Name = "Legend1";
            this.chartGrossRevenue.Legends.Add(legend11);
            this.chartGrossRevenue.Location = new System.Drawing.Point(4, 119);
            this.chartGrossRevenue.Name = "chartGrossRevenue";
            series11.BorderColor = System.Drawing.Color.White;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series11.Color = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            series11.Legend = "Legend1";
            series11.Name = "Tháng";
            series11.YValuesPerPoint = 2;
            this.chartGrossRevenue.Series.Add(series11);
            this.chartGrossRevenue.Size = new System.Drawing.Size(500, 300);
            this.chartGrossRevenue.TabIndex = 56;
            this.chartGrossRevenue.Text = "chartGrossRevenue";
            title11.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title11.Name = "Title1";
            title11.Text = "Tổng doanh thu";
            this.chartGrossRevenue.Titles.Add(title11);
            // 
            // chartTop5Products
            // 
            chartArea12.Name = "ChartArea1";
            this.chartTop5Products.ChartAreas.Add(chartArea12);
            legend12.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend12.Name = "Legend1";
            this.chartTop5Products.Legends.Add(legend12);
            this.chartTop5Products.Location = new System.Drawing.Point(510, 116);
            this.chartTop5Products.Name = "chartTop5Products";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            series12.IsValueShownAsLabel = true;
            series12.LabelForeColor = System.Drawing.Color.White;
            series12.Legend = "Legend1";
            series12.Name = "Series1";
            this.chartTop5Products.Series.Add(series12);
            this.chartTop5Products.Size = new System.Drawing.Size(345, 530);
            this.chartTop5Products.TabIndex = 57;
            this.chartTop5Products.Text = "chartTop5Products";
            title12.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title12.Name = "Title1";
            title12.Text = "Top 5 sản phẩm bán chạy";
            this.chartTop5Products.Titles.Add(title12);
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
            this.panel5.Size = new System.Drawing.Size(179, 224);
            this.panel5.TabIndex = 58;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số sản phẩm";
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
            this.label8.Size = new System.Drawing.Size(120, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Số lượng người đăng ký";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tổng";
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
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số lượng khách hàng";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.dgvUnderStocks);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Location = new System.Drawing.Point(189, 425);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(315, 224);
            this.panel6.TabIndex = 59;
            // 
            // dgvUnderStocks
            // 
            this.dgvUnderStocks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUnderStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnderStocks.Location = new System.Drawing.Point(8, 28);
            this.dgvUnderStocks.Name = "dgvUnderStocks";
            this.dgvUnderStocks.Size = new System.Drawing.Size(304, 183);
            this.dgvUnderStocks.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(221, 25);
            this.label13.TabIndex = 2;
            this.label13.Text = "Sản phẩm gần hết hàng";
            // 
            // btnLastMonth
            // 
            this.btnLastMonth.AutoSize = true;
            this.btnLastMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLastMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLastMonth.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnLastMonth.Location = new System.Drawing.Point(677, 9);
            this.btnLastMonth.Name = "btnLastMonth";
            this.btnLastMonth.Size = new System.Drawing.Size(82, 25);
            this.btnLastMonth.TabIndex = 8;
            this.btnLastMonth.Text = "1 tháng trước";
            this.btnLastMonth.UseVisualStyleBackColor = true;
            this.btnLastMonth.Click += new System.EventHandler(this.btnLastMonth_Click);
            // 
            // btnLast90Days
            // 
            this.btnLast90Days.AutoSize = true;
            this.btnLast90Days.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLast90Days.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast90Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast90Days.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnLast90Days.Location = new System.Drawing.Point(758, 9);
            this.btnLast90Days.Name = "btnLast90Days";
            this.btnLast90Days.Size = new System.Drawing.Size(84, 25);
            this.btnLast90Days.TabIndex = 9;
            this.btnLast90Days.Text = "90 ngày trước";
            this.btnLast90Days.UseVisualStyleBackColor = true;
            this.btnLast90Days.Click += new System.EventHandler(this.btnLast90Days_Click);
            // 
            // ucQuanLyThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.chartTop5Products);
            this.Controls.Add(this.chartGrossRevenue);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucQuanLyThongKe";
            this.Size = new System.Drawing.Size(855, 652);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrossRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTop5Products)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGrossRevenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTop5Products;
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
        private System.Windows.Forms.Button btnLast90Days;
        private System.Windows.Forms.Button btnLastMonth;
    }
}
