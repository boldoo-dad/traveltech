using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Traveltech.Controllers.Dto
{
    public class SectionDto
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        public int? PageId { get; set; }
        public int? HomePageId { get; set; }
    }
}
