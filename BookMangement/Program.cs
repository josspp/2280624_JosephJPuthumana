using System;
using System.Collections.Generic;
using System.Linq;

public class Book
{
    public string BookID { get; set; }
    public string BookName { get; set; }
    public string ISBNNo { get; set; }
    public decimal Price { get; set; }
    public string Publisher { get; set; }
    public int NumberOfPages { get; set; }
    public string Language { get; set; } = "English";
    public string LoT { get; set; } = "Technical";
    public string Summary { get; set; }

    public static bool ValidateBookID(string bookID)
    {
        return bookID.Length == 5 && int.TryParse(bookID, out _);
    }

    public static bool ValidateLoT(string lot)
    {
        var validLots = new[] { ".NET", "Java", "IMS", "V&V", "BI", "RDBMS" };
        return Array.Exists(validLots, l => l == lot);
    }
}

public class BookManagementSystem
{
    private Dictionary<string, Book> books = new Dictionary<string, Book>();

    public void AddBook()
    {
        Console.Write("Enter Book ID (5 digits): ");
        string bookID = Console.ReadLine();
        if (!Book.ValidateBookID(bookID))
        {
            Console.WriteLine("Invalid Book ID. It must be 5 digits.");
            return;
        }

        Console.Write("Enter Book Name: ");
        string bookName = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(bookName))
        {
            Console.WriteLine("Book Name cannot be blank.");
            return;
        }

        Console.Write("Enter ISBN No: ");
        string isbnNo = Console.ReadLine();

        Console.Write("Enter Price: ");
        decimal price;
        while (!decimal.TryParse(Console.ReadLine(), out price))
        {
            Console.Write("Invalid input. Enter Price: ");
        }

        Console.Write("Enter Publisher: ");
        string publisher = Console.ReadLine();

        Console.Write("Enter Number of Pages: ");
        int numPages;
        while (!int.TryParse(Console.ReadLine(), out numPages))
        {
            Console.Write("Invalid input. Enter Number of Pages: ");
        }

        Console.Write("Enter Language (default is English): ");
        string language = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(language))
        {
            language = "English";
        }

        Console.Write("Enter LoT (default is Technical): ");
        string lot = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(lot))
        {
            lot = "Technical";
        }
        else if (!Book.ValidateLoT(lot))
        {
            Console.WriteLine("Invalid LoT. It must be one of the predefined values.");
            return;
        }

        Console.Write("Enter Summary: ");
        string summary = Console.ReadLine();

        var book = new Book
        {
            BookID = bookID,
            BookName = bookName,
            ISBNNo = isbnNo,
            Price = price,
            Publisher = publisher,
            NumberOfPages = numPages,
            Language = language,
            LoT = lot,
            Summary = summary
        };

        books[bookID] = book;
        Console.WriteLine("Book added successfully.");
    }

    public void DisplayBooks()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("No books available.");
            return;
        }

        foreach (var book in books.Values)
        {
            Console.WriteLine(book);
        }
    }

    public void DeleteBook()
    {
        Console.Write("Enter Book ID to delete: ");
        string bookID = Console.ReadLine();

        if (books.Remove(bookID))
        {
            Console.WriteLine("Book deleted successfully.");
        }
        else
        {
            Console.WriteLine("Book ID not found.");
        }
    }

    public void ShowMenu()
    {
        while (true)
        {
            Console.WriteLine("\nBook Management System");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Display Books");
            Console.WriteLine("3. Delete Book");
            Console.WriteLine("4. Exit");
            Console.Write("Select an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    AddBook();
                    break;
                case "2":
                    DisplayBooks();
                    break;
                case "3":
                    DeleteBook();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please select again.");
                    break;
            }
        }
    }
}

class Program
{
    static void Main()
    {
        var system = new BookManagementSystem();
        system.ShowMenu();
    }
}