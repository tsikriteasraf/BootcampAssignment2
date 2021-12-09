using System;
using System.Collections.Generic;

namespace StartAssignment
{
    class Student
    {
        

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int TuitionFees { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();
    }
}
