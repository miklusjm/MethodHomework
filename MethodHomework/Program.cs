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
                Console.WriteLine("5.) Run them all in order");
                Console.WriteLine("6.) Quit\n");
                Console.Write("Enter your selection: ");
                string choice = Console.ReadLine();

                //String reverser
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

                //Birth month
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

                //Name capitalizer
                if (choice == "3" || choice == "5")
                {
                    Console.Clear();
                    Console.Write("Enter your first name: ");
                    string first = Console.ReadLine();
                    Console.Write("Enter your last name: ");
                    string last = Console.ReadLine();
                    string full = NameCapitalizer(first, last);
                    Console.WriteLine("\nFull name: " + full);
                    Console.Write("\nHit any key to continue.");
                    Console.ReadKey();
                }

                //Zero remover
                if (choice == "4" || choice == "5")
                {
                    Console.Clear();
                    Console.Write("Enter the string to check for zeroes: ");
                    string zeroString = Console.ReadLine();
                    ZeroRemover(zeroString);
                    Console.Write("\nHit any key to continue.");
                    Console.ReadKey();
                }

                if (choice == "6")
                {
                    loop = false;
                }

                if (choice != "1" && choice != "2" && choice != "3"
                    && choice != "4" && choice != "5" && choice != "6")
                {
                    Console.Write("\nInvalid selection. Hit any key to continue.");
                    Console.ReadKey();
                }

            }
        }

        static void StringReverse(string s)
        {
            string[] sentence = s.Split();
            
            for (int x = sentence.Length - 1; x >= 0; x--)
            {
                Console.Write(sentence[x]);
                if (x > 0)
                {
                    Console.Write(" ");
                }
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
            string name = f.Substring(0, 1).ToUpper() + f.Substring(1) + " " + l.Substring(0, 1).ToUpper() + l.Substring(1);
            return name;
        }

        static void ZeroRemover(string s)
        {
            bool flag = false;

            for (int x = 0; x < s.Length; x++)
            {
                if (s.Substring(x,1) == "0")
                {
                    s = s.Remove(x, 1);
                    flag = true;
                }
            }

            if (flag == true)
            {
                Console.WriteLine("\n" + s);
            }
            else
            {
                Console.WriteLine("This string is okay!");
            }
        }
    }
}
