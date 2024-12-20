using _0_Framework.Domain;
using EarthManagement.Domain.SectorAgg;
using EarthManagement.Domain.SmalVillageAgg;
using System;
using System.Collections.Generic;
using System.Text;

namespace EarthManagement.Domain.VillageAgg
{
   public class Village:EntityBase
    {
        public string Name { get;private set; }    //نام دهستان 
        public int SectorId { get; private set; }
        public Sector Sector { get; private set; }
        public List<SmalVillage> SmalVillage { get; private set; }
        public Village(string name)
        {
            Name = name;
        }
    }
}
