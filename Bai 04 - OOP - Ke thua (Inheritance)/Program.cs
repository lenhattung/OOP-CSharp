using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Developer d1 = new Developer("Tung", 1,5000000, "Dev", "C#", 10);
        Tester t1 = new Tester("Tung", 1, 5000000, "Dev", "Selenium", 100);
        Manager m1 = new Manager("Tung", 1, 5000000, "MN", 5000000, 100);

        // Tính đa hình  - Polymorphism 
        Employee d2 = new Developer("Tung", 1, 5000000, "Dev", "C#", 10);
        Employee t2 = new Tester("Tung", 1, 5000000, "Dev", "Selenium", 100);
        Employee m2 = new Manager("Tung", 1, 5000000, "MN", 5000000, 100);

        Employee[] arr = new Employee[] {d2, t2, m2};
    }
}