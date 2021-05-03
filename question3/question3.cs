using System;

namespace question3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine()); // Entering the number

            Console.WriteLine("Enter the power: ");
            int power = Convert.ToInt32(Console.ReadLine()); //Entering the exponent


            int result = 1;

            // Program to calculate power of a given number.
            if(power==0 || num==1)
            {
                Console.WriteLine("{0} raised to power {1} is {2}",num,power,result);
            }
            else
            {
                for(int i=1; i<=power; i++)
                {
                    result*=num;
                }

                Console.WriteLine("{0} raised to power {1} is {2}",num,power,result);
            }
        }
    }
}
