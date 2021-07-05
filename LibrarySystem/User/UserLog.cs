using LibrarySystem.User.Extended;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.User
{
    public class UserLog : UserDataLog
    {
        const string admin = "Admin";
        const string pass = "Password123";
        public override bool Login(ref string username, ref string password)
        {
            bool result;
            if(username == admin && password == pass)
            {
               
                result = true;
                return result;
            }
            else
            {
                result = false;
                return result;
            }
        }

        public override void LogOut()
        {
            Console.WriteLine();
            Console.WriteLine("press any Key to Log Out");
            Console.WriteLine();
            Console.ReadKey();
            Environment.Exit(0);
        }

        public override void showLoginmessage(bool result)
        {
            switch(result)
            {
                case true:
                    Console.WriteLine("Login is SucccessFul");
                    break;
                default:
                    Console.WriteLine("Login Fail");
                    break;
            }
        }
    }
}
