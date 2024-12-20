using _0_Framework.Domain;
using MunicipalityManagement.Domain.SakhtemanAgg;
using System.Collections.Generic;

namespace MunicipalityManagement.Domain.ListTabaghatAgg;

public class ListTabaghat : EntityBase
{
    public string Name { get; private set; }
    public int Idtabagheh { get; private set; }
    public List<Sakhteman> sakhtemans { get; private set; }

    public ListTabaghat(string name, int idtabagheh)
    {
        Name = name;
        Idtabagheh = idtabagheh;
    }

    public void Edit(string name, int idtabagheh)
    {
        Name = name;
        Idtabagheh = idtabagheh;
    }
}
