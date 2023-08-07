using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    internal class Library
    {
        public static ArrayList book = new ArrayList();
        public static void BorrowBook(string title)
        {
            Book.Ilend(title);
        }

        public static void ReturnBook(string title)
        {
            foreach (Book i in book)
            {
                if (i.Title.Equals(title))
                {
                    i.IsAvailable = true;
                    Console.WriteLine("Returned");
                }
            }

        }
        public static void DisplayBookDetails()
        {
            foreach (Book i in book)
            {
                Console.WriteLine("Title :" +i.Title + " Author :" + i.Author + " Availablity " + i.IsAvailable);
            }
        }
    }
}
