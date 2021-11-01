using System;

namespace ktra
{
    public class Vehicle
    {
        public string HangSanXuat {get; set;}
        public string MauSac {get; set;}

        public virtual void Nhap() {
            Console.Write($"Hang san xuat: ");
            HangSanXuat = Console.ReadLine();
            Console.Write($"Mau sac: ");
            MauSac = Console.ReadLine();
        }
    }
}