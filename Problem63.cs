using System;
using System.Diagnostics.CodeAnalysis;
namespace Application
{
    class Problem63
    {
        public static void solution()
        {
            Console.WriteLine("Enter the value of a");
             int a= Int32.Parse (Console.ReadLine());

               Console.WriteLine("Enter the value of b");
               int b= Int32.Parse (Console.ReadLine());
               
             string A= string.Format(" the value of a is {0} and b is {1}.",a,b);
             Console.WriteLine(A);
              int Sum= a + b;
              Console.WriteLine(Sum);
        }
    }
}