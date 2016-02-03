namespace Countries.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Country
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public string Language { get; set; }

        public int Population { get; set; }

        public int ContinentId { get; set; }

        public virtual Continent Continent { get; set; }
    }
}