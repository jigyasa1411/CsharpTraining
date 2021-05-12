// PAYROLL MANAGEMENT SYSTEM USING OOPS AND FILE HANDLING CONCEPTS

using System;
using System.IO;

namespace PayrollManagementSystem
{

    public class Employee
    {
        // Specifying the attributes of the Employee
        private int empCode, empAge, numOfLeaves, totalWorkingDays, deductions ;

        private string empName, empGender, empDesignation, paymentMethod;

        private double empContact, empDailyPay;

       // Since atrributes are private so to support access of these attributes from other classes,
       // we will use get and set for all the attributes.

        public int EmpCode
        {
            get{ return empCode;}
            set{ empCode = value;}
        }

        public string EmpName
        {
            get{ return empName;}
            set{ empName = value;}
        }

        public string EmpDesignation
        {
            get{ return empDesignation;}
            set{ empDesignation = value;}
        }

        public double EmpDailyPay
        {
            get{ return empDailyPay;}
            set{ empDailyPay = value;}
        }

        public int TotalWorkingDays
        {
            get{ return totalWorkingDays;}
            set{ totalWorkingDays = value;}
        }

        public int Deductions
        {
            get{ return deductions;}
            set{ deductions = value;}
        }

        public double EmpContact
        {
            get{ return empContact;}
            set{ empContact = value;}
        }

        public int EmpAge
        {
            get{ return empAge;}
            set{ empAge = value;}
        }

        public string EmpGender
        {
            get{ return empGender;}
            set{ empGender = value;}
        }

        public string PaymentMethod
        {
            get{ return paymentMethod;}
            set{ paymentMethod = value;}
        }

        public int NumOfLeaves
        {
            get{ return numOfLeaves;}
            set{ numOfLeaves = value;}
        }
        



    }


    class AddEmployee : Employee, ItakeEntries  // Class to add a new employee and it is inhereting Employee class.
    {
        public void takeEntries()
        {
            try
            {
        
            Console.WriteLine("Enter employee code: ");
            EmpCode = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter employee's name: ");
            EmpName = Console.ReadLine();

            Console.WriteLine("Enter employee's contact: ");
            EmpContact = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter employee's age: ");
            EmpAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Gender: ");
            EmpGender = Console.ReadLine();

            Console.WriteLine("Enter designation: ");
            EmpDesignation = Console.ReadLine();

            Console.WriteLine("Enter employee's daily pay: ");
            EmpDailyPay = Convert.ToDouble(Console.ReadLine());
            }

            catch(Exception e)
            {
               
               Console.WriteLine("Enter valid type of input. Check below exception message.");
               Console.WriteLine("____________________________________________________________");
               Console.WriteLine(e.Message.ToString());
               Console.WriteLine("____________________________________________________________");
              
            }


                
        }
        public void addEmployeeDetails()
        {
            
            takeEntries(); //calling take entries method for taking entries.
            string[] ArrayLine = new string[7]; 
            
            ArrayLine[0] = EmpCode.ToString(); // Type casting non string types to string.
            ArrayLine[1] = EmpName;
            ArrayLine[2] = EmpContact.ToString();
            ArrayLine[3] = EmpAge.ToString();
            ArrayLine[4] = EmpGender;
            ArrayLine[5] = EmpDesignation;
            ArrayLine[6] = EmpDailyPay.ToString();

            System.IO.File.AppendAllLines("file.txt", ArrayLine);


        }
    }

    interface ItakeEntries
    {
        public void takeEntries();
    }


    class GeneratePayroll : Employee, ItakeEntries  // Class to generate payroll of an existing employee.
    {
        
       public bool checkEmployee(string EmpCode)
       {
            bool empExists = false;
           using (StreamReader sr = File.OpenText("file.txt"))
           {
                string[] lines = File.ReadAllLines("file.txt");
                bool isMatch = false;
                for (int x = 0; x < lines.Length - 1; x++)
                {
                    if (EmpCode == lines[x])  //Checking if employee code is present in our file or not.
                    {
                        sr.Close();
                        isMatch = true;
                        empExists = true;
                        return empExists;
                   

                    }
                }
                if (!isMatch)
                {
                    sr.Close();
                    empExists = false;
                    return empExists;
                
                }
                return empExists;
            }
        
            
       }

       public void takeEntries()
       {
           try
           {
           Console.WriteLine("Enter employee code: ");
           EmpCode = Convert.ToInt32(Console.ReadLine());

           if(checkEmployee(EmpCode.ToString())) // Checking if employee exists or not.
           {
               Console.WriteLine("Employee exists! Please move further for entering further details.");
           }
           else
           {
               Console.WriteLine("Employee doesn't exists! Please add a new employee if you wish to continue with same detail by pressing 1 in next run.");
               System.Environment.Exit(0); // The code will terminate if employee doesn't exists.
           }


           Console.WriteLine("Enter employee's full name: ");
           EmpName = Console.ReadLine();

           Console.WriteLine("Enter employee's daily pay for full working day: ");
           EmpDailyPay = Convert.ToDouble(Console.ReadLine());

           Console.WriteLine("Enter employee's total working days: ");
           TotalWorkingDays = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine("Enter the number of leaves: ");
           NumOfLeaves = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine("Is there any deductions to be reduced in employee's total pay, enter 0 in case of no deductions: ");
           Deductions = Convert.ToInt32(Console.ReadLine());
           }
           catch(Exception e)
           {
               
               Console.WriteLine("Enter valid type of input. Check below exception message.");
               Console.WriteLine("____________________________________________________________");
               Console.WriteLine(e.Message.ToString());
               Console.WriteLine("____________________________________________________________");

           }

       }
       public void enterEmployeeDetails()  // Method which takes employee's details.
       {
           Console.WriteLine("______________________Taking Employee's Details to generate payroll_______________");
           Console.WriteLine("<!NOTE> Only enter details of existing employees.");
           takeEntries();
           
           
           Console.WriteLine("____________________________________________________________");
           Console.WriteLine("Employee Code: "+EmpCode);
           Console.WriteLine("Employee name: "+EmpName);
           Console.WriteLine("Daily Pay: "+EmpDailyPay);
           Console.WriteLine("Total working days: "+TotalWorkingDays);
           Console.WriteLine("Total Number of Leaves: "+NumOfLeaves);
           Console.WriteLine("Deductions Rs. "+Deductions);
           Console.WriteLine("_________________________________________________________________");

        }

        public double calculatePayroll()
        {
            double payroll=0;

            // Calculating payroll of an employee.
            payroll = EmpDailyPay*TotalWorkingDays - (Deductions + NumOfLeaves*EmpDailyPay);

            return payroll;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nPAYROLL MANAGEMENT APPLICATION");
            Console.WriteLine("\n\nPress 1 if you wish to add an employee and find his/her payroll.");
            Console.WriteLine("Press 2 if you want to calculate payroll of an existing employee.");
            int choice = Convert.ToInt32(Console.ReadLine());

            if(choice == 1)
            {
                AddEmployee obj = new AddEmployee();
                obj.addEmployeeDetails();
            }
            else if(choice == 2)
            {
                GeneratePayroll obj = new GeneratePayroll();
                obj.enterEmployeeDetails();
                double payment = obj.calculatePayroll();
                Console.WriteLine("The payroll is Rs. "+payment);
                
            }
            else
            {
                Console.WriteLine("Enter valid choice.");
            }
        }
    }
}
