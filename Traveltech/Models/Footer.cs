using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Traveltech.Models
{
    public class Footer
    {
        public int Id { get; set; }
        [ForeignKey("WebSite")]
        public int? WebSiteId { get; set; }
        [JsonIgnore]
        public WebSite WebSite { get; set; }
        public IList<Menu> Menus { get; set; }
    }
}
