namespace SchoolAdministration
{
    using System;
    using System.Collections.Generic;

    public class Course
    {
        private IList<Student> students;

        public Course() 
        {
            this.students = new List<Student>();
        }

        public void addStudent(Student student)
        {
            if (this.students.Count > 29)
            {
                throw new ArgumentOutOfRangeException("Course can have no more than 29 students!");
            }

            if (this.students.Contains(student))
            {
                throw new ArgumentException("Student is already attending this course!");
            }

            this.students.Add(student);
        }

        public void removeStudent(Student student)
        {
            if (!this.students.Contains(student))
            {
                throw new ArgumentException("Student is not attending this course.");
            }

            this.students.Remove(student);
        }


    }
}
