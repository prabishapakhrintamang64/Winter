using System;
namespace Application
{
    class Problem66
    {
        public int hehe( int i, int j)
        {
            int result = i+j;
             return result; 
        }
        public static void solution()
        {
            Problem66 obj = new Problem66();
            int ans = obj.hehe(30,64);
            Console.WriteLine(ans);
            Console.ReadLine();

        }
    }
}