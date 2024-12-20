using _0_Framework.Domain;
using EarthManagement.Domain.CityAgg;
using EarthManagement.Domain.DistrictAgg;
using System;
using System.Collections.Generic;
using System.Text;

namespace EarthManagement.Domain.RegionAgg
{
    public class Region:EntityBase
    {
        public string  Name { get;private set; }        
        public double Area { get; private set; }
        public int CityId { get; private set; }
        public City City { get; set; }
        public List<District> Districts { get; private set; }


    }
}
