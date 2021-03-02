//Create a class for Hyundai which has the members:
// -maximum speed limit
// -method:
//  -SetMaxSpeed: should set the max speed of hyundai to 120Km/Hr
//  -ToString : should display the details of maximum speed limit
//Create following two derived classes inheriting Hyundai:
// 1) Hyudai Era
//  -methods:
//   -SetMaxSpeed: should set the max speed of hyundai to 80Km/Hr
//               -ToString : should display the details of maximum                      speed limit			
//     2) Hyudai Magna
//- methods:
//	-SetMaxSpeed: should set the max speed of hyundai to 70Km/Hr
//	-ToString : should display the details of maximum speed limit


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QS19_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Static Binding.....");
            Hyundai h = new Hyundai();
            h.SetMaxSpeed();
            h.ToString();
            HyundaiEra h1 = new HyundaiEra();
            h1.SetMaxSpeed();
            h1.ToString();
            HyudaiMagna h2 = new HyudaiMagna();
            h2.SetMaxSpeed();
            h2.ToString();
            
            Console.WriteLine();

            Console.WriteLine("Dynamic Binding.....");
            Hyundai obj;
            obj = new HyundaiEra();
            obj.SetMaxSpeed();
            obj.ToString();

            obj = new HyudaiMagna();
            obj.SetMaxSpeed();
            obj.ToString();

            obj = new Hyundai();
            obj.SetMaxSpeed();
            obj.ToString();
        }
        


        class Hyundai
        {
            protected int max_speed_limit;
            public virtual void SetMaxSpeed()
            {
                max_speed_limit = 120;
            }
            public override string ToString()
            {
                Console.WriteLine("The max speed limit is : "+max_speed_limit);
                return "";
            }
        }
        class HyundaiEra:Hyundai
        {
            public override void SetMaxSpeed()
            {
                max_speed_limit = 80;
            }
            public override string ToString()
            {
                Console.WriteLine("The max speed limit is : " + max_speed_limit);
                return "";
            }
        }
        class HyudaiMagna:Hyundai
        {
            public override void SetMaxSpeed()
            {
                max_speed_limit = 70;
            }
            public override string ToString()
            {
                Console.WriteLine("The max speed limit is : " + max_speed_limit);
                return "";
            }

        }
    }
}
