using _0_Framework.Application;
using System.Collections.Generic;

namespace MunicipalityManagement.Application.Contracts.Sakhteman;

public interface ISakhtemanApplication
{
    OperationResult Create(CreateSakhteman command);
    OperationResult Edit(EditSakhteman command);
    EditSakhteman GetDetails(long id);
    List<SakhtemanViewModel> Search(long idmelk);
}
