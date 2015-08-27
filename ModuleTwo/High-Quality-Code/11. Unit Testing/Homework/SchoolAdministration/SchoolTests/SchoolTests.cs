namespace SchoolTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SchoolAdministration;

    [TestClass]
    public class SchoolTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestStudentWithEmptyName()
        {
            var name = "";
            var id = 99999;

            Student invalidNameStudent = new Student(name, id);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestStudentWithTooShortId()
        {
            var name = "Ivancho";
            var id = 213;

            Student invalidIdStudent = new Student(name, id);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestAddSameStudentTwice()
        {
            Course english = new Course();
            Student ivan = new Student("Ivan", 21355);

            ivan.attendCourse(english);
            ivan.attendCourse(english);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRemoveStudentWhoDoesntAttendCourse()
        {
            Course english = new Course();
            Student ivan = new Student("Ivan", 21355);

            ivan.disengageCourse(english);
        }
    }
}
