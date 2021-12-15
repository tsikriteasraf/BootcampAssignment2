using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StartAssignment.Validations;

namespace StartAssignment.Views
{
    class ViewAssignment:Validation
    {
        public static void PrintAllStudentsWithAssignmentAtDate(List<Assignment> assignments)
        {
            foreach (var assignment in assignments)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"{assignment.Title} of {assignment.Course.Title} {assignment.Course.Type} has to be submitted by the following students this week: ");
                Console.ResetColor();
                foreach (var stu in assignment.Course.Students)
                {
                    Console.WriteLine($"{stu.FirstName,5} {stu.LastName}");
                }
            }
        }
        public static void PrintAllAssignments(List<Assignment> assignments)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Id---Title-----------------------Description----------------------------------------------SubDate Time------------------Oral Mark-----Total Mark");
            Console.ResetColor();
            foreach (var assignment in assignments)
            {
                Console.WriteLine($"{assignment.Id,-5}{assignment.Title,-15}{' ',3}{assignment.Description,-40}{' ',30} {assignment.SubDateTime.ToShortDateString(),-30} {assignment.OralMark,-10} {assignment.TotalMark,-10}");
            }
        }
        public static void PrintAssignmentsPerCourse(List<Course> courses)
        {
           
            foreach (var course in courses)
            {
               
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"Course: {course.Title}  {course.Type}");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Title------------------------Description");
                Console.ResetColor();
                foreach (var assignment in course.Assignments)
                {
                    Console.WriteLine($"{assignment.Title,-15}{' ',5}{assignment.Description,-15}");
                }
            }
        }
        public static void PrintAssignmentsPerStudent(List<Student>students)
        {
            foreach (var stu in students)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"{stu.FirstName,-15}{' ',5}{stu.LastName,-15}");
                Console.ResetColor();
                foreach (var course in stu.Courses)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($"{course.Title} {course.Type}");
                    Console.ResetColor();
                    Console.WriteLine($"Title--------------------Description");
                    foreach (var assignment in course.Assignments)
                    {
                        Console.WriteLine($"{assignment.Title}{' ',5}{assignment.Description,-15}");
                    }
                }
            }
        }
        public static Assignment CreateAssignment()
        {

            string title = IsValidAssignmentTitle();
            Console.WriteLine("Give the Assignment's Description");
            string description=Console.ReadLine();
            DateTime subDateTime = IsValidDate("assignment", "sub date time");
            int oralMark = IsValidScore();
            int totalMark = IsValidScore();
            Assignment assignment = new Assignment(0, title, description, subDateTime, oralMark, totalMark);
            return assignment;
        }
    }
    
}
