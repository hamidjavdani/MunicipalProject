using _0_Framework.Domain;
using EarthManagement.Domain.MelkComprehensivePlanAgg;
using System;
using System.Collections.Generic;
using System.Text;

namespace EarthManagement.Domain.ComprehensivePlanAgg
{
    public class ComprehensivePlan:EntityBase
    {
        public string Name { get; private set; }
        public List<MelkComprehensivePlan> MelkComprehensivePlans { get; set; }
    }
}
