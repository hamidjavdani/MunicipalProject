using _0_Framework.Domain;
using EarthManagement.Domain.ProvinceAgg;
using EarthManagement.Domain.SectorAgg;
using System.Collections.Generic;

namespace EarthManagement.Domain.TownshipAgg
{
   public class Township:EntityBase
    {
        public string  Name { get; private set; } //نام شهرستان
        public int ProvinceId { get; private set; }
        public  Province province { get; private set; }
        public List<Sector> Sector { get; private set; }

        public Township(string name)
        {
            Name = name;
        }
    }
}
