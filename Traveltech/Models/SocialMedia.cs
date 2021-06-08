using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Traveltech.Models
{
    public class SocialMedia
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
        public int? SumbolId { get; set; }
        [JsonIgnore]
        public Sumbol Sumbol { get; set; }
        public string Link { get; set; }
        public string AccessToken { get; set; }
    }
}
