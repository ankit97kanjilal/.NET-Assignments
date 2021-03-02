using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 95, 65, 30, 90, 97, 95, 70};
            DisplayResult(arr);
        }
        static void DisplayResult(int[] arr)
        {
            float avg = 0;
            for (int i = 0; i < arr.Length; i++) { avg += arr[i]; }
            avg = avg / arr.Length;
            Console.WriteLine("Average is : " + avg);
            int flag=0;
            for (int i = 0; i < arr.Length; i++)
            {
                //Console.WriteLine(arr[i]);
                if (arr[i] < 35 || avg < 50)
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.WriteLine("Passed");
            else
                Console.WriteLine("Failed");
        }
    }
}
