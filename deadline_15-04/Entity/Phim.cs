using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deadline_15_04.Entity
{
    public class Phim
    {
        private string maPhim;
        private string tenPhim;
        private string moTa;
        private string trangThai;
        private int thoiLuong;
        private List<SuatChieu> listSC;
        private Image hinh;
        public string MaPhim
        {
            get { return maPhim; }
            set { maPhim = value; }
        }
        public string TenPhim
        {
            get { return tenPhim; }
            set { tenPhim = value; }
        }
        public string MoTa
        {
            get { return moTa; }
            set { moTa = value; }
        }
        public string TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }
        public int ThoiLuong
        {
            get { return thoiLuong; }
            set { thoiLuong = value; }
        }
        public List<SuatChieu> ListSC
        {
            get { return listSC; }
            set { listSC = value; }
        }
        public Image Hinh
        {
            get { return hinh; }
            set { hinh = value; }
        }
        public string CreateMaSuatChieu()
        {
            return this.maPhim + (listSC.Count + 1).ToString();
        }
        public void Sort_SuatChieu()
        {
            listSC.Sort(
                delegate (SuatChieu p1, SuatChieu p2)
                {
                    DateTime d1 = new DateTime(p1.Nam, p1.Thang, p1.Ngay);
                    DateTime d2 = new DateTime(p2.Nam, p2.Thang, p2.Ngay);
                    return d1.CompareTo(d2);
                });
        }
        public SuatChieu FindSuatChieu(string MaSuatChieu)
        {
            foreach (SuatChieu i in ListSC)
                if (i.MaSuatChieu == MaSuatChieu)
                    return i;
            return null;
        }
        public Phim()
        {
            maPhim = "0000";
            tenPhim = "none";
            moTa = "none";
            trangThai = "Đang chiếu";
            thoiLuong = 60;
            listSC = new List<SuatChieu>();
            hinh = Properties.Resources.none_image;
            Sort_SuatChieu();
        }
    }
}
