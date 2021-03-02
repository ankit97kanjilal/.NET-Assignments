/*
Write a program to create a list of words present in a sentence passed from command line. The list 
also contain count of the appearance of each word in that sentence. The program has to display the 
words in sorted order and its frequency.
If the input is: "DotNet is technology and DotNet is interoperable and DotNet is simple".
Output should be: [and = 2, DotNet =3, interoperable = 1, is = 3, oop =1, simple =1]
[Hint: To choose appropriate collection class for storing key/ value pair.]
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QS26_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the String : ");
            string input = Console.ReadLine();
            MethodForSolve(input);
        }
        static void MethodForSolve(string input)
        {
            string[] listStr = input.Split(' ');
            HashSet<string> hashSet = new HashSet<string>(); //for unique members idetifying we need this
            SortedDictionary<string, int> sorted_dict = new SortedDictionary<string, int>();
            foreach (string s in listStr)
            {
                //Console.WriteLine(s); //printed each word of the string
                hashSet.Add(s);
            }

            foreach (string s in hashSet)
            {
                int value = 0;
                for (int i = 0; i < listStr.Length; i++)
                {
                    if (s.Equals(listStr[i]))
                    {
                        value += 1;
                    }
                }
                sorted_dict.Add(s, value);
            }

            Console.WriteLine("The frequency of the words : ");
            foreach (string s in sorted_dict.Keys)
            {
                Console.WriteLine(s + " : " + sorted_dict[s]);
            }
            Console.WriteLine("");

            //for (int i = 0; i < listStr.Length; i++)
            //{
            //    int value = 0;
            //    for (int k = 1; k < listStr.Length; k++)
            //    {
            //        if (listStr[i].Equals(listStr[k]))
            //        {
            //            value += 1;
            //            Console.WriteLine("Value:" + value);
            //        }
            //    }
            //    sorted_dict.Add(listStr[i], value);
            //}

            //foreach (string s in listStr)
            //{
            //    //sorted_dict.Add(s, 1);
            //    Console.WriteLine("Enter in foreach1..........");
            //    if (sorted_dict.Count() == 0)
            //    {
            //        sorted_dict.Add(s, 1);
            //    }
            //    else
            //    {
            //        foreach (string s1 in sorted_dict.Keys)
            //        {
            //            Console.WriteLine("Enter in foreach2..........");
            //            if (s.Equals(s1))
            //            {
            //                sorted_dict[s1] += 1;
            //            }
            //            else
            //            {
            //                sorted_dict.Add(s, 1);
            //            }
            //        }
            //    }
            //}
        }
    }
}
