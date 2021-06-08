using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Traveltech.Models
{
    public class Menu
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        public string Link { get; set; }

        public int? HeaderId { get; set; }
        [JsonIgnore]
        public Header Header { get; set; }

        public int? FooterId { get; set; }
        [JsonIgnore]
        public Footer Footer { get; set; }

        public int? PositionId { get; set; }
        [JsonIgnore]
        public Position Position { get; set; }

        public IList<MenuItem> MenuItems { get; set; }
    }
}
