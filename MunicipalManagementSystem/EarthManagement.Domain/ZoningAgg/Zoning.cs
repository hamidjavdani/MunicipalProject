using _0_Framework.Domain;
using EarthManagement.Domain.MelkZoningAgg;
using System;
using System.Collections.Generic;
using System.Text;

namespace EarthManagement.Domain.ZoningAgg
{
   public class Zoning:EntityBase
    {
        public string Name { get;private set; }
        public List<MelkZoning> MelkZonings { get;private set; }
    }
}
