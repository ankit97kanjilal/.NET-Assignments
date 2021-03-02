using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;

namespace FileOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First insert values in the products.txt file");
            WriteProducts();

            //Reading values from the products.txt
            string filePath = @"F:\products.txt";
            StreamReader reader = null;
            int id;
            String item;
            double price;
            List<Products> listProduct = new List<Products>();
            if (File.Exists(filePath))
            {
                FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                reader = new StreamReader(fs);
                while (!reader.EndOfStream)   //while(String.IsNullOrEmpty())
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');  //Comma Separated Values
                    id = Convert.ToInt32(values[0]);
                    item = values[1];
                    price = Convert.ToDouble(values[2]);
                    
                    Products p = new Products();
                    p.id = id;
                    p.item = item;
                    p.cost = price;
                    listProduct.Add(p);
                }
            }
            else
            {
                Console.WriteLine("File doesn't exist");
            }
            reader.Close();
            UpdateValue(listProduct);

            //after updateing the value
            foreach (Products i in listProduct)
            {
                Console.WriteLine(i.id + " " + i.item + " " + i.cost);
            }
        }
        static void UpdateValue(List<Products> listProducts)
        {
            string filepath = @"F:\\Products_update.txt";
            FileStream fw = new FileStream(filepath, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fw);
            foreach (Products p in listProducts)
            {
                p.cost = p.cost * 1.10;
                sw.WriteLine(p.id + "," + p.item + "," + p.cost);
            }
            sw.Close();
        }
        static void WriteProducts()
        {
            FileStream fs = null;
            fs = new FileStream("f:\\products.txt", FileMode.Create, FileAccess.Write);

            //2. create a Stream writer for the file stream
            StreamWriter sw = new StreamWriter(fs);

            //3. write data to the file using stream writer
            string data;
            Console.WriteLine("Enter data(press ENTER to exit):");
            data = Console.ReadLine();

            while (!String.IsNullOrEmpty(data))
            {
                sw.WriteLine(data);
                data = Console.ReadLine();
            }

            sw.Close();
            fs.Close();
        }
        static void ReadProducts()
        {
            FileStream fs = null;
            FileStream fw = null;

            fs = new FileStream("f:\\products.txt", FileMode.Open, FileAccess.Read);
            fw = new FileStream("f:\\products_updated.txt", FileMode.Create, FileAccess.Write);
            StreamReader sr = new StreamReader(fs);
            StreamWriter sw = new StreamWriter(fw);

            string data = "";
            data = sr.ReadLine();
            while (!String.IsNullOrEmpty(data))
            {
                Console.WriteLine(data);
                sw.WriteLine(data);
                data = sr.ReadLine();
            }
            sr.Close();

            //catch (IOException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    fs.Close();
            //}
        }
        class Products
        {
            public int id { get; set; }
            public string item { get; set; }
            public double cost { get; set; }
        }
    }
}