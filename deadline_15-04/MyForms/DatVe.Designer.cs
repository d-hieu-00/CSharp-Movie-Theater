
namespace deadline_15_04
{
    partial class DatVe
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatVe));
            this.PnFlow_DatVe = new System.Windows.Forms.FlowLayoutPanel();
            this.Grbox_Filter = new System.Windows.Forms.GroupBox();
            this.Btn_ThongTinHoaDon = new System.Windows.Forms.Button();
            this.DateTime_Ngay = new System.Windows.Forms.DateTimePicker();
            this.Btn_HienTatCa = new System.Windows.Forms.Button();
            this.Btn_Filter = new System.Windows.Forms.Button();
            this.Label_Ngay = new System.Windows.Forms.Label();
            this.Timer_AutoLoad = new System.Windows.Forms.Timer(this.components);
            this.Grbox_TTVePhim = new System.Windows.Forms.GroupBox();
            this.Label_ThoiLuong = new System.Windows.Forms.Label();
            this.Label_ThT = new System.Windows.Forms.Label();
            this.Label_TongTien = new System.Windows.Forms.Label();
            this.Label_GioChieu = new System.Windows.Forms.Label();
            this.Label_NgayChieu = new System.Windows.Forms.Label();
            this.Label_PhongChieu = new System.Windows.Forms.Label();
            this.PnFlow_GheDaDat = new System.Windows.Forms.FlowLayoutPanel();
            this.Label_TempGDC = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.Label_TT = new System.Windows.Forms.Label();
            this.Label_GC = new System.Windows.Forms.Label();
            this.Label_NC = new System.Windows.Forms.Label();
            this.Label_PC = new System.Windows.Forms.Label();
            this.Label_MP = new System.Windows.Forms.Label();
            this.Label_TenPhim = new System.Windows.Forms.Label();
            this.Grbox_Filter.SuspendLayout();
            this.Grbox_TTVePhim.SuspendLayout();
            this.PnFlow_GheDaDat.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnFlow_DatVe
            // 
            this.PnFlow_DatVe.AutoScroll = true;
            this.PnFlow_DatVe.Location = new System.Drawing.Point(247, 12);
            this.PnFlow_DatVe.Name = "PnFlow_DatVe";
            this.PnFlow_DatVe.Size = new System.Drawing.Size(915, 493);
            this.PnFlow_DatVe.TabIndex = 0;
            // 
            // Grbox_Filter
            // 
            this.Grbox_Filter.Controls.Add(this.Btn_ThongTinHoaDon);
            this.Grbox_Filter.Controls.Add(this.DateTime_Ngay);
            this.Grbox_Filter.Controls.Add(this.Btn_HienTatCa);
            this.Grbox_Filter.Controls.Add(this.Btn_Filter);
            this.Grbox_Filter.Controls.Add(this.Label_Ngay);
            this.Grbox_Filter.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grbox_Filter.Location = new System.Drawing.Point(13, 13);
            this.Grbox_Filter.Name = "Grbox_Filter";
            this.Grbox_Filter.Size = new System.Drawing.Size(228, 197);
            this.Grbox_Filter.TabIndex = 1;
            this.Grbox_Filter.TabStop = false;
            this.Grbox_Filter.Text = "Lọc phim theo ngày";
            // 
            // Btn_ThongTinHoaDon
            // 
            this.Btn_ThongTinHoaDon.BackColor = System.Drawing.Color.DarkCyan;
            this.Btn_ThongTinHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ThongTinHoaDon.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ThongTinHoaDon.ForeColor = System.Drawing.Color.White;
            this.Btn_ThongTinHoaDon.Location = new System.Drawing.Point(9, 160);
            this.Btn_ThongTinHoaDon.Name = "Btn_ThongTinHoaDon";
            this.Btn_ThongTinHoaDon.Size = new System.Drawing.Size(210, 28);
            this.Btn_ThongTinHoaDon.TabIndex = 10;
            this.Btn_ThongTinHoaDon.Text = "Xem thông tin vé đặt theo ngày";
            this.Btn_ThongTinHoaDon.UseVisualStyleBackColor = false;
            this.Btn_ThongTinHoaDon.Click += new System.EventHandler(this.Btn_ThongTinHoaDon_Click);
            // 
            // DateTime_Ngay
            // 
            this.DateTime_Ngay.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTime_Ngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTime_Ngay.Location = new System.Drawing.Point(9, 68);
            this.DateTime_Ngay.Name = "DateTime_Ngay";
            this.DateTime_Ngay.Size = new System.Drawing.Size(210, 25);
            this.DateTime_Ngay.TabIndex = 9;
            // 
            // Btn_HienTatCa
            // 
            this.Btn_HienTatCa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_HienTatCa.Location = new System.Drawing.Point(9, 114);
            this.Btn_HienTatCa.Name = "Btn_HienTatCa";
            this.Btn_HienTatCa.Size = new System.Drawing.Size(95, 28);
            this.Btn_HienTatCa.TabIndex = 8;
            this.Btn_HienTatCa.Text = "Hiện tất cả";
            this.Btn_HienTatCa.UseVisualStyleBackColor = true;
            this.Btn_HienTatCa.Click += new System.EventHandler(this.Btn_HienTatCa_Click);
            // 
            // Btn_Filter
            // 
            this.Btn_Filter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Filter.Location = new System.Drawing.Point(144, 114);
            this.Btn_Filter.Name = "Btn_Filter";
            this.Btn_Filter.Size = new System.Drawing.Size(75, 28);
            this.Btn_Filter.TabIndex = 7;
            this.Btn_Filter.Text = "Lọc";
            this.Btn_Filter.UseVisualStyleBackColor = true;
            this.Btn_Filter.Click += new System.EventHandler(this.Btn_Filter_Click);
            // 
            // Label_Ngay
            // 
            this.Label_Ngay.AutoSize = true;
            this.Label_Ngay.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Ngay.Location = new System.Drawing.Point(6, 34);
            this.Label_Ngay.Name = "Label_Ngay";
            this.Label_Ngay.Size = new System.Drawing.Size(147, 17);
            this.Label_Ngay.TabIndex = 0;
            this.Label_Ngay.Text = "Chọn ngày muốn đặt vé";
            // 
            // Timer_AutoLoad
            // 
            this.Timer_AutoLoad.Enabled = true;
            this.Timer_AutoLoad.Tick += new System.EventHandler(this.AutoLoad);
            // 
            // Grbox_TTVePhim
            // 
            this.Grbox_TTVePhim.Controls.Add(this.Label_ThoiLuong);
            this.Grbox_TTVePhim.Controls.Add(this.Label_ThT);
            this.Grbox_TTVePhim.Controls.Add(this.Label_TongTien);
            this.Grbox_TTVePhim.Controls.Add(this.Label_GioChieu);
            this.Grbox_TTVePhim.Controls.Add(this.Label_NgayChieu);
            this.Grbox_TTVePhim.Controls.Add(this.Label_PhongChieu);
            this.Grbox_TTVePhim.Controls.Add(this.PnFlow_GheDaDat);
            this.Grbox_TTVePhim.Controls.Add(this.label18);
            this.Grbox_TTVePhim.Controls.Add(this.Label_TT);
            this.Grbox_TTVePhim.Controls.Add(this.Label_GC);
            this.Grbox_TTVePhim.Controls.Add(this.Label_NC);
            this.Grbox_TTVePhim.Controls.Add(this.Label_PC);
            this.Grbox_TTVePhim.Controls.Add(this.Label_MP);
            this.Grbox_TTVePhim.Controls.Add(this.Label_TenPhim);
            this.Grbox_TTVePhim.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grbox_TTVePhim.Location = new System.Drawing.Point(13, 217);
            this.Grbox_TTVePhim.Name = "Grbox_TTVePhim";
            this.Grbox_TTVePhim.Size = new System.Drawing.Size(228, 282);
            this.Grbox_TTVePhim.TabIndex = 2;
            this.Grbox_TTVePhim.TabStop = false;
            this.Grbox_TTVePhim.Text = "Thông tin vé xem phim";
            // 
            // Label_ThoiLuong
            // 
            this.Label_ThoiLuong.AutoSize = true;
            this.Label_ThoiLuong.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ThoiLuong.Location = new System.Drawing.Point(117, 125);
            this.Label_ThoiLuong.Name = "Label_ThoiLuong";
            this.Label_ThoiLuong.Size = new System.Drawing.Size(60, 17);
            this.Label_ThoiLuong.TabIndex = 26;
            this.Label_ThoiLuong.Text = "120 phút";
            // 
            // Label_ThT
            // 
            this.Label_ThT.AutoSize = true;
            this.Label_ThT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ThT.Location = new System.Drawing.Point(7, 125);
            this.Label_ThT.Name = "Label_ThT";
            this.Label_ThT.Size = new System.Drawing.Size(74, 17);
            this.Label_ThT.TabIndex = 25;
            this.Label_ThT.Text = "Thời lượng:";
            // 
            // Label_TongTien
            // 
            this.Label_TongTien.AutoSize = true;
            this.Label_TongTien.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TongTien.Location = new System.Drawing.Point(117, 150);
            this.Label_TongTien.Name = "Label_TongTien";
            this.Label_TongTien.Size = new System.Drawing.Size(63, 17);
            this.Label_TongTien.TabIndex = 24;
            this.Label_TongTien.Text = "3,000,000";
            // 
            // Label_GioChieu
            // 
            this.Label_GioChieu.AutoSize = true;
            this.Label_GioChieu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_GioChieu.Location = new System.Drawing.Point(117, 100);
            this.Label_GioChieu.Name = "Label_GioChieu";
            this.Label_GioChieu.Size = new System.Drawing.Size(39, 17);
            this.Label_GioChieu.TabIndex = 23;
            this.Label_GioChieu.Text = "20:30";
            // 
            // Label_NgayChieu
            // 
            this.Label_NgayChieu.AutoSize = true;
            this.Label_NgayChieu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_NgayChieu.Location = new System.Drawing.Point(117, 75);
            this.Label_NgayChieu.Name = "Label_NgayChieu";
            this.Label_NgayChieu.Size = new System.Drawing.Size(70, 17);
            this.Label_NgayChieu.TabIndex = 22;
            this.Label_NgayChieu.Text = "20/12/2021";
            // 
            // Label_PhongChieu
            // 
            this.Label_PhongChieu.AutoSize = true;
            this.Label_PhongChieu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_PhongChieu.Location = new System.Drawing.Point(117, 50);
            this.Label_PhongChieu.Name = "Label_PhongChieu";
            this.Label_PhongChieu.Size = new System.Drawing.Size(28, 17);
            this.Label_PhongChieu.TabIndex = 21;
            this.Label_PhongChieu.Text = "P01";
            // 
            // PnFlow_GheDaDat
            // 
            this.PnFlow_GheDaDat.AutoScroll = true;
            this.PnFlow_GheDaDat.Controls.Add(this.Label_TempGDC);
            this.PnFlow_GheDaDat.Location = new System.Drawing.Point(9, 195);
            this.PnFlow_GheDaDat.Name = "PnFlow_GheDaDat";
            this.PnFlow_GheDaDat.Size = new System.Drawing.Size(200, 75);
            this.PnFlow_GheDaDat.TabIndex = 6;
            // 
            // Label_TempGDC
            // 
            this.Label_TempGDC.AutoSize = true;
            this.Label_TempGDC.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TempGDC.Location = new System.Drawing.Point(3, 0);
            this.Label_TempGDC.Name = "Label_TempGDC";
            this.Label_TempGDC.Size = new System.Drawing.Size(29, 17);
            this.Label_TempGDC.TabIndex = 7;
            this.Label_TempGDC.Text = "A01";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(7, 175);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(113, 17);
            this.label18.TabIndex = 5;
            this.label18.Text = "Các ghế đã chọn: ";
            // 
            // Label_TT
            // 
            this.Label_TT.AutoSize = true;
            this.Label_TT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TT.Location = new System.Drawing.Point(7, 150);
            this.Label_TT.Name = "Label_TT";
            this.Label_TT.Size = new System.Drawing.Size(70, 17);
            this.Label_TT.TabIndex = 4;
            this.Label_TT.Text = "Tổng tiền: ";
            // 
            // Label_GC
            // 
            this.Label_GC.AutoSize = true;
            this.Label_GC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_GC.Location = new System.Drawing.Point(7, 100);
            this.Label_GC.Name = "Label_GC";
            this.Label_GC.Size = new System.Drawing.Size(69, 17);
            this.Label_GC.TabIndex = 3;
            this.Label_GC.Text = "Giờ chiếu: ";
            // 
            // Label_NC
            // 
            this.Label_NC.AutoSize = true;
            this.Label_NC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_NC.Location = new System.Drawing.Point(7, 75);
            this.Label_NC.Name = "Label_NC";
            this.Label_NC.Size = new System.Drawing.Size(80, 17);
            this.Label_NC.TabIndex = 2;
            this.Label_NC.Text = "Ngày chiếu: ";
            // 
            // Label_PC
            // 
            this.Label_PC.AutoSize = true;
            this.Label_PC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_PC.Location = new System.Drawing.Point(7, 50);
            this.Label_PC.Name = "Label_PC";
            this.Label_PC.Size = new System.Drawing.Size(86, 17);
            this.Label_PC.TabIndex = 1;
            this.Label_PC.Text = "Phòng chiếu: ";
            // 
            // Label_MP
            // 
            this.Label_MP.AutoSize = true;
            this.Label_MP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_MP.Location = new System.Drawing.Point(7, 25);
            this.Label_MP.Name = "Label_MP";
            this.Label_MP.Size = new System.Drawing.Size(68, 17);
            this.Label_MP.TabIndex = 0;
            this.Label_MP.Text = "Tên phim: ";
            // 
            // Label_TenPhim
            // 
            this.Label_TenPhim.AutoSize = true;
            this.Label_TenPhim.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TenPhim.Location = new System.Drawing.Point(117, 25);
            this.Label_TenPhim.Name = "Label_TenPhim";
            this.Label_TenPhim.Size = new System.Drawing.Size(109, 17);
            this.Label_TenPhim.TabIndex = 20;
            this.Label_TenPhim.Text = "123456789012345";
            // 
            // DatVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1169, 511);
            this.Controls.Add(this.Grbox_TTVePhim);
            this.Controls.Add(this.Grbox_Filter);
            this.Controls.Add(this.PnFlow_DatVe);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "DatVe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt vé";
            this.Grbox_Filter.ResumeLayout(false);
            this.Grbox_Filter.PerformLayout();
            this.Grbox_TTVePhim.ResumeLayout(false);
            this.Grbox_TTVePhim.PerformLayout();
            this.PnFlow_GheDaDat.ResumeLayout(false);
            this.PnFlow_GheDaDat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PnFlow_DatVe;
        private System.Windows.Forms.GroupBox Grbox_Filter;
        private System.Windows.Forms.Label Label_Ngay;
        private System.Windows.Forms.Button Btn_HienTatCa;
        private System.Windows.Forms.Button Btn_Filter;
        private System.Windows.Forms.Timer Timer_AutoLoad;
        private System.Windows.Forms.DateTimePicker DateTime_Ngay;
        private System.Windows.Forms.Button Btn_ThongTinHoaDon;
        private System.Windows.Forms.GroupBox Grbox_TTVePhim;
        private System.Windows.Forms.FlowLayoutPanel PnFlow_GheDaDat;
        private System.Windows.Forms.Label Label_TempGDC;
        private System.Windows.Forms.Label Label_TenPhim;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label Label_TT;
        private System.Windows.Forms.Label Label_GC;
        private System.Windows.Forms.Label Label_NC;
        private System.Windows.Forms.Label Label_PC;
        private System.Windows.Forms.Label Label_MP;
        private System.Windows.Forms.Label Label_TongTien;
        private System.Windows.Forms.Label Label_GioChieu;
        private System.Windows.Forms.Label Label_NgayChieu;
        private System.Windows.Forms.Label Label_PhongChieu;
        private System.Windows.Forms.Label Label_ThoiLuong;
        private System.Windows.Forms.Label Label_ThT;
    }
}