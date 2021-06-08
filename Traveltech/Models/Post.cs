using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Traveltech.Models
{
    public class Post
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
        public string Text { get; set; } //html visual editor needed
        public bool? IsPublished { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? PublishedDate { get; set; }
        public DateTime? ArchiedDate { get; set; }
        [JsonIgnore]
        public IList<Category> Categories { get; set; }
    }
}
