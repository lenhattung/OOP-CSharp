using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

public class ListExample
{

    public static void Main()
    {
        // Sử dụng mảng
        Student[] danhSachSV = new Student[35];
        danhSachSV[0] = new Student(01, "NVA", 9.0);


        // Tạo và sử dụng danh sách
        ArrayList students = new ArrayList();
        students.Add(new Student(01, "NVA", 9.0));
        for(int i = 10; i < 100; i++)
        {
            students.Add(new Student(i, "Nguyen "+i, i));
        }


        students.RemoveAt(0);


        foreach (var item in students)
        {
            Console.WriteLine(item.ToString());
        }


        Console.ReadKey();

    }
}
