using System;
using System.Collections.Generic;

namespace Application
{
    public class Problem127
    {
        public static void solution()
        {
            Student obj = new Student("Superman", "Kumar", 23);
            Student objj = new Student("Spiderman", "Kumar", 20);
            List<Student> students = new List<Student> { obj, objj };

            Class<Student> myClass = new Class<Student>("seven", students);
            List<Class<Student>> classes = new List<Class<Student>> { myClass };
            School school = new School("MMC", classes);
            school.SchoolInfo();
        }

        public class Student
        {
            public string Fname;
            public string Lname;
            public int Rollno;

            public Student(string fname, string lname, int rollno)
            {
                Fname = fname;
                Lname = lname;
                Rollno = rollno;
            }

            public void StudentInfo()
            {
                Console.WriteLine($"Fname: {Fname}, Lname: {Lname}, Rollno: {Rollno}");
            }
        }

        public class Class<T>
        {
            public string Grade;
            public List<T> Students;

            public Class(string grade, List<T> students)
            {
                Grade = grade;
                Students = students;
            }

            public void ClassInfo()
            {
                Console.WriteLine($"Grade: {Grade}");
                Console.WriteLine("Students:");
                foreach (var student in Students)
                {
                    if (student is Student studentObj)
                    {
                        studentObj.StudentInfo();
                    }
                }
            }
        }

        public class School
        {
            public string Schoolname;
            public List<Class<Student>> Classes;

            public School(string schoolname, List<Class<Student>> classes)
            {
                Schoolname = schoolname;
                Classes = classes;
            }

            public void SchoolInfo()
            {
                Console.WriteLine($"Schoolname: {Schoolname}");
                Console.WriteLine("Classes:");
                foreach (var schoolClass in Classes)
                {
                    schoolClass.ClassInfo();
                }
            }
        }
    }
}
