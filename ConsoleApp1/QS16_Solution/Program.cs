using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QS16_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a = new Account("164750502HBA56", "Ankit", 3351.04);
            a.DoTransaction();
            a.show();
        }

        class Account
        {
            //like Account no, Customer name, Transaction type(d/w), amount, balance
            string acc_no, cname;
            char t_type;
            double amount, balance;

            //constructor
            public Account(string acc, string name, double b)
            {
                acc_no = acc;
                cname = name;
                balance = b;
            }
            public void DoTransaction()
            {
                Console.WriteLine("Select which you want to do:... \n1.Withdraw(by typing w)\t2.Deposit(by typing d)");
                t_type = Convert.ToChar(Console.ReadLine());
                if (t_type == 'd')
                {
                    credit();
                }
                else if(t_type == 'w')
                {
                    debit();
                }
                else
                {
                    Console.WriteLine("Wrong choice...\nyour transaction failed...");
                }
            }

            public void credit()
            {
                Console.WriteLine("Enter amount to be credited: ");
                amount = Convert.ToDouble(Console.ReadLine());
                balance = balance + amount;
                Console.WriteLine("After Deposit the Balance is: "+balance);
            }
            public void debit()
            {
                Console.WriteLine("Enter amount to be withdrawn: ");
                amount = Convert.ToDouble(Console.ReadLine());
                balance = balance - amount;
                Console.WriteLine("After Withdrawal the Balance is: " + balance);
            }
            public void show()
            {
                Console.WriteLine("");
                Console.WriteLine("The Details of The Account is:........ ");
                Console.WriteLine("The account number is : " +acc_no);
                Console.WriteLine("The name of account holder is : " + cname);
                Console.WriteLine("The account balance is : " + balance);
            }
        }
    }
}
