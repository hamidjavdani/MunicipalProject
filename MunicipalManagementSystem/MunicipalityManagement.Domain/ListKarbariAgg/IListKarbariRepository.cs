using _0_Framework.Domain;
using MunicipalityManagement.Application.Contracts.ListKarbari;
using System.Collections.Generic;

namespace MunicipalityManagement.Domain.ListKarbariAgg;

public interface IListKarbariRepository : IRepository<long, ListKarbari>
{
    EditListKarbari GetDetails(long id);
    List<ListKarbariViewModel> Search(ListKarbariSearchModel searchModel);
    List<ListKarbariViewModel> GetListKarbari(long id);
}
