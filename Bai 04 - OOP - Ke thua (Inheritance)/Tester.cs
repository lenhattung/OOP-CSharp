using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Lớp con Tester
public class Tester : Employee
{
    private string testingTool;
    private int bugsFound;

    // Constructor mặc định
    public Tester() : base()
    {
        this.TestingTool = "";
        this.BugsFound = 0;
    }

    public Tester(string name, int id, double baseSalary, string department,
                 string tool, int bugs)
        : base(name, id, baseSalary, department)
    {
        this.TestingTool = tool;
        this.BugsFound = bugs;
    }

    // Properties cho các trường private
    public string TestingTool
    {
        get { return testingTool; }
        set { testingTool = value; }
    }

    public int BugsFound
    {
        get { return bugsFound; }
        set { bugsFound = value; }
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Công cụ test: {TestingTool}");
        Console.WriteLine($"Số bugs tìm được: {BugsFound}");
    }

    public override double CalculateSalary()
    {
        return BaseSalary + (BugsFound * 500); // 500k cho mỗi bug tìm được
    }

    public void TestFeature()
    {
        Console.WriteLine($"{Name} đang test bằng {TestingTool}");
    }
}