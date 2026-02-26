using System;

namespace StudentAttendanceAPI.Models
{
    public class Attendance
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public User Student { get; set; }
        public int ClassId { get; set; }
        public Class Class { get; set; }
        public DateTime AttendanceDate { get; set; }
        public AttendanceStatus Status { get; set; }
        public string Remarks { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

    public enum AttendanceStatus
    {
        Present,
        Absent,
        Late,
        ExcusedAbsence
    }
}