﻿namespace WinFormApp.View
{
    partial class FullSizeAvatar
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbAnhDaiDien = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnhDaiDien)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WinFormApp.Properties.Resources.icon_close_img;
            this.pictureBox2.Location = new System.Drawing.Point(1152, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pbAnhDaiDien
            // 
            this.pbAnhDaiDien.Location = new System.Drawing.Point(0, 0);
            this.pbAnhDaiDien.Name = "pbAnhDaiDien";
            this.pbAnhDaiDien.Size = new System.Drawing.Size(1212, 804);
            this.pbAnhDaiDien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAnhDaiDien.TabIndex = 0;
            this.pbAnhDaiDien.TabStop = false;
            // 
            // FullSizeAvatar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 802);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pbAnhDaiDien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FullSizeAvatar";
            this.Text = "FullSizeAvatar";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FullSizeAvatar_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnhDaiDien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAnhDaiDien;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}