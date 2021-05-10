using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Traveltech.Models.Widgets;

namespace Traveltech.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string HouseNr { get; set; }
        public string ZipCode { get; set; }

        public int? CityId { get; set; }
        [JsonIgnore]
        public City City { get; set; }

        public int? StateId { get; set; }
        [JsonIgnore]
        public State State { get; set; }

        public int? LandId { get; set; }
        [JsonIgnore]
        public Land Land { get; set; }

        public int? ContactId { get; set; }
        [JsonIgnore]
        public Contact Contact { get; set; }
    }
}
