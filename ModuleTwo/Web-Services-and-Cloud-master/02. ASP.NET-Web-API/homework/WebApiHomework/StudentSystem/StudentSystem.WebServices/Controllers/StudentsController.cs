namespace StudentSystem.WebServices.Controllers
{
    using System.Web.Http;
    using Data;
    using System.Linq;
    using Models;
    using Data.Repositories;
    using RequestModels;

    public class StudentsController : ApiController
    {
        private readonly IGenericRepository<Student> studentData;

        public StudentsController()
        {
            var dbContext = new StudentSystemDbContext();
            this.studentData = new GenericRepository<Student>(dbContext);
        }

        public IHttpActionResult Get()
        {
            var allStudents = this.studentData
                .All()
                .ToList();

            return this.Ok(allStudents);
        }

        public IHttpActionResult Post(StudentRequestModel requestStudent)
        {
            this.studentData.Add(new Student() {
                FirstName = requestStudent.FirstName,
                LastName = requestStudent.LastName,
                Level = requestStudent.Level
            });

            this.studentData.SaveChanges();

            return this.Ok(string.Format("student {0} added.", requestStudent.FirstName));
        }

        public IHttpActionResult Put(int id, int level)
        {
            var student = this.studentData
                .All()
                .FirstOrDefault(x => x.StudentIdentification == id);

            student.Level = level;

            this.studentData.Update(student);

            this.studentData.SaveChanges();

            return this.Ok(string.Format("Student with id: {0} updated!", id));
        }

        public IHttpActionResult Delete(int id)
        {
            var student = this.studentData
                .All()
                .FirstOrDefault(x => x.StudentIdentification == id);

            this.studentData.Delete(student);

            this.studentData.SaveChanges();

            return this.Ok("Successfully removed.");
        }
    }
}