using _0_Framework.Domain;
using EarthManagement.Domain.VillageAgg;

namespace EarthManagement.Domain.SmalVillageAgg
{
   public class SmalVillage:EntityBase
    {
        public string Name { get;private set; } //نام روستا
        public int VillageId { get;private set; }
        public  Village Village { get; private set; }

        public SmalVillage(string name)
        {
            Name = name;
        }
    }
}
