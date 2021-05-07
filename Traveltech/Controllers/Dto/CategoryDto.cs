using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traveltech.Controllers.Dto
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; } //html visual editor needed
        public IList<PostDto> Posts { get; set; }
    }
}
