using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Traveltech.Models
{
    public class MenuItem : Menu
    {
        public int? MenuId { get; set; }
        [JsonIgnore]
        public Menu Parent { get; set; }
    }
}
