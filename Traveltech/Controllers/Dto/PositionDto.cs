using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traveltech.Controllers.Dto
{
    public class PositionDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<PositionDto> Positions { get; set; }
    }
}
