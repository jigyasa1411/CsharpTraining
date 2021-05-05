using System;

namespace question5
{
    class Program
    {
        static void Main(string[] args)
        {
            // program for Tax calculation
            double tax = 0; //Initially value of tax be zero.
            Console.WriteLine("Enter the amount:");
            double amount = Convert.ToDouble(Console.ReadLine()); //Amount is changed into double data type.

            if(amount<10000) 
            {
                tax = (0.05)*amount;
                Console.WriteLine("The tax for {0} amount is 5% of amount which is: {1}",amount,tax);
            }
            else if(amount>=10000 && amount <= 100000)
            {
                tax = (0.08)*amount;
                Console.WriteLine("The tax for {0} amount is 8% of amount which is: {1}",amount,tax);
            }
            else
            {
                tax = (0.085)*amount;
                Console.WriteLine("The tax for {0} amount is 8.5% of amount which is: {1}",amount,tax);

            }
        }
    }
}
