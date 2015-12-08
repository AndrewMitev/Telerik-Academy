namespace StudentSystem.WebServices.RequestModels
{
    using Models;
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq.Expressions;

    public class CourseRequestModel
    {
        public static Expression<Func<Course, CourseRequestModel>> FromModel {
            get
            {
                return c => new CourseRequestModel
                {
                    Name = c.Name,
                    Description = c.Description
                };
            }
                
        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}