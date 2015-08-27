using System;

namespace StudentsAndWorkers
{
    class Student : Human
    {

        public float Grade { set; get; }

        public Student(string firstname, string lastname, float grade)
            : base(firstname, lastname)
        {
            this.Grade = grade;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} : {2}", base.Firstname, base.Lastname, this.Grade);
        }
    }
}
