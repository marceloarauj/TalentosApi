using System.Collections.Generic;
using api.Models.EntityModel.Searches;
using Newtonsoft.Json;

namespace api.Models.EntityModel.Sports
{
    public class Sport
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [JsonIgnore]
        public IEnumerable<Search> Searches { get; set; }
    }
}