using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Traveltech.Models
{
    public class Section
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        public int? PageId { get; set; }
        [JsonIgnore]
        public Page Page { get; set; }
        public int? HomePageId { get; set; }
        [JsonIgnore]
        public HomePage HomePage { get; set; }
    }
}
