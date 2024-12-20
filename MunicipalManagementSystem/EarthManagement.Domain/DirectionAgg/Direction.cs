using _0_Framework.Domain;
using EarthManagement.Domain.MelkDirectionAgg;
using System;
using System.Collections.Generic;
using System.Text;

namespace EarthManagement.Domain.DirectionAgg
{
   public class Direction:EntityBase
    {
        public string Name { get; set; }
        public List<MelkDirection> MelkDirections { get; private set; } //ابعاد ملک
    }
}
