using StartAssignment.Repository_Service;
using StartAssignment.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StartAssignment.Validations;

namespace StartAssignment.Controllers
{
    class Controller:Validation
    {
        Main_Repository repository = new Main_Repository();



        #region Students


        public void AssignStudentToCourse()
        {
            var students = repository.GetInputStudents();
            Console.WriteLine("Assign Student To Course \n");
            ReadAllInputStudents();

            var courses = repository.GetInputCourses();
            ReadAllInputCourses();

            Console.WriteLine("Give Student's Id");
            int studentId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give Course's Id");
            int courseId = Convert.ToInt32(Console.ReadLine());

            repository.AttachStudentToCourse(studentId, courseId);
        }

        //Student Prints
        public void ReadAllStudents() => ViewStudent.PrintAllStudents(repository.GetStudents());
        public void ReadAllInputStudents() => ViewStudent.PrintAllStudents(repository.GetInputStudents());

        public void ReadStudentsPerCourse() => ViewStudent.PrintStudentsPerCourse(repository.GetCourses());
        public void ReadInputStudentsPerCourse() => ViewStudent.PrintStudentsPerCourse(repository.GetInputCourses());
        public void ReadStudentsMoreCourses() => ViewStudent.PrintStudentMoreCourses(repository.GetStudents());
        public void ReadInputStudentsMoreCourses() => ViewStudent.PrintStudentMoreCourses(repository.GetInputStudents());

        //Student Creation
        public void CreateStudents()
        {
            Student student = ViewStudent.CreateInputStudent();
            repository.CreateStudents(student);
        }
        #endregion
        #region Courses

        //Courses Prints
        public void ReadAllCourses() => ViewCourse.PrintAllCourses(repository.GetCourses());
        public void ReadAllInputCourses() => ViewCourse.PrintAllCourses(repository.GetInputCourses());

        //Courses Creation
        public void CreateCourses()
        {
            Course course = ViewCourse.CreateInputCourse();
            repository.CreateCourses(course);
        }
        #endregion
        #region Trainers

        public void AssignTrainerToCourse()
        {
            var trainers = repository.GetInputTrainers();
            Console.WriteLine("Assign Trainer To Course \n");
            ReadAllInputTrainers();

            var courses = repository.GetInputCourses();
            ReadAllInputCourses();

            Console.WriteLine("Give Trainer's Id");
            int trainerId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give Course's Id");
            int courseId = Convert.ToInt32(Console.ReadLine());

            repository.AttachTrainerToCourse(trainerId, courseId);
        }

        //Trainer Prints

        public void ReadAllTrainers() => ViewTrainer.PrintAllTrainers(repository.GetTrainers());
        public void ReadAllInputTrainers() => ViewTrainer.PrintAllTrainers(repository.GetInputTrainers());
        public void ReadTrainersPerCourse() => ViewTrainer.PrintTrainersPerCourse(repository.GetCourses());
        public void ReadInputTrainersPerCourse() => ViewTrainer.PrintTrainersPerCourse(repository.GetInputCourses());

        //Trainer Creation
        public void CreateTrainers()
        {
            Trainer trainer = ViewTrainer.CreateInputTrainer();
            repository.CreateTrainers(trainer);

        }

        #endregion
        #region Assignments

        public void AssignAssignmentToCourse()
        {
            var assignments = repository.GetInputAssignments();
            Console.WriteLine("Assign Assignment To Course \n");
            ReadAllInputAssignments();

            var courses = repository.GetInputCourses();
            ReadAllInputCourses();

            Console.WriteLine("Give Assignment's Id");
            int assignmentId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give Course's Id");
            int courseId = Convert.ToInt32(Console.ReadLine());

            repository.AttachAssignmentToCourse(assignmentId, courseId);
        }

        //Assignment Prints

        public void ReadAllAssignments() => ViewAssignment.PrintAllAssignments(repository.GetAssignments());
        public void ReadAllInputAssignments() => ViewAssignment.PrintAllAssignments(repository.GetInputAssignments());
        public void ReadAllAssignmentsPerCourse() => ViewAssignment.PrintAssignmentsPerCourse(repository.GetCourses());
        public void ReadAllInputAssignmentsPerCourse() => ViewAssignment.PrintAssignmentsPerCourse(repository.GetInputCourses());
        public void ReadAllAssignmentsPerStudent() => ViewAssignment.PrintAssignmentsPerStudent(repository.GetStudents());
        public void ReadAllInputAssignmentsPerStudent() => ViewAssignment.PrintAssignmentsPerStudent(repository.GetInputStudents());
        public void ReadAllStudentsWithAssignmentsAt() => ViewAssignment.PrintAllStudentsWithAssignmentAtDate(IsValidSpecifiedDate(repository.GetAssignments()));
        //Assignment Creation
        public void CreateAssignments()
        {
            Assignment assignment = ViewAssignment.CreateAssignment();
            repository.CreateAssignment(assignment);
        }
        #endregion

    }
}
