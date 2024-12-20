using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MunicipalityManagement.Application.Contracts.ListKarbari;
using System.Collections.Generic;

namespace ServiceHost.Areas.Administration.Pages.Municipality.ListKarbari;

public class IndexModel : PageModel
{
    public List<ListKarbariViewModel> listkarbari;

    private readonly IListKarbariApplication _ListKarbariApplication;

    public IndexModel(IListKarbariApplication listKarbariApplication)
    {
        _ListKarbariApplication = listKarbariApplication;
    }

    public void OnGet(ListKarbariSearchModel searchModel)
    {
        listkarbari = _ListKarbariApplication.Search(searchModel);
    }

    public IActionResult OnGetCreate()
    {
        var command = new CreateListKarbari();
        //  command.karbarit= _melkApplication.GetKarbari();
        //command.Name=
        return Partial("./Create", new CreateListKarbari());

    }
    public JsonResult OnPostCreate(CreateListKarbari command)
    {
        var result = _ListKarbariApplication.Create(command);
        return new JsonResult(result);
    }
    public IActionResult OnGetEdit(long id)
    {
        var listboxcategory = _ListKarbariApplication.GetDetails(id);
        return Partial("Edit", listboxcategory);

    }
    public JsonResult OnPostEdit(EditListKarbari command)
    {
        var result = _ListKarbariApplication.Edit(command);
        return new JsonResult(result);
    }
}
