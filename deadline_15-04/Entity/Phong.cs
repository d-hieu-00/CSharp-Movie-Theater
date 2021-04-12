using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deadline_15_04.Entity
{
    public class Phong
    {
        private string maPhong;
        private int soGhe;
        private string trangThai;
        private List<Ghe> listGhe;
        public string MaPhong
        {
            get { return maPhong; }
            set { maPhong = value; }
        }
        public int SoGhe
        {
            get { return soGhe; }
            set { soGhe = value; }
        }
        public string TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }
        public List<Ghe> ListGhe
        {
            get { return listGhe; }
            set { listGhe = value; }
        }
        public Ghe FindGhe(string MaGhe)
        {
            foreach (Ghe i in ListGhe)
                if (i.MaGhe == MaGhe)
                    return i;
            return null;
        }
        public Phong()
        {
            maPhong = "00";
            soGhe = 126;// 7 ghế đôi
            trangThai = "Sẵn sàng";
            listGhe = new List<Ghe>();
            for (int i=0; i<soGhe-7; i++)
            {
                Ghe t;
                string ma = ((char)((int)(i / 14) + 65)).ToString();
                int _so = ((i) % 14 + 1);
                string so = (_so / 10 < 1) ? "0" + _so.ToString() : _so.ToString();
                if(ma == "I")
                {
                    t = new Ghe
                    {
                        MaGhe = ma + so,
                        LoaiGhe = "Ghế đôi",
                        Gia = 160000
                    };
                }
                else
                {
                    t = new Ghe
                    {
                        MaGhe = ma + so
                    };
                }
                
                listGhe.Add(t);
            }
        }
    }
}
