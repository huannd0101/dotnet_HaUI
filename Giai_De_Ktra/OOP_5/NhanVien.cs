using System;

namespace ktra
{
    public class NhanVien
    {
        public string HoTen { get; set; }
        public DateTime NgayTuyenDung { get; set; }

        public NhanVien()
        {

        }
        public NhanVien(string hoTen, DateTime ngayTuyenDung)
        {
            this.HoTen = hoTen;
            this.NgayTuyenDung = ngayTuyenDung;
        }
    }
}