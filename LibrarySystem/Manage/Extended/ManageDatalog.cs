using LibrarySystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Manage.Extended
{
    public abstract class ManageDatalog
    {
        public abstract void BookList();
        public abstract void Show(string name);
        public abstract void search(string Categories, string bookname);
        public abstract void Borrowers(UserViewModel userView);
    }
}
