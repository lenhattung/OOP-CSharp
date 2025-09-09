using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ClassRoom
{
    // Private fields
    private string className;
    private string teacher;
    private int maxStudents;
    private int currentStudents;
    private DateTime established;

    // Static fields
    private static int totalClasses = 0;
    private static string schoolName = "Trường Đại học ABC";

    // Constructor
    public ClassRoom(string name, string teacherName, int maxSize)
    {
        ClassName = name;
        Teacher = teacherName;
        MaxStudents = maxSize;
        currentStudents = 0;
        Established = DateTime.Now;

        totalClasses++;
    }

    // Properties
    public string ClassName
    {
        get { return className; }
        set
        {
            if (!string.IsNullOrEmpty(value))
                className = value;
        }
    }

    public string Teacher
    {
        get { return teacher; }
        set
        {
            if (!string.IsNullOrEmpty(value))
                teacher = value;
        }
    }

    public int MaxStudents
    {
        get { return maxStudents; }
        set
        {
            if (value > 0 && value >= currentStudents)
                maxStudents = value;
        }
    }

    public int CurrentStudents
    {
        get { return currentStudents; }
    }

    public DateTime Established
    {
        get { return established; }
        set { established = value; }
    }

    // Instance methods
    public void DisplayClassInfo()
    {
        Console.WriteLine($"Tên lớp: {className}");
        Console.WriteLine($"Giáo viên: {teacher}");
        Console.WriteLine($"Sĩ số: {currentStudents}/{maxStudents}");
        Console.WriteLine($"Thành lập: {established:dd/MM/yyyy}");
        Console.WriteLine($"Tuổi lớp: {GetClassAge()} ngày");
        Console.WriteLine($"Trạng thái: {(IsFull() ? "Đã đầy" : "Còn chỗ")}");
        Console.WriteLine($"Thuộc: {schoolName}");
        Console.WriteLine(new string('-', 30));
    }

    public bool AddStudent()
    {
        if (!IsFull())
        {
            currentStudents++;
            Console.WriteLine($"Đã thêm sinh viên vào lớp {className}");
            Console.WriteLine($"Sĩ số hiện tại: {currentStudents}/{maxStudents}");
            return true;
        }
        else
        {
            Console.WriteLine($"Lớp {className} đã đầy! Không thể thêm sinh viên.");
            return false;
        }
    }

    public bool RemoveStudent()
    {
        if (currentStudents > 0)
        {
            currentStudents--;
            Console.WriteLine($"Đã loại sinh viên khỏi lớp {className}");
            Console.WriteLine($"Sĩ số hiện tại: {currentStudents}/{maxStudents}");
            return true;
        }
        else
        {
            Console.WriteLine($"Lớp {className} không có sinh viên nào!");
            return false;
        }
    }

    public bool IsFull()
    {
        return currentStudents >= maxStudents;
    }

    public int GetClassAge()
    {
        return (DateTime.Now - established).Days;
    }

    public double GetOccupancyRate()
    {
        return maxStudents > 0 ? (double)currentStudents / maxStudents * 100 : 0;
    }

    // Static methods
    public static int GetTotalClasses()
    {
        return totalClasses;
    }

    public static string GetSchoolName()
    {
        return schoolName;
    }

    public static void SetSchoolName(string newName)
    {
        if (!string.IsNullOrEmpty(newName))
            schoolName = newName;
    }

    public static void DisplayClassStatistics()
    {
        Console.WriteLine("=== THỐNG KÊ LỚP HỌC ===");
        Console.WriteLine($"Tên trường: {schoolName}");
        Console.WriteLine($"Tổng số lớp: {totalClasses}");
        Console.WriteLine();
    }
}