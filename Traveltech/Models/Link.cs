using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Traveltech.Models
{
    public class Link
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        public string Url { get; set; }
        public string Symbol { get; set; }
    }
}
