using System;
using Newtonsoft.Json;

namespace Empleado.Models
{
    public class Job
    {
        [JsonProperty("Id")]
        public string Id { get; set; }

        [JsonProperty("Title")]
        public string Title { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("Location")]
        public string Location { get; set; }

        [JsonProperty("IsRemote")]
        public bool IsRemote { get; set; }

        [JsonProperty("VisitCount")]
        public int VisitCount { get; set; }

        [JsonProperty("Category")]
        public string Category { get; set; }

        [JsonProperty("Company")]
        public string Company { get; set; }
    }
}
