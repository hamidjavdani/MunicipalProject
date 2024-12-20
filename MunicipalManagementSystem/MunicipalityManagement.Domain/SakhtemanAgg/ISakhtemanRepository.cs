using _0_Framework.Domain;
using MunicipalityManagement.Application.Contracts.Sakhteman;
using System.Collections.Generic;

namespace MunicipalityManagement.Domain.SakhtemanAgg;

public interface ISakhtemanRepository : IRepository<long, Sakhteman>
{
    EditSakhteman GetDetails(long id);
    List<SakhtemanViewModel> Search(long Id);


}
