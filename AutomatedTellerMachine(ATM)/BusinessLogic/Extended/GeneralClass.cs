using AutomatedTellerMachine_ATM_.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedTellerMachine_ATM_.BusinessLogic
{
    public static partial class GeneralClass
    {
        internal static void DisplayAllMethod()
        {
            AcountDetail();
            Withdraw();
            Deposit();
            Registration();
            Search();
        }

        internal static List<Account> ListofAccount()
        {
            List<Account> accounts = new List<Account>()
            {
                new Account{Id = 1, AccountName = "Shina", AccountNumber = "0190983738", Balance = 509.00, IsBlock = 0, CreatedDate = DateTime.Now.AddDays(-190)},
                 new Account{Id = 2, AccountName = "Fela Kuti", AccountNumber = "0290963738", Balance = 499999.00, IsBlock = 0, CreatedDate = DateTime.Now.AddDays(-4983)},
                  new Account{Id = 3, AccountName = "Agbani", AccountNumber = "0160933738", Balance = 366666.00, IsBlock = 0, CreatedDate = DateTime.Now.AddDays(-566)},
                   new Account{Id = 4, AccountName = "Wole Soyinka", AccountNumber = "0160978738", Balance = 23678932444.00, IsBlock = 1, CreatedDate = DateTime.Now.AddDays(-186)},
                    new Account{Id = 5, AccountName = "Chinua", AccountNumber = "0136933938", Balance = 66789933333.00, IsBlock = 1, CreatedDate = DateTime.Now.AddDays(-566)},
                     new Account{Id = 6, AccountName = "Davido", AccountNumber = "0197983732", Balance = 509.00, IsBlock = 0, CreatedDate = DateTime.Now.AddDays(-4556)},
                      new Account{Id = 7, AccountName = "Chimamanda", AccountNumber = "0790953738", Balance = 400.00, IsBlock = 0, CreatedDate = DateTime.Now.AddDays(-3445)},
                       new Account{Id = 8, AccountName = "Tiwa Savage", AccountNumber = "0890983308", Balance = 500.00, IsBlock = 0, CreatedDate = DateTime.Now.AddDays(-786)},
                        new Account{Id = 9, AccountName = "Olusegun Obasanjo", AccountNumber = "0390993738", Balance = 700.00, IsBlock = 0, CreatedDate = DateTime.Now.AddDays(-166)},
                         new Account{Id = 10, AccountName = "Chinua Achebe", AccountNumber = "0590984538", Balance = 500.00, IsBlock = 0, CreatedDate = DateTime.Now.AddDays(-6477)}
          };

            return accounts;
        }
    }
}
