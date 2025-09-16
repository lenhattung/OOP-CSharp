using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Lớp cha - chứa những gì CHUNG của tất cả nhân viên
public class Employee
{
    // Thuộc tính chung - private với properties tương ứng
    private int id;
    private string name;
    private double baseSalary;
    private string department;

    // Constructor mặc định
    public Employee()
    {
        this.Id = 0;
        this.Name = "No Name";
        this.BaseSalary = 0;
        this.Department = "";
    }

    // Constructor có tham số
    public Employee(string name, int id, double baseSalary, string department)
    {
        this.Name = name;
        this.Id = id;
        this.BaseSalary = baseSalary;
        this.Department = department;
    }

    // Properties cho tất cả các trường private
    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double BaseSalary
    {
        get { return baseSalary; }
        set { baseSalary = value; }
    }

    public string Department
    {
        get { return department; }
        set { department = value; }
    }

    // Phương thức chung
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Tên: {Name}");
        Console.WriteLine($"Mã nhân viên: {Id}");
        Console.WriteLine($"Lương cơ bản: {BaseSalary:C}");
        Console.WriteLine($"Phòng ban: {Department}");
    }

    // Phương thức có thể được ghi đè
    public virtual double CalculateSalary()
    {
        return BaseSalary;
    }

    // Phương thức chung
    public virtual void WorkDaily()
    {
        Console.WriteLine($"{Name} bắt đầu làm việc lúc 8:00 AM");
        Console.WriteLine($"{Name} nghỉ trưa từ 12:00-13:00");
        Console.WriteLine($"{Name} kết thúc công việc lúc 17:30 PM");
    }
}
