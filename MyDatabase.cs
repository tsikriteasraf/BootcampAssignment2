using System.Collections.Generic;
using System;
using StartAssignment.Enums;
using StartAssignment.Database.PairClasses;

namespace StartAssignment
{
    class MyDatabase
    {
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Course> Courses { get; set; } = new List<Course>();
        public List<Trainer> Trainers { get; set; } = new List<Trainer>();
        public List<Assignment> Assignments { get; set; } = new List<Assignment>();

        public MyDatabase()
        {
            #region Seeding Students
            Student s1 = new Student(1, "Rafael", "Tsikriteas", new DateTime(1993, 5, 17), 2500);
            Student s2 = new Student(2, "Jadyn", "Schroeder", new DateTime(2000, 3, 11), 2500);
            Student s3 = new Student(3, "Eleanor", "Barnett", new DateTime(1995, 6, 22), 2500);
            Student s4 = new Student(4, "Isabelle", "Stafford", new DateTime(1996, 2, 13), 2500);
            Student s5 = new Student(5, "Keith", "Maynard", new DateTime(1997, 5, 19), 2500);
            Student s6 = new Student(6, "Violet", "Leblanc", new DateTime(1978, 4, 30), 2500);
            Student s7 = new Student(7, "Demarion", "Rios", new DateTime(1989, 10, 10), 2500);
            Student s8 = new Student(8, "Felicity", "Rosales", new DateTime(1992, 5, 10), 2500);
            Student s9 = new Student(9, "Perla", "Dennis", new DateTime(1990, 6, 15), 2500);
            Student s10 = new Student(10, "Isai", "Barnett", new DateTime(1991, 3, 12), 2500);
            Student s11 = new Student(11, "Evie", "Solomon", new DateTime(1998, 1, 21), 2500);
            Student s12 = new Student(12, "Alberto", "Irwin", new DateTime(1988, 5, 1), 2500);
            Student s13 = new Student(13, "Kaden", "Simmons", new DateTime(2001, 2, 12), 2500);
            Student s14 = new Student(14, "Arjun", "Powers", new DateTime(1990, 1, 19), 2500);
            Student s15 = new Student(15, "Antonio", "Mclean", new DateTime(1987, 5, 17), 2500);
            Student s16 = new Student(16, "Nikhil", "Miles", new DateTime(1999, 2, 25), 2500);
            Student s17 = new Student(17, "Aylin", "Craig", new DateTime(2000, 2, 1), 2500);
            Student s18 = new Student(18, "Mohamed", "Herring", new DateTime(1970, 1, 18), 2500);
            Student s19 = new Student(19, "Aden", "Richards", new DateTime(1998, 3, 5), 2500);
            Student s20 = new Student(20, "Haven", "Mckay", new DateTime(1995, 2, 19), 2500);
            Student s21 = new Student(21, "Dangelo", "Yu", new DateTime(1993, 12, 20), 2500);
            Student s22 = new Student(22, "Donte", "Rowe", new DateTime(1991, 12, 21), 2500);
            Student s23 = new Student(23, "Eddie", "Rivera", new DateTime(1985, 10, 21), 2500);
            Student s24 = new Student(24, "Tripp", "Rubio", new DateTime(1987, 12, 25), 2500);
            Student s25 = new Student(25, "Lincoln", "Lucas", new DateTime(1995, 2, 27), 2500);
            Student s26 = new Student(26, "Lorena", "Madden", new DateTime(1992, 1, 29), 2500);
            Student s27 = new Student(27, "Jasmin", "Cooper", new DateTime(1989, 1, 13), 2500);
            Student s28 = new Student(28, "Jaelynn", "Harris", new DateTime(1995, 11, 14), 2500);
            Student s29 = new Student(29, "Jaylah", "French", new DateTime(1999, 6, 4), 2500);
            Student s30 = new Student(30, "Ezequiel", "Schmidt", new DateTime(1990, 12, 21), 2500);
            Student s31 = new Student(31, "Giada", "Mcclure", new DateTime(2000, 5, 20), 2500);
            Student s32 = new Student(32, "Rowan", "Andersen", new DateTime(1993, 11, 11), 2500);
            Student s33 = new Student(33, "Leslie", "Avery", new DateTime(2000, 7, 25), 2500);
            Student s34 = new Student(34, "Jerry", "Prince", new DateTime(1996, 5, 12), 2500);
            Student s35 = new Student(35, "Cade", "Gillespie", new DateTime(1979, 2, 2), 2500);
            Student s36 = new Student(36, "Alexis", "Parks", new DateTime(1992, 3, 23), 2500);
            Student s37 = new Student(37, "Alexus", "Huber", new DateTime(1990, 4, 5), 2500);
            Student s38 = new Student(38, "Kamren", "Joyce", new DateTime(1989, 3, 8), 2500);
            Student s39 = new Student(39, "Colby", "Hebert", new DateTime(2001, 1, 2), 2500);
            Student s40 = new Student(40, "Carleigh", "Melendez", new DateTime(1994, 4, 20), 2500);
            Student s41 = new Student(41, "Maverick", "Marsh", new DateTime(1993, 4, 23), 2500);
            Student s42 = new Student(42, "Mario", "Lucas", new DateTime(1993, 4, 23), 2500);
            Student s43 = new Student(43, "Justice", "Barry", new DateTime(1997, 12, 5), 2500);
            Student s44 = new Student(44, "Stephany", "Vang", new DateTime(1998, 1, 29), 2500);
            Student s45 = new Student(45, "Cyrus", "Holden", new DateTime(1992, 4, 22), 2500);
            Student s46 = new Student(46, "Yadiel", "Huerta", new DateTime(1995, 6, 7), 2500);
            Student s47 = new Student(47, "Kaiya", "Koch", new DateTime(1997, 8, 12), 2500);
            Student s48 = new Student(48, "Monique", "Erickson", new DateTime(1999, 10, 21), 2500);
            Student s49 = new Student(49, "Jamarcus", "Esparza", new DateTime(1987, 12, 20), 2500);
            Student s50 = new Student(50, "Randy", "Shaw", new DateTime(1999, 11, 2), 2500);
            Student s51 = new Student(51, "Xiomara", "Ortega", new DateTime(2000, 4, 6), 2500);
            Student s52 = new Student(52, "Nolan", "York", new DateTime(1969, 6, 2), 2500);
            Student s53 = new Student(53, "Deandre", "Austin", new DateTime(1998, 10, 21), 2500);
            Student s54 = new Student(54, "Kassidy", "Poole", new DateTime(1993, 5, 20), 2500);
            Student s55 = new Student(55, "Anaya", "Horne", new DateTime(1995, 10, 9), 2500);
            Student s56 = new Student(56, "Joey", "Melendez", new DateTime(1995, 5, 5), 2500);
            Student s57 = new Student(57, "Jamar", "Banks", new DateTime(1988, 6, 23), 2500);
            Student s58 = new Student(58, "Hillary", "Weber", new DateTime(1996, 7, 26), 2500);
            Student s59 = new Student(59, "Jadyn", "Ashley", new DateTime(1996, 2, 27), 2500);
            Student s60 = new Student(60, "Blaine", "Grant", new DateTime(1982, 9, 12), 2500);
            Student s61 = new Student(61, "Louis", "Owen", new DateTime(1990, 3, 3), 2500);
            Student s62 = new Student(62, "Brandon", "Pena", new DateTime(1990, 5, 8), 2500);
            Student s63 = new Student(63, "Kaylynn", "Nunez", new DateTime(1994, 5, 15), 2500);
            Student s64 = new Student(64, "Lucian", "Barnes", new DateTime(1992, 3, 13), 2500);
            Student s65 = new Student(65, "Teagan", "Conley", new DateTime(1996, 3, 30), 2500);
            Student s66 = new Student(66, "Keira", "Herring", new DateTime(1998, 7, 1), 2500);
            Student s67 = new Student(67, "Kendal", "Bullock", new DateTime(1990, 4, 28), 2500);
            Student s68 = new Student(68, "Jamari", "Ballard",new DateTime(1995, 3, 23), 2500);
            Student s69 = new Student(69, "Emmy", "Horton", new DateTime(1995, 3, 23), 2500);
            Student s70 = new Student(70, "Troy", "Ramos", new DateTime(1995, 5, 1), 2500);
            Student s71 = new Student(71, "Ada", "Pratt", new DateTime(1994, 2, 18), 2500);
            Student s72 = new Student(72, "Allen", "Leblanc", new DateTime(1979, 2, 8), 2500);
            Student s73 = new Student(73, "Ronan", "Strickland", new DateTime(1994, 2, 19), 2500);
            Student s74 = new Student(74, "Charity", "Maldonado", new DateTime(1991, 3, 26), 2500);
            Student s75 = new Student(75, "Amber", "Byrd", new DateTime(1990, 6, 29), 2500);
            Student s76 = new Student(76, "Santos", "Oneill", new DateTime(1997, 8, 12), 2500);
            Student s77 = new Student(77, "Warren", "Wang", new DateTime(1977, 8, 3), 2500);
            Student s78 = new Student(78, "Keira", "Olsen", new DateTime(1998, 9, 17), 2500);
            Student s79 = new Student(79, "Anya", "Shannon", new DateTime(1989, 12, 4), 2500);
            Student s80 = new Student(80, "Josephine", "Carter", new DateTime(1990, 3, 3), 2500);
            #endregion
            #region Seeding Courses
            Course c1 = new Course(1, "C#", CourseStreamEnum.CB8, CourseTypeEnums.FullTime, new DateTime(2019, 1, 1), new DateTime(2019, 6, 30));
          
            c1.Students = new List<Student>() { s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15, s16, s17, s18, s19, s20 };
            s1.Courses.Add(c1);
            s2.Courses.Add(c1);
            s3.Courses.Add(c1);
            s4.Courses.Add(c1);
            s5.Courses.Add(c1);
            s6.Courses.Add(c1);
            s7.Courses.Add(c1);
            s8.Courses.Add(c1);
            s9.Courses.Add(c1);
            s10.Courses.Add(c1);
            s11.Courses.Add(c1);
            s12.Courses.Add(c1);
            s13.Courses.Add(c1);
            s14.Courses.Add(c1);
            s15.Courses.Add(c1);
            s16.Courses.Add(c1);
            s17.Courses.Add(c1);
            s18.Courses.Add(c1);
            s19.Courses.Add(c1);
            s20.Courses.Add(c1);
            Course c2 = new Course(2, "C#", CourseStreamEnum.CB8, CourseTypeEnums.PartTime, new DateTime(2019, 1, 1), new DateTime(2019, 3, 31));
          
            c2.Students = new List<Student>() { s21,s22,s23,s24,s25,s26,s27,s28,s29,s30,s31,s32,s33,s34,s35,s36,s37,s38,s39,s40};
            s21.Courses.Add(c2);
            s22.Courses.Add(c2);
            s23.Courses.Add(c2);
            s24.Courses.Add(c2);
            s25.Courses.Add(c2);
            s26.Courses.Add(c2);
            s27.Courses.Add(c2);
            s28.Courses.Add(c2);
            s29.Courses.Add(c2);
            s30.Courses.Add(c2);
            s31.Courses.Add(c2);
            s32.Courses.Add(c2);
            s33.Courses.Add(c2);
            s34.Courses.Add(c2);
            s35.Courses.Add(c2);
            s36.Courses.Add(c2);
            s37.Courses.Add(c2);
            s38.Courses.Add(c2);
            s39.Courses.Add(c2);
            s40.Courses.Add(c2);
            Course c3 = new Course(3, "Java", CourseStreamEnum.CB8, CourseTypeEnums.FullTime, new DateTime(2019, 1, 1), new DateTime(2019, 6, 30));
         
            c3.Students = new List<Student>() { s41, s42, s43, s44, s45, s46, s47, s48, s48, s49, s50, s51, s52, s53, s54, s55, s56, s57, s58, s59, s60 };
            s41.Courses.Add(c3);
            s42.Courses.Add(c3);
            s43.Courses.Add(c3);
            s44.Courses.Add(c3);
            s45.Courses.Add(c3);
            s46.Courses.Add(c3);
            s47.Courses.Add(c3);
            s48.Courses.Add(c3);
            s49.Courses.Add(c3);
            s50.Courses.Add(c3);
            s51.Courses.Add(c3);
            s52.Courses.Add(c3);
            s53.Courses.Add(c3);
            s54.Courses.Add(c3);
            s55.Courses.Add(c3);
            s56.Courses.Add(c3);
            s57.Courses.Add(c3);
            s58.Courses.Add(c3);
            s59.Courses.Add(c3);
            s60.Courses.Add(c3);
            Course c4 = new Course(4, "Java", CourseStreamEnum.CB8, CourseTypeEnums.PartTime, new DateTime(2019, 1, 1), new DateTime(2019, 3, 31));
         
            c4.Students = new List<Student>() { s61,s62,s63,s64,s65,s66,s67,s68,s69,s70,s71,s72,s73,s74,s75,s76,s77,s78,s79,s80};
            s61.Courses.Add(c4);
            s62.Courses.Add(c4);
            s63.Courses.Add(c4);
            s64.Courses.Add(c4);
            s65.Courses.Add(c4);
            s66.Courses.Add(c4);
            s67.Courses.Add(c4);
            s68.Courses.Add(c4);
            s69.Courses.Add(c4);
            s70.Courses.Add(c4);
            s71.Courses.Add(c4);
            s72.Courses.Add(c4);
            s73.Courses.Add(c4);
            s74.Courses.Add(c4);
            s75.Courses.Add(c4);
            s76.Courses.Add(c4);
            s77.Courses.Add(c4);
            s78.Courses.Add(c4);
            s79.Courses.Add(c4);
            s80.Courses.Add(c4);

            s1.Courses.Add(c4);
            s13.Courses.Add(c3);
            s22.Courses.Add(c2);
            s67.Courses.Add(c1);
            s24.Courses.Add(c4);
            s21.Courses.Add(c4);
            #endregion
            #region Seeding Trainers

            Trainer t1 = new Trainer(1, "Bethany", "Scott", "C#");
            TrainersToCourses.Pair(t1, c1);

            Trainer t2 = new Trainer(2, "Philip", "Gibbs", "C#");
            TrainersToCourses.Pair(t2, c1);

            Trainer t3 = new Trainer(3, "Morgan", "Simpson", "C#");
            TrainersToCourses.Pair(t3, c2);

            Trainer t4 = new Trainer(4, "Clare", "Hill", "C#");
            TrainersToCourses.Pair(t4, c2);

            Trainer t5 = new Trainer(5, "Jacey", "Campos", "Java");
            TrainersToCourses.Pair(t5, c3);

            Trainer t6 = new Trainer(6, "Jordon", "Lawson", "Java");
            TrainersToCourses.Pair(t6, c3);

            Trainer t7 = new Trainer(7, "Jerome", "Mccann", "Java");
            TrainersToCourses.Pair(t7, c4);

            Trainer t8 = new Trainer(8, "Andreas", "Blackwell", "Java");
            TrainersToCourses.Pair(t8, c4);

            #endregion
            #region Seeding Assignments
            Assignment a1 = new Assignment(1,"Assignment 1", "Design of a private school structure", new DateTime(2019, 1, 16),70, 80);
             Assignment a2 = new Assignment(2,"Assignment 2", "Design of a public school structure", new DateTime(2019, 2, 1), 75, 85);
            Assignment a3 = new Assignment(3, "Assignment 3", "Design of a streaming service", new DateTime(2019, 2, 16), 72, 80);
            Assignment a4 = new Assignment(4, "Assignment 4", "Design of a website", new DateTime(2019, 2, 28), 56, 89);
            Assignment a5 = new Assignment(5, "Assignment 5", "Design of a dating app", new DateTime(2019, 3, 1), 90, 95);
            Assignment a6 = new Assignment(6, "Project 1", "Design of a game platform", new DateTime(2019, 3, 1), 76, 81);
            Assignment a7 = new Assignment(7, "Project 2", "Design of a social media app", new DateTime(2019, 3, 31), 81, 89);
            
            AssignmentsToCourses.Pair(a1, c1);
            AssignmentsToCourses.Pair(a2, c1);
            AssignmentsToCourses.Pair(a3, c1);
            AssignmentsToCourses.Pair(a4, c1);
            AssignmentsToCourses.Pair(a5, c1);
            AssignmentsToCourses.Pair(a6, c1);
            AssignmentsToCourses.Pair(a7, c1);

            Assignment a8 = new Assignment(8, "Assignment 1", "Design of a coding bootcamp structure", new DateTime(2019, 1, 16), 73, 82);
            Assignment a9 = new Assignment(9, "Assignment 2", "Design of a diving structure", new DateTime(2019, 2, 15), 71, 76);
            Assignment a10 = new Assignment(10, "Assignment 3", "Design of a game streaming service", new DateTime(2019, 2, 16), 77, 81);
            Assignment a11 = new Assignment(11, "Assignment 4", "Design of a photo sharing app", new DateTime(2019, 3, 1), 56, 62);
            Assignment a12 = new Assignment(12, "Assignment 5", "Design of an online office suite", new DateTime(2019, 3, 30), 66, 68);
            Assignment a13 = new Assignment(13, "Project 1", "Design of a video streaming service", new DateTime(2019, 4, 28), 72, 80);
            Assignment a14 = new Assignment(14, "Project 2", "Design of a bibliographic database", new DateTime(2019, 6, 30), 81, 89);
           
            AssignmentsToCourses.Pair(a8, c2);
            AssignmentsToCourses.Pair(a9, c2);
            AssignmentsToCourses.Pair(a10, c2);
            AssignmentsToCourses.Pair(a11, c2);
            AssignmentsToCourses.Pair(a12, c2);
            AssignmentsToCourses.Pair(a13, c2);
            AssignmentsToCourses.Pair(a14, c2);

            Assignment a15 = new Assignment(15, "Assignment 1", "Design of a web calendar", new DateTime(2019, 1, 16), 55, 60);
            Assignment a16 = new Assignment(16, "Assignment 2", "Design of an online file editing", new DateTime(2019, 2, 1), 66, 89);
            Assignment a17 = new Assignment(17, "Assignment 3", "Design of a mapping app", new DateTime(2019, 2, 16), 87, 94);
            Assignment a18 = new Assignment(18, "Assignment 4", "Design of a blog", new DateTime(2019, 2, 28), 53, 65);
            Assignment a19 = new Assignment(19, "Assignment 5", "Design of a parking app", new DateTime(2019, 3, 1), 83, 88);
            Assignment a20 = new Assignment(20, "Project 1", "Design of a publication management app", new DateTime(2019, 3, 1), 72, 80);
            Assignment a21 = new Assignment(21, "Project 2", "Design of a web mail service", new DateTime(2019, 3, 31), 81, 93);
           
            AssignmentsToCourses.Pair(a15, c3);
            AssignmentsToCourses.Pair(a16, c3);
            AssignmentsToCourses.Pair(a17, c3);
            AssignmentsToCourses.Pair(a18, c3);
            AssignmentsToCourses.Pair(a19, c3);
            AssignmentsToCourses.Pair(a20, c3);
            AssignmentsToCourses.Pair(a21, c3);

            Assignment a22 = new Assignment(22, "Assignment 1", "Design of a forum", new DateTime(2019, 1, 16), 72, 84);
            Assignment a23 = new Assignment(23, "Assignment 2", "Design of a mailing lists app", new DateTime(2019, 2, 15), 73, 79);
            Assignment a24 = new Assignment(24, "Assignment 3", "Design of an RSS reader", new DateTime(2019, 2, 16), 78, 98);
            Assignment a25 = new Assignment(25, "Assignment 4", "Design of a web chat", new DateTime(2019, 3, 1), 56, 65);
            Assignment a26 = new Assignment(26, "Assignment 5", "Design of a virtual world app", new DateTime(2019, 3, 30), 68, 79);
            Assignment a27 = new Assignment(27, "Project 1", "Design of a password manager", new DateTime(2019, 4, 30), 76, 87);
            Assignment a28 = new Assignment(28, "Project 2", "Design of a translation app", new DateTime(2019, 6, 30), 90, 99);
         
            AssignmentsToCourses.Pair(a22, c4);
            AssignmentsToCourses.Pair(a23, c4);
            AssignmentsToCourses.Pair(a24, c4);
            AssignmentsToCourses.Pair(a25, c4);
            AssignmentsToCourses.Pair(a26, c4);
            AssignmentsToCourses.Pair(a27, c4);
            AssignmentsToCourses.Pair(a28, c4);

            #endregion
            #region Populate Lists
            List<Course> courses = new List<Course>() {c1,c2,c3,c4};
            Courses.AddRange(courses);
            List<Student> students = new List<Student>() { s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15, s17, s17, s18, s19, s20, s21, s22, s23, s24, s25, s26, s27, s28, s29, s30, s31, s32, s33, s34, s35, s36, s37, s38, s39, s40, s41, s42, s43, s44, s45, s46, s47, s48, s49, s50, s51, s52, s53, s54, s55, s56, s57, s58, s59, s60, s61, s62, s63, s64, s65, s66, s67, s68, s69, s70, s71, s72, s73, s74, s75, s76, s77, s78, s79, s80 };
            Students.AddRange(students);
            List<Trainer> trainers = new List<Trainer>() { t1, t2, t3, t4, t5, t6, t7, t8 };
            Trainers.AddRange(trainers);
            List<Assignment> assignments = new List<Assignment>() { a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21, a22, a23, a24, a25, a26, a27, a28 };
            Assignments.AddRange(assignments);
            #endregion
        }

    }
}
