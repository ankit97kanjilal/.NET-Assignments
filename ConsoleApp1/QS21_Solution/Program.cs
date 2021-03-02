/*
 Q21. An agency which works for a bank takes care of background verification of a customer who had applied
for a personal loan. The agency will go through background check and classify the customer into two categories:
“Green” and “Red”. 

Example: 
If a customer has good financial transaction history, he/she will be categorized as “Green”. 
If a customer has poor financial transaction history, he/she will be categorized as ‘Red”. 
Based on category, the bank will decide to approve the loan request. Below is the class diagram.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QS21_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize Customer Object....
            Customer c = new Customer(100, "123/727, Rothtala", "9874706050", "Ankit");
            Customer c1 = new Customer(101, "122/727, Rothtala", "9681561392", "Raman");
            Customer c2 = new Customer(102, "121/727, Rothtala", "9836672824", "Rahul");
            Customer c3 = new Customer(103, "120/727, Rothtala", "9454810220", "Rohit");
            Customer[] custArray = new Customer[4];
            custArray[0] = c;
            custArray[1] = c1;
            custArray[2] = c2;
            custArray[3] = c3;

            //Initialize the Agency class....
            Agency ag = new Agency("XYZ Agency", "Naihati", "9584123001");
            ag.verifyCustomer(c);   //veryfying customers's status
            ag.verifyCustomer(c1);
            //ag.verifyCustomer(c2); --> as I dont want to give access to green status to this Customer
            ag.verifyCustomer(c3);

            //Initialize the Bank Details....
            Bank b = new Bank("State Bank of India", "Shyamnagar", "9681-050-215", custArray);
            b.applyForLoan();
        }
        class Bank
        {
            string BankName;
            string BankAddress;
            string BankContactNumber;
            Customer[] Customers;
            public Bank()
            {

            }
            public Bank(string BankName, string BankAddress, string BankContactNumber, Customer[] Customers)
            {
                this.BankName = BankName;
                this.BankAddress = BankAddress;
                this.BankContactNumber = BankContactNumber;
                this.Customers = Customers;
            }
            public void applyForLoan()
            {
                foreach (Customer c in Customers)
                {
                    Console.WriteLine("Enter in foreach");
                    if (c.CustStatus == "green")
                    {
                        Console.WriteLine("Loan for this Customer: "+c.CustName+" is approved");
                    }
                    else
                    {
                        Console.WriteLine("Loan for this Customer: " + c.CustName + " is not approved");
                    }
                }
            }
        }
        public class Customer
        {
            public string CustName;
            string CustAddress;
            string CustMobileNo;
            int CustID;

            public string CustStatus = null;
            public Customer()
            {

            }
            public Customer(int CustID, string CustAddress, string CustMobileNo, string CustName)
            {
                this.CustID = CustID;
                this.CustAddress = CustAddress;
                this.CustMobileNo = CustMobileNo;
                this.CustName = CustName;
            }
        }
        class Agency
        {
            string AgencyName;
            string AgencyAddress;
            string AgencyContactNumber;
            public Agency()
            {

            }
            public Agency(string AgencyName, string AgencyAddress, string AgencyContactNumber)
            {
                this.AgencyAddress = AgencyAddress;
                this.AgencyContactNumber = AgencyContactNumber;
                this.AgencyName = AgencyName;
            }
            public Customer verifyCustomer(Customer c)
            {
                Console.WriteLine("Customer Status is updated........");
                c.CustStatus = "green";
                return c;
            }
        }
    }
}
