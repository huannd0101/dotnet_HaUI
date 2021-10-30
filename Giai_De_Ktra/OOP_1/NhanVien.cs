using System;

namespace Demo
{
    public class NhanVien : TinhLuong
    {
        public string MaNV { get; set; }
        public string ChucVu { get; set; }

        public override float GetLuong()
        {
            float pc = 0f;
            if (ChucVu == "Giam doc")
            {
                pc = 0.5f;
            }
            else if (ChucVu == "Truong phong" || ChucVu == "Pho giam doc")
            {
                pc = 0.4f;
            }
            else if (ChucVu == "Pho phong")
            {
                pc = 0.3f;
            }
            return (HeSoLuong + pc) * LuongCoBan;
        }
    }
}