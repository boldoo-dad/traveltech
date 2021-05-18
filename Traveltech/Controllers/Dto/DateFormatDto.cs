using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traveltech.Controllers.Dto
{
    public class DateFormatDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<WebSiteDto> WebSites { get; set; }
    }
}
