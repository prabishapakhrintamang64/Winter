using System;
namespace Application
{
    class Problem70
    {
        public int Program( int[]arr )
        {
       int smallest=arr[0];
        //int arr.length=length(arr)
        int  Length= arr.Length;
        {

           for( int i=1; i < arr.Length; i++)
            {
                if( arr[i] < smallest)
                {
                    smallest=arr[i];
                }
            }
             return smallest;
        }
        }
         public static void solution()
        {
          Problem70 obj = new Problem70();
          // int []arr =[22, 12, 14, 30];
            int ans = obj.Program([22, 12, 14, 30]);
            Console.WriteLine(ans);
        }
    }
}


