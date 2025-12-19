using System.Collections.Generic;

namespace WebAppMVC.Models
{
    public class CourseParticipantsViewModel
    {
        public Course? Course { get; set; }
        public List<Student> AllStudents { get; set; } = new List<Student>();
        public List<int> SelectedStudentIds { get; set; } = new List<int>();
    }
}
