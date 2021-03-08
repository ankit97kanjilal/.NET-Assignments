using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Polymorphism2
{
    class Program
    {
        static void Main(string[] args)
        {
            Child ch = new Child();
            ch.Show();



            int marks;
            Console.Write("Enter marks:");
            marks = int.Parse(Console.ReadLine());

            Console.WriteLine("Check Eligibility");
            Console.WriteLine("1.RV College\n2.Ramaiah");
            Console.Write("Enter choice:");
            int choice = int.Parse(Console.ReadLine());

            University u;
            bool eligible;
            if(choice==1)
            {
                u = new RVCollege();
                eligible = u.CheckEligibility(marks);
                if(eligible)
                {
                    Console.WriteLine("Eligible for RV College");
                }
                else
                {
                    Console.WriteLine("Not Eligible for RV College");
                }
            }
            if(choice==2)
            {
                u = new RamaiahMedicalCollege();
                eligible = u.CheckEligibility(marks);
                if (eligible)
                {
                    Console.WriteLine("Eligible for Ramaiah");
                }
                else
                {
                    Console.WriteLine("Not Eligible for Ramaiah");
                }
            }


            
        }
    }


    class University
    {
        protected int cutOffMarks = 70;
        public virtual bool CheckEligibility(int marks) 
        {
            if(marks>=cutOffMarks)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }

    class RVCollege : University
    {
        public RVCollege()
        {
            cutOffMarks = 60;
        }
        public override bool CheckEligibility(int marks)
        {
            if(marks>=this.cutOffMarks)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class RamaiahMedicalCollege : University
    {
        public RamaiahMedicalCollege()
        {
            cutOffMarks = 50;
        }
        public override bool CheckEligibility(int marks)
        {
            if (marks >= this.cutOffMarks)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}


class Parent
{
    public virtual void Show()
    {
        Console.WriteLine("Parent-Show");
    }
}
class Child : Parent
{
    public override void Show()
    {
        Console.WriteLine("Child-Show");
    }
}