using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deadline_15_04.Entity
{
    public class SuatChieu
    {
        private string maSuatChieu;
        private int phut;
        private int gio;
        private int ngay;
        private int thang;
        private int nam;
        private string maPhong;

        public string MaSuatChieu
        {
            get { return maSuatChieu; }
            set { maSuatChieu = value; }
        }
        public int Phut
        {
            get { return phut; }
            set { phut = value; }
        }
        public int Gio
        {
            get { return gio; }
            set { gio = value; }
        }
        public int Ngay
        {
            get { return ngay; }
            set { ngay = value; }
        }
        public int Thang
        {
            get { return thang; }
            set { thang = value; }
        }
        public int Nam
        {
            get { return nam; }
            set { nam = value; }
        }
        public string MaPhong
        {
            get { return maPhong; }
            set { maPhong = value; }
        }

        public SuatChieu()
        {
            maSuatChieu = "000";
            phut = 0;
            gio = 0;
            ngay = 0;
            thang = 0;
            nam = 0;
            maPhong = "00";
        }
    }
}
