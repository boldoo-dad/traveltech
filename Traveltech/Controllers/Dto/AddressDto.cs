using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traveltech.Controllers.Dto
{
    public class AddressDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string HouseNr { get; set; }
        public string ZipCode { get; set; }


        public int? CityId { get; set; }
        public int? StateId { get; set; }
        public int? LandId { get; set; }
        public int? ContactId { get; set; }
    }
}
