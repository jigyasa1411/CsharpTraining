using System;

namespace question7
{
    class Program
    {
        static void Main(string[] args)
        {
            label:
                Console.WriteLine("Enter the number:");
                int num = Convert.ToInt32(Console.ReadLine());
            

            int power = 1;
            int n = num;
            while(n>0)
            {
                power*=num;
                n--;
            }
            // Printing the power
            Console.WriteLine("The power of {0} raised to power {1} is: {2}",num,num,power);

            // Asking user if he/she wants to continue or not.
            Console.WriteLine("If you wish to continue press y or Y otherwise press any key to exit.");
            string choice = Console.ReadLine();

            if(choice=="y" || choice=="Y")
            {
                goto label;
            }
            
        }
    }
}
