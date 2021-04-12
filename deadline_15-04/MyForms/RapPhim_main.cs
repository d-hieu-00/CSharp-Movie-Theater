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
    public partial class RapPhim_main : Form
    {
        private bool dragging = false;
        private Point startPoint;

        public RapPhim_main()
        {
            InitializeComponent();
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            Pn_main_function.Focus();
            this.Close();
            if (MessageBox.Show("Exit programe?", "Confirme exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void RapPhim_main_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void RapPhim_main_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void RapPhim_main_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Btn_close_MouseEnter(object sender, EventArgs e)
        {
            //Btn_close.Font = new Font(Btn_close.Font.FontFamily, Btn_close.Font.Size, FontStyle.Bold);
            Btn_close.BackColor = Color.FromArgb(232, 17, 35);
        }

        private void Btn_close_MouseLeave(object sender, EventArgs e)
        {
            //Btn_close.Font = new Font(Btn_close.Font.FontFamily, Btn_close.Font.Size, FontStyle.Regular);
            Btn_close.BackColor = Color.Gray;
        }

        private void Btn_DanhMucPhim_Click(object sender, EventArgs e)
        {
            Pn_main_function.Focus();
            MyResources.ShowFormDanhMucPhim();
        }

        private void Btn_PhongChieuPhim_Click(object sender, EventArgs e)
        {
            Pn_main_function.Focus();
            MyResources.ShowFormPhongChieuPhim();
        }

        private void Btn_DatVe_Click(object sender, EventArgs e)
        {
            Pn_main_function.Focus();
            MyResources.ShowFormDatVe();
        }

        private void RapPhim_main_Activated(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
            Lb_InfoApp.ForeColor = Color.White; 
            Btn_close.ForeColor = Color.White;
            Btn_close.BackColor = Color.Gray;
        }

        private void RapPhim_main_Deactivate(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            Lb_InfoApp.ForeColor = Color.Gray;
            Btn_close.ForeColor = Color.Gray;
            Btn_close.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DateTime input = new DateTime(2020, 12, 12, 12, 12, 0);
            int t = (int)(now - input).TotalMinutes;
            MessageBox.Show(t.ToString() + "\n" + now.CompareTo(input));
        }
    }
}
