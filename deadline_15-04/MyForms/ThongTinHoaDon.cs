using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deadline_15_04.MyForms
{
    public partial class ThongTinHoaDon : Form
    {
        public ThongTinHoaDon()
        {
            this.Close();
        }
        public ThongTinHoaDon(List<List<string>> l, DateTime d)
        {
            InitializeComponent();
            LisView_TTHoaDon.Items.Clear();
            Label_TT.Text = "Danh sách các hóa đơn ngày " + d.Day + "/" + d.Month + "/" + d.Year;
            foreach (List<string> i in l)
                LisView_TTHoaDon.Items.Add(new System.Windows.Forms.ListViewItem(i.ToArray(), -1));
            this.Deactivate += LostFocusHandle;
        }

        private void LostFocusHandle(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
