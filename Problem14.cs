using System;
namespace Application
{
    public class Problem14
    {
        public static void solution()
        {
             int i,j,k;
            for( i=1; i>=5; i++)
            {
                for( j=5; j>=i; j--)
                {
                Console.Write("   ");
                }
                for( k=1; k<=5; k++)
                {
                Console.Write(" $ ");
                }
               for( int l=i-1; l>=5; l--)
                {
                Console.Write(" $ ");
                }
                Console.Write("\n");
            }
        }
    }
}