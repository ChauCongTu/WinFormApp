namespace WinFormApp.CustomControl
{
    partial class ucKhoPhuTung
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
            this.dgvPhuTung = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.txtMota = new System.Windows.Forms.TextBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.txtTenphutung = new System.Windows.Forms.TextBox();
            this.txtMaphutung = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pbsave = new System.Windows.Forms.PictureBox();
            this.pbcancel = new System.Windows.Forms.PictureBox();
            this.pbedit = new System.Windows.Forms.PictureBox();
            this.pbdelete = new System.Windows.Forms.PictureBox();
            this.pbadd = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTraCuuHoaDon = new CustomControls.RJControls.RJTextBox();
            this._sott = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._mapt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._tenpt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._mota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuTung)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbsave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbedit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbdelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbadd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhuTung
            // 
            this.dgvPhuTung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhuTung.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPhuTung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhuTung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._sott,
            this._mapt,
            this._tenpt,
            this._sl,
            this._mota});
            this.dgvPhuTung.Location = new System.Drawing.Point(13, 393);
            this.dgvPhuTung.Name = "dgvPhuTung";
            this.dgvPhuTung.RowHeadersWidth = 51;
            this.dgvPhuTung.RowTemplate.Height = 24;
            this.dgvPhuTung.Size = new System.Drawing.Size(1127, 396);
            this.dgvPhuTung.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.pbsave);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.pbcancel);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.pbedit);
            this.panel1.Controls.Add(this.pbdelete);
            this.panel1.Controls.Add(this.pbadd);
            this.panel1.Controls.Add(this.btn_xoa);
            this.panel1.Controls.Add(this.btn_sua);
            this.panel1.Controls.Add(this.btn_them);
            this.panel1.Controls.Add(this.txtMota);
            this.panel1.Controls.Add(this.txtSoluong);
            this.panel1.Controls.Add(this.txtTenphutung);
            this.panel1.Controls.Add(this.txtMaphutung);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(13, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1127, 327);
            this.panel1.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(261, 273);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(157, 40);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "   Lưu lại ";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.button2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(918, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 40);
            this.button2.TabIndex = 34;
            this.button2.Text = "   Thoát";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.White;
            this.btn_xoa.Location = new System.Drawing.Point(694, 273);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(157, 40);
            this.btn_xoa.TabIndex = 30;
            this.btn_xoa.Text = "    Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.btn_sua.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.White;
            this.btn_sua.Location = new System.Drawing.Point(472, 273);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(157, 40);
            this.btn_sua.TabIndex = 29;
            this.btn_sua.Text = "     Chỉnh sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.Location = new System.Drawing.Point(55, 273);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(157, 40);
            this.btn_them.TabIndex = 28;
            this.btn_them.Text = "     Thêm mới";
            this.btn_them.UseVisualStyleBackColor = false;
            // 
            // txtMota
            // 
            this.txtMota.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMota.Location = new System.Drawing.Point(738, 124);
            this.txtMota.Multiline = true;
            this.txtMota.Name = "txtMota";
            this.txtMota.Size = new System.Drawing.Size(269, 128);
            this.txtMota.TabIndex = 8;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoluong.Location = new System.Drawing.Point(279, 218);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(250, 34);
            this.txtSoluong.TabIndex = 7;
            // 
            // txtTenphutung
            // 
            this.txtTenphutung.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenphutung.Location = new System.Drawing.Point(279, 169);
            this.txtTenphutung.Name = "txtTenphutung";
            this.txtTenphutung.Size = new System.Drawing.Size(250, 34);
            this.txtTenphutung.TabIndex = 6;
            // 
            // txtMaphutung
            // 
            this.txtMaphutung.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaphutung.Location = new System.Drawing.Point(279, 124);
            this.txtMaphutung.Name = "txtMaphutung";
            this.txtMaphutung.Size = new System.Drawing.Size(250, 34);
            this.txtMaphutung.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(636, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mô tả:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(121, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên phụ tùng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã phụ tùng:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1125, 43);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(69, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kho phụ tùng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(328, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 26);
            this.label7.TabIndex = 39;
            this.label7.Text = "Chi nhánh:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Quản Lý",
            "Nhân Viên"});
            this.comboBox1.Location = new System.Drawing.Point(446, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(328, 34);
            this.comboBox1.TabIndex = 38;
            // 
            // pbsave
            // 
            this.pbsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.pbsave.Image = global::WinFormApp.Properties.Resources.icon_save;
            this.pbsave.Location = new System.Drawing.Point(279, 279);
            this.pbsave.Name = "pbsave";
            this.pbsave.Size = new System.Drawing.Size(26, 26);
            this.pbsave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbsave.TabIndex = 37;
            this.pbsave.TabStop = false;
            // 
            // pbcancel
            // 
            this.pbcancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.pbcancel.Image = global::WinFormApp.Properties.Resources.icon_close;
            this.pbcancel.Location = new System.Drawing.Point(937, 279);
            this.pbcancel.Name = "pbcancel";
            this.pbcancel.Size = new System.Drawing.Size(28, 28);
            this.pbcancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbcancel.TabIndex = 35;
            this.pbcancel.TabStop = false;
            // 
            // pbedit
            // 
            this.pbedit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.pbedit.Cursor = System.Windows.Forms.Cursors.No;
            this.pbedit.Enabled = false;
            this.pbedit.Image = global::WinFormApp.Properties.Resources.icon_edit;
            this.pbedit.Location = new System.Drawing.Point(482, 281);
            this.pbedit.Name = "pbedit";
            this.pbedit.Size = new System.Drawing.Size(28, 28);
            this.pbedit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbedit.TabIndex = 33;
            this.pbedit.TabStop = false;
            // 
            // pbdelete
            // 
            this.pbdelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.pbdelete.Image = global::WinFormApp.Properties.Resources.icon_delete;
            this.pbdelete.Location = new System.Drawing.Point(714, 279);
            this.pbdelete.Name = "pbdelete";
            this.pbdelete.Size = new System.Drawing.Size(28, 28);
            this.pbdelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbdelete.TabIndex = 32;
            this.pbdelete.TabStop = false;
            // 
            // pbadd
            // 
            this.pbadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.pbadd.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbadd.Image = global::WinFormApp.Properties.Resources.icon_add1;
            this.pbadd.Location = new System.Drawing.Point(72, 279);
            this.pbadd.Name = "pbadd";
            this.pbadd.Size = new System.Drawing.Size(28, 28);
            this.pbadd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbadd.TabIndex = 31;
            this.pbadd.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinFormApp.Properties.Resources.PhuTung1_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(20, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::WinFormApp.Properties.Resources.icon_search;
            this.pictureBox2.Location = new System.Drawing.Point(1111, 345);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 58;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(659, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 26);
            this.label6.TabIndex = 57;
            this.label6.Text = "Tìm kiếm phụ tùng:";
            // 
            // txtTraCuuHoaDon
            // 
            this.txtTraCuuHoaDon.BackColor = System.Drawing.Color.White;
            this.txtTraCuuHoaDon.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.txtTraCuuHoaDon.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTraCuuHoaDon.BorderSize = 2;
            this.txtTraCuuHoaDon.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTraCuuHoaDon.ForeColor = System.Drawing.Color.Black;
            this.txtTraCuuHoaDon.Location = new System.Drawing.Point(863, 345);
            this.txtTraCuuHoaDon.Multiline = false;
            this.txtTraCuuHoaDon.Name = "txtTraCuuHoaDon";
            this.txtTraCuuHoaDon.Padding = new System.Windows.Forms.Padding(7);
            this.txtTraCuuHoaDon.PasswordChar = false;
            this.txtTraCuuHoaDon.Size = new System.Drawing.Size(276, 34);
            this.txtTraCuuHoaDon.TabIndex = 56;
            this.txtTraCuuHoaDon.Texts = "";
            this.txtTraCuuHoaDon.UnderlinedStyle = true;
            // 
            // _sott
            // 
            this._sott.HeaderText = "Số TT";
            this._sott.MinimumWidth = 6;
            this._sott.Name = "_sott";
            this._sott.ReadOnly = true;
            // 
            // _mapt
            // 
            this._mapt.HeaderText = "Mã phụ tùng";
            this._mapt.MinimumWidth = 6;
            this._mapt.Name = "_mapt";
            this._mapt.ReadOnly = true;
            // 
            // _tenpt
            // 
            this._tenpt.HeaderText = "Tên phụ tùng";
            this._tenpt.MinimumWidth = 6;
            this._tenpt.Name = "_tenpt";
            this._tenpt.ReadOnly = true;
            // 
            // _sl
            // 
            this._sl.HeaderText = "Số lượng";
            this._sl.MinimumWidth = 6;
            this._sl.Name = "_sl";
            this._sl.ReadOnly = true;
            // 
            // _mota
            // 
            this._mota.HeaderText = "Mô tả";
            this._mota.MinimumWidth = 6;
            this._mota.Name = "_mota";
            this._mota.ReadOnly = true;
            // 
            // ucKhoPhuTung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTraCuuHoaDon);
            this.Controls.Add(this.dgvPhuTung);
            this.Controls.Add(this.panel1);
            this.Name = "ucKhoPhuTung";
            this.Size = new System.Drawing.Size(1153, 803);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuTung)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbsave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbedit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbdelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbadd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhuTung;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbsave;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pbcancel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pbedit;
        private System.Windows.Forms.PictureBox pbdelete;
        private System.Windows.Forms.PictureBox pbadd;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox txtMota;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.TextBox txtTenphutung;
        private System.Windows.Forms.TextBox txtMaphutung;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private CustomControls.RJControls.RJTextBox txtTraCuuHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn _sott;
        private System.Windows.Forms.DataGridViewTextBoxColumn _mapt;
        private System.Windows.Forms.DataGridViewTextBoxColumn _tenpt;
        private System.Windows.Forms.DataGridViewTextBoxColumn _sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn _mota;
    }
}
