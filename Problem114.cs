using System;

namespace Application
{
    public class Problem114
    {
        public static void Solution()
        {
            StudentA obj = new StudentA("Suren", 23);
            StudentA objj = new StudentA("Anisha", 20);
            StudentA[] ss = new StudentA[] { obj, objj };

            Employee obji = new Teacher("Tabrej Baba", "Chemistry");
            Class<StudentA, Employee> obje = new Class<StudentA, Employee>(10, obji, ss);

            StudentB objec = new StudentB("Panda", 12);
            StudentB ob = new StudentB("Husky", 11);
            StudentB[] oka = new StudentB[] { objec, ob };

            Admin obb = new Admin("Pulami Khadka");
            Class<StudentB, Admin> oo = new Class<StudentB, Admin>(11, obb, oka);

            obje.DisplayClass();
            oo.DisplayClass();
        }

        class StudentA
        {
            public string Name;
            public int Age;

            public StudentA(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public void DisplayStudent()
            {
                Console.WriteLine($"Name: {Name}, Age: {Age}");
            }
        }

        class StudentB
        {
            public string Name;
            public int Rollnumber;

            public StudentB(string name, int rollnumber)
            {
                Name = name;
                Rollnumber = rollnumber;
            }

            public void DisplayStudent()
            {
                Console.WriteLine($"Name: {Name}, Rollno: {Rollnumber}");
            }
        }

        class Employee
        {
            public string Name;

            public Employee(string name)
            {
                Name = name;
            }

            public void DisplayEmployee()
            {
                Console.WriteLine($"Name: {Name}");
            }
        }

        class Teacher : Employee
        {
            public string Subject;

            public Teacher(string name, string subject) : base(name)
            {
                Subject = subject;
            }

            public void DisplayTeacher()
            {
                Console.WriteLine($"Subject: {Subject}");
            }
        }

        class Admin : Employee
        {
            public Admin(string name) : base(name) { }
        }

        public class Class<T, P>
        {
            public int Level;
            public T[] Students;
            public P ClassTeacher;

            public Class(int level, P classteacher, T[] students)
            {
                Level = level;
                Students = students;
                ClassTeacher = classteacher;
            }

            public void DisplayClass()
            {
                Console.WriteLine($"Level: {Level}");

                if (ClassTeacher is Employee employee)
                {
                    employee.DisplayEmployee();
                    
                    if (ClassTeacher is Teacher teacher)
                    {
                        teacher.DisplayTeacher();
                    }
                }

                Console.WriteLine("Students:");
                foreach (var student in Students)
                {
                    if (student is StudentA studentA)
                    {
                        studentA.DisplayStudent();
                    }
                    else if (student is StudentB studentB)
                    {
                        studentB.DisplayStudent();
                    }
                }
            }
        }
    }
}
