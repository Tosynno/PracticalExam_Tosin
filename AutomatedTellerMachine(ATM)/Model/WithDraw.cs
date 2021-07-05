using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedTellerMachine_ATM_.Model
{
    public class WithDraw
    {
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public double Amount { get; set; }
        public DateTime WithDrawDate { get; set; } = DateTime.Now;
    }
}
