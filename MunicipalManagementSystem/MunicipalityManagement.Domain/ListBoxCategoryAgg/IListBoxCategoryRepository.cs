using _0_Framework.Domain;
using MunicipalityManagement.Application.Contracts.ListBoxCategory;
using System.Collections.Generic;

namespace MunicipalityManagement.Domain.ListBoxCategoryAgg;

public interface IListBoxCategoryRepository : IRepository<long, ListBoxCategory>
{

    List<ListBoxCategoryViewModel> GetListBoxCategories();
    EditListBoxCategory GetDetails(long id);
    List<ListBoxCategoryViewModel> Search(ListBoxCategorySearchModel searchModel);


}
