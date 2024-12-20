using _0_Framework.Application;
using MunicipalityManagement.Application.Contracts.ListTabaghat;
using MunicipalityManagement.Domain.ListTabaghatAgg;
using System.Collections.Generic;

namespace MunicipalityManagement.Application;

public class ListTabaghatApplication : IListTabaghatApplication
{
    private readonly IListTabaghatRepository _ListTabaghatRepository;

    public ListTabaghatApplication(IListTabaghatRepository listTabaghatRepository)
    {
        _ListTabaghatRepository = listTabaghatRepository;
    }

    public OperationResult Create(CreateListTabaghat command)
    {
        var operation = new OperationResult();
        if (_ListTabaghatRepository.Exists(x => x.Name == command.Name))
            return operation.Failed(ApplicationMessages.DuplicatedRecord);

        var listTabaghat = new ListTabaghat(command.Name, command.Idtabagheh);
        _ListTabaghatRepository.Create(listTabaghat);
        _ListTabaghatRepository.SaveChange();
        return operation.Succedded();
    }


    public OperationResult Edit(EditListTabaghat command)
    {
        var operation = new OperationResult();
        var listTabaghat = _ListTabaghatRepository.Get(command.Id);
        if (listTabaghat == null)
            return operation.Failed(ApplicationMessages.RecordNotFound);
        if (_ListTabaghatRepository.Exists(x => x.Name == command.Name && x.Id != command.Id))
            return operation.Failed(ApplicationMessages.DuplicatedRecord);
        listTabaghat.Edit(command.Name, command.Idtabagheh);
        _ListTabaghatRepository.SaveChange();
        return operation.Succedded();
    }

    public EditListTabaghat GetDetails(long id)
    {
        return _ListTabaghatRepository.GetDetails(id);

    }

    public List<ListTabaghatViewModel> GetListTabaghat(long id)
    {
        return _ListTabaghatRepository.GetListTabaghat(id);
    }
    public List<ListTabaghatViewModel> Search(ListTabaghatSearchModel searchModel)
    {
        return _ListTabaghatRepository.Search(searchModel);
    }




}
