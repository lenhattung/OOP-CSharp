using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Tester
{
    public static void Main1()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        HocSinh hocSinh = new HocSinh();
        hocSinh.HoTen = "Le Nhat Tung";
        hocSinh.Tuoi = 18;
        hocSinh.DiemTB = 9.5;

        hocSinh.HienThiThongTin();
        Console.WriteLine("=====");
        HocSinh[] danhSach = new HocSinh[10];
        for (int i = 0; i < danhSach.Length; i++)
        {
            danhSach[i] = new HocSinh();
            hocSinh.HoTen = "Nguyen Van " + i;
            hocSinh.Tuoi = 18;
            hocSinh.DiemTB = i;
            hocSinh.HienThiThongTin();
            Console.WriteLine("=====");
        }

        // Test Constructor
        HocSinh hs1 = new HocSinh();
        hs1.HienThiThongTin();
        
        Console.WriteLine("=====");
        HocSinh hs2 = new HocSinh("Nguyen Van AAAAA", 20, 8.5);
        hs2.HienThiThongTin();
        
        Console.WriteLine("=====");
        HocSinh hs3 = new HocSinh("Nguyen Van BBBBB", 18);
        hs3.HienThiThongTin();


        Console.WriteLine("=====");
        hs3.DiemTB = -1;
        hs3.HienThiThongTin();


        Console.WriteLine("=====");
        hs3.DiemTB = 8.5;
        hs3.HienThiThongTin();

        Console.WriteLine(hs3.Tuoi);

        Console.WriteLine("=====");
        Console.WriteLine("Test Tostring: ");
        Console.WriteLine(hs3);

    }
}