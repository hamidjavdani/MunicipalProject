using _0_Framework.Domain;
using MunicipalityManagement.Application.Contracts.ListTabaghat;
using System.Collections.Generic;

namespace MunicipalityManagement.Domain.ListTabaghatAgg;

public interface IListTabaghatRepository : IRepository<long, ListTabaghat>
{
    EditListTabaghat GetDetails(long id);
    List<ListTabaghatViewModel> Search(ListTabaghatSearchModel searchModel);
    List<ListTabaghatViewModel> GetListTabaghat(long id);
}

