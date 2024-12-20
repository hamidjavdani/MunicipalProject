using _0_Framework.Application;
using MunicipalityManagement.Application.Contracts.ListBoxCategory;
using MunicipalityManagement.Domain.ListBoxCategoryAgg;
using System.Collections.Generic;

namespace MunicipalityManagement.Application;

public class ListBoxCategoryApplication : IListBoxCategoryApplication
{

    private readonly IListBoxCategoryRepository _ListBoxCategoryRepository;

    public ListBoxCategoryApplication(IListBoxCategoryRepository listBoxCategoryRepository)
    {
        _ListBoxCategoryRepository = listBoxCategoryRepository;
    }

    public OperationResult Create(CreateListBoxCategory command)
    {
        var operation = new OperationResult();
        if (_ListBoxCategoryRepository.Exists(x => x.Name == command.Name))
            return operation.Failed(ApplicationMessages.DuplicatedRecord);

        var listBoxCategory = new ListBoxCategory(command.Name);
        _ListBoxCategoryRepository.Create(listBoxCategory);
        _ListBoxCategoryRepository.SaveChange();
        return operation.Succedded();
    }

    public OperationResult Edit(EditListBoxCategory command)
    {
        var operation = new OperationResult();
        var listBoxCategory = _ListBoxCategoryRepository.Get(command.Id);
        if (listBoxCategory == null)
            return operation.Failed(ApplicationMessages.RecordNotFound);
        if (_ListBoxCategoryRepository.Exists(x => x.Name == command.Name && x.Id != command.Id))
            return operation.Failed(ApplicationMessages.DuplicatedRecord);
        listBoxCategory.Edit(command.Name);
        _ListBoxCategoryRepository.SaveChange();
        return operation.Succedded();
    }

    public EditListBoxCategory GetDetails(long id)
    {
        return _ListBoxCategoryRepository.GetDetails(id);

    }

    public List<ListBoxCategoryViewModel> GetListBoxCategories()
    {
        return _ListBoxCategoryRepository.GetListBoxCategories();
    }

    public List<ListBoxCategoryViewModel> Search(ListBoxCategorySearchModel searchModel)
    {
        return _ListBoxCategoryRepository.Search(searchModel);
    }


}
