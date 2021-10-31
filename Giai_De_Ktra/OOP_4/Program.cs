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

            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int choose;

            do
            {
                Console.WriteLine($"-------------------Menu--------------------");
                Console.WriteLine($"1. Thêm");
                Console.WriteLine($"2. Hiển thị danh sách");
                Console.WriteLine($"3. Sắp xếp");
                Console.WriteLine($"4. Thoát");

                Console.WriteLine($"Nhập lựa chọn: ");
                choose = int.Parse(Console.ReadLine());

                switch (choose)
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
                        Console.WriteLine($"Kết thúc");
                        break;
                    default:
                        Console.WriteLine($"Không có lựa chọn này");
                        break;
                }
            } while (choose != 4);

        }

        public static void AddCar()
        {
            try
            {
                Car car = new Car();
                car.Nhap();
                if (IsDuplicate(car))
                {
                    Console.WriteLine($"Trùng biển số xe");
                    return;
                }

                cars.Add(car);
            }catch(Exception e) {
                Console.WriteLine($"Lỗi nhập dữ liệu");
            }
        }
        public static void Show()
        {
            Console.WriteLine($"{"Hãng sản xuất",20}{"Màu sắc",20}{"Biển số xe",20}{"Dòng xe",20}{"Phiên bản",20}{"Giá cơ bản",20}{"Giá xe",20}");
            foreach (var item in cars)
            {
                Console.WriteLine($"{item.HangSanXuat,20}{item.MauSac,20}{item.BienSoXe,20}{item.DongXe,20}{item.PhienBan,20}{item.GiaCoBan,20}{item.TinhGiaXe(),20}");
            }
        }
        public static void Sort()
        {
            for (int i = 0; i < cars.Count - 1; i++)
            {
                for (int j = cars.Count - 1; j > i; j--)
                {
                    if (cars[j - 1].TinhGiaXe() > cars[j].TinhGiaXe())
                    {
                        Car temp = cars[j - 1];
                        cars[j - 1] = cars[j];
                        cars[j] = temp;
                    }
                }
            }
        }

        public static bool IsDuplicate(Car car)
        {
            foreach (var item in cars)
            {
                if (item.BienSoXe == car.BienSoXe)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
