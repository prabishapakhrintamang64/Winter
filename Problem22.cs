using System;
namespace Application
{
    public class Problem22
    {
        public static void solution()
     {
        int i, sum=0;
        for(i=1; i<=20; i++)
        {
            if(i%2==1)
            {
                sum = sum +i;

            }
            Console.WriteLine(sum);
        }
        }
        }
        }