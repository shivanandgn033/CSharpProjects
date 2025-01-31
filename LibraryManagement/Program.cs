using System;
using System.Collections.Generic;

class LibraryManagement
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsBorrowed { get; set; }
    }

    static List<Book> library = new List<Book>();

    static void Main()
    {
        string option;
        do
        {
            Console.WriteLine("\nLibrary management");
            Console.WriteLine("1. Add book");
            Console.WriteLine("2. Show books");
            Console.WriteLine("3. Borrow book");
            Console.WriteLine("4. Return book");
            Console.WriteLine("5. Finish");
            Console.Write("Choose option: ");
            option = Console.ReadLine();

            switch (option)
            {
                case "1": AddBook(); break;
                case "2": DisplayBooks(); break;
                case "3": BorrowBook(); break;
                case "4": ReturnBook(); break;
            }
        } while (option != "5");
    }

    static void AddBook()
    {
        Console.Write("Title: ");
        string title = Console.ReadLine();
        Console.Write("Author: ");
        string author = Console.ReadLine();

        library.Add(new Book { Title = title, Author = author, IsBorrowed = false });
        Console.WriteLine("Book added.");
    }

    static void DisplayBooks()
    {
        if (library.Count == 0)
        {
            Console.WriteLine("No books available.");
            return;
        }

        Console.WriteLine("\nBooks:");
        for (int i = 0; i < library.Count; i++)
        {
            var status = library[i].IsBorrowed ? "Borrowed" : "Available";
            Console.WriteLine($"{i + 1}. {library[i].Title} von {library[i].Author} ({status})");
        }
    }

    static void BorrowBook()
    {
        DisplayBooks();
        Console.Write("Book number to borrow: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < library.Count && !library[index].IsBorrowed)
        {
            library[index].IsBorrowed = true;
            Console.WriteLine("Book borrowed.");
        }
        else
        {
            Console.WriteLine("Invalid selection or book already borrowed.");
        }
    }

    static void ReturnBook()
    {
        DisplayBooks();
        Console.Write("Book number to return: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < library.Count && library[index].IsBorrowed)
        {
            library[index].IsBorrowed = false;
            Console.WriteLine("Book returned.");
        }
        else
        {
            Console.WriteLine("Invalid selection or book is not borrowed.");
        }
    }
}