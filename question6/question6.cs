using System;

namespace question6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program for Libraray management system
            Console.WriteLine("Choose one of the following options respect to kind of book you are looking for: ");
            Console.WriteLine("c: for computer books");
            Console.WriteLine("m: for mathematical books");
            Console.WriteLine("h: for history books");
            Console.WriteLine("e: for English books");

            label:
                Console.WriteLine("Enter your option:");
                string option = Console.ReadLine();

            switch(option)
            {
                case "c":
                    Console.WriteLine("COMPUTER BOOKS");
                    break;
                
                case "m":
                    Console.WriteLine("MATHEMATICAL BOOKS");
                    break;
                
                case "h":
                    Console.WriteLine("HISTORY BOOKS");
                    break;

                case "e":
                    Console.WriteLine("ENGLISH BOOKS");
                    break;

                default:
                    Console.WriteLine("Please choose correct option");
                    goto label; // Prompting user back to enter a legitimate option by going back to label statement above.
            }

        }
    }
}
