using _0_Framework.Domain;
using EarthManagement.Domain.CountryAgg;
using EarthManagement.Domain.TownshipAgg;
using System;
using System.Collections.Generic;
using System.Text;

namespace EarthManagement.Domain.ProvinceAgg
{
   public class Province:EntityBase
    {
        public string Name { get; private set; }   //نام استان
        public int CountryId { get; private set; }
        public Country Country { get; private set; }
        public List<Township> Townships { get; private set; }  //لیستی از شهرستان ها دارد
        public Province(string name)
        {
            Name = name;
            Townships = new List<Township>();
        }
        public void Edit(string name)
        {
            Name = name;
        }
    }
}
