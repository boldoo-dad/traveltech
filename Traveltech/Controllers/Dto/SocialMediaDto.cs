using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Traveltech.Controllers.Dto
{
    public class SocialMediaDto
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
        public int? SumbolId { get; set; }
        public string Link { get; set; }
        public string AccessToken { get; set; }
    }
}
