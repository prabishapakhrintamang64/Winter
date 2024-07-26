using System;
namespace Application
{
    class Problem43
    {
        public static void solution()
        {
            // String.Concat method
            string String1= "Coding";
            string String2= " Ninjas";
            string finalString=string.Concat(String1,String2);
            Console.WriteLine(finalString);

            // Concatenate Concat
            string doubleConcat=string.Concat(string.Concat(String1,String2),"Company");
            Console.WriteLine(doubleConcat);
        }
    }
}