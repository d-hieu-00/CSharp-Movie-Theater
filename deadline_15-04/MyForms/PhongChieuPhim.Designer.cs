
namespace deadline_15_04
{
    partial class PhongChieuPhim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhongChieuPhim));
            this.Grbox_TTPhong = new System.Windows.Forms.GroupBox();
            this.Label_TgCL = new System.Windows.Forms.Label();
            this.Label_SoGhe = new System.Windows.Forms.Label();
            this.Label_TrangThai = new System.Windows.Forms.Label();
            this.lb_tgcl = new System.Windows.Forms.Label();
            this.lb_sg = new System.Windows.Forms.Label();
            this.lb_TT = new System.Windows.Forms.Label();
            this.Cbox_PhongChieu = new System.Windows.Forms.ComboBox();
            this.Label_PC = new System.Windows.Forms.Label();
            this.Timer_AutoLoad = new System.Windows.Forms.Timer(this.components);
            this.Grbox_TTPhong.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grbox_TTPhong
            // 
            this.Grbox_TTPhong.Controls.Add(this.Label_TgCL);
            this.Grbox_TTPhong.Controls.Add(this.Label_SoGhe);
            this.Grbox_TTPhong.Controls.Add(this.Label_TrangThai);
            this.Grbox_TTPhong.Controls.Add(this.lb_tgcl);
            this.Grbox_TTPhong.Controls.Add(this.lb_sg);
            this.Grbox_TTPhong.Controls.Add(this.lb_TT);
            this.Grbox_TTPhong.Controls.Add(this.Cbox_PhongChieu);
            this.Grbox_TTPhong.Controls.Add(this.Label_PC);
            this.Grbox_TTPhong.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grbox_TTPhong.Location = new System.Drawing.Point(12, 12);
            this.Grbox_TTPhong.Name = "Grbox_TTPhong";
            this.Grbox_TTPhong.Size = new System.Drawing.Size(299, 201);
            this.Grbox_TTPhong.TabIndex = 0;
            this.Grbox_TTPhong.TabStop = false;
            this.Grbox_TTPhong.Text = "Thông tin các phòng chiếu";
            // 
            // Label_TgCL
            // 
            this.Label_TgCL.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TgCL.Location = new System.Drawing.Point(161, 163);
            this.Label_TgCL.Name = "Label_TgCL";
            this.Label_TgCL.Size = new System.Drawing.Size(108, 17);
            this.Label_TgCL.TabIndex = 7;
            this.Label_TgCL.Text = "1:12";
            this.Label_TgCL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_SoGhe
            // 
            this.Label_SoGhe.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_SoGhe.Location = new System.Drawing.Point(161, 123);
            this.Label_SoGhe.Name = "Label_SoGhe";
            this.Label_SoGhe.Size = new System.Drawing.Size(108, 17);
            this.Label_SoGhe.TabIndex = 6;
            this.Label_SoGhe.Text = "44/119";
            this.Label_SoGhe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_TrangThai
            // 
            this.Label_TrangThai.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TrangThai.Location = new System.Drawing.Point(161, 83);
            this.Label_TrangThai.Name = "Label_TrangThai";
            this.Label_TrangThai.Size = new System.Drawing.Size(108, 17);
            this.Label_TrangThai.TabIndex = 5;
            this.Label_TrangThai.Text = "Trống";
            this.Label_TrangThai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_tgcl
            // 
            this.lb_tgcl.AutoSize = true;
            this.lb_tgcl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tgcl.Location = new System.Drawing.Point(6, 163);
            this.lb_tgcl.Name = "lb_tgcl";
            this.lb_tgcl.Size = new System.Drawing.Size(138, 17);
            this.lb_tgcl.TabIndex = 4;
            this.lb_tgcl.Text = "Thời gian chiếu còn lại";
            // 
            // lb_sg
            // 
            this.lb_sg.AutoSize = true;
            this.lb_sg.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sg.Location = new System.Drawing.Point(6, 123);
            this.lb_sg.Name = "lb_sg";
            this.lb_sg.Size = new System.Drawing.Size(91, 17);
            this.lb_sg.TabIndex = 3;
            this.lb_sg.Text = "Số ghế đã đặt";
            // 
            // lb_TT
            // 
            this.lb_TT.AutoSize = true;
            this.lb_TT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TT.Location = new System.Drawing.Point(6, 83);
            this.lb_TT.Name = "lb_TT";
            this.lb_TT.Size = new System.Drawing.Size(66, 17);
            this.lb_TT.TabIndex = 2;
            this.lb_TT.Text = "Trạng thái";
            // 
            // Cbox_PhongChieu
            // 
            this.Cbox_PhongChieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbox_PhongChieu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbox_PhongChieu.FormattingEnabled = true;
            this.Cbox_PhongChieu.Location = new System.Drawing.Point(164, 40);
            this.Cbox_PhongChieu.Name = "Cbox_PhongChieu";
            this.Cbox_PhongChieu.Size = new System.Drawing.Size(105, 25);
            this.Cbox_PhongChieu.TabIndex = 1;
            // 
            // Label_PC
            // 
            this.Label_PC.AutoSize = true;
            this.Label_PC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_PC.Location = new System.Drawing.Point(6, 43);
            this.Label_PC.Name = "Label_PC";
            this.Label_PC.Size = new System.Drawing.Size(79, 17);
            this.Label_PC.TabIndex = 0;
            this.Label_PC.Text = "Phòng chiếu";
            // 
            // Timer_AutoLoad
            // 
            this.Timer_AutoLoad.Enabled = true;
            this.Timer_AutoLoad.Interval = 1000;
            this.Timer_AutoLoad.Tick += new System.EventHandler(this.Timer_AutoLoad_Tick);
            // 
            // PhongChieuPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(323, 225);
            this.Controls.Add(this.Grbox_TTPhong);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PhongChieuPhim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phòng chiếu phim";
            this.Grbox_TTPhong.ResumeLayout(false);
            this.Grbox_TTPhong.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Grbox_TTPhong;
        private System.Windows.Forms.Label Label_TgCL;
        private System.Windows.Forms.Label Label_SoGhe;
        private System.Windows.Forms.Label Label_TrangThai;
        private System.Windows.Forms.Label lb_tgcl;
        private System.Windows.Forms.Label lb_sg;
        private System.Windows.Forms.Label lb_TT;
        private System.Windows.Forms.Label Label_PC;
        private System.Windows.Forms.Timer Timer_AutoLoad;
        private System.Windows.Forms.ComboBox Cbox_PhongChieu;
    }
}