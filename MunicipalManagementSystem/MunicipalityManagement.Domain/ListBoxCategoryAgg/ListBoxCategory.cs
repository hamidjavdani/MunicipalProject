using _0_Framework.Domain;
using MunicipalityManagement.Domain.ListBoxAgg;
using System.Collections.Generic;

namespace MunicipalityManagement.Domain.ListBoxCategoryAgg;

public class ListBoxCategory : EntityBase
{
    public string Name { get; private set; }

    public List<ListBox> Listboxs { get; private set; }

    public ListBoxCategory(string name)
    {
        Name = name;
    }
    public void Edit(string name)
    {
        Name = name;
    }
}
