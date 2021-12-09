using System.Collections.Generic;

namespace StartAssignment
{
    class Trainer
    {
       

        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Subject { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();
    }
}
