
namespace deadline_15_04.MyForms
{
    partial class ThongTinHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongTinHoaDon));
            this.LisView_TTHoaDon = new System.Windows.Forms.ListView();
            this.col_MaPhim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_TenPhim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_PhongChieu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_NgayChieu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_GioChieu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_SoGhe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_ThanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_NgayMua = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Label_TT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LisView_TTHoaDon
            // 
            this.LisView_TTHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LisView_TTHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LisView_TTHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_MaPhim,
            this.col_TenPhim,
            this.col_PhongChieu,
            this.col_NgayChieu,
            this.col_GioChieu,
            this.col_SoGhe,
            this.col_ThanhTien,
            this.col_NgayMua});
            this.LisView_TTHoaDon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LisView_TTHoaDon.FullRowSelect = true;
            this.LisView_TTHoaDon.GridLines = true;
            this.LisView_TTHoaDon.HideSelection = false;
            this.LisView_TTHoaDon.Location = new System.Drawing.Point(12, 63);
            this.LisView_TTHoaDon.Name = "LisView_TTHoaDon";
            this.LisView_TTHoaDon.Size = new System.Drawing.Size(973, 375);
            this.LisView_TTHoaDon.TabIndex = 0;
            this.LisView_TTHoaDon.UseCompatibleStateImageBehavior = false;
            this.LisView_TTHoaDon.View = System.Windows.Forms.View.Details;
            // 
            // col_MaPhim
            // 
            this.col_MaPhim.Text = "Mã phim";
            this.col_MaPhim.Width = 63;
            // 
            // col_TenPhim
            // 
            this.col_TenPhim.Text = "Tên Phim";
            this.col_TenPhim.Width = 186;
            // 
            // col_PhongChieu
            // 
            this.col_PhongChieu.Text = "Phòng chiếu";
            this.col_PhongChieu.Width = 87;
            // 
            // col_NgayChieu
            // 
            this.col_NgayChieu.Text = "Ngày chiếu";
            this.col_NgayChieu.Width = 91;
            // 
            // col_GioChieu
            // 
            this.col_GioChieu.Text = "Giờ Chiếu";
            this.col_GioChieu.Width = 69;
            // 
            // col_SoGhe
            // 
            this.col_SoGhe.Text = "Ghế đã đặt";
            this.col_SoGhe.Width = 213;
            // 
            // col_ThanhTien
            // 
            this.col_ThanhTien.Text = "Thành tiền";
            this.col_ThanhTien.Width = 117;
            // 
            // col_NgayMua
            // 
            this.col_NgayMua.Text = "Ngày đặt";
            this.col_NgayMua.Width = 133;
            // 
            // Label_TT
            // 
            this.Label_TT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_TT.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TT.Location = new System.Drawing.Point(259, 9);
            this.Label_TT.Name = "Label_TT";
            this.Label_TT.Size = new System.Drawing.Size(492, 32);
            this.Label_TT.TabIndex = 1;
            this.Label_TT.Text = "label1";
            this.Label_TT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ThongTinHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(997, 448);
            this.Controls.Add(this.Label_TT);
            this.Controls.Add(this.LisView_TTHoaDon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThongTinHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongTinHoaDon";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LisView_TTHoaDon;
        private System.Windows.Forms.ColumnHeader col_MaPhim;
        private System.Windows.Forms.ColumnHeader col_TenPhim;
        private System.Windows.Forms.ColumnHeader col_PhongChieu;
        private System.Windows.Forms.ColumnHeader col_NgayChieu;
        private System.Windows.Forms.ColumnHeader col_GioChieu;
        private System.Windows.Forms.ColumnHeader col_SoGhe;
        private System.Windows.Forms.ColumnHeader col_ThanhTien;
        private System.Windows.Forms.ColumnHeader col_NgayMua;
        private System.Windows.Forms.Label Label_TT;
    }
}