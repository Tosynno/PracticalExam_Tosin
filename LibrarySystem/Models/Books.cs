using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Models
{
    public class Books
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string Category { get; set; }
        public DateTime Release { get; set; }
        public int AvaliableCopies { get; set; }
        public int NumberofCopies { get; set; }
        public int Createdby { get; set; }
    }
}
