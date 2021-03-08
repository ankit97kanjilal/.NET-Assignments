using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //for file operations: creating, reading, writing, appending
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using N1;
namespace Day7FileOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            MyApp app = new MyApp();
            

            //WriteText();
            //Console.WriteLine("File created");
            //ReadTextFile();
            //WriteBinaryData();
            //ReadBinaryData();
            //SaveEmployee();
            //ReadEmployee();
            //SaveToXml();
        }
        static void WriteText()
        {
            //1. create a file stream 
            FileStream fs = null;

            fs = new FileStream("f:\\letter.txt", FileMode.Create, FileAccess.Write);

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
            
            //4. close the file stream
            sw.Close();

            //5. close the file stream
            fs.Close();
        }

        static void ReadTextFile()
        {
            FileStream fs=null;
            try
            {               

                fs = new FileStream("f:\\letter.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);

                string data = "";
                data = sr.ReadLine();
                while (!String.IsNullOrEmpty(data))
                {
                    Console.WriteLine(data);
                    data = sr.ReadLine();
                }

                sr.Close();
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        static void WriteBinaryData()
        {
            FileStream fs = null;
            fs = new FileStream("f:\\data.txt", FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);

            int ecode = 101;
            string ename = "Ramnath";
            int salary = 1111;
            int deptid = 201;

            bw.Write(ecode);
            bw.Write(ename);
            bw.Write(salary);
            bw.Write(deptid);

            Console.WriteLine("Data stored");

            bw.Close();
            fs.Close();

        }

        static void ReadBinaryData()
        {
            FileStream fs = null;
            fs = new FileStream("f:\\data.txt", FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

            int ecode = br.ReadInt32();
            string ename = br.ReadString();
            int salary = br.ReadInt32();
            int deptid = br.ReadInt32();

            Console.WriteLine(ecode + "\t" + ename + "\t" + salary + "\t" + deptid);
        }

        static void SaveEmployee()
        {
            FileStream fs = new FileStream("f:\\employee.txt", FileMode.Create, FileAccess.Write);

            List<Employee> lstEmps = new List<Employee>
            {
             new Employee("ITC"){Ecode =101,Ename ="Ramnath",Salary =1111,Deptid=201 },
             new Employee("IBM"){Ecode =102,Ename ="Rahul",Salary =2222,Deptid=202 },
             new Employee("CTS"){Ecode =103,Ename ="Ramesh",Salary =3333,Deptid=203 }
            };
            

            BinaryFormatter binFmt = new BinaryFormatter();
            binFmt.Serialize(fs, lstEmps);
            Console.WriteLine("Employees records serialized");

            fs.Close();

        }

        static void ReadEmployee()
        {
            FileStream fs = new FileStream("f:\\employee.txt", FileMode.Open, FileAccess.Read);
            
            BinaryFormatter binFmt = new BinaryFormatter();
            List<Employee> lstEmps = (List<Employee>)binFmt.Deserialize(fs);

            foreach (Employee obj in lstEmps)
            {
                Console.WriteLine(obj.Ecode + "\t" + obj.Ename + "\t" + obj.Salary + "\t" + obj.Deptid);
            }

            fs.Close();

        }
        static void SaveToXml()
        {
            FileStream fs = new FileStream("f:\\employee.xml", FileMode.Create, FileAccess.Write);

            List<Employee> lstEmps = new List<Employee>
            {
             new Employee("ITC"){Ecode =101,Ename ="Ramnath",Salary =1111,Deptid=201 },
             new Employee("IBM"){Ecode =102,Ename ="Rahul",Salary =2222,Deptid=202 },
             new Employee("CTS"){Ecode =103,Ename ="Ramesh",Salary =3333,Deptid=203 }
            };


            XmlSerializer xmlSer = new XmlSerializer(lstEmps.GetType());
            xmlSer.Serialize(fs, lstEmps);
            Console.WriteLine("Employees records serialized to xml");

            fs.Close();
        }
    }
}


class Test
{
    virtual public void Method1()
    {

    }
}
class Demo : Test 
{
    sealed public override void Method1()
    {
       
    }
}
class Grand : Demo
{
    //override 
}

namespace N1
{
    partial class MyApp
    {
        partial void Method1();
        public void Method2()
        {
            //TODO
        }
    }
    partial class MyApp
    {
        partial void Method1()
        {
            //todo
        }
        public void Method3()
        {
            //TODO
        }
        public void Method4()
        {
            //TODO
        }
    }
}