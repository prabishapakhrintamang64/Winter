using System;
namespace Application
{
    class Problem49
    {
        public static void solution()
        {
            int[] inputarray= { 1, 2, 3, 4, 5};
            string a= "+";
            string finalresult= " int:";
            finalresult += string.Join(a, inputarray);
            Console.WriteLine($"result:{finalresult}");
        }
    }
}