using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deadline_15_04.Entity
{
    public class HoaDon
    {
        private string maPhim;
        private string maSuatChieu;
        private int thanhTien;
        private DateTime ngayDatVe;
        private List<string> maGhe;
        public string MaPhim
        {
            get { return maPhim; }
            set { maPhim = value; }
        }
        public string MaSuatChieu
        {
            get { return maSuatChieu; }
            set { maSuatChieu = value; }
        }
        public int ThanhTien
        {
            get { return thanhTien; }
            set { thanhTien = value; }
        }
        public DateTime NgayDatVe
        {
            get { return ngayDatVe; }
            set { ngayDatVe = value; }
        }
        public List<string> MaGhe
        {
            get { return maGhe; }
            set { maGhe = value; }
        }
        public List<string> GetTTHoaDon()
        {
            List<string> ls = new List<string>();
            ls.Add(MaPhim);
            foreach(Phim i in MyResources.MyRapPhim.ListPhim)
                if (i.MaPhim == MaPhim)
                {
                    ls.Add(i.TenPhim);
                    foreach(SuatChieu j in i.ListSC)
                        if(j.MaSuatChieu == maSuatChieu)
                        {
                            ls.Add(j.MaPhong);
                            ls.Add(j.Ngay + "/" + j.Thang + "/" + j.Nam);
                            ls.Add(j.Gio + ":" + j.Phut);
                            break;
                        }
                    break;
                }
            ls.Add(String.Join(", ", MaGhe.ToArray()));
            ls.Add(string.Format("{0:N}", thanhTien).Replace(".00", "").Replace(",", "."));
            ls.Add(ngayDatVe.ToString());
            return ls;
        }
        public HoaDon()
        {
            maPhim = "0000";
            maSuatChieu = "000";
            thanhTien = 0;
            maGhe = new List<string>();
        }
    }
}
