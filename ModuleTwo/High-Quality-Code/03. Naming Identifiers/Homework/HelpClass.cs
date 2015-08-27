internal class HelpClass
{
    internal enum Gender
    {
        Male,
        Female
    }

    public void MakeHuman(int age)
    {
        Human somePerson = new Human();

        somePerson.Age = age;

        if (age % 2 == 0)
        {
            somePerson.Name = "Батката";
            somePerson.Gender = Gender.Male;
        }
        else
        {
            somePerson.Name = "Мацето";
            somePerson.Gender = Gender.Female;
        }
    }

    internal class Human
    {
        public Gender Gender { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }
    }
}