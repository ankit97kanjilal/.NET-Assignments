using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3OOPBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            //int rollno, marks;
            //string  result;

            //rollno = 101;
            //marks = 80;

            //result = CalculateResult(marks);
            //DisplayResult(rollno, marks, result);

            Student s = new Student();
            s.StoreDetails(101, 80);


            //s.CalculateResult();
            //s.Display();

        }
        static string CalculateResult(int marks)
        {
            string result = "Pass";
            if (marks < 70)
            {
                result = "Failed";
            }
            return result;
        }
        static void DisplayResult(int rno,int marks, string result)
        {
            Console.WriteLine("Rollno:" + rno);
            Console.WriteLine("Marks:" + marks);
            Console.WriteLine("Result:" + result);
        }
    }


    class Student
    {
        int rollno;
        int marks;
        string result;

        public void StoreDetails(int rno,int m)
        {
            rollno = rno;
            marks = m; 
        }
        public void CalculateResult()
        {
            result = "Pass";
            if (marks < 70)
            {
                result = "Failed";
            }
        }
        public void Display()
        {
           
            Console.WriteLine("Rollno:" + rollno);
            Console.WriteLine("Marks:" + marks);
            Console.WriteLine("Result:" + result);
        }
    }

    class Course
    {
        //
    }
    class Faculty
    {
        //
    }



}
