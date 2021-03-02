//A coffee shop would like to find out the customer feedback rating about its services. The customer class shown below:
//Customer
//	- FeedbackRating: double
//		-MobileNumber: String
//		- Name: String
// Example: Assume that the shop will collect feedback from ‘N’ customers. Following are the sample customer feedback values.
//	Customer 1: 3 out of 5
//	Customer 2: 4 out of 5
//	Customer 3: 2.5 out of 5
//Write an application which creates array of ‘N’ customer objects to store feedback values of these customers 
//and print the average feedback rating.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QS20_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of Customers you want to add: ");
            int n = int.Parse(Console.ReadLine());
            Customer[] cust = new Customer[n];

            //Customer[] cust = new Customer[3];
            //cust[0].FeedbackRating = 3;
            //cust[0].MobileNumber = "9874706055";
            //cust[0].Name = "Ankit";
            //cust[1].FeedbackRating = 4;
            //cust[2].FeedbackRating = 2.5;

            double total = 0;
            for (int i = 0; i < cust.Length; i++)
            {
                cust[i] = new Customer();
                Console.WriteLine("Enter details of Customer :"+(i+1));
                Console.Write("Enter feedback rating : ");
                double fb = double.Parse(Console.ReadLine());
                cust[i].FeedbackRating = fb;
                total += cust[i].FeedbackRating;
                Console.Write("Enter Mobile number : ");
                string mobile = Convert.ToString(Console.ReadLine());
                cust[i].MobileNumber = mobile;
                Console.Write("Enter feedback rating : ");
                string ename = Convert.ToString(Console.ReadLine());
                cust[i].Name = ename;
            }
            double avg = total / n;
            Console.WriteLine("The Average rating is : "+avg);
        }
        class Customer
        {
            //double FeedbackRating;
            //string MobileNumber, Name;

            public double FeedbackRating { get; set; }
            public string MobileNumber { get; set; }
            public string Name { get; set; }

            //public int this[double FeedbackRating ]
            //{

            //}
        }

    }
}
