using System.ComponentModel.DataAnnotations;

namespace Countries.Models
{
    public class Continent
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = "Asia";
    }
}