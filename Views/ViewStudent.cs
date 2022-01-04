using StartAssignment.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartAssignment.Views
{
    class ViewStudent:Validation
    {
       
        public static void PrintAllStudents(List<Student> students)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Id---First Name------Last Name-------Date of Birth------Tuition Fees");
            Console.ResetColor();
            foreach (var stu in students)
            {
                Console.WriteLine($"{stu.Id,-5}{stu.FirstName,-15} {stu.LastName,-15} {stu.DateOfBirth.ToShortDateString(),-15} {' ',5}{stu.TuitionFees,-15}");
            }
        }
        public static void PrintStudentsPerCourse(List<Course> courses)
        {
            
            foreach (var course in courses)
            {

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"Course: {course.Title}  {course.Type}");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Fist Name-----Last Name");
                Console.ResetColor();
                foreach (var student in course.Students)
                {
                    Console.WriteLine($"{student.FirstName,-15}{student.LastName,-15}");
                }
            }
        }
        public static void PrintStudentMoreCourses(List<Student>students)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("First Name-------Last Name------Courses");
            Console.ResetColor();
            foreach (var stu in students)
            {
                if (stu.Courses.Count > 1)
                {
                    Console.WriteLine($"{stu.FirstName,-15} {stu.LastName,-15}-----------------------");
                    foreach (var course in stu.Courses)
                    {
                        Console.WriteLine($"{course.Title,50}{' ',3}");
                    }
                }
            }
        }
        public static Student CreateInputStudent()
        {
            string firstName = IsValidName("first", "student");
            string lastName = IsValidName("last", "student");
            DateTime birthday = IsValidBirthday("student", "Date Of Birth");
            int tuitionFees = IsValidNumber();
            Student student = new Student(0, firstName, lastName, birthday, tuitionFees);
            return student;
        }
    }
}
