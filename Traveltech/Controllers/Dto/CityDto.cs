using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traveltech.Controllers.Dto
{
    public class CityDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? StateId { get; set; }
    }
}
