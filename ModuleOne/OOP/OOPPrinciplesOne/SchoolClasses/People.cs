using System;

namespace SchoolClasses
{
    abstract class People
    {
        protected string name;

        public string Name { get; set; }

        public People(string n)
        {
            this.Name = n;
        }
    }
}
