using _0_Framework.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CityManagement.Domain.CityAgg
{
    public class City : EntityBase
    {
        public string Name { get; private set; }
        public double Area { get; private set; }
      
        //public List<mantagheh> listmatagheh{get;praivate set;}

    }
}
