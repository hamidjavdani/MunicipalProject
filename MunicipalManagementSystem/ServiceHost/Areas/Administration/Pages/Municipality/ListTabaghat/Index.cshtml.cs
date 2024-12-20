using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MunicipalityManagement.Application.Contracts.ListTabaghat;
using System.Collections.Generic;

namespace ServiceHost.Areas.Administration.Pages.Municipality.ListTabaghat;

public class IndexModel : PageModel
{
    public List<ListTabaghatViewModel> listtabaghat;

    private readonly IListTabaghatApplication _ListTabaghatApplication;

    public IndexModel(IListTabaghatApplication listTabaghatApplication)
    {
        _ListTabaghatApplication = listTabaghatApplication;
    }

    public void OnGet(ListTabaghatSearchModel searchModel)
    {
        listtabaghat = _ListTabaghatApplication.Search(searchModel);
    }

    public IActionResult OnGetCreate()
    {
        var command = new CreateListTabaghat();
        //  command.karbarit= _melkApplication.GetKarbari();
        //command.Name=
        return Partial("./Create", new CreateListTabaghat());

    }
    public JsonResult OnPostCreate(CreateListTabaghat command)
    {
        var result = _ListTabaghatApplication.Create(command);
        return new JsonResult(result);
    }
    public IActionResult OnGetEdit(long id)
    {
        var listboxcategory = _ListTabaghatApplication.GetDetails(id);
        return Partial("Edit", listboxcategory);

    }
    public JsonResult OnPostEdit(EditListTabaghat command)
    {
        var result = _ListTabaghatApplication.Edit(command);
        return new JsonResult(result);
    }
}
