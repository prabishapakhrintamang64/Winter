using System;
namespace Application
{
    public class Problem110
    {
          public static void solution()
        {
            Student obj = new Student("soba");
            Student obj1 = new Student("boba");

            Student[] students1 = new Student[] { obj, obj1 };

            Class obj2 = new Class("class3", students1);
            Class[] classes3 = new Class[] { obj2 };

            Employee employees=new Employee("moye");
            Employee[] employees1=new Employee[]{employees};

            School school = new School("devaki", classes3,employees1);

            Teacher teacher = new Teacher("mew",12);
            
            Admin admin = new Admin("moye",7);
            
            school.DisplaySchoolInfo();
            teacher.Teacherinfo();
            admin.Admininfo();

        }
    public class Student
    {
        public string StudentName;
        public Student(string studentname)
        {
            StudentName = studentname;
        }
        public void DisplayStudentInfo()
        {
            Console.WriteLine($"Student Name: {StudentName}");
        }
    }
    public class Class
    {
        public string Classname;
        public Student[] Students;
        public Class(string classname, Student[] students)
        {
            Classname = classname;
            Students = students;
        }
        public void displayInfo()
        {
            Console.WriteLine($"Classname: {Classname}");
            Console.WriteLine("Students:");
            foreach (var student in Students)
            {
                student.DisplayStudentInfo();
            }
        }
    }
    public class Employee
    {
        public string EmployeeName;
        public Employee(string employeename)
        {
            EmployeeName = employeename;
        }
        public void Employeeinfo()
        {
            Console.WriteLine($"EmployeeName:{EmployeeName}");
        }
    }
    public class Teacher: Employee
    {
        public int Teacherid;
        public Teacher(string employeename, int teacherid) :base(employeename)
        {
            Teacherid = teacherid;
        }
        public void Teacherinfo()
        {
            Console.WriteLine($"Teacherid:{Teacherid}");
        }
    }
    public class Admin : Employee
    {
        public int Adminid;
        public Admin(string employeename, int adminid) : base(employeename)
        {
            Adminid = adminid;
        }
        public void Admininfo()
        {
            Console.WriteLine($"Adminid:{Adminid}");
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
        public void DisplaySchoolInfo()
        {
            Console.WriteLine($"SchoolName : {SchoolName}");
            Console.WriteLine("Classes");
            foreach (var classes in Classes)
            {
                classes.displayInfo();
            }
        }
    }
    
}
}





