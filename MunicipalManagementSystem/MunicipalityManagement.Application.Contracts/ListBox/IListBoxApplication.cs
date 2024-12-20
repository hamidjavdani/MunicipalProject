using _0_Framework.Application;
using System.Collections.Generic;

namespace MunicipalityManagement.Application.Contracts.ListBox;

public interface IListBoxApplication
{
    OperationResult Create(CreateListBox command);
    OperationResult Edit(EditListBox command);

    List<ListBoxViewModel> GetListBoxs(long id);
    EditListBox GetDetails(long id);
    List<ListBoxViewModel> Search(ListBoxSearchModel searchModel);
}
