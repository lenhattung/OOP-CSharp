// Ép kiểu
// Ép kiểu tự động
// Ép kiểu tường minh

using System;
class Program1
{
    public static void Main1()
    {
        //short x = 1;
        //int y = 2;
        //y = x;
        //Console.WriteLine(y);


        //int z = 0;
        //short t = 10;
        //t = z; //=> lỗi
        //Console.WriteLine(t);

        int z = 0;
        short t = 10;
        t = (short)z;
        Console.WriteLine(t);

        int a = 5;
        int b = 2;
        Console.WriteLine("{0}/{1}={2}", a, b, a / b);
        Console.WriteLine("{0}/{1}={2}", a, b, (double) a / b);
    }
}
