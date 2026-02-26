using System;

namespace StudentAttendanceAPI.Models {
    public class StudentClass {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public User Student { get; set; }
        public int ClassId { get; set; }
        public Class Class { get; set; }
        public DateTime EnrolledAt { get; set; }
        public bool IsActive { get; set; }
    }
}