namespace WinFormApp.CustomControl
{
    partial class ucQuanLyXuatHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbChiNhanh = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoHD = new System.Windows.Forms.TextBox();
            this.btnDelete = new WinFormApp.RJButton();
            this.cbNhanVien = new System.Windows.Forms.ComboBox();
            this.btnExit = new WinFormApp.RJButton();
            this.cbKhachHang = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new WinFormApp.RJButton();
            this.btnChiTietHD = new WinFormApp.RJButton();
            this.btnSave = new WinFormApp.RJButton();
            this.btnNew = new WinFormApp.RJButton();
            this.dtpNgayHD = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHoaDonXuat = new System.Windows.Forms.DataGridView();
            this.txtNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNgayHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTraCuuHoaDon = new CustomControls.RJControls.RJTextBox();
            this.rjButton1 = new WinFormApp.RJButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbDelete = new System.Windows.Forms.PictureBox();
            this.pbUpdate = new System.Windows.Forms.PictureBox();
            this.pbSave = new System.Windows.Forms.PictureBox();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbChiNhanh);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtSoHD);
            this.panel1.Controls.Add(this.pbDelete);
            this.panel1.Controls.Add(this.pbUpdate);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.pbSave);
            this.panel1.Controls.Add(this.pbAdd);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.cbNhanVien);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.cbKhachHang);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnChiTietHD);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.dtpNgayHD);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(18, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1122, 340);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cbChiNhanh
            // 
            this.cbChiNhanh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChiNhanh.FormattingEnabled = true;
            this.cbChiNhanh.Location = new System.Drawing.Point(200, 119);
            this.cbChiNhanh.Name = "cbChiNhanh";
            this.cbChiNhanh.Size = new System.Drawing.Size(250, 34);
            this.cbChiNhanh.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(58, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 26);
            this.label8.TabIndex = 45;
            this.label8.Text = "Chi nhánh:";
            // 
            // txtSoHD
            // 
            this.txtSoHD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoHD.Location = new System.Drawing.Point(200, 66);
            this.txtSoHD.Name = "txtSoHD";
            this.txtSoHD.Size = new System.Drawing.Size(250, 30);
            this.txtSoHD.TabIndex = 44;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.btnDelete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.btnDelete.BorderColor = System.Drawing.Color.DimGray;
            this.btnDelete.BorderRadius = 0;
            this.btnDelete.BorderSize = 1;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(701, 270);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnDelete.Size = new System.Drawing.Size(157, 40);
            this.btnDelete.TabIndex = 42;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // cbNhanVien
            // 
            this.cbNhanVien.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNhanVien.FormattingEnabled = true;
            this.cbNhanVien.Location = new System.Drawing.Point(826, 119);
            this.cbNhanVien.Name = "cbNhanVien";
            this.cbNhanVien.Size = new System.Drawing.Size(250, 34);
            this.cbNhanVien.TabIndex = 17;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnExit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnExit.BorderColor = System.Drawing.Color.DimGray;
            this.btnExit.BorderRadius = 0;
            this.btnExit.BorderSize = 1;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(919, 270);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(53, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(157, 40);
            this.btnExit.TabIndex = 40;
            this.btnExit.Text = "Thoát";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextColor = System.Drawing.Color.White;
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // cbKhachHang
            // 
            this.cbKhachHang.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhachHang.FormattingEnabled = true;
            this.cbKhachHang.Location = new System.Drawing.Point(200, 181);
            this.cbKhachHang.Name = "cbKhachHang";
            this.cbKhachHang.Size = new System.Drawing.Size(250, 34);
            this.cbKhachHang.TabIndex = 16;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.btnUpdate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.btnUpdate.BorderColor = System.Drawing.Color.DimGray;
            this.btnUpdate.BorderRadius = 0;
            this.btnUpdate.BorderSize = 1;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(488, 270);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnUpdate.Size = new System.Drawing.Size(157, 40);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Chỉnh Sửa";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.TextColor = System.Drawing.Color.White;
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnChiTietHD
            // 
            this.btnChiTietHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnChiTietHD.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnChiTietHD.BorderColor = System.Drawing.Color.DimGray;
            this.btnChiTietHD.BorderRadius = 0;
            this.btnChiTietHD.BorderSize = 1;
            this.btnChiTietHD.FlatAppearance.BorderSize = 0;
            this.btnChiTietHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChiTietHD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTietHD.ForeColor = System.Drawing.Color.White;
            this.btnChiTietHD.Location = new System.Drawing.Point(701, 181);
            this.btnChiTietHD.Name = "btnChiTietHD";
            this.btnChiTietHD.Size = new System.Drawing.Size(375, 34);
            this.btnChiTietHD.TabIndex = 11;
            this.btnChiTietHD.Text = "Chi tiết hóa đơn";
            this.btnChiTietHD.TextColor = System.Drawing.Color.White;
            this.btnChiTietHD.UseVisualStyleBackColor = false;
            this.btnChiTietHD.Click += new System.EventHandler(this.btnChiTietHD_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.btnSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.btnSave.BorderColor = System.Drawing.Color.DimGray;
            this.btnSave.BorderRadius = 0;
            this.btnSave.BorderSize = 1;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(269, 270);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSave.Size = new System.Drawing.Size(157, 40);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Lưu Lại";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.btnNew.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.btnNew.BorderColor = System.Drawing.Color.DimGray;
            this.btnNew.BorderRadius = 0;
            this.btnNew.BorderSize = 1;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(56, 270);
            this.btnNew.Name = "btnNew";
            this.btnNew.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnNew.Size = new System.Drawing.Size(157, 40);
            this.btnNew.TabIndex = 9;
            this.btnNew.Text = "Thêm Mới";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.TextColor = System.Drawing.Color.White;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dtpNgayHD
            // 
            this.dtpNgayHD.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayHD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayHD.Location = new System.Drawing.Point(826, 66);
            this.dtpNgayHD.Name = "dtpNgayHD";
            this.dtpNgayHD.Size = new System.Drawing.Size(250, 34);
            this.dtpNgayHD.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(696, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ngày:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(696, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nhân viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Khách hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số HĐ:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1120, 50);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin hóa đơn xuất";
            // 
            // dgvHoaDonXuat
            // 
            this.dgvHoaDonXuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDonXuat.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoaDonXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDonXuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtNo,
            this.txtID,
            this.txtKhachHang,
            this.txtNgayHD,
            this.txtNhanVien,
            this.txtTongTien});
            this.dgvHoaDonXuat.Location = new System.Drawing.Point(19, 415);
            this.dgvHoaDonXuat.Name = "dgvHoaDonXuat";
            this.dgvHoaDonXuat.RowHeadersWidth = 51;
            this.dgvHoaDonXuat.RowTemplate.Height = 24;
            this.dgvHoaDonXuat.Size = new System.Drawing.Size(1121, 371);
            this.dgvHoaDonXuat.TabIndex = 1;
            // 
            // txtNo
            // 
            this.txtNo.HeaderText = "Số TT";
            this.txtNo.MinimumWidth = 6;
            this.txtNo.Name = "txtNo";
            this.txtNo.ReadOnly = true;
            // 
            // txtID
            // 
            this.txtID.HeaderText = "Số hóa đơn";
            this.txtID.MinimumWidth = 6;
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.HeaderText = "Khách hàng";
            this.txtKhachHang.MinimumWidth = 6;
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.ReadOnly = true;
            // 
            // txtNgayHD
            // 
            this.txtNgayHD.HeaderText = "Ngày lập HĐ";
            this.txtNgayHD.MinimumWidth = 6;
            this.txtNgayHD.Name = "txtNgayHD";
            this.txtNgayHD.ReadOnly = true;
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.HeaderText = "Nhân viên lập HĐ";
            this.txtNhanVien.MinimumWidth = 6;
            this.txtNhanVien.Name = "txtNhanVien";
            // 
            // txtTongTien
            // 
            this.txtTongTien.HeaderText = "Tổng tiền";
            this.txtTongTien.MinimumWidth = 6;
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(659, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 26);
            this.label6.TabIndex = 45;
            this.label6.Text = "Tra cứu số hóa đơn:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(19, 361);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(155, 34);
            this.dateTimePicker1.TabIndex = 45;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(210, 361);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(155, 34);
            this.dateTimePicker2.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(180, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 26);
            this.label7.TabIndex = 45;
            this.label7.Text = "~";
            // 
            // txtTraCuuHoaDon
            // 
            this.txtTraCuuHoaDon.BackColor = System.Drawing.Color.White;
            this.txtTraCuuHoaDon.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.txtTraCuuHoaDon.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTraCuuHoaDon.BorderSize = 2;
            this.txtTraCuuHoaDon.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTraCuuHoaDon.ForeColor = System.Drawing.Color.Black;
            this.txtTraCuuHoaDon.Location = new System.Drawing.Point(863, 359);
            this.txtTraCuuHoaDon.Multiline = false;
            this.txtTraCuuHoaDon.Name = "txtTraCuuHoaDon";
            this.txtTraCuuHoaDon.Padding = new System.Windows.Forms.Padding(7);
            this.txtTraCuuHoaDon.PasswordChar = false;
            this.txtTraCuuHoaDon.Size = new System.Drawing.Size(276, 34);
            this.txtTraCuuHoaDon.TabIndex = 2;
            this.txtTraCuuHoaDon.Texts = "";
            this.txtTraCuuHoaDon.UnderlinedStyle = true;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.rjButton1.BorderColor = System.Drawing.Color.DimGray;
            this.rjButton1.BorderRadius = 0;
            this.rjButton1.BorderSize = 1;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(401, 361);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(82, 34);
            this.rjButton1.TabIndex = 45;
            this.rjButton1.Text = "Lọc";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::WinFormApp.Properties.Resources.icon_search;
            this.pictureBox1.Location = new System.Drawing.Point(1111, 361);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // pbDelete
            // 
            this.pbDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.pbDelete.Image = global::WinFormApp.Properties.Resources.taoanhdep_icon_trash_alt_removebg_preview;
            this.pbDelete.Location = new System.Drawing.Point(720, 272);
            this.pbDelete.Name = "pbDelete";
            this.pbDelete.Size = new System.Drawing.Size(31, 31);
            this.pbDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDelete.TabIndex = 43;
            this.pbDelete.TabStop = false;
            // 
            // pbUpdate
            // 
            this.pbUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.pbUpdate.Image = global::WinFormApp.Properties.Resources.icon_edit;
            this.pbUpdate.Location = new System.Drawing.Point(511, 275);
            this.pbUpdate.Name = "pbUpdate";
            this.pbUpdate.Size = new System.Drawing.Size(28, 28);
            this.pbUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUpdate.TabIndex = 20;
            this.pbUpdate.TabStop = false;
            // 
            // pbSave
            // 
            this.pbSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.pbSave.Image = global::WinFormApp.Properties.Resources.icon_save;
            this.pbSave.Location = new System.Drawing.Point(292, 275);
            this.pbSave.Name = "pbSave";
            this.pbSave.Size = new System.Drawing.Size(28, 28);
            this.pbSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSave.TabIndex = 19;
            this.pbSave.TabStop = false;
            // 
            // pbAdd
            // 
            this.pbAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.pbAdd.Image = global::WinFormApp.Properties.Resources.icon_add2;
            this.pbAdd.Location = new System.Drawing.Point(80, 275);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(28, 28);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAdd.TabIndex = 18;
            this.pbAdd.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.pictureBox5.Image = global::WinFormApp.Properties.Resources.icon_close;
            this.pictureBox5.Location = new System.Drawing.Point(945, 275);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(26, 26);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 41;
            this.pictureBox5.TabStop = false;
            // 
            // ucQuanLyXuatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTraCuuHoaDon);
            this.Controls.Add(this.dgvHoaDonXuat);
            this.Controls.Add(this.panel1);
            this.Name = "ucQuanLyXuatHang";
            this.Size = new System.Drawing.Size(1153, 803);
            this.Load += new System.EventHandler(this.ucQuanLyXuatHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHoaDonXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNgayHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgayHD;
        private System.Windows.Forms.Label label5;
        private RJButton btnUpdate;
        private RJButton btnChiTietHD;
        private RJButton btnSave;
        private RJButton btnNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTongTien;
        private System.Windows.Forms.ComboBox cbKhachHang;
        private System.Windows.Forms.ComboBox cbNhanVien;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.PictureBox pbSave;
        private System.Windows.Forms.PictureBox pbUpdate;
        private System.Windows.Forms.PictureBox pbDelete;
        private RJButton btnDelete;
        private System.Windows.Forms.PictureBox pictureBox5;
        private RJButton btnExit;
        private System.Windows.Forms.TextBox txtSoHD;
        private CustomControls.RJControls.RJTextBox txtTraCuuHoaDon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label7;
        private RJButton rjButton1;
        private System.Windows.Forms.ComboBox cbChiNhanh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
