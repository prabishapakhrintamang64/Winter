using System;
namespace Application
{
    class Problem75
    {
        public float calculate(int m, float a)
        {
            float F = m*a;
            return F;
        }
    
    public static void solution()
    {
        Problem75 obj= new Problem75();
        float ans= obj.calculate(50,12);
        Console.WriteLine(ans);
        Console.ReadLine();
    }
    }
}