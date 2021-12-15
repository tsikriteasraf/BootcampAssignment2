using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartAssignment.Database.PairClasses
{
    class TrainersToCourses
    {
        public static void Pair(Trainer t, Course c)
        {
            t.Courses.Add(c);
            c.Trainers.Add(t);
        }
      
    }
}
