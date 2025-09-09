using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Student
{
    // Private fields
    private string studentId;
    private string fullName;
    private DateTime birthDate;
    private double gpa;
    private bool isActive;

    // Static fields
    private static int totalStudents = 0;
    private static int passedStudents = 0;

    // Constructor
    public Student(string id, string name, DateTime birth, double gpaScore = 0.0)
    {
        StudentId = id;
        FullName = name;
        BirthDate = birth;
        GPA = gpaScore;

        isActive = true;

        totalStudents++;
    }

    public string StudentId
    {
        get { return studentId; }
        set { studentId = value; }
    }

    public string FullName
    {
        get { return fullName; }
        set
        {
            if (!string.IsNullOrEmpty(value))
                fullName = value;
        }
    }

    public DateTime BirthDate
    {
        get { return birthDate; }
        set
        {
            if (value <= DateTime.Now)
                birthDate = value;
        }
    }

    public double GPA
    {
        get { return gpa; }
        set
        {
            if (value >= 0.0 && value <= 4.0)
                gpa = value;
        }
    }

    public bool IsActive
    {
        get { return isActive; }
    }


    // Instance methods
    public void DisplayInfo()
    {
        string status = isActive ? "Đang học" : "Đã tốt nghiệp";
        Console.WriteLine($"ID: {studentId}");
        Console.WriteLine($"Họ tên: {fullName}");
        Console.WriteLine($"Ngày sinh: {birthDate:dd/MM/yyyy}");
        Console.WriteLine($"Tuổi: {CalculateAge()}");
        Console.WriteLine($"GPA: {gpa:F2}");
        Console.WriteLine($"Xếp hạng: {GetGradeLevel()}");
        Console.WriteLine($"Trạng thái: {status}");
        Console.WriteLine(new string('-', 30));
    }

    public int CalculateAge()
    {
        DateTime today = DateTime.Today;
        int age = today.Year - birthDate.Year;

        // Kiểm tra nếu chưa đến sinh nhật trong năm nay
        if (birthDate.Date > today.AddYears(-age))
            age--;

        return age;
    }

    public bool Graduate()
    {
        if (isActive && gpa >= 2.0)
        {
            isActive = false;
            passedStudents++;
            Console.WriteLine($"{fullName} đã tốt nghiệp thành công!");
            return true;
        }
        else if (!isActive)
        {
            Console.WriteLine($"{fullName} đã tốt nghiệp rồi!");
            return false;
        }
        else
        {
            Console.WriteLine($"{fullName} chưa đủ điều kiện tốt nghiệp (GPA < 2.0)!");
            return false;
        }
    }

    public string GetGradeLevel()
    {
        if (gpa >= 3.5) return "Xuất sắc";
        else if (gpa >= 3.0) return "Giỏi";
        else if (gpa >= 2.5) return "Khá";
        else if (gpa >= 2.0) return "Trung bình";
        else return "Yếu";
    }

    // Static methods
    public static int GetTotalStudents()
    {
        return totalStudents;
    }

    public static int GetActiveStudents()
    {
        return totalStudents - passedStudents;
    }

    public static int GetPassedStudents()
    {
        return passedStudents;
    }

    public static void DisplayStudentStatistics()
    {
        Console.WriteLine("=== THỐNG KÊ SINH VIÊN ===");
        Console.WriteLine($"Tổng số sinh viên: {totalStudents}");
        Console.WriteLine($"Đang học: {GetActiveStudents()}");
        Console.WriteLine($"Đã tốt nghiệp: {passedStudents}");
        Console.WriteLine();
    }

}