using _0_Framework.Domain;
using EarthManagement.Domain.MelkAgg;
using EarthManagement.Domain.ZoningAgg;
using System;
using System.Collections.Generic;
using System.Text;

namespace EarthManagement.Domain.MelkZoningAgg
{
    public class MelkZoning : EntityBase
    {
        public int MelkId { get; set; }
        public Melk Melk { get; set; }
        public int ZoningId{ get; set; }
        public Zoning Zoning { get; set; }
    }
}
