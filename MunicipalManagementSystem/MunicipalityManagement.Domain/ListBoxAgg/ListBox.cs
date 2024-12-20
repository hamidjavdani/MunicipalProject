using _0_Framework.Domain;
using MunicipalityManagement.Domain.ListBoxCategoryAgg;
using MunicipalityManagement.Domain.MelkAgg;
using MunicipalityManagement.Domain.SakhtemanAgg;
using System.Collections.Generic;

namespace MunicipalityManagement.Domain.ListBoxAgg;

public class ListBox : EntityBase
{
    public string Name { get; private set; }
    public long CategoryId { get; private set; }
    public ListBoxCategory Category { get; private set; }
    public List<Melk> melks { get; private set; }
    public List<Sakhteman> sakhtemans { get; private set; }
    public List<Melk> tarhjameh { get; private set; }
    public ListBox(string name, long categoryId)
    {
        Name = name;
        CategoryId = categoryId;
        melks = new List<Melk>();
        sakhtemans = new List<Sakhteman>();
        tarhjameh = new List<Melk>();
    }



    public void Edit(string name, long categoryId)
    {
        Name = name;
        CategoryId = categoryId;
    }
}
