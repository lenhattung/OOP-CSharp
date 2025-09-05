using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program6
{
    public static void Main1()
    {

        // I. Mang 1 chieu
        int[] a = new int[10];
        int[] b = new int[3] { 1, 2, 3 };
        int[] c = { 1, 2, 3 };

        for(int i=0; i<a.Length; i++)
        {
            a[i] = i;
        }

        foreach(int x in a)
        {
            Console.Write(x+" ");
        }

        Console.WriteLine("\n==========================");
        // II. Mang 2 chieu (nhieu chieu)
        // a. Kich thuoc cua cac hang giong nhau
        // kieudulieu[,] tenMang;

        int rows = 4;
        int cols = 3;
        // khai bao mang 2 chieu
        int[,] r = new int[rows, cols];
        int v = 0;
        for(int i=0; i<rows; i++)
        {
            for(int j=0; j<cols; j++)
            {
                r[i,j] = v; // r[i][j]
                v++;
            }
        }
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(r[i,j]+" ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\n==========================");
        // b. Kich thuoc cua cac hang khac nhau
        int[][] k = new int[rows][];
        k[0] = new int[2];
        k[1] = new int[3];
        k[2] = new int[4];
        k[3] = new int[5];

        for(int i=0; i < rows; i++)
        {
            for(int j=0; j<k[i].Length; j++)
            {
                k[i][j] = i + j;
            }
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < k[i].Length; j++)
            {
               Console.Write(k[i][j] + " ");
            }
            Console.WriteLine() ;
        }

    }
}