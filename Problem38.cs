using System;
namespace Application
{
    class Problem38
    {
         public static void solution()
         {
            int[] arr1 = { 21, 22, 23,24, 25};
            int i;
            int[] arr2= new int[4];
            
            //int arr . length= length (arr)
            int length = arr1.Length;

            for( i= arr1.Length; i>=0; i--)
            {
              arr2 [arr1.Length - i]= arr1 [i];
            }
                Console.WriteLine(arr2);
                
        }
            
     }
            


           
 }

