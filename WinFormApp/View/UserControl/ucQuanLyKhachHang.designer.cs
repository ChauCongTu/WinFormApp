namespace WinFormApp.CustomControl
{
    partial class ucQuanLyKhachHang
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
            this.pbDelete = new System.Windows.Forms.PictureBox();
            this.pbUpdate = new System.Windows.Forms.PictureBox();
            this.btnDelete = new WinFormApp.RJButton();
            this.pbSave = new System.Windows.Forms.PictureBox();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnExit = new WinFormApp.RJButton();
            this.btnUpdate = new WinFormApp.RJButton();
            this.btnSave = new WinFormApp.RJButton();
            this.btnNew = new WinFormApp.RJButton();
            this.txtHoTenKH = new System.Windows.Forms.TextBox();
            this.txtSdtKH = new System.Windows.Forms.TextBox();
            this.txtDiaChiKH = new System.Windows.Forms.TextBox();
            this.txtCmndKH = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.colMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSdtKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChiKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCmndKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbDelete);
            this.panel1.Controls.Add(this.pbUpdate);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.pbSave);
            this.panel1.Controls.Add(this.pbAdd);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.txtHoTenKH);
            this.panel1.Controls.Add(this.txtSdtKH);
            this.panel1.Controls.Add(this.txtDiaChiKH);
            this.panel1.Controls.Add(this.txtCmndKH);
            this.panel1.Controls.Add(this.txtMaKH);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(18, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1121, 351);
            this.panel1.TabIndex = 0;
            // 
            // pbDelete
            // 
            this.pbDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.pbDelete.Image = global::WinFormApp.Properties.Resources.taoanhdep_icon_trash_alt_removebg_preview;
            this.pbDelete.Location = new System.Drawing.Point(715, 276);
            this.pbDelete.Name = "pbDelete";
            this.pbDelete.Size = new System.Drawing.Size(31, 31);
            this.pbDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDelete.TabIndex = 54;
            this.pbDelete.TabStop = false;
            // 
            // pbUpdate
            // 
            this.pbUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.pbUpdate.Image = global::WinFormApp.Properties.Resources.icon_edit;
            this.pbUpdate.Location = new System.Drawing.Point(506, 279);
            this.pbUpdate.Name = "pbUpdate";
            this.pbUpdate.Size = new System.Drawing.Size(28, 28);
            this.pbUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUpdate.TabIndex = 50;
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
            this.btnDelete.Location = new System.Drawing.Point(697, 275);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnDelete.Size = new System.Drawing.Size(157, 40);
            this.btnDelete.TabIndex = 53;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // pbSave
            // 
            this.pbSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.pbSave.Image = global::WinFormApp.Properties.Resources.icon_save;
            this.pbSave.Location = new System.Drawing.Point(287, 279);
            this.pbSave.Name = "pbSave";
            this.pbSave.Size = new System.Drawing.Size(28, 28);
            this.pbSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSave.TabIndex = 49;
            this.pbSave.TabStop = false;
            // 
            // pbAdd
            // 
            this.pbAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.pbAdd.Image = global::WinFormApp.Properties.Resources.icon_add2;
            this.pbAdd.Location = new System.Drawing.Point(75, 279);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(28, 28);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAdd.TabIndex = 48;
            this.pbAdd.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.pictureBox5.Image = global::WinFormApp.Properties.Resources.icon_close;
            this.pictureBox5.Location = new System.Drawing.Point(941, 279);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(26, 26);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 52;
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
            this.btnExit.Location = new System.Drawing.Point(914, 275);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(53, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(157, 40);
            this.btnExit.TabIndex = 51;
            this.btnExit.Text = "Thoát";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextColor = System.Drawing.Color.White;
            this.btnExit.UseVisualStyleBackColor = false;
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
            this.btnUpdate.Location = new System.Drawing.Point(483, 275);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnUpdate.Size = new System.Drawing.Size(157, 40);
            this.btnUpdate.TabIndex = 47;
            this.btnUpdate.Text = "Chỉnh Sửa";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.TextColor = System.Drawing.Color.White;
            this.btnUpdate.UseVisualStyleBackColor = false;
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
            this.btnSave.Location = new System.Drawing.Point(265, 275);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSave.Size = new System.Drawing.Size(157, 40);
            this.btnSave.TabIndex = 46;
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
            this.btnNew.Location = new System.Drawing.Point(51, 275);
            this.btnNew.Name = "btnNew";
            this.btnNew.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnNew.Size = new System.Drawing.Size(157, 40);
            this.btnNew.TabIndex = 45;
            this.btnNew.Text = "Thêm Mới";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.TextColor = System.Drawing.Color.White;
            this.btnNew.UseVisualStyleBackColor = false;
            // 
            // txtHoTenKH
            // 
            this.txtHoTenKH.Location = new System.Drawing.Point(237, 133);
            this.txtHoTenKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHoTenKH.Multiline = true;
            this.txtHoTenKH.Name = "txtHoTenKH";
            this.txtHoTenKH.Size = new System.Drawing.Size(250, 30);
            this.txtHoTenKH.TabIndex = 10;
            this.txtHoTenKH.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtSdtKH
            // 
            this.txtSdtKH.Location = new System.Drawing.Point(237, 183);
            this.txtSdtKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSdtKH.Multiline = true;
            this.txtSdtKH.Name = "txtSdtKH";
            this.txtSdtKH.Size = new System.Drawing.Size(250, 30);
            this.txtSdtKH.TabIndex = 9;
            this.txtSdtKH.TextChanged += new System.EventHandler(this.txtSdtKH_TextChanged);
            // 
            // txtDiaChiKH
            // 
            this.txtDiaChiKH.Location = new System.Drawing.Point(795, 138);
            this.txtDiaChiKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDiaChiKH.Multiline = true;
            this.txtDiaChiKH.Name = "txtDiaChiKH";
            this.txtDiaChiKH.Size = new System.Drawing.Size(250, 75);
            this.txtDiaChiKH.TabIndex = 8;
            this.txtDiaChiKH.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtCmndKH
            // 
            this.txtCmndKH.Location = new System.Drawing.Point(795, 89);
            this.txtCmndKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCmndKH.Multiline = true;
            this.txtCmndKH.Name = "txtCmndKH";
            this.txtCmndKH.Size = new System.Drawing.Size(250, 30);
            this.txtCmndKH.TabIndex = 7;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(237, 84);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaKH.Multiline = true;
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(250, 30);
            this.txtMaKH.TabIndex = 44;
            this.txtMaKH.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(587, 90);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 27);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số CMND/CCCD: ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(587, 139);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa chỉ: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 184);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số điện thoại: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ và Tên: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1121, 50);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khách hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaKH,
            this.colTenKH,
            this.colSdtKH,
            this.colDiaChiKH,
            this.colCmndKH});
            this.dgvKhachHang.Location = new System.Drawing.Point(18, 356);
            this.dgvKhachHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersWidth = 82;
            this.dgvKhachHang.RowTemplate.Height = 33;
            this.dgvKhachHang.Size = new System.Drawing.Size(1121, 447);
            this.dgvKhachHang.TabIndex = 1;
            this.dgvKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellContentClick);
            // 
            // colMaKH
            // 
            this.colMaKH.HeaderText = "Mã KH";
            this.colMaKH.MinimumWidth = 6;
            this.colMaKH.Name = "colMaKH";
            this.colMaKH.ReadOnly = true;
            // 
            // colTenKH
            // 
            this.colTenKH.HeaderText = "Họ và Tên";
            this.colTenKH.MinimumWidth = 6;
            this.colTenKH.Name = "colTenKH";
            this.colTenKH.ReadOnly = true;
            // 
            // colSdtKH
            // 
            this.colSdtKH.HeaderText = "Số điện thoại";
            this.colSdtKH.MinimumWidth = 6;
            this.colSdtKH.Name = "colSdtKH";
            this.colSdtKH.ReadOnly = true;
            // 
            // colDiaChiKH
            // 
            this.colDiaChiKH.HeaderText = "Địa chỉ";
            this.colDiaChiKH.MinimumWidth = 6;
            this.colDiaChiKH.Name = "colDiaChiKH";
            this.colDiaChiKH.ReadOnly = true;
            // 
            // colCmndKH
            // 
            this.colCmndKH.HeaderText = "CMND/CCCD";
            this.colCmndKH.MinimumWidth = 6;
            this.colCmndKH.Name = "colCmndKH";
            this.colCmndKH.ReadOnly = true;
            // 
            // ucQuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ucQuanLyKhachHang";
            this.Size = new System.Drawing.Size(1153, 803);
            this.Load += new System.EventHandler(this.ucQuanLyKhachHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtHoTenKH;
        private System.Windows.Forms.TextBox txtSdtKH;
        private System.Windows.Forms.TextBox txtDiaChiKH;
        private System.Windows.Forms.TextBox txtCmndKH;
        private System.Windows.Forms.PictureBox pbDelete;
        private System.Windows.Forms.PictureBox pbUpdate;
        private RJButton btnDelete;
        private System.Windows.Forms.PictureBox pbSave;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.PictureBox pictureBox5;
        private RJButton btnExit;
        private RJButton btnUpdate;
        private RJButton btnSave;
        private RJButton btnNew;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSdtKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChiKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCmndKH;
    }
}
