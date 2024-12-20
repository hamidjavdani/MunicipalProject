using _0_Framework.Application;
using System.Collections.Generic;

namespace MunicipalityManagement.Application.Contracts.ListBoxCategory;

public interface IListBoxCategoryApplication
{
    OperationResult Create(CreateListBoxCategory command);
    OperationResult Edit(EditListBoxCategory command);
    EditListBoxCategory GetDetails(long id);

    List<ListBoxCategoryViewModel> GetListBoxCategories();
    List<ListBoxCategoryViewModel> Search(ListBoxCategorySearchModel searchModel);


}
