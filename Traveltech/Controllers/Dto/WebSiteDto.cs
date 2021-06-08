using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Traveltech.Controllers.Dto
{
    public class WebSiteDto
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

        public int? DateFormatId { get; set; }


        public int? TimeFormatId { get; set; }

        public int? HeaderId { get; set; }

        public int? FooterId { get; set; }

        public int? ClientId { get; set; }

        public IList<UserDto> Users { get; set; }
    }
}
