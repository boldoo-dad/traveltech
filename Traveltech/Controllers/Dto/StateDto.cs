using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traveltech.Controllers.Dto
{
    public class StateDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? LandId { get; set; }

        public IList<CityDto> Cities { get; set; }
    }
}
