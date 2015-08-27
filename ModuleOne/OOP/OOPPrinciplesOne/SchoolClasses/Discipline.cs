using System;

namespace SchoolClasses
{
    class Discipline
    {
        private string name;

        private int numberLextures;

        private int numberExercises;

        private string comments;

        public Discipline(string name, int numberLextures, int numberExercises, string comm = null)
        {
            this.name = name;
            this.numberLextures = numberLextures;
            this.numberExercises = numberExercises;
            this.Comments = comm;
        }

        public string Comments { get; set; }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int NumberLextures
        {
            get
            {
                return this.numberLextures;
            }
            set
            {
                this.numberLextures = value;
            }
        }

        public int NumberExercises
        {
            get
            {
                return this.numberExercises;
            }
            set
            {
                this.numberExercises = value;
            }
        }
    }
}
