using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLib; //import the namespace of calculator class
using CustomerLib; //import the namespace of Customer class

namespace Day2Struct
{
    class Program
    {
        static void Main(string[] args)
        {

            //Calculator calc = new Calculator();
            //Console.WriteLine(calc.GetMsg());
            //Console.WriteLine(calc.AddNumbers(100,200));

            CustomerLib.Customer customer = new CustomerLib.Customer();

            



            customer.StoreDetails(1001, "David", "Italy");

            customer.DisplayDetails();

            //CalculatorLib.Customer c2 = new CalculatorLib.Customer();
            

            //Customer c = new Customer();            

            //conversion of data-types

            //Console.WriteLine(Convert.ToInt32(12.8));

            //Console.WriteLine(int.Parse("12"));
            //Console.WriteLine(double.Parse("12.8"));

            //Console.WriteLine(int.Parse("12.9"));
            //Console.WriteLine(int.TryParse("12",out int res));
            //Console.WriteLine(res);




            //address : country,state,pin, streetno, hno
            Address adr1 = new Address("India","Karnataka","560042");
            //adr1.State = "Karnataka";
            //adr1.Country = "India";
            //adr1.pin = "560042";
          
            adr1.Display();

            //Address adr2 = adr1;
            //adr2.pin = "560054";
            //Console.WriteLine("Pin:" + adr1.pin);
        }
    }



    class RegularCustomer : CustomerLib.Customer
    {
        public void Display()
        {
            Console.WriteLine(var_pro_inrnl);
        }
    }


    struct Address
    {
        public string Country;
        public string State;
        public string pin;

        public Address(string c,string s,string p)
        {
            Country = c;
            State = s;
            pin = p;
        }
        public void Display()
        {
            Console.WriteLine("State:" + State);
            Console.WriteLine("Country:" + Country);
            Console.WriteLine("Pin:" + pin);
        }

        //~Address()   //not allowed
        //{
        //}
    }
}

//1.struct is a value type data-type
//2.by default members of a structure are not public 
//3.structure CANNOT have destructor
//4.structure can have constructor but it must be parameterised and its fields must be assigned
//with those parameters
//5. default field initialization is not allowed inside struct unlike class