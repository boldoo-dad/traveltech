using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Traveltech.Models
{
    public class SocialMedia
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SymbolId { get; set; }
        [JsonIgnore]
        public Sumbol Sumbol { get; set; }
        public string Link { get; set; }
        public string AccessToken { get; set; }
    }
}
