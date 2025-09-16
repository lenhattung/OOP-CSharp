using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Developer : Employee
{
    private string programmingLanguage;
    private int projectCount;

    // Constructor mặc định
    public Developer() : base()
    {
        this.ProgrammingLanguage = "";
        this.ProjectCount = 0;
    }

    public Developer(string name, int id, double baseSalary, string department,
                  string language, int projectCount)
      : base(name, id, baseSalary, department)  // Gọi constructor lớp cha
    {
        this.ProgrammingLanguage = language;
        this.ProjectCount = projectCount;
    }

    // Properties cho các trường private
    public string ProgrammingLanguage
    {
        get { return programmingLanguage; }
        set { programmingLanguage = value; }
    }

    public int ProjectCount
    {
        get { return projectCount; }
        set { projectCount = value; }
    }

    // Ghi đè phương thức hiển thị thông tin
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Ngôn ngữ lập trình: {ProgrammingLanguage}");
        Console.WriteLine($"Số dự án: {ProjectCount}");
    }

    // Ghi đè phương thức tính lương
    public override double CalculateSalary()
    {
        return BaseSalary + (ProjectCount * 2000);
    }

    // Phương thức riêng của Developer
    public void WriteCode()
    {
        Console.WriteLine($"{Name} đang viết code bằng {ProgrammingLanguage}");
    }
}
