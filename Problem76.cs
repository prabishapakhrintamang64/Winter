using System;
namespace Application
{
    class Problem76
    {
        public bool calculate(int i)
        {
         if(i%4==0)
         {
            return true;
         }
         else
         {
            return false;
         }
        }
    
    public static void solution()
    {
        Problem76 obj= new Problem76();
        bool ans= obj.calculate(2007);
        Console.WriteLine(ans);
        Console.ReadLine();
    }
    }
}