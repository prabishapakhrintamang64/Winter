 using System;
namespace Application
{
    public class Problem29
    {
        public static void solution()
     {
     int[] arr= { 94, 45, 36, 10, 56 };

     int greatest=arr[0];

     //int arr.length=length(arr)
        int  Length = arr.Length;

       for( int i=1; arr.Length < i; i--)
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