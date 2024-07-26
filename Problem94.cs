using System;
namespace Application
{
    class Problem94
    {
        public static void solution()
        {
            Contractemployee w=new Contractemployee(100);
            double ans=w.CalculateSalary(3);
            Console.Write("contract employee salary:");
            Console.WriteLine(ans);


        }
       public abstract class Employee
        {
            public abstract double CalculateSalary(float numberofhours);

        }
        class Contractemployee:Employee
        {
            double hoursalary;
            public Contractemployee( double a)
            {
                this.hoursalary=a;
            }
            public override double CalculateSalary( float numberofhours)
            {
                double abc=numberofhours*hoursalary;
                return abc;

            }
        }
    }
}