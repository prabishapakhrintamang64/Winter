using System;
using System.Collections;
namespace Application
{
    public class Problem125
    {
        public static void solution()
        {
            Student student= new Student("Eren","Yeager",3);
            Student student1= new Student("Inosuke","Hasibira",1);
            ArrayList arrayList= new ArrayList{student, student1};

            Class classes= new Class("twelve",arrayList);
            ArrayList arrayList1= new ArrayList{classes};

            Student student2= new Student("Geto","Suguru",6);
            classes.AddStudent(student2);


            School school=new School("MMC",arrayList1);
            school.Schoolinfo();


        }
        class Student
        {
            public string Fname;
            public string Lname;
            public int Rollno;

            public Student(string fname, string lname, int rollno)
            {
                Fname=fname;
                Lname=lname;
                Rollno=rollno;
            }
            public void Studentinfo()
            {
                Console.WriteLine($"Fname={Fname}, Lname={Lname}, Rollno:{Rollno}");
            }
        } 
        class Class
        {
            public string Grade;
            public ArrayList Students;
            public Class(string grade, ArrayList students)
            {
                Grade=grade;
                Students=students;
            }
            public void AddStudent(Student Newstudent)
            {
                Students.Add(Newstudent);

            }
            public void Classinfo()
            {
                Console.WriteLine($"Grade:{Grade}");
                Console.WriteLine("Students:");
                foreach(Student student in Students)
                {
                    student.Studentinfo();
                }
            }

        }
        class School
        {
            public string Schoolname;
            public ArrayList Classes;
            public School(string schoolname, ArrayList classes)
            {
                Schoolname=schoolname;
                Classes=classes;
            }
            public void Schoolinfo()
            {
                Console.WriteLine($"Schoolname:{Schoolname}");
                Console.WriteLine("Classes:");
                foreach(Class classes in Classes)
                {
                    classes.Classinfo();
                }
            }
            

        }
    }
}