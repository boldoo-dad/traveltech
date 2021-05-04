using System;
using System.Collections.Generic;
using System.Text;

namespace Traveltech.Models
{
    public class Land
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<State> States { get; set; }
    }
}
