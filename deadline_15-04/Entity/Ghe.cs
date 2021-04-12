using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deadline_15_04.Entity
{
    public class Ghe
    {
        private string maGhe;
        private string trangThai;
        private string loaiGhe;
        private int gia;
        public string MaGhe
        {
            get { return maGhe; }
            set { maGhe = value; }
        }
        public string TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }
        public string LoaiGhe
        {
            get { return loaiGhe; }
            set { loaiGhe = value; }
        }
        public int Gia
        {
            get { return gia; }
            set { gia = value; }
        }

        public Ghe()
        {
            maGhe = "00";
            trangThai = "Trống";
            loaiGhe = "Ghế đơn";
            gia = 90000;
        }
    }
}
