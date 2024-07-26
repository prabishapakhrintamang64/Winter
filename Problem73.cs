using System;
namespace Application
{
   class Problem73
   {
    public double calculate ( double G,double m1, double m2, double r)
    {
      
       double F= G*(m1*m2)/Math.Pow(r,2);
        return F;

    }
    public static void solution()
    {
        Problem73 obj = new Problem73();
      
        double ans = obj.calculate(6.67*Math.Pow(10,-11), 20, 10, 12);
        Console.WriteLine(ans);
        Console.ReadLine();
    }

   } 
}