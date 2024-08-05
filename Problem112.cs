using System;
namespace Application
{
    public class Problem112
    {
        public static void solution()
        {
            Person person= new Person();
            person.GetFullName();

        }
        class Person
        {
            public string FirstName="Inosuke";
            public string LastName="Hasibira";
            public int Age=17;
            public void GetFullName()
            {
                Console.WriteLine($"FullName:{FirstName} {LastName},Age:{Age}");
            }
        }
    }
}