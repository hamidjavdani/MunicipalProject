using _0_Framework.Application;
using System.Collections.Generic;

namespace MunicipalityManagement.Application.Contracts.TitleRequest;

public interface ITitleRequestApplication
{

    OperationResult Create(CreateTitleRequest command);
    OperationResult Edit(EditTitleRequest command);

    List<TitleRequestViewModel> GetTitleRequest();
    EditTitleRequest GetDetails(long id);
    List<TitleRequestViewModel> Search(TitleRequestSearchModel searchModel);
}
