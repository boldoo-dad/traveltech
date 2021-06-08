using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Traveltech.Controllers.Dto
{
    public class MenuItemDto
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        public string Link { get; set; }

        public int? HeaderId { get; set; }

        public int? FooterId { get; set; }

        public int? PositionId { get; set; }
        public int? MenuId { get; set; }
    }
}
