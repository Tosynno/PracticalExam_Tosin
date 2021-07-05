using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.User.Extended
{
    public abstract class UserDataLog
    {
        public abstract bool Login(ref string username, ref string password);
        public abstract void showLoginmessage(bool result);
        public abstract void LogOut();
    }
}
