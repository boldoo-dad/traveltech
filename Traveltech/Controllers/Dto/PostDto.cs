using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Traveltech.Controllers.Dto
{
    public class PostDto
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
        public string Text { get; set; } //html visual editor needed
        public bool? IsPublished { get; set; }
        public string CreatedDate { get; set; }
        public string PublishedDate { get; set; }
        public string ArchiedDate { get; set; }
    }
}
