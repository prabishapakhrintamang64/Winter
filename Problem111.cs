using System;

namespace Application
{
    public class Problem111
    {
        public static void solution()
        {
            Student[] students = new Student[]
            {
                new Student(1, "John Doe"),
                new Student(2, "Jane Smith")
            };

            Class myClass = new Class("Class A", students);

            Employee[] employees = new Employee[]
            {
                new Teacher(101, "Mr. Anderson", 201, "Anderson"),
                new Admin(102, "Ms. Brown", 301, "Brown")
            };

            School mySchool = new School("Greenwood High", new Class[] { myClass }, employees);

            mySchool.DisplaySchool();
            myClass.DisplayClass();
            

            foreach (var student in students)
            {
                student.DisplayStudent();
            }
            }
            }
        }

        public class Student
        {
            public int StudentId;
            public string StudentName;

            public Student(int studentid, string studentname)
            {
                StudentId = studentid;
                StudentName = studentname;
            }

            public void DisplayStudent()
            {
                Console.WriteLine($"StudentId: {StudentId}, StudentName: {StudentName}");
            }
        }

        public class Class
        {
            public string ClassName;
            public Student[] Students;

            public Class(string classname, Student[] students)
            {
                ClassName = classname;
                Students = students;
            }

            public void DisplayClass()
            {
                Console.WriteLine($"ClassName: {ClassName}");
                foreach (var student in Students)
                {
                    student.DisplayStudent();
                }
            }
        }

        public class Employee
        {
            public int EmployeeId;
            public string EmployeeName;

            public Employee(int employeeid, string employeename)
            {
                EmployeeId = employeeid;
                EmployeeName = employeename;
            }

            public void DisplayEmployee()
            {
                Console.WriteLine($"EmployeeId: {EmployeeId}, EmployeeName: {EmployeeName}");
            }
        }

        public class Teacher : Employee
        {
            public int TeacherId;
            public string TeacherName;

            public Teacher(int employeeid, string employeename, int teacherid, string teachername)
                : base(employeeid, employeename)
            {
                TeacherId = teacherid;
                TeacherName = teachername;
            }

            public void DisplayTeacher()
            {
                Console.WriteLine($"TeacherId: {TeacherId}, TeacherName: {TeacherName}");
            }
        }

        public class Admin : Employee
        {
            public int AdminId;
            public string AdminName;

            public Admin(int employeeid, string employeename, int adminid, string adminname)
                : base(employeeid, employeename)
            {
                AdminId = adminid;
                AdminName = adminname;
            }

            public void DisplayAdmin()
            {
                Console.WriteLine($"AdminId: {AdminId}, AdminName: {AdminName}");
            }
        }

        public class School
        {
            public string SchoolName;
            public Class[] Classes;
            public Employee[] Employees;

            public School(string schoolname, Class[] classes, Employee[] employees)
            {
                SchoolName = schoolname;
                Classes = classes;
                Employees = employees;
            }

            public void DisplaySchool()
            {
                Console.WriteLine($"SchoolName: {SchoolName}");
                foreach (var classItem in Classes)
                {
                    classItem.DisplayClass();
                }
                foreach (var employee in Employees)
                {
                    employee.DisplayEmployee();
                }
            }
        }
    

