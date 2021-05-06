using System;

namespace EventManagementApplication
{
    class Event //PARENT CLASS
    {
        private string eventName; // specifies the name of event i.e. birthday party etc.
        private string eventType; // Specifies whether an event is a day or evening event.

        private int numOfguest; // Specifies the expected number of attendees.

        private int package; //Specifies the package selected by the user such as regular or premium etc.


        private string venue; // specifies the venue of the event.

        private int decoration; //specifies the kind decoration.

        public int expense; // specifies the expense to be incurred for the party.


        // Setting up the name of the event.
        public string EventName
        {
            get { return eventName;}

            set { eventName = value;}
        }

        // Setting up the name of the event.
        public string EventType
        {
           get { return eventType;}

            set { eventType = value;}
        }

        // Setting up the expected number of attendees.
        public int NumOfguest
        {
           get { return numOfguest;}

            set { numOfguest = value;}
        }

        // setting up the name of the package selected.

        public int Package
        {
            get{ return package;}

            set{ package = value;}
        }
        
        // Setting up name of the venue.
        public string Venue
        {
            get { return venue;}

            set{ venue = value;}
        }

        // Setting up the name of the decoration
        public int Decoration
        {
            get{ return decoration;}
            set{ decoration = value;}
        } 


        // Method to confirm successful registration of the event.

        public void success(string s)
        {
            if(s == "y" || s=="Y")
            {   
                Console.WriteLine("\n");
                Console.WriteLine("Congratulations!!!! Regsitration successful");
            }

            else
            {
                Console.WriteLine("\n");
                Console.WriteLine("Event not successfully registered.!");
            }
            
        }
        
    }
}


// BIRTHDAY EVENT CHILD CLASS

namespace EventManagementApplication
{

    class Birthday : Event
    {

        
        // Method to set event name.
        public string setEventName()
        {
            EventName = "Birthday Event";
            return EventName;
        }
        
        // Method to set event type.
        public string setEventType()
        {
            eventSelection:
                Console.WriteLine("\n");
                Console.WriteLine("Enter event type: ");
                Console.WriteLine("Enter 1 for Day Event: ");
                Console.WriteLine("Enter 2 for evening event: ");
                Console.WriteLine("Enter 3 for Night Event: ");
                Console.WriteLine("Enter the choice: ");
                int et = Convert.ToInt32(Console.ReadLine());
            
            if(et == 1)
            {
                EventType = "Day Event";
                return EventType;
            }
                
            
            else if(et == 2)
            {
                EventType = "Evening Event";
                return EventType;
            }

            else if(et == 3)
            {
                EventType = "Night Event";
                return EventType;
            }

            else
            {   
                Console.WriteLine("\n");
                Console.WriteLine("Please enter choice from available option.");
                goto eventSelection; // Prompt user to make a valid choice again.
            }



        }


        // Method to set number of guest
        public int setNumOfguest()
        {
           Console.WriteLine("\n");
           Console.WriteLine("Enter the number of expected guests: ");
           NumOfguest = Convert.ToInt32(Console.ReadLine());
           return NumOfguest;
        }


        // Method to set package for the event
        public string setPackage()
        {
            packageSelection: 
                Console.WriteLine("\n");
                Console.WriteLine("Choose one of the following packages: ");
                Console.WriteLine("Press 1 for Premium (500 per person)");
                Console.WriteLine("Press 2 for Regular (400 per person)");
                Console.WriteLine("Press 3 for Budget (300 per person)");
                Console.WriteLine("Enter your choice: ");
                Package = Convert.ToInt32(Console.ReadLine()); //Getting the pacakge selection as input.

            string packName;
            if(Package == 1)
            {
                packName = "Premium";
                return packName;

            }

            else if(Package == 2)
            {
                packName = "Regular";
                return packName;
            }

            else if(Package == 3)
            {
                packName = "Budget";
                return packName;
            }
            else
            {   
                Console.WriteLine("\n");
                System.Console.WriteLine("Select from available options of packages.");
                goto packageSelection;
            }
        }


        // Method to calculate estimated expenditure of the event.
        public int calculateExpense()
        {
            if(Package == 1) // Premium Package
            {
                expense = 500*NumOfguest + 50000;
                return expense;
            }

            else if(Package == 2) // Regular Package
            {
                expense = 400*NumOfguest +40000;
                return expense;
            }

            else if(Package == 3)  // Budget Package
            {
                expense = 300*NumOfguest + 30000;
                return expense;
            }
            
            else
            {
                expense = 0; //Default is 0 for wrong pacakge selected.
                return expense;
            }
        }


