using System;
namespace Application
{
    class Problem77
    {
        public double calculate(double m, double r)
        {
        double I= m*Math.Pow(r,2);
        return I;
        }
    
    public static void solution()
    {
        Problem77 obj= new Problem77();
        double ans= obj.calculate(100,50);
        Console.WriteLine(ans);
        Console.ReadLine();
    }
    }
}