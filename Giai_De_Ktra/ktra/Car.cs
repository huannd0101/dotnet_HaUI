using System;

namespace ktra
{
    public class Car : Vehicle
    {
        public string BienSoXe { get; set; }
        public string DongXe { get; set; }
        public string PhienBan { get; set; }
        public double GiaCoBan { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write($"Bien so: ");
            BienSoXe = Console.ReadLine();
            Console.Write($"Dong xe: ");
            DongXe = Console.ReadLine();
            Console.Write($"Phien ban: ");
            PhienBan = Console.ReadLine();
            Console.Write($"Gia co ban: ");
            GiaCoBan = double.Parse(Console.ReadLine());
        }

        public double TinhGiaXe()
        {
            double t = 0;
            if(PhienBan == "Standard") {
                t = 0;
            }else if(PhienBan == "Premium") {
                t = 2000;
            }else if(PhienBan == "Deluxe") {
                t = 5000;
            }else if(PhienBan == "Luxury") {
                t = 10000;
            }
            return GiaCoBan + t;
        }
    }
}