        // Method to set event venue.
        public string setVenue()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Enter the venue for event: ");
            Venue = System.Console.ReadLine();
            return Venue;
        }


        // Method to set decoration
        public string setDecoration()
        {
            decorationSelection:
                Console.WriteLine("\n");
                Console.WriteLine("Choose one of the following decoration themes:");
                Console.WriteLine("Enter 1 for Royal Theme");
                Console.WriteLine("Enter 2 for Floral Decoration");
                Console.WriteLine("Enter 3 for Balloon Decoration");
                Console.WriteLine("Enter 4 for Custom (Please contact us for further discussion)");
                Console.WriteLine("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

            string deco;

            if(choice == 1)
            {
                deco = "Royal Theme";
                return deco;
            }

            else if(choice == 2)
            {
                deco = "Floral Theme";
                return deco;
            }

            else if(choice == 3)
            {
                deco = "Balloon Decoration";
                return deco;
            }

            else if(choice == 4)
            {
                deco = "Custom Decoration";
                return deco;
            }

            else
            {   
                Console.WriteLine("\n");
                Console.WriteLine("Choose any one from the available decoration options.");
                goto decorationSelection;
            }
                
                
        }


        // Generating Successful registration method.
        public void success(string s,bool t) // success() of child class.
        {   
            if((s == "y" || s== "Y")&& t==true)
            {
                Console.WriteLine("\n"); 
                Console.WriteLine("Congratulations!!!! Registration for birthday event is successful.");
            }
            
           
        }

    }
}



// WEDDING EVENT CHILD CLASS
namespace EventManagementApplication
{

    class Wedding : Event
    {
        // Method to set event name.
        public string setEventName()
        {
            EventName = "Wedding Event";
            return EventName;
        }
        
        // Method to set event type.
        public string setEventType()
        {
            eventSelection:
                Console.WriteLine("\n");
                Console.WriteLine("Enter event type: ");
                Console.WriteLine("Enter 1 for Day Event: ");
                Console.WriteLine("Enter 2 for evening event: ");
                Console.WriteLine("Enter 3 for Night Event: ");
                Console.WriteLine("Enter the choice: ");
                int et = Convert.ToInt32(Console.ReadLine());
            
            if(et == 1)
            {
                EventType = "Day Event";
                return EventType;
            }
                
            
            else if(et == 2)
            {
                EventType = "Evening Event";
                return EventType;
            }

            else if(et == 3)
            {
                EventType = "Night Event";
                return EventType;
            }

            else
            {
                Console.WriteLine("\n");
                Console.WriteLine("Please enter choice from available option.");
                goto eventSelection; // Prompt user to make a valid choice again.
            }



        }


        // Method to set number of guest
        public int setNumOfguest()
        {
           Console.WriteLine("\n"); 
           Console.WriteLine("Enter the number of expected guests: ");
           NumOfguest = Convert.ToInt32(Console.ReadLine());
           return NumOfguest;
        }


        // Method to set package for the event
        public string setPackage()
        {
            packageSelection: 
                Console.WriteLine("\n");
                Console.WriteLine("Choose one of the following packages: ");
                Console.WriteLine("Press 1 for Premium (500 per person)");
                Console.WriteLine("Press 2 for Regular (400 per person)");
                Console.WriteLine("Press 3 for Budget (300 per person)");
                Console.WriteLine("Enter your choice: ");
                Package = Convert.ToInt32(Console.ReadLine()); //Getting the pacakge selection as input.

            string packName;
            if(Package == 1)
            {
                packName = "Premium";
                return packName;

            }

            else if(Package == 2)
            {
                packName = "Regular";
                return packName;
            }

            else if(Package == 3)
            {
                packName = "Budget";
                return packName;
            }
            else
            {
                Console.WriteLine("\n");
                Console.WriteLine("Select from available options of packages.");
                goto packageSelection;
            }
        }


