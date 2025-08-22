// Viết chương trình nhập a,b từ bàn phím và giải phương trình bậc nhất ax+b=0 bằng C#.
// a = double.Parse(Console.Readline())
// if, else

using System;
class Program05
{
    public static void Main()
    {
        int[] a = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Console.WriteLine("=========================");
        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine(a[i]);
        }

        Console.WriteLine("==========================");
        foreach (int x in a)
        {
            Console.WriteLine(x);
        }

        //Console.WriteLine("=========================");
        //for (int i = 0; i < a.Length; i++)
        //{
        //    a[i] = 1;
        //}

        //Console.WriteLine("==========================");
        //foreach (int x in a)
        //{
        //    Console.WriteLine(x);
        //}

        //Console.WriteLine("==========================");
        //foreach (int x in a)
        //{
        //    x = 1; => Read only
        //}
        Console.WriteLine("==========================");
        foreach (int x in a)
        {
            Console.WriteLine(x);
        }
    }

}