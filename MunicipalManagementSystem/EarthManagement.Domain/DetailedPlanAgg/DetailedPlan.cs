using _0_Framework.Domain;
using EarthManagement.Domain.MelkDetailedPlanAgg;
using System;
using System.Collections.Generic;
using System.Text;

namespace EarthManagement.Domain.DetailedPlanAgg
{
    public class DetailedPlan : EntityBase
    {
        public string Name { get; private set; }
        public List<MelkDetailedPlan> MelkDetailedPlans { get; private set; }
    }
}
