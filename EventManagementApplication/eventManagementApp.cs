using System;

namespace EventManagementApplication
{
    class Event //PARENT CLASS
    {
        public string eventName; // specifies the name of event i.e. birthday party etc.
        public string eventType; // Specifies whether an event is a day or evening event.

        public int numOfguest; // Specifies the expected number of attendees.

        public int package; //Specifies the package selected by the user such as regular or premium etc.

        public int expense; // specifies the expense to be incurred for the party.

        public string venue; // specifies the venue of the event.

        public string decoration; //specifies the kind decoration.

        
    }
}


// BIRTHDAY EVENT CHILD CLASS
namespace EventManagementApplication
{

    class Birthday : Event
    {
        public void setEventName(string en)
        {
            eventName = en;  //Inhereting atttribute(eventName from base class)
        }
        
        public void setEventType(string et)
        {
            eventType = et;
        }

        public void setNumOfguest(int ng)
        {
            numOfguest = ng;
        }

        public void setPackage(int p)
        {
            package = p;
        }

        public int getExpense()
        {
            if(package == 1) // Premium Package
            {
                expense = 500*numOfguest + 50000;
                return expense;
            }

            else if(package == 2) // Regular Package
            {
                expense = 400*numOfguest +40000;
                return expense;
            }

            else if(package == 3)  // Budget Package
            {
                expense = 300*numOfguest + 30000;
                return expense;
            }
            
            else
            {
                expense = 0; //Default is 0 for wrong pacakge selected.
                return expense;
            }
        }

        public void setVenue(string sv)
        {
            venue = sv;
        }

        public void setDecoration(string sd)
        {
            decoration = sd;
        }


    }
}



// WEDDING EVENT CHILD CLASS
namespace EventManagementApplication
{

    class Wedding : Event
    {
        public void setEventName(string en)
        {
            eventName = en;  //Inhereting atttribute(eventName from base class)
        }
        
        public void setEventType(string et)
        {
            eventType = et;
        }

        public void setNumOfguest(int ng)
        {
            numOfguest = ng;
        }

        public void setPackage(int p)
        {
            package = p;
        }

        public int getExpense()
        {
            if(package == 1) // Premium Package
            {
                expense = 500*numOfguest + 50000;
                return expense;
            }

            else if(package == 2) // Regular Package
            {
                expense = 400*numOfguest +40000;
                return expense;
            }

            else if(package == 3)  // Budget Package
            {
                expense = 300*numOfguest + 30000;
                return expense;
            }
            
            else
            {
                expense = 0; //Default is 0 for wrong pacakge selected.
                return expense;
            }
        }

        public void setVenue(string sv)
        {
            venue = sv;
        }

        public void setDecoration(string sd)
        {
            decoration = sd;
        }


    }
}



// RECEPTION EVENT CHILD CLASS
namespace EventManagementApplication
{

    class Reception : Event
    {
        public void setEventName(string en)
        {
            eventName = en;  //Inhereting atttribute(eventName from base class)
        }
        
        public void setEventType(string et)
        {
            eventType = et;
        }

        public void setNumOfguest(int ng)
        {
            numOfguest = ng;
        }

        public void setPackage(int p)
        {
            package = p;
        }

        public int getExpense()
        {
            if(package == 1) // Premium Package
            {
                expense = 500*numOfguest + 50000;
                return expense;
            }

            else if(package == 2) // Regular Package
            {
                expense = 400*numOfguest +40000;
                return expense;
            }

            else if(package == 3)  // Budget Package
            {
                expense = 300*numOfguest + 30000;
                return expense;
            }
            
            else
            {
                expense = 0; //Default is 0 for wrong pacakge selected.
                return expense;
            }
        }

        public void setVenue(string sv)
        {
            venue = sv;
        }

        public void setDecoration(string sd)
        {
            decoration = sd;
        }


    }
}


// ENGAGEMENT EVENT CHILD CLASS
namespace EventManagementApplication
{

    class Engagement : Event
    {
        public void setEventName(string en)
        {
            eventName = en;  //Inhereting atttribute(eventName from base class)
        }
        
        public void setEventType(string et)
        {
            eventType = et;
        }

