using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }

    public double GPA { get; set; }

    public Student(int id, string Name, double GPA)
    {
        this.Id = id;
        this.Name = Name;
        this. GPA = GPA;
    }

    public override string ToString()
    {
        return $"ID: {Id}, Name: {Name}, GPA: {GPA}";
    }

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }
}

