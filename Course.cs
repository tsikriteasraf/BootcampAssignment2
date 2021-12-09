using System;
using System.Collections.Generic;

namespace StartAssignment
{
    class Course
    {
 

        public string Title { get; set; }

        public string Stream { get; set; }

        public string Type { get; set; }

        public DateTime Start_Date { get; set; }

        public DateTime End_Date { get; set; }

        public List<Trainer> Trainers { get; set; } = new List<Trainer>();
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Assignment> Assignments { get; set; } = new List<Assignment>();

    }
}
