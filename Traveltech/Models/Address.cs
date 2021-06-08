using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Traveltech.Models.Widgets;

namespace Traveltech.Models
{
    public class Address
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(100)]
        public string Street { get; set; }
        [StringLength(100)]
        public string HouseNr { get; set; }
        [StringLength(5)]
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
