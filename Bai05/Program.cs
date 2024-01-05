using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }
        static void menu()
        {
            QuanLiCD quanliCD = new QuanLiCD();
            int luachon = 0;
            do
            {
                Console.WriteLine("---------------Chuong trinh quan li dia CD----------------");
                Console.WriteLine("1. Them CD.");
                Console.WriteLine("2. Tinh tong gia thanh trung binh.");
                Console.WriteLine("3. Sap xep CD giam dan theo gia thanh.");
                Console.WriteLine("4. Sap xep CD tang dan theo tua cua CD.");
                Console.WriteLine("5. Xuat toan bo dia CD.");
                Console.WriteLine("6. Thoat.");
                Console.WriteLine("-----------------------------------------------------------");
                Console.Write("Vui long nhap lua chon:");
                luachon = int.Parse(Console.ReadLine());
                switch (luachon)
                {
                    case 1:
                        CD cd = new CD();
                        Console.Write("Nhap ma CD:");
                        cd.MaCD = int.Parse(Console.ReadLine());
                        Console.Write("Nhap tua cua CD:");
                        cd.TuaCD = Console.ReadLine();
                        Console.Write("Nhap so bai hat:");
                        cd.SoBaiHat = int.Parse(Console.ReadLine());
                        Console.Write("Nhap gia:");
                        cd.DonGia = int.Parse(Console.ReadLine());
                        quanliCD.ThemCD(cd);
                        break;
                    case 2:
                        double kq = quanliCD.tinhGiaTB();
                        Console.WriteLine("Gia trung binh: {0:#,##0.00}", kq);
                        break;
                    case 3:
                        quanliCD.SapXepGiamTheoGiaThanh();
                        Console.WriteLine("Sap theo gia giam dan.");
                        break;
                    case 4:
                        quanliCD.SapXepTheoTuaCD();
                        Console.WriteLine("Da sap xep.");
                        break;
                    case 5:
                        quanliCD.Xuat();
                        break;
                    case 6:
                        Console.WriteLine("Da ket thuc chuong trinh, hen gap lai.");
                        Console.ReadLine();
                        break;
                }
            } while (luachon != 6);

        }
    }
}
