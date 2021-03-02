/*
 4.4 Press Release Application
It is a interesting application about how media/press releases the news
4.4.1 Objective:
Understand how events are used with the help of delegate.
4.4.2 Problem Statement:
TNN (Times News Network) publishes press releases throughout India and World through World News and National News.
Each and every subscriber can get the news (press releases) through them, provided they subscribe to the TNN, either 
World News unit or National News unit. Create an application through which any subscriber, by subscribing to any of those units,
can get the current news from TNN.

Hint: You need to create an entity/class called TNN with two events, WorldNews and NationalNews. 
Publication is done through these two events. The argument of press release event should contain the description of 
the press release (Report). Finally, each and every subscriber should be represented by an entity, which will receive press 
release by subscribing some method.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_QS_4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            TNN tnn = new TNN();
            tnn.TelecastCurrentNewsToSubscriber();
        }
        class TNN
        {
            //WorldNewsUnit;
            //NationalNewsUnit;
            string ChoosingSection;
            public void TelecastCurrentNewsToSubscriber()
            {
                Subscriber sc = new Subscriber();
                sc.dlg = new Subscriber.CallbackDelegate(this.News);
                sc.DoSubscribe();
            }
            void News(string msg)
            {
                ChoosingSection = msg;
                if (ChoosingSection.Equals("WorldNews"))
                {
                    Console.WriteLine("You have subscribed Current World news...");
                    Console.WriteLine("World News Headlines.......");
                }
                else
                {
                    Console.WriteLine("You have subscribed Current National news...");
                    Console.WriteLine("National News Headlines....");
                }
            }
        }
        class Subscriber
        {
            public delegate void CallbackDelegate(string msg);
            public CallbackDelegate dlg = null;
            public void DoSubscribe()
            {
                Console.WriteLine("Subscribe to the Section... \n1.WorldNews\t2.NationalNews");
                int choice = int.Parse(Console.ReadLine());
                if(choice==1)
                {
                    dlg("WorldNews");
                }
                else if (choice == 2)
                {
                    dlg("NationalNews");
                }
                else
                {
                    Console.WriteLine("Wrong Choice...");
                }
            }
        }
    }
}