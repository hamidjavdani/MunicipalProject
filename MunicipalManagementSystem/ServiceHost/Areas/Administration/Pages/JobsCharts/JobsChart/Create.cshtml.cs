using AccountManagement.Application.Contracts.JobsChart;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Areas.Administration.Pages.JobsCharts.JobsChart;

public class CreateModel : PageModel
{
    public CreateJobsChart Command;
    public int idjobcChartlevel = 0;
    public string NamejobcChartlevel = "";
    private readonly IJobsChartApplication _jobschartApplication;

    public CreateModel(IJobsChartApplication jobschartApplication)
    {
        _jobschartApplication = jobschartApplication;
    }

    public void OnGet(int id, string parentname)
    {
        //  Command.JobsChartLevel = id;
        // Command.JobsChartName = parentname;
        idjobcChartlevel = id;
        NamejobcChartlevel = parentname;
    }

    public IActionResult OnPost(CreateJobsChart command)
    {
        var result = _jobschartApplication.Create(command);
        return RedirectToPage("Index");
    }
}
