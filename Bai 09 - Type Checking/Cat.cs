using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Cat : Animal
{
    public bool IsIndoor { get; set; }
    public override void MakeSound() => Console.WriteLine("Meow!");
    public void Climb() => Console.WriteLine("Climbing tree!");
}