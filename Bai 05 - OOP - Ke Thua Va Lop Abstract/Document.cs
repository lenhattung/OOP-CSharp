using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Document
{
    // Properties
    public string Id { get; protected set; }
    public string Title { get; set; }
    public int Year { get; set; }
    public bool IsAvailable { get; protected set; }

    // Constructor
    public Document(string id, string title, int year)
    {
        Id = id;
        Title = title;
        Year = year;
        IsAvailable = true;
    }

    // Virtual method - có thể override
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Year: {Year}");
        Console.WriteLine($"Status: {(IsAvailable ? "Available" : "Borrowed")}");
    }

    // Abstract method - bắt buộc override
    public abstract string GetType();

    // Virtual methods for borrowing
    public virtual void Borrow()
    {
        if (IsAvailable)
        {
            IsAvailable = false;
            Console.WriteLine($"'{Title}' has been borrowed successfully.");
        }
        else
        {
            Console.WriteLine($"'{Title}' is not available for borrowing.");
        }
    }

    public virtual void Return()
    {
        if (!IsAvailable)
        {
            IsAvailable = true;
            Console.WriteLine($"'{Title}' has been returned successfully.");
        }
        else
        {
            Console.WriteLine($"'{Title}' is already available.");
        }
    }

}
