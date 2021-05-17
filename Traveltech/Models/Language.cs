using System;
using System.Collections.Generic;
using System.Text;

namespace Traveltech.Models
{
    public class Language
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<WebSite> Websites { get; set; }
    }
}
