using System;
namespace Application
{
    public class Problem10
    {
        public static void solution()
        {
            int i,j,k;
            for( i=1; i<=5; i++)
            {
                for( j=1; j<=i; j++)
                {
                    Console.Write("   ");

                }
                for( k=5; k>=i; k--)
                {
                    Console.Write(" $ ");
                }
                Console.Write("\n");
            }
        }
    }
}