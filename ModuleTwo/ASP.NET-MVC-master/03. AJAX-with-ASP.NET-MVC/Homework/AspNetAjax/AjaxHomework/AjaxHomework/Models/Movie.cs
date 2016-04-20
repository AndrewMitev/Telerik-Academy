namespace AjaxHomework.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Director { get; set; }

        [Required]
        public short Year { get; set; }

        public Human LeadingMaleRole { get; set; }

        public Human LeadingFemaleRole { get; set; }
    }
}