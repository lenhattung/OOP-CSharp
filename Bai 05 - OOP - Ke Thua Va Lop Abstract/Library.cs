using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Library
{
    // Private fields
    private List<Document> documents;

    // Public properties
    public List<Document> Documents
    {
        get { return documents; }
        set { documents = value; }
    }

    public Library()
    {
        documents = new List<Document>();
    }

    // Add document to library
    public void AddDocument(Document doc)
    {
        documents.Add(doc);
        Console.WriteLine($"Added {doc.GetType()}: '{doc.Title}' to library.");
    }
    // Display all documents
    public void DisplayAllDocuments()
    {
        Console.WriteLine("\n=== LIBRARY CATALOG ===");
        if (documents.Count == 0)
        {
            Console.WriteLine("No documents in library.");
            return;
        }

        foreach (Document doc in documents)
        {
            Console.WriteLine($"\n--- {doc.GetType()} ---");
            doc.DisplayInfo();
        }
    }
    // Search document by ID
    public Document SearchById(string id)
    {
        foreach (Document document in documents)
        {
            if (document.Id.Equals(id))
            {
                return document;
            }
        }
        return null;
    }

    // Borrow document by ID
    public void BorrowDocument(string id)
    {
        Document doc = SearchById(id);
        if (doc != null)
        {
            doc.Borrow();
        }
        else
        {
            Console.WriteLine($"Document with ID '{id}' not found.");
        }
    }

    // Return document by ID
    public void ReturnDocument(string id)
    {
        Document doc = SearchById(id);
        if (doc != null)
        {
            doc.Return();
        }
        else
        {
            Console.WriteLine($"Document with ID '{id}' not found.");
        }
    }

    // Display available documents
    public void DisplayAvailableDocuments()
    {
        Console.WriteLine("\n=== AVAILABLE DOCUMENTS ===");
        var available = documents.Where(d => d.IsAvailable);

        if (!available.Any())
        {
            Console.WriteLine("No documents available.");
            return;
        }

        foreach (Document doc in available)
        {
            Console.WriteLine($"{doc.Id} - {doc.Title} ({doc.GetType()})");
        }
    }
    // Get statistics
    public void DisplayStatistics()
    {
        Console.WriteLine("\n=== LIBRARY STATISTICS ===");
        Console.WriteLine($"Total documents: {documents.Count}");
        Console.WriteLine($"Available: {documents.Count(d => d.IsAvailable)}");
        Console.WriteLine($"Borrowed: {documents.Count(d => !d.IsAvailable)}");

        Console.WriteLine($"Books: {documents.OfType<Book>().Count()}");
        Console.WriteLine($"Magazines: {documents.OfType<Magazine>().Count()}");
        Console.WriteLine($"DVDs: {documents.OfType<DVD>().Count()}");
    }
}
