using System.ComponentModel.DataAnnotations.Schema;

namespace StudentsInformation.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Name { get; set; }
        public string LecturerName { get; set; }


        public ICollection<Student> Students { get; set; }
    }
}
