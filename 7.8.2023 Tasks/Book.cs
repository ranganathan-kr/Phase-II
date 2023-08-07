using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    internal class Book 
    {
        private int id;
        private string? title;
        private string? author;
        private bool isAvailable;

        public Book(int id, string? title, string? author, bool isAvail)
        {
            this.Id = id;
            this.Title = title;
            this.Author = author;
            this.IsAvailable = isAvailable;
        }

        public int Id { get => id; set => id = value; }
        public string? Title { get => title; set => title = value; }
        public string? Author { get => author; set => author = value; }
        public bool IsAvailable { get => isAvailable; set => isAvailable = value; }

        internal static void Ilend(string title)
        {
            int count = 0;
            foreach (Book i in Library.book)
            {
                if (i.Title.Equals(title))
                {
                    i.IsAvailable = false;
                    Console.WriteLine("Borrowed");
                    count++;
                }
            }
            if(count==0) { Console.WriteLine("Book not Available"); }
        }

    }
}
