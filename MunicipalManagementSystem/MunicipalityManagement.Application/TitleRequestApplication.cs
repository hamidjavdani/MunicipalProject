using _0_Framework.Application;
using MunicipalityManagement.Application.Contracts.TitleRequest;
using MunicipalityManagement.Domain.Title_RequestAgg;
using System.Collections.Generic;

namespace MunicipalityManagement.Application;

public class TitleRequestApplication : ITitleRequestApplication
{
    private readonly ITitleRequestRepository _TitleRequestRepository;

    public TitleRequestApplication(ITitleRequestRepository titleRequestRepository)
    {
        _TitleRequestRepository = titleRequestRepository;
    }

    public OperationResult Create(CreateTitleRequest command)
    {
        var operation = new OperationResult();
        if (_TitleRequestRepository.Exists(x => x.Name == command.Name))
            return operation.Failed(ApplicationMessages.DuplicatedRecord);

        var titlerequest = new TitleRequest(command.Name);
        _TitleRequestRepository.Create(titlerequest);
        _TitleRequestRepository.SaveChange();
        return operation.Succedded();
    }

    public OperationResult Edit(EditTitleRequest command)
    {
        var operation = new OperationResult();
        var titlerequest = _TitleRequestRepository.Get(command.Id);
        if (titlerequest == null)
            return operation.Failed(ApplicationMessages.RecordNotFound);
        if (_TitleRequestRepository.Exists(x => x.Name == command.Name && x.Id != command.Id))
            return operation.Failed(ApplicationMessages.DuplicatedRecord);
        titlerequest.Edit(command.Name);
        _TitleRequestRepository.SaveChange();
        return operation.Succedded();
    }

    public EditTitleRequest GetDetails(long id)
    {
        return _TitleRequestRepository.GetDetails(id);
    }

    public List<TitleRequestViewModel> GetTitleRequest()
    {
        return _TitleRequestRepository.GetTitleRequest();
    }

    public List<TitleRequestViewModel> Search(TitleRequestSearchModel searchModel)
    {
        return _TitleRequestRepository.Search(searchModel);
    }
}
