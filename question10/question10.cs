using System;

namespace question10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program to count total number of duplicate elements in an array.
            Console.WriteLine("Enter the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[size]; 
            int count = 0;
            

            Console.WriteLine("Enter the elements in the array: ");
            for (int i = 0; i < size; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("The First Array Contains");
            for (int i = 0; i < size; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine("\n");
            for (int i = 0; i < size;i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (a[i] == a[j])
                    {
                        count++;
                        break;
                    }
                }
            }
            Console.WriteLine("The number of Duplicate Elements Present in Array is={0}", count);
           
        }
    }
}
