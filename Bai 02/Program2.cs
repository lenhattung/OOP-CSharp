using System;

class Program
{
    enum NhietDoNuoc: int
    {
        DoDong = 0,
        DoNguoi = 20,
        DoAm = 40,
        DoNong = 60,
        DoSoi = 100
    }

    public static void Main1()
    {
        NhietDoNuoc nhietDo = NhietDoNuoc.DoNguoi;
        Console.WriteLine($"Tên: {nhietDo}");
        Console.WriteLine($"Giá trị: {(int)nhietDo}");
    }

}
