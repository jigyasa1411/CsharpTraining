using System;

namespace question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name (In alphabetical format): ");
            string name = Console.ReadLine(); //Taking student's name as input

            Console.WriteLine("Enter your Roll Number (In numeric format):");
            int rollNo = Convert.ToInt32(Console.ReadLine()); //Taking student's roll no. as input

            Console.WriteLine("Enter your age (In numeric format):");
            int age = Convert.ToInt32(Console.ReadLine()); // Taking student's age as input

            Console.WriteLine("Enter your class (In numeric format):");
            int Class = Convert.ToInt32(Console.ReadLine()); // Taking student's class as input

            Console.WriteLine("Enter your University Name (In alphabetical format):");
            string universityName = Console.ReadLine(); //Taking student's university name as input


            // Printing the details
            Console.WriteLine("_________________________________________________________________________");
            Console.WriteLine("Name: "+ name);
            Console.WriteLine("Roll Number: "+ rollNo);
            Console.WriteLine("Age: "+ age);
            Console.WriteLine("Class: "+ Class);
            Console.WriteLine("University Name: "+ universityName);
        }
    }
}
