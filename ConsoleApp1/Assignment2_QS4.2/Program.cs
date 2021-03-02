/*
4.2 Sort Product Collection
Refer any online shopping portal, the products will be displayed in some order. The user in-terface
displays the products sorted by brand or by price.
4.2.1 Objective
Sorting user defined entity classes based on runtime requirement.
4.2.2 Problem Statement
Create an Entity class to hold the following data. You need to choose an appropriate collection to hold it.
Product ID      Brand Name      Description         Price
200             Dell            15 inch Monitor     3400.44
120             Dell            Laptop              45000.00
150            Microsoft        Windows 7           7000.50
100             Logitech        Optical Mouse       540.00 

Write a program to perform the following operations
1. Stores the collections of the data shown above
2. An operation to display all the products in a sorted order by default based on their product id.
3. Option for sorting based on Brand name or price based on input provided at runtime.
a. If two products contain same brand name, description should be considered.
b. Similarly if products have same price, product id’s should be considered while displaying
them in order 
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_QS4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            listDemo();
        }
        static void listDemo()
        {
            List<Product> lstPro = new List<Product>();
            lstPro.Add(new Product { ProductID = 250, BrandName = "Dell.......", Description = "laptop........", Price = 45000.00 });
            lstPro.Add(new Product { ProductID = 200, BrandName = "Dell.......", Description= "15 inch Monitor", Price= 3400.44 });
            lstPro.Add(new Product { ProductID = 150, BrandName = "Microsoft..", Description = "Windows 7.....", Price = 7000.50 });
            lstPro.Add(new Product { ProductID = 120, BrandName = "Seagate....", Description = "Dvd Drive.....", Price = 540.00 });
            lstPro.Add(new Product { ProductID = 100, BrandName = "Logitech...", Description = "Optical Mouse", Price = 540.00 });

            Console.WriteLine("Before Sorting the list is...........");
            Console.WriteLine("");
            foreach (Product p in lstPro)
            {
                Console.WriteLine(p.ProductID + "\t\t" + p.BrandName + "\t\t" + p.Description + "\t\t" + p.Price);
            }

            //by default by product id decreasing order
            lstPro.Sort();
            Console.WriteLine("After default sort by product id List is......");
            Console.WriteLine("");
            foreach (Product p in lstPro)
            {
                Console.WriteLine(p.ProductID + "\t\t" + p.BrandName + "\t\t" + p.Description + "\t\t" + p.Price);
            }

            //menu driven sorting......
            //Option for sorting based on Brand name or price based on input provided at runtime.
            //If two products contain same brand name, description should be considered.
            //Similarly if products have same price, product id’s should be considered while displaying them in order

            Console.WriteLine("Choose one of these........\n1.Sorting based on Brand name" +
                "\n2.Sorting based on Description\n3.Sorting based on Price");

            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Sort by BrandName.....");
                SortByBrand sort_by_brand = new SortByBrand();
                lstPro.Sort(sort_by_brand);
            }
            else if (choice == 2)
            {
                Console.WriteLine("Sort by Description.....");
                SortByDescription sbd = new SortByDescription();
                lstPro.Sort(sbd);
            }
            else if (choice == 3)
            {
                Console.WriteLine("Sort by Price......");
                SortByPrice sbp = new SortByPrice();
                lstPro.Sort(sbp);
            }
            else
            {
                Console.WriteLine("Wrong Choice Entered......");
            }
            
            Console.WriteLine("List values are..........\n");
            Console.WriteLine("");

            foreach (Product p in lstPro)
            {
                Console.WriteLine(p.ProductID+"\t\t"+p.BrandName+"\t\t"+p.Description+"\t\t"+p.Price);
            }
        }
        class Product:IComparable<Product>
        {
            public int ProductID{ set; get; }
            public string BrandName { set; get; }
            public string Description { set; get; }
            public double Price { set; get; }

            public int CompareTo(Product p)
            {
                if (this.ProductID > p.ProductID)
                {
                    return -1;
                }
                else if(this.ProductID < p.ProductID)
                {
                    return 1;
                }
                else
                {
                    return 0;                   
                }
            }//Default sorting on decreasing Product id
        }

        //Custome sort on different parts.......

        class SortByBrand : IComparer<Product>
        {
            public int Compare(Product x,Product y)
            {
                int returnval = string.Compare(x.BrandName, y.BrandName);
                if(returnval == 0)
                {
                    Console.WriteLine("Brand Name Matched... So sorting against their Description....");
                    returnval = string.Compare(x.Description, y.Description);
                    return returnval;
                }
                else
                    return returnval;
            }
        }
        class SortByDescription:IComparer<Product>
        {
            public int Compare(Product x, Product y)
            {
                int returnval = string.Compare(x.BrandName, y.BrandName);
                return returnval;
            }
        }
        class SortByPrice:IComparer<Product>
        {
            public int Compare(Product x,Product y)
            {
                if (x.Price > y.Price)
                {
                    return -1;
                }
                else if (x.Price < y.Price)
                {
                    return 1;
                }
                else
                {
                    Console.WriteLine("Price of the Products matched.......");
                    if (x.ProductID > y.ProductID)
                    {
                        return 1;
                    }
                    else if (x.ProductID < y.ProductID)
                    {
                        return -1;
                    }
                    else
                        return 0;
                }
            }            
        }
    }
}
