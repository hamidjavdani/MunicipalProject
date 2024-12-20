using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MunicipalityManagement.Application.Contracts.Darkhast;
using System.Collections.Generic;

namespace ServiceHost.Areas.Administration.Pages.Municipality.Darkhast;

public class Index1Model : PageModel
{
    public List<DarkhastViewModel> darkhasts;

    private readonly IDarkhastApplication _DarkhastApplication;

    public Index1Model(IDarkhastApplication darkhastApplication)
    {
        _DarkhastApplication = darkhastApplication;
    }

    public void OnGet(DarkhastSearchModel searchModel)
    {
        darkhasts = _DarkhastApplication.Search(searchModel);
    }

    public IActionResult OnGetCreate()
    {
        var command = new CreateDarkhast();
        //  command.karbarit= _melkApplication.GetKarbari();
        //command.Name=
        return Partial("./Create", new CreateDarkhast());

    }
    public JsonResult OnPostCreate(CreateDarkhast command)
    {
        var result = _DarkhastApplication.Create(command);
        return new JsonResult(result);
    }
    public IActionResult OnGetEdit(long id)
    {
        var darkhast = _DarkhastApplication.GetDetails(id);
        return Partial("Edit", darkhast);

    }
    public JsonResult OnPostEdit(EditDarkhast command)
    {
        var result = _DarkhastApplication.Edit(command);
        return new JsonResult(result);
    }
}
