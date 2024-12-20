using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MunicipalityManagement.Application.Contracts.ListBoxCategory;
using MunicipalityManagement.Application.Contracts.Request;
using MunicipalityManagement.Application.Contracts.TitleRequest;
using System.Collections.Generic;

namespace ServiceHost.Areas.UserAreas.Pages.Request;

public class IndexModel : PageModel
{
    [TempData]
    public string Message { get; set; }
    public List<RequestViewModel> Request;
    public SelectList TitleRequest;
    public readonly IRequestApplication _requestApplication;
    public readonly ITitleRequestApplication _titleRequestApplication;
    public readonly IListBoxCategoryApplication _ListBoxCategoryApplication;

    public readonly IRequestApplication _ListBoxCategoryApplication1;
    public IndexModel(IRequestApplication orderApplication,
        ITitleRequestApplication ititleRequestApplication
        )
    {
        _requestApplication = orderApplication;
        _titleRequestApplication = ititleRequestApplication;
    }

    //[NeedsPermission(MunicipalityPermissions.Listbox)]
    public void OnGet(RequestSearchModel searchModel)
    {
        EditTitleRequest t = _titleRequestApplication.GetDetails(1);

        Request = _requestApplication.Search(searchModel);
    }
    //[NeedsPermission(MunicipalityPermissions.CreateListbox)]
    public IActionResult OnGetCreate()
    {

        var command = new CreateRequest
        {
            TitleRequests = _titleRequestApplication.GetTitleRequest()
        };

        return Partial("./Create", command);

    }

    public JsonResult OnPostCreate(CreateRequest command)
    {
        var result = _requestApplication.Create(command);
        return new JsonResult(result);
    }
    //[NeedsPermission(MunicipalityPermissions.EditListbox)]
    public IActionResult OnGetEdit(long id)
    {
        //var slide = _requestApplication.GetDetails(id);
        //return Partial("Edit", slide);

        var command = new CreateRequest
        {
            TitleRequests = _titleRequestApplication.GetTitleRequest()
        };

        return Partial("./Edit", command);

    }

    public JsonResult OnPostEdit(EditRequest command)
    {
        var result = _requestApplication.Edit(command);
        return new JsonResult(result);
    }

    public IActionResult OnGetRemove(long id)
    {
        //var result = _orderApplication.Remove(id);
        //if (result.IsSuccedded)
        //    return RedirectToPage("./Index");

        //Message = result.Message;
        return RedirectToPage("./Index");
    }

    public IActionResult OnGetRestore(long id)
    {
        //var result = _slideApplication.Restore(id);
        //if (result.IsSuccedded)
        //    return RedirectToPage("./Index");

        //Message = result.Message;
        return RedirectToPage("./Index");
    }
}
