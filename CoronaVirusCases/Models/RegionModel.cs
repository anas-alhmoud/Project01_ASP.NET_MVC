﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaVirusCases.Models
{
    public class RegionModel
    {
        public string Id { get; set; }
        public int TotalConfirmed { get; set; }
        public int NewConfirmed { get; set; }
        public int TotalRecovered { get; set; }
        public int NewRecovered { get; set; }
        public int TotalDeaths { get; set; }
        public int NewDeaths { get; set; }
        public string CountryCode { get; set; }
    }
}
