using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6CustomExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Account account = new Account(5000);
                account.WithDraw(3000);
                Console.WriteLine("Amount withdrawn successfully, current balance: " + account.Balance);
                account.Deposit(-1000);
                Console.WriteLine("Amount desposited successfully, current balance: " + account.Balance);
                account.WithDraw(1000);
                Console.WriteLine("Amount withdrawn successfully, current balance: " + account.Balance);
            }
            catch(AtmException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Thank u for using ATM services");
            }

        }
    }
}
