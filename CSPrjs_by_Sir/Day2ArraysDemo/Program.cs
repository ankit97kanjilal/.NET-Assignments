using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2ArraysDemo
{
    class Program
    {
        static void Main(string[] args)
        { 
            SingleDimensionArray();
            RectangularArray();
            JaggedArray();
        }
        static void SingleDimensionArray()
        {
            Console.WriteLine("Single Dimension Array");
            //data-type[] arrayname=new data-type[size]
            //int[] numbers = new int[5];
            //numbers[0] = 10;numbers[1] = 20;numbers[2] = 30;
            //numbers[3] = 40;numbers[4] = 50;
            //OR
            int[] numbers = new int[] { 10, 20, 30, 40, 50 ,60};

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        static void RectangularArray()
        {
            Console.WriteLine("Rectangular Array");
            //int[,] numbers = new int[3, 2];
            //numbers[0, 0] = 10;numbers[0, 1] = 20;
            //numbers[1, 0] = 30; numbers[1, 1] = 40;
            //numbers[2, 0] = 50; numbers[2, 1] = 60;
            //OR
            int[,] numbers = new int[,] { 
                                            { 10, 20 }, 
                                            { 30, 40 }, 
                                            { 50, 60 } 
            };


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(numbers[i,j]+"\t");
                }
                Console.WriteLine("");
            }


        }
        static void JaggedArray()
        {
            Console.WriteLine("Jagged Array");
            //int[][] jarr = new int[3][];
            //jarr[0] = new int[] { 10, 20, 30 };
            //jarr[1] = new int[] { 40, 50, 60, 70 };
            //jarr[2] = new int[] { 80, 90 };
            //OR
            int[][] jarr = new int[][] {
                                        new int[] { 10, 20, 30 },
                                        new int[] { 40, 50, 60, 70 } , 
                                        new int[] { 80, 90 } 
            };


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < jarr[i].Length; j++)
                {
                    Console.Write(jarr[i][j]+"\t");
                }
                Console.WriteLine("");
            }
        }
    }
}
