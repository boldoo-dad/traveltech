using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Traveltech.Controllers.Dto
{
    public class AddressDto
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(100)]
        public string Street { get; set; }
        [StringLength(100)]
        public string HouseNr { get; set; }
        [StringLength(5)]
        public string ZipCode { get; set; }


        public int? CityId { get; set; }
        public int? StateId { get; set; }
        public int? LandId { get; set; }
        public int? ContactId { get; set; }
    }
}
