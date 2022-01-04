using StartAssignment.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartAssignment.Repository_Service
{
    class Main_Repository
    {
        private InputDatabase idb = new InputDatabase();
        private MyDatabase db = new MyDatabase();


        #region Students
        public List<Student> GetStudents()
        {
            return db.Students;
        }
        public List<Student> GetInputStudents()
        {
            return idb.Students;
        }
        public void CreateStudents(Student student)
        {
            if (idb.Students.Count == 0)
            {
                student.Id = 1;
            }
            else
            {
                int lastId = idb.Students[idb.Students.Count].Id;
                student.Id = lastId + 1;
            }
            idb.Students.Add(student);
        }
        public void AttachStudentToCourse(int studentId, int courseId)
        {
            var student = idb.Students.Find(x => x.Id == studentId);
            var course = idb.Courses.Find(x => x.Id == courseId);
            course.Students.Add(student);
            student.Courses.Add(course);
        }
        #endregion
        #region Trainers

        public void AttachTrainerToCourse(int trainerId, int courseId)
        {
            var trainer = idb.Trainers.Find(x => x.Id == trainerId);
            var course = idb.Courses.Find(x => x.Id == courseId);
            course.Trainers.Add(trainer);
            trainer.Courses.Add(course);
        }

        public List<Trainer> GetTrainers()
        {
            return db.Trainers;
        }
        public List<Trainer> GetInputTrainers()
        {
            return idb.Trainers;
        }
        public void CreateTrainers(Trainer trainer)
        {
            if (idb.Trainers.Count == 0)
            {
                trainer.Id = 1;
            }
            else
            {
                int lastId = idb.Trainers[idb.Trainers.Count-1].Id;
                trainer.Id = lastId + 1;
            }
            idb.Trainers.Add(trainer);
        }
        #endregion
        #region Assignments
        public List<Assignment> GetAssignments()
        {
            return db.Assignments;
        }
        public List<Assignment> GetInputAssignments()
        {
            return idb.Assignments;
        }
        public void CreateAssignment(Assignment assignment)
        {
            if (idb.Assignments.Count == 0)
            {
                assignment.Id = 1;
            }
            else
            {
                int lastId = idb.Assignments[idb.Assignments.Count-1].Id;
                assignment.Id = lastId + 1;
            }
            idb.Assignments.Add(assignment);
        }
        public void AttachAssignmentToCourse(int assignmentId, int courseId)
        {
            var assignment = idb.Assignments.Find(x => x.Id == assignmentId);
            var course = idb.Courses.Find(x => x.Id == courseId);
            course.Assignments.Add(assignment);
        }
        #endregion
        #region Courses
        public List<Course> GetCourses()
        {
            return db.Courses;
        }
        public List<Course> GetInputCourses()
        {
            return idb.Courses;
        }
        public void CreateCourses(Course course)
        {
            if (idb.Courses.Count == 0)
            {
                course.Id = 1;
            }
            else
            {
                int lastId = idb.Courses[idb.Courses.Count-1].Id;
                course.Id = lastId + 1;
            }
            idb.Courses.Add(course);
        }

        #endregion

    }
}
