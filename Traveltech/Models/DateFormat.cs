using System;
using System.Collections.Generic;
using System.Text;

namespace Traveltech.Models
{
    public class DateFormat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<WebSite> WebSites { get; set; }
    }
}
