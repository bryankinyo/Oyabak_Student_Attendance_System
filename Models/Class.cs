using System;
using System.Collections.Generic;

namespace StudentAttendanceAPI.Models
{
    public class Class
    {
        public int Id { get; set; }
        public string ClassName { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public int FacultyId { get; set; }
        public User Faculty { get; set; }
        public string Room { get; set; }
        public string Schedule { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public ICollection<StudentClass> StudentClasses { get; set; }
        public ICollection<Attendance> Attendances { get; set; }
    }
}