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

        internal static bool AcountDetail()
        {
            Console.WriteLine("Account Detail");
            bool response = false;

           
            //this are not block, kindly display
            var result = ListofAccount().ToList();
            if(result.Count > 0)
            {
                Console.WriteLine();
                foreach (var item in result)
                {
                    Console.WriteLine();
                    Console.WriteLine(item.Id);
                    Console.WriteLine($"Account Name: {item.AccountName}");
                    Console.WriteLine($"Account Number: {item.AccountNumber}");
                    Console.WriteLine($"Balance: {item.Balance}");
                    Console.WriteLine($"CreatedDate: {item.CreatedDate}");
                }
                response = true;
                return response;
            }
           
            return response;

        }

        internal static void Search()
        {
            Console.WriteLine();
            Console.WriteLine("Find Account");
            Console.WriteLine();
            Console.WriteLine("Account Number");
            string acctNo =Console.ReadLine();
                var result = ListofAccount().FirstOrDefault(c => c.AccountNumber == acctNo && c.IsBlock == 0);
            if(result.Id > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Unblock Account");

                Console.WriteLine();
                Console.WriteLine($"Account Name: {result.AccountName}");
                Console.WriteLine($"Account Number: {result.AccountNumber}");
                Console.WriteLine($"Balance: {result.Balance}");
                Console.WriteLine($"CreatedDate: {result.CreatedDate}");
            }
            else
            {
                var result2 = ListofAccount().FirstOrDefault(c => c.AccountNumber == acctNo && c.IsBlock == 1);
                if (result2.Id > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Unblock Account");

                    Console.WriteLine();
                    Console.WriteLine($"Account Name: {result2.AccountName}");
                    Console.WriteLine($"Account Number: {result2.AccountNumber}");
                    Console.WriteLine($"Balance: {result2.Balance}");
                    Console.WriteLine($"CreatedDate: {result2.CreatedDate}");
                }
                else
                {
                    Console.WriteLine("No Record Found");
                }
            }
               
                
               
        }
    
        internal static void Registration()
        {
            Console.WriteLine();
            Console.WriteLine("Registration");
            Console.WriteLine();
            Account account = new Account();
            Console.WriteLine("Account Name");
            account.AccountName = Console.ReadLine();
            account.IsBlock = 0;

            Console.WriteLine("Display new Account Detail");
            Console.WriteLine();

            Console.WriteLine("Account Name");
            Console.WriteLine(account.AccountName);

            Random random = new Random();
            Console.WriteLine("Account Number");

            int acctno = random.Next(999);
            Console.WriteLine(DateTime.Now.ToString("yyyymmdd") + acctno);

            Console.WriteLine("Is Block");
            Console.WriteLine(false);
        }

        internal static void Withdraw()
        {
            Console.WriteLine();
            Console.WriteLine("WithDraw");
            Console.WriteLine();

            WithDraw withdraw = new WithDraw();
            Console.WriteLine("Account Name");
            withdraw.AccountName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Account Number");
            withdraw.AccountNumber = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Amount");
            withdraw.Amount = double.Parse(Console.ReadLine());

            var result = ListofAccount().FirstOrDefault(c => c.AccountName == withdraw.AccountName.Trim() && c.AccountNumber == withdraw.AccountNumber.Trim());

            if(result.Id > 0)
            {
                double balance = result.Balance - withdraw.Amount;
                if(balance < 0)
                {
                    Console.WriteLine("**********************************************************************");
                    Console.WriteLine("insufficient fund");
                    Console.WriteLine("**********************************************************************");
                }
                else
                {
                    Console.WriteLine($"Account Name: {result.AccountName}");
                    Console.WriteLine();
                    Console.WriteLine($"Account Number: {result.AccountNumber}");
                    Console.WriteLine();
                    Console.WriteLine($"Old Balance: {result.Balance}");
                    Console.WriteLine();
                    Console.WriteLine($"New Balance: {balance}");
                    Console.WriteLine();
                    Console.WriteLine($"Withdrawal Date: {withdraw.WithDrawDate}");
                }
              
            }
            else
            {
                Console.WriteLine("Client Account Does not Exist!!!");
            }
        }
    
        internal static void Deposit()
        {
            Console.WriteLine();
            Console.WriteLine("Deposit");
            Console.WriteLine();

            Deposit deposit = new Deposit();
            Console.WriteLine("Account Name");
            deposit.AccountName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Account Number");
            deposit.AccountNumber = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Amount");
            deposit.Amount = double.Parse(Console.ReadLine());

            var result = ListofAccount().FirstOrDefault(c => c.AccountName == deposit.AccountName.Trim() && c.AccountNumber == deposit.AccountNumber.Trim());

            if (result.AccountName != null)
            {
                var balance = result.Balance + deposit.Amount;
                Console.WriteLine($"Account Name: {result.AccountName}");
                Console.WriteLine();
                Console.WriteLine($"Account Number: {result.AccountNumber}");
                Console.WriteLine();
                Console.WriteLine($"Old Balance: {result.Balance}");
                Console.WriteLine();
                Console.WriteLine($"New Balance: {balance}");
                Console.WriteLine();
                Console.WriteLine($"Deposit Date: {deposit.DepositDate}");
            }
            else
            {
                Console.WriteLine("Client Account Does not Exist!!!");
            }
        }
    }
}
