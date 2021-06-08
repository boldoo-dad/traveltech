using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Traveltech.Models.Widgets
{
    public class Contact
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
        public string Description { get; set; } //html visual editor needed


        public IList<Address> Addresses { get; set; }
    }
}
