namespace SchoolAdministration
{
    using System;

    public class Student
    {
        private string name;
        private int id;

        public Student(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }

        public string Name {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty!");
                }

                this.name = value;
            }
        }

        public int Id
        {
            get
            {
                return this.id;
            }

            set
            {
                if (value < 10000 || value > 99999)
                {
                    throw new ArgumentException("Id must be between 10000 and 99999 inclusive.");
                }

                this.id = value;
            }
        }

        public void attendCourse(Course course)
        {
            course.addStudent(this);
        }

        public void disengageCourse(Course course)
        {
            course.removeStudent(this);
        }
    }
}
