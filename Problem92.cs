using System;
using System.Globalization;
namespace Application
{
    class Problem92
    {
        public static void solution()
        {
            Permanentemployee obj=new Permanentemployee(100,100);
             double q= obj.CalculateSalary(12);
             Console.Write("The fixedsalary of permenament Employee:");
            Console.WriteLine(q);
        }
        public abstract class Employee
        {
            public abstract double CalculateSalary(int numberofmonths);
        }
        class Permanentemployee : Employee
        {
             double monthlySalary;
             double bonus;
             public Permanentemployee( double q, double r)
            {
              this.monthlySalary=q;
              this.bonus=r;
            }
            public override double CalculateSalary(int numberofmonths)
            {
                 if(numberofmonths < 12)
                {
                    double a= (monthlySalary)*(numberofmonths);
                    return a;
                   
                }
                else
                {
                    double b=(monthlySalary) *(12)+(bonus);
                    return b;

                }
                }
               
              

            }
        }
    }
