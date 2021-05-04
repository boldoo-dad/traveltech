using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traveltech.Controllers.Dto
{
    public class PageDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Author { get; set; }
        public string Email { get; set; }
        public string Slug { get; set; }
        public bool? isTemplate { get; set; }
        public bool? isPublished { get; set; }
        public bool? isAllowedComment { get; set; }
        public int? Order { get; set; }
        public string CreatedDate { get; set; }
        public string PublishedDate { get; set; }
        public string ArchiedDate { get; set; }

        public IList<SectionDto> Sections { get; set; }
    }
}
