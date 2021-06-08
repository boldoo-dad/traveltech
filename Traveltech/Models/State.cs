using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Traveltech.Models
{
    public class State
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        public int? LandId { get; set; }
        [JsonIgnore]
        public Land Land { get; set; }

        public IList<City> Cities { get; set; }
    }
}
