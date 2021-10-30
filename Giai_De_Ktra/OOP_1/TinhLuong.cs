using System;

namespace Demo
{
    public class TinhLuong
    {
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public int HeSoLuong { get; set; }
        public int LuongCoBan { get; set; }

        public TinhLuong()
        {
            this.HeSoLuong = 1000000;
        }
        public TinhLuong(string hoTen, string diaChi, int heSoLuong, int luongCoBan)
        {
            this.HoTen = hoTen;
            this.DiaChi = diaChi;
            this.HeSoLuong = heSoLuong;
            this.LuongCoBan = luongCoBan;
        }

        public virtual float GetLuong()
        {
            return HeSoLuong * LuongCoBan;
        }
    }
}