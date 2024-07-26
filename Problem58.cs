using System;
namespace Application
{
    class Problem58
    {
        public static void solution()
        {
          int myAge = 25;
          int votingAge = 18;

          if (myAge >= votingAge) 
          {
           Console.WriteLine("Old enough to vote!");
          } 
          else 
         {
          Console.WriteLine("Not old enough to vote.");
        }
        }
    }
}