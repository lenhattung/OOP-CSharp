using System;

// Struct - Value Type
public struct PersonStruct
{
    public string Name { get; set; }
    public int Age { get; set; }

    public PersonStruct(string name, int age)
    {
        Name = name;
        Age = age;
    }
}