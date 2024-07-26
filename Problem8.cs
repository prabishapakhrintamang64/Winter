using System;
namespace Application
{
    public class Problem8
    {
        public static void solution()
    {
        int i,j;
        for( i=1; i<=5;i++)
        {
            for( j=5; j>=i; j--)
            {
                Console.Write(" $ ");

            }
            Console.Write("\n");
        }
    }
    }
}