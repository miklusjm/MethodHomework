using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;

            while(loop == true)
            {
                Console.Clear();
                Console.WriteLine("Methods Homework");
                Console.WriteLine("July 25, 2016");
                Console.WriteLine("\n******************\n");
                Console.WriteLine("1.) String Reverse");
                Console.WriteLine("2.) Birth Month");
                Console.WriteLine("3.) Name Capitalizer");
                Console.WriteLine("4.) Zero Remover");
                Console.WriteLine("5.) Run them all in order\n");
                Console.Write("Enter your selection: ");
                string choice = Console.ReadLine();

                if (choice == "1" || choice == "5")
                {
                    Console.Clear();
                    Console.Write("Enter a string to be reversed: ");
                    string inputString = Console.ReadLine();
                    Console.WriteLine();
                    StringReverse(inputString);
                    Console.Write("\nHit any key to continue.");
                    Console.ReadKey();
                }
                if (choice == "2" || choice == "5")
                {
                    Console.Clear();
                    Console.Write("Enter your name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter your birth month: ");
                    string month = Console.ReadLine();
                    Console.WriteLine();
                    BirthMonth(name, month);
                    Console.Write("\nHit any key to continue.");
                    Console.ReadKey();
                }
                if (choice == "3" || choice == "5")
                {
                    Console.Clear();
                    Console.Write("Enter your first name: ");
                    string first = Console.ReadLine();
                    Console.Write("Enter your last name: ");
                    string last = Console.ReadLine();
                    string full = NameCapitalizer(first, last);
                    Console.WriteLine("\nFull name: " + full);
                }

            }
        }

        static void StringReverse(string s)
        {
            string[] sentence = s.Split();
            
            for (int x = sentence.Length - 1; x >= 0; x--)
            {
                Console.Write(sentence[x] + " ");
            }

            Console.WriteLine();
        }

        static void BirthMonth(string n, string m)
        {
            Console.Write(n + " is a");
            if (m == "April" || m == "August" || m == "October")
            {
                Console.Write("n");
            }
            Console.Write(" " + m + " baby!\n");
        }

        static string NameCapitalizer(string f, string l)
        {
            for (int x=1; x<f.Length; x++)
            {

            }

            string name = "";
            return name;
        }

        static void ZeroRemover(string s)
        {

        }
    }
}
