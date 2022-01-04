using StartAssignment.Enums;
using System;
using System.Collections.Generic;

namespace StartAssignment
{
    class Course
    {
        public Course(int id, string title, CourseStreamEnum stream, CourseTypeEnums type, DateTime start_Date, DateTime end_Date)
        {
            Id = id;
            Title = title;
            Stream = stream;
            Type = type;
            Start_Date = start_Date;
            End_Date = end_Date;
        }

        public int Id { get; set; }
        public string Title { get; set; }

        public CourseStreamEnum Stream { get; set; }

        public CourseTypeEnums Type { get; set; }

        public DateTime Start_Date { get; set; }

        public DateTime End_Date { get; set; }

        public List<Trainer> Trainers { get; set; } = new List<Trainer>();
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Assignment> Assignments { get; set; } = new List<Assignment>();

    }
}
