using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazilimmimarisi
{
   abstract class Transportation
    {
        public Firm Firm { get; set; }
        public decimal Price { get; set; }
        public int Capacity { get; set; }
        public TravelInfo Travel { get; set; }
    }
}
