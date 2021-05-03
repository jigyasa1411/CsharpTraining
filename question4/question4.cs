using System;

namespace question4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program for calculation of area of triangle

            Console.WriteLine("Enter the base of triangle:");
            double TriangleBase = Convert.ToDouble(Console.ReadLine()); // Taking base of the triangle

            Console.WriteLine("Enter height of the triangle:");
            double TriangleHeight = Convert.ToDouble(Console.ReadLine()); // Taking height of the triangle

            double area = (TriangleBase*TriangleHeight)/2;
            Console.WriteLine("Area of triangle is : "+ area );



        
        }
    }
}
