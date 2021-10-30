using System;

namespace dotnet
{
    public class NhanVien : Nguoi
    {
        public string MaNV {get; set;}
        public string ChucVu {get; set;}
        public long LuongCoBan {get; set;}

        public override void Nhap() {
            base.Nhap();
            Console.Write($"Nhap ma nv: ");
            MaNV = Console.ReadLine();
            Console.Write($"Nhap chuc vu: ");
            ChucVu = Console.ReadLine();
            Console.Write($"Nhap luong co ban: ");
            LuongCoBan = long.Parse(Console.ReadLine());
        }

        public int TinhHeSo() {
            if(ChucVu == "Giam doc") {
                return 10;
            }else if(ChucVu == "Truong phong" || ChucVu == "Pho giam doc") {
                return 6;
            }else if(ChucVu == "Pho phong") {
                return 4;
            }
            return 2;
        }

    }
}