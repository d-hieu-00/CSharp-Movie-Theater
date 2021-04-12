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
        }

        private void LoadTTPhong(string MaPhong)
        {
            List<string> l = MyResources.MyRapPhim.GetTTPhong(MaPhong);
            Label_TrangThai.Text = l.ToArray()[0];
            Label_SoGhe.Text = l.ToArray()[1];
            Label_TgCL.Text = l.ToArray()[2];
        }

        private void Timer_AutoLoad_Tick(object sender, EventArgs e)
        {
            LoadTTPhong(Cbox_PhongChieu.SelectedItem.ToString());
        }
    }
}
