using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            //BankAccount bankAccount ;

            //bankAccount = new SavingAccount();


            //bankAccount = new CurrentAccount();

            Shape sh;
            sh = new Circle();
            sh.Area();
            sh.FillColor();

            sh = new Square();
            sh.Area();
            sh.FillColor();


            IDatabase idb;

            idb = new Oracle();


            idb = new SqlServer();



        }
    }

    abstract class Shape
    {
        public abstract void Area();
        public void FillColor()
        {
            Console.WriteLine("FillColor");
        }
        
    }

    class Circle : Shape
    {
        public override void Area()
        {
            Console.WriteLine("Area of Circle");
        }
    }
    class Square : Shape
    {
        public override void Area()
        {
            Console.WriteLine("Area of Square");
        }
    }
}


abstract class BankAccount
{
    public abstract void Deposit(int amount);
    public abstract void Withdraw(int amount);

}

class SavingAccount : BankAccount
{
    public override void Deposit(int amount)
    {
        //
    }
    public override void Withdraw(int amount)
    {
        //
    }
}
class CurrentAccount : BankAccount
{
    public override void Deposit(int amount)
    {
        //
    }
    public override void Withdraw(int amount)
    {
        //
    }
}


interface IDatabase
{
    void Select();
    void Insert();
    void Delete();
    void Update();
}
interface IAdminTask
{
    void Backup();
    void Recovery();
}
class Oracle : IDatabase,IAdminTask
{
    public void Backup()
    {
        throw new NotImplementedException();
    }

    public void Delete()
    {
        throw new NotImplementedException();
    }

    public void Insert()
    {
        throw new NotImplementedException();
    }

    public void Recovery()
    {
        throw new NotImplementedException();
    }

    public void Select()
    {
        throw new NotImplementedException();
    }

    public void Update()
    {
        throw new NotImplementedException();
    }
}
class SqlServer : IDatabase
{
    public void Delete()
    {
        throw new NotImplementedException();
    }

    public void Insert()
    {
        throw new NotImplementedException();
    }

    public void Select()
    {
        throw new NotImplementedException();
    }

    public void Update()
    {
        throw new NotImplementedException();
    }
}

