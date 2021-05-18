using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traveltech.Controllers.Dto
{
    public class LanguageDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<WebSiteDto> Websites { get; set; }
    }
}
