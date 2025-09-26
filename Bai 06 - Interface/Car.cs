using System;

public class Car : Vehicle, IStartable
{
    public bool IsRunning { get; set; }

    public Car() : base()
    {

    }

    public Car(int Id, string Name, string Description, bool IsRunning) : base(Id, Name, Description)
    {
        this.IsRunning = IsRunning;
    }

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
