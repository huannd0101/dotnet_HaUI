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
            Console.Write($"Nhập biển số: ");
            BienSoXe = Console.ReadLine();
            Console.Write($"Nhập dòng xe: ");
            DongXe = Console.ReadLine();
            Console.Write($"Nhập phiên bản: ");
            PhienBan = Console.ReadLine();
            Console.Write($"Nhập giá cơ bản: ");
            GiaCoBan = double.Parse(Console.ReadLine());
        }

        public double TinhGiaXe()
        {
            double t = 0;
            if (PhienBan == "Luxury")
            {
                t = 10000;
            }
            else if (PhienBan == "Deluxe")
            {
                t = 5000;
            }
            else if (PhienBan == "Premium")
            {
                t = 2000;
            }
            else if (PhienBan == "Standard")
            {
                t = 0;
            }
            return GiaCoBan + t;
        }
    }
}