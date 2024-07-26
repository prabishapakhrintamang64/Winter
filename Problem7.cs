using System;
namespace Application
{
    public  class Problem7
    {
        public static void solution()
        {
           int i,j;
           for(i=0; i<=7; i++)
           {
            for(j=1; j<=i; j++)
            {
                Console.Write(" $ ");
            }
            Console.WriteLine();
           }
            
        }
    }
}