using System;
using System.IO;


class fileHandling
{
    static void Main(string[] args)
    {
		string nameOfFile = @"file.txt";
		string[] ArrLines ;
		int displayLines=1; // Set default lines to be displayed as 1.

	   
        if (File.Exists(nameOfFile))  // Checking if file has been created or not.
        {
                File.Delete(nameOfFile);
        }


       // Taking the total number of lines to be contained in the file by the user.
       Console.WriteLine("Enter the number of lines you want in your file  :");
       int numOfLines = Convert.ToInt32(Console.ReadLine());
       ArrLines=new string[numOfLines];    


       Console.WriteLine("\n\nInput {0} strings below :\n",numOfLines); //Taking the lines entered in the file.
		for(int i=0;i<numOfLines;i++)
		{
		    Console.WriteLine("Enter line {0} : ",i+1);
		    ArrLines[i] = Console.ReadLine();	
		}	


        // writing the lines in our file by using WriteAllLines() method.
        System.IO.File.WriteAllLines(nameOfFile, ArrLines); //ArrLines will be written in our file "nameOfFile.txt".
		

        selectLine:
            Console.WriteLine("\n\nEnter how many last line(s) you want to display :");
            int linesToDisplay = Convert.ToInt32(Console.ReadLine()); 
            displayLines=linesToDisplay; // Setting Display Lines to user entered lines to be displayed.


        if(linesToDisplay>=1 && linesToDisplay<=numOfLines)
        {
            Console.WriteLine("\n\nThe content of the last {0} lines of the file {1} is : \n",linesToDisplay,nameOfFile);
			if (File.Exists(nameOfFile))
			{
                Console.WriteLine("The last {0} lines are: ",linesToDisplay);
				for(int i=numOfLines-linesToDisplay;i<numOfLines;i++)
				{
				    string[] lines = File.ReadAllLines(nameOfFile);
				    Console.WriteLine(lines[i]);
				    displayLines--;
				}
			}
		}
		
        else
		{
			Console.WriteLine("Please enter valid number of lines.");
            goto selectLine;
		}

             
    }
}