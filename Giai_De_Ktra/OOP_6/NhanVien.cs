using System;

namespace De5_Phuong_461_C3_C1
{
    public class NhanVien
    {
        public string HoTen { get; set; }
        public bool GioiTinh { get; set; }
        public DateTime NgayTuyenDung { get; set; }

        public NhanVien()
        {

        }
        public NhanVien(string hoTen, bool gioiTinh, DateTime ngayTuyenDung)
        {
            this.HoTen = hoTen;
            this.GioiTinh = gioiTinh;
            this.NgayTuyenDung = ngayTuyenDung;
        }

        public override string ToString()
        {
            return $"{HoTen,20}{GioiTinh,20}{NgayTuyenDung.ToString("dd-MM-yyyy"),20}";
        }
    }
}