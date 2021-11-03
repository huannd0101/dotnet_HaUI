using System;
namespace De5_Phuong_461_C3_C1
{
    public class NhanVienThoiVu : NhanVien
    {
        public int SoNgayLamViec { get; set; }

        public NhanVienThoiVu() : base()
        {
        }
        public NhanVienThoiVu(string hoTen, bool gioiTinh, DateTime ngayTuyenDung, int soNgay)
            : base(hoTen, gioiTinh, ngayTuyenDung)
        {
            this.SoNgayLamViec = soNgay;
        }

        public int TinhTienLuong()
        {
            if (SoNgayLamViec > 10)
            {
                return 2000000 + (SoNgayLamViec - 10) * 400000;
            }
            else
            {
                return SoNgayLamViec * 200000;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $"{SoNgayLamViec,20}{TinhTienLuong(),20}";
        }
    }
}