        public void setNumOfguest(int ng)
        {
            numOfguest = ng;
        }

        public void setPackage(int p)
        {
            package = p;
        }

        public int getExpense()
        {
            if(package == 1) // Premium Package
            {
                expense = 500*numOfguest + 50000;
                return expense;
            }

            else if(package == 2) // Regular Package
            {
                expense = 400*numOfguest +40000;
                return expense;
            }

            else if(package == 3)  // Budget Package
            {
                expense = 300*numOfguest + 30000;
                return expense;
            }
            
            else
            {
                expense = 0; //Default is 0 for wrong pacakge selected.
                return expense;
            }
        }

        public void setVenue(string sv)
        {
            venue = sv;
        }

        public void setDecoration(string sd)
        {
            decoration = sd;
        }


    }
}




namespace EventManagementApplication
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine("-----------------------SUNSHINE EVENT MANAGEMENT SERVICES PVT. LTD.------------------------------");
            Console.WriteLine("---------------------We are here to take your hassle of managing an event------------------------");


           // Birthday obj1 = new Birthday(); //Creating object of the Birthday Event
            label:
                Console.WriteLine("\n");
                Console.WriteLine("Choose from the following events that we manage: "); //Getting the selection of the event
                Console.WriteLine("Enter 1 for a Birthday Event.");
                Console.WriteLine("Enter 2 for a Wedding Event.");
                Console.WriteLine("Enter 3 for a Reception Event.");
                Console.WriteLine("Enter 4 for a Engagement Event.");
                Console.WriteLine("Enter your event selection: ");
                int selection = Convert.ToInt32(Console.ReadLine());

            //Creating object of every event class based on the chosen event name.
            
            if(selection == 1) // BIRTHDAY IS THE EVENT
            {
                Birthday obj1 = new Birthday();
                Console.WriteLine("Enter the name of event: "); //Getting Name of the event
                string name = Console.ReadLine();
                obj1.setEventName(name); // Setting the name of the event
            
                Console.WriteLine("\n");
                Console.WriteLine("Enter the type of the party: "); //Getting Type of event.
                string ptype = Console.ReadLine();
                obj1.setEventType(ptype);


                Console.WriteLine("\n");
                Console.WriteLine("Enter the estimated number of guests: "); // Getting estimated number of Guests.
                int nguest = Convert.ToInt32(Console.ReadLine());
                obj1.setNumOfguest(nguest);

                Console.WriteLine("\n");
                Console.WriteLine("Choose one of the following packages: ");
                Console.WriteLine("Press 1 for Premium (500 per person)");
                Console.WriteLine("Press 2 for Regular (400 per person)");
                Console.WriteLine("Press 3 for Budget (300 per person)");
                Console.WriteLine("Enter your choice: ");
                int pack = Convert.ToInt32(Console.ReadLine()); //Getting the pacakge selection as input.
                obj1.setPackage(pack);


                Console.WriteLine("\n");
                Console.WriteLine("enter your venue: "); //Getting the venue;
                string ven = Console.ReadLine();
                obj1.setVenue(ven);


                Console.WriteLine("\n");
                Console.WriteLine("Choose one of the following decoration themes:");
                Console.WriteLine("Royal Theme");
                Console.WriteLine("Floral Decoration");
                Console.WriteLine("Balloon Decoration");
                Console.WriteLine("Custom (Please contact us for further discussion)");
                Console.WriteLine("Enter your choice: ");
                string deco = Console.ReadLine();  // Getting Decoration selection
                obj1.setDecoration(deco);


                int expenditure = obj1.getExpense(); //Calculating total expense of the event.

                // Displaying all the details regarding the event
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.WriteLine("*************************************************************************************************");
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.WriteLine("Here's the details of the event you are planning for:\n");
                Console.WriteLine("Party Name:"+ obj1.eventName); //Inhereting attribute names from parent class
                Console.WriteLine("Party Type: "+ obj1.eventType);
                Console.WriteLine("Expected number of guests: "+ obj1.numOfguest);
                Console.WriteLine("Package Selected : "+ obj1.package);
                Console.WriteLine("Selected Venue: "+obj1.venue);
                Console.WriteLine("Selected decoration Theme: "+ obj1.decoration);
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.WriteLine("Your Total Expensde is: "+obj1.expense);
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.WriteLine("*************************************************************************************************");
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
            }

            else if(selection == 2)  //WEDDING IS THE EVENT
            {
                Wedding obj1 = new Wedding();
                Console.WriteLine("Enter the name of event: "); //Getting Name of the event
                string name = Console.ReadLine();
                obj1.setEventName(name); // Setting the name of the event
            
                Console.WriteLine("\n");
                Console.WriteLine("Enter the type of the party: "); //Getting Type of event.
                string ptype = Console.ReadLine();
                obj1.setEventType(ptype);


                Console.WriteLine("\n");
                Console.WriteLine("Enter the estimated number of guests: "); // Getting estimated number of Guests.
                int nguest = Convert.ToInt32(Console.ReadLine());
                obj1.setNumOfguest(nguest);

                Console.WriteLine("\n");
                Console.WriteLine("Choose one of the following packages: ");
                Console.WriteLine("Press 1 for Premium (500 per person)");
                Console.WriteLine("Press 2 for Regular (400 per person)");
                Console.WriteLine("Press 3 for Budget (300 per person)");
                Console.WriteLine("Enter your choice: ");
                int pack = Convert.ToInt32(Console.ReadLine()); //Getting the pacakge selection as input.
                obj1.setPackage(pack);


                Console.WriteLine("\n");
                Console.WriteLine("enter your venue: "); //Getting the venue;
                string ven = Console.ReadLine();
                obj1.setVenue(ven);


                Console.WriteLine("\n");
                Console.WriteLine("Choose one of the following decoration themes:");
                Console.WriteLine("Royal Theme");
                Console.WriteLine("Floral Decoration");
                Console.WriteLine("Balloon Decoration");
                Console.WriteLine("Custom (Please contact us for further discussion)");
                Console.WriteLine("Enter your choice: ");
                string deco = Console.ReadLine();  // Getting Decoration selection
                obj1.setDecoration(deco);


                int expenditure = obj1.getExpense(); //Calculating total expense of the event.

                // Displaying all the details regarding the event
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.WriteLine("*************************************************************************************************");
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.WriteLine("Here's the details of the event you are planning for:\n");
                Console.WriteLine("Party Name:"+ obj1.eventName); //Inhereting attribute names from parent class
                Console.WriteLine("Party Type: "+ obj1.eventType);
                Console.WriteLine("Expected number of guests: "+ obj1.numOfguest);
                Console.WriteLine("Package Selected : "+ obj1.package);
                Console.WriteLine("Selected Venue: "+obj1.venue);
                Console.WriteLine("Selected decoration Theme: "+ obj1.decoration);
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.WriteLine("Your Total Expensde is: "+obj1.expense);
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.WriteLine("*************************************************************************************************");
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
            }

            else if(selection == 3)  //RECEPTION IS THE EVENT
            {
                Reception obj1 = new Reception();
                Console.WriteLine("Enter the name of event: "); //Getting Name of the event
                string name = Console.ReadLine();
                obj1.setEventName(name); // Setting the name of the event
            
                Console.WriteLine("\n");
                Console.WriteLine("Enter the type of the party: "); //Getting Type of event.
                string ptype = Console.ReadLine();
                obj1.setEventType(ptype);


                Console.WriteLine("\n");
                Console.WriteLine("Enter the estimated number of guests: "); // Getting estimated number of Guests.
                int nguest = Convert.ToInt32(Console.ReadLine());
                obj1.setNumOfguest(nguest);

                Console.WriteLine("\n");
                Console.WriteLine("Choose one of the following packages: ");
                Console.WriteLine("Press 1 for Premium (500 per person)");
                Console.WriteLine("Press 2 for Regular (400 per person)");
                Console.WriteLine("Press 3 for Budget (300 per person)");
                Console.WriteLine("Enter your choice: ");
                int pack = Convert.ToInt32(Console.ReadLine()); //Getting the pacakge selection as input.
                obj1.setPackage(pack);


                Console.WriteLine("\n");
                Console.WriteLine("enter your venue: "); //Getting the venue;
                string ven = Console.ReadLine();
                obj1.setVenue(ven);


                Console.WriteLine("\n");
                Console.WriteLine("Choose one of the following decoration themes:");
                Console.WriteLine("Royal Theme");
                Console.WriteLine("Floral Decoration");
                Console.WriteLine("Balloon Decoration");
                Console.WriteLine("Custom (Please contact us for further discussion)");
                Console.WriteLine("Enter your choice: ");
                string deco = Console.ReadLine();  // Getting Decoration selection
                obj1.setDecoration(deco);


                int expenditure = obj1.getExpense(); //Calculating total expense of the event.

                // Displaying all the details regarding the event
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.WriteLine("*************************************************************************************************");
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.WriteLine("Here's the details of the event you are planning for:\n");
                Console.WriteLine("Party Name:"+ obj1.eventName); //Inhereting attribute names from parent class
                Console.WriteLine("Party Type: "+ obj1.eventType);
                Console.WriteLine("Expected number of guests: "+ obj1.numOfguest);
                Console.WriteLine("Package Selected : "+ obj1.package);
                Console.WriteLine("Selected Venue: "+obj1.venue);
                Console.WriteLine("Selected decoration Theme: "+ obj1.decoration);
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.WriteLine("Your Total Expensde is: "+obj1.expense);
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.WriteLine("*************************************************************************************************");
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
            }

            else if(selection == 4) // ENGAGEMENT IS THE EVENT
            {
                Engagement obj1 = new Engagement();
                Console.WriteLine("Enter the name of event: "); //Getting Name of the event
                string name = Console.ReadLine();
                obj1.setEventName(name); // Setting the name of the event
            
                Console.WriteLine("\n");
                Console.WriteLine("Enter the type of the party: "); //Getting Type of event.
                string ptype = Console.ReadLine();
                obj1.setEventType(ptype);


                Console.WriteLine("\n");
                Console.WriteLine("Enter the estimated number of guests: "); // Getting estimated number of Guests.
                int nguest = Convert.ToInt32(Console.ReadLine());
                obj1.setNumOfguest(nguest);

                Console.WriteLine("\n");
                Console.WriteLine("Choose one of the following packages: ");
                Console.WriteLine("Press 1 for Premium (500 per person)");
                Console.WriteLine("Press 2 for Regular (400 per person)");
                Console.WriteLine("Press 3 for Budget (300 per person)");
                Console.WriteLine("Enter your choice: ");
                int pack = Convert.ToInt32(Console.ReadLine()); //Getting the pacakge selection as input.
                obj1.setPackage(pack);


                Console.WriteLine("\n");
                Console.WriteLine("enter your venue: "); //Getting the venue;
                string ven = Console.ReadLine();
                obj1.setVenue(ven);


                Console.WriteLine("\n");
                Console.WriteLine("Choose one of the following decoration themes:");
                Console.WriteLine("Royal Theme");
                Console.WriteLine("Floral Decoration");
                Console.WriteLine("Balloon Decoration");
                Console.WriteLine("Custom (Please contact us for further discussion)");
                Console.WriteLine("Enter your choice: ");
                string deco = Console.ReadLine();  // Getting Decoration selection
                obj1.setDecoration(deco);


                int expenditure = obj1.getExpense(); //Calculating total expense of the event.

                // Displaying all the details regarding the event
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.WriteLine("*************************************************************************************************");
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.WriteLine("Here's the details of the event you are planning for:\n");
                Console.WriteLine("Party Name:"+ obj1.eventName); //Inhereting attribute names from parent class
                Console.WriteLine("Party Type: "+ obj1.eventType);
                Console.WriteLine("Expected number of guests: "+ obj1.numOfguest);
                Console.WriteLine("Package Selected : "+ obj1.package);
                Console.WriteLine("Selected Venue: "+obj1.venue);
                Console.WriteLine("Selected decoration Theme: "+ obj1.decoration);
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.WriteLine("Your Total Expensde is: "+obj1.expense);
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.WriteLine("*************************************************************************************************");
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
            }
            
            else
            {
                Console.WriteLine("Enter Correct Selection fro given list");
                goto label;
            }




        }
    }
}
