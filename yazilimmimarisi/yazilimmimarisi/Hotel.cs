﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazilimmimarisi
{
    class Hotel : Accomodation
    {
        public BedType BedType { get; set; }
        //... other specific properties
       /* enum BedType
        {
            Single,
            Double,
            Triple
        }*/
    }
}
