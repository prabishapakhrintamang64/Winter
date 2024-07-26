using System;
namespace Application
{
    class Vehicles1
    {
        public string make="italian luxury sports car";
        public string model="812 Superfast";
        public int year=2017;
        public void showProperties1()
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
    class Car1:Vehicles1
    {
        public int numberofdoors=4;
        public bool isconvertible=true;
        public new void showProperties1()
        {
             base.showProperties1();
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
        public Car1(string model,string make,int year,int numberofdoors,bool isconvertible)
        {
          this.model=model;
          this.make=make;
          this.year=year;
          this.isconvertible=isconvertible;
          this.numberofdoors=numberofdoors;
        }
    }
}