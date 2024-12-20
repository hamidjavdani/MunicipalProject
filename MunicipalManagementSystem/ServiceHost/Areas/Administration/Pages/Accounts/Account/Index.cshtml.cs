using AccountManagement.Application.Contracts.Account;
using AccountManagement.Application.Contracts.Log;
using AccountManagement.Application.Contracts.Role;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ServiceHost.Areas.Administration.Pages.Accounts.Account;

// [Authorize(Roles = Roles.Administrator)]//
public class IndexModel : PageModel
{
    [TempData]
    public string Message { get; set; }
    public AccountSearchModel SearchModel;
    public List<AccountViewModel> Accounts;
    public SelectList Roles;
    public CreateLog Createlog;
    private readonly IRoleApplication _roleApplication;
    private readonly IAccountApplication _accountApplication;
    private readonly ILogApplication _logApplication;

    public IndexModel(IAccountApplication accountApplication
        , IRoleApplication roleApplication
,
ILogApplication logApplication)
    {
        _roleApplication = roleApplication;
        _accountApplication = accountApplication;
        _logApplication = logApplication;
    }

    public void OnGet(AccountSearchModel searchModel)
    {
        Roles = new SelectList(_roleApplication.List(), "Id", "Name");
        Accounts = _accountApplication.Search(searchModel);
    }

    public IActionResult OnGetCreate()
    {
        var command = new RegisterAccount
        {
            Roles = _roleApplication.List()
        };
        return Partial("./Create", command);
    }

    public JsonResult OnPostCreate(RegisterAccount command)
    {
        var result = _accountApplication.Register(command);
        var account = _accountApplication.GetAccountBy(command.Username);


        //var log = new Log(account.Id, 1, "333");
        //_logRepository.Create(log);
        //_logRepository.SaveChange();



        return new JsonResult(result);
    }

    public IActionResult OnGetEdit(long id)
    {
        var account = _accountApplication.GetDetails(id);
        account.Roles = _roleApplication.List();
        return Partial("Edit", account);
    }

    public JsonResult OnPostEdit(EditAccount command)
    {
        var result = _accountApplication.Edit(command);
        return new JsonResult(result);
    }

    public IActionResult OnGetChangePassword(long id)
    {
        var command = new ChangePassword { Id = id };
        return Partial("ChangePassword", command);
    }

    public JsonResult OnPostChangePassword(ChangePassword command)
    {
        var result = _accountApplication.ChangePassword(command);
        return new JsonResult(result);
    }
}
