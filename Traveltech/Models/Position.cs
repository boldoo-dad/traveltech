using System;
using System.Collections.Generic;
using System.Text;

namespace Traveltech.Models
{
    public class Position
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Position> Positions { get; set; }
    }
}
