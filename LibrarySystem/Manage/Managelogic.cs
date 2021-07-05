using LibrarySystem.Manage.Extended;
using LibrarySystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Manage
{
    public class Managelogic : ManageDatalog
    {
        List<Books> booklist = new List<Books>(){
            new Books{Id = 1, BookName = "Adventures of Tom Sawyer", Author = "Mark Twain", AvaliableCopies = 7, NumberofCopies = 10, Category = "Adventures", Publisher = "Northwest printing", Release = DateTime.Now.AddDays(-56), Createdby = 1 },
             new Books{Id = 2, BookName = "Agni Veena", Author = "Kazi Nasrul Islam", AvaliableCopies = 10, NumberofCopies = 10, Category = "Adventures", Publisher = "Northwest printing", Release = DateTime.Now.AddDays(-46), Createdby = 1 },
             new Books{Id = 3, BookName = "Animal Farm", Author = "George Orwell", AvaliableCopies = 6, NumberofCopies = 10, Category = "Adventures", Publisher = "Northwest printing", Release = DateTime.Now.AddDays(-40), Createdby = 1 },
             new Books{Id = 4, BookName = "Ben Hur", Author = "Lewis Wallace", AvaliableCopies = 9, NumberofCopies = 10, Category = "Adventures", Publisher = "Northwest printing", Release = DateTime.Now.AddDays(-40), Createdby = 1 },
             new Books{Id = 5, BookName = "Baburnama", Author = "Babur", AvaliableCopies = 10, NumberofCopies = 10, Category = "Adventures", Publisher = "Northwest printing", Release = DateTime.Now.AddDays(-40), Createdby = 1 },
              new Books{Id = 6, BookName = "Fifty Shades of Grey (Fifty Shades, #1)", Author = "E.L. James", AvaliableCopies = 3, NumberofCopies = 10, Category = "Love", Publisher = "Northwest printing", Release = DateTime.Now.AddDays(-100), Createdby = 1 },
               new Books{Id = 7, BookName = "Beautiful Disaster (Beautiful, #1)", Author = "Jamie McGuire", AvaliableCopies = 7, NumberofCopies = 10, Category = "Love", Publisher = "Northwest printing", Release = DateTime.Now.AddDays(-10), Createdby = 1 },
                new Books{Id = 8, BookName = "Bared to You (Crossfire, #1)", Author = "Sylvia Day", AvaliableCopies = 7, NumberofCopies = 10, Category = "Love", Publisher = "Northwest printing", Release = DateTime.Now.AddDays(-70), Createdby = 1 },
                 new Books{Id = 9, BookName = "Fifty Shades Darker (Fifty Shades, #2)", Author = "E.L. James", AvaliableCopies = 5, NumberofCopies = 10, Category = "Love", Publisher = "Northwest printing", Release = DateTime.Now.AddDays(-70), Createdby = 1 },
                  new Books{Id = 10, BookName = "Gabriel's Inferno (Gabriel's Inferno, #1)", Author = "Sylvain Reynard", AvaliableCopies = 5, NumberofCopies = 10, Category = "Love", Publisher = "Northwest printing", Release = DateTime.Now.AddDays(-80), Createdby = 1 },
        };
        public override void BookList()
        {
            var result = booklist.ToList();
            Show("****************************************************************");
            Show("List of Book");
            Show("****************************************************************");

            foreach (var item in result)
            {
                Show("");
                Console.WriteLine($"Book Name: {item.BookName}");
                Console.WriteLine($"Author: {item.Author}");
                Console.WriteLine($"Available Copies: {item.AvaliableCopies}");
                Console.WriteLine($"Numble of Copies: {item.NumberofCopies}");
                Console.WriteLine($"Categories: {item.Category}");
                Console.WriteLine($"Publisher: {item.Publisher}");
                Console.WriteLine($"Release: {item.Release}");
                Console.WriteLine($"Createdby: {item.Createdby}");
            }
            Show("");
        }

        public override void Borrowers(UserViewModel userView)
        {
            Show("****************************************************************");
            Show("Book Booking");
            Show("****************************************************************");
            Show("");

            var result = booklist.ToList().FirstOrDefault(c => c.BookName == userView.BookName.Trim() && c.Category == userView.Category.Trim());
            if(result.AvaliableCopies > 3)
            {
                Show("");
                Show($"{userView.UserName} your Booking is Successful");
                Console.WriteLine($"Book Name: {result.BookName}");
                Console.WriteLine($"Author: {result.Author}");
                Console.WriteLine($"Available Copies: {result.AvaliableCopies}");
                Console.WriteLine($"Numble of Copies: {result.NumberofCopies}");
                Console.WriteLine($"Categories: {result.Category}");
                Console.WriteLine($"Publisher: {result.Publisher}");
                Console.WriteLine($"Release: {result.Release}");
                Console.WriteLine($"Createdby: {result.Createdby}");
            }
            else
            {
                Show("");
                Show($"{userView.UserName} this Book name: {userView.BookName} is not avaliable");
            }
        }

        public override void search(string Categories, string bookname)
        {
            Show("****************************************************************");
            Show("Search using Categories and Book name");
            Show("****************************************************************");
            Show("");
            var result = booklist.ToList().FirstOrDefault(c => c.BookName == bookname.Trim() && c.Category == Categories.Trim());
           if(result != null)
           {

                Console.WriteLine($"Book Name: {result.BookName}");
                Console.WriteLine($"Author: {result.Author}");
                Console.WriteLine($"Available Copies: {result.AvaliableCopies}");
                Console.WriteLine($"Numble of Copies: {result.NumberofCopies}");
                Console.WriteLine($"Categories: {result.Category}");
                Console.WriteLine($"Publisher: {result.Publisher}");
                Console.WriteLine($"Release: {result.Release}");
                Console.WriteLine($"Createdby: {result.Createdby}");
           }
           else
           {
               Show("No Book Found");
           }
            Show("");
        }

        public override void Show(string name)
        {
            Console.WriteLine($"{name}");
        }
    }
}
