using System;
using System.Text;
using System.Collections.Generic;

namespace De5_Phuong_461_C3_C1
{
    class Program
    {
        static List<NhanVienThoiVu> nhanViens = new List<NhanVienThoiVu>();
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int choose;

            do
            {
                Console.WriteLine($"-------------------Menu--------------------");
                Console.WriteLine($"1. Nhập thông tin");
                Console.WriteLine($"2. Hiển thị danh sách");
                Console.WriteLine($"3. Sắp xếp");
                Console.WriteLine($"4. Thoát");

                Console.Write($"Nhập lựa chọn: ");
                choose = int.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        Add();
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
                        Console.WriteLine($"Không có lựa chọn này vui lòng nhập lại: ");
                        break;
                }
            } while (choose != 4);

        }

        public static void Add()
        {
            Console.WriteLine($"1. Nhập thông tin nhân viên");
            Console.WriteLine($"2. Nhập thông tin nhân viên thời vụ");
            Console.Write($"Nhập lựa chọn: ");
            
            int c = int.Parse(Console.ReadLine());
            if (c == 1)
            {
                Console.Write($"Nhập họ tên: ");
                string hoTen = Console.ReadLine();
                Console.Write($"Nhập ngày tuyển dụng(ngay-thang-nam): ");
                DateTime ngayTuyenDung = DateTime.Parse(Console.ReadLine());
                Console.Write($"Nhập giới tính(nam/nu): ");
                string temp = Console.ReadLine();
                bool gioiTinh = (temp == "nam") ? true : false;

                NhanVienThoiVu n = new NhanVienThoiVu(hoTen, gioiTinh, ngayTuyenDung, -1);
                if (IsDuplicate(n))
                {
                    Console.WriteLine($"Trùng tên nhân viên");
                    return;
                }
                nhanViens.Add(n);
            }
            else if (c == 2)
            {
                Console.Write($"Nhập họ tên: ");
                string hoTen = Console.ReadLine();
                Console.Write($"Nhập ngày tuyển dụng(ngay-thang-nam): ");
                DateTime ngayTuyenDung = DateTime.Parse(Console.ReadLine());
                Console.Write($"Nhập số ngày làm: ");
                int soNgay = int.Parse(Console.ReadLine());
                Console.Write($"Nhập giới tính(nam/nu): ");
                string temp = Console.ReadLine();
                bool gioiTinh = (temp == "Nam") ? true : false;

                NhanVienThoiVu n = new NhanVienThoiVu(hoTen, gioiTinh, ngayTuyenDung, soNgay);

                if (IsDuplicate(n))
                {
                    Console.WriteLine($"Trùng tên nhân viên");
                    return;
                }
                nhanViens.Add(n);
            }
            else
            {
                Console.WriteLine($"Không có lựa chọn này");
            }
        }
        public static void Show()
        {
            Console.WriteLine($"{"Họ Tên",20}{"Giới tính",20}{"Ngày tuyển dụng",20}{"Số ngày làm việc",20}{"Tiền lương",20}");
            foreach (var item in nhanViens)
            {
                string gioiTinh = (item.GioiTinh) ? "Nam" : "Nữ";
                if (item.SoNgayLamViec != -1)
                {
                    Console.WriteLine($"{item.HoTen,20}{gioiTinh, 20}{item.NgayTuyenDung.ToString("dd/MM/yyyy"),20}{item.SoNgayLamViec,20}{item.TinhTienLuong(),20}");
                }
                else
                {
                    Console.WriteLine($"{item.HoTen,20}{gioiTinh, 20}{item.NgayTuyenDung.ToString("dd/MM/yyyy"),20}{"--------",20}{"--------",20}");
                }
            }
        }

        public static bool IsDuplicate(NhanVienThoiVu nhanVien)
        {
            foreach (var item in nhanViens)
            {
                if (item.HoTen == nhanVien.HoTen)
                {
                    return true;
                }
            }
            return false;
        }

        public static void Sort()
        {
            for (int i = 0; i < nhanViens.Count - 1; i++)
            {
                for (int j = i + 1; j < nhanViens.Count; j++)
                {
                    if (DateTime.Compare(nhanViens[i].NgayTuyenDung, nhanViens[j].NgayTuyenDung) > 0)
                    {
                        NhanVienThoiVu n = nhanViens[i];
                        nhanViens[i] = nhanViens[j];
                        nhanViens[j] = n;
                    }
                    else if (DateTime.Compare(nhanViens[i].NgayTuyenDung, nhanViens[j].NgayTuyenDung) == 0)
                    {
                        if (String.Compare(nhanViens[i].HoTen, nhanViens[j].HoTen) < 0)
                        {
                            NhanVienThoiVu n = nhanViens[i];
                            nhanViens[i] = nhanViens[j];
                            nhanViens[j] = n;
                        }
                    }
                }
            }
        }
    }
}
