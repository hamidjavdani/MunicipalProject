using _0_Framework.Application;
using MunicipalityManagement.Application.Contracts.Darkhast;
using MunicipalityManagement.Domain.DarkhastAgg;
using System.Collections.Generic;

namespace MunicipalityManagement.Application;

public class DarkhastApplication : IDarkhastApplication
{
    private readonly IDarkhastRepository _DarkhastRepository;
    public DarkhastApplication(IDarkhastRepository darkhastRepository)
    {
        _DarkhastRepository = darkhastRepository;
    }
    public OperationResult Create(CreateDarkhast command)
    {
        var operation = new OperationResult();
        if (_DarkhastRepository.Exists(x => x.Name == command.Name))
            return operation.Failed(ApplicationMessages.DuplicatedRecord);

        var darkhast = new Darkhast(command.Name);
        _DarkhastRepository.Create(darkhast);
        _DarkhastRepository.SaveChange();
        return operation.Succedded();
    }

    public OperationResult Edit(EditDarkhast command)
    {
        var operation = new OperationResult();
        var darkhast = _DarkhastRepository.Get(command.Id);
        if (darkhast == null)
            return operation.Failed(ApplicationMessages.RecordNotFound);
        if (_DarkhastRepository.Exists(x => x.Name == command.Name && x.Id != command.Id))
            return operation.Failed(ApplicationMessages.DuplicatedRecord);
        darkhast.Edit(command.Name);
        _DarkhastRepository.SaveChange();
        return operation.Succedded();
    }

    public List<DarkhastViewModel> GetDarkhast(long id)
    {
        return _DarkhastRepository.GetDarkhast(id);
    }

    public EditDarkhast GetDetails(long id)
    {
        return _DarkhastRepository.GetDetails(id);
    }

    public List<DarkhastViewModel> Search(DarkhastSearchModel searchModel)
    {
        return _DarkhastRepository.Search(searchModel);
    }
}
