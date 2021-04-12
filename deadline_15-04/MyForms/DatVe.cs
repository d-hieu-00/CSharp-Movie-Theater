using deadline_15_04.Entity;
using deadline_15_04.MyForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deadline_15_04
{
    public partial class DatVe : Form
    {
        //Bitmap Bmp_TTVe;
        public DatVe()
        {
            InitializeComponent();
            this.Visible = false;
            Grbox_Filter.Focus();
            Grbox_TTVePhim.Hide();
            LoadPhim();
            
        }
        private void AutoLoad(object sender, EventArgs e)
        {
            if (MyResources.AutoLoadDV)
            {
                this.Hide();
                LoadPhim();
                this.Show();
                MyResources.Form_DanhMucPhim.Focus();
                MyResources.AutoLoadDV = false;
                MyResources.AutoLoadDV = false;
            }
        }
        #region load Phim
        public FlowLayoutPanel CreatePhim(Phim t)
        {
            FlowLayoutPanel pn_tmp = new FlowLayoutPanel();
            PictureBox pic_tmp = new PictureBox();
            Label lb_tmp = new Label();
            // 
            // flowLayoutPanel
            // 
            pn_tmp.BackColor = System.Drawing.Color.DarkCyan;
            //pn_tmp.BorderStyle = BorderStyle.FixedSingle;
            pn_tmp.Controls.Add(pic_tmp);
            pn_tmp.Controls.Add(lb_tmp);
            pn_tmp.Name = t.MaPhim;
            pn_tmp.Size = new System.Drawing.Size(892, 155);
            // 
            // pictureBox
            // 
            pic_tmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pic_tmp.Image = t.Hinh;
            pic_tmp.Name = t.MaPhim + "_pic";
            pic_tmp.Size = new System.Drawing.Size(100, 150);
            pic_tmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // label
            // 
            lb_tmp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_tmp.ForeColor = System.Drawing.Color.White;
            lb_tmp.Name = t.MaPhim + "_name";
            lb_tmp.Size = new System.Drawing.Size(182, 153);
            lb_tmp.Text = t.TenPhim;
            lb_tmp.Dock = DockStyle.Fill;
            //lb_tmp.BackColor = Color.Gray;

            return pn_tmp;
        }
        private Button CreateSCDay(int d, int m, int y, string name, int ck)
        {
            Button temp = new Button();
            string _d = d.ToString();
            if (_d.Length < 2)
                _d = "0" + _d;
            string _m = m.ToString();
            if (_m.Length < 2)
                _m = "0" + _m;
            string text = _d + "/" + _m + "/" + y.ToString();
            // 
            // button Day
            // 
            temp.BackColor = System.Drawing.Color.LimeGreen;
            temp.Enabled = false;
            temp.FlatAppearance.BorderSize = 0;
            temp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            temp.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            temp.ForeColor = System.Drawing.Color.White;
            temp.Location = new System.Drawing.Point(3, 3);
            temp.Name = name;
            temp.Size = new System.Drawing.Size(80, 29);
            temp.TabIndex = 0;
            temp.Text = text;
            temp.UseVisualStyleBackColor = false;
            if (ck > 0)
                temp.BackColor = Color.LightCoral;
            else if (ck == 0)
                temp.BackColor = Color.LimeGreen;
            else
                temp.BackColor = Color.Goldenrod;
            return temp;
        }
        private FlowLayoutPanel CreateSCHourLayout(string name, int ck)
        {
            Color c;
            if (ck > 0)
                c = Color.LightCoral;
            else if (ck == 0)
                c = Color.LimeGreen;
            else
                c = Color.Goldenrod;
            // 
            // flowLayoutPanel Gio Chieu layout
            // 
            FlowLayoutPanel temp = new FlowLayoutPanel
            {
                BorderStyle = System.Windows.Forms.BorderStyle.None,
                Location = new System.Drawing.Point(88, 3),
                Margin = new System.Windows.Forms.Padding(2, 3, 2, 3),
                Name = name,
                Size = new System.Drawing.Size(226, 34),
                ForeColor = c
            };
            temp.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            //temp.ForeColor = Color.Black;
            return temp;
        }
        private void Panel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, (sender as Panel).ClientRectangle, (sender as Panel).ForeColor, ButtonBorderStyle.Solid);
        }
        private Button CreateSCHour(int h, int m, string MaPhong, string name, int ck)
        {
            Button temp = new Button();
            string _h = h.ToString();
            if (_h.Length < 2)
                _h = "0" + _h;
            string _m = m.ToString();
            if (_m.Length < 2)
                _m = "0" + _m;
            // 
            // button Gio chieu
            // 
            temp.BackColor = System.Drawing.Color.Teal;
            temp.FlatAppearance.BorderSize = 0;
            temp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            temp.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            temp.ForeColor = System.Drawing.Color.White;
            temp.Location = new System.Drawing.Point(2, 2);
            temp.Margin = new System.Windows.Forms.Padding(2);
            temp.Name = name;
            temp.Size = new System.Drawing.Size(70, 29);
            temp.TabIndex = 12;
            temp.Text = _h + ":" + _m + "-" + MaPhong;
            if (ck > 0)
            {
                temp.Enabled = false;
                temp.BackColor = Color.LightCoral;
            }
            else if (ck == 0)
            {
                //temp.Enabled = false;
                temp.BackColor = Color.LimeGreen;
            }
            else
            {
                temp.ForeColor = Color.White;
                temp.BackColor = Color.Goldenrod;
            }
            temp.Click += new EventHandler(this.Btn_Hour_Click_orderDatVe);
            return temp;

        }
        private int DangDienRa(int d, int m, int y, int h, int mi, int time)
        {
            DateTime now = DateTime.Now;
            DateTime input = new DateTime(y, m, d, h, mi, 0);
            int t = (int)(now - input).TotalMinutes;
            if (now.CompareTo(input) >= 0)
            {
                if (t > time)
                    return 1;
                else
                    return 0;
            }
            else
                return -1;
        }
        private int DangDienRa(int d, int m, int y)
        {
            DateTime now = DateTime.Now;
            DateTime input = new DateTime(y, m, d);
            int t = (int)(now - input).TotalDays;
            if (now.CompareTo(input) >= 0)
            {
                if (t >= 1)
                    return 1;
                else
                    return 0;
            }
            else
                return -1;
        }
        private void LoadTTSuatChieuDatVe(Phim t, FlowLayoutPanel PnFlow_Phim)
        {
            List<SuatChieu> list = t.ListSC;
            for (int i = 0; i < list.Count; i++)
            {
                int ck = DangDienRa(list[i].Ngay, list[i].Thang, list[i].Nam);
                if (ck > 0)
                    continue;
                PnFlow_Phim.Controls.Add(CreateSCDay(list[i].Ngay, list[i].Thang, list[i].Nam, t.MaPhim, ck));
                FlowLayoutPanel SCLayout = CreateSCHourLayout(t.MaPhim, ck);
                int n = 0;
                for (int j = i; j < list.Count; j++)
                {
                    ck = DangDienRa(list[j].Ngay, list[j].Thang, list[j].Nam, list[j].Gio, list[j].Phut, t.ThoiLuong);
                    if (list[j].Ngay == list[i].Ngay && list[j].Thang == list[i].Thang && list[j].Nam == list[i].Nam)
                    {
                        SCLayout.Controls.Add(CreateSCHour(list[j].Gio, list[j].Phut, list[j].MaPhong, list[j].MaSuatChieu, ck));
                        n++;
                    }
                    else
                        break;
                }
                i += n - 1;
                SCLayout.Size = new Size(456, 34 * ((n > 6) ? 2 : 1));
                PnFlow_Phim.Controls.Add(SCLayout);
            }
        }  
        private void LoadPhim()
        {
            List<Phim> listP = MyResources.MyRapPhim.ListPhim;
            PnFlow_DatVe.Controls.Clear();
            foreach (Phim i in listP)
            {
                if (i.TrangThai != "Ngừng chiếu")
                {
                    FlowLayoutPanel PnFlow_Phim = CreatePhim(i);
                    FlowLayoutPanel SC = new FlowLayoutPanel()
                    {
                        BackColor = Color.WhiteSmoke,
                        Size = new Size(592, 149),
                        AutoScroll = true
                    };
                    LoadTTSuatChieuDatVe(i, SC);
                    PnFlow_Phim.Controls.Add(SC);
                    PnFlow_DatVe.Controls.Add(PnFlow_Phim);
                    //PnFlow_DatVe.Controls.Add(SC);
                }

            }
        }
        #endregion
        #region Dat Ve
        private void HienThiThongTinVe(Phim t, SuatChieu s)
        {
            Grbox_TTVePhim.Show();
            Label_TenPhim.Text = t.TenPhim.Substring(0, (t.TenPhim.Length > 15) ? 15 : t.TenPhim.Length);
            Label_TenPhim.Name = t.MaPhim;
            Label_PhongChieu.Text = s.MaPhong;
            Label_NgayChieu.Text = s.Ngay + "/" + s.Thang + "/" + s.Nam;
            Label_GioChieu.Text = s.Gio + ":" + s.Phut;
            Label_ThoiLuong.Text = t.ThoiLuong.ToString() + " phút";
            Label_TongTien.Text = "0";
            PnFlow_GheDaDat.Name = s.MaSuatChieu;
            PnFlow_GheDaDat.Controls.Clear();
        }
        private void ClearTTVe()
        {
            Grbox_TTVePhim.Show();
            Label_TenPhim.Text = "";
            Label_TenPhim.Name = "";
            Label_PhongChieu.Text = "";
            Label_NgayChieu.Text = "";
            Label_GioChieu.Text = "";
            Label_ThoiLuong.Text = "";
            Label_TongTien.Text = "";
            PnFlow_GheDaDat.Controls.Clear();
        }
        private Panel CreateDatGhePanel(Phim t, SuatChieu s)
        {
            Panel pn = new Panel();
            Label lb_LV = new Label();
            Label lb_MH = new Label();
            pn.BackColor = System.Drawing.Color.PeachPuff;
            pn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pn.Controls.Add(lb_LV);
            pn.Controls.Add(lb_MH);
            pn.Location = new System.Drawing.Point(3, 55);
            pn.Name = "PnFLow_DatGhe";
            pn.Size = new System.Drawing.Size(907, 432);
            // 
            // Buttons Ghe
            // 
            List<Ghe> li = MyResources.MyRapPhim.GetListGheFollowSC(t, s);
            int soGhe = MyResources.MyRapPhim.FindPhong(s.MaPhong).SoGhe;
            for (int i = 0; i < soGhe - 7; i++)
            {
                Ghe _tmp = li[i];
                Button btn_ghe = new Button
                {
                    BackColor = System.Drawing.Color.White,
                    FlatStyle = System.Windows.Forms.FlatStyle.Flat,
                    Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                    ForeColor = System.Drawing.Color.Black,
                    Size = new System.Drawing.Size(41, 26),
                    Text = _tmp.MaGhe,
                    UseVisualStyleBackColor = false
                };
                btn_ghe.FlatAppearance.BorderSize = 0;
                btn_ghe.Click += this.Btn_GheClick;
                if(_tmp.TrangThai != "Trống")
                {
                    btn_ghe.Enabled = false;
                    btn_ghe.BackColor = Color.LightGray;
                }
                string ma = _tmp.MaGhe.Substring(0, 1);
                int stt = Convert.ToInt32(_tmp.MaGhe.Substring(1, 2));
                int day = Convert.ToInt32(ma.ToCharArray()[0]);
                btn_ghe.Location = new System.Drawing.Point(768, 70);
                int[] arrX = { 768, 721, 623, 576, 529, 482, 435, 388, 341, 294, 197, 150, 103, 56 };
                int[] arrXForI = { 721, 576, 482, 388, 294, 150, 56 };
                if (ma == "I")
                {
                    btn_ghe.Location = new System.Drawing.Point(arrXForI[stt - 1], 70 + (day - 65) * 40);
                    btn_ghe.Size = new System.Drawing.Size(88, 26);
                }
                else
                    btn_ghe.Location = new System.Drawing.Point(arrX[stt - 1], 70 + (day-65) * 40);
                pn.Controls.Add(btn_ghe);
            }
            // 
            // Labels Alplabet
            // 
            for (int i=0; i<9; i++)
            {
                Label tmp = new Label
                {
                    AutoSize = true,
                    Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                    Location = new System.Drawing.Point(14, 75 + i*40),
                    Size = new System.Drawing.Size(17, 17),
                    TabIndex = 1,
                    Text = ((char)(i + 65)).ToString()
                };
                pn.Controls.Add(tmp);
            }
            // 
            // Label_ManHinh
            // 
            lb_MH.BackColor = System.Drawing.Color.SkyBlue;
            lb_MH.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_MH.Location = new System.Drawing.Point(102, 13);
            lb_MH.Name = "Label_ManHinh";
            lb_MH.Size = new System.Drawing.Size(659, 34);
            lb_MH.TabIndex = 15;
            lb_MH.Text = "Màn hình";
            lb_MH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_LoiVao
            // 
            lb_LV.BackColor = System.Drawing.Color.DarkSlateGray;
            lb_LV.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_LV.ForeColor = System.Drawing.Color.White;
            lb_LV.Location = new System.Drawing.Point(825, 390);
            lb_LV.Name = "Label_LoiVao";
            lb_LV.Size = new System.Drawing.Size(70, 26);
            lb_LV.TabIndex = 16;
            lb_LV.Text = "Lối vào";
            lb_LV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            return pn;
        }
        private void CreateDatGheLayout(Phim t, SuatChieu s)
        {
            Button btn_huy = new Button();
            Label lb_tp = new Label();
            Button btn_dv = new Button();
            Panel pn_dg = CreateDatGhePanel(t, s);
            // 
            // Btn_Huy
            // 
            btn_huy.BackColor = System.Drawing.Color.IndianRed;
            btn_huy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_huy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_huy.ForeColor = System.Drawing.Color.White;
            btn_huy.Location = new System.Drawing.Point(3, 3);
            btn_huy.Name = "Btn_Huy";
            btn_huy.Size = new System.Drawing.Size(60, 46);
            btn_huy.TabIndex = 11;
            btn_huy.Text = "Hủy";
            btn_huy.UseVisualStyleBackColor = false;
            btn_huy.Click += this.Btn_HuyClick;
            // 
            // LabelTenPhim
            // 
            lb_tp.BackColor = System.Drawing.Color.DarkCyan;
            lb_tp.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_tp.ForeColor = System.Drawing.Color.White;
            lb_tp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            lb_tp.Location = new System.Drawing.Point(69, 0);
            lb_tp.Name = t.MaPhim;
            lb_tp.Size = new System.Drawing.Size(754, 52);
            lb_tp.TabIndex = 0;
            lb_tp.Text = t.TenPhim;
            lb_tp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_DatVe
            // 
            btn_dv.BackColor = System.Drawing.Color.MediumSeaGreen;
            btn_dv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_dv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_dv.ForeColor = System.Drawing.Color.White;
            btn_dv.Location = new System.Drawing.Point(829, 3);
            btn_dv.Name = "Btn_DatVe";
            btn_dv.Size = new System.Drawing.Size(81, 46);
            btn_dv.TabIndex = 12;
            btn_dv.Text = "Đặt vé";
            btn_dv.UseVisualStyleBackColor = false;
            btn_dv.Click += this.Btn_DatVeClick;
            //
            //add to frame
            //
            PnFlow_DatVe.Controls.Clear();
            PnFlow_DatVe.Controls.Add(btn_huy);
            PnFlow_DatVe.Controls.Add(lb_tp);
            PnFlow_DatVe.Controls.Add(btn_dv);
            PnFlow_DatVe.Controls.Add(pn_dg);
        }
        private void Btn_Hour_Click_orderDatVe(object sender, EventArgs e)
        {
            Control c = (sender as Button);
            string MaPhim = c.Parent.Name;
            string MaSC = c.Name;
            Phim t = MyResources.MyRapPhim.FindPhim(MaPhim);
            SuatChieu s = t.FindSuatChieu(MaSC);
            if(t == null || s == null)
            {
                MessageBox.Show("Error in find SC or find flim", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Btn_HienTatCa.Enabled = false;
            Btn_Filter.Enabled = false;
            CreateDatGheLayout(t, s);
            HienThiThongTinVe(t, s);
        }
        private void Btn_HuyClick(object sender, EventArgs e)
        {
            ClearTTVe();
            Grbox_TTVePhim.Hide();
            Btn_HienTatCa.Enabled = true;
            Btn_Filter.Enabled = true;
            LoadPhim();
        }
        private HoaDon GetHoaDonForSave()
        {
            List<string> listGhe = new List<string>();
            foreach (Control i in PnFlow_GheDaDat.Controls)
                listGhe.Add(i.Text);
            if (listGhe.Count == 0)
                return null;
            return new HoaDon()
            {
                MaPhim = Label_TenPhim.Name,
                MaSuatChieu = PnFlow_GheDaDat.Name,
                MaGhe = listGhe,
                NgayDatVe = DateTime.Now,
                ThanhTien = Convert.ToInt32(Label_TongTien.Text.Replace(".", ""))
            };
        }
        #region InHoaDon
        private void Doc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            GroupBox grd = Grbox_TTVePhim;
            Bitmap bmp = new Bitmap(grd.Width, grd.Height, grd.CreateGraphics());
            grd.DrawToBitmap(bmp, new Rectangle(0, 0, grd.Width, grd.Height));
            RectangleF bounds = e.PageSettings.PrintableArea;
            float factor = ((float)bmp.Height / (float)bmp.Width);
            e.Graphics.DrawImage(bmp, bounds.Left, bounds.Top, bounds.Width, factor * bounds.Width);
        }
        private void PrintHoaDon()
        {
            PrintDocument doc = new System.Drawing.Printing.PrintDocument();
            PrintPreviewDialog p = new PrintPreviewDialog();
            p.Document = doc;
            doc.PrintPage += new PrintPageEventHandler(Doc_PrintPage);
            p.ShowDialog();
        }
        #endregion
        private void Btn_DatVeClick(object sender, EventArgs e)
        {
            HoaDon hd = GetHoaDonForSave();
            if (hd == null)
            {
                MessageBox.Show("Bạn ơi chơi đồ à ???\n Chưa chọn ghế kìa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MyResources.MyRapPhim.ListHoaDon.Add(hd);
            if (MessageBox.Show("Thêm hóa đơn thành công!!!\n" +
                "Có muốn in hóa đơn ???", "In hóa đơn", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                PrintHoaDon();
            ClearTTVe();
            Grbox_TTVePhim.Hide();
            Btn_HienTatCa.Enabled = true;
            Btn_Filter.Enabled = true;
            LoadPhim();
        }
        private void Btn_GheClick(object sender, EventArgs e)
        {
            Control c = (sender as Button);
            int tt;
            Ghe t;
            if (c.BackColor == Color.Gold)
            {
                c.BackColor = Color.White;
                PnFlow_GheDaDat.Controls.Remove(PnFlow_GheDaDat.Controls.Find(c.Text, false)[0]);
                tt = Convert.ToInt32(Label_TongTien.Text.Replace(".",""));
                t = MyResources.MyRapPhim.FindPhong(Label_PhongChieu.Text).FindGhe(c.Text);
                if (t == null)
                {
                    MessageBox.Show("Error in find_slot", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                tt -= t.Gia;
                Label_TongTien.Text = string.Format("{0:N}", tt).Replace(".00", "").Replace(",", ".");
                return;
            }
            Label tmp = new Label
            {
                AutoSize = true,
                Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                Location = new System.Drawing.Point(3, 0),
                Name = c.Text,
                Size = new System.Drawing.Size(29, 17),
                TabIndex = 7,
                Text = c.Text
            };
            c.BackColor = Color.Gold;
            PnFlow_GheDaDat.Controls.Add(tmp);
            tt = Convert.ToInt32(Label_TongTien.Text.Replace(".",""));
            t = MyResources.MyRapPhim.FindPhong(Label_PhongChieu.Text).FindGhe(c.Text);
            if (t == null)
            {
                MessageBox.Show("Error in find slot", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tt += t.Gia;
            Label_TongTien.Text = string.Format("{0:N}", tt).Replace(".00", "").Replace(",", ".");
        }
        #endregion
        // 
        // Xem tt hoa don 
        //
        private void Btn_ThongTinHoaDon_Click(object sender, EventArgs e)
        {
            ThongTinHoaDon a = new ThongTinHoaDon(
                MyResources.MyRapPhim.GetTTHoaDonTheoNgay(DateTime_Ngay.Value), 
                DateTime_Ngay.Value);
            a.Show();
            a.Activate();
        }
        #region Filter
        private void Btn_HienTatCa_Click(object sender, EventArgs e)
        {
            DateTime_Ngay.Value = DateTime.Now;
            foreach (Control i in PnFlow_DatVe.Controls)
                i.Show();
        }
        private void Btn_Filter_Click(object sender, EventArgs e)
        {
            foreach(Control i in PnFlow_DatVe.Controls)
                if (!MyResources.MyRapPhim.CheckPhimSameDate(i.Name, DateTime_Ngay.Value))
                    i.Hide();
        }
        #endregion

    }
}
