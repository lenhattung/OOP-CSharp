using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Magazine : Document
{
    // Additional properties specific to Magazine
    public int Issue { get; set; }
    public string Month { get; set; }

    // Constructor
    public Magazine(string id, string title, int year, int issue, string month)
        : base(id, title, year)
    {
        Issue = issue;
        Month = month;
    }

    // Override abstract method
    public override string GetType()
    {
        return "Magazine";
    }

    // Override virtual method
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Issue: {Issue}");
        Console.WriteLine($"Month: {Month}");
        Console.WriteLine($"Type: {GetType()}");
    }

    // Override borrow method with specific logic for magazines
    public override void Borrow()
    {
        if (IsAvailable)
        {
            base.Borrow();
            Console.WriteLine($"Magazine can be borrowed for 1 week only.");
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
            Console.WriteLine($"Thank you for returning {Title} magazine, Issue {Issue}.");
        }
    }
}

