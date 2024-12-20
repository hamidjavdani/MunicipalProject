
using _0_Framework.Application;
using System.Collections.Generic;

namespace MunicipalityManagement.Application.Contracts.ListKarbari;

public interface IListKarbariApplication
{
    OperationResult Create(CreateListKarbari command);
    OperationResult Edit(EditListKarbari command);
    EditListKarbari GetDetails(long id);
    List<ListKarbariViewModel> Search(ListKarbariSearchModel searchModel);
    List<ListKarbariViewModel> GetListKarbari(long id);

}
