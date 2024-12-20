using _0_Framework.Domain;
using EarthManagement.Domain.CityAgg;
using EarthManagement.Domain.ProvinceAgg;
using EarthManagement.Domain.TownshipAgg;
using EarthManagement.Domain.VillageAgg;
using System;
using System.Collections.Generic;
using System.Text;

namespace EarthManagement.Domain.SectorAgg
{
    public class Sector : EntityBase
    {
        public string Name { get; private set; }  //نام بخش
        public int TownshipId { get; private set; }
        public Township Township { get; private set; }       
        public List<Village> Village { get; private set; }       
        public  List<City> City { get; private set; }
        public Sector(string name)
        {
            Name = name;
        }
    }
}
