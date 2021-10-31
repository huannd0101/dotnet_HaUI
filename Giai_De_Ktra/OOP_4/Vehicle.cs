using System;

namespace ktra
{
    public class Vehicle
    {
        public string HangSanXuat {get; set;}
        public string MauSac {get; set;}

        public virtual void Nhap() {
            Console.Write($"Nhập hãng sản xuất: ");
            HangSanXuat = Console.ReadLine();
            Console.Write($"Nhập màu sắc    : ");
            MauSac = Console.ReadLine();
        }
    }
}