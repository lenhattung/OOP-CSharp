using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Tester02
{
    public static void Main1()
    {
        ThoiGian thoiGian = new ThoiGian();
        Console.WriteLine(thoiGian.ToString());
        Console.WriteLine("==================");

        ThoiGian thoiGian1 = new ThoiGian(2025,09,05,13,35,00);
        Console.WriteLine(thoiGian1.ToString());
        Console.WriteLine("==================");

        ThoiGian thoiGian2 = new ThoiGian(thoiGian1);
        Console.WriteLine(thoiGian2.ToString());
        Console.WriteLine("==================");

        ThoiGian thoiGian3 = new ThoiGian(new DateTime());
        Console.WriteLine(thoiGian3.ToString());
        Console.WriteLine("==================");

        ThoiGian thoiGian4 = new ThoiGian(DateTime.Now);
        Console.WriteLine(thoiGian4.ToString());
        Console.WriteLine("==================");
    }
}