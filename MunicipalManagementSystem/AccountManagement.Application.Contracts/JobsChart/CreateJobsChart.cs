using _0_Framework.Application;
using System.ComponentModel.DataAnnotations;
namespace AccountManagement.Application.Contracts.JobsChart;

public class CreateJobsChart
{
    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public string JobsChartName { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public string JobsChartDescription { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public int JobsChartLevel { get; set; }
}
