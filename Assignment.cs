using System;
using System.Collections.Generic;

namespace StartAssignment
{
    class Assignment
    {
        

        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime SubDateTime { get; set; }
        public int OralMark { get; set; }
        public int TotalMark { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();
    }
}
