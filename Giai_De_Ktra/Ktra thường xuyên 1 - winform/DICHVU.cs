using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaoThiHongPhuong212
{
    public class DICHVU
    {
        protected string maKH;
        protected string tenKH;
        protected string doiTuong;

        public DICHVU() { }
        public DICHVU(string maKH, string tenKH, string doiTuong)
        {
            this.maKH = maKH;
            this.tenKH = tenKH;
            this.doiTuong = doiTuong;
        }

        public string MaKH { get => maKH; set => maKH = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string DoiTuong { get => doiTuong; set => doiTuong = value; }

        public virtual List<string> Xuat()
        {
            List<string> list = new List<string>();

            list.Add(this.maKH);
            list.Add(this.tenKH);
            list.Add(this.doiTuong);

            return list;
        }
    }
}
