using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedTellerMachine_ATM_.Model
{
    public class Account
    {
        public int Id { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public double Balance { get; set; }
        public int IsBlock { get; set; }
        public DateTime CreatedDate { get; set; } 

    }
}
