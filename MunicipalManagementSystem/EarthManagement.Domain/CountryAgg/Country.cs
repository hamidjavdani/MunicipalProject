using _0_Framework.Domain;
using EarthManagement.Domain.ProvinceAgg;
using System;
using System.Collections.Generic;
using System.Text;

namespace EarthManagement.Domain.CountryAgg
{
    public class Country : EntityBase
    {
        public string Name { get; private set; }
        public double Area { get; private set; }
        public int Population { get; private set; }
        public List<Province> Provinces { get; private set; } //لیستی از استان دارد


        public Country(string name, double area, int population)
        {
            Name = name;
            Area = area;
            Population = population;
            Provinces = new List<Province>();
        }

        public void Edit(string name, double area, int population)
        {
            Name = name;
            Area = area;
            Population = population;
        }


    }
}
