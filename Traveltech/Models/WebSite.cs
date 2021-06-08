using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Traveltech.Models
{
    public class WebSite
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
        public string Logo { get; set; }
        public string TagLine { get; set; }
        public string Url { get; set; }
        [StringLength(100)]
        public string Domain { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        public bool? Membership { get; set; }

        public int? LanguageId { get; set; }
        [JsonIgnore]
        public Language Language { get; set; }

        public int? DateFormatId { get; set; }
        [JsonIgnore]
        public DateFormat DateFormat { get; set; }


        public int? TimeFormatId { get; set; }
        [JsonIgnore]
        public TimeFormat TimeFormat { get; set; }
        [ForeignKey("Header")]
        public int? HeaderId { get; set; }
        [JsonIgnore]
        public Header Header { get; set; }

        [ForeignKey("Footer")]
        public int? FooterId { get; set; }
        [JsonIgnore]
        public Footer Footer { get; set; }

        public int? ClientId { get; set; }
        [JsonIgnore]
        public Client Client { get; set; }

        public IList<User> Users { get; set; }
    }
}
