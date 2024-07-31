using System;
namespace Application 
{
    public class Problem102
    {
        public static void solution()
        {
            Stuudent obj = new Stuudent("prabisha", 12);
            Stuudent[] student=  new Stuudent[] {obj};

            Cllaasss obj2= new Cllaasss("twelve", student);
            Cllaasss[] Class= new Cllaasss[] {obj2};

            Schooll obj3= new Schooll("Devaki Ma.Vi", Class);
            obj3.displayproperty();



        }
         class Stuudent
         {
            public string Name;
            public int Grade;


            public Stuudent ( string name, int grade)
            {
                Name = name;
                Grade = grade;

            }
            public void displayproperty()
            {
                Console.WriteLine($"Name:{Name}, Grade:{Grade}");
            }


         }
         class Cllaasss
         {
            public string Classname;
            public Stuudent[] Stuudents;

            public Cllaasss(string classname, Stuudent[] stuudents)
            {
                Classname= classname;
                Stuudents= stuudents;
            }

            public void displayproperty()
            {
                Console.WriteLine($"Classname: {Classname}");
                Console.WriteLine("Stuudent:");
                foreach(var stuudents in Stuudents)
                {
                    stuudents.displayproperty();
                }

            }

         }

         class Schooll
         {
            public string Schoolname;
            public Cllaasss[] Cllaassses;
            public Schooll(string schoolname, Cllaasss[] cllaassses)
            {
                Schoolname= schoolname;
                Cllaassses= cllaassses;
            }

            public void displayproperty()
            {
                Console.WriteLine("Schooll");
                Console.WriteLine($"Schoolname: {Schoolname}");
                Console.WriteLine("Cllaasss:");
               foreach(var cllaassses in Cllaassses)
               {
                cllaassses.displayproperty();
               }
            }

         }
    }
}