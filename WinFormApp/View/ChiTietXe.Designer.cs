namespace WinFormApp.View
{
    partial class ChiTietXe
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnChiTiet = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thôngSốKỹThuậtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hìnhẢnhSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnChiTiet
            // 
            this.pnChiTiet.Location = new System.Drawing.Point(4, 39);
            this.pnChiTiet.Name = "pnChiTiet";
            this.pnChiTiet.Size = new System.Drawing.Size(1126, 698);
            this.pnChiTiet.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngSốKỹThuậtToolStripMenuItem,
            this.hìnhẢnhSảnPhẩmToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1134, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thôngSốKỹThuậtToolStripMenuItem
            // 
            this.thôngSốKỹThuậtToolStripMenuItem.Name = "thôngSốKỹThuậtToolStripMenuItem";
            this.thôngSốKỹThuậtToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.thôngSốKỹThuậtToolStripMenuItem.Text = "Thông số kỹ thuật";
            this.thôngSốKỹThuậtToolStripMenuItem.Click += new System.EventHandler(this.thôngSốKỹThuậtToolStripMenuItem_Click);
            // 
            // hìnhẢnhSảnPhẩmToolStripMenuItem
            // 
            this.hìnhẢnhSảnPhẩmToolStripMenuItem.Name = "hìnhẢnhSảnPhẩmToolStripMenuItem";
            this.hìnhẢnhSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.hìnhẢnhSảnPhẩmToolStripMenuItem.Text = "Hình ảnh sản phẩm";
            this.hìnhẢnhSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.hìnhẢnhSảnPhẩmToolStripMenuItem_Click);
            // 
            // ChiTietXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 742);
            this.Controls.Add(this.pnChiTiet);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ChiTietXe";
            this.Text = "ChiTietXe";
            this.Load += new System.EventHandler(this.ChiTietXe_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnChiTiet;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thôngSốKỹThuậtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hìnhẢnhSảnPhẩmToolStripMenuItem;
    }
}