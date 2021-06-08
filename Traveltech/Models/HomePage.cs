using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Traveltech.Models
{
    public class HomePage
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
        public string Text { get; set; }

        public IList<Section> Sections { get; set; }
    }
}
