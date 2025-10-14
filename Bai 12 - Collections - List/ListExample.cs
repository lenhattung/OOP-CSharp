using System;
using System.Collections;

public class ListExample
{
    public static void Main()
    {
        // Sử dụng mảng
        Student[] danhSachSV = new Student[35];
        danhSachSV[0] = new Student(1, "NVA", 9.0);

        // Tạo và sử dụng ArrayList
        ArrayList students = new ArrayList();
        students.Add(new Student(1, "NVA", 9.0));

        for (int i = 1; i < 10; i++)
        {
            students.Add(new Student(i, "Nguyen " + i, i % 10 + 1)); // GPA từ 1-10
        }

        students.RemoveAt(0);

        Console.WriteLine($"=== DANH SACH {students.Count} SINH VIEN ===\n");
        foreach (Student item in students) // Đổi var thành Student
        {
            Console.WriteLine(item);
        }

        // Demo Contains
        Console.WriteLine("\n=== DEMO CONTAINS ===");
        bool found = students.Contains(new Student(15, "", 0));
        Console.WriteLine($"Tim thay sinh vien ID=15: {found}");

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