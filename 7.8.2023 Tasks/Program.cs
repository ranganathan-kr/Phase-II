// See https://aka.ms/new-console-template for more information
using LibraryManagement;

Book book1 = new Book(101, "Tholkappiyam", "JayyaKKavin", true);
Book book2 = new Book(102, "Thirukural", "Ramkumar", true);
Book book3 = new Book(103, "Puranooru", "Parithi", true);
Book book4 = new Book(104, "HahaHoHo", "Sanjai Bro", false);
Library.book.Add(book1);
Library.book.Add(book2);
Library.book.Add(book3);
Library.book.Add(book4);

while (true)
{
    Console.WriteLine("Choose the option\n1.Borrow Book\n2.Return Book\n3.Display Books\n4.Exit");
    int choice = Convert.ToInt32(Console.ReadLine());
    if (choice == 1)
    {
        Console.WriteLine("Enter the title of the book to borrow");
        string? title = Console.ReadLine();
        Library.BorrowBook(title);
    }
    else if (choice == 2)
    {
        Console.WriteLine("Enter the title of the book to return");
        string? title = Console.ReadLine();
        Library.ReturnBook(title);
    }
    else if (choice == 3)
    {
        Library.DisplayBookDetails();
    }
    
    else if (choice == 4)
    {
        break;
    }
}
        