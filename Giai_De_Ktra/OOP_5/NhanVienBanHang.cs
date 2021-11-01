using System;

namespace ktra
{
    public class NhanVienBanHang : NhanVien
    {
        public int SoLuongBan { get; set; }

        public NhanVienBanHang() : base()
        {
        }
        public NhanVienBanHang(string hoTen, DateTime ngayTuyenDung, int soLuong) 
            : base(hoTen, ngayTuyenDung)
        {
            this.SoLuongBan = soLuong;
        }

        public int TinhTienHoaHong()
        {
            if(SoLuongBan > 500) {
                return 3000;
            }else if(SoLuongBan >= 100) {
                return 2000;
            }else {
                return 1000;
            }
        }
    }
}