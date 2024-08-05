using System;

namespace Application
{
    public class Problem113
    {
        public static void solution()
        {
            Car myCar = new Car();
            myCar.make = 2024;
            myCar.model = "Tesla Model S";
            myCar.NumbersOfDoors = 4;

            myCar.showProperties(); 

            myCar.StartEngine(); 
        }
        
        class Vehicles
        {
            public int make = 2007;
            public string model = "Aquarius";

            public void showProperties()
            {
                Console.WriteLine($"Make: {make}, Model: {model}");
            }

            public virtual void StartEngine()
            {
                Console.WriteLine("Engine Started");
            }
        }

        class Car : Vehicles
        {
            public int NumbersOfDoors = 4;

            public new void showProperties()
            {
                base.showProperties();
                Console.WriteLine($"NumbersOfDoors: {NumbersOfDoors}");
            }

            public override void StartEngine()
            {
                Console.WriteLine("Car engine started");
            }
        }
    }
}
