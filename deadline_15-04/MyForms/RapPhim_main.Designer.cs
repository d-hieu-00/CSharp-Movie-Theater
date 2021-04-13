
namespace deadline_15_04
{
    partial class RapPhim_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RapPhim_main));
            this.Btn_close = new System.Windows.Forms.Button();
            this.Pn_main_function = new System.Windows.Forms.Panel();
            this.Btn_DatVe = new System.Windows.Forms.Button();
            this.Btn_PhongChieuPhim = new System.Windows.Forms.Button();
            this.Btn_DanhMucPhim = new System.Windows.Forms.Button();
            this.Lb_InfoApp = new System.Windows.Forms.Label();
            this.Pn_main_function.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_close
            // 
            this.Btn_close.FlatAppearance.BorderSize = 0;
            this.Btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_close.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Btn_close.ForeColor = System.Drawing.Color.White;
            this.Btn_close.Location = new System.Drawing.Point(759, 1);
            this.Btn_close.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_close.Name = "Btn_close";
            this.Btn_close.Size = new System.Drawing.Size(40, 30);
            this.Btn_close.TabIndex = 0;
            this.Btn_close.Text = "X";
            this.Btn_close.UseVisualStyleBackColor = true;
            this.Btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            this.Btn_close.MouseEnter += new System.EventHandler(this.Btn_close_MouseEnter);
            this.Btn_close.MouseLeave += new System.EventHandler(this.Btn_close_MouseLeave);
            // 
            // Pn_main_function
            // 
            this.Pn_main_function.BackColor = System.Drawing.Color.White;
            this.Pn_main_function.Controls.Add(this.Btn_DatVe);
            this.Pn_main_function.Controls.Add(this.Btn_PhongChieuPhim);
            this.Pn_main_function.Controls.Add(this.Btn_DanhMucPhim);
            this.Pn_main_function.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pn_main_function.Location = new System.Drawing.Point(1, 32);
            this.Pn_main_function.Name = "Pn_main_function";
            this.Pn_main_function.Size = new System.Drawing.Size(798, 273);
            this.Pn_main_function.TabIndex = 1;
            // 
            // Btn_DatVe
            // 
            this.Btn_DatVe.FlatAppearance.BorderSize = 0;
            this.Btn_DatVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_DatVe.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DatVe.Image = global::deadline_15_04.Properties.Resources.DatVe;
            this.Btn_DatVe.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_DatVe.Location = new System.Drawing.Point(567, 60);
            this.Btn_DatVe.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_DatVe.Name = "Btn_DatVe";
            this.Btn_DatVe.Size = new System.Drawing.Size(160, 160);
            this.Btn_DatVe.TabIndex = 2;
            this.Btn_DatVe.Text = "Đặt vé";
            this.Btn_DatVe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_DatVe.UseVisualStyleBackColor = true;
            this.Btn_DatVe.Click += new System.EventHandler(this.Btn_DatVe_Click);
            // 
            // Btn_PhongChieuPhim
            // 
            this.Btn_PhongChieuPhim.FlatAppearance.BorderSize = 0;
            this.Btn_PhongChieuPhim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_PhongChieuPhim.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_PhongChieuPhim.Image = global::deadline_15_04.Properties.Resources.PhongChieu;
            this.Btn_PhongChieuPhim.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_PhongChieuPhim.Location = new System.Drawing.Point(320, 60);
            this.Btn_PhongChieuPhim.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_PhongChieuPhim.Name = "Btn_PhongChieuPhim";
            this.Btn_PhongChieuPhim.Size = new System.Drawing.Size(160, 160);
            this.Btn_PhongChieuPhim.TabIndex = 1;
            this.Btn_PhongChieuPhim.Text = "Phòng chiếu phim";
            this.Btn_PhongChieuPhim.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_PhongChieuPhim.UseVisualStyleBackColor = true;
            this.Btn_PhongChieuPhim.Click += new System.EventHandler(this.Btn_PhongChieuPhim_Click);
            // 
            // Btn_DanhMucPhim
            // 
            this.Btn_DanhMucPhim.FlatAppearance.BorderSize = 0;
            this.Btn_DanhMucPhim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_DanhMucPhim.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DanhMucPhim.Image = global::deadline_15_04.Properties.Resources.DanhMucPhim;
            this.Btn_DanhMucPhim.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_DanhMucPhim.Location = new System.Drawing.Point(53, 60);
            this.Btn_DanhMucPhim.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_DanhMucPhim.Name = "Btn_DanhMucPhim";
            this.Btn_DanhMucPhim.Size = new System.Drawing.Size(160, 160);
            this.Btn_DanhMucPhim.TabIndex = 0;
            this.Btn_DanhMucPhim.Text = "Danh mục phim";
            this.Btn_DanhMucPhim.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_DanhMucPhim.UseVisualStyleBackColor = true;
            this.Btn_DanhMucPhim.Click += new System.EventHandler(this.Btn_DanhMucPhim_Click);
            // 
            // Lb_InfoApp
            // 
            this.Lb_InfoApp.AutoSize = true;
            this.Lb_InfoApp.Font = new System.Drawing.Font("MS Reference Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_InfoApp.ForeColor = System.Drawing.Color.White;
            this.Lb_InfoApp.Location = new System.Drawing.Point(333, 4);
            this.Lb_InfoApp.Name = "Lb_InfoApp";
            this.Lb_InfoApp.Size = new System.Drawing.Size(133, 22);
            this.Lb_InfoApp.TabIndex = 2;
            this.Lb_InfoApp.Text = "Rạp Phim ERA";
            // 
            // RapPhim_main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 306);
            this.Controls.Add(this.Lb_InfoApp);
            this.Controls.Add(this.Pn_main_function);
            this.Controls.Add(this.Btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RapPhim_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rap Phim";
            this.Activated += new System.EventHandler(this.RapPhim_main_Activated);
            this.Deactivate += new System.EventHandler(this.RapPhim_main_Deactivate);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RapPhim_main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RapPhim_main_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RapPhim_main_MouseUp);
            this.Pn_main_function.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_close;
        private System.Windows.Forms.Panel Pn_main_function;
        private System.Windows.Forms.Label Lb_InfoApp;
        private System.Windows.Forms.Button Btn_DanhMucPhim;
        private System.Windows.Forms.Button Btn_PhongChieuPhim;
        private System.Windows.Forms.Button Btn_DatVe;
    }
}

