
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Traveltech.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int? ClientId { get; set; }
        [JsonIgnore]
        public Client Client { get; set; }
    }
}
