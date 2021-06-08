using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Traveltech.Models
{
    public class Sumbol
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        public string Link { get; set; }
        [StringLength(1024)]
        public string Description { get; set; }
    }
}
