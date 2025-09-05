using LAB01_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TestLAB01_1
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        LAB01_1.SinhVien sv1 = new LAB01_1.SinhVien();
        //Console.WriteLine(sv1.ToString());
        sv1.show();
        Console.WriteLine("=======================");
       
        LAB01_1.SinhVien sv2 = new LAB01_1.SinhVien("0123", "le nhat tung", "cong nghe thong tin", 9.9);
        //Console.WriteLine(sv2.ToString());
        sv2.show();
        Console.WriteLine("=======================");

        LAB01_1.SinhVien sv3 = new LAB01_1.SinhVien("1234567890", "LE NHAT TUNG", "cong nghe thong tin", 9.9);
        //Console.WriteLine(sv3.ToString());
        sv3.show();
        Console.WriteLine("=======================");

        Console.WriteLine("Nhập vào số lượng sinh viên: ");
        int n = int.Parse(Console.ReadLine());
        LAB01_1.SinhVien[] danhSach = new LAB01_1.SinhVien[n];
        for (int i = 0; i < danhSach.Length; i++)
        {
            Console.WriteLine($"\nNhập vào sinh viên {i}:");
            danhSach[i] = new LAB01_1.SinhVien();
            danhSach[i].input();
        }
        Console.WriteLine("=======================");
        Console.WriteLine("Danh sách sinh viên: ");
        for (int i = 0; i < danhSach.Length; i++)
        {
            //Console.WriteLine(danhSach[i]);
            danhSach[i].show();
        }
    }
}