        // Method to calculate estimated expenditure of the event.
        public int calculateExpense()
        {
            if(Package == 1) // Premium Package
            {
                expense = 500*NumOfguest + 50000;
                return expense;
            }

            else if(Package == 2) // Regular Package
            {
                expense = 400*NumOfguest +40000;
                return expense;
            }

            else if(Package == 3)  // Budget Package
            {
                expense = 300*NumOfguest + 30000;
                return expense;
            }
            
            else
            {
                expense = 0; //Default is 0 for wrong pacakge selected.
                return expense;
            }
        }


        // Method to set event venue.
        public string setVenue()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Enter the venue for event: ");
            Venue = Console.ReadLine();
            return Venue;
        }


        // Method to set decoration
        public string setDecoration()
        {
            decorationSelection:
                Console.WriteLine("\n");
                Console.WriteLine("Choose one of the following decoration themes:");
                Console.WriteLine("Enter 1 for Royal Theme");
                Console.WriteLine("Enter 2 for Floral Decoration");
                Console.WriteLine("Enter 3 for Balloon Decoration");
                Console.WriteLine("Enter 4 for Custom (Please contact us for further discussion)");
                Console.WriteLine("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

            string deco;

            if(choice == 1)
            {
                deco = "Royal Theme";
                return deco;
            }

            else if(choice == 2)
            {
                deco = "Floral Theme";
                return deco;
            }

            else if(choice == 3)
            {
                deco = "Balloon Decoration";
                return deco;
            }

            else if(choice == 4)
            {
                deco = "Custom Decoration";
                return deco;
            }

            else
            {
                Console.WriteLine("\n");
                Console.WriteLine("Choose any one from the available decoration options.");
                goto decorationSelection;
            }
                
                
        }


        // Generating Successful registration method.
        public void success(string s,bool t) // success() of child class.
        {   
            if((s == "y" || s== "Y")&& t==true)
            {
                Console.WriteLine("\n"); 
                Console.WriteLine("Congratulations!!!! Registration for Wedding event is successful.");
            }
            
           
        }
    }
}



// RECEPTION EVENT CHILD CLASS
namespace EventManagementApplication
{

    class Reception : Event
    {
        // Method to set event name.
        public string setEventName()
        {
            EventName = "Reception Event";
            return EventName;
        }
        
        // Method to set event type.
        public string setEventType()
        {
            eventSelection:
                Console.WriteLine("\n");
                Console.WriteLine("Enter event type: ");
                Console.WriteLine("Enter 1 for Day Event: ");
                Console.WriteLine("Enter 2 for evening event: ");
                Console.WriteLine("Enter 3 for Night Event: ");
                Console.WriteLine("Enter the choice: ");
                int et = Convert.ToInt32(Console.ReadLine());
            
            if(et == 1)
            {
                EventType = "Day Event";
                return EventType;
            }
                
            
            else if(et == 2)
            {
                EventType = "Evening Event";
                return EventType;
            }

            else if(et == 3)
            {
                EventType = "Night Event";
                return EventType;
            }

            else
            {
                Console.WriteLine("Please enter choice from available option.");
                goto eventSelection; // Prompt user to make a valid choice again.
            }



        }


        // Method to set number of guest
        public int setNumOfguest()
        {
           Console.WriteLine("\n");
           Console.WriteLine("Enter the number of expected guests: ");
           NumOfguest = Convert.ToInt32(Console.ReadLine());
           return NumOfguest;
        }


        // Method to set package for the event
        public string setPackage()
        {
            packageSelection: 
                Console.WriteLine("\n");
                Console.WriteLine("Choose one of the following packages: ");
                Console.WriteLine("Press 1 for Premium (500 per person)");
                Console.WriteLine("Press 2 for Regular (400 per person)");
                Console.WriteLine("Press 3 for Budget (300 per person)");
                Console.WriteLine("Enter your choice: ");
                Package = Convert.ToInt32(Console.ReadLine()); //Getting the pacakge selection as input.

            string packName;
            if(Package == 1)
            {
                packName = "Premium";
                return packName;

            }

            else if(Package == 2)
            {
                packName = "Regular";
                return packName;
            }

            else if(Package == 3)
            {
                packName = "Budget";
                return packName;
            }
            else
            {
                Console.WriteLine("\n");
                Console.WriteLine("Select from available options of packages.");
                goto packageSelection;
            }
        }


