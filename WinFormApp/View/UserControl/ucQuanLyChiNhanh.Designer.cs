namespace WinFormApp.CustomControl
{
    partial class ucQuanLyChiNhanh
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
            this.label3 = new System.Windows.Forms.Label();
            this.dgvChiNhanh = new System.Windows.Forms.DataGridView();
            this.txtNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaCn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenCN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbInputSDT = new System.Windows.Forms.TextBox();
            this.tbInputTenCN = new System.Windows.Forms.TextBox();
            this.tbInputDiachi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbInputMacn = new System.Windows.Forms.TextBox();
            this.pbDelete = new System.Windows.Forms.PictureBox();
            this.pbUpdate = new System.Windows.Forms.PictureBox();
            this.btnDeleteCN = new WinFormApp.RJButton();
            this.pbSave = new System.Windows.Forms.PictureBox();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnExitCN = new WinFormApp.RJButton();
            this.btnUpdateCN = new WinFormApp.RJButton();
            this.btnSaveCN = new WinFormApp.RJButton();
            this.btnNewCN = new WinFormApp.RJButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtTraCuuHoaDon = new CustomControls.RJControls.RJTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiNhanh)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(645, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 26);
            this.label3.TabIndex = 59;
            this.label3.Text = "Tìm kiếm chi nhánh:";
            // 
            // dgvChiNhanh
            // 
            this.dgvChiNhanh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiNhanh.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiNhanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiNhanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtNo,
            this.txtMaCn,
            this.txtTenCN,
            this.txtDiaChi,
            this.txtSDT});
            this.dgvChiNhanh.Location = new System.Drawing.Point(16, 342);
            this.dgvChiNhanh.Name = "dgvChiNhanh";
            this.dgvChiNhanh.RowHeadersWidth = 51;
            this.dgvChiNhanh.RowTemplate.Height = 24;
            this.dgvChiNhanh.Size = new System.Drawing.Size(1121, 456);
            this.dgvChiNhanh.TabIndex = 61;
            this.dgvChiNhanh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiNhanh_CellClick);
            // 
            // txtNo
            // 
            this.txtNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.txtNo.HeaderText = "Số TT";
            this.txtNo.MinimumWidth = 6;
            this.txtNo.Name = "txtNo";
            this.txtNo.ReadOnly = true;
            this.txtNo.Width = 114;
            // 
            // txtMaCn
            // 
            this.txtMaCn.HeaderText = "Mã Chi Nhánh";
            this.txtMaCn.MinimumWidth = 6;
            this.txtMaCn.Name = "txtMaCn";
            this.txtMaCn.ReadOnly = true;
            // 
            // txtTenCN
            // 
            this.txtTenCN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.txtTenCN.HeaderText = "Tên Chi Nhánh";
            this.txtTenCN.MinimumWidth = 6;
            this.txtTenCN.Name = "txtTenCN";
            this.txtTenCN.ReadOnly = true;
            this.txtTenCN.Width = 314;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.HeaderText = "Địa Chỉ";
            this.txtDiaChi.MinimumWidth = 6;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ReadOnly = true;
            // 
            // txtSDT
            // 
            this.txtSDT.HeaderText = "Số Điện Thoại";
            this.txtSDT.MinimumWidth = 6;
            this.txtSDT.Name = "txtSDT";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tbInputSDT);
            this.panel1.Controls.Add(this.tbInputTenCN);
            this.panel1.Controls.Add(this.tbInputDiachi);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tbInputMacn);
            this.panel1.Controls.Add(this.pbDelete);
            this.panel1.Controls.Add(this.pbUpdate);
            this.panel1.Controls.Add(this.btnDeleteCN);
            this.panel1.Controls.Add(this.pbSave);
            this.panel1.Controls.Add(this.pbAdd);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.btnExitCN);
            this.panel1.Controls.Add(this.btnUpdateCN);
            this.panel1.Controls.Add(this.btnSaveCN);
            this.panel1.Controls.Add(this.btnNewCN);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(15, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1122, 262);
            this.panel1.TabIndex = 60;
            // 
            // tbInputSDT
            // 
            this.tbInputSDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInputSDT.Location = new System.Drawing.Point(787, 128);
            this.tbInputSDT.Name = "tbInputSDT";
            this.tbInputSDT.Size = new System.Drawing.Size(250, 30);
            this.tbInputSDT.TabIndex = 49;
            this.tbInputSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInputSDT_KeyPress);
            // 
            // tbInputTenCN
            // 
            this.tbInputTenCN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInputTenCN.Location = new System.Drawing.Point(214, 128);
            this.tbInputTenCN.Name = "tbInputTenCN";
            this.tbInputTenCN.Size = new System.Drawing.Size(250, 30);
            this.tbInputTenCN.TabIndex = 48;
            // 
            // tbInputDiachi
            // 
            this.tbInputDiachi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInputDiachi.Location = new System.Drawing.Point(787, 71);
            this.tbInputDiachi.Name = "tbInputDiachi";
            this.tbInputDiachi.Size = new System.Drawing.Size(250, 30);
            this.tbInputDiachi.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(47, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 26);
            this.label8.TabIndex = 45;
            this.label8.Text = "Tên Chi Nhánh:";
            // 
            // tbInputMacn
            // 
            this.tbInputMacn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInputMacn.Location = new System.Drawing.Point(214, 71);
            this.tbInputMacn.Name = "tbInputMacn";
            this.tbInputMacn.Size = new System.Drawing.Size(250, 30);
            this.tbInputMacn.TabIndex = 44;
            // 
            // pbDelete
            // 
            this.pbDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.pbDelete.Image = global::WinFormApp.Properties.Resources.taoanhdep_icon_trash_alt_removebg_preview;
            this.pbDelete.Location = new System.Drawing.Point(717, 195);
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
            this.pbUpdate.Location = new System.Drawing.Point(508, 198);
            this.pbUpdate.Name = "pbUpdate";
            this.pbUpdate.Size = new System.Drawing.Size(28, 28);
            this.pbUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUpdate.TabIndex = 20;
            this.pbUpdate.TabStop = false;
            // 
            // btnDeleteCN
            // 
            this.btnDeleteCN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.btnDeleteCN.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.btnDeleteCN.BorderColor = System.Drawing.Color.DimGray;
            this.btnDeleteCN.BorderRadius = 0;
            this.btnDeleteCN.BorderSize = 1;
            this.btnDeleteCN.FlatAppearance.BorderSize = 0;
            this.btnDeleteCN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCN.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCN.Location = new System.Drawing.Point(698, 193);
            this.btnDeleteCN.Name = "btnDeleteCN";
            this.btnDeleteCN.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnDeleteCN.Size = new System.Drawing.Size(157, 40);
            this.btnDeleteCN.TabIndex = 42;
            this.btnDeleteCN.Text = "Xóa";
            this.btnDeleteCN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteCN.TextColor = System.Drawing.Color.White;
            this.btnDeleteCN.UseVisualStyleBackColor = false;
            this.btnDeleteCN.Click += new System.EventHandler(this.btnDeleteCN_Click);
            // 
            // pbSave
            // 
            this.pbSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.pbSave.Image = global::WinFormApp.Properties.Resources.icon_save;
            this.pbSave.Location = new System.Drawing.Point(289, 198);
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
            this.pbAdd.Location = new System.Drawing.Point(77, 198);
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
            this.pictureBox5.Location = new System.Drawing.Point(942, 198);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(26, 26);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 41;
            this.pictureBox5.TabStop = false;
            // 
            // btnExitCN
            // 
            this.btnExitCN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnExitCN.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnExitCN.BorderColor = System.Drawing.Color.DimGray;
            this.btnExitCN.BorderRadius = 0;
            this.btnExitCN.BorderSize = 1;
            this.btnExitCN.FlatAppearance.BorderSize = 0;
            this.btnExitCN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitCN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitCN.ForeColor = System.Drawing.Color.White;
            this.btnExitCN.Location = new System.Drawing.Point(916, 193);
            this.btnExitCN.Name = "btnExitCN";
            this.btnExitCN.Padding = new System.Windows.Forms.Padding(53, 0, 0, 0);
            this.btnExitCN.Size = new System.Drawing.Size(157, 40);
            this.btnExitCN.TabIndex = 40;
            this.btnExitCN.Text = "Thoát";
            this.btnExitCN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExitCN.TextColor = System.Drawing.Color.White;
            this.btnExitCN.UseVisualStyleBackColor = false;
            this.btnExitCN.Click += new System.EventHandler(this.btnExitCN_Click);
            // 
            // btnUpdateCN
            // 
            this.btnUpdateCN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.btnUpdateCN.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.btnUpdateCN.BorderColor = System.Drawing.Color.DimGray;
            this.btnUpdateCN.BorderRadius = 0;
            this.btnUpdateCN.BorderSize = 1;
            this.btnUpdateCN.FlatAppearance.BorderSize = 0;
            this.btnUpdateCN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCN.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCN.Location = new System.Drawing.Point(485, 193);
            this.btnUpdateCN.Name = "btnUpdateCN";
            this.btnUpdateCN.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnUpdateCN.Size = new System.Drawing.Size(157, 40);
            this.btnUpdateCN.TabIndex = 12;
            this.btnUpdateCN.Text = "Chỉnh Sửa";
            this.btnUpdateCN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateCN.TextColor = System.Drawing.Color.White;
            this.btnUpdateCN.UseVisualStyleBackColor = false;
            this.btnUpdateCN.Click += new System.EventHandler(this.btnUpdateCN_Click);
            // 
            // btnSaveCN
            // 
            this.btnSaveCN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.btnSaveCN.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.btnSaveCN.BorderColor = System.Drawing.Color.DimGray;
            this.btnSaveCN.BorderRadius = 0;
            this.btnSaveCN.BorderSize = 1;
            this.btnSaveCN.FlatAppearance.BorderSize = 0;
            this.btnSaveCN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveCN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCN.ForeColor = System.Drawing.Color.White;
            this.btnSaveCN.Location = new System.Drawing.Point(266, 193);
            this.btnSaveCN.Name = "btnSaveCN";
            this.btnSaveCN.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSaveCN.Size = new System.Drawing.Size(157, 40);
            this.btnSaveCN.TabIndex = 10;
            this.btnSaveCN.Text = "Lưu Lại";
            this.btnSaveCN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveCN.TextColor = System.Drawing.Color.White;
            this.btnSaveCN.UseVisualStyleBackColor = false;
            this.btnSaveCN.Click += new System.EventHandler(this.btnSaveCN_Click);
            // 
            // btnNewCN
            // 
            this.btnNewCN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.btnNewCN.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.btnNewCN.BorderColor = System.Drawing.Color.DimGray;
            this.btnNewCN.BorderRadius = 0;
            this.btnNewCN.BorderSize = 1;
            this.btnNewCN.FlatAppearance.BorderSize = 0;
            this.btnNewCN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewCN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCN.ForeColor = System.Drawing.Color.White;
            this.btnNewCN.Location = new System.Drawing.Point(53, 193);
            this.btnNewCN.Name = "btnNewCN";
            this.btnNewCN.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnNewCN.Size = new System.Drawing.Size(157, 40);
            this.btnNewCN.TabIndex = 9;
            this.btnNewCN.Text = "Thêm Mới";
            this.btnNewCN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewCN.TextColor = System.Drawing.Color.White;
            this.btnNewCN.UseVisualStyleBackColor = false;
            this.btnNewCN.Click += new System.EventHandler(this.btnNewCN_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(629, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Địa Chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(629, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số Điện Thoại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Chi Nhánh:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1120, 50);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WinFormApp.Properties.Resources.ChiNhanh1_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(11, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Chi Nhánh";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::WinFormApp.Properties.Resources.icon_search;
            this.pictureBox1.Location = new System.Drawing.Point(1108, 288);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // txtTraCuuHoaDon
            // 
            this.txtTraCuuHoaDon.BackColor = System.Drawing.Color.White;
            this.txtTraCuuHoaDon.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(139)))));
            this.txtTraCuuHoaDon.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTraCuuHoaDon.BorderSize = 2;
            this.txtTraCuuHoaDon.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTraCuuHoaDon.ForeColor = System.Drawing.Color.Black;
            this.txtTraCuuHoaDon.Location = new System.Drawing.Point(860, 286);
            this.txtTraCuuHoaDon.Multiline = false;
            this.txtTraCuuHoaDon.Name = "txtTraCuuHoaDon";
            this.txtTraCuuHoaDon.Padding = new System.Windows.Forms.Padding(7);
            this.txtTraCuuHoaDon.PasswordChar = false;
            this.txtTraCuuHoaDon.Size = new System.Drawing.Size(276, 34);
            this.txtTraCuuHoaDon.TabIndex = 62;
            this.txtTraCuuHoaDon.Texts = "";
            this.txtTraCuuHoaDon.UnderlinedStyle = true;
            // 
            // ucQuanLyChiNhanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTraCuuHoaDon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvChiNhanh);
            this.Controls.Add(this.panel1);
            this.Name = "ucQuanLyChiNhanh";
            this.Size = new System.Drawing.Size(1153, 803);
            this.Load += new System.EventHandler(this.ucQuanLyChiNhanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiNhanh)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvChiNhanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMaCn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTenCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSDT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbInputSDT;
        private System.Windows.Forms.TextBox tbInputTenCN;
        private System.Windows.Forms.TextBox tbInputDiachi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbInputMacn;
        private System.Windows.Forms.PictureBox pbDelete;
        private System.Windows.Forms.PictureBox pbUpdate;
        private RJButton btnDeleteCN;
        private System.Windows.Forms.PictureBox pbSave;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.PictureBox pictureBox5;
        private RJButton btnExitCN;
        private RJButton btnUpdateCN;
        private RJButton btnSaveCN;
        private RJButton btnNewCN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomControls.RJControls.RJTextBox txtTraCuuHoaDon;
    }
}
