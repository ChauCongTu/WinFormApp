namespace WinFormApp.CustomControl
{
    partial class ucKhoXe
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
            this.dgvKhoXe = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbLoaiXe = new System.Windows.Forms.ComboBox();
            this.txtSoKhung = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbChiNhanh = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnXemChiTiet = new WinFormApp.RJButton();
            this.pbDelete = new System.Windows.Forms.PictureBox();
            this.pbUpdate = new System.Windows.Forms.PictureBox();
            this.btnDelete = new WinFormApp.RJButton();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnExit = new WinFormApp.RJButton();
            this.btnUpdate = new WinFormApp.RJButton();
            this.btnNew = new WinFormApp.RJButton();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtTenXe = new System.Windows.Forms.TextBox();
            this.txtMaXe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTraCuuHoaDon = new CustomControls.RJControls.RJTextBox();
            this._stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMaXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTenXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoXe)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKhoXe
            // 
            this.dgvKhoXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhoXe.BackgroundColor = System.Drawing.Color.White;
            this.dgvKhoXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoXe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._stt,
            this.ColMaXe,
            this.ColTenXe,
            this.ColSL,
            this.ColDG,
            this.ColMoTa});
            this.dgvKhoXe.Location = new System.Drawing.Point(16, 412);
            this.dgvKhoXe.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKhoXe.Name = "dgvKhoXe";
            this.dgvKhoXe.ReadOnly = true;
            this.dgvKhoXe.RowHeadersWidth = 51;
            this.dgvKhoXe.Size = new System.Drawing.Size(1121, 383);
            this.dgvKhoXe.TabIndex = 5;
            this.dgvKhoXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhoXe_CellClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cbLoaiXe);
            this.panel2.Controls.Add(this.txtSoKhung);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cbChiNhanh);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnXemChiTiet);
            this.panel2.Controls.Add(this.pbDelete);
            this.panel2.Controls.Add(this.pbUpdate);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.pbAdd);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnNew);
            this.panel2.Controls.Add(this.txtDonGia);
            this.panel2.Controls.Add(this.txtTenXe);
            this.panel2.Controls.Add(this.txtMaXe);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(16, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1121, 351);
            this.panel2.TabIndex = 4;
            // 
            // cbLoaiXe
            // 
            this.cbLoaiXe.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiXe.FormattingEnabled = true;
            this.cbLoaiXe.Items.AddRange(new object[] {
            "Xe số",
            "Xe côn tay",
            "Xe tay ga"});
            this.cbLoaiXe.Location = new System.Drawing.Point(736, 173);
            this.cbLoaiXe.Name = "cbLoaiXe";
            this.cbLoaiXe.Size = new System.Drawing.Size(250, 34);
            this.cbLoaiXe.TabIndex = 72;
            this.cbLoaiXe.Text = "-- Chọn loại xe --";
            // 
            // txtSoKhung
            // 
            this.txtSoKhung.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoKhung.Location = new System.Drawing.Point(249, 226);
            this.txtSoKhung.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoKhung.Name = "txtSoKhung";
            this.txtSoKhung.Size = new System.Drawing.Size(249, 34);
            this.txtSoKhung.TabIndex = 71;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.875F);
            this.label7.Location = new System.Drawing.Point(127, 231);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 26);
            this.label7.TabIndex = 70;
            this.label7.Text = "Số khung:";
            // 
            // cbChiNhanh
            // 
            this.cbChiNhanh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChiNhanh.FormattingEnabled = true;
            this.cbChiNhanh.Location = new System.Drawing.Point(482, 65);
            this.cbChiNhanh.Name = "cbChiNhanh";
            this.cbChiNhanh.Size = new System.Drawing.Size(250, 34);
            this.cbChiNhanh.TabIndex = 69;
            this.cbChiNhanh.SelectedValueChanged += new System.EventHandler(this.cbNhanVien_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.875F);
            this.label6.Location = new System.Drawing.Point(299, 73);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 26);
            this.label6.TabIndex = 66;
            this.label6.Text = "Chọn chi nhánh:";
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.btnXemChiTiet.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.btnXemChiTiet.BorderColor = System.Drawing.Color.DimGray;
            this.btnXemChiTiet.BorderRadius = 0;
            this.btnXemChiTiet.BorderSize = 1;
            this.btnXemChiTiet.FlatAppearance.BorderSize = 0;
            this.btnXemChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemChiTiet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemChiTiet.ForeColor = System.Drawing.Color.White;
            this.btnXemChiTiet.Location = new System.Drawing.Point(598, 228);
            this.btnXemChiTiet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(387, 34);
            this.btnXemChiTiet.TabIndex = 65;
            this.btnXemChiTiet.Text = "Xem Chi Tiết";
            this.btnXemChiTiet.TextColor = System.Drawing.Color.White;
            this.btnXemChiTiet.UseVisualStyleBackColor = false;
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // pbDelete
            // 
            this.pbDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.pbDelete.Image = global::WinFormApp.Properties.Resources.taoanhdep_icon_trash_alt_removebg_preview;
            this.pbDelete.Location = new System.Drawing.Point(601, 300);
            this.pbDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbDelete.Name = "pbDelete";
            this.pbDelete.Size = new System.Drawing.Size(31, 31);
            this.pbDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDelete.TabIndex = 64;
            this.pbDelete.TabStop = false;
            // 
            // pbUpdate
            // 
            this.pbUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.pbUpdate.Image = global::WinFormApp.Properties.Resources.icon_edit;
            this.pbUpdate.Location = new System.Drawing.Point(388, 300);
            this.pbUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbUpdate.Name = "pbUpdate";
            this.pbUpdate.Size = new System.Drawing.Size(28, 28);
            this.pbUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUpdate.TabIndex = 60;
            this.pbUpdate.TabStop = false;
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
            this.btnDelete.Location = new System.Drawing.Point(579, 295);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(51, 0, 0, 0);
            this.btnDelete.Size = new System.Drawing.Size(157, 39);
            this.btnDelete.TabIndex = 63;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pbAdd
            // 
            this.pbAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.pbAdd.Image = global::WinFormApp.Properties.Resources.icon_add2;
            this.pbAdd.Location = new System.Drawing.Point(170, 300);
            this.pbAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(28, 28);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAdd.TabIndex = 58;
            this.pbAdd.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.pictureBox5.Image = global::WinFormApp.Properties.Resources.icon_close;
            this.pictureBox5.Location = new System.Drawing.Point(823, 300);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(27, 26);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 62;
            this.pictureBox5.TabStop = false;
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
            this.btnExit.Location = new System.Drawing.Point(797, 295);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(53, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(157, 39);
            this.btnExit.TabIndex = 61;
            this.btnExit.Text = "Thoát";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextColor = System.Drawing.Color.White;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            this.btnUpdate.Location = new System.Drawing.Point(365, 295);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(51, 0, 0, 0);
            this.btnUpdate.Size = new System.Drawing.Size(157, 39);
            this.btnUpdate.TabIndex = 57;
            this.btnUpdate.Text = "Chỉnh Sửa";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.TextColor = System.Drawing.Color.White;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.btnNew.Location = new System.Drawing.Point(147, 295);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Padding = new System.Windows.Forms.Padding(51, 0, 0, 0);
            this.btnNew.Size = new System.Drawing.Size(157, 39);
            this.btnNew.TabIndex = 55;
            this.btnNew.Text = "Thêm Mới";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.TextColor = System.Drawing.Color.White;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(736, 130);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(249, 34);
            this.txtDonGia.TabIndex = 11;
            // 
            // txtTenXe
            // 
            this.txtTenXe.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenXe.Location = new System.Drawing.Point(249, 173);
            this.txtTenXe.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenXe.Name = "txtTenXe";
            this.txtTenXe.Size = new System.Drawing.Size(249, 34);
            this.txtTenXe.TabIndex = 9;
            // 
            // txtMaXe
            // 
            this.txtMaXe.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaXe.Location = new System.Drawing.Point(249, 128);
            this.txtMaXe.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaXe.Name = "txtMaXe";
            this.txtMaXe.Size = new System.Drawing.Size(249, 34);
            this.txtMaXe.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.875F);
            this.label5.Location = new System.Drawing.Point(593, 133);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Đơn giá:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.875F);
            this.label4.Location = new System.Drawing.Point(593, 181);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Loại xe:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.875F);
            this.label3.Location = new System.Drawing.Point(127, 181);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên xe:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.875F);
            this.label2.Location = new System.Drawing.Point(127, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã SP:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1119, 50);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WinFormApp.Properties.Resources.KhoXe1_removebg_preview;
            this.pictureBox3.Location = new System.Drawing.Point(22, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 43);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(75, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý kho xe";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::WinFormApp.Properties.Resources.icon_search;
            this.pictureBox1.Location = new System.Drawing.Point(1108, 366);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(648, 374);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 26);
            this.label8.TabIndex = 73;
            this.label8.Text = "Tra cứu phương tiện:";
            // 
            // txtTraCuuHoaDon
            // 
            this.txtTraCuuHoaDon.BackColor = System.Drawing.Color.White;
            this.txtTraCuuHoaDon.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.txtTraCuuHoaDon.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTraCuuHoaDon.BorderSize = 2;
            this.txtTraCuuHoaDon.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTraCuuHoaDon.ForeColor = System.Drawing.Color.Black;
            this.txtTraCuuHoaDon.Location = new System.Drawing.Point(860, 366);
            this.txtTraCuuHoaDon.Multiline = false;
            this.txtTraCuuHoaDon.Name = "txtTraCuuHoaDon";
            this.txtTraCuuHoaDon.Padding = new System.Windows.Forms.Padding(7);
            this.txtTraCuuHoaDon.PasswordChar = false;
            this.txtTraCuuHoaDon.Size = new System.Drawing.Size(276, 34);
            this.txtTraCuuHoaDon.TabIndex = 72;
            this.txtTraCuuHoaDon.Texts = "";
            this.txtTraCuuHoaDon.UnderlinedStyle = true;
            // 
            // _stt
            // 
            this._stt.HeaderText = "Số TT";
            this._stt.MinimumWidth = 6;
            this._stt.Name = "_stt";
            this._stt.ReadOnly = true;
            // 
            // ColMaXe
            // 
            this.ColMaXe.HeaderText = "Mã sản phẩm";
            this.ColMaXe.MinimumWidth = 6;
            this.ColMaXe.Name = "ColMaXe";
            this.ColMaXe.ReadOnly = true;
            // 
            // ColTenXe
            // 
            this.ColTenXe.HeaderText = "Tên Xe";
            this.ColTenXe.MinimumWidth = 6;
            this.ColTenXe.Name = "ColTenXe";
            this.ColTenXe.ReadOnly = true;
            // 
            // ColSL
            // 
            this.ColSL.HeaderText = "Loại Xe";
            this.ColSL.MinimumWidth = 6;
            this.ColSL.Name = "ColSL";
            this.ColSL.ReadOnly = true;
            // 
            // ColDG
            // 
            this.ColDG.HeaderText = "Đơn Giá";
            this.ColDG.MinimumWidth = 6;
            this.ColDG.Name = "ColDG";
            this.ColDG.ReadOnly = true;
            // 
            // ColMoTa
            // 
            this.ColMoTa.HeaderText = "Số khung";
            this.ColMoTa.MinimumWidth = 6;
            this.ColMoTa.Name = "ColMoTa";
            this.ColMoTa.ReadOnly = true;
            // 
            // ucKhoXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvKhoXe);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtTraCuuHoaDon);
            this.Name = "ucKhoXe";
            this.Size = new System.Drawing.Size(1153, 803);
            this.Load += new System.EventHandler(this.ucKhoXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoXe)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKhoXe;
        private System.Windows.Forms.Panel panel2;
        private RJButton btnXemChiTiet;
        private System.Windows.Forms.PictureBox pbDelete;
        private System.Windows.Forms.PictureBox pbUpdate;
        private RJButton btnDelete;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.PictureBox pictureBox5;
        private RJButton btnExit;
        private RJButton btnUpdate;
        private RJButton btnNew;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtTenXe;
        private System.Windows.Forms.TextBox txtMaXe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbChiNhanh;
        private System.Windows.Forms.TextBox txtSoKhung;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private CustomControls.RJControls.RJTextBox txtTraCuuHoaDon;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox cbLoaiXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn _stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTenXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMoTa;
    }
}
