using _0_Framework.Domain;
using EarthManagement.Domain.ApartmentAgg;
using EarthManagement.Domain.MelkAgg;
using System;
using System.Collections.Generic;
using System.Text;

namespace EarthManagement.Domain.BuildingAgg
{
   public class Building:EntityBase
    {
        public string Name { get;private set; }
        public int MelkId { get;private set; }
        public Melk Melk { get; private set; }
        public List<Apartment> Apartments { get; set; }
    }
}
