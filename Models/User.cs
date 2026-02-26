using System;
using System.Collections.Generic;

namespace StudentAttendanceAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string PhoneNumber { get; set; }
        public UserRole Role { get; set; } // Student, Faculty, Admin
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

    public enum UserRole
    {
        Student,
        Faculty,
        Admin
    }
}