using _0_Framework.Domain;
using EarthManagement.Domain.ComprehensivePlanAgg;
using EarthManagement.Domain.MelkAgg;
using System;
using System.Collections.Generic;
using System.Text;

namespace EarthManagement.Domain.MelkComprehensivePlanAgg
{
    public class MelkComprehensivePlan:EntityBase
    {
        public int MelkId { get; set; }
        public Melk Melk { get; set; }
        public int ComprehensivePlanId { get; set; }
        public ComprehensivePlan ComprehensivePlan { get; set; }
    }
}
