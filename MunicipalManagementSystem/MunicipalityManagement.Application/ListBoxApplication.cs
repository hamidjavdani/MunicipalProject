using _0_Framework.Application;
using MunicipalityManagement.Application.Contracts.ListBox;
using MunicipalityManagement.Domain.ListBoxAgg;
using System.Collections.Generic;

namespace MunicipalityManagement.Application;

public class ListBoxApplication : IListBoxApplication
{
    private readonly IListBoxRepository _ListBoxRepository;

    public ListBoxApplication(IListBoxRepository listBoxRepository)
    {
        _ListBoxRepository = listBoxRepository;
    }

    public OperationResult Create(CreateListBox command)
    {
        var operation = new OperationResult();
        if (_ListBoxRepository.Exists(x => x.Name == command.Name))
            return operation.Failed(ApplicationMessages.DuplicatedRecord);

        var listBoxCategory = new ListBox(command.Name, command.CategoryId);
        _ListBoxRepository.Create(listBoxCategory);
        _ListBoxRepository.SaveChange();
        return operation.Succedded();

    }


    public OperationResult Edit(EditListBox command)
    {
        var operation = new OperationResult();
        var listBox = _ListBoxRepository.Get(command.Id);
        if (listBox == null)
            return operation.Failed(ApplicationMessages.RecordNotFound);
        if (_ListBoxRepository.Exists(x => x.Name == command.Name && x.Id != command.Id))
            return operation.Failed(ApplicationMessages.DuplicatedRecord);
        listBox.Edit(command.Name, command.CategoryId);
        _ListBoxRepository.SaveChange();
        return operation.Succedded();
    }

    public EditListBox GetDetails(long id)
    {
        return _ListBoxRepository.GetDetails(id);

    }

    public List<ListBoxViewModel> GetListBoxs(long id)
    {
        return _ListBoxRepository.GetListBoxs(id);
    }
    public List<ListBoxViewModel> Search(ListBoxSearchModel searchModel)
    {
        return _ListBoxRepository.Search(searchModel);
    }




}
