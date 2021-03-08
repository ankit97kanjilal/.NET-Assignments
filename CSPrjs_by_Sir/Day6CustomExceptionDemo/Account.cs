using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6CustomExceptionDemo
{
    class Account
    {
        public double Balance { get; set; }

        public Account(int balance)
        {
            Balance += balance;
        }
        public void Deposit(int amt)
        {
            if(amt<=0)
            {
                AtmException ex = new AtmException("invalid figure to deposit");
                throw ex;
            }
            Balance += amt;
        }
        public void WithDraw(int amt)
        {
            if (amt > Balance)
            {
                AtmException ex = new AtmException("insufficient funds to withdraw!!!");
                throw ex;
            }
            else
            {
                Balance -= amt;
            }
        }
    }
}
