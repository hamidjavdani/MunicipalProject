using _0_Framework.Application;
using System.Collections.Generic;

namespace MunicipalityManagement.Application.Contracts.Darkhast;

public interface IDarkhastApplication
{
    OperationResult Create(CreateDarkhast command);
    OperationResult Edit(EditDarkhast command);

    List<DarkhastViewModel> GetDarkhast(long id);
    EditDarkhast GetDetails(long id);
    List<DarkhastViewModel> Search(DarkhastSearchModel searchModel);
}
