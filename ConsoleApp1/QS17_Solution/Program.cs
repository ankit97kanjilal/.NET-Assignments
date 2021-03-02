using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QS17_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime dob = Convert.ToDateTime(Console.ReadLine());// for input taking
            //but convert only take in dd-mm-yyyy not in other format
            //instead of this we should go for.... 
            //DateTime dob2 = DateTime.ParseExact(Console.ReadLine(), "MM-dd-yyyy", null);
            // if we want to pass date in our chosen format then we can go for PraseExact

            DateTime dob = new DateTime(2000, 02, 25);
            Person p1 = new Person("Ankit", "Kanjilal", dob, "ankit.kanjilal@gmail.com" );
            p1.isBirthdayToday(dob);
            p1.isAdult(dob);
        }
        class Person
        {
            string firstname, lastname, email;
            DateTime dob;
            
            public Person(string firstname, string lastname, DateTime dob, string email)
            {
                this.firstname = firstname;
                this.lastname = lastname;
                this.email = email;
                this.dob = dob;
            }
            public Person(string firstname, string lastname, string email)
            {
                this.firstname = firstname;
                this.lastname = lastname;
                this.email = email;
            }

            public Person(string firstname, string lastname, DateTime dob)
            {
                this.firstname = firstname;
                this.lastname = lastname;
                this.dob = dob;
            }

            public void isAdult(DateTime dob)
            {
                DateTime current = DateTime.Now;
                int age = current.Year - dob.Year;
                if (age < 18)
                    Console.WriteLine("Person is not an adult....");
                else
                    Console.WriteLine("Person is an adult person....");
            }

            public void isBirthdayToday(DateTime dob)
            {
                DateTime current = DateTime.Now;
                if (dob.ToString("dd-MM").Equals(current.ToString("dd-MM")))
                {
                    Console.WriteLine("Yes today is the Person's birthday");
                    Console.WriteLine("Happy Birthday to you "+this.lastname);
                }
            }
        }
    }
}
