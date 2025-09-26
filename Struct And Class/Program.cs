// Test với Class
PersonClass person1 = new PersonClass("An", 20);
PersonClass person2 = person1; // person2 tham chiếu đến cùng object
person2.Age = 25;
Console.WriteLine($"person1.Age: {person1.Age}");
Console.WriteLine($"person2.Age: {person2.Age}");
Console.WriteLine($"person1 == person2: {person1 == person2}");

// Test với Struct
PersonStruct struct1 = new PersonStruct("Bình", 20);
PersonStruct struct2 = struct1; // struct2 là bản COPY của struct1
struct2.Age = 25;
Console.WriteLine($"struct1.Age: {struct1.Age}");
Console.WriteLine($"struct2.Age: {struct2.Age}");
Console.WriteLine($"struct1.Equals(struct2): {struct1.Equals(struct2)}");