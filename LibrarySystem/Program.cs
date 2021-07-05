using LibrarySystem.BussinessLogic;
using System;

namespace LibrarySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Library System");

            GeneralClass.IsLogin();

            GeneralClass.getbookbysearch();

            GeneralClass.bookBorrow();

            GeneralClass.LogOutorSignOut();
        }
    }
}
