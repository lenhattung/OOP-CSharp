// Tao project: Bai 01c
// Xoa file Program.cs
// Tao file Variables.cs

using System;

class Variables
{
    public static void Main()
    {
        int radius = 4;
        const double PI = 3.14159;
        double circum, area;

        area = PI * radius * radius;
        circum = 2 * PI * radius;

        // in kết quả
        Console.WriteLine("Ban kinh = {0}, PI = {1}", radius, PI);
        Console.WriteLine("Dien tich {0}", area);
        Console.WriteLine("Chu vi {0}", circum);
    }
}

// Cho biết chương trình thực hiện điều gì?