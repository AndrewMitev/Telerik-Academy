namespace StudentSystem.WebServices.Controllers
{
    using Data;
    using Data.Repositories;
    using Models;
    using RequestModels;
    using System.Web.Http;
    using System.Linq;
    using System;

    public class CourseController : ApiController
    {
        private readonly IGenericRepository<Course> courseData;

        public CourseController(IGenericRepository<Course> repo)
        {
            this.courseData = repo;
        }

        public IHttpActionResult Get()
        {
            var courses = this.courseData
                .All()
                .Select(CourseRequestModel.FromModel)
                .ToList();

            return this.Ok(courses);
        }

        public IHttpActionResult Post(CourseRequestModel requestModel)
        {
            var newCourse = new Course()
            {
                Name = requestModel.Name,
                Description = requestModel.Description
            };

            this.courseData.Add(newCourse);

            this.courseData.SaveChanges();

            return this.Ok();
        }

        public IHttpActionResult Put(CourseRequestModel updateCourseInfo)
        {
            var selectedCourse = this.courseData
                .All()
                .FirstOrDefault(x => x.Id == updateCourseInfo.Id);

            selectedCourse.Name = updateCourseInfo.Name;
            selectedCourse.Description = updateCourseInfo.Description;

            this.courseData.Update(selectedCourse);

            this.courseData.SaveChanges();

            return this.Ok();
        }

        public IHttpActionResult Delete(string id)
        {
            var selectedCourse = this.courseData
           .All()
           .FirstOrDefault(x => x.Id == Guid.Parse(id));

            this.courseData.Delete(selectedCourse);

            this.courseData.SaveChanges();

            return this.Ok();
        }
    }
}