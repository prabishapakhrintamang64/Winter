using System;
namespace Application
{
    class Problem42
    {
        public static void solution()
        {
            // String Interpolation 
            string daughter =" prabisha";
            string parents ="pritam and basun";
            // use string interpolation to concatenate strings
            string daughterofparents =$"{ daughter} is a child of {parents}.";
            Console.WriteLine(daughterofparents);
        }
    }

}