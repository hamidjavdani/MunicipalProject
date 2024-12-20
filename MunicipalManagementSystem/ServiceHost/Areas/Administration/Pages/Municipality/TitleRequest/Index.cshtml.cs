using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MunicipalityManagement.Application.Contracts.TitleRequest;
using System.Collections.Generic;

namespace ServiceHost.Areas.Administration.Pages.Municipality.TitleRequest;

public class IndexModel : PageModel
{
    public List<TitleRequestViewModel> titlerequest;

    private readonly ITitleRequestApplication _TitleRequestApplication;

    public IndexModel(ITitleRequestApplication TitleRequestApplication)
    {
        _TitleRequestApplication = TitleRequestApplication;
    }

    public void OnGet(TitleRequestSearchModel searchModel)
    {
        titlerequest = _TitleRequestApplication.Search(searchModel);
    }

    public IActionResult OnGetCreate()
    {
        var command = new CreateTitleRequest();
        //  command.karbarit= _melkApplication.GetKarbari();
        //command.Name=
        return Partial("./Create", new CreateTitleRequest());

    }
    public JsonResult OnPostCreate(CreateTitleRequest command)
    {
        var result = _TitleRequestApplication.Create(command);
        return new JsonResult(result);
    }
    public IActionResult OnGetEdit(long id)
    {
        var darkhast = _TitleRequestApplication.GetDetails(id);
        return Partial("Edit", darkhast);

    }
    public JsonResult OnPostEdit(EditTitleRequest command)
    {
        var result = _TitleRequestApplication.Edit(command);
        return new JsonResult(result);
    }
}
