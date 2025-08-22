// Viết chương trình nhập a,b từ bàn phím và giải phương trình bậc nhất ax+b=0 bằng C#.
// a = double.Parse(Console.Readline())
// if, else

using System;
class Program03
{
    public static void Main1() {
        double a, b;

        Console.WriteLine("Giai phuong trinh bac nhat ax + b = 0");
        Console.WriteLine("=====================================");

        // Nhập hệ số a
        Console.Write("Nhap he so a: ");
        a = double.Parse(Console.ReadLine());

        // Nhập hệ số b
        Console.Write("Nhap he so b: ");
        b = double.Parse(Console.ReadLine());

        Console.WriteLine("\nPhuong trinh: {0}x + {1} = 0", a, b);

        // Giải phương trình
        if (a == 0)
        {
            if (b == 0)
            {
                Console.WriteLine("Phuong trinh co vo so nghiem!");
            }
            else
            {
                Console.WriteLine("Phuong trinh vo nghiem!");
            }
        }
        else
        {
            double x = -b / a;
            Console.WriteLine("Nghiem cua phuong trinh: x = {0}", x);
        }

        Console.WriteLine("\nNhan phim bat ky de thoat...");
        Console.ReadKey();
    }

}