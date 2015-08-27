using System;
using System.Collections.Generic;

namespace SchoolClasses
{
    class Teacher : People
    {
        private List<Discipline> disciplines;

        private string comment;

        public string Comment { get; set; }

        public List<Discipline> Disciplines { set; get; }

        public Teacher(string name, List<Discipline> disc, string comm = null)
            : base(name)
        {
            this.Disciplines = disc;
            this.Comment = comm;
        }
    }
}
