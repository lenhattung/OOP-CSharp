using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Student : IComparable<Student>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double GPA { get; set; }

    public Student(int id, string Name, double GPA)
    {
        this.Id = id;
        this.Name = Name;
        this.GPA = GPA;
    }

    public override string ToString()
    {
        return $"ID: {Id}, Name: {Name}, GPA: {GPA}";
    }

    // Để Contains() hoạt động
    public override bool Equals(object? obj)
    {
        if (obj is Student other)
            return this.Id == other.Id;
        return false;
    }

    public int CompareTo(Student? obj)
    {
        if (obj == null) return 1;

        Student other = obj as Student;
        if (other == null)
            throw new ArgumentException("Object is not a Student");

        // Sắp xếp theo GPA giảm dần
        return other.GPA.CompareTo(this.GPA);
    }

    /*
        < 0: đối tượng hiện tại nhỏ hơn đối tượng so sánh
        = 0: bằng nhau
        > 0: đối tượng hiện tại lớn hơn
     */
}

