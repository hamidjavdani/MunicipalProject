using AccountManagement.Application.Contracts.Log;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ServiceHost.Areas.Administration.Pages.Accounts.Log;

// [Authorize(Roles = Roles.Administrator)]//
public class IndexModel : PageModel
{
    [TempData]
    public string Message { get; set; }
    public LogSearchModel SearchModel;
    public List<LogViewModel> Logs;
    public SelectList Roles;

    private readonly ILogApplication _logApplication;


    public IndexModel(ILogApplication logApplication

        )
    {
        _logApplication = logApplication;

    }

    public void OnGet(LogSearchModel searchModel)
    {
        // Roles = new SelectList(_roleApplication.List(), "Id", "Name");
        Logs = _logApplication.Search(searchModel);
    }




}
