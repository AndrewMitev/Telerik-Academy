using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace StudentClass
{
    class Student : ICloneable, IComparable
    {
        #region properties
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public ulong SSN { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public MailAddress Email { get; set; }
        public int Course { get; set; }
        public _University University { get; set; }
        public _Faculty Faculty { get; set; }
        public _Specialty Speciality { get; set; }
        #endregion

        public Student(string firstName, string middleName, string lastName, ulong ssn, string address, string phone, MailAddress email, int course, _University university, _Faculty faculty, _Specialty speciality)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.Course = course;
            this.University = university;
            this.Faculty = faculty;
            this.Speciality = speciality;
        }

        public override bool Equals(object obj)
        {
            if (!this.FirstName.Equals((obj as Student).FirstName)) return false;
            if (!this.MiddleName.Equals((obj as Student).MiddleName)) return false;
            if (!this.LastName.Equals((obj as Student).LastName)) return false;
            if (!this.SSN.Equals((obj as Student).SSN)) return false;
            if (!this.Address.Equals((obj as Student).Address)) return false;
            if (!this.Phone.Equals((obj as Student).Phone)) return false;
            if (!this.Email.Equals((obj as Student).Email)) return false;
            if (!this.Faculty.Equals((obj as Student).Faculty)) return false;
            if (!this.Course.Equals((obj as Student).Course)) return false;
            if (!this.University.Equals((obj as Student).University)) return false;
            if (!this.Speciality.Equals((obj as Student).Speciality)) return false;

            return true;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2}", this.FirstName, this.MiddleName, this.LastName);
        }

        public override int GetHashCode()
        {
            int hash = 3 * this.Course;

            hash *= (int)this.SSN;

            return hash;
        }

        public static bool operator ==(Student one, Student two)
        {
            return one.Equals(two);
        }

        public static bool operator !=(Student one, Student two)
        {
            return !one.Equals(two);
        }

        public object Clone()
        {
            Student temp = new Student(
                this.FirstName, this.MiddleName, this.LastName,
                this.SSN, this.Address, this.Phone, this.Email,
                this.Course, this.University,this.Faculty, this.Speciality 
                );

            return temp;
        }

        public int CompareTo(object obj)
        {
            if (this.FirstName.CompareTo((obj as Student).FirstName) != 0)
            {
                return this.FirstName.CompareTo((obj as Student).FirstName);
            }

            if (this.MiddleName.CompareTo((obj as Student).MiddleName) != 0)
            {
                return this.MiddleName.CompareTo((obj as Student).MiddleName);
            }

            if (this.LastName.CompareTo((obj as Student).LastName) != 0)
            {
                return this.LastName.CompareTo((obj as Student).LastName);
            }

            if (this.SSN.CompareTo((obj as Student).SSN) != 0)
            {
                return this.SSN.CompareTo((obj as Student).SSN);
            }

            return 0;
        }
    }

    #region enums
    public enum _Specialty
    {
        IT,
        Mathematics,
        Physics,
        Economics
    }

    public enum _University
    {
        SofiaUniversity,
        TechnicalUniversity,
        UNWE,
        NBU
    }

    public enum _Faculty
    {
        Mathematics,
        Economy,
        Physics
    }
    #endregion  
}
