using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DVD : Document
{
    // Additional properties specific to DVD
    public int Duration { get; set; } // in minutes

    // Constructor
    public DVD(string id, string title, int year, int duration)
        : base(id, title, year)
    {
        Duration = duration;
    }

    // Override abstract method
    public override string GetType()
    {
        return "DVD";
    }

    // Override virtual method
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Duration: {Duration} minutes");
        Console.WriteLine($"Type: {GetType()}");
    }

    // Override borrow method with specific logic for DVDs
    public override void Borrow()
    {
        if (IsAvailable)
        {
            base.Borrow();
            Console.WriteLine($"DVD can be borrowed for 3 days. Please handle with care.");
        }
        else
        {
            base.Borrow();
        }
    }

    // Override return method
    public override void Return()
    {
        base.Return();
        if (IsAvailable)
        {
            Console.WriteLine($"Thank you for returning '{Title}' DVD.");
        }
    }
}