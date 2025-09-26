using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(3 + 5);

        Point p1 = new Point(1, 2);
        Point p2 = new Point(3, 4);

        Console.WriteLine(p1);
        Console.WriteLine(p2);

        Console.WriteLine(p1 + p2);

        Console.WriteLine(p1 - p2);

        Console.WriteLine(p1 *10 );

        Console.WriteLine(p1 == p2); // False
        Console.WriteLine(p1 != p2); // True
    }
}

/*
 * Các quy tắc quan trọng
Toán tử BẮT BUỘC cặp đôi:
    == và !=
    > và <
    >= và <=
    true và false

Toán tử KHÔNG thể nạp chồng:
    = (gán)
    &&, || (logic)
    [] (indexer - có cách khác)
    () (cast - có cách khác)
    new, is, as, typeof
 */

