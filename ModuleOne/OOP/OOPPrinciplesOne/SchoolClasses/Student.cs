using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    internal class Student : People
    {

        private int classNumber;

        private string comment;

        private static List<int> takenNumbers;

        public string Comment { get; set; }

        public int ClassNumber {
            get
            {
                return this.classNumber;
            }

            set
            {
                if (!CheckIfTaken(value))
                {
                    this.ClassNumber = value;
                }
                else
                {
                    throw new TakenNumberException("Class number already taken.");
                }
            }
        }

        public Student(string n, int num, string comment = null) : base(n)
        {
            this.ClassNumber = num;

            this.comment = comment;
        }

        private static bool CheckIfTaken(int num)
        {
            if (takenNumbers.Contains(num))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
