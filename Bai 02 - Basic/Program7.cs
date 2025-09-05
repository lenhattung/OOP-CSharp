using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bai_02;
using Bai_02.Collections;

class Program7
{
    public static void Main()
    {
        // Toan tu
        // + - * / %
        // += -= *= /= %= (a+=2 <=> a= a+2)
        // ++ tang len 1 gia tri
        // -- giam di 1 gia tri

        int a = 5;
        Console.WriteLine(a++); // 5; a=6
        Console.WriteLine(++a); // a=7; 7
        Console.WriteLine(a--); // 7; a=6
        Console.WriteLine(a--); // 6; a=5
        Console.WriteLine(--a); // a=4; 4
        // 5 7 7 6 4

        // So sanh: > < >= <= == !=

        // && || !

        // >> <<: dich bit
        // 15 (he thap phan) =? he nhi phan
        // 15 = 1111
        // 1111 >> 1 = 111
        // 1111 >> 2 = 11
        // 1111 << 1 = 11110
        Console.WriteLine("\n====================");
        int x = 15;
        x = x << 1;
        Console.WriteLine(x);

        // Toan tu 3 ngoi:
        // bieu thuc 1 ? bieu thuc 2: bieu thuc 3

        int y = 2;
        if (y % 2 == 0)
        {
            Console.WriteLine(y + " la so chan");
        }
        else
        {
            Console.WriteLine(y + " la so le");
        }


        Console.WriteLine(y + " la so " + (y%2==0?"chan":"le"));

        Program8 p = new Program8();
        p.printA();

        Program8a p8a = new Program8a();
        p8a.print8A();
    }
}