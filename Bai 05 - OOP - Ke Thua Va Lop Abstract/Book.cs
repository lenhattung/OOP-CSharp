using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Book : Document
{
    // Additional properties specific to Book
    public string Author { get; set; }
    public string PublishingHouse { get; set; }
    public int Pages { get; set; }


    // Constructor
    public Book(string id, string title, int year, string author, string publishingHouse, int pages)
        : base(id, title, year)
    {
        Author = author;
        PublishingHouse = publishingHouse;
        Pages = pages;
    }

    // Override abstract method
    public override string GetType()
    {
        return "Book";
    }
    // Override virtual method to add specific info
    public override void DisplayInfo()
    {
        base.DisplayInfo(); // Call parent method
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Publishing House: {PublishingHouse}");
        Console.WriteLine($"Pages: {Pages}");
        Console.WriteLine($"Type: {GetType()}");
    }

    // Override borrow method with specific logic for books
    public override void Borrow()
    {
        if (IsAvailable)
        {
            base.Borrow();
            Console.WriteLine($"Remember to return the book '{Title}' by {Author} within 2 weeks.");
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
            Console.WriteLine($"Thank you for returning '{Title}' by {Author}.");
        }
    }
}

