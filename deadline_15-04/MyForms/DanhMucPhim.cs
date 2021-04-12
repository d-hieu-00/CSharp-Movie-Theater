using deadline_15_04.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deadline_15_04
{
    public partial class DanhMucPhim : Form
    {
        public DanhMucPhim()
        {
            InitializeComponent();
            this.Visible = false;
            LoadPhim();
            Grbox_func.Focus();
            Cbox_TrangThai.SelectedIndex = 0;
            Cbox_TrangThai_GrThemPhim.SelectedIndex = 0;
            Cbox_PhongChieu.SelectedIndex = 0;
            Btn_ThemSC.Name = "0000";
            Btn_ThemSC.Enabled = false;
            DateTime_Ngay.MinDate = DateTime.Now;
            Cbox_PhongChieu.Items.Clear();
            for (int i = 0; i < MyResources.MyRapPhim.SoPhong; i++)
                Cbox_PhongChieu.Items.Add(MyResources.MyRapPhim.ListPhong[i].MaPhong);
            Cbox_PhongChieu.SelectedIndex = 0;
        }
        private void AutoLoad(object sender, EventArgs e)
        {
            if (MyResources.AutoLoadDMP)
            {
                this.Hide();
                LoadPhim();
                this.Show();
                MyResources.AutoLoadDMP = false;
            }
        }
        #region CreatePhim
        private FlowLayoutPanel CreatePhim(Phim t)
        {
            FlowLayoutPanel PnFlow_temp = new FlowLayoutPanel();
            PictureBox Picbox_temp = new PictureBox();
            TextBox Tb_temp = new TextBox();
            Label Label_temp = new Label();
            Button Btn_temp1 = new Button();
            Button Btn_temp2 = new Button();
            Button Btn_temp3 = new Button();
            // 
            // flowLayoutPanel
            // 
            PnFlow_temp.BackColor = System.Drawing.Color.DarkCyan;
            PnFlow_temp.Controls.Add(Picbox_temp);
            PnFlow_temp.Controls.Add(Tb_temp);
            PnFlow_temp.Controls.Add(Label_temp);
            PnFlow_temp.Controls.Add(Btn_temp1);
            PnFlow_temp.Controls.Add(Btn_temp2);
            PnFlow_temp.Controls.Add(Btn_temp3);
            PnFlow_temp.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            PnFlow_temp.ForeColor = System.Drawing.Color.White;
            PnFlow_temp.Location = new System.Drawing.Point(3, 3);
            PnFlow_temp.Name = t.MaPhim;
            PnFlow_temp.Size = new System.Drawing.Size(793, 156);
            // 
            // pictureBox
            // 
            Picbox_temp.BackgroundImage = t.Hinh;
            Picbox_temp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Picbox_temp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            Picbox_temp.Location = new System.Drawing.Point(3, 3);
            Picbox_temp.Name = t.MaPhim;
            Picbox_temp.Size = new System.Drawing.Size(100, 150);
            Picbox_temp.TabIndex = 0;
            Picbox_temp.TabStop = false;
            // 
            // textBox
            // tenPhim
            // 
            Tb_temp.BackColor = System.Drawing.Color.DarkCyan;
            Tb_temp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Tb_temp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Tb_temp.ForeColor = System.Drawing.Color.Transparent;
            Tb_temp.Location = new System.Drawing.Point(109, 3);
            Tb_temp.Name = t.MaPhim;
            Tb_temp.ReadOnly = true;
            Tb_temp.Size = new System.Drawing.Size(557, 26);
            Tb_temp.TabIndex = 5;
            Tb_temp.Text = t.TenPhim;
            //
            // Label
            // Mota phim
            //
            Label_temp.BackColor = System.Drawing.Color.DarkCyan;
            Label_temp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Label_temp.Cursor = System.Windows.Forms.Cursors.IBeam;
            Label_temp.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label_temp.ForeColor = System.Drawing.Color.Transparent;
            Label_temp.Location = new System.Drawing.Point(109, 35);
            Label_temp.Name = t.MaPhim;
            Label_temp.Size = new System.Drawing.Size(557, 114);
            Label_temp.Text = t.MoTa;
            // 
            // button trang thai
            // 
            Btn_temp1.BackColor = System.Drawing.Color.DarkCyan;
            Btn_temp1.Enabled = false;
            Btn_temp1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Btn_temp1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Btn_temp1.Location = new System.Drawing.Point(672, 3);
            Btn_temp1.Name = t.MaPhim;
            Btn_temp1.Size = new System.Drawing.Size(113, 35);
            Btn_temp1.TabIndex = 6;
            Btn_temp1.Text = t.TrangThai;
            Btn_temp1.UseVisualStyleBackColor = false;
            // 
            // button suat chieu
            // 
            Btn_temp2.BackColor = System.Drawing.Color.DarkCyan;
            Btn_temp2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Btn_temp2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Btn_temp2.Location = new System.Drawing.Point(672, 55);
            Btn_temp2.Name = t.MaPhim;
            Btn_temp2.Size = new System.Drawing.Size(113, 35);
            Btn_temp2.TabIndex = 3;
            Btn_temp2.Text = "Suất chiếu";
            Btn_temp2.UseVisualStyleBackColor = false;
            Btn_temp2.Click += new EventHandler(this.Btn_Detail_Click);
            // 
            // button edit
            // 
            Btn_temp3.BackColor = System.Drawing.Color.DarkCyan;
            Btn_temp3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Btn_temp3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Btn_temp3.Location = new System.Drawing.Point(672, 106);
            Btn_temp3.Name = t.MaPhim;
            Btn_temp3.Size = new System.Drawing.Size(113, 35);
            Btn_temp3.TabIndex = 4;
            Btn_temp3.Text = "Chỉnh sửa";
            Btn_temp3.UseVisualStyleBackColor = false;
            Btn_temp3.Click += new EventHandler(this.Btn_Edit_Click);


            // more edit

            if (t.TrangThai == "Sắp chiếu")
            {
                Btn_temp1.ForeColor = System.Drawing.Color.Gold;
            }
            else if (t.TrangThai == "Đang chiếu")
            {
                Btn_temp1.ForeColor = System.Drawing.Color.LimeGreen;
            }
            else
            {
                Btn_temp1.ForeColor = System.Drawing.Color.Red;
                //Btn_temp3.Enabled = false;
            }
            return PnFlow_temp;
        }
        private void LoadPhim()
        {
            int n = PnFlow_DanhMucPhim.Controls.Count;
            List<Phim> ListPhim = MyResources.MyRapPhim.ListPhim;
            if (n < ListPhim.Count)
            {
                for (int i = n; i < ListPhim.Count; i++)
                {
                    FlowLayoutPanel temp = CreatePhim(ListPhim[i]);
                    PnFlow_DanhMucPhim.Controls.Add(temp);
                }
            }
        }
        #endregion
        #region Tim kiem
        private void Btn_TimKiem_Click(object sender, EventArgs e)
        {
            string ten = Tbox_TenPhim.Text.ToLower();
            string tt = Cbox_TrangThai.SelectedItem.ToString();
            int n = PnFlow_DanhMucPhim.Controls.Count;
            for(int i=0; i<n; i++)
            {
                string _tenPhim = PnFlow_DanhMucPhim.Controls[i].Controls[1].Text.ToLower();
                string _tt = PnFlow_DanhMucPhim.Controls[i].Controls[3].Text;
                if (_tenPhim.Contains(ten) && _tt.Equals(tt))
                {
                    PnFlow_DanhMucPhim.Controls[i].Visible = true;
                }
                else
                {
                    PnFlow_DanhMucPhim.Controls[i].Visible = false;
                }
            }
        }
        private void Btn_reload_Click(object sender, EventArgs e)
        {
            int n = PnFlow_DanhMucPhim.Controls.Count;
            for (int i = 0; i < n; i++)
            {
                if(PnFlow_DanhMucPhim.Controls[i].Visible == false)
                {
                    PnFlow_DanhMucPhim.Controls[i].Visible = true;
                }
            }
        }
        #endregion
        #region Tab them phim
        private void LoadTTPhimForEdit(Phim t)
        {
            Tbox_TenPhim_GrThemPhim.Text = t.TenPhim;
            Cbox_TrangThai_GrThemPhim.SelectedItem = t.TrangThai;
            Tbox_Mota_GrThemPhim.Text = t.MoTa;
            Num_ThoiLuong.Value = t.ThoiLuong;
            Btn_Save.Name = t.MaPhim;
            Picbox_Phim.Image = t.Hinh;
        }

        private Phim GetTTPhimForSave()
        {
            return new Phim()
            {
                MaPhim = Btn_Save.Name,
                TenPhim = Tbox_TenPhim_GrThemPhim.Text,
                TrangThai = Cbox_TrangThai_GrThemPhim.SelectedItem.ToString(),
                MoTa = Tbox_Mota_GrThemPhim.Text,
                ThoiLuong = (int) Num_ThoiLuong.Value,
                Hinh = Picbox_Phim.Image
            };
        }
        private Phim GetTTPhimForCreate()
        {
            return new Phim()
            {
                MaPhim = MyResources.MyRapPhim.CreateMaPhim(),
                TenPhim = Tbox_TenPhim_GrThemPhim.Text,
                TrangThai = Cbox_TrangThai_GrThemPhim.SelectedItem.ToString(),
                MoTa = Tbox_Mota_GrThemPhim.Text,
                ThoiLuong = (int)Num_ThoiLuong.Value,
                Hinh = Picbox_Phim.Image
            };
        }
        private void ClearTTPhim()
        {
            Tbox_TenPhim_GrThemPhim.Text = "";
            Cbox_TrangThai_GrThemPhim.SelectedIndex = 0;
            Tbox_Mota_GrThemPhim.Text = "";
            Btn_Save.Name = "0000";
            Picbox_Phim.Image = Properties.Resources.none_image;
            Num_ThoiLuong.Value = 1;
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            string MaPhim = (sender as Button).Name;
            List<Phim> listP = MyResources.MyRapPhim.ListPhim;
            Phim t = null;
            foreach (Phim i in listP)
            {
                if (i.MaPhim.Equals(MaPhim))
                {
                    t = i;
                    break;
                }
            }
            if (t == null)
            {
                MessageBox.Show("Error in list<Phim>", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LoadTTPhimForEdit(t);
            Btn_Save.Enabled = true;
            Btn_Create.Enabled = false;
            TabCtl_DanhMucPhim.SelectedIndex = 0;
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            string MaPhim = (sender as Button).Name;
            List<Phim> listP = MyResources.MyRapPhim.ListPhim;
            bool ck = false;
            for (int i=0; i<listP.Count; i++)
            {
                if (listP[i].MaPhim == MaPhim)
                {
                    MyResources.MyRapPhim.ListPhim[i] = GetTTPhimForSave();
                    ck = true;
                    PnFlow_DanhMucPhim.Controls.Clear();
                    LoadPhim();
                    MyResources.AutoLoadDV = true;
                    ClearTTPhim();
                    Btn_Save.Enabled = false;
                    Btn_Create.Enabled = true;
                    break;
                }
            }
            if (!ck)
            {
                MessageBox.Show("Can't Save !!!!\nError in list<Phim>", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Btn_Create_Click(object sender, EventArgs e)
        {
            if (Tbox_TenPhim_GrThemPhim.Text == "")
            {
                MessageBox.Show("Không tạo phim mới !!\nNhập đủ thông tin", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MyResources.MyRapPhim.ListPhim.Add(GetTTPhimForCreate());
            PnFlow_DanhMucPhim.Controls.Clear();
            LoadPhim();
            MyResources.AutoLoadDV = true;
            ClearTTPhim();
        }

        private void Btn_HinhPhim_Click(object sender, EventArgs e)
        {
            string imageLocation;
            OpenFileDialog Odialog_temp = new OpenFileDialog();
            Odialog_temp.Filter = "jgp files(*.jpg)|*.jpg| PNG files(*.png)|*.png";
            Odialog_temp.Multiselect = false;
            if (Odialog_temp.ShowDialog() == DialogResult.OK)
            {
                imageLocation = Odialog_temp.FileName;
                Picbox_Phim.Image = Image.FromFile(imageLocation);
            }
        }

        #endregion
        #region Tab thong tin suat chieu
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
                _h = "0" +_h;
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
                temp.Enabled = false;
                temp.BackColor = Color.LimeGreen;
            }
            else
            {
                temp.ForeColor = Color.White;
                temp.BackColor = Color.Goldenrod;
            }
            temp.Click += new EventHandler(this.Btn_Hour_Click_deleteHour);
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
        private void LoadTTSuatChieu(Phim t)
        {
            List<SuatChieu> list = t.ListSC;
            PnFLow_SuatChieu.Controls.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                int ck = DangDienRa(list[i].Ngay, list[i].Thang, list[i].Nam);
                PnFLow_SuatChieu.Controls.Add(CreateSCDay(list[i].Ngay, list[i].Thang, list[i].Nam, t.MaPhim, ck));
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
                i += n-1;
                SCLayout.Size = new Size(226, 34 * ((n > 6) ? 3 : ((n > 3) ? 2 : 1)));
                PnFLow_SuatChieu.Controls.Add(SCLayout);

            }
        }
        private void Btn_Detail_Click(object sender, EventArgs e)
        {
            string MaPhim = (sender as Button).Name;
            List<Phim> listP = MyResources.MyRapPhim.ListPhim;
            Phim t = null;
            foreach (Phim i in listP)
            {
                if (i.MaPhim.Equals(MaPhim))
                {
                    t = i;
                    break;
                }
            }
            if (t == null)
            {
                MessageBox.Show("Error in list<Phim>", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LoadTTSuatChieu(t);
            TabCtl_DanhMucPhim.SelectedIndex = 1;
            Btn_ThemSC.Name = t.MaPhim;
            Btn_ThemSC.Enabled = true;
        }
        private SuatChieu GetTTSCForSave(Phim t)
        {
            SuatChieu temp = new SuatChieu()
            {
                MaSuatChieu = t.CreateMaSuatChieu(),
                Ngay = (int) DateTime_Ngay.Value.Day,
                Thang = (int)DateTime_Ngay.Value.Month,
                Nam = (int)DateTime_Ngay.Value.Year,
                Gio = (int)Num_Gio.Value,
                Phut = (int)Num_Phut.Value,
                MaPhong = Cbox_PhongChieu.SelectedItem.ToString()
            };
            int ck = DangDienRa(temp.Ngay, temp.Thang, temp.Nam, temp.Gio, temp.Phut, t.ThoiLuong);
            /*if(ck >= 0)
            {
                MessageBox.Show("Vui lòng chọn ngày giờ sớm hơn", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }*/
            return temp;
        }
        private void ClearTTSC()
        {
            DateTime_Ngay.Value = DateTime_Ngay.MinDate;
            Num_Gio.Value = Num_Gio.Minimum;
            Num_Phut.Value = Num_Phut.Minimum;
            Cbox_PhongChieu.SelectedIndex = 0;
        }
        private void Btn_ThemSC_Click(object sender, EventArgs e)
        {
            string MaPhim = (sender as Button).Name;
            List<Phim> listP = MyResources.MyRapPhim.ListPhim;
            bool ck = false;
            for (int i = 0; i < listP.Count; i++)
            {
                if (listP[i].MaPhim.Equals(MaPhim))
                {
                    ck = true;
                    SuatChieu sc = GetTTSCForSave(MyResources.MyRapPhim.ListPhim[i]);
                    if (sc == null)
                        return;
                    if (MyResources.MyRapPhim.CheckSameSC(listP[i], sc))
                    {
                        MessageBox.Show("Trùng giờ chiếu (có thể với phim khác)!!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    MyResources.MyRapPhim.ListPhim[i].ListSC.Add(sc);
                    MyResources.MyRapPhim.ListPhim[i].Sort_SuatChieu();
                    ClearTTSC();
                    MyResources.AutoLoadDV = true;
                    LoadTTSuatChieu(MyResources.MyRapPhim.ListPhim[i]);
                    break;
                }
            }
            if (!ck)
            {
                MessageBox.Show("Can't Save !!!!\nError in list<Phim>", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void Btn_Hour_Click_deleteHour(object sender, EventArgs e)
        {
            string MaPhim = Btn_ThemSC.Name;
            List<Phim> listP = MyResources.MyRapPhim.ListPhim;
            bool ck = false;

            for (int i = 0; i < listP.Count; i++)
            {
                if (listP[i].MaPhim.Equals(MaPhim))
                {
                    bool ck1 = false;
                    List<SuatChieu> listSC = MyResources.MyRapPhim.ListPhim[i].ListSC;
                    string TenPhim = MyResources.MyRapPhim.ListPhim[i].TenPhim;
                    string MaSuatChieu = (sender as Button).Name;

                    ck = true;
                    for (int j=0; j < listSC.Count; j++)
                    {
                        if (listSC[j].MaSuatChieu.Equals(MaSuatChieu))
                        {
                            string ThoiGian = listSC[j].Ngay + "/" + listSC[j].Thang + "/" + listSC[j].Nam + " " +
                                listSC[j].Gio + ":" + listSC[j].Phut;
                            string PhongChieu = listSC[j].MaPhong;
                            
                            ck1 = true;
                            if (MessageBox.Show("Xác nhận xóa suất chiếu:\n" +
                                "Phim: " + TenPhim + "\n" +
                                "Thời gian: " + ThoiGian + "\n" +
                                "Phòng: " + PhongChieu, "Cảnh báo xóa suất chiếu", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                MyResources.MyRapPhim.ListPhim[i].ListSC.RemoveAt(j);
                            }
                            break;
                        }
                    }
                    if (!ck1)
                    {
                        MessageBox.Show("Can't handle !!!!\nError in list<SuatChieu>", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    MyResources.AutoLoadDV = true;
                    LoadTTSuatChieu(MyResources.MyRapPhim.ListPhim[i]);
                    break;
                }
            }
            if (!ck)
            {
                MessageBox.Show("Can't handle !!!!\nError in list<Phim>", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        #endregion

    }
}
