using AccountManagement.Application.Contracts.JobsChart;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ServiceHost.Areas.Administration.Pages.JobsCharts.JobsChart;

public class IndexModel : PageModel
{
    private readonly IJobsChartApplication _jobsChartApplication;
    public object nodedata;
    public IndexModel(IJobsChartApplication jobsChartApplication)
    {
        _jobsChartApplication = jobsChartApplication;
    }


    public void OnGet()
    {
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


    //public JsonResult OnPostCreate(long id)
    //{
    //    var jobsChart = _jobsChartApplication.GetDetails(id);
    //    //account.Roles = _roleApplication.List();
    //    return Partial("Edit", jobsChart);

    //}
    public IActionResult OnGetCreateJobs(long id)
    {
        var jobsChart = _jobsChartApplication.GetDetails(id);
        //account.Roles = _roleApplication.List();
        return Partial("Create", jobsChart);
    }
    public IActionResult OnGetEdit(long id)
    {
        var jobsChart = _jobsChartApplication.GetDetails(id);
        //account.Roles = _roleApplication.List();
        return Partial("Edit", jobsChart);
    }
}
