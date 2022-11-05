namespace WinFormApp.CustomControl
{
    partial class ucNhanVien
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
            this.pbsave = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.pbcancel = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.pbedit = new System.Windows.Forms.PictureBox();
            this.pbdelete = new System.Windows.Forms.PictureBox();
            this.pbadd = new System.Windows.Forms.PictureBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.cbChucvu = new System.Windows.Forms.ComboBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtSodienthoai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtbNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtManhanvien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_Ten = new System.Windows.Forms.Label();
            this.lb_Manv = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cbGioitinh = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbsave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbedit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbdelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbadd)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbGioitinh);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pbsave);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.pbcancel);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btn_thoat);
            this.panel1.Controls.Add(this.pbedit);
            this.panel1.Controls.Add(this.pbdelete);
            this.panel1.Controls.Add(this.pbadd);
            this.panel1.Controls.Add(this.btn_xoa);
            this.panel1.Controls.Add(this.btn_sua);
            this.panel1.Controls.Add(this.btn_them);
            this.panel1.Controls.Add(this.cbChucvu);
            this.panel1.Controls.Add(this.txtDiachi);
            this.panel1.Controls.Add(this.txtSodienthoai);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtbNgaysinh);
            this.panel1.Controls.Add(this.txtTen);
            this.panel1.Controls.Add(this.txtManhanvien);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lb_Ten);
            this.panel1.Controls.Add(this.lb_Manv);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(13, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1127, 395);
            this.panel1.TabIndex = 0;
            // 
            // pbsave
            // 
            this.pbsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.pbsave.Image = global::WinFormApp.Properties.Resources.icon_save;
            this.pbsave.Location = new System.Drawing.Point(280, 272);
            this.pbsave.Name = "pbsave";
            this.pbsave.Size = new System.Drawing.Size(26, 26);
            this.pbsave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbsave.TabIndex = 27;
            this.pbsave.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(262, 266);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(157, 40);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "   Lưu lại ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pbcancel
            // 
            this.pbcancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.pbcancel.Image = global::WinFormApp.Properties.Resources.icon_close;
            this.pbcancel.Location = new System.Drawing.Point(938, 272);
            this.pbcancel.Name = "pbcancel";
            this.pbcancel.Size = new System.Drawing.Size(28, 28);
            this.pbcancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbcancel.TabIndex = 25;
            this.pbcancel.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(462, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(261, 25);
            this.label7.TabIndex = 23;
            this.label7.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btn_thoat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.Color.White;
            this.btn_thoat.Location = new System.Drawing.Point(919, 266);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(157, 40);
            this.btn_thoat.TabIndex = 24;
            this.btn_thoat.Text = "   Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // pbedit
            // 
            this.pbedit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.pbedit.Cursor = System.Windows.Forms.Cursors.No;
            this.pbedit.Enabled = false;
            this.pbedit.Image = global::WinFormApp.Properties.Resources.icon_edit;
            this.pbedit.Location = new System.Drawing.Point(483, 274);
            this.pbedit.Name = "pbedit";
            this.pbedit.Size = new System.Drawing.Size(28, 28);
            this.pbedit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbedit.TabIndex = 22;
            this.pbedit.TabStop = false;
            // 
            // pbdelete
            // 
            this.pbdelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.pbdelete.Image = global::WinFormApp.Properties.Resources.icon_delete;
            this.pbdelete.Location = new System.Drawing.Point(715, 272);
            this.pbdelete.Name = "pbdelete";
            this.pbdelete.Size = new System.Drawing.Size(28, 28);
            this.pbdelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbdelete.TabIndex = 21;
            this.pbdelete.TabStop = false;
            this.pbdelete.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbadd
            // 
            this.pbadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.pbadd.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbadd.Image = global::WinFormApp.Properties.Resources.icon_add1;
            this.pbadd.Location = new System.Drawing.Point(73, 272);
            this.pbadd.Name = "pbadd";
            this.pbadd.Size = new System.Drawing.Size(28, 28);
            this.pbadd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbadd.TabIndex = 20;
            this.pbadd.TabStop = false;
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.White;
            this.btn_xoa.Location = new System.Drawing.Point(695, 266);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(157, 40);
            this.btn_xoa.TabIndex = 19;
            this.btn_xoa.Text = "    Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.btn_sua.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.White;
            this.btn_sua.Location = new System.Drawing.Point(473, 266);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(157, 40);
            this.btn_sua.TabIndex = 18;
            this.btn_sua.Text = "     Chỉnh sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.Location = new System.Drawing.Point(56, 266);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(157, 40);
            this.btn_them.TabIndex = 16;
            this.btn_them.Text = "     Thêm mới";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbChucvu
            // 
            this.cbChucvu.FormattingEnabled = true;
            this.cbChucvu.Items.AddRange(new object[] {
            "Quản Lý",
            "Nhân Viên"});
            this.cbChucvu.Location = new System.Drawing.Point(777, 201);
            this.cbChucvu.Name = "cbChucvu";
            this.cbChucvu.Size = new System.Drawing.Size(250, 24);
            this.cbChucvu.TabIndex = 15;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(777, 61);
            this.txtDiachi.Multiline = true;
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(250, 76);
            this.txtDiachi.TabIndex = 14;
            // 
            // txtSodienthoai
            // 
            this.txtSodienthoai.Location = new System.Drawing.Point(777, 153);
            this.txtSodienthoai.Multiline = true;
            this.txtSodienthoai.Name = "txtSodienthoai";
            this.txtSodienthoai.Size = new System.Drawing.Size(250, 30);
            this.txtSodienthoai.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(596, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 26);
            this.label6.TabIndex = 12;
            this.label6.Text = "Chức Vụ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(593, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "Số Điện Thoại:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(593, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Địa Chỉ: ";
            // 
            // dtbNgaysinh
            // 
            this.dtbNgaysinh.Location = new System.Drawing.Point(277, 151);
            this.dtbNgaysinh.Name = "dtbNgaysinh";
            this.dtbNgaysinh.Size = new System.Drawing.Size(250, 22);
            this.dtbNgaysinh.TabIndex = 7;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(277, 107);
            this.txtTen.Multiline = true;
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(250, 30);
            this.txtTen.TabIndex = 6;
            // 
            // txtManhanvien
            // 
            this.txtManhanvien.Location = new System.Drawing.Point(277, 66);
            this.txtManhanvien.Multiline = true;
            this.txtManhanvien.Name = "txtManhanvien";
            this.txtManhanvien.Size = new System.Drawing.Size(250, 30);
            this.txtManhanvien.TabIndex = 5;
            this.txtManhanvien.TextChanged += new System.EventHandler(this.text_ten_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày Sinh:";
            // 
            // lb_Ten
            // 
            this.lb_Ten.AutoSize = true;
            this.lb_Ten.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Ten.Location = new System.Drawing.Point(98, 107);
            this.lb_Ten.Name = "lb_Ten";
            this.lb_Ten.Size = new System.Drawing.Size(87, 26);
            this.lb_Ten.TabIndex = 2;
            this.lb_Ten.Text = "Họ Tên:";
            // 
            // lb_Manv
            // 
            this.lb_Manv.AutoSize = true;
            this.lb_Manv.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Manv.Location = new System.Drawing.Point(98, 61);
            this.lb_Manv.Name = "lb_Manv";
            this.lb_Manv.Size = new System.Drawing.Size(152, 26);
            this.lb_Manv.TabIndex = 1;
            this.lb_Manv.Text = "Mã Nhân Viên:";
            this.lb_Manv.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1125, 43);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WinFormApp.Properties.Resources.NhanVien1_removebg_preview;
            this.pictureBox3.Location = new System.Drawing.Point(20, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 43);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(69, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý nhân viên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 404);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1126, 386);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 29);
            this.label3.TabIndex = 28;
            this.label3.Text = "Giới tính";
            // 
            // cbGioitinh
            // 
            this.cbGioitinh.FormattingEnabled = true;
            this.cbGioitinh.Items.AddRange(new object[] {
            "",
            "Nam",
            "Nữ"});
            this.cbGioitinh.Location = new System.Drawing.Point(277, 202);
            this.cbGioitinh.Name = "cbGioitinh";
            this.cbGioitinh.Size = new System.Drawing.Size(250, 24);
            this.cbGioitinh.TabIndex = 29;
            this.cbGioitinh.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ucNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "ucNhanVien";
            this.Size = new System.Drawing.Size(1153, 803);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbsave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbedit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbdelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbadd)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lb_Ten;
        private System.Windows.Forms.Label lb_Manv;
        private System.Windows.Forms.DateTimePicker dtbNgaysinh;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtManhanvien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbChucvu;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtSodienthoai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.PictureBox pbdelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.PictureBox pbedit;
        private System.Windows.Forms.PictureBox pbcancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pbsave;
        private System.Windows.Forms.PictureBox pbadd;
        private System.Windows.Forms.ComboBox cbGioitinh;
        private System.Windows.Forms.Label label3;
    }
}
