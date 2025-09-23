using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Car : Vehicle, IStartable
{
    public bool IsRunning { get; set; }

    public void Start()
    {
        Console.WriteLine("Car engine started!");
        IsRunning = true;
    }

    public void Stop()
    {
        Console.WriteLine("Car engine stopped!");
        IsRunning = false;
    }
}
