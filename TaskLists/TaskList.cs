using System;
using System.Collections.Generic;
using System.Linq;

namespace TaskLists
{
    class Program
    {

        
        static void Main(string[] args)
        {
           label:
                Console.WriteLine("What kind of list you are intending to operate with: ");
                Console.WriteLine("Press 1 for Integer List.");
                Console.WriteLine("Press 2 for String List: ");
                Console.WriteLine("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many elements do you want in your list: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int count; // specifies count of a particular element in the list.

            if(choice == 1)
            {
                List <int> intList = new List<int>();
                List <int> freqList = new List<int>();
                Console.WriteLine("Enter the elements in your integer list. After inserting each element press enter key to enter next element.: ");
                for(int i =0; i<size; i++)
                {
                    intList.Add(Convert.ToInt32(Console.ReadLine()));
                    freqList.Add(-1);
                }


                Console.WriteLine("\n\nOriginal List: ");
                foreach(int i in intList)
                {
                    Console.Write(" "+i);
                }
                Console.WriteLine();

               
                //Sorting
                intList.Sort();
                Console.WriteLine("\n\nSorted List: ");
                foreach(int i in intList)
                {
                    Console.Write(" "+i);
                }

                // Calculating frequency
                Console.WriteLine("\n\nFrequency: ");
                
                // Frequency Counting
                for(int i=0; i<size; i++)
                {
                    count = 1;
                    for(int j=i+1; j<size; j++)
                    {
                        if(intList[i]==intList[j])
                        {
                            count++;
                            freqList[j] = 0;
                        }
                    }

                    if(freqList[i]!=0)
                    {
                        freqList[i] = count;
                    }
                }

                // Frequency Printing
                for(int i=0; i<size; i++)
                {
                    if(freqList[i]!=0)
                    {
                        Console.Write("Frequency of {0} is {1}.\n", intList[i], freqList[i]);
                    }

                }
                
            }

            else if(choice == 2)
            {
                List <string> stringList = new List<string>();
                List <int> freqList = new List<int>();

                Console.WriteLine("Enter the elements in your integer list: After inserting each element press enter key to insert next element.: ");
                for(int i =0; i<size; i++)
                {
                    stringList.Add(Console.ReadLine());
                    freqList.Add(-1); // Insert -1 at each index in the frequency list.
                }


                Console.WriteLine("\n\nOriginal List: ");
                foreach(string i in stringList)
                {
                    Console.Write(" "+i);
                }
                Console.WriteLine();

               
                //Sorting
                stringList.Sort();
                Console.WriteLine("\n\nSorted List: ");
                foreach(string i in stringList)
                {
                    Console.Write(" "+i);
                }


                // Calculating Frequency
                Console.WriteLine("\n\nFrequency: ");
                // Frequency Counting
                for(int i=0; i<size; i++)
                {
                    count = 1;
                    for(int j=i+1; j<size; j++)
                    {
                        if(stringList[i]==stringList[j])
                        {
                            count++;
                            freqList[j] = 0;
                        }
                    }

                    if(freqList[i]!=0)
                    {
                        freqList[i] = count;
                    }
                }

                
                // Frequency Printing
                for(int i=0; i<size; i++)
                {
                    if(freqList[i]!=0)
                    {
                        Console.Write("Frequency of {0} is {1}.\n", stringList[i], freqList[i]);
                    }

                }
            }

            else
            {
                Console.WriteLine("Enter valid input: ");
                goto label;
            }


        }
    }
}
