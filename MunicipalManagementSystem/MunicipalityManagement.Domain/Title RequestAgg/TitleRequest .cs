using _0_Framework.Domain;
using MunicipalityManagement.Domain.RequestAgg;
using System.Collections.Generic;

namespace MunicipalityManagement.Domain.Title_RequestAgg;

public class TitleRequest : EntityBase
{
    public string Name { get; private set; }

    public List<Request> Requests { get; private set; }
    public TitleRequest(string name)
    {
        Name = name;
    }

    public void Edit(string name)
    {
        Name = name;
    }
}
