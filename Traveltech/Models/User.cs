
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Traveltech.Models
{
    public class User
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string FirstName { get; set; }
        [StringLength(100)]
        public string LastName { get; set; }

        public int? WebSiteId { get; set; }
        [JsonIgnore]
        public WebSite WebSite { get; set; }
        public int? ClientId { get; set; }
        [JsonIgnore]
        public Client Client { get; set; }
    }
}
