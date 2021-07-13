using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaoThiHongPhuong212
{
    public class TIENDIEN : DICHVU
    {
        private int chiSoDau;
        private int chiSoCuoi;
        private string ngayNop;
        public TIENDIEN() : base() { }
        public TIENDIEN(string maKH, string tenKH, string doiTuong, int chiSoDau, int chiSoCuoi, string ngayNop)
            :base(maKH, tenKH, doiTuong)
        {
            this.chiSoDau = chiSoDau;
            this.chiSoCuoi = chiSoCuoi;
            this.ngayNop = ngayNop;
        }

        public int ChiSoDau { get => chiSoDau; set => chiSoDau = value; }
        public int ChiSoCuoi { get => chiSoCuoi; set => chiSoCuoi = value; }
        public string NgayNop { get => ngayNop; set => ngayNop = value; }

        public long TongTien()
        {
            if(string.Compare(doiTuong, "Doanh nghiệp", true) == 0)
            {
                return (this.chiSoCuoi - this.chiSoDau) * 3000;
            }else {
                int kwh = this.chiSoCuoi - this.chiSoDau;
                if(kwh <= 50)
                {
                    return kwh * 1000;
                }else if(kwh <= 100)
                {
                    return 50 * 1000 + (kwh - 50) * 1500;
                }else
                {
                    return 50 * 1000 + 50 * 1500 + (kwh - 100) * 2000;
                }
            }
        }
        public override List<string> Xuat()
        {
            List<string> list = base.Xuat();

            list.Add(chiSoDau.ToString());
            list.Add(chiSoCuoi.ToString());
            list.Add(ngayNop);

            return list;
        }
    }
}
