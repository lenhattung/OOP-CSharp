// Test với toán tử is
Animal[] animals = {
    new Dog { Name = "Buddy", Breed = "Golden Retriever" },
    new Cat { Name = "Whiskers", IsIndoor = true },
    new Animal { Name = "Generic Animal" }
};

foreach (Animal animal in animals)
{
    Console.WriteLine($"Checking {animal.Name}:");

    // Kiểm tra kiểu cụ thể
    if (animal is Dog)
    {
        Console.WriteLine("  -> This is a Dog!");
    }

    if (animal is Cat)
    {
        Console.WriteLine("  -> This is a Cat!");
    }

    // Kiểm tra kiểu base
    if (animal is Animal)
    {
        Console.WriteLine("  -> This is an Animal!"); // Luôn true
    }

    Console.WriteLine();
}


object[] objects = {
    new Dog { Name = "Max" },
    new Cat { Name = "Luna" },
    "This is a string",
    123,
    null
};

foreach (object obj in objects)
{
    Console.WriteLine($"Processing object: {obj?.ToString() ?? "null"}");

    // Safe casting với as
    Dog dog = obj as Dog;
    if (dog != null)
    {
        Console.WriteLine($"  -> Successfully cast to Dog: {dog.Name}");
        dog.Fetch();
    }

    Cat cat = obj as Cat;
    if (cat != null)
    {
        Console.WriteLine($"  -> Successfully cast to Cat: {cat.Name}");
        cat.Climb();
    }

    string str = obj as string;
    if (str != null)
    {
        Console.WriteLine($"  -> This is a string with length: {str.Length}");
    }

    Console.WriteLine();
}