using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Traveltech.Models
{
    public class Page
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
        public string Text { get; set; }
        public string Author { get; set; }
        public string Email { get; set; }
        public string Slug { get; set; }
        public bool? isTemplate { get; set; }
        public bool? isPublished { get; set; }
        public bool? isAllowedComment { get; set; }
        public int? Order { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? PublishedDate { get; set; }
        public DateTime? ArchiedDate { get; set; }

        public IList<Section> Sections { get; set; }
    }
}
