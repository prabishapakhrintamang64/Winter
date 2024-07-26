using System;
using System.Transactions;
namespace Application
{
    class Problem61
    {
        public static void solution()
        {
           
    
            Console.WriteLine("Enter the value of a");
             string a= Console.ReadLine();

             Console.WriteLine("enter the value of b");
              string b= Console.ReadLine();

              string A= String.Format("the value of a is {0} and the value of b is {1}.",a,b);
              Console.WriteLine(A);   
        }
    }
}