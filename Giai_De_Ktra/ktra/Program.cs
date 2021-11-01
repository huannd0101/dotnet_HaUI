using System;
using System.Text;
using System.Collections.Generic;

namespace ktra
{
    class Program
    {
        static List<Car> cars = new List<Car>();
        static void Main(string[] args)
        {
            int c;

            do
            {
                Console.WriteLine($"1. Them car");
                Console.WriteLine($"2. Hien thi cars");
                Console.WriteLine($"3. Sap xep cars");
                Console.WriteLine($"4. Thoat");
                Console.WriteLine($"Nhap lua chon: ");
                c = int.Parse(Console.ReadLine());

                switch (c)
                {
                    case 1:
                        AddCar();
                        break;
                    case 2:
                        Show();
                        break;
                    case 3:
                        Sort();
                        break;
                    case 4:
                        Console.WriteLine($"Ket thuc");
                        break;
                    default:
                        Console.WriteLine($"Khong ton tai lua chon nay");
                        break;
                }
            } while (c != 4);

        }

        public static void AddCar()
        {
            try
            {
                Car car = new Car();
                car.Nhap();
                foreach (var item in cars)
                {
                    if (item.BienSoXe == car.BienSoXe)
                    {
                        Console.WriteLine($"Trung bien so");
                        return;
                    }
                }

                cars.Add(car);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Loi nhap thong tin xe");
            }
        }
        public static void Show()
        {
            Console.WriteLine($"{"Hang san xuat",25}{"Mau sac",25}{"Bien so xe",25}{"ong xe",25}{"Phien ban",25}{"Gia co ban",25}{"Gia xe",25}");
            foreach (var item in cars)
            {
                Console.WriteLine($"{item.HangSanXuat,25}{item.MauSac,25}{item.BienSoXe,25}{item.DongXe,25}{item.PhienBan,25}{item.GiaCoBan,25}{item.TinhGiaXe(),25}");
            }
        }
        public static void Sort()
        {
            for (int i = 0; i < cars.Count - 1; i++)
            {
                for (int j = i + 1; j <cars.Count; j++)
                {
                    if (cars[i].TinhGiaXe() > cars[j].TinhGiaXe())
                    {
                        Car temp = cars[i];
                        cars[i] = cars[j];
                        cars[j] = temp;
                    }
                }
            }
        }


    }
}
