using System;

namespace program 
{
    public class Car  //BASE CLASS
    {
        public string engine="ENGINE-ABC";
        public string tyre = "TYRE-XYZ";
        public string soundSystem = "SOUNDSYSTEM_ABC";

    }
}

namespace program
{
    public interface IsetColor  //INTERFACE
    {
        public string setColor();  // method that will be implemented by each child class.
    }

}

namespace program
{
    public class redCar: Car, IsetColor  // CHILD CLASS REDCAR
    {
        
        
        public string setColor() // method gto define color of red car.
        {
            string color = "Red";
            
            return color;
        }
    }

    
}

namespace program
{
    public class greenCar: Car, IsetColor //CHILD CLASS GREENCAR
    {
        
        
        public string setColor()  // method to define green car.
        {
            string color = "Green";
            
            return color;
        }
    }

    
}

namespace program
{
    public class blueCar: Car, IsetColor  //CHILD CLASS BLUECAR
    {
        
        
        public string setColor()  // method to define blue car.
        {
            string color = "Blue";
            
            return color;
        }
    }

    
}

namespace  program
{
    class Program
    {
        static void Main(string[] args)
        {
            selection:
                Console.WriteLine("Enter the choice of car:");
                Console.WriteLine("Press 1 for red car");
                Console.WriteLine("Press 2 for green car");
                Console.WriteLine("Press 3 for blue car");
                Console.WriteLine("Enter your choice:");

                int choice = Convert.ToInt32(Console.ReadLine());

            if(choice == 1)
            {
                redCar obj = new redCar();

                string carColor = obj.setColor();
                Console.WriteLine("Engine: "+obj.engine);
                Console.WriteLine("Tyre: "+obj.tyre);
                Console.WriteLine("Sound System : "+obj.soundSystem);
                Console.WriteLine("Color of car: "+ obj.setColor());
            }

            else if(choice == 2)
            {
                greenCar obj = new greenCar();

                string carColor = obj.setColor();
                Console.WriteLine("Engine: "+obj.engine);
                Console.WriteLine("Tyre: "+obj.tyre);
                Console.WriteLine("Sound System : "+obj.soundSystem);
                Console.WriteLine("Color of car: "+ obj.setColor());
            }

            else if(choice == 3)
            {
                blueCar obj = new blueCar();
                
                string carColor = obj.setColor();
                Console.WriteLine("Engine: "+obj.engine);
                Console.WriteLine("Tyre: "+obj.tyre);
                Console.WriteLine("Sound System : "+obj.soundSystem);
                Console.WriteLine("Color of car: "+ obj.setColor());
            }

            else
            {
                Console.WriteLine("Enter Valid choice: ");
                goto selection;
            }

        }
    }
}