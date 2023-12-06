using System.Text.Json.Serialization;

namespace ServerToAngular.Models
{
    public class Gift
    {
        public int Id { get; set; }
        public string Name { get; set; }
      
        public Donor Donor { get; set; }
        public int Cost { get; set; } = 10;

        public string Description { get; set; }

        public string Image { get; set; }
        public Gift(int id, string name, Donor donor, int cost,string description,string image)
        {
            Id = id;
            Name = name;
            Donor = donor;
            Cost = cost;
            Description = description;
            Image = image;
        }
    }
}
