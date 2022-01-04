using StartAssignment.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StartAssignment.Validations;

namespace StartAssignment.Views
{
    class ViewCourse : Validation
    {
        public static void PrintAllCourses(List<Course> courses)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Id----Title-------Stream------Type---------Start Date---------End Date");
            Console.ResetColor();
            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Id,-6}{course.Title,-5}{' ',8}{course.Stream}{' ',5} {course.Type,-10}{' ',5} {course.Start_Date.ToShortDateString(),-10}{' ',7} {course.End_Date.ToShortDateString(),-10}");
            }
        }

        public static Course CreateInputCourse()
        {
            //Title
            string title = IsValidCourse1();
            //Stream
            int choice=1;
            CourseStreamEnum stream = 0;
            do
            {
                try
                {
                    Console.WriteLine("Choose the Course's stream.Choose a number from the following.");
                    Console.WriteLine("1-CB8  2-CB9  3-CB10  4-CB11  5-CB12");
                    choice = IsValidEnumCb();

                    switch (choice)
                    {
                        case 1: stream = (CourseStreamEnum)choice; break;
                        case 2: stream = (CourseStreamEnum)choice; break;
                        case 3: stream = (CourseStreamEnum)choice; break;
                        case 4: stream = (CourseStreamEnum)choice; break;
                        case 5: stream = (CourseStreamEnum)choice; break;
                        default: Console.WriteLine("Not a valid choice. Please try again"); break;

                    }
                }
                catch ( Exception e)
                {

                    Console.WriteLine(e.Message);
                }
            } while (choice != 1 && choice != 2 && choice != 3 && choice != 4 && choice != 5);

            //TYPE
            CourseTypeEnums type = 0;
            do
            {
                try
                {
                    Console.WriteLine("Choose the course's type.Choose a number from the following.");
                    Console.WriteLine("1-FullTime  2-PartTime");
                    choice = IsValidEnumStream();
                    switch (choice)
                    {
                        case 1: type = (CourseTypeEnums)choice; break;
                        case 2: type = (CourseTypeEnums)choice; break;
                        default: Console.WriteLine("Not a valid choice. Please try again"); break;
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
            } while (choice != 1 && choice != 2);

            //StartDate
            DateTime startDate = IsValidDate("course", "starting date");
            //EndDate
            DateTime endDate = IsValidDateCourse("course", "end date",startDate,choice);

            Course course = new Course(0, title, stream, type, startDate, endDate);
            return course;
        }
    }
}
