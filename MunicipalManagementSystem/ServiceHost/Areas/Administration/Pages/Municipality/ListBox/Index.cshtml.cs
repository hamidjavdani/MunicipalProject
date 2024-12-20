using _0_Framework.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MunicipalityManagement.Application.Contracts.ListBox;
using MunicipalityManagement.Application.Contracts.ListBoxCategory;
using MunicipalityManagement.Infrastructure.Configuration.Permissions;
using System.Collections.Generic;

namespace ServiceHost.Areas.Administration.Pages.Municipality.ListBox;

public class IndexModel : PageModel
{


    public ListBoxSearchModel SearchModel;
    public List<ListBoxViewModel> ListBoxs;
    public SelectList ListBoxCategories;


    private readonly IListBoxApplication _ListBoxApplication;
    private readonly IListBoxCategoryApplication _ListBoxCategoryApplication;

    public IndexModel(IListBoxApplication listBoxApplication,
        IListBoxCategoryApplication listBoxCategoryApplication
        )
    {
        _ListBoxApplication = listBoxApplication;
        _ListBoxCategoryApplication = listBoxCategoryApplication;
    }

    [NeedsPermission(MunicipalityPermissions.Listbox)]
    public void OnGet(ListBoxSearchModel searchModel)
    {
        //  listboxs = _ListBoxApplication.Search(searchModel);
        List<ListBoxCategoryViewModel> Categoriesss = _ListBoxCategoryApplication.GetListBoxCategories();
        ListBoxCategories = new SelectList(_ListBoxCategoryApplication.GetListBoxCategories(), "Id", "Name");
        ListBoxs = _ListBoxApplication.Search(searchModel);
    }


    public IActionResult OnGetCreate()
    {
        //var command = new CreateListBox();
        ////  command.karbarit= _melkApplication.GetKarbari();
        ////command.Name=
        //return Partial("./Create", new CreateListBox());

        var command = new CreateListBox
        {
            Categories = _ListBoxCategoryApplication.GetListBoxCategories()
        };
        return Partial("./Create", command);



    }

    [NeedsPermission(MunicipalityPermissions.CreateListbox)]
    public JsonResult OnPostCreate(CreateListBox command)
    {
        var result = _ListBoxApplication.Create(command);
        return new JsonResult(result);
    }
    public IActionResult OnGetEdit(long id)
    {
        var listboxcategory = _ListBoxApplication.GetDetails(id);
        return Partial("Edit", listboxcategory);

    }
    [NeedsPermission(MunicipalityPermissions.EditListbox)]
    public JsonResult OnPostEdit(EditListBox command)
    {
        var result = _ListBoxApplication.Edit(command);
        return new JsonResult(result);
    }
}
