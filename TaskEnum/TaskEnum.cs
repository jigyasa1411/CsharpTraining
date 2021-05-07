using System;

namespace TaskEnum
{
    enum Months  // Defining Month's enum
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program takes an alphabet as input and return all the month names starting from that alphabet.");
            choice:
                Console.WriteLine("Enter an alphabet: ");
                string alphabet = Console.ReadLine();

            // Checking if input is empty or not.
            if(string.IsNullOrEmpty(alphabet))
            {
                Console.WriteLine("This field can not be empty or null. Enter valid input:");
                goto choice;
            }

            

            // As per the given input printing the month's name startimg from that letter.
            if(alphabet == "A" || alphabet == "a")
            {
                Console.WriteLine("Months starting with alphabet {0} : ",alphabet);
                Console.WriteLine(Months.April);
                Console.WriteLine(Months.August);
            }

            else if(alphabet == "D" || alphabet == "d")
            {
                Console.WriteLine("Months starting with alphabet {0} : ",alphabet);
                Console.WriteLine(Months.December);
            }

            else if(alphabet == "F" || alphabet == "f")
            {
                Console.WriteLine("Months starting with alphabet {0} : ",alphabet);
                Console.WriteLine(Months.February);
            }

            else if(alphabet == "J" || alphabet == "j")
            {
                Console.WriteLine("Months starting with alphabet {0} : ",alphabet);
                Console.WriteLine(Months.January);
                Console.WriteLine(Months.June);
                Console.WriteLine(Months.July);

            }

            else if(alphabet == "M" || alphabet == "m")
            {
                Console.WriteLine("Months starting with alphabet {0} : ",alphabet);
                Console.WriteLine(Months.March);
                Console.WriteLine(Months.May);
                
            }

            else if(alphabet == "N" || alphabet == "n")
            {
                Console.WriteLine("Months starting with alphabet {0} : ",alphabet);
                Console.WriteLine(Months.November);
                
            }

            else if(alphabet == "O" || alphabet == "o")
            {
                Console.WriteLine("Months starting with alphabet {0} : ",alphabet);
                Console.WriteLine(Months.October);
                
            }

            else if(alphabet == "S" || alphabet == "s")
            {
                Console.WriteLine("Months starting with alphabet {0} : ",alphabet);
                Console.WriteLine(Months.September);
            }
            
            else 
            {
                Console.WriteLine("Enter valid choice");
                goto choice;
            }
            
            
        }
    }
}
