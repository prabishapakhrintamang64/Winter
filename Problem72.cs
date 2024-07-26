using System;
namespace Application
{
    class Problem72
    {
        public float Program(int[] arr)
        {
            // get the sum of all array elements
            float sum = arr.Sum();
 	 
           // get the total number of elements present in the array
            int count = arr.Count();
 	 
                float average = sum/count;
                return average;
        }
         public static void solution()
        {
          Problem72 obj = new Problem72();
          int[] arr =[13, 12, 14, 30];
            float ans = obj.Program(arr);
            Console.WriteLine(ans);
        }
    }
}


