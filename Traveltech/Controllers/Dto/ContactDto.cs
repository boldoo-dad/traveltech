using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Traveltech.Controllers.Dto
{
    public class ContactDto
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
        public string Description { get; set; } //html visual editor needed


        public IList<AddressDto> Addresses { get; set; }
    }
}
