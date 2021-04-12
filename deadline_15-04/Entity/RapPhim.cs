using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deadline_15_04.Entity
{
    public class RapPhim
    {
        private int soPhong;
        private List<Phim> listPhim;
        private List<Phong> listPhong;
        private List<HoaDon> listHoaDon;

        public int SoPhong
        {
            get { return soPhong; }
            set { soPhong = value; }
        }
        public List<Phim> ListPhim
        {
            get { return listPhim; }
            set { listPhim = value; }
        }
        public List<Phong> ListPhong
        {
            get { return listPhong; }
            set { listPhong = value; }
        }
        public List<HoaDon> ListHoaDon
        {
            get { return listHoaDon; }
            set { listHoaDon = value; }
        }
        #region Sample
        public static List<SuatChieu> CreateTempSC(string _MaPhim)
        {
            List<SuatChieu> temp = new List<SuatChieu>
            {
                new SuatChieu()
                {
                    Nam = 2020,
                    Thang = 11,
                    Ngay = 21,
                    Gio = 11,
                    Phut = 10,
                    MaPhong = "P01",
                    MaSuatChieu = _MaPhim + "1"
                },
                new SuatChieu()
                {
                    Nam = 2021,
                    Thang = 4,
                    Ngay = 15,
                    Gio = 10,
                    Phut = 20,
                    MaPhong = "P01",
                    MaSuatChieu = _MaPhim + "2"
                },
                new SuatChieu()
                {
                    Nam = 2021,
                    Thang = 4,
                    Ngay = 15,
                    Gio = 15,
                    Phut = 20,
                    MaPhong = "P01",
                    MaSuatChieu = _MaPhim + "3"
                },
                new SuatChieu()
                {
                    Nam = 2021,
                    Thang = 12,
                    Ngay = 21,
                    Gio = 14,
                    Phut = 20,
                    MaPhong = "P01",
                    MaSuatChieu = _MaPhim + "4"
                },
                new SuatChieu()
                {
                    Nam = 2021,
                    Thang = 12,
                    Ngay = 21,
                    Gio = 20,
                    Phut = 20,
                    MaPhong = "P01",
                    MaSuatChieu = _MaPhim + "5"
                }
            };
            return temp;
        }
        public void Sample()
        {
            listPhim.Add(
                new Phim()
                {
                    MaPhim = CreateMaPhim(),
                    TenPhim = "Bố già",
                    ListSC = CreateTempSC(CreateMaPhim()),
                    Hinh = Properties.Resources.bogia1203,
                    MoTa = "Bố Già xoay quanh lối sống thường nhật của một xóm lao động nghèo," +
                        " ở đó có bộ tứ anh em Giàu - Sang - Phú - Quý với Ba Sang sẽ là nhân vật chính, " +
                        "hay lo chuyện bao đồng nhưng vô cùng thương con cái. Câu chuyện phim tập trung về hai cha con Ba Sang và Quắn." +
                        " Dù yêu thương nhau nhưng khoảng cách thế hệ đã đem đến những bất đồng lớn giữa hai cha con." +
                        " Liệu cả hai có thể cho nhau cơ hội thấu hiểu đối phương, thu hẹp khoảng cách và tạo nên hạnh phúc từ sự khác biệt?"
                }
            ); ;
            listPhim.Add(
                new Phim()
                {
                    MaPhim = CreateMaPhim(),
                    TenPhim = "CUỘC CHIẾN SINH TỬ",
                    ListSC = CreateTempSC(CreateMaPhim()),
                    Hinh = Properties.Resources.mortal,
                    MoTa = "Mortal Kombat: Cuộc Chiến Sinh Tử xoay quanh võ sĩ võ thuật tổng hợp Cole Young (Lewis Tan), " +
                    "người mang trên mình một vết chàm rồng đen bí ẩn - biểu tượng của Mortal Kombat. Cole Young không hề biết" +
                    " về dòng máu bí ẩn đang chảy trong người anh, hay vì sao anh lại bị tên sát thủ Sub-Zero (Joe Taslim) săn lùng." +
                    " Vì sự an nguy của gia đình, Cole cùng với một nhóm những chiến binh đã được tuyển chọn để tham gia " +
                    "vào một trận chiến đẫm máu nhằm chống lại những kẻ thù đến từ Outworld."
                }
            );
            listPhim.Add(
                new Phim()
                {
                    MaPhim = CreateMaPhim(),
                    TenPhim = "GODZILLA VS KONG",
                    ListSC = CreateTempSC(CreateMaPhim()),
                    Hinh = Properties.Resources.gocong,
                    MoTa = "Sau các sự kiện diễn ra ở “Godzilla: King of the Monsters”, trong thời đại mà các Titans đòi lại " +
                    "quyền làm chủ hành tinh, cuộc đấu tranh sinh tồn giữa loài người với chúng đã dẫn đến một cuộc chiến không" +
                    " thể tránh khỏi giữa Godzilla và Kong. Trong khi Monarch cố gắng làm sáng tỏ nguồn gốc của Titans, thì vẫn " +
                    "còn đó một âm mưu đen tối với mục đích là tiêu diệt tất cả các Titan và toàn bộ các sinh vật trên Trái Đất ..."
                }
            );
            listPhim.Add(
                new Phim()
                {
                    MaPhim = CreateMaPhim(),
                    TenPhim = "JOSEE: KHI NÀNG THƠ YÊU",
                    ListSC = CreateTempSC(CreateMaPhim()),
                    Hinh = Properties.Resources.josee,
                    MoTa = "Phim xoay quanh cuộc gặp gỡ định mệnh giữa Josee, một cô gái 24 tuổi khuyết tật, sống cùng bà và vô" +
                    " cùng khép kín với cuộc sống bên ngoài. Josee đã luôn sống trong thế giới nhỏ của bản thân, cho tới một buổi" +
                    " tối định mệnh khi cô được cậu sinh viên Tsuneo cứu trong một tai nạn. Mới đầu, Josee còn vô cùng cảnh giác " +
                    "với sự xuất hiện của Tsuneo, tuy nhiên sau đó, khi cậu sinh viên chứng minh được sự chân thành của mình, Josee " +
                    "đã dần mở lòng để Tsuneo khám phá về thế giới bí mật của riêng cô. Về phần Tsuneo, sự xuất hiện của Josee chính " +
                    "là bước ngoặt trong cuộc sống tưởng chừng đã được “mặc định” sẵn từng bước của cậu"
                }
            );
        }
        #endregion
        public string CreateMaPhim()
        {
            return "RP_Era" + (listPhim.Count + 1).ToString();
        }
        public Phim FindPhim(string MaPhim)
        {
            foreach (Phim i in ListPhim)
                if (i.MaPhim == MaPhim)
                    return i;
            return null;
        }
        public Phong FindPhong(string MaPhong)
        {
            foreach (Phong i in ListPhong)
                if (i.MaPhong == MaPhong)
                    return i;
            return null;
        }
        private void SetTTDaDatForGhe(List<Ghe> lg, string MaGhe)
        {
            foreach (Ghe i in lg)
                if (i.MaGhe == MaGhe)
                    i.TrangThai = "Đã đặt";
        }
        public List<Ghe> GetListGheFollowSC(Phim t, SuatChieu s)
        {
            List<Ghe> lg = FindPhong(s.MaPhong).ListGhe;
            List<string> lg_rved = new List<string>();
            foreach (HoaDon i in ListHoaDon)
                if (i.MaPhim == t.MaPhim && i.MaSuatChieu == s.MaSuatChieu)
                    foreach (string j in i.MaGhe)
                        SetTTDaDatForGhe(lg, j);
            return lg;
        }
        public List<Ghe> GetListGheForMaPhon(string MaPhong)
        {
            return null;
        }
        private bool SameDate(DateTime d1, DateTime d2)
        {
            if (d1.Year == d2.Year && d1.Month == d2.Month && d1.Day == d2.Day)
                return true;
            return false;
        }
        public List<List<string>> GetTTHoaDonTheoNgay(DateTime d)
        {
            List<List<string>> ls = new List<List<string>>();
            foreach (HoaDon i in listHoaDon)
                if (SameDate(d, i.NgayDatVe))
                    ls.Add(i.GetTTHoaDon());
            return ls;
        }
        public bool CheckPhimSameDate(string MaPhim, DateTime d)
        {
            foreach (Phim i in listPhim)
                if (i.MaPhim == MaPhim)
                    foreach (SuatChieu j in i.ListSC)
                        if (SameDate(new DateTime(j.Nam, j.Thang, j.Ngay), d))
                            return true;
            return false;
        }
        private bool CheckSameSC(SuatChieu s1, int s1_tl, SuatChieu s2, int s2_tl)
        {
            DateTime d1 = new DateTime(s1.Nam, s1.Thang, s1.Ngay, s1.Gio, s1.Phut, 0);
            DateTime d2 = new DateTime(s2.Nam, s2.Thang, s2.Ngay, s2.Gio, s2.Phut, 0);
            int t = (int)(d1 - d2).TotalMinutes;
            t = Math.Abs(t);
            if (d1.CompareTo(d2) > 0)
            {
                //d1 > d2 sample d1: 12:15 -- d2: 11:25
                //t > s1_tl, s1 can be show after s2
                if (t > s2_tl)
                    return false;
                return true;
            }
            else
            {
                if(t > s1_tl)
                    return false;
                return true;
            }
        }
        private int CheckShowingSC(DateTime d1, SuatChieu s2, int s2_tl)
        {
            DateTime d2 = new DateTime(s2.Nam, s2.Thang, s2.Ngay, s2.Gio, s2.Phut, 0);
            int t = (int)(d1 - d2).TotalMinutes;
            t = Math.Abs(t);
            if (d1.CompareTo(d2) > 0)
            {
                if (t > s2_tl)
                    return -1;
                return Math.Abs(t - s2_tl);
            }
            else
            {
                return -1;
            }
        }
        public bool CheckSameSC(Phim t, SuatChieu s)
        {
            foreach (Phim i in listPhim)
                foreach (SuatChieu j in i.ListSC)
                    if (s.MaPhong == j.MaPhong && CheckSameSC(s, t.ThoiLuong, j, i.ThoiLuong))
                        return true;
            return false;
        }
        private int CountSoGheDaDat(Phim t, SuatChieu s)
        {
            int tt = 0;
            foreach (HoaDon i in listHoaDon)
                if (i.MaPhim == t.MaPhim && s.MaSuatChieu == i.MaSuatChieu)
                    tt += i.MaGhe.Count;
            return tt;
        }
        private string FormatTimestamp(int t)
        {
            int h = (int)t / 60;
            int m = t % 60;
            string _h, _m;
            if (h / 10 > 1)
                _h = h.ToString();
            else
                _h = "0" + h.ToString();
            if (m / 10 > 1)
                _m = m.ToString();
            else
                _m = "0" + m.ToString();
            return _h + ":" + _m;
        }
        public List<string> GetTTPhong(string MaPhong)
        {
            List<string> l = new List<string>();
            string SoGhe = "";
            bool ck = false;

            foreach (Phong i in listPhong)
                if(i.MaPhong == MaPhong)
                {
                    SoGhe = (i.SoGhe - 7).ToString();
                    break;
                }
            foreach (Phim i in listPhim)
                foreach (SuatChieu j in i.ListSC)
                {
                    int t = CheckShowingSC(DateTime.Now, j, i.ThoiLuong);
                    if (MaPhong == j.MaPhong && t != -1)
                    {
                        ck = true;
                        l.Add("Đang chiếu");
                        l.Add(CountSoGheDaDat(i, j).ToString() + "/" + SoGhe);
                        l.Add(FormatTimestamp(t));
                        break;
                    }
                }
            if (!ck)
            {
                l.Add("Trống");
                l.Add("0/" + SoGhe);
                l.Add("00:00");
            }
            return l;
        }
        public RapPhim()
        {
            soPhong = 3;
            listPhim = new List<Phim>();
            listPhong = new List<Phong>();
            listHoaDon = new List<HoaDon>();
            for(int i=0; i<soPhong; i++)
            {
                Phong t = new Phong()
                {
                    MaPhong = "P0" + (i + 1).ToString()
                };
                listPhong.Add(t);
            }
        }
    }
}
