using LibrarySystem.Manage;
using LibrarySystem.Manage.Extended;
using LibrarySystem.Models;
using LibrarySystem.User;
using LibrarySystem.User.Extended;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.BussinessLogic
{
    public static class GeneralClass
    {
        internal static void IsLogin()
        {
            UserDataLog user;
            ManageDatalog datalog;
            user = new UserLog();
            datalog = new Managelogic();

            Console.WriteLine("UserName");
            string getuser =  Console.ReadLine();

            Console.WriteLine("Password");
            string getpass = Console.ReadLine();

            bool result = user.Login(ref getuser, ref getpass);
            user.showLoginmessage(result);
            if (result == true)
                datalog.BookList();
           
        }

        internal static void getbookbysearch()
        {
            ManageDatalog datalog;
           
            datalog = new Managelogic();
            Console.WriteLine("book Name");
            string bookname = Console.ReadLine();

            Console.WriteLine("Category");
            string Category = Console.ReadLine();
            datalog.search(Category, bookname);
        }

        internal static void LogOutorSignOut()
        {
            UserDataLog user;
            user = new UserLog();
            user.LogOut();
        }

        internal static void bookBorrow()
        {
            ManageDatalog datalog;

            datalog = new Managelogic();

            UserViewModel userView = new UserViewModel();
            Console.WriteLine("User Name");
             userView.UserName = Console.ReadLine();
            Console.WriteLine("book Name");
            userView.BookName = Console.ReadLine();

            Console.WriteLine("booking or Borrow");
            userView.Booking = Console.ReadLine();

            Console.WriteLine("Category");
            userView.Category = Console.ReadLine();
            datalog.Borrowers(userView);
        }
    }
}
