using LAB01_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TesterLab01_1
{
    public static void Main()
    {

        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;


        LAB01_1.SinhVien sv1 = new LAB01_1.SinhVien("01", "le nhat tung", "CNTT", 10);
        Console.WriteLine(sv1.ToString());

        LAB01_1.SinhVien sv2 = new LAB01_1.SinhVien("0123456789", "le nhat tung", "công nghệ thông tin", 10);
        Console.WriteLine(sv2.ToString());

        Console.WriteLine("=================");
        int n = 0;
        Console.WriteLine("Nhập vố số lượng sinh viên (n)");
        n = int.Parse(Console.ReadLine());
        LAB01_1.SinhVien[] danhSach = new LAB01_1.SinhVien[n];
        for(int i = 0; i < danhSach.Length; i++)
        {
            danhSach[i] = new LAB01_1.SinhVien();
            danhSach[i].input();
        }

        Console.WriteLine("=================");
        Console.WriteLine("Danh sách sinh viên đã nhập: ");
        for (int i = 0; i < danhSach.Length; i++)
        {
            danhSach[i].show();
        }
    }
}
