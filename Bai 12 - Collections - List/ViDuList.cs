using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ViDuList
{
    public static void Main()
    {
        List<Student> students = new List<Student>();
        students.Add(new Student(1, "Nguyen Van A", 9.0));

        for (int i = 2; i<=10; i++)
        {
            students.Add(new Student(i, "Nguyen Van "+i, i%10+1));
        }

        Console.WriteLine($"=== DANH SACH {students.Count} SINH VIEN ===\n");
        foreach (Student student in students)
        {
            Console.WriteLine(student);
        }

        // Demo Remove
        students.RemoveAt(0);
        Console.WriteLine($"=== DANH SACH {students.Count} SINH VIEN SAU KHI REMOVE 0===\n");
        foreach (Student student in students)
        {
            Console.WriteLine(student);
        }

        // Demo Contains
        Console.WriteLine("\n=== DEMO CONTAINS ===");
        bool found = students.Contains(new Student(15, "", 0));
        Console.WriteLine($"Tim thay sinh vien ID=15: {found}");
        bool found2 = students.Contains(new Student(10, "", 0));
        Console.WriteLine($"Tim thay sinh vien ID=10: {found2}");


        // Demo Sort
        Console.WriteLine("\n=== SAP XEP THEO GPA ===");
        students.Sort();
        foreach (Student item in students) // Đổi var thành Student
        {
            Console.WriteLine(item);
        }

        Console.ReadKey();

    }
}

