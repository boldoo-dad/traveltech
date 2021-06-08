using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Traveltech.Models
{
    public class Category
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
        public string Text { get; set; } //html visual editor needed
        public IList<Post> Posts { get; set; }
    }
}
