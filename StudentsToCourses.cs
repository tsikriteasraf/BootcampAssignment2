using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartAssignment.Database.PairClasses
{
    class StudentsToCourses
    {
        public static void Pair(Student s,Course c)
        {
            s.Courses.Add(c);
            c.Students.Add(s);
        }
    }
}
