using System;
namespace Application
{
    class Problem69
    {
        public bool number(int a)
        {

           if(a%2==0)
           {
            return true;
           }
           else{
            return false;
            }
        }
               public static void solution()
        {
          Problem69 obj = new Problem69();
            bool ans = obj.number(15);
            Console.WriteLine(ans);
            Console.ReadLine();
        }
    }
}

