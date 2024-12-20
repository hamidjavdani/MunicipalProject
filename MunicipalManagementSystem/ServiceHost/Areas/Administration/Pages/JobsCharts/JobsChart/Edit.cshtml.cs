
using AccountManagement.Application.Contracts.JobsChart;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace ServiceHost.Areas.Administration.Pages.JobsCharts.JobsChart;

public class EditModel : PageModel
{
    public EditJobsChart Command;
    public int idjobcChartlevel = 0;
    public string NamejobcChartlevel = "";
    private readonly IJobsChartApplication _jobschartApplication;

    public EditModel(IJobsChartApplication jobschartApplication)
    {
        _jobschartApplication = jobschartApplication;
    }

    public void OnGet(int id, string parentname)
    {
        Command = _jobschartApplication.GetDetails(id);
        //  Command.JobsChartLevel = id;
        // Command.JobsChartName = parentname;
        idjobcChartlevel = Command.JobsChartLevel;
        NamejobcChartlevel = parentname;
    }
    public IActionResult OnPost(EditJobsChart command)
    {
        var result = _jobschartApplication.Edit(command);
        return RedirectToPage("Index");
    }

}
