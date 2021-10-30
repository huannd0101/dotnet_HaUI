using System;
using System.Text;
using System.Collections.Generic;

namespace Demo
{
    class Program
    {
        static List<NhanVien> nhanViens = new List<NhanVien>();
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
                        AddNhanVien();
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

        public static void AddNhanVien()
        {
            NhanVien nhanVien = new NhanVien();
            Console.Write($"Nhập tên: ");
            nhanVien.HoTen = Console.ReadLine();
            Console.Write($"Nhập địa chỉ: ");
            nhanVien.DiaChi = Console.ReadLine();
            Console.Write($"Nhập hệ số luong: ");
            nhanVien.HeSoLuong = int.Parse(Console.ReadLine());
            Console.Write($"Nhập lương cơ bản: ");
            nhanVien.LuongCoBan = int.Parse(Console.ReadLine());
            Console.Write($"Nhập mã nhân viên: ");
            nhanVien.MaNV = Console.ReadLine();
            Console.Write($"Nhập chức vụ: ");
            nhanVien.ChucVu = Console.ReadLine();

            nhanViens.Add(nhanVien);

        }
        public static void Show()
        {
            Title();
            foreach (var item in nhanViens)
            {
                Console.WriteLine($"{item.HoTen,20} {item.DiaChi,20} {item.HeSoLuong,20} {item.LuongCoBan,20} {item.MaNV,20} {item.ChucVu,20} {item.GetLuong(),20}");
            }
        }
        public static void Sort()
        {
            for (int i = 0; i < nhanViens.Count - 1; i++)
            {
                for (int j = nhanViens.Count - 1; j > i; j--)
                {
                    if (nhanViens[j - 1].GetLuong() > nhanViens[j].GetLuong())
                    {
                        NhanVien temp = nhanViens[j - 1];
                        nhanViens[j - 1] = nhanViens[j];
                        nhanViens[j] = temp;
                    }
                }
            }
        }

        public static void Title()
        {
            Console.WriteLine($"{"Họ tên",20} {"Địa chỉ",20} {"Hệ số lương",20} {"Lương cơ bản",20} {"Mã nhân viên",20} {"Chức vụ",20} {"Lương",20}");
        }
    }
}
