namespace AjaxHomework.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Human
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Range(18, 65)]
        public short Age { get; set; }

        public string Studio { get; set; }

        public string StudioAddress { get; set; }

        public bool isMale { get; set; }
    }
}