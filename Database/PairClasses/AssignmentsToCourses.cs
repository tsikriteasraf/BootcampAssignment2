using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartAssignment.Database.PairClasses
{
    class AssignmentsToCourses
    {
        public static void Pair(Assignment a, Course c)
        {
            c.Assignments.Add(a);
            a.Course = c;
        }

    }
}