        // Method to calculate estimated expenditure of the event.
        public int calculateExpense()
        {
            if(Package == 1) // Premium Package
            {
                expense = 500*NumOfguest + 50000;
                return expense;
            }

            else if(Package == 2) // Regular Package
            {
                expense = 400*NumOfguest +40000;
                return expense;
            }

            else if(Package == 3)  // Budget Package
            {
                expense = 300*NumOfguest + 30000;
                return expense;
            }
            
            else
            {
                Console.WriteLine("\n");
                expense = 0; //Default is 0 for wrong pacakge selected.
                return expense;
            }
        }


        // Method to set event venue.
        public string setVenue()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Enter the venue for event: ");
            Venue = Console.ReadLine();
            return Venue;
        }


        // Method to set decoration
        public string setDecoration()
        {
            decorationSelection:
                Console.WriteLine("\n");
                Console.WriteLine("Choose one of the following decoration themes:");
                Console.WriteLine("Enter 1 for Royal Theme");
                Console.WriteLine("Enter 2 for Floral Decoration");
                Console.WriteLine("Enter 3 for Balloon Decoration");
                Console.WriteLine("Enter 4 for Custom (Please contact us for further discussion)");
                Console.WriteLine("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

            string deco;

            if(choice == 1)
            {
                deco = "Royal Theme";
                return deco;
            }

            else if(choice == 2)
            {
                deco = "Floral Theme";
                return deco;
            }

            else if(choice == 3)
            {
                deco = "Balloon Decoration";
                return deco;
            }

            else if(choice == 4)
            {
                deco = "Custom Decoration";
                return deco;
            }

            else
            {
                Console.WriteLine("\n");
                Console.WriteLine("Choose any one from the available decoration options.");
                goto decorationSelection;
            }
                
                
        }


        // Generating Successful registration method.
        public void success(string s,bool t) // success() of child class.
        {   
            if((s == "y" || s== "Y")&& t==true)
            {
                Console.WriteLine("\n"); 
                Console.WriteLine("Congratulations!!!! Registration for Reception event is successful.");
            }
            
           
        }


    }
}


// ENGAGEMENT EVENT CHILD CLASS
namespace EventManagementApplication
{

    class Engagement : Event
    {
        // Method to set event name.
        public string setEventName()
        {
            EventName = "Engagement Event";
            return EventName;
        }
        
        // Method to set event type.
        public string setEventType()
        {
            eventSelection:
                Console.WriteLine("\n");
                Console.WriteLine("Enter event type: ");
                Console.WriteLine("Enter 1 for Day Event: ");
                Console.WriteLine("Enter 2 for evening event: ");
                Console.WriteLine("Enter 3 for Night Event: ");
                Console.WriteLine("Enter the choice: ");
                int et = Convert.ToInt32(Console.ReadLine());
            
            if(et == 1)
            {
                EventType = "Day Event";
                return EventType;
            }
                
            
            else if(et == 2)
            {
                EventType = "Evening Event";
                return EventType;
            }

            else if(et == 3)
            {
                EventType = "Night Event";
                return EventType;
            }

            else
            {
                Console.WriteLine("\n");
                Console.WriteLine("Please enter choice from available option.");
                goto eventSelection; // Prompt user to make a valid choice again.
            }



        }


        // Method to set number of guest
        public int setNumOfguest()
        {
           Console.WriteLine("\n");
           Console.WriteLine("Enter the number of expected guests: ");
           NumOfguest = Convert.ToInt32(Console.ReadLine());
           return NumOfguest;
        }


        // Method to set package for the event
        public string setPackage()
        {
            packageSelection: 
                Console.WriteLine("\n");
                Console.WriteLine("Choose one of the following packages: ");
                Console.WriteLine("Press 1 for Premium (500 per person)");
                Console.WriteLine("Press 2 for Regular (400 per person)");
                Console.WriteLine("Press 3 for Budget (300 per person)");
                Console.WriteLine("Enter your choice: ");
                Package = Convert.ToInt32(Console.ReadLine()); //Getting the pacakge selection as input.

            string packName;
            if(Package == 1)
            {
                packName = "Premium";
                return packName;

            }

            else if(Package == 2)
            {
                packName = "Regular";
                return packName;
            }

            else if(Package == 3)
            {
                packName = "Budget";
                return packName;
            }
            else
            {
                Console.WriteLine("\n");
                Console.WriteLine("Select from available options of packages.");
                goto packageSelection;
            }
        }


