using System;

namespace LibraryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Book[] arr = { new Book(101, "Python", "Nandhini", true), new Book(102, "Java", "Peerthi", true), new Book(103, "C#", "Suriya", true), new Book(104, "C", "Kirubha", false) };
            Library library = new Library(arr);
            int choice = 0;
            while (choice != 4)
            {
                Console.WriteLine("Choose the option\n1.Borrow Book\n2.Return Book\n3.Display Books\n4.Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("Enter the title of the book to borrow");
                    string title = Console.ReadLine();
                    library.BorrowBook(title);
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Enter the title of the book to return");
                    string title = Console.ReadLine();
                    library.ReturnBook(title);
                }
                else if (choice == 3)
                {
                    library.DisplayBookDetails();
                }
                else if (choice == 4)
                {
                    break;
                }
            }
        }
    }
}