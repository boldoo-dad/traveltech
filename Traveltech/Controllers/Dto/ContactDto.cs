using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traveltech.Controllers.Dto
{
    public class ContactDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; } //html visual editor needed


        public IList<AddressDto> Addresses { get; set; }
    }
}
