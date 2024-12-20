using _0_Framework.Domain;
using EarthManagement.Domain.CityRegionAgg;
using EarthManagement.Domain.ProvinceAgg;
using EarthManagement.Domain.RegionAgg;
using EarthManagement.Domain.SectorAgg;
using System;
using System.Collections.Generic;
using System.Text;

namespace EarthManagement.Domain.CityAgg
{
   public class City:EntityBase
    {
        public string Name { get; private set; } //نام شهر
        public int SectorId { get; private set; }
        public Sector Sector { get; private set; }
        public List<Region> Region { get; private set; }

        public City(string name)
        {
            Name = name;
        }
        public void Edit(string name)
        {
            Name = name;
        }
    }
}
