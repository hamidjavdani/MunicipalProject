using _0_Framework.Domain;
using EarthManagement.Domain.MelkAgg;
using EarthManagement.Domain.ParishAgg;
using System;
using System.Collections.Generic;
using System.Text;

namespace EarthManagement.Domain.BlockAgg
{
    public class Block : EntityBase
    {
        public string Name { get; private set; }
        public int ParishId { get; private set; }
        public Parish Parish { get;private set; }
        public List<Melk> Melk { get;private set; }

    }
}
