/*  Store few names in the Collection and sort them using length */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QS25_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            SortNameUsingLength();
        }
        static void SortNameUsingLength()
        {
            List<Student> listStudent = new List<Student>();
            Student s;
            Console.Write("Enter the number of students you want to enter: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Enter the Student" + (i+1) + " details......");
                Console.Write("Enter name : ");
                string name = Console.ReadLine();
                Console.Write("Enter roll number : ");
                int roll = int.Parse(Console.ReadLine());
                s = new Student { Name = name, RollNumber = roll };
                listStudent.Add(s); //adding the student object to the list
            }
            Console.WriteLine("Sorting the Student database according to the length of name.......");
            SortByName sortByName = new SortByName();
            listStudent.Sort(sortByName);
            foreach (Student s1 in listStudent)
            {
                Console.WriteLine("Name: "+s1.Name+"\t"+"Roll Number: "+s1.RollNumber);
            }
        }
        class Student
        {
            public string Name { set; get; }
            public int RollNumber { set; get; }
        }
        class SortByName:IComparer<Student>
        {
            public int Compare(Student x, Student y)
            {
                if (x.Name.Length > y.Name.Length) { return -1; }
                else if (x.Name.Length < y.Name.Length) { return 1; }
                else
                {
                    if (x.RollNumber > y.RollNumber) { return -1; }
                    else if (x.RollNumber < y.RollNumber) { return 1; }
                    else return 0;
                }
            }
        }
    }
}
