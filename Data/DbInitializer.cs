using StudentsInformation.Models;
using System.Diagnostics;

namespace StudentsInformation.Data
{
    public class DbInitializer
    {
        public static void Initialize(StudentsInformationContext context)
        {
            // Look for any students.
            if (context.Courses.Any())
            {
                return;   // DB has been seeded
            }

            var courses = new Course[]
            {
                new Course{CourseID=1,Name="Web Development",LecturerName="M.M. Herath"},
                new Course{CourseID=2,Name="Graphic Design",LecturerName="J.S.V. Piyasena"},
                new Course{CourseID=3,Name="Mobile App Development",LecturerName="K.K.S. Dias"},
                new Course{CourseID=4,Name="Java",LecturerName="U.H.S. Perera"},
            };

            context.Courses.AddRange(courses);
            context.SaveChanges();

            var students = new Student[]
            {
                new Student{Name="Kasun Gamage",City="Kandy",CourseID=2},
                new Student{Name="Daniel Sam",City="Jaffna",CourseID=3},
                new Student{Name="Hansi Silva",City="Colombo",CourseID=1},
                new Student{Name="Ranidu Herath",City="Matara",CourseID=3},
                new Student{Name="Praneeth Wijesinghe",City="Kandy",CourseID=4},
                new Student{Name="Nuwani Herath",City="Rathnapura",CourseID=1},
               
            };

            context.Students.AddRange(students);
            context.SaveChanges();
        }
    }
}
