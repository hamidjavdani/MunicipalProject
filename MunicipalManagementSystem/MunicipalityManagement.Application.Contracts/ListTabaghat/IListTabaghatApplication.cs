using _0_Framework.Application;
using System.Collections.Generic;

namespace MunicipalityManagement.Application.Contracts.ListTabaghat;

public interface IListTabaghatApplication
{
    OperationResult Create(CreateListTabaghat command);
    OperationResult Edit(EditListTabaghat command);
    EditListTabaghat GetDetails(long id);
    List<ListTabaghatViewModel> Search(ListTabaghatSearchModel searchModel);
    List<ListTabaghatViewModel> GetListTabaghat(long id);
}
