using _0_Framework.Application;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Areas.Login.Pages;

public class IndexModel : PageModel
{
    private readonly IHttpContextAccessor _contextAccessor;

    private AuthViewModel currentAccount;

    private readonly IAuthHelper _authHelper;

    public IndexModel(IAuthHelper authHelper)
    {
        _authHelper = authHelper;

    }
    public void OnGet()
    {

    }
    public IActionResult OnPostLogin1()
    {

        currentAccount = _authHelper.CurrentAccountInfo();
        long userid = currentAccount.Id;

        //return Redirect(url: "http://172.20.32.7:2020/LoginSystem.aspx/?id=" + userid);
        return Redirect(url: "http://localhost:21267/Municipality2020/LoginSystem.aspx/?id=" + userid);

    }

    public IActionResult OnPostLogin2()
    {
        currentAccount = _authHelper.CurrentAccountInfo();
        long userid = currentAccount.Id;
        return Redirect(url: "http://172.20.32.7:2020/LoginSystem.aspx/?id=" + userid);

    }

}
