using _0_Framework.Domain;
using EarthManagement.Domain.MelkAgg;
using System;
using System.Collections.Generic;
using System.Text;

namespace EarthManagement.Domain.TitleDocumentAgg
{
    public class TitleDocument : EntityBase
    {
        public string Name { get; private set; }
        public List<Melk> Mleks { get; private set; }
    }
}
