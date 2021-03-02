/*
 * Write a program to take words and meaning of theword and display the meaning
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCollection1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Add Words 2. Search Meaning 3. Any other key to exit");
            Dictionary<string, string> dictWord = new Dictionary<string, string>();
            while (1 > 0)
            {
                Console.WriteLine("Enter your choice: ");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    Console.WriteLine("You choose to add words meaning...");
                    dictWord = DoAddWord(dictWord);
                }
                else if (choice == "2")
                {
                    Console.WriteLine("Search the meaning of a word...");
                    SearchMeaning(dictWord);
                }
                else
                {
                    Console.WriteLine("Thank you for using this service...");
                    break;
                }
            }
        }
        static Dictionary<string,string> DoAddWord(Dictionary<string,string> dictWord)
        {
            Console.Write("Enter the Word: ");
            string word = Console.ReadLine();
            Console.Write("Enter the Meaning: ");
            string meaning = Console.ReadLine();
            dictWord.Add(word, meaning);
            return dictWord;
        }
        static void SearchMeaning(Dictionary<string,string> dictWord)
        {
            Console.WriteLine("Enter the word you want to know the meaning: ");
            string word = Console.ReadLine();
            int flag = 0;
            foreach (string key in dictWord.Keys)
            {
                if(key.Equals(word))
                {
                    flag = 1;
                    Console.WriteLine("Meaning of the word is: "+dictWord[key]);
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("Sorry, no words found with this name..");
            }
        }
    }
}
