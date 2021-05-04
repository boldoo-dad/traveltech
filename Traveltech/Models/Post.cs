using System;
using System.Collections.Generic;
using System.Text;

namespace Traveltech.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; } //html visual editor needed
        public bool? IsPublished { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? PublishedDate { get; set; }
        public DateTime? ArchiedDate { get; set; }
        public IList<Category> Categories { get; set; }
    }
}
