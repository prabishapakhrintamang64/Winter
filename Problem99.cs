using System;
using consoleApp;
using Application;


namespace consoleApp
{
 class Dog{
    public void bark()
    {
        Console.WriteLine("dog1");
    }
 }
}
namespace Application
{
    class Dog{
        public void bark()
    {
        Console.WriteLine("dog2");
    }
    }
}
class Problem99
{
    public static void solution ()
    {
       consoleApp.Dog obj = new consoleApp.Dog ();
       obj.bark();
    
    }
}

