using _0_Framework.Domain;
using MunicipalityManagement.Application.Contracts.ListBox;
using System.Collections.Generic;

namespace MunicipalityManagement.Domain.ListBoxAgg;

public interface IListBoxRepository : IRepository<long, ListBox>
{
    EditListBox GetDetails(long id);
    List<ListBoxViewModel> Search(ListBoxSearchModel searchModel);

    List<ListBoxViewModel> GetListBoxs(long id);
}
