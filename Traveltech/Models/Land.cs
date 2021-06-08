using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Traveltech.Models
{
    public class Land
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        public IList<State> States { get; set; }
    }
}
