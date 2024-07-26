using System;
namespace Application
{
   class Problem74
   {
    public double celsius(double F)
    {
        double C= (F-32) /1.8;
        return C;

    }
    public static void solution()
    {
        Problem74 obj = new Problem74();
      
        double ans = obj.celsius(100);
        Console.WriteLine(ans);
        Console.ReadLine();
    }

   } 
}