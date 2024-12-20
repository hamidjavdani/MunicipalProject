using _0_Framework.Domain;
using MunicipalityManagement.Domain.SakhtemanAgg;
using System.Collections.Generic;

namespace MunicipalityManagement.Domain.ListKarbariAgg;

public class ListKarbari : EntityBase
{
    public string Name { get; private set; }
    public int Idkarbari { get; private set; }
    public List<Sakhteman> sakhtemans { get; private set; }

    public ListKarbari(string name, int idkarbari)
    {
        Name = name;
        Idkarbari = idkarbari;
    }

    public void Edit(string name, int idkarbari)
    {
        Name = name;
        Idkarbari = idkarbari;
    }


}
