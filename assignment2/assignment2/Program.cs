using System;

namespace LibraryManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a library
            Library library = new Library();

            // Create some books
            Book book1 = new PhysicalBook("Book1", "Author1");
            Book book2 = new EBook("Book2", "Author2", "PDF");

            // Add books to the library
            library.AddBook(book1);
            library.AddBook(book2);

            // Display initial library information
            Console.WriteLine("Initial library information:");
            Console.WriteLine("Number of books: " + library.GetBookCount());
            Console.WriteLine();

            // Borrow a book
            library.BorrowBook("Book1");

            // Display updated library information
            Console.WriteLine("Library information after borrowing Book1:");
            Console.WriteLine("Number of books: " + library.GetBookCount());
            Console.WriteLine();

            // Return a book
            library.ReturnItem(DateTime.Now);

            // Display final library information
            Console.WriteLine("Library information after returning a book:");
            Console.WriteLine("Number of books: " + library.GetBookCount());

            Console.ReadLine();
        }
    }
}