using AccountManagement.Application.Contracts.AccountJob;
using AccountManagement.Application.Contracts.JobsChart;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ServiceHost.Areas.Administration.Pages.AccountJobs.AccountJob;

public class CreateModel : PageModel
{
    private readonly IJobsChartApplication _jobsChartApplication;
    private readonly IAccountJobApplication _accountJobApplication;
    public object nodedata;
    public long _idaccount = 0;
    public long _idjob = 0;
    public string _accounname = "";
    public CreateAccountJob Command;
    public CreateModel(IJobsChartApplication jobsChartApplication,
        IAccountJobApplication accountJobApplication)
    {
        _jobsChartApplication = jobsChartApplication;
        _accountJobApplication = accountJobApplication;
    }


    public void OnGet(long idaccount, string accountname)
    {
        _idaccount = idaccount;
        _accounname = accountname;
        List<TreeViewModel> node = new List<TreeViewModel>();
        List<TreeViewModel> node1 = new List<TreeViewModel>();
        node.Add(new TreeViewModel
        {
            id = "1",
            text = "مدیریت شهری",
            parent = "#"
        });

        node1 = _jobsChartApplication.GetDataforTree();
        for (int i = 1; i < node1.Count; i++)
        {
            node.Add(new TreeViewModel
            {
                id = node1[i].id.ToString(),
                text = node1[i].text,
                parent = node1[i].parent.ToString()
            });

        }

        nodedata = JsonConvert.SerializeObject(node);

    }


    public IActionResult OnPost(CreateAccountJob command)
    {

        var result = _accountJobApplication.Create(command);
        return RedirectToPage("Index");
    }
}
