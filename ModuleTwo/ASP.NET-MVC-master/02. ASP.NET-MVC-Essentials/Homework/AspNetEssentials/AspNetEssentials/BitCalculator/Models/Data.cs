namespace BitCalculator.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Numerics;
    using System.Web.Mvc;

    public class Data
    {
        public IEnumerable<SelectListItem> data { get; set; } 

        public double Quantity { get; set; }

        [Display(Name = "Kilo")]
        public int Base { get; set; }

        public string Type { get; set; }

        public ICollection<Helper> dataToDisplay { get; set; }
    }
}