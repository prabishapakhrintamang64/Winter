using System;
namespace Application
{
    class Problem67
    {
        public int birth( int a, int b)
        {
            int age = b-a;
            return age; 
        }
        public static void solution()
        {
         Problem67 obj = new Problem67();
         int ans = obj.birth(2007,2024);
         Console.WriteLine(ans);
        Console.ReadLine();

        }
    }
}