using System;

namespace dotnet
{
    public class Nguoi
    {
        public string HoTen {get; set;}
        public string DiaChi {get; set;}

        public virtual void Nhap() {
            Console.Write($"Nhap ho ten: ");
            HoTen = Console.ReadLine();
            Console.Write($"Nhap dia chi: ");
            DiaChi = Console.ReadLine();
        }
    }
}