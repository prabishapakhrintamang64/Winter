using System;
namespace Application
{
  public class Bottle
  {
       public String color ="transparent";
       public int mass =12;
       public int capacity=200;
       public int water=0;
       public Bottle()
       {
       }
   
        public void colors()
        {
        Console.WriteLine(color);
        }
        public Bottle(String c)
        {
         color = c;
        }
    } 
}