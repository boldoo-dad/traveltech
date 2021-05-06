using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traveltech.Controllers.Dto
{
    public class HomePageDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }

        public IList<SectionDto> Sections { get; set; }
    }
}
