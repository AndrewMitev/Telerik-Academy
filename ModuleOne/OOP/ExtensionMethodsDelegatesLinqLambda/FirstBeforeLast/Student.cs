using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstBeforeLast
{
    class Student
    {
        private string firstName;

        private string lastName;

        private sbyte age;

        public string FirstName { set; get; }

        public string LastName { set; get; }

        public sbyte Age { set; get; }

        public Student(string fName, string lName)
        {
            this.FirstName = fName;

            this.LastName = lName;

            this.Age = 0;
        }

        public Student(string fName, string lName, sbyte a)
        {
            this.FirstName = fName;

            this.LastName = lName;

            this.Age = a;
        }

        public override string ToString()
        {
            return String.Format("{0} {1}", this.FirstName, this.LastName);
        }
    }
}
