using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarsSearch.Models
{
    public class Producer
    {
        public Producer(string name, ICollection<Model> models)
        {
            this.Name = name;
            this.Models = models;
        }

        public string Name { get; set; } = "Megatron";

        public ICollection<Model> Models = new List<Model>();
    }
}