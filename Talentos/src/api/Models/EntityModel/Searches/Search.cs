using Newtonsoft.Json;
using api.Models.EntityModel.Sports;
using api.Models.EntityModel.Users;

namespace api.Models.EntityModel.Searches
{
    public class Search
    {
        public int UserId { get; set; }

        [JsonIgnore]
        public User User { get; set; }

        public int SportId { get; set; }

        [JsonIgnore]
        public Sport Sport { get; set; }

        //Atributos Dermatoglifia
        public int Force { get; set; }

        public int Speed { get; set; }

        public int MotorCoordination { get; set; }

        public int Power { get; set; }

        public int Agility { get; set; }

        public int Hypertrophy { get; set; }

        public int Resistance { get; set; }

        //Atributos de Cineantropometria
        public int BodyHeight { get; set; }

        public int Height { get; set; }

        public int Wingspan { get; set; }
    }
}