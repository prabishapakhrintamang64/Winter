using System;
using Application;
using consoleApp;
namespace Application
{
    class One
    {
        public void Count()
        {
            Console.WriteLine("one apple a day keeps doctor away");

        }

    }
}
namespace consoleApp
{
    class Two
    {
        public void count()
        {
            Console.WriteLine("two is two");
        }
    }

}
class Problem100
{
    public static void solution()
    {
        One obj= new One();
        obj.Count();
        Two ojj = new Two();
        ojj.count();
    }
}