using System;
namespace Application
{
    class Problem93
    {
        public static void solution()
        {
            Permanentemployee obj=new Permanentemployee(100,100);
            double app=obj.calculatesalary(12);
            Console.Write("Prabisha pakhrin's fixed salary:");
            Console.WriteLine(app);
            
            

        }
            public abstract class Employee
            {
                public abstract double calculatesalary(int numberofmonths);


            }
            class Permanentemployee:Employee
            {
                double bonus;
                double monthlySalary;
                public Permanentemployee(double p, double r)
                {
                    this.bonus=p;
                    this.monthlySalary=r;              
                }
                public override double calculatesalary(int numberofmonths)
                {
                    if(numberofmonths<12)
                    {
                        double a=monthlySalary*numberofmonths;
                        return a;

                    }
                    else 
                    {
                        double b=monthlySalary*12+bonus;
                        return b;
                    }

                }
            }
     

    }
}