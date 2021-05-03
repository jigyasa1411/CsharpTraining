using System;

namespace question8b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows:");
            int totalRows = Convert.ToInt32(Console.ReadLine());

            // Print simple pyramid..
            for (int i = 1; i <= totalRows; i++)
            {
                // Loop For Space
                for (int j = 1; j <= (totalRows - i); j++)
                    Console.Write(" ");
                //increase the number value
                for (int Number = 1; Number <= i; Number++)
                    Console.Write(Number);
                //decrease the number value
                for (int Number = (i - 1); Number >= 1; Number--)
                    Console.Write(Number);
                Console.WriteLine();
            }
 
            //Print reverse pyramid..
            for (int i = (totalRows - 1); i >= 1; i--)
            {
                // Loop For Space
                for (int j = 1; j <= (totalRows - i); j++)
                    Console.Write(" ");
                //increase the number value
                for (int Number = 1; Number <= i; Number++)
                    Console.Write(Number);
                //decrease the number value
                for (int Number = (i - 1); Number >= 1; Number--)
                    Console.Write(Number);
                Console.WriteLine();
            }
            
        }
    }
}
