using System;
namespace Application 
{
    public class Problem9
    {
        public static void solution()
        {
            int i,j,k;
            for( i=1; i<=5; i++)
            {
                for( j=5; j>=i; j--)
                {
                Console.Write("   ");
                }
                for( k=1; k<=i; k++)
              {
                Console.Write(" $ ");

               }
                Console.Write("\n");
            }

        }
    }
}