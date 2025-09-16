using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_04___OOP___Ke_thua__Inheritance_
{
    internal class Developer
    {
        private int id;
        private string name;
        private double baseSalary;
        private string department;
        private string programmingLanguage;
        private int projectCount;

        public Developer()
        {
            this.id = 0;
            this.name = "No Name";
            this.baseSalary = 0;
            this.department = "";
            this.programmingLanguage = "";
            this.projectCount = 0;
        }
        public Developer(string name, int id, double baseSalary, string department,
                       string language, int projectCount)
        {
            this.Name = name;
            this.Id = id;
            this.BaseSalary = baseSalary;
            this.Department = department;
            this.ProgrammingLanguage = language;
            this.ProjectCount = projectCount;
        }
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

        public void DisplayInfo()
        {
            Console.WriteLine($"Tên: {name}");
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Lương cơ bản: {baseSalary:C}");
            Console.WriteLine($"Phòng ban: {department}");
            Console.WriteLine($"Ngôn ngữ: {programmingLanguage}");
            Console.WriteLine($"Số dự án: {projectCount}");
        }

        public double CalculateSalary()
        {
            return baseSalary + (projectCount * 2000);
        }

        public void WorkDaily()
        {
            Console.WriteLine($"{name} bắt đầu làm việc lúc 9:00 AM");
            Console.WriteLine($"{name} nghỉ trưa từ 12:00-13:00");
            Console.WriteLine($"{name} kết thúc công việc lúc 17:30 PM");
        }
    }

    internal class Manager
    {
        private int id;              // TRÙNG LẶP!
        private string name;         // TRÙNG LẶP!
        private double baseSalary;   // TRÙNG LẶP!
        private string department;   // TRÙNG LẶP!
        private double bonus;
        private int teamSize;

        public Manager()
        {
            this.Id = 0;                    // CODE LẶP!
            this.Name = "No Name";          // CODE LẶP!
            this.BaseSalary = 0;            // CODE LẶP!
            this.Department = "";           // CODE LẶP!
            this.bonus = 0;
            this.teamSize = 0;
        }

        public Manager(string name, int id, double baseSalary, string department,
                     double bonus, int teamSize)
        {
            this.Name = name;                   // CODE LẶP!
            this.Id = id;                       // CODE LẶP!
            this.BaseSalary = baseSalary;       // CODE LẶP!
            this.Department = department;       // CODE LẶP!
            this.Bonus = bonus;
            this.TeamSize = teamSize;
        }

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

        public double Bonus { get { return bonus; } set { bonus = value; } }

        public int TeamSize { get { return teamSize; } set { teamSize = value; } }

        public void DisplayInfo()
        {
            Console.WriteLine($"Tên: {name}");
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Lương cơ bản: {baseSalary:C}");
            Console.WriteLine($"Phòng ban: {department}");
            // ... 
        }

        public double CalculateSalary()
        {
            return baseSalary + (bonus);
        }

        public void WorkDaily()
        {
            Console.WriteLine($"{name} bắt đầu làm việc lúc 9:00 AM");
            Console.WriteLine($"{name} nghỉ trưa từ 12:00-13:00");
            Console.WriteLine($"{name} kết thúc công việc lúc 17:30 PM");
        }
    }


    internal class Tester
    {
        private int id;
        private string name;
        private double baseSalary;
        private string department;
        private string testingTool;
        private int bugsFound;

        public Tester()
        {
            this.Id = 0;
            this.Name = "No Name";
            this.BaseSalary = 0;
            this.Department = "";
            this.TestingTool = "";
            this.BugsFound = 0;
        }
        public Tester(string name, int id, double baseSalary, string department,
                       string testingTool, int bugsFound)
        {
            this.Name = name;
            this.Id = id;
            this.BaseSalary = baseSalary;
            this.Department = department;
            this.TestingTool = testingTool;
            this.BugsFound = bugsFound;
        }
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

        public void DisplayInfo()
        {
            Console.WriteLine($"Tên: {name}");
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Lương cơ bản: {baseSalary:C}");
            Console.WriteLine($"Phòng ban: {department}");
            // ... 
        }

        public double CalculateSalary()
        {
            return baseSalary + (bugsFound * 1000);
        }

        public void WorkDaily()
        {
            Console.WriteLine($"{name} bắt đầu làm việc lúc 9:00 AM");
            Console.WriteLine($"{name} nghỉ trưa từ 12:00-13:00");
            Console.WriteLine($"{name} kết thúc công việc lúc 17:30 PM");
        }
    }

    // Vi phạm nguyên tắc DRY (Don't Repeat Yourself)
    // Code lặp lại: Cùng thuộc tính và phương thức được viết nhiều lần
    // Muốn sửa WorkDaily() phải sửa ở 3 chỗ
    // Dễ sai sót: Có thể quên sửa ở một class nào đó
    // Không thể quản lý chung: Không thể tạo danh sách chung cho tất cả nhân viên
}