        // Method to calculate estimated expenditure of the event.
        public int calculateExpense()
        {
            if(Package == 1) // Premium Package
            {
                expense = 500*NumOfguest + 50000;
                return expense;
            }

            else if(Package == 2) // Regular Package
            {
                expense = 400*NumOfguest +40000;
                return expense;
            }

            else if(Package == 3)  // Budget Package
            {
                expense = 300*NumOfguest + 30000;
                return expense;
            }
            
            else
            {
                expense = 0; //Default is 0 for wrong pacakge selected.
                return expense;
            }
        }


        // Method to set event venue.
        public string setVenue()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Enter the venue for event: ");
            Venue = Console.ReadLine();
            return Venue;
        }


        // Method to set decoration
        public string setDecoration()
        {
            decorationSelection:
                Console.WriteLine("\n");
                Console.WriteLine("Choose one of the following decoration themes:");
                Console.WriteLine("Enter 1 for Royal Theme");
                Console.WriteLine("Enter 2 for Floral Decoration");
                Console.WriteLine("Enter 3 for Balloon Decoration");
                Console.WriteLine("Enter 4 for Custom (Please contact us for further discussion)");
                Console.WriteLine("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

            string deco;

            if(choice == 1)
            {
                deco = "Royal Theme";
                return deco;
            }

            else if(choice == 2)
            {
                deco = "Floral Theme";
                return deco;
            }

            else if(choice == 3)
            {
                deco = "Balloon Decoration";
                return deco;
            }

            else if(choice == 4)
            {
                deco = "Custom Decoration";
                return deco;
            }

            else
            {
                Console.WriteLine("\n");
                Console.WriteLine("Choose any one from the available decoration options.");
                goto decorationSelection;
            }
                
                
        }


        // Generating Successful registration method.
        public void success(string s,bool t) // success() of child class.
        {   
            if((s == "y" || s== "Y")&& t==true)
            {
                Console.WriteLine("\n"); 
                Console.WriteLine("Congratulations!!!! Registration for Engagement event is successful.");
            }

            else
            {
                Console.WriteLine("\n");
                Console.WriteLine("Oops! Registraion Unsuccessful.");
            }
            
           
        }

    }
}



