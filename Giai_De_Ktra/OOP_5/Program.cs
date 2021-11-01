using System;
using System.Text;
using System.Collections.Generic;

namespace ktra
{
    class Program
    {
        static List<NhanVienBanHang> nhanViens = new List<NhanVienBanHang>();
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
                Console.WriteLine($"3. Hiển thị danh sách");
                Console.WriteLine($"4. Thoát");

                Console.WriteLine($"Nhập lựa chọn: ");
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
            Console.WriteLine($"2. Nhập thông tin nhân viên bán hàng");
            int c = int.Parse(Console.ReadLine());
            if(c == 1) {
                Console.WriteLine($"Nhập họ tên: ");
                string hoTen = Console.ReadLine();
                Console.WriteLine($"Nhập ngày tuyển dụng(ngay-thang-nam): ");
                DateTime ngayTuyenDung = DateTime.Parse(Console.ReadLine());
                
                NhanVienBanHang n = new NhanVienBanHang(hoTen, ngayTuyenDung, -1);
                if(IsDuplicate(n)) {
                    Console.WriteLine($"Trùng tên nhân viên");
                    return;
                }
                nhanViens.Add(n);
            }else if(c == 2) {  
                Console.WriteLine($"Nhập họ tên: ");
                string hoTen = Console.ReadLine();
                Console.WriteLine($"Nhập ngày tuyển dụng(ngay-thang-nam): ");
                DateTime ngayTuyenDung = DateTime.Parse(Console.ReadLine());
                Console.WriteLine($"Nhập số lượng bán: ");
                int soLuongBan = int.Parse(Console.ReadLine());
                
                NhanVienBanHang n = new NhanVienBanHang(hoTen, ngayTuyenDung, soLuongBan);

                if(IsDuplicate(n)) {
                    Console.WriteLine($"Trùng tên nhân viên");
                    return;
                }
                nhanViens.Add(n);
            }else {
                Console.WriteLine($"Không có lựa chọn này");
            }
        }
        public static void Show()
        {
            Console.WriteLine($"{"Họ Tên",20}{"Ngày tuyển dụng",20}{"Số lượng bán",20}{"Tiền hoa hồng",20}");
            foreach (var item in nhanViens)
            {
                if(item.SoLuongBan != -1) {
                    Console.WriteLine($"{item.HoTen,20}{item.NgayTuyenDung.ToString("dd/MM/yyyy"),20}{item.SoLuongBan,20}{item.TinhTienHoaHong(),20}");
                }else {
                    Console.WriteLine($"{item.HoTen,20}{item.NgayTuyenDung.ToString("dd/MM/yyyy"),20}{"--------",20}{"--------",20}");
                }
            }
        }

        public static bool IsDuplicate(NhanVienBanHang nhanVien)
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

        public static void Sort() {
            for(int i=0; i<nhanViens.Count - 1; i++) {
                for(int j=i+1; j<nhanViens.Count; j++) {
                    if(DateTime.Compare(nhanViens[i].NgayTuyenDung, nhanViens[j].NgayTuyenDung) > 0) {
                        NhanVienBanHang n = nhanViens[i];
                        nhanViens[i] = nhanViens[j];
                        nhanViens[j] = n;
                    }else if(DateTime.Compare(nhanViens[i].NgayTuyenDung, nhanViens[j].NgayTuyenDung) == 0) {
                        if(String.Compare(nhanViens[i].HoTen, nhanViens[j].HoTen) > 0) {
                             NhanVienBanHang n = nhanViens[i];
                            nhanViens[i] = nhanViens[j];
                            nhanViens[j] = n;
                        }
                    }
                }
            }
        }
    }
}
