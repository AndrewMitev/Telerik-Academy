namespace ConsumingWebServicesWithCSharp
{
    using System;

    public class Account
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public long World { get; set; }

        public string[] Guilds { get; set; }

        public string Created { get; set; }

        public override string ToString()
        {
            return string.Format(@"
                Id: {0},
                Name: {1},
                World: {2},
                Created: {3}
            ", this.Id, this.Name, this.World, this.Created);
        }
    }
}
