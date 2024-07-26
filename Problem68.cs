using System;
namespace Application
{
    class Problem68
    {
        public int birth(int b)
        {
            int age = 2024-b;
            return age; 
        }
        public static void solution()
        {
         Problem68 obj = new Problem68();
         int age= obj.birth(2007);
         Console.WriteLine(age);
        Console.ReadLine();

        }
    }
}