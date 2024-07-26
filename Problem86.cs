using System;
namespace Application
{
    class Vehicles
    {
        public string make="italian luxury sports car";
        public string model="812 Superfast";
        public int year=2017;
        public void showProperties()
        {
          Console.WriteLine("make:{0}",make);
         Console.WriteLine("model:{0}",model);
         Console.WriteLine("year:{0}",year);

        }

         public void StartEngine()
         {
            Console.WriteLine("Engine Started");
         }
         public void StopEngine()
         {
            Console.WriteLine("Engine stopped");
         }

    }
    class Car:Vehicles
    {
       public int numberofdoors=4;
       public bool isconvertible=true;
        public new void showProperties()
        {
         base.showProperties();
          Console.WriteLine("numberofdoors:{0}",numberofdoors);
         Console.WriteLine("isconvertible:{0}", isconvertible);
        }
       public void Opentrunk()
       {
        Console.WriteLine("trunk opened");
       }
       public void closetrunk()
       {
        Console.WriteLine("trunk closed");
       }
      
      
    }


}