//MAIN CLASS
namespace EventManagementApplication
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine("*************************************************************************************************");
            
            Console.WriteLine("---------------------------JIGYASA EVENT MANAGEMENT SERVICES PVT. LTD.--------------------------------");
            Console.WriteLine("---------------------We are here to take your hassle of managing an event-------------------------");

            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            


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

                // Calling the inherited methods
                string nameOfEvent = obj1.setEventName();
                string typeOfEvent = obj1.setEventType();
                double numberOfGuest = obj1.setNumOfguest();
                string pacakgeSelected = obj1.setPackage();
                string venueSelected = obj1.setVenue();
                string selectedDecoration = obj1.setDecoration();
                double expenditure = obj1.calculateExpense();
                
                // Displaying all the details regarding the event
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.WriteLine("*************************************************************************************************");
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.WriteLine("Here's the details of the event you are planning for:\n");
                Console.WriteLine("*************************************************************************************************");
                Console.WriteLine("Party Name || "+ nameOfEvent); 
                Console.WriteLine("Party Type || "+ typeOfEvent);
                Console.WriteLine("Expected number of guest || "+ numberOfGuest);
                Console.WriteLine("Your selected package is || "+pacakgeSelected);
                Console.WriteLine("Your selecetd venue is || "+ venueSelected);
                Console.WriteLine("Your selected decoration is || "+ selectedDecoration);
                Console.WriteLine("*************************************************************************************************");
                Console.WriteLine("Total expected expenditure for your event is Rs. " + expenditure);
                Console.WriteLine("*************************************************************************************************");
                Console.WriteLine("\n");
                Console.WriteLine("Do you want to move further with your registeration? Enter y/Y to continue or any other key to quit.");
                string confirm = Console.ReadLine();
                obj1.success(confirm);  //success() of parent class (Event class)
                obj1.success(confirm, true); //success() of child class
            }

            else if(selection == 2)  //WEDDING IS THE EVENT
            {
                Wedding obj1 = new Wedding();

                // Calling the inherited methods
                string nameOfEvent = obj1.setEventName();
                string typeOfEvent = obj1.setEventType();
                double numberOfGuest = obj1.setNumOfguest();
                string pacakgeSelected = obj1.setPackage();
                string venueSelected = obj1.setVenue();
                string selectedDecoration = obj1.setDecoration();
                double expenditure = obj1.calculateExpense();
                
                // Displaying all the details regarding the event
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.WriteLine("*************************************************************************************************");
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.WriteLine("Here's the details of the event you are planning for:\n");
                Console.WriteLine("Party Name: "+ nameOfEvent); 
                Console.WriteLine("Party Type: "+ typeOfEvent);
                Console.WriteLine("Expected number of guest: "+ numberOfGuest);
                Console.WriteLine("Your selected package is: "+pacakgeSelected);
                Console.WriteLine("Your selecetd venue is: "+ venueSelected);
                Console.WriteLine("Your selected decoration is: "+ selectedDecoration);
                Console.WriteLine("*************************************************************************************************");
                Console.WriteLine("Total expected expenditure for your event is: Rs. " + expenditure);
                Console.WriteLine("*************************************************************************************************");

                Console.WriteLine("Do you want to move further with your registeration? Enter y/Y to continue: ");
                string confirm = Console.ReadLine();
                obj1.success(confirm);
                obj1.success(confirm, true);
            }

            else if(selection == 3)  //RECEPTION IS THE EVENT
            {
                Reception obj1 = new Reception();
                
                // Calling the inherited methods
                string nameOfEvent = obj1.setEventName();
                string typeOfEvent = obj1.setEventType();
                double numberOfGuest = obj1.setNumOfguest();
                string pacakgeSelected = obj1.setPackage();
                string venueSelected = obj1.setVenue();
                string selectedDecoration = obj1.setDecoration();
                double expenditure = obj1.calculateExpense();
                
                // Displaying all the details regarding the event
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.WriteLine("*************************************************************************************************");
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.WriteLine("Here's the details of the event you are planning for:\n");
                Console.WriteLine("Party Name: "+ nameOfEvent); 
                Console.WriteLine("Party Type: "+ typeOfEvent);
                Console.WriteLine("Expected number of guest: "+ numberOfGuest);
                Console.WriteLine("Your selected package is: "+pacakgeSelected);
                Console.WriteLine("Your selecetd venue is: "+ venueSelected);
                Console.WriteLine("Your selected decoration is: "+ selectedDecoration);
                Console.WriteLine("*************************************************************************************************");
                Console.WriteLine("Total expected expenditure for your event is: Rs. " + expenditure);
                Console.WriteLine("*************************************************************************************************");

                Console.WriteLine("Do you want to move further with your registeration? Enter y/Y to continue: ");
                string confirm = Console.ReadLine();
                obj1.success(confirm);
                obj1.success(confirm, true);
            }

            else if(selection == 4) // ENGAGEMENT IS THE EVENT
            {
                Engagement obj1 = new Engagement();

                // Calling the inherited methods
                string nameOfEvent = obj1.setEventName();
                string typeOfEvent = obj1.setEventType();
                double numberOfGuest = obj1.setNumOfguest();
                string pacakgeSelected = obj1.setPackage();
                string venueSelected = obj1.setVenue();
                string selectedDecoration = obj1.setDecoration();
                double expenditure = obj1.calculateExpense();
                
                // Displaying all the details regarding the event
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.WriteLine("*************************************************************************************************");
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.WriteLine("Here's the details of the event you are planning for:\n");
                Console.WriteLine("Party Name: "+ nameOfEvent); 
                Console.WriteLine("Party Type: "+ typeOfEvent);
                Console.WriteLine("Expected number of guest: "+ numberOfGuest);
                Console.WriteLine("Your selected package is: "+pacakgeSelected);
                Console.WriteLine("Your selecetd venue is: "+ venueSelected);
                Console.WriteLine("Your selected decoration is: "+ selectedDecoration);
                Console.WriteLine("*************************************************************************************************");
                Console.WriteLine("Total expected expenditure for your event is: Rs. " + expenditure);
                Console.WriteLine("*************************************************************************************************");

                Console.WriteLine("Do you want to move further with your registeration? Enter y/Y or n/N");
                string confirm = Console.ReadLine();
                obj1.success(confirm);
                obj1.success(confirm, true);
            }
            
            else
            {
                Console.WriteLine("Enter Correct Selection from given list");
                goto label;
            }




        }
    }
}
