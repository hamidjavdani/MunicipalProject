using _0_Framework.Domain;
using EarthManagement.Domain.DetailedPlanAgg;
using EarthManagement.Domain.MelkAgg;
using System;
using System.Collections.Generic;
using System.Text;

namespace EarthManagement.Domain.MelkDetailedPlanAgg
{
   public class MelkDetailedPlan:EntityBase
    {
        public int MelkId { get; set; }
        public Melk Melk { get; private set; }
        public int DetailedPlanId { get; set; }
        public DetailedPlan DetailedPlan  { get; set; }

    }
}
