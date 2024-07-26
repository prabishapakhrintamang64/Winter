using System;
namespace Application
{
    class Problem88
    {
        
            class Vehicle 
            {
            
             

        
            }
            class Car:Vehicle
            {
                 public void show()
                 {
                    Console.WriteLine(" ferarri, lambo, rolls royce");
                 }
            }
            class Bicycle:Vehicle
            {
               public void show()
                 {
                    Console.WriteLine("mountain bike, 3T bike,folding bike");
                 }
            }
            class Boat:Vehicle
            {
               public void show()
                 {
                    Console.WriteLine("Aquaholic, blue moon, Seas day");
                 }
                 }
                   public static void solution()
                   {
                        Car car=new Car();
                        car.show();
                        Bicycle bicycle=new Bicycle();
                        bicycle.show();
                        Boat boat=new Boat();
                        boat.show();
                        Vehicle[] vehicles={car, bicycle, boat};
                    } 
            
    }
}