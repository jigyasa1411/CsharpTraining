using System;

namespace question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine(); //Taking student's name as input

            Console.WriteLine("Enter your Roll Number:");
            int rollNo = Convert.ToInt32(Console.ReadLine()); //Taking student's roll no. as input

            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine()); // Taking student's age as input

            Console.WriteLine("Enter your class:");
            int Class = Convert.ToInt32(Console.ReadLine()); // Taking student's class as input

            Console.WriteLine("Enter your University Name:");
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
