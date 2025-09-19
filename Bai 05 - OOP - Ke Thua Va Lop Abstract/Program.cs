using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== LIBRARY MANAGEMENT SYSTEM ===\n");

        // Create library instance
        Library library = new Library();

        // Document d = new Document("---", '-----', 2025);
        // Document d1 = new Book("B001", "The Great Gatsby", 1925, "F. Scott Fitzgerald", "Scribner", 180);

        // Add different types of documents
        library.AddDocument(new Book("B001", "The Great Gatsby", 1925, "F. Scott Fitzgerald", "Scribner", 180));
        library.AddDocument(new Book("B002", "To Kill a Mockingbird", 1960, "Harper Lee", "J.B. Lippincott & Co.", 376));

        library.AddDocument(new Magazine("M001", "National Geographic", 2024, 150, "January"));
        library.AddDocument(new Magazine("M002", "Time Magazine", 2024, 12, "March"));

        library.AddDocument(new DVD("D001", "The Shawshank Redemption", 1994, 142));
        library.AddDocument(new DVD("D002", "Inception", 2010, 148));

        // Display all documents
        library.DisplayAllDocuments();

        // Display statistics
        library.DisplayStatistics();

        // Test borrowing
        Console.WriteLine("\n=== BORROWING DOCUMENTS ===");
        library.BorrowDocument("B001");
        library.BorrowDocument("M001");
        library.BorrowDocument("D001");

        // Try to borrow already borrowed document
        library.BorrowDocument("B001");

        // Display available documents
        library.DisplayAvailableDocuments();

        // Test returning
        Console.WriteLine("\n=== RETURNING DOCUMENTS ===");
        library.ReturnDocument("B001");
        library.ReturnDocument("M001");

        // Display final statistics
        library.DisplayStatistics();

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}