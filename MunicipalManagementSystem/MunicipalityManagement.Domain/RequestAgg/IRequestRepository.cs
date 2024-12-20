using _0_Framework.Domain;
using MunicipalityManagement.Application.Contracts.Request;
using System.Collections.Generic;

namespace MunicipalityManagement.Domain.RequestAgg;

public interface IRequestRepository : IRepository<long, Request>
{
    EditRequest GetDetails(long id);

    List<RequestViewModel> Search(RequestSearchModel searchModel);



}
