using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace StartAssignment.Validations
{

   class Validation
    {
        //Queryables
        static Predicate<string> stringQueryable = s => s.ToCharArray().Select(x => Char.IsLetter(x)).Any(x => x == false);
        static Predicate<string> stringQueryable2 = s => Regex.IsMatch(s, @"[^a-zA-Z#+]");
        static Predicate<string> stringQueryable3 = s => Regex.IsMatch(s, @"[^a-zA-Z0-9]");

        //Methods
        public static string IsValidName(string nameType, string personType)
        {
            bool isValid = true;
            string firstName;
            do
            {

                Console.WriteLine($"Give the {personType}'s {nameType} name (No symbols or numbers allowed)");
                firstName = Console.ReadLine();
                isValid = stringQueryable(firstName);

            } while (isValid);
            return firstName;
        }

        public static int IsValidNumber()
        {
            int tuitionFees = 0;
            bool validFormat = true;
            bool inRangeFees = true;
            do
            {
                try
                {
                    Console.WriteLine("Give the student's tuition fees  (must be >=1000 & <=10000)");
                    tuitionFees = Convert.ToInt32(Console.ReadLine());
                    inRangeFees = tuitionFees < 1000 || tuitionFees > 10000;
                    validFormat = false;

                }
                catch (FormatException e)
                {

                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (validFormat || inRangeFees);
            return tuitionFees;
        }
        public static int IsValidScore()
        {
            int score = 0;
            bool validFormat = true;
            bool inRangescore = true;
            do
            {
                try
                {
                    Console.WriteLine("Give the assignment's score. (must be >=0 & <=100)");
                    score = Convert.ToInt32(Console.ReadLine());
                    inRangescore = score < 0 || score > 100;
                    validFormat = false;

                }
                catch (FormatException e)
                {

                    Console.WriteLine(e.Message);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                
            } while (validFormat || inRangescore);
            return score;
        }
        public static DateTime IsValidDate(string personType, string dateType)
        {
            DateTime birthday = DateTime.Now;
            bool isValidDate = true;
            do
            {
                try
                {
                    Console.WriteLine($"Give the {personType}'s {dateType}   ex.(yyyy-mm-dd)");
                    birthday = DateTime.Parse(Console.ReadLine());
                    isValidDate = false;
                }
                catch (FormatException e)
                {

                    Console.WriteLine(e.Message);
                }
            } while (isValidDate);
            return birthday;
        }
        public static DateTime IsValidDateCourse(string personType, string dateType,DateTime startingDate,int choice)
        {
            DateTime birthday = DateTime.Now;
            bool isValidDate = true;
            do
            {
                try
                {
                    Console.WriteLine($"Give the {personType}'s {dateType}   ex.(yyyy-mm-dd)");
                    birthday = DateTime.Parse(Console.ReadLine());
                    if (choice==1)
                    {
                        isValidDate = birthday < startingDate.AddMonths(6);
                    }
                    else if (choice==2)
                    {
                        isValidDate = birthday < startingDate.AddMonths(3);
                    }
                }
                catch (FormatException e)
                {

                    Console.WriteLine(e.Message);
                }
            } while (isValidDate);
            return birthday;
        }
        public static List<Assignment> IsValidSpecifiedDate(List<Assignment>assignments)
        {
            List<Assignment> assignments1 = new List<Assignment>();
            bool isValidDate = true;
            DateTime inputDate = DateTime.Now;
            DateTime start = DateTime.Parse("2019-1-1");
            DateTime end = DateTime.Parse("2019-6-30");
            DateTime from = DateTime.Now;
            DateTime to = DateTime.Now;
            do
            {
                try
                {
                    Console.WriteLine($"Give the date that you would like to check for " +
                        $"ex.(yyyy-mm-dd valid dates are between {start.ToShortDateString()} & {end.ToShortDateString()})");
                    inputDate = DateTime.Parse(Console.ReadLine());
                    isValidDate = !(inputDate >= start && inputDate <= end);
                    if (isValidDate==false)
                    {
                        switch (inputDate.DayOfWeek)
                        {
                            case DayOfWeek.Sunday:
                                from = inputDate.AddDays(-6);to = inputDate.AddDays(-2);
                                break;
                            case DayOfWeek.Monday:
                                from = inputDate; to = inputDate.AddDays(4);
                                break;
                            case DayOfWeek.Tuesday:
                                from = inputDate.AddDays(-1); to = inputDate.AddDays(3);
                                break;
                            case DayOfWeek.Wednesday:
                                from = inputDate.AddDays(-2); to = inputDate.AddDays(2);
                                break;
                            case DayOfWeek.Thursday:
                                from = inputDate.AddDays(-3); to = inputDate.AddDays(1);
                                break;
                            case DayOfWeek.Friday:
                                from = inputDate.AddDays(-4); to = inputDate;
                                break;
                            case DayOfWeek.Saturday:
                                from = inputDate.AddDays(-5); to = inputDate.AddDays(-1);
                                break;
                            default:
                                break;
                        }
                        foreach (var assignment in assignments)
                        {
                            if (assignment.SubDateTime >= from && assignment.SubDateTime<=to) assignments1.Add(assignment);
                        }
                    }
                }
                catch (FormatException e)
                {

                    Console.WriteLine(e.Message);
                }
            } while (isValidDate);
            return assignments1;
        }
        public static string IsValidCourse(string personType)
        {
            bool isValid = true;
            string subject = " ";
            do
            {
                try
                {
                    Console.WriteLine($"Give the {personType}'s subject");
                    subject = Console.ReadLine();
                    isValid = stringQueryable2(subject);
                }
                catch (FormatException e)
                {

                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (isValid);
            return subject;
        }
        public static string IsValidAssignmentTitle()
        {
            bool isValid = true;
            string title = " ";
            do
            {
                try
                {
                    Console.WriteLine($"Give the assignment's title  (only letters and numbers allowed)");
                    title = Console.ReadLine();
                    isValid = stringQueryable3(title);
                }
                catch (FormatException e)
                {

                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (isValid);
            return title;
        }

    }
    

}
