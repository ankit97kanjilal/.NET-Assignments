using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day8CollectionDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager prodMgr = new ProductManager();
            //read products.txt file and store the records into collection
            List<Product> lstProducts = prodMgr.GetAllProducts();
            DisplayProducts(lstProducts);

            //process the collection and update the price
            prodMgr.UpdatePrice(lstProducts);
            DisplayProducts(lstProducts);

            //write the updated collection into new file products_updated.txt
            prodMgr.SaveUpdatedProducts(lstProducts);
        }

        static void DisplayProducts(List<Product> lstProducts)
        {
            foreach (Product product in lstProducts)
            {
                Console.WriteLine(product.ProductId +"\t"+product.Description+"\t"+product.Price);
            }
        }

    }

    class ProductManager
    {       
        public List<Product> GetAllProducts ()
        {
            List<Product> lstProducts = new List<Product>();
            FileStream fs = new FileStream(@"..\..\products.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();
            while (!String.IsNullOrEmpty(line))
            {
                string[] cols = line.Split(',');
                Product product = new Product
                {
                    ProductId = int.Parse(cols[0]),
                    Description = cols[1],
                    Price = double.Parse(cols[2])
                };

                lstProducts.Add(product);
                line = sr.ReadLine();
            }

            sr.Close();
            fs.Close();

            return lstProducts;
        }

        public void UpdatePrice(List<Product> lstProducts)
        {
            foreach (Product product in lstProducts)
            {
                product.Price += product.Price * 0.1;
            }
        }

        public void SaveUpdatedProducts(List<Product> lstProducts)
        {
            FileStream fs = new FileStream("..\\..\\products_updated.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            foreach (Product product in lstProducts)
            {
                string line = "";
                string[] cols = new string[3];
                cols[0] = product.ProductId.ToString();
                cols[1] = product.Description;
                cols[2] = product.Price.ToString();

                line = String.Join(",", cols);

                sw.WriteLine(line);
            }
            sw.Close();
            fs.Close();
        }
    }
}
