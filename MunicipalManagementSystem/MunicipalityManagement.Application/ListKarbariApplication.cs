using _0_Framework.Application;
using MunicipalityManagement.Application.Contracts.ListKarbari;
using MunicipalityManagement.Domain.ListKarbariAgg;
using System.Collections.Generic;

namespace MunicipalityManagement.Application;

public class ListKarbariApplication : IListKarbariApplication
{
    private readonly IListKarbariRepository _ListKarbariRepository;

    public ListKarbariApplication(IListKarbariRepository ListKarbariRepository)
    {
        _ListKarbariRepository = ListKarbariRepository;
    }


    public OperationResult Create(CreateListKarbari command)
    {
        var operation = new OperationResult();
        if (_ListKarbariRepository.Exists(x => x.Name == command.Name))
            return operation.Failed(ApplicationMessages.DuplicatedRecord);

        var listkarbari = new ListKarbari(command.Name, command.Idkarbari);

        _ListKarbariRepository.Create(listkarbari);
        _ListKarbariRepository.SaveChange();

        return operation.Succedded();

    }

    public OperationResult Edit(EditListKarbari command)
    {
        var operation = new OperationResult();
        var listkarbari = _ListKarbariRepository.Get(command.Id);
        if (listkarbari == null)
            return operation.Failed(ApplicationMessages.RecordNotFound);
        if (_ListKarbariRepository.Exists(x => x.Name == command.Name && x.Id != command.Id))
            return operation.Failed(ApplicationMessages.DuplicatedRecord);
        listkarbari.Edit(command.Name, command.Idkarbari);
        _ListKarbariRepository.SaveChange();
        return operation.Succedded();
    }

    public EditListKarbari GetDetails(long id)
    {
        return _ListKarbariRepository.GetDetails(id);
    }

    public List<ListKarbariViewModel> GetListKarbari(long id)
    {
        return _ListKarbariRepository.GetListKarbari(id);
    }

    public List<ListKarbariViewModel> Search(ListKarbariSearchModel searchModel)
    {
        return _ListKarbariRepository.Search(searchModel);
    }
}
