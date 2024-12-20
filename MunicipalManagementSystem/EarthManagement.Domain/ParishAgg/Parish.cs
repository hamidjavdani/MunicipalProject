using _0_Framework.Domain;
using EarthManagement.Domain.BlockAgg;
using EarthManagement.Domain.DistrictAgg;
using System;
using System.Collections.Generic;
using System.Text;

namespace EarthManagement.Domain.ParishAgg
{
    public class Parish : EntityBase   //کلاس محله
    {
        public string Name { get; set; }
        public int DistrictId { get; set; }
        public  District District { get; set; }
        public List<Block> Blocks { get; set; }
    }
}
