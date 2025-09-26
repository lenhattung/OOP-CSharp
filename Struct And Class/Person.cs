using System;

// Class phù hợp cho Person vì:
// - Có thể thay đổi được
// - Có thể có nhiều thuộc tính phức tạp
// - Cần identity (định danh)

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public List<string> Hobbies { get; set; }
    public DateTime DateOfBirth { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
        Hobbies = new List<string>();
    }

    public void AddHobby(string hobby)
    {
        Hobbies.Add(hobby);
    }

    public override string ToString()
    {
        return $"{Name} ({Age} tuổi)";
    }
}