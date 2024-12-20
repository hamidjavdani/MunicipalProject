using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MunicipalityManagement.Application.Contracts.ListBoxCategory;
using System.Collections.Generic;

namespace ServiceHost.Areas.Administration.Pages.Municipality.ListBoxCategory;

public class IndexModel : PageModel
{
    public List<ListBoxCategoryViewModel> listboxcategories;

    private readonly IListBoxCategoryApplication _ListBoxCategoryApplication;

    public IndexModel(IListBoxCategoryApplication listBoxCategoryApplication)
    {
        _ListBoxCategoryApplication = listBoxCategoryApplication;
    }

    public void OnGet(ListBoxCategorySearchModel searchModel)
    {
        listboxcategories = _ListBoxCategoryApplication.Search(searchModel);
    }

    public IActionResult OnGetCreate()
    {
        var command = new CreateListBoxCategory();
        //  command.karbarit= _melkApplication.GetKarbari();
        //command.Name=
        return Partial("./Create", new CreateListBoxCategory());

    }
    public JsonResult OnPostCreate(CreateListBoxCategory command)
    {
        var result = _ListBoxCategoryApplication.Create(command);
        return new JsonResult(result);
    }
    public IActionResult OnGetEdit(long id)
    {
        var listboxcategory = _ListBoxCategoryApplication.GetDetails(id);
        return Partial("Edit", listboxcategory);

    }
    public JsonResult OnPostEdit(EditListBoxCategory command)
    {
        var result = _ListBoxCategoryApplication.Edit(command);
        return new JsonResult(result);
    }
}
