using StartAssignment.Controllers;
using StartAssignment.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StartAssignment.Menu
{
    class StartMenu
    {
        Controller controller = new Controller();
        public void MainMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Hello user");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Please choose one of the following");
            Console.ResetColor();
            string input = "";
            do
            {
                Console.WriteLine("1- Syntetic Data");
                Console.WriteLine("2- Create your own data");
                Console.WriteLine("3- View your own data");
                Console.WriteLine("E- To exit");
                input = Console.ReadLine().ToUpper();
                Console.Clear();
                switch (input)
                {
                    case "1":MenuSunthetic();break;
                    case "2":InputCreationMenu();break;
                    case "3":InputShowMenu();break;
                    case "E": Console.WriteLine("Have a nice day!"); break;
                    default: Console.WriteLine("Please choose a valid option");break;
                }
            } while (input!="E");
        }
        public void MenuSunthetic()
        {
            string input = "";
            do
            {
                Console.WriteLine("1-All Students");
                Console.WriteLine("2-All Courses");
                Console.WriteLine("3-All Trainers");
                Console.WriteLine("4-All Assignments");
                Console.WriteLine("5-All Students Per Course");
                Console.WriteLine("6-All Trainers Per Course");
                Console.WriteLine("7-All Assignments Per Course");
                Console.WriteLine("8-All Assignments Per Student");
                Console.WriteLine("9-Students With More Than One Course");
                Console.WriteLine("10-Students With Assignments at a specified date");
                Console.WriteLine("E-To go back to main menu");
                input = Console.ReadLine().ToUpper();
                Console.Clear();
                switch (input)
                {
                    case "1":controller.ReadAllStudents();break;
                    case "2":controller.ReadAllCourses();break;
                    case "3":controller.ReadAllTrainers();break;
                    case "4":controller.ReadAllAssignments();break;
                    case "5":controller.ReadStudentsPerCourse();break;
                    case "6":controller.ReadTrainersPerCourse();break;
                    case "7":controller.ReadAllAssignmentsPerCourse();break;
                    case "8":controller.ReadAllAssignmentsPerStudent();break;
                    case "9":controller.ReadStudentsMoreCourses();break;
                    case "10":controller.ReadAllStudentsWithAssignmentsAt();break;
                    case "E":break;

                    default:Console.WriteLine("Please Enter a Valid Choice");break;
                }
              
            } while (input!="E");
        }
        public void InputCreationMenu()
        {
          
            string input = "";
            do
            {
                Console.WriteLine("1- Create Students");
                Console.WriteLine("2- Create Courses");
                Console.WriteLine("3- Create Trainers");
                Console.WriteLine("4- Create Assignments");
                Console.WriteLine("5-Assign Student To Course");
                Console.WriteLine("6-Assign Trainer To Course");
                Console.WriteLine("7-Assign Assignment To Course");
                Console.WriteLine("E-To go back to main menu");
                input = Console.ReadLine().ToUpper();
                Console.Clear();
                switch (input)
                {
                    case "1": controller.CreateStudents(); break;
                    case "2": controller.CreateCourses(); break;
                    case "3": controller.CreateTrainers(); break;
                    case "4": controller.CreateAssignments(); break;
                    case "5": controller.AssignStudentToCourse(); break;
                    case "6": controller.AssignTrainerToCourse(); break;
                    case "7": controller.AssignAssignmentToCourse(); break;
                    case "E": break;
                    default: Console.WriteLine("Invalid Choice. Try again."); break;
                } 
            } while (input!="E");
        }
        public void InputShowMenu()
        {
            string input;
           
            do
            {
                Console.WriteLine("1-All Students");
                Console.WriteLine("2-All Courses");
                Console.WriteLine("3-All Trainers");
                Console.WriteLine("4-All Assignments");
                Console.WriteLine("5-All Students Per Course");
                Console.WriteLine("6-All Trainers Per Course");
                Console.WriteLine("7-All Assignments Per Course");
                Console.WriteLine("8-All Assignments Per Student");
                Console.WriteLine("9-Students With More Than One Course");
                Console.WriteLine("E-To go back to main menu");
                input= Console.ReadLine().ToUpper();
                Console.Clear();
                switch (input)
                {
                    case "1": controller.ReadAllInputStudents(); break;
                    case "2": controller.ReadAllInputCourses(); break;
                    case "3": controller.ReadAllInputTrainers(); break;
                    case "4": controller.ReadAllInputAssignments(); break;
                    case "5": controller.ReadInputStudentsPerCourse(); break;
                    case "6": controller.ReadInputTrainersPerCourse(); break;
                    case "7": controller.ReadAllInputAssignmentsPerCourse(); break;
                    case "8": controller.ReadAllInputAssignmentsPerStudent(); break;
                    case "9": controller.ReadInputStudentsMoreCourses(); break;
                    case "E": break;

                    default: Console.WriteLine("Please Enter a Valid Choice"); break;
                }
            } while (input != "E");
        }
        
    }
}
