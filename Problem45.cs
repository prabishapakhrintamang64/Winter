using System;
namespace Application
{
    class Problem45
    {
        public static void solution()
        {
            // using String.Join (String, String[])
            int[] inputArray ={12, 13, 14, 15, 16};
            String sep =";";
            string finalresult ="Int:";
            finalresult += String.Join(sep, inputArray);
            Console.WriteLine($"Result: {finalresult}");

        }
    }
}