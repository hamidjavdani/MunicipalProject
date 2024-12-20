using _0_Framework.Domain;
using EarthManagement.Domain.BuildingAgg;
using System;
using System.Collections.Generic;
using System.Text;

namespace EarthManagement.Domain.ApartmentAgg
{
    public class Apartment : EntityBase
    {
        public string Name { get; private set; }
        public int BuildingId { get; private set; }
        public Building Building { get; private set; }
    }
}
