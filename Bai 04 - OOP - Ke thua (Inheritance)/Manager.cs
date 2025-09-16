using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Lớp con Manager
public class Manager : Employee
{
    private double bonus;
    private int teamSize;

    // Constructor mặc định
    public Manager() : base()
    {
        this.Bonus = 0;
        this.TeamSize = 0;
    }

    public Manager(string name, int id, double baseSalary, string department,
                  double bonus, int teamSize)
        : base(name, id, baseSalary, department)
    {
        this.Bonus = bonus;
        this.TeamSize = teamSize;
    }

    // Properties cho các trường private
    public double Bonus
    {
        get { return bonus; }
        set { bonus = value; }
    }

    public int TeamSize
    {
        get { return teamSize; }
        set { teamSize = value; }
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Bonus: {Bonus:C}");
        Console.WriteLine($"Kích thước team: {TeamSize}");
    }

    public override double CalculateSalary()
    {
        return BaseSalary + Bonus + (TeamSize * 1000);
    }

    public void ManageTeam()
    {
        Console.WriteLine($"{Name} đang quản lý team gồm {TeamSize} thành viên");
    }
}