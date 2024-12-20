using _0_Framework.Domain;
using MunicipalityManagement.Application.Contracts.TitleRequest;
using System.Collections.Generic;

namespace MunicipalityManagement.Domain.Title_RequestAgg;

public interface ITitleRequestRepository : IRepository<long, TitleRequest>
{
    EditTitleRequest GetDetails(long id);
    List<TitleRequestViewModel> GetTitleRequest();
    List<TitleRequestViewModel> Search(TitleRequestSearchModel searchModel);
}
