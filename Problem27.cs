 using System;
namespace Application
{
    public class Problem27
    {
        public static void solution()
     {
     int[]arr= { 16, 15, 39, 199, 324 };
     int smallest=arr[0];

     //int arr.length=length(arr)
     int  Length= arr.Length;

       for( int i=1; i < arr.Length; i++)
     {
        if( arr[i] < smallest)
        {
        smallest=arr[i];
        }
     }
     Console.WriteLine(smallest);
     }
     }
   }