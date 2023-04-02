namespace Hackathon_Project2.Models
{
    public class PlayerModel
    {

        public string? Id { get; set; }
        public string Name { get; set; }

        public List<string> films { get; set; }

        public int Health { get; set; } // for later
    }
}
