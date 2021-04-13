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
    public partial class PhongChieuPhim : Form
    {
        public PhongChieuPhim()
        {
            InitializeComponent();
            this.Visible = false;
            Cbox_PhongChieu.Items.Clear();
            for (int i = 0; i < MyResources.MyRapPhim.SoPhong; i++)
                Cbox_PhongChieu.Items.Add(MyResources.MyRapPhim.ListPhong[i].MaPhong);
            Cbox_PhongChieu.SelectedIndex = 0;
            LoadTTPhong(Cbox_PhongChieu.SelectedItem.ToString());
            LoadPrice(Cbox_PhongChieu.SelectedItem.ToString());
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
        }
        private void LoadTTPhong(string MaPhong)
        {
            List<string> l = MyResources.MyRapPhim.GetTTPhong(MaPhong);
            string tt = l.ToArray()[0];
            if (tt == "Trống")
                Label_TrangThai.ForeColor = Color.Red;
            else
                Label_TrangThai.ForeColor = Color.LimeGreen;
            Label_TrangThai.Text = tt;
            Label_SoGhe.Text = l.ToArray()[1];
            Label_TgCL.Text = l.ToArray()[2];
        }
        public void LoadPrice(string MaPhong)
        {
            List<int> p = MyResources.MyRapPhim.GetPriceRoom(MaPhong);
            Tbox_GiaDon.Text = string.Format("{0:N}", p.ToArray()[0]).Replace(".00", "").Replace(",", ".");
            Tbox_GiaDoi.Text = string.Format("{0:N}", p.ToArray()[1]).Replace(".00", "").Replace(",", ".");
        }
        private void Tbox_DobClick(object sender, EventArgs e)
        {
            TextBox t = (sender as TextBox);
            t.ReadOnly = false;
            t.Text = t.Text.Replace(".", "");
            Btn_Save.Enabled = true;
        }
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            int pSig = Convert.ToInt32(Tbox_GiaDon.Text.Replace(".", ""));
            int pDou = Convert.ToInt32(Tbox_GiaDoi.Text.Replace(".", ""));
            if (MyResources.MyRapPhim.SetPriceRoom(Cbox_PhongChieu.SelectedItem.ToString(), pSig, pDou))
            {
                Btn_Save.Enabled = false;
                Tbox_GiaDon.Text = string.Format("{0:N}", pSig).Replace(".00", "").Replace(",", ".");
                Tbox_GiaDoi.Text = string.Format("{0:N}", pDou).Replace(".00", "").Replace(",", ".");
                Tbox_GiaDon.ReadOnly = true;
                Tbox_GiaDoi.ReadOnly = true;
            }
            else
                MessageBox.Show("Có lỗi éo lưu đc", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Timer_AutoLoad_Tick(object sender, EventArgs e)
        {
            LoadTTPhong(Cbox_PhongChieu.SelectedItem.ToString());
        }
        private void Cbox_PhongChieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPrice(Cbox_PhongChieu.SelectedItem.ToString());
        }
    }
}
