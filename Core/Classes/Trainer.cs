using System.Collections.Generic;

namespace StartAssignment
{
    class Trainer
    {
        public Trainer(int id, string first_Name, string last_Name, string subject)
        {
            Id = id;
            First_Name = first_Name;
            Last_Name = last_Name;
            Subject = subject;
        }

        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Subject { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();
    }
}
