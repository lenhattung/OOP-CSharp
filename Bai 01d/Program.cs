// Xac dinh chi so BMI cua mot nguoi
// Can nang va chieu cao (nhap tu ban phim)
// BMI = Cân nặng/Chiều cao^2 , kg va m

using System;

class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        double canNang = 0;
        double chieuCao = 0;

        Console.Write("Nhập vào cân nặng (kg): ");
        canNang = double.Parse(Console.ReadLine());

        Console.Write("Nhập vào chiều cao (m): ");
        chieuCao = double.Parse(Console.ReadLine());

        double bmi = canNang/(chieuCao*chieuCao);

        Console.WriteLine("BMI của bạn là : {0}", bmi);

        Console.WriteLine("Nhập phím bất kỳ để thoát.");
        Console.ReadKey();
    }
}


