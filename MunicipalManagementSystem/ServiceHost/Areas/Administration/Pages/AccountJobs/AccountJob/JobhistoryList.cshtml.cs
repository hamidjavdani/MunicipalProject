using AccountManagement.Application.Contracts.AccountJob;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ServiceHost.Areas.Administration.Pages.AccountJobs.AccountJob;

public class JobhistoryListModel : PageModel
{
    [TempData]
    public string Message { get; set; }
    public AccountJobSearchModel SearchModel;
    public List<AccountJobViewModel> AccountJob;
    public SelectList Roles;
    public long _accountid = 0;
    public string _accountname = "";
    private readonly IAccountJobApplication _accountJobApplication;
    public JobhistoryListModel(IAccountJobApplication accountJobApplication
        )
    {
        _accountJobApplication = accountJobApplication;
    }

    public void OnGet(AccountJobSearchModel searchModel, long idaccount, string accountname)
    {
        _accountid = idaccount;
        _accountname = accountname;
        //Roles = new SelectList(_accountJobApplication.List(), "Id", "Name");
        AccountJob = _accountJobApplication.Search(searchModel);
    }

}
