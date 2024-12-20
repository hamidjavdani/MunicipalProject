using _0_Framework.Domain;

namespace MunicipalityManagement.Domain.DarkhastAgg;

public class Darkhast : EntityBase
{
    public string Name { get; private set; }

    public Darkhast(string name)
    {
        Name = name;
    }

    public void Edit(string name)
    {
        Name = name;
    }
}
