using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.RegularExpressions; //for regular expression

namespace Day8RegularExpression
{
    class Program
    {
        static void Main(string[] args)
        {


            

            //string is immutable 


            //string s1 = "Hello";
            //string s2 = "World";
            //s2 += s1;

            //for (int i = 0; i < 100; i++)
            //{
            //    s2 += "";
            //}

            StringBuilder sb = new StringBuilder();
            sb.Append("Hello ");
            sb.Append("How ");
            sb.Append("are ");
            sb.Append("Your?");
            sb.Append("Come ");
            sb.Append("Home ");


            Console.WriteLine(sb.ToString());


            string line = "Hello,how are you? I am fine.How about you?";

            string val = String.Concat("Hello", " World");
            Console.WriteLine(val);




            char[] splitChars = new char[] { ',', '.', ' ' };
            string[] words = line.Split(splitChars);

            foreach (string w in words)
            {
                Console.WriteLine(w);
            }





            string name = "Ramnath";

            string mobilenum = "9986017462";

            //to check name contains only alphabets
            Regex regex = new Regex(@"^\w}$");

            if(regex.IsMatch(mobilenum))
            {
               // Console.WriteLine("mobile number is valid");
            }
            else
            {
                //Console.WriteLine("invalid mobile number, must contain only 10-digits");
            }


        }
    }
}

//  "\d" : for digit
// "\D" : for any character
// "[0-9]*" for only numbers 0-9
//  "[aA-zZ]"  for only alphabets

