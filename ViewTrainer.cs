using StartAssignment.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartAssignment.Views
{
    class ViewTrainer:Validation
    {
       
        public static void PrintAllTrainers(List<Trainer>trainers)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Id---First Name----Last Name---------Subject");
            Console.ResetColor();
            foreach (var trainer in trainers)
            {
                Console.WriteLine($"{trainer.Id,-5}{trainer.First_Name,-15}{trainer.Last_Name,-15}");
                foreach (var course in trainer.Courses)
                {
                    Console.WriteLine($"{course.Title,40} {course.Type}");
                }
            }
        }
        public static void PrintTrainersPerCourse(List<Course> courses)
        {
            
            foreach (var course in courses)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"Course: {course.Title}  {course.Type}");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Fist Name-----Last Name");
                Console.ResetColor();
                Console.ResetColor();
                foreach (var trainer in course.Trainers)
                {
                    Console.WriteLine($"{trainer.First_Name,-15}{trainer.Last_Name,-15}");
                }
            }
        }
        public static Trainer CreateInputTrainer()
        {
            string firstName = IsValidName("first","trainer");
            string lastName = IsValidName("last", "trainer");
            string subject = IsValidCourse("trainer");
            Trainer trainer = new Trainer(0, firstName, lastName, subject);
            return trainer;
        }

        
    }
}
