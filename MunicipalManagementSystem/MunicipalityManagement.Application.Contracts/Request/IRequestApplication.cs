using _0_Framework.Application;
using System.Collections.Generic;

namespace MunicipalityManagement.Application.Contracts.Request;

public interface IRequestApplication
{
    OperationResult Create(CreateRequest command);
    OperationResult Edit(EditRequest command);
    EditRequest GetDetails(long id);
    List<RequestViewModel> Search(RequestSearchModel searchModel);
}
