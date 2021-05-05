using System;

namespace question1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine(); //Taking user's name as input

            Console.WriteLine("Enter your city:");
            string city = Console.ReadLine(); //Taking user's city as input

            Console.WriteLine("Enter your street:");
            string street = Console.ReadLine(); // Taking user's street as input

            Console.WriteLine("Enter your pin:");
            int pinCode = Convert.ToInt32(Console.ReadLine()); // Taking user's pin 

            Console.WriteLine("Enter your House number:");
            int houseNo =Convert.ToInt32(Console.ReadLine()); //Taking user's house no.


            // Printing the details
            Console.WriteLine("_________________________________________________________________________");
            Console.WriteLine("Name: "+ name);
            Console.WriteLine("City: "+ city);
            Console.WriteLine("Street: "+ street);
            Console.WriteLine("Pin Code: "+ pinCode);
            Console.WriteLine("House Number: "+ houseNo);
        }
    }
}
