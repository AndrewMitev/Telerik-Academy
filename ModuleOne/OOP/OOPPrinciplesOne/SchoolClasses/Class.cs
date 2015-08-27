using System;
using System.Collections.Generic;

namespace SchoolClasses
{
    class Class
    {
        private string identifier;

        private List<Teacher> teachers;

        private List<Student> students;

        private string comments;

        public Class(string identifier, List<Teacher> teachers,List<Student> students, string comments = null)
        {
            this.Identifier = identifier;
            this.Teachers = teachers;
            this.Students = students;
            this.Comments = comments;
        }

        public List<Student> Students { set; get; }

        public string Identifier
        {
            get
            {
                return this.identifier;
            }
            set
            {
                this.identifier = value;
            }
        }

        public List<Teacher> Teachers
        {
            get
            {
                return this.teachers;
            }
            set
            {
                this.teachers = value;
            }
        }

        public string Comments
        {
            get
            {
                return this.comments;
            }
            set
            {
                this.comments = value;
            }
        }
    }
}
