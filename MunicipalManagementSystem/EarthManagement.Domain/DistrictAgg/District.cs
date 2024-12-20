using _0_Framework.Domain;
using EarthManagement.Domain.ParishAgg;
using EarthManagement.Domain.RegionAgg;
using System;
using System.Collections.Generic;
using System.Text;

namespace EarthManagement.Domain.DistrictAgg
{
   public class District:EntityBase
    {
        public string Name { get; private set; }
        public  int RegionId  { get;private set; }
        public Region Region { get; set; }
        public List<Parish> Parishs { get; set; }
    }
}
