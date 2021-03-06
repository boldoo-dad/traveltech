using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Traveltech.Controllers.Dto
{
    public class LandDto
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        public IList<StateDto> States { get; set; }
    }
}
