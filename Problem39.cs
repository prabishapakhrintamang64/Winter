using System;
namespace Application
{
    class Problem39
    {
         public static void solution()
         {
            int[] arr1 = { 21, 22, 23,24, 25};
            int i;
            int[]arr2 = new int[4];
            
            //int arr . length= length (arr)
            int length = arr1.Length;

            for( i= arr1.Length - 1; i>=0; i--)
            {
             Console.WriteLine($"Value of i: {i}");
             // Console.WriteLine(i);
             int newIndex = arr1.Length -i;
             Console.WriteLine($"New index: {newIndex}");
             // Console.WriteLine(arr1.Length-i);
             arr2[newIndex] = arr1[i];
            }
            for(i=0; i< arr2.Length; i++)
            {
             Console.WriteLine(arr2[i]);
             }
         }
  }
}

