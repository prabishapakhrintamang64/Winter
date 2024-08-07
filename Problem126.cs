using System;
using System.Collections.Generic;

namespace Application
{
    public class Problem126
    {
        public static void solution()
        {
            Student student = new Student("Eren", "Yeager", 3);
            Student student1 = new Student("Inosuke", "Hasibira", 1);
            List<Student> studentList = new List<Student> { student, student1 };

            Class class1 = new Class("twelve", studentList);
            List<Class> classList = new List<Class> { class1 };

            Student student2 = new Student("Geto", "Suguru", 6);
            class1.AddStudent(student2);

            School school = new School("MMC", classList);
            school.Schoolinfo();
        }

        class Student
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

            public void Studentinfo()
            {
                Console.WriteLine($"Fname={Fname}, Lname={Lname}, Rollno:{Rollno}");
            }
        }

        class Class
        {
            public string Grade;
            public List<Student> Students;

            public Class(string grade, List<Student> students)
            {
                Grade = grade;
                Students = students;
            }

            public void AddStudent(Student newStudent)
            {
                Students.Add(newStudent);
            }

            public void Classinfo()
            {
                Console.WriteLine($"Grade:{Grade}");
                Console.WriteLine("Students:");
                foreach (Student student in Students)
                {
                    student.Studentinfo();
                }
            }
        }

        class School
        {
            public string Schoolname;
            public List<Class> Classes;

            public School(string schoolname, List<Class> classes)
            {
                Schoolname = schoolname;
                Classes = classes;
            }

            public void Schoolinfo()
            {
                Console.WriteLine($"Schoolname:{Schoolname}");
                Console.WriteLine("Classes:");
                foreach (Class class1 in Classes)
                {
                    class1.Classinfo();
                }
            }
        }
    }
}
