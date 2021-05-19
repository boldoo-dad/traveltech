using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traveltech.Controllers.Dto
{
    public class HeaderDto
    {
        public int Id { get; set; }
        public int? WebSiteId { get; set; }

        public IList<MenuDto> Menus { get; set; }
    }
}
