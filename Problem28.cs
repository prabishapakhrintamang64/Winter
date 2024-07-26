 using System;
namespace Application
{
    public class Problem28
    {
        public static void solution()
     {
     int[]arr= { 54, 12, 14, 17, 34, 98 };

     int greatest=arr[5];

     //int arr.length=length(arr)
     int  Length = arr.Length;
       for( int i=1; i < arr.Length; i++)
     {
        if( arr[i] > greatest)
        {
        greatest= arr[i];
        }
     }
      Console.WriteLine(greatest);
      }
   }
}