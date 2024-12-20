using _0_Framework.Domain;
using MunicipalityManagement.Application.Contracts.Darkhast;
using System.Collections.Generic;

namespace MunicipalityManagement.Domain.DarkhastAgg;

public interface IDarkhastRepository : IRepository<long, Darkhast>
{
    //EditListBox GetDetails(long id);
    //List<ListBoxViewModel> Search(ListBoxSearchModel searchModel);

    EditDarkhast GetDetails(long id);
    List<DarkhastViewModel> GetDarkhast(long id);
    List<DarkhastViewModel> Search(DarkhastSearchModel searchModel);
}
