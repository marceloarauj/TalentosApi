using System.Collections.Generic;
using api.Models.EntityModel.Searches;

namespace api.Models.EntityModel.Users
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Graduation { get; set; }

        public string Email { get; set; }

        public string Title { get; set; }

        public double CarrearTime { get; set; }

        public string Expertise { get; set; }

        public string Dimention { get; set; }

        public IEnumerable<Search> Searches { get; set; }
    }
}