using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Dog : Animal
{
    public string Breed { get; set; }
    public override void MakeSound() => Console.WriteLine("Woof!");
    public void Fetch() => Console.WriteLine("Fetching ball!");
}