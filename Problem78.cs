using System;
namespace Application
{
    class Problem78
    {
        public double calculate(double m, double v)
        {
        double KE=1/2* m*Math.Pow(v,2);
        return KE ;
        }
    
    public static void solution()
    {
        Problem78 obj= new Problem78();
        double ans= obj.calculate(100,50);
        Console.WriteLine(ans);
        Console.ReadLine();
    }










    
    }
}