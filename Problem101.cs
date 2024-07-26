using System;
 namespace Application 
 {
    class Problem101
    {
        public static void solution()
        {
            School obj = new School()
            {
                Name="prabisha pakhrin",
                Location="bagmati, jhurjhure"


            };
            Students obj1= new Students()
            {
                name = "prabisha pakhrin",
                age = 17,
                grade = 12

            }
            obj.PrintDetails();
            obj1.PrintDetails();

        }
        class School
        {
            public string Name;
            public string Location;

            public School( string name, string location, string students)
            {
                Name=name;
                Location=location;

            }
            public void PrintDetails()
            {
                Console.WriteLine($"Name:{Name}, Location:{Location}");
            }




        }
        class Students
        {
            public string name;
            public int age;
            public int grade;
             public Students( string name, int age , int grade )
             {
                this.name = name ;
                this.age = age ;
                this.grade = grade ;

             }

             public void PrintDetails()
             {
                Console.WriteLine($"Name:{name}, Age:{age}, Grade:{grade}");
             }
        }

    }
 }