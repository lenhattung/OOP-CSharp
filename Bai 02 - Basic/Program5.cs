using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program5
{
    public static void Main1()
    {
        int i = 1;

        while (i <= 10)
        {
            Console.Write(i+" ");
            i++;
        }

        Console.WriteLine("\n=========");

        for(int j=1; j<=10; j++)
        {
            Console.Write(j+" ");
        }

        Console.WriteLine("\n=========");

        for (int k = 1; k <= 10; k++, Console.Write(k+" ")) ;

        Console.WriteLine("\n=========");
        int[] a = new int[5] { 2, 4, 6, 8, 10 };
        foreach(int x in a)
        {
            Console.Write(x+" ");
        }
    }
}
