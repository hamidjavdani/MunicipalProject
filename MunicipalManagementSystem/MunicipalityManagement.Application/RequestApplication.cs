using _0_Framework.Application;
using MunicipalityManagement.Application.Contracts.Request;
using MunicipalityManagement.Domain.RequestAgg;
using System;
using System.Collections.Generic;

namespace MunicipalityManagement.Application;

public class RequestApplication : IRequestApplication
{
    private readonly IRequestRepository _RequestRepository;

    public RequestApplication(IRequestRepository requestRepository)
    {
        _RequestRepository = requestRepository;
    }

    public OperationResult Create(CreateRequest command)
    {
        var operation = new OperationResult();
        //if (_RequestRepository.Exists(x => x. == command.Name))
        //    return operation.Failed(ApplicationMessages.DuplicatedRecord);

        var request = new Request(
            command.AccountId,
            command.RequestType,
            command.Codemelk,
            command.IssueTrackingNo,
            command.Cnmantagheh,
            command.Cnhozeh,
            command.Cnblock,
            command.Cnmelk);
        _RequestRepository.Create(request);
        _RequestRepository.SaveChange();
        return operation.Succedded();
    }

    public OperationResult Edit(EditRequest command)
    {
        throw new NotImplementedException();
    }

    public EditRequest GetDetails(long id)
    {
        return _RequestRepository.GetDetails(id);
    }

    public List<RequestViewModel> Search(RequestSearchModel searchModel)
    {
        return _RequestRepository.Search(searchModel);
    }
}
