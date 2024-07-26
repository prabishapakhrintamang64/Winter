using System;
namespace Application
{
    class Problem71
    {
        public int Program( int[]arr )
        {
       int greatest=arr[0];
        //int arr.length=length(arr)
        int  Length= arr.Length;
        {

           for( int i=1; i < arr.Length; i++)
            {
                if( arr[i] > greatest)
                {
                    greatest=arr[i];
                }
            }
             return  greatest;
        }
        }
         public static void solution()
        {
          Problem71 obj = new Problem71();
          // int []arr =[13, 12, 14, 30];
            int ans = obj.Program([13, 12, 14, 30]);
            Console.WriteLine(ans);
        }
    }
}


