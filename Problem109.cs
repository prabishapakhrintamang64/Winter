using System;
namespace Application
{
    public class Problem109
    {
        public static void solution()
        {
            School school = new School("Devaki Secondary");
            school.DisplaySchoolInfo();

            Class myClass = new Class("Devaki Secondary", "Class 12A");
            myClass.DisplayClassInfo();

            Employee employee=new Employee("Devaki Secondary", "Rabindra");
            employee.DisplayEmployeeInfo();

            Student student = new Student("Devaki Secondary", "Class 12A", "Susan Lama");
            student.DisplayStudentInfo();
            
            Teacher teacher = new Teacher("Devaki Secondary", "UPS", "Rabindra");
            teacher.DisplayTeacherInfo();
            
        }
        public class School
        {
            public string SchoolName;
            public School(string schoolname)
            {
                SchoolName=schoolname;
            }
            public void DisplaySchoolInfo()
            {
                Console.WriteLine($"SchoolName:{SchoolName}");
            }

        }
        public class Class: School
        {
            public string ClassName;
            public Class( string schoolname, string classname) :base(schoolname)
            {
                ClassName= classname;
            }
            public void DisplayClassInfo()
            {
                Console.WriteLine($"ClassName:{ClassName}");
            }
        }
        class Employee: School  
        {
            public string EmployeeName;
            public Employee(string schoolname, string employeename): base(schoolname)
            {
                EmployeeName= employeename;
            }
                public void DisplayEmployeeInfo()
            {
                Console.WriteLine($"EmployeeName:{EmployeeName}");
            }

        }
        class Student: Class
        {
            public string StudentName;
            public Student( string schoolname, string classname, string studentname): base(schoolname,classname)
            {
                StudentName=studentname;

            }
                public void DisplayStudentInfo()
            {
                Console.WriteLine($"StudentName:{StudentName}");
            }

        }
        class Teacher: Employee
        {
            public string TeacherName;
            public Teacher(string schoolname, string employeename, string teachername): base(schoolname, employeename)
            {
                TeacherName=teachername;
            }
                public void DisplayTeacherInfo()
            {
                Console.WriteLine($"TeacherName:{TeacherName}");
            }

        }
    }
}