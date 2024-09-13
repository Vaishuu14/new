﻿namespace StudentManagment.Models
{
    public class Course
    {

        public int Id { get; set; }
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public int Credits { get; set; }

        public ICollection<Entrollment>? Entrollments { get; set; }

    }
}
