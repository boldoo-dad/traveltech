
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Traveltech.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? StateId { get; set; }
        [JsonIgnore]
        public State State { get; set; }
    }